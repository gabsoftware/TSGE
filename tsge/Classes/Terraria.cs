// -----------------------------------------------------------------------
//    This file is part of TSGE.
//
//    TSGE is free software: you can redistribute it and/or modify
//    it under the terms of the GNU General Public License as published by
//    the Free Software Foundation, either version 3 of the License, or
//    (at your option) any later version.
//
//    TSGE is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//    GNU General Public License for more details.
//
//    You should have received a copy of the GNU General Public License
//    along with TSGE.  If not, see <http://www.gnu.org/licenses/>.
// -----------------------------------------------------------------------

namespace tsge.Classes
{
    using Comparers;
    using Extensions;
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.IO;
    using System.Linq;
    using System.Security.Cryptography;
    using System.Text;
    using System.Windows.Forms;
    using System.Xml.Serialization;

    public class Terraria
    {
        /// <summary>
        /// Singleton instance of this class.
        /// </summary>
        private static Terraria m_Instance;

        /// <summary>
        /// Internal buff list.
        /// </summary>
        private List<Buff> m_BuffList;

        /// <summary>
        /// Internal item list.
        /// </summary>
        private List<Item> m_ItemList;

        /// <summary>
        /// Internal item prefix list.
        /// </summary>
        private List<ItemPrefix> m_PrefixList;

        /// <summary>
        /// Current supported game version.
        /// </summary>
        public static List<int> GameVersions = new List<int>(new[] { 38, 47, 58, 68, 69, 70, 71, 72, 73, 77, 81, 83, 93 });

        /// <summary>
        /// The latest supported version of Terraria.
        /// </summary>
        public static int LatestVersion = 93;

        /// <summary>
        /// Profile path to the Terraria save game files.
        /// </summary>
        public static string ProfilePath = string.Join(
            Path.DirectorySeparatorChar.ToString(),
            new[]
                {
                    Environment.GetFolderPath(Environment.SpecialFolder.Personal),
                    "My Games", "Terraria", "Players"
                });

        /// <summary>
        /// Encryption key used to encrypt and decrypt player files.
        /// </summary>
        private const string ENCRYPTION_KEY = "h3y_gUyZ";

        /// <summary>
        /// Encryption key converted to byte data for crypto provider.
        /// </summary>
        private static readonly byte[] ENCRYPTION_DATA = Encoding.Unicode.GetBytes(ENCRYPTION_KEY);

        /// <summary>
        /// Default Constructor
        /// </summary>
        public Terraria()
        {
            // Initialize internl lists..
            this.m_BuffList = new List<Buff>();
            this.m_ItemList = new List<Item>();
            this.m_PrefixList = new List<ItemPrefix>();
            this.HairFiles = new List<string>();
        }

        /// <summary>
        /// Gets the singleton instance of this class.
        /// </summary>
        public static Terraria Instance
        {
            get { return m_Instance ?? (m_Instance = new Terraria()); }
        }

        /// <summary>
        /// Initializes the Terraria class.
        /// </summary>
        /// <returns></returns>
        public bool Initialize()
        {
            // Load buff list..
            using (var fStream = new FileStream("Data\\_bufflist.xml", FileMode.Open, FileAccess.Read))
            {
                var xls = new XmlSerializer(typeof(Buff[]));
                this.Buffs = ((Buff[])xls.Deserialize(fStream)).ToList();
            }

            // Load item list..
            using (var fStream = new FileStream("Data\\_itemlist.xml", FileMode.Open, FileAccess.Read))
            {
                var xls = new XmlSerializer(typeof(Item[]));
                this.m_ItemList = ((Item[])xls.Deserialize(fStream)).ToList();
            }

            // Load item prefix list..
            using (var fStream = new FileStream("Data\\_prefixlist.xml", FileMode.Open, FileAccess.Read))
            {
                var xls = new XmlSerializer(typeof(ItemPrefix[]));
                this.Prefixes = ((ItemPrefix[])xls.Deserialize(fStream)).ToList();
            }

            // Load the hair style list..
            var dir = new DirectoryInfo("Data\\Hair");
            var files = (from FileInfo f in dir.GetFiles("*.png")
                         where f.FullName.Contains("_alt_") == false
                         select f).ToList().OrderBy(file => file, new NaturalFileInfoNameComparer());

            foreach (var f in files)
                this.HairFiles.Add(f.Name);


            return (this.Buffs != null && this.m_ItemList != null && this.m_PrefixList != null);
        }

