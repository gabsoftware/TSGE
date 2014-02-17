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
    using System.Drawing;
    using System.Linq;

    public class Player : ModelBase
    {
        /// <summary>
        /// Default Constructor
        /// </summary>
        public Player()
        {
            // Set player defaults..
            this.GameVersion = Terraria.LatestVersion;
            this.Name = "Player";
            this.Difficulty = 0;
            this.Hair = 0;
            this.IsMale = true;
            this.Health = 500;
            this.HealthMax = 500;
            this.Mana = 200;
            this.ManaMax = 200;
            this.IsHotbarLocked = false;
            this.File = string.Empty;

            // Set default colors..
            this.HairColor = Color.FromArgb(0xFF, 0xD7, 0x5A, 0x37);
            this.SkinColor = Color.FromArgb(0xFF, 0xFF, 0x7D, 0x4B);
            this.EyeColor = Color.FromArgb(0xFF, 0x69, 0x5A, 0x4B);
            this.ShirtColor = Color.FromArgb(0xFF, 0xAF, 0xA5, 0x8C);
            this.UndershirtColor = Color.FromArgb(0xFF, 0xA0, 0xB4, 0xD7);
            this.PantsColor = Color.FromArgb(0xFF, 0xFF, 0xE6, 0xAF);
            this.ShoesColor = Color.FromArgb(0xFF, 0xA0, 0x6A, 0x3C);

            // Prepare default data..
            this.Armor = new Item[3];
            this.Vanity = new Item[3];
            this.Accessories = new Item[5];
            this.SocialAccessories = new Item[5];
            this.Dye = new Item[8];
            this.Inventory = new Item[58];
            this.Bank1 = new Item[40];
            this.Bank2 = new Item[40];
            this.Buffs = new Buff[22];
            this.ServerEntries = new ServerEntry[200];

            var item = Terraria.Instance.Items.Single(i => i.NetID == 0);
            var buff = Terraria.Instance.Buffs.Single(b => b.Id == 0);

            for (var x = 0; x < this.Armor.Length; x++)
                this.Armor[x] = item.Clone() as Item;

            for (var x = 0; x < this.Vanity.Length; x++)
                this.Vanity[x] = item.Clone() as Item;

            for (var x = 0; x < this.Accessories.Length; x++)
                this.Accessories[x] = item.Clone() as Item;

            for (var x = 0; x < this.SocialAccessories.Length; x++)
                this.SocialAccessories[x] = item.Clone() as Item;

            for (var x = 0; x < this.Dye.Length; x++)
                this.Dye[x] = item.Clone() as Item;

            for (var x = 0; x < this.Inventory.Length; x++)
                this.Inventory[x] = item.Clone() as Item;

            for (var x = 0; x < this.Bank1.Length; x++)
                this.Bank1[x] = item.Clone() as Item;

            for (var x = 0; x < this.Bank2.Length; x++)
                this.Bank2[x] = item.Clone() as Item;

            for (var x = 0; x < this.Buffs.Length; x++)
                this.Buffs[x] = buff.Clone() as Buff;

            for (var x = 0; x < this.ServerEntries.Length; x++)
                this.ServerEntries[x] = new ServerEntry();
        }

        /// <summary>
        /// Gets or sets the profile file of this player.
        /// </summary>
        public string File
        {
            get { return this.Get<string>("File"); }
            set { this.Set("File", value); }
        }

        /// <summary>
        /// Gets or sets the game version of this player.
        /// </summary>
        public int GameVersion
        {
            get { return this.Get<int>("GameVersion"); }
            set { this.Set("GameVersion", value); }
        }

        /// <summary>
        /// Gets or sets the name of this player.
        /// </summary>
        public string Name
        {
            get { return this.Get<string>("Name"); }
            set { this.Set("Name", value); }
        }

        /// <summary>
        /// Gets or sets the difficulty of this player.
        /// </summary>
        public byte Difficulty
        {
            get { return this.Get<byte>("Difficulty"); }
            set { this.Set("Difficulty", value); }
        }

        /// <summary>
        /// Gets or sets the hair of this player.
        /// </summary>
        public int Hair
        {
            get { return this.Get<int>("Hair"); }
            set { this.Set("Hair", value); }
        }

        /// <summary>
        /// Gets or sets the hair dye of this player.
        /// </summary>
        public byte HairDye
        {
            get { return this.Get<byte>("HairDye"); }
            set { this.Set("HairDye", value); }
        }

        /// <summary>
        /// Gets or sets the hide visual flag of this player.
        /// </summary>
        public byte HideVisual
        {
            get { return this.Get<byte>("HideVisual"); }
            set { this.Set("HideVisual", value); }
        }

        /// <summary>
        /// Gets or sets the male flag of this player.
        /// </summary>
        public bool IsMale
        {
            get { return this.Get<bool>("IsMale"); }
            set { this.Set("IsMale", value); }
        }

        /// <summary>
        /// Gets or sets the health of this player.
        /// </summary>
        public int Health
        {
            get { return this.Get<int>("Health"); }
            set { this.Set("Health", value); }
        }

        /// <summary>
        /// Gets or sets the max health of this player.
        /// </summary>
        public int HealthMax
        {
            get { return this.Get<int>("HealthMax"); }
            set { this.Set("HealthMax", value); }
        }

        /// <summary>
        /// Gets or sets the mana of this player.
        /// </summary>
        public int Mana
        {
            get { return this.Get<int>("Mana"); }
            set { this.Set("Mana", value); }
        }

        /// <summary>
        /// Gets or sets the max mana of this player.
        /// </summary>
        public int ManaMax
        {
            get { return this.Get<int>("ManaMax"); }
            set { this.Set("ManaMax", value); }
        }

        /// <summary>
        /// Gets or sets the hair color of this player.
        /// </summary>
        public Color HairColor
        {
            get { return this.Get<Color>("HairColor"); }
            set { this.Set("HairColor", value); }
        }

        /// <summary>
        /// Gets or sets the skin color of this player.
        /// </summary>
        public Color SkinColor
        {
            get { return this.Get<Color>("SkinColor"); }
            set { this.Set("SkinColor", value); }
        }

        /// <summary>
        /// Gets or sets the eye color of this player.
        /// </summary>
        public Color EyeColor
        {
            get { return this.Get<Color>("EyeColor"); }
            set { this.Set("EyeColor", value); }
        }

        /// <summary>
        /// Gets or sets the shirt color of this player.
        /// </summary>
        public Color ShirtColor
        {
            get { return this.Get<Color>("ShirtColor"); }
            set { this.Set("ShirtColor", value); }
        }

        /// <summary>
        /// Gets or sets the undershirt color of this player.
        /// </summary>
        public Color UndershirtColor
        {
            get { return this.Get<Color>("UndershirtColor"); }
            set { this.Set("UndershirtColor", value); }
        }

        /// <summary>
        /// Gets or sets the pants color of this player.
        /// </summary>
        public Color PantsColor
        {
            get { return this.Get<Color>("PantsColor"); }
            set { this.Set("PantsColor", value); }
        }

        /// <summary>
        /// Gets or sets the shoes color of this player.
        /// </summary>
        public Color ShoesColor
        {
            get { return this.Get<Color>("ShoesColor"); }
            set { this.Set("ShoesColor", value); }
        }

        /// <summary>
        /// Gets or sets the armor items of this player.
        /// </summary>
        public Item[] Armor
        {
            get { return this.Get<Item[]>("Armor"); }
            set { this.Set("Armor", value); }
        }

        /// <summary>
        /// Gets or sets the vanity items of this player.
        /// </summary>
        public Item[] Vanity
        {
            get { return this.Get<Item[]>("Vanity"); }
            set { this.Set("Vanity", value); }
        }

        /// <summary>
        /// Gets or sets the accessory items of this player.
        /// </summary>
        public Item[] Accessories
        {
            get { return this.Get<Item[]>("Accessories"); }
            set { this.Set("Accessories", value); }
        }

        /// <summary>
        /// Gets or sets the social accessory items of this player.
        /// </summary>
        public Item[] SocialAccessories
        {
            get { return this.Get<Item[]>("SocialAccessories"); }
            set { this.Set("SocialAccessories", value); }
        }

        /// <summary>
        /// Gets or sets the dye items of this player.
        /// </summary>
        public Item[] Dye
        {
            get { return this.Get<Item[]>("Dye"); }
            set { this.Set("Dye", value); }
        }

        /// <summary>
        /// Gets or sets the inventory items of this player.
        /// </summary>
        public Item[] Inventory
        {
            get { return this.Get<Item[]>("Inventory"); }
            set { this.Set("Inventory", value); }
        }

        /// <summary>
        /// Gets or sets the bank1 items of this player.
        /// </summary>
        public Item[] Bank1
        {
            get { return this.Get<Item[]>("Bank1"); }
            set { this.Set("Bank1", value); }
        }

        /// <summary>
        /// Gets or sets the bank2 items of this player.
        /// </summary>
        public Item[] Bank2
        {
            get { return this.Get<Item[]>("Bank2"); }
            set { this.Set("Bank2", value); }
        }

        /// <summary>
        /// Gets or sets the buffs of this player.
        /// </summary>
        public Buff[] Buffs
        {
            get { return this.Get<Buff[]>("Buffs"); }
            set { this.Set("Buffs", value); }
        }

        /// <summary>
        /// Gets or sets the server entries of this player.
        /// </summary>
        public ServerEntry[] ServerEntries
        {
            get { return this.Get<ServerEntry[]>("ServerEntries"); }
            set { this.Set("ServerEntries", value); }
        }

        /// <summary>
        /// Gets or sets the is hotbar locked flag of this player.
        /// </summary>
        public bool IsHotbarLocked
        {
            get { return this.Get<bool>("IsHotbarLocked"); }
            set { this.Set("IsHotbarLocked", value); }
        }
    }
}