        /// <summary>
        /// Decrypts the given player profile and returns the data as an array.
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        private static byte[] DecryptProfile(string fileName)
        {
            try
            {
                using (var fStream = new FileStream(fileName, FileMode.Open, FileAccess.Read))
                {
                    var rjm = new RijndaelManaged();
                    using (var cStream = new CryptoStream(fStream, rjm.CreateDecryptor(ENCRYPTION_DATA, ENCRYPTION_DATA), CryptoStreamMode.Read))
                    {
                        using (var mStream = new MemoryStream())
                        {
                            int dataRead;
                            while ((dataRead = cStream.ReadByte()) != -1)
                                mStream.WriteByte((byte)dataRead);
                            return mStream.GetBuffer().Clone() as byte[];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Failed to decrypt profile; error was:\r\n\r\n{0}", ex), "Error!");
                return default(byte[]);
            }
        }

        /// <summary>
        /// Encrypts the given player profile.
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        private static bool EncryptProfile(string fileName)
        {
            try
            {
                using (var fStreamOut = new FileStream(fileName, FileMode.Create, FileAccess.Write))
                {
                    var rjm = new RijndaelManaged();
                    using (var cStream = new CryptoStream(fStreamOut, rjm.CreateEncryptor(ENCRYPTION_DATA, ENCRYPTION_DATA), CryptoStreamMode.Write))
                    {
                        using (var fStreamTmp = new FileStream(fileName + ".tmp", FileMode.Open, FileAccess.Read))
                        {
                            int dataRead;
                            while ((dataRead = fStreamTmp.ReadByte()) != -1)
                                cStream.WriteByte((byte)dataRead);
                            return true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Failed to encrypt profile; error was:\r\n\r\n{0}", ex), "Error!");
                return false;
            }
        }

        /// <summary>
        /// Attempts to decrypt and load a player file.
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public Player LoadProfile(string fileName)
        {
            try
            {
                // Attempt to decrypt the player file..
                var playerData = DecryptProfile(fileName);
                if (playerData == null)
                    return default(Player);

                // Attempt to read the player file..
                using (var mStream = new MemoryStream(playerData))
                {
                    using (var bReader = new BinaryReader(mStream))
                    {
                        // Create the new player object..
                        var p = new Player { GameVersion = bReader.ReadInt32() };

                        // Ensure game version is valid..
                        if (p.GameVersion < Terraria.GameVersions.Min() || p.GameVersion > Terraria.GameVersions.Max())
                            throw new InvalidDataException("GameVersion does not match the supported value!");

                        // Read basic player info..
                        p.Name = bReader.ReadString();
                        p.Difficulty = bReader.ReadByte();
                        p.Hair = bReader.ReadInt32();

                        // Hair Dye
                        if (p.GameVersion >= 82)
                            bReader.ReadByte();

                        // Hide Visual
                        if (p.GameVersion >= 83)
                            bReader.ReadByte();

                        p.IsMale = bReader.ReadBoolean();
                        p.Health = bReader.ReadInt32();
                        p.HealthMax = bReader.ReadInt32();
                        p.Mana = bReader.ReadInt32();
                        p.ManaMax = bReader.ReadInt32();

                        // Read character colors..
                        p.HairColor = new Color().FromBytes(bReader.ReadBytes(3));
                        p.SkinColor = new Color().FromBytes(bReader.ReadBytes(3));
                        p.EyeColor = new Color().FromBytes(bReader.ReadBytes(3));
                        p.ShirtColor = new Color().FromBytes(bReader.ReadBytes(3));
                        p.UndershirtColor = new Color().FromBytes(bReader.ReadBytes(3));
                        p.PantsColor = new Color().FromBytes(bReader.ReadBytes(3));
                        p.ShoesColor = new Color().FromBytes(bReader.ReadBytes(3));

                        // Read Armor..
                        for (var x = 0; x < 3; x++)
                        {
                            p.Armor[x].SetItem(bReader.ReadInt32());
                            p.Armor[x].Prefix = bReader.ReadByte();
                        }

                        // Read accessories..
                        for (var x = 0; x < 5; x++)
                        {
                            p.Accessories[x].SetItem(bReader.ReadInt32());
                            p.Accessories[x].Prefix = bReader.ReadByte();
                        }

                        // Read vanity items..
                        for (var x = 0; x < 3; x++)
                        {
                            p.Vanity[x].SetItem(bReader.ReadInt32());
                            p.Vanity[x].Prefix = bReader.ReadByte();
                        }

                        // TODO: Handle new social equipment slots..
                        for (var x = 0; x < 5; x++)
                        {
                            bReader.ReadInt32();
                            bReader.ReadByte();
                        }

                        // Read dye items..
                        if (p.GameVersion >= 47)
                        {
                            var dyeCount = (p.GameVersion >= 81) ? 8 : 3;
                            for (var x = 0; x < dyeCount; x++)
                            {
                                p.Dye[x].SetItem(bReader.ReadInt32());
                                p.Dye[x].Prefix = bReader.ReadByte();
                            }
                        }

                        // Read inventory..
                        for (var x = 0; x < ((p.GameVersion >= 58) ? 58 : 48); x++)
                        {
                            var temp = bReader.ReadInt32();
                            if (temp >= 2289)
                                p.Inventory[x].SetItem(0);
                            else
                            {
                                p.Inventory[x].SetItem(temp);
                                p.Inventory[x].Count = bReader.ReadInt32();
                                p.Inventory[x].Prefix = bReader.ReadByte();
                            }
                        }

                        // Read Bank1..
                        for (var x = 0; x < ((p.GameVersion >= 58) ? 40 : 20); x++)
                        {
                            p.Bank1[x].SetItem(bReader.ReadInt32());
                            p.Bank1[x].Count = bReader.ReadInt32();
                            p.Bank1[x].Prefix = bReader.ReadByte();
                        }

                        // Read Bank2..
                        for (var x = 0; x < ((p.GameVersion >= 58) ? 40 : 20); x++)
                        {
                            p.Bank2[x].SetItem(bReader.ReadInt32());
                            p.Bank2[x].Count = bReader.ReadInt32();
                            p.Bank2[x].Prefix = bReader.ReadByte();
                        }

                        // Read Buffs..
                        var buffCount = (p.GameVersion < 74) ? 10 : 22;
                        for (var x = 0; x < buffCount; x++)
                        {
                            p.Buffs[x].SetBuff(bReader.ReadInt32());
                            p.Buffs[x].Duration = bReader.ReadInt32();
                        }

                        // Read Server Entries..
                        for (var x = 0; x < 200; x++)
                        {
                            var temp = bReader.ReadInt32();
                            if (temp == -1) break;

                            p.ServerEntries[x].SpawnX = temp;
                            p.ServerEntries[x].SpawnY = bReader.ReadInt32();
                            p.ServerEntries[x].ServerAddress = bReader.ReadInt32();
                            p.ServerEntries[x].ServerName = bReader.ReadString();
                        }

                        // Read Hotbar Locked Flag..
                        p.IsHotbarLocked = bReader.ReadBoolean();

                        // Force the new profile to latest version..
                        p.GameVersion = Terraria.LatestVersion;
                        return p;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Failed to load profile; error was:\r\n\r\n{0}", ex), "Error!");
                return default(Player);
            }
        }

        /// <summary>
        /// Attempts to obtain the profiles name.
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public string GetProfileName(string fileName)
        {
            // Attempt to decrypt the player file..
            var playerData = DecryptProfile(fileName);
            if (playerData == null)
                return string.Empty;

            // Attempt to read the name..
            try
            {
                using (var mStream = new MemoryStream(playerData))
                {
                    using (var bReader = new BinaryReader(mStream))
                    {
                        bReader.ReadInt32(); // GameVersion
                        return bReader.ReadString();
                    }
                }
            }
            catch
            {
                return string.Empty;
            }
        }

        /// <summary>
        /// Attempts to encrypt and save a player object.
        /// </summary>
        /// <param name="player"></param>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public bool SaveProfile(Player player, string fileName)
        {
            FileStream fStream = null;
            BinaryWriter bWriter = null;

            try
            {
                // Open or create temp file to write to..
                fStream = new FileStream(fileName + ".tmp", FileMode.OpenOrCreate, FileAccess.Write);
                bWriter = new BinaryWriter(fStream);

                // Write the game version..
                bWriter.Write(player.GameVersion);

                // Write basic player info..
                bWriter.Write(player.Name);
                bWriter.Write(player.Difficulty);
                bWriter.Write(player.Hair);

                // TODO: Handle hair dye / visual flags..
                bWriter.Write((byte)0);
                bWriter.Write((byte)0);

                bWriter.Write(player.IsMale);
                bWriter.Write(player.Health);
                bWriter.Write(player.HealthMax);
                bWriter.Write(player.Mana);
                bWriter.Write(player.ManaMax);

                // Write player colors..
                bWriter.Write(player.HairColor.ToBytes());
                bWriter.Write(player.SkinColor.ToBytes());
                bWriter.Write(player.EyeColor.ToBytes());
                bWriter.Write(player.ShirtColor.ToBytes());
                bWriter.Write(player.UndershirtColor.ToBytes());
                bWriter.Write(player.PantsColor.ToBytes());
                bWriter.Write(player.ShoesColor.ToBytes());

                // Write player armor..
                for (var x = 0; x < 3; x++)
                {
                    bWriter.Write(player.Armor[x].NetID);
                    bWriter.Write(player.Armor[x].Prefix);
                }

                // Write player accessories..
                for (var x = 0; x < 5; x++)
                {
                    bWriter.Write(player.Accessories[x].NetID);
                    bWriter.Write(player.Accessories[x].Prefix);
                }

                // Write player vanity items..
                for (var x = 0; x < 3; x++)
                {
                    bWriter.Write(player.Vanity[x].NetID);
                    bWriter.Write(player.Vanity[x].Prefix);
                }

                // TODO: Handle new social equipment slots..
                for (var x = 0; x < 5; x++)
                {
                    bWriter.Write((int)0);
                    bWriter.Write((byte)0);
                }

                // Write player dye..
                for (var x = 0; x < 8; x++)
                {
                    bWriter.Write(player.Dye[x].NetID);
                    bWriter.Write(player.Dye[x].Prefix);
                }

                // Write player inventory..
                for (var x = 0; x < 58; x++)
                {
                    bWriter.Write(player.Inventory[x].NetID);
                    bWriter.Write(player.Inventory[x].Count);
                    bWriter.Write(player.Inventory[x].Prefix);
                }

                // Write player bank1..
                for (var x = 0; x < 40; x++)
                {
                    bWriter.Write(player.Bank1[x].NetID);
                    bWriter.Write(player.Bank1[x].Count);
                    bWriter.Write(player.Bank1[x].Prefix);
                }

                // Write player bank2..
                for (var x = 0; x < 40; x++)
                {
                    bWriter.Write(player.Bank2[x].NetID);
                    bWriter.Write(player.Bank2[x].Count);
                    bWriter.Write(player.Bank2[x].Prefix);
                }

                // Write player buffs..
                var buffCount = (player.GameVersion < 74) ? 10 : 22;
                for (var x = 0; x < buffCount; x++)
                {
                    bWriter.Write(player.Buffs[x].Id);
                    bWriter.Write(player.Buffs[x].Duration);
                }

                // Write server entries..
                for (var x = 0; x < 200; x++)
                {
                    if (player.ServerEntries[x].SpawnX == -1)
                    {
                        bWriter.Write(player.ServerEntries[x].SpawnX);
                        break;
                    }

                    bWriter.Write(player.ServerEntries[x].SpawnX);
                    bWriter.Write(player.ServerEntries[x].SpawnY);
                    bWriter.Write(player.ServerEntries[x].ServerAddress);
                    bWriter.Write(player.ServerEntries[x].ServerName);
                }

                // Write hotbar locked flag..
                bWriter.Write(player.IsHotbarLocked);

                // Cleanup..
                bWriter.Close();
                fStream.Close();

                // Encrypt the file and save it to real path..
                var ret = EncryptProfile(fileName);

                // Delete the temp file..
                File.Delete(fileName + ".tmp");
                return ret;
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Failed to save profile; error was:\r\n\r\n{0}", ex), "Error!");
                return false;
            }
            finally
            {
                // Ensure streams are cleaned up..
                if (bWriter != null)
                    bWriter.Close();
                if (fStream != null)
                    fStream.Close();
            }
        }

        /// <summary>
        /// Gets or sets the list of buffs.
        /// </summary>
        public List<Buff> Buffs
        {
            get
            {
                if (this.m_BuffList != null && this.m_BuffList.Count > 0)
                    this.m_BuffList.Sort(new NaturalBuffNameComparer());
                return this.m_BuffList;
            }
            set { this.m_BuffList = value; }
        }

        /// <summary>
        /// Gets or sets the list of Items.
        /// </summary>
        public List<Item> Items
        {
            get
            {
                if (this.m_ItemList != null && this.m_ItemList.Count > 0)
                    this.m_ItemList.Sort(new NaturalItemNameComparer());

                if (this.m_ItemList == null)
                    return null;

                var items = this.m_ItemList;
                return new List<Item>((Item[])items.ToArray().Clone());
            }
        }

        /// <summary>
        /// Gets or sets the list of Prefixes.
        /// </summary>
        public List<ItemPrefix> Prefixes
        {
            get
            {
                if (this.m_PrefixList != null && this.m_PrefixList.Count > 0)
                    this.m_PrefixList.Sort(new NaturalItemPrefixNameComparer());

                if (this.m_PrefixList == null)
                    return null;

                var prefixes = this.m_PrefixList;
                return new List<ItemPrefix>((ItemPrefix[])prefixes.ToArray().Clone());
            }
            set { this.m_PrefixList = value; }
        }

        /// <summary>
        /// Gets or sets the hair file list.
        /// </summary>
        public List<string> HairFiles { get; set; }
    }
}
