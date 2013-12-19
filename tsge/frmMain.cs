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

namespace tsge
{
    using Classes;
    using Comparers;
    using Controls;
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Drawing;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Reflection;
    using System.Windows.Forms;
    using System.Xml.Linq;

    public partial class frmMain : Form
    {
        /// <summary>
        /// Tooltip object to attach helpful text to controls.
        /// </summary>
        private readonly ToolTip m_Tooltip;

        /// <summary>
        /// The current player object being edited.
        /// </summary>
        public Player Player { get; set; }

        /// <summary>
        /// Internal list of all inventory item labels.
        /// </summary>
        private readonly List<ItemLabel> m_InventoryLabels;

        /// <summary>
        /// Internal list of all equipment item labels.
        /// </summary>
        private readonly List<ItemLabel> m_EquipmentLabels;

        /// <summary>
        /// Internal list of all bank and safe item labels.
        /// </summary>
        private readonly List<ItemLabel> m_BankSafeLabels;

        /// <summary>
        /// The currently selected inventory item.
        /// </summary>
        public Label m_SelectedInventoryItem;

        /// <summary>
        /// The currently selected equipment item.
        /// </summary>
        public Label m_SelectedEquipmentItem;

        /// <summary>
        /// The currently selected bank/safe item.
        /// </summary>
        public Label m_SelectedBankSafeItem;

        /// <summary>
        /// Default Constructor
        /// </summary>
        public frmMain()
        {
            InitializeComponent();

            // Set the default size..
            this.Width = DpiHelper.ScaleAsDpi(628);
            this.Height = DpiHelper.ScaleAsDpi(493);

            // Initialize the Terraria class..
            Terraria.Instance.Initialize();

            // Set data source to various lists..
            this.lstBuffSelection.DataSource = Terraria.Instance.Buffs;
            this.lstInventoryItems.DataSource = Terraria.Instance.Items;
            this.lstBankSafeItems.DataSource = Terraria.Instance.Items;
            this.cboInventoryPrefix.DataSource = Terraria.Instance.Prefixes;
            this.cboEquipmentPrefix.DataSource = Terraria.Instance.Prefixes;
            this.cboBankSafePrefix.DataSource = Terraria.Instance.Prefixes;

            // Initialize tooltip object..
            this.m_Tooltip = new ToolTip();

            // Initialize internal item label lists..
            this.m_InventoryLabels = new List<ItemLabel>();
            this.m_EquipmentLabels = new List<ItemLabel>();
            this.m_BankSafeLabels = new List<ItemLabel>();

            var nullItemIcon = new Bitmap(Application.StartupPath + "\\Data\\Items\\item_0.png");
            var nullItemName = Terraria.Instance.Items.Single(i => i.NetID == 0).ToString();

            // Prepare inventory item label list..
            for (var x = 0; x < 58; x++)
            {
                // Find the label..
                var label = (ItemLabel)this.Controls.Find(string.Format("inventoryItem{0:d2}", x), true)[0];
                this.m_InventoryLabels.Add(label);

                // Update the label defaults..
                label.Image = nullItemIcon;
                label.Text = "0";
                label.Tag = x;

                // Set the default tooltip..
                this.m_Tooltip.SetToolTip(label, nullItemName);
            }

            // Prepare equipment item label list..
            for (var x = 0; x < 14; x++)
            {
                // Find the label..
                var label = (ItemLabel)this.Controls.Find(string.Format("equipmentItem{0:d2}", x), true)[0];
                this.m_EquipmentLabels.Add(label);

                // Update the label defaults.
                label.ShowItemCount = false;
                label.Image = nullItemIcon;
                label.Text = "";
                label.Tag = x;

                // Set the default tooltip..
                this.m_Tooltip.SetToolTip(label, nullItemName);
            }

            // Prepare the bank/safe label list..
            for (var x = 0; x < 80; x++)
            {
                // Find the label..
                var label = (ItemLabel)this.Controls.Find(string.Format("bankSafeItem{0:d2}", x), true)[0];
                this.m_BankSafeLabels.Add(label);

                // Update the label defaults..
                label.Image = nullItemIcon;
                label.Text = "0";
                label.Tag = x;

                // Set the default tooltip..
                this.m_Tooltip.SetToolTip(label, nullItemName);
            }

            // Initialize the default player object..
            this.modelViewer.SuspendModelUpdates();
            this.Player = new Player
                {
                    EyeColor = this.pbEyesColor.BackColor = Color.FromArgb(255, 105, 90, 75),
                    HairColor = this.pbHairColor.BackColor = Color.FromArgb(255, 215, 90, 55),
                    SkinColor = this.pbSkinColor.BackColor = Color.FromArgb(255, 255, 125, 75),
                    PantsColor = this.pbPantsColor.BackColor = Color.FromArgb(255, 255, 230, 175),
                    ShirtColor = this.pbShirtColor.BackColor = Color.FromArgb(255, 175, 165, 140),
                    ShoesColor = this.pbShoesColor.BackColor = Color.FromArgb(255, 160, 106, 60),
                    UndershirtColor = this.pbUndershirtColor.BackColor = Color.FromArgb(255, 160, 180, 215)
                };

            // Set the binding object data source..
            playerBindingSource.DataSource = this.Player;
            this.modelViewer.ResumeModelUpdates();
        }

        /// <summary>
        /// Creates a filtered item list.
        /// </summary>
        /// <param name="nameFilter"></param>
        /// <param name="categoryFilter"></param>
        /// <returns></returns>
        private static IEnumerable<Item> CreateFilteredItemList(string nameFilter, int categoryFilter)
        {
            // Should we filter by name first..?
            var items = Terraria.Instance.Items;
            if (!string.IsNullOrEmpty(nameFilter))
                items = items.Where(i => i.Name.ToLower().Contains(nameFilter.ToLower()) || i.NetID == 0).ToList();

            // Next filter by category..
            switch (categoryFilter)
            {
                case 0: // All
                    break;
                case 1: // Armor / Social Gear
                    {
                        items = items.Where(i => i.WornArmor || i.Social || i.Vanity || i.HeadSlot > -1 || i.BodySlot > -1 || i.LegSlot > -1 || i.NetID == 0).ToList();
                        break;
                    }
                case 2: // Accessories
                    {
                        items = items.Where(i => i.Accessory || i.NetID == 0).ToList();
                        break;
                    }
                case 3: // Ammunition
                    {
                        items = items.Where(i => i.Ammo > 0 || i.NetID == 0).ToList();
                        break;
                    }
                case 4: // Building Objects
                    {
                        items = items.Where(i => i.HeadSlot <= 0 && i.BodySlot <= 0 && i.LegSlot <= 0 && i.Ammo <= 0 && i.Material || i.NetID == 0).ToList();
                        break;
                    }
                case 5: // Consumables
                    {
                        items = items.Where(i => i.Consumable || i.NetID == 0).ToList();
                        break;
                    }
                case 6: // Money
                    {
                        items = items.Where(i => i.Name.ToLower().Contains("coin") || i.NetID == 0).ToList();
                        break;
                    }
                case 7: // Tools
                    {
                        items = items.Where(i => i.Axe > 0 || i.Hammer > 0 || i.Pick > 0 || i.NetID == 0).ToList();
                        break;
                    }
                case 8: // Weapons
                    {
                        items = items.Where(i => i.HeadSlot <= 0 && i.BodySlot <= 0 && i.LegSlot <= 0 && i.Ammo <= 0 &&
                                                 !i.WornArmor && !i.Accessory && !i.Social && !i.Vanity &&
                                                 !i.Consumable || i.NetID == 0).ToList();
                        break;
                    }
            }

            // Return the filtered list..
            return items;
        }

        /// <summary>
        /// Creates a filtered item prefix list.
        /// </summary>
        /// <param name="categoryFilter"></param>
        /// <returns></returns>
        private static IEnumerable<ItemPrefix> CreateFilteredPrefixList(int categoryFilter)
        {
            // Filter the prefix list..
            var items = Terraria.Instance.Prefixes;
            switch (categoryFilter)
            {
                case 0: // All
                    break;
                case 1: // Universal
                    items = items.Where(i => i.Category == -1 || i.Category == 0).ToList();
                    break;
                case 2: // Common
                    items = items.Where(i => i.Category == -1 || i.Category == 1).ToList();
                    break;
                case 3: // Melee
                    items = items.Where(i => i.Category == -1 || i.Category == 2).ToList();
                    break;
                case 4: // Ranged
                    items = items.Where(i => i.Category == -1 || i.Category == 3).ToList();
                    break;
                case 5: // Magic
                    items = items.Where(i => i.Category == -1 || i.Category == 4).ToList();
                    break;
                case 6: // Accessories
                    items = items.Where(i => i.Category == -1 || i.Category == 5).ToList();
                    break;
            }

            return items;
        }

        /// <summary>
        /// Updates the selected equipment label with the given item info.
        /// </summary>
        /// <param name="label"></param>
        /// <param name="item"></param>
        private void UpdateEquipmentLabel(ItemLabel label, Item item)
        {
            label.Image = new Bitmap(string.Format("{0}\\Data\\Items\\item_{1}.png", Application.StartupPath, item.NetID));
            this.m_Tooltip.SetToolTip(label, item.ToString());
        }

        /// <summary>
        /// Refreshes the non-bound UI items.
        /// </summary>
        private void RefreshLoadedPlayer()
        {
            // Update the inventory..
            foreach (var label in this.m_InventoryLabels)
            {
                label.Image = new Bitmap(string.Format("{0}\\Data\\Items\\item_{1}.png", Application.StartupPath, this.Player.Inventory[(int)label.Tag].NetID));
                label.Text = this.Player.Inventory[(int)label.Tag].Count.ToString();
                this.m_Tooltip.SetToolTip(label, this.Player.Inventory[(int)label.Tag].ToString());
            }

            // Update the equipment..
            UpdateEquipmentLabel(this.m_EquipmentLabels[00], this.Player.Armor[0]);
            UpdateEquipmentLabel(this.m_EquipmentLabels[01], this.Player.Armor[1]);
            UpdateEquipmentLabel(this.m_EquipmentLabels[02], this.Player.Armor[2]);
            UpdateEquipmentLabel(this.m_EquipmentLabels[03], this.Player.Vanity[0]);
            UpdateEquipmentLabel(this.m_EquipmentLabels[04], this.Player.Vanity[1]);
            UpdateEquipmentLabel(this.m_EquipmentLabels[05], this.Player.Vanity[2]);
            UpdateEquipmentLabel(this.m_EquipmentLabels[06], this.Player.Dye[0]);
            UpdateEquipmentLabel(this.m_EquipmentLabels[07], this.Player.Dye[1]);
            UpdateEquipmentLabel(this.m_EquipmentLabels[08], this.Player.Dye[2]);
            UpdateEquipmentLabel(this.m_EquipmentLabels[09], this.Player.Accessories[0]);
            UpdateEquipmentLabel(this.m_EquipmentLabels[10], this.Player.Accessories[1]);
            UpdateEquipmentLabel(this.m_EquipmentLabels[11], this.Player.Accessories[2]);
            UpdateEquipmentLabel(this.m_EquipmentLabels[12], this.Player.Accessories[3]);
            UpdateEquipmentLabel(this.m_EquipmentLabels[13], this.Player.Accessories[4]);

            // Update the bank/safe..
            for (var x = 0; x < this.m_BankSafeLabels.Count; x++)
            {
                // Update the item label..
                var item = (x < 40) ? this.Player.Bank1[x] : this.Player.Bank2[x - 40];
                this.m_BankSafeLabels[x].Image = new Bitmap(string.Format("{0}\\Data\\Items\\item_{1}.png", Application.StartupPath, item.NetID));
                this.m_BankSafeLabels[x].Text = item.Count.ToString();
                this.m_Tooltip.SetToolTip(this.m_BankSafeLabels[x], item.ToString());
            }
        }

        #region "==> Menu Command Handlers"

        /// <summary>
        /// Fills the quick-select character box with known profiles.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tscboQuickSelect_DropDown(object sender, EventArgs e)
        {
            // Clear the current items..
            this.tscboQuickSelect.Items.Clear();

            // Find all current profiles..
            var dir = new DirectoryInfo(Terraria.ProfilePath);
            var files = dir.GetFiles("*.plr").OrderBy(f => f, new NaturalFileInfoNameComparer());

            // Insert each file into the combobox..
            foreach (var f in files)
            {
                var name = Terraria.Instance.GetProfileName(f.FullName);
                if (string.IsNullOrEmpty(name))
                    name = f.Name;
                this.tscboQuickSelect.Items.Add(string.Format("{0} -- {1}", name, f.Name));
            }
        }

        /// <summary>
        /// Attempts to load the quick-selected character.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tscboQuickSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Attempt to get the file name from the list..
            var selectedItem = this.tscboQuickSelect.SelectedItem;
            var file = selectedItem.ToString().Split(new[] { " -- " }, StringSplitOptions.RemoveEmptyEntries)[1];

            if (string.IsNullOrEmpty(file))
                return;

            // Attempt to load the profile..
            this.Player = Terraria.Instance.LoadProfile(string.Format("{0}\\{1}", Terraria.ProfilePath, file));
            if (this.Player == null)
            {
                this.Player = new Player();
                this.playerBindingSource.DataSource = this.Player;
                this.modelViewer.UpdateTextures();
                return;
            }

            this.Player.File = string.Format("{0}\\{1}", Terraria.ProfilePath, file);
            this.playerBindingSource.DataSource = this.Player;
            this.modelViewer.UpdateTextures();
            this.RefreshLoadedPlayer();
        }

        /// <summary>
        /// Creates a new player profile.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newCharacterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Player = new Player();
            this.playerBindingSource.DataSource = this.Player;
            this.RefreshLoadedPlayer();
        }

        /// <summary>
        /// Opens an existing profile.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                ofd.AddExtension = true;
                ofd.CheckFileExists = true;
                ofd.CheckPathExists = true;
                ofd.DefaultExt = "plr";
                ofd.Filter = "Terraria Player Files (*.plr)|*.plr|All files (*.*)|*.*";
                ofd.InitialDirectory = Terraria.ProfilePath;
                ofd.ValidateNames = true;

                if (ofd.ShowDialog() != DialogResult.OK)
                    return;

                // Load the profile..
                this.Player = Terraria.Instance.LoadProfile(ofd.FileName);
                if (this.Player == null)
                {
                    this.Player = new Player();
                    this.playerBindingSource.DataSource = this.Player;
                    this.modelViewer.UpdateTextures();
                    return;
                }

                this.Player.File = ofd.FileName;
                this.playerBindingSource.DataSource = this.Player;
                this.modelViewer.UpdateTextures();
                this.RefreshLoadedPlayer();
            }
        }

        /// <summary>
        /// Saves a profile to its known location.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Execute save-as if we have no file..
            if (string.IsNullOrEmpty(this.Player.File))
            {
                saveAsToolStripMenuItem_Click(sender, e);
                return;
            }

            // Save the profile..
            Terraria.Instance.SaveProfile(this.Player, this.Player.File);
        }

        /// <summary>
        /// Saves a profile to the selected location.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var sfd = new SaveFileDialog())
            {
                sfd.AddExtension = true;
                sfd.CheckPathExists = true;
                sfd.DefaultExt = "plr";
                sfd.Filter = "Terraria Player Files (*.plr)|*.plr|All files (*.*)|*.*";
                sfd.InitialDirectory = Terraria.ProfilePath;
                sfd.ValidateNames = true;

                if (sfd.ShowDialog() != DialogResult.OK)
                    return;

                // Save the profile..
                this.Player.File = sfd.FileName;
                Terraria.Instance.SaveProfile(this.Player, this.Player.File);
            }
        }

        /// <summary>
        /// Exits this appliction.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Displays the about form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutTSGEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var aboutForm = new frmAbout())
            {
                aboutForm.ShowDialog();
            }
        }

        /// <summary>
        /// Checks for updates.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkForUpdatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Attempt to download the latest info..
                var client = new WebClient();
                var latest = client.DownloadString("https://raw.github.com/atom0s/TSGE/master/latest.txt");
                if (string.IsNullOrEmpty(latest))
                    throw new Exception("No update found!");

                // Attempt to get the update parts..
                var parts = latest.Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                if (parts.Length != 2)
                    throw new Exception("No update found!");

                // See if we have the latest version..
                if (Assembly.GetExecutingAssembly().GetName().Version < new Version(parts[0]))
                {
                    // Update found..
                    var ret = MessageBox.Show("Update available!\r\nVersion: " + parts[0], "Update available!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (ret == DialogResult.Yes)
                        Process.Start(parts[1]);
                    return;
                }

                MessageBox.Show("No updates found at this time.", "No Update Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("No updates found at this time.", "No Update Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        #region "==> Player Tab"

        /// <summary>
        /// Adjusts the hair color.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbHairColor_Click(object sender, EventArgs e)
        {
            using (var cdlg = new ColorDialog())
            {
                cdlg.Color = this.pbHairColor.BackColor;
                if (cdlg.ShowDialog() != DialogResult.OK)
                    return;

                this.Player.HairColor = this.modelViewer.HairColor = cdlg.Color;
            }
        }

        /// <summary>
        /// Adjusts the skin color.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbSkinColor_Click(object sender, EventArgs e)
        {
            using (var cdlg = new ColorDialog())
            {
                cdlg.Color = this.pbSkinColor.BackColor;
                if (cdlg.ShowDialog() != DialogResult.OK)
                    return;

                this.Player.SkinColor = this.modelViewer.HandsColor = this.modelViewer.HeadColor = cdlg.Color;
            }
        }

        /// <summary>
        /// Adjusts the eyes color.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbEyesColor_Click(object sender, EventArgs e)
        {
            using (var cdlg = new ColorDialog())
            {
                cdlg.Color = this.pbEyesColor.BackColor;
                if (cdlg.ShowDialog() != DialogResult.OK)
                    return;

                this.Player.EyeColor = this.modelViewer.EyeColor = cdlg.Color;
            }
        }

        /// <summary>
        /// Adjusts the shirt color.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbShirtColor_Click(object sender, EventArgs e)
        {
            using (var cdlg = new ColorDialog())
            {
                cdlg.Color = this.pbShirtColor.BackColor;
                if (cdlg.ShowDialog() != DialogResult.OK)
                    return;

                this.Player.ShirtColor = this.modelViewer.ShirtColor = cdlg.Color;
            }
        }

        /// <summary>
        /// Adjusts the undershirt color.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbUndershirtColor_Click(object sender, EventArgs e)
        {
            using (var cdlg = new ColorDialog())
            {
                cdlg.Color = this.pbUndershirtColor.BackColor;
                if (cdlg.ShowDialog() != DialogResult.OK)
                    return;

                this.Player.UndershirtColor = this.modelViewer.UndershirtColor = cdlg.Color;
            }
        }

        /// <summary>
        /// Adjusts the pants color
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbPantsColor_Click(object sender, EventArgs e)
        {
            using (var cdlg = new ColorDialog())
            {
                cdlg.Color = this.pbPantsColor.BackColor;
                if (cdlg.ShowDialog() != DialogResult.OK)
                    return;

                this.Player.PantsColor = this.modelViewer.PantsColor = cdlg.Color;
            }
        }

        /// <summary>
        /// Adjusts the shoes color.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbShoesColor_Click(object sender, EventArgs e)
        {
            using (var cdlg = new ColorDialog())
            {
                cdlg.Color = this.pbShoesColor.BackColor;
                if (cdlg.ShowDialog() != DialogResult.OK)
                    return;

                this.Player.ShoesColor = this.modelViewer.ShoesColor = cdlg.Color;
            }
        }

        /// <summary>
        /// Opens the hair selector.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectHair_Click(object sender, EventArgs e)
        {
            var frmHair = new frmHairSelection { HairId = this.Player.Hair };
            if (frmHair.ShowDialog() != DialogResult.OK)
                return;

            this.Player.Hair = frmHair.HairId;
            this.modelViewer.HairId = frmHair.HairId;
            this.modelViewer.UpdateTextures();
        }

        /// <summary>
        /// Selects a random hair file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRandomHair_Click(object sender, EventArgs e)
        {
            var rand = new Random((int)DateTime.Now.Ticks);
            var hair = rand.Next(0, 50);

            this.Player.Hair = hair;
            this.modelViewer.HairId = hair;
            this.modelViewer.UpdateTextures();
        }

        /// <summary>
        /// Selects random colors.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRandomColors_Click(object sender, EventArgs e)
        {
            var rand = new Random((int)DateTime.Now.Ticks);
            var btColors = new byte[21];
            rand.NextBytes(btColors);

            this.modelViewer.SuspendModelUpdates();
            this.Player.HairColor = this.modelViewer.HairColor = Color.FromArgb(255, btColors[0], btColors[1], btColors[2]);
            this.Player.SkinColor = this.modelViewer.HandsColor = this.modelViewer.HeadColor = Color.FromArgb(255, btColors[3], btColors[4], btColors[5]);
            this.Player.EyeColor = this.modelViewer.EyeColor = Color.FromArgb(255, btColors[6], btColors[7], btColors[8]);
            this.Player.ShirtColor = this.modelViewer.ShirtColor = Color.FromArgb(255, btColors[9], btColors[10], btColors[11]);
            this.Player.UndershirtColor = this.modelViewer.UndershirtColor = Color.FromArgb(255, btColors[12], btColors[13], btColors[14]);
            this.Player.PantsColor = this.modelViewer.PantsColor = Color.FromArgb(255, btColors[15], btColors[16], btColors[17]);
            this.Player.ShoesColor = this.modelViewer.ShoesColor = Color.FromArgb(255, btColors[18], btColors[19], btColors[20]);
            this.modelViewer.ResumeModelUpdates();
        }

        /// <summary>
        /// Exports the current players hair type and colors.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveColorHair_Click(object sender, EventArgs e)
        {
            // Ask where to save to..
            var sfd = new SaveFileDialog
                {
                    AddExtension = true,
                    CheckPathExists = true,
                    DefaultExt = "xml",
                    Filter = "TSGE Hair and Color Files (*.xml)|*.xml|All files (*.*)|*.*",
                    InitialDirectory = Application.StartupPath,
                    ValidateNames = true,
                };

            var ret = sfd.ShowDialog();
            if (ret != DialogResult.OK)
            {
                if (ret == DialogResult.Cancel || ret == DialogResult.Abort)
                    return;
                MessageBox.Show("Failed to save hair and color!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create the new xml document..
            var xml = new XDocument(new XElement("HairColor"));
            if (xml.Root == null)
            {
                sfd.Dispose();
                MessageBox.Show("Failed to save hair and color!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Add the hair id element..
            xml.Root.Add(new XElement("hair", new object[]
                {
                    new XAttribute("id", this.Player.Hair)
                }));

            // Add the color elements..
            xml.Root.Add(new XElement("HairColor", new object[]
                {
                    new XAttribute("a", this.Player.HairColor.A),
                    new XAttribute("r", this.Player.HairColor.R),
                    new XAttribute("g", this.Player.HairColor.G),
                    new XAttribute("b", this.Player.HairColor.B)
                }));
            xml.Root.Add(new XElement("SkinColor", new object[]
                {
                    new XAttribute("a", this.Player.SkinColor.A),
                    new XAttribute("r", this.Player.SkinColor.R),
                    new XAttribute("g", this.Player.SkinColor.G),
                    new XAttribute("b", this.Player.SkinColor.B)
                }));
            xml.Root.Add(new XElement("EyeColor", new object[]
                {
                    new XAttribute("a", this.Player.EyeColor.A),
                    new XAttribute("r", this.Player.EyeColor.R),
                    new XAttribute("g", this.Player.EyeColor.G),
                    new XAttribute("b", this.Player.EyeColor.B)
                }));
            xml.Root.Add(new XElement("ShirtColor", new object[]
                {
                    new XAttribute("a", this.Player.ShirtColor.A),
                    new XAttribute("r", this.Player.ShirtColor.R),
                    new XAttribute("g", this.Player.ShirtColor.G),
                    new XAttribute("b", this.Player.ShirtColor.B)
                }));
            xml.Root.Add(new XElement("UndershirtColor", new object[]
                {
                    new XAttribute("a", this.Player.UndershirtColor.A),
                    new XAttribute("r", this.Player.UndershirtColor.R),
                    new XAttribute("g", this.Player.UndershirtColor.G),
                    new XAttribute("b", this.Player.UndershirtColor.B)
                }));
            xml.Root.Add(new XElement("PantsColor", new object[]
                {
                    new XAttribute("a", this.Player.PantsColor.A),
                    new XAttribute("r", this.Player.PantsColor.R),
                    new XAttribute("g", this.Player.PantsColor.G),
                    new XAttribute("b", this.Player.PantsColor.B)
                }));
            xml.Root.Add(new XElement("ShoesColor", new object[]
                {
                    new XAttribute("a", this.Player.ShoesColor.A),
                    new XAttribute("r", this.Player.ShoesColor.R),
                    new XAttribute("g", this.Player.ShoesColor.G),
                    new XAttribute("b", this.Player.ShoesColor.B)
                }));

            // Attempt to save the document..
            xml.Save(sfd.FileName);
            sfd.Dispose();
        }

        /// <summary>
        /// Imports a hair type and color profile.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLoadColorHair_Click(object sender, EventArgs e)
        {

            // Ask what to open..
            var ofd = new OpenFileDialog
                {
                    AddExtension = true,
                    CheckFileExists = true,
                    CheckPathExists = true,
                    DefaultExt = "xml",
                    Filter = "TSGE Hair and Color Files (*.xml)|*.xml|All files (*.*)|*.*",
                    InitialDirectory = Application.StartupPath,
                    ValidateNames = true
                };

            var ret = ofd.ShowDialog();
            if (ret != DialogResult.OK)
            {
                if (ret == DialogResult.Cancel || ret == DialogResult.Abort)
                    return;
                MessageBox.Show("Failed to open hair and color file!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            try
            {
                // Load the hair and color dump..
                var xml = XDocument.Load(ofd.FileName);

                // Ensure the root element exists..
                var root = xml.Element("HairColor");
                if (root == null)
                    throw new InvalidDataException("File data is not valid.");

                var element = root.Element("hair");
                if (element == null)
                    throw new InvalidDataException("File data is not valid.");
                var hairId = int.Parse(element.Attribute("id").Value);

                element = root.Element("HairColor");
                if (element == null)
                    throw new InvalidDataException("File data is not valid.");
                var hairColor = Color.FromArgb(int.Parse(element.Attribute("a").Value),
                    int.Parse(element.Attribute("r").Value),
                    int.Parse(element.Attribute("g").Value),
                    int.Parse(element.Attribute("b").Value));

                element = root.Element("SkinColor");
                if (element == null)
                    throw new InvalidDataException("File data is not valid.");
                var skinColor = Color.FromArgb(int.Parse(element.Attribute("a").Value),
                    int.Parse(element.Attribute("r").Value),
                    int.Parse(element.Attribute("g").Value),
                    int.Parse(element.Attribute("b").Value));

                element = root.Element("EyeColor");
                if (element == null)
                    throw new InvalidDataException("File data is not valid.");
                var eyeColor = Color.FromArgb(int.Parse(element.Attribute("a").Value),
                    int.Parse(element.Attribute("r").Value),
                    int.Parse(element.Attribute("g").Value),
                    int.Parse(element.Attribute("b").Value));

                element = root.Element("ShirtColor");
                if (element == null)
                    throw new InvalidDataException("File data is not valid.");
                var shirtColor = Color.FromArgb(int.Parse(element.Attribute("a").Value),
                    int.Parse(element.Attribute("r").Value),
                    int.Parse(element.Attribute("g").Value),
                    int.Parse(element.Attribute("b").Value));

                element = root.Element("UndershirtColor");
                if (element == null)
                    throw new InvalidDataException("File data is not valid.");
                var undershirtColor = Color.FromArgb(int.Parse(element.Attribute("a").Value),
                    int.Parse(element.Attribute("r").Value),
                    int.Parse(element.Attribute("g").Value),
                    int.Parse(element.Attribute("b").Value));

                element = root.Element("PantsColor");
                if (element == null)
                    throw new InvalidDataException("File data is not valid.");
                var pantsColor = Color.FromArgb(int.Parse(element.Attribute("a").Value),
                    int.Parse(element.Attribute("r").Value),
                    int.Parse(element.Attribute("g").Value),
                    int.Parse(element.Attribute("b").Value));

                element = root.Element("ShoesColor");
                if (element == null)
                    throw new InvalidDataException("File data is not valid.");
                var shoesColor = Color.FromArgb(int.Parse(element.Attribute("a").Value),
                    int.Parse(element.Attribute("r").Value),
                    int.Parse(element.Attribute("g").Value),
                    int.Parse(element.Attribute("b").Value));

                // Update the player..
                this.modelViewer.SuspendModelUpdates();
                this.Player.Hair = hairId;
                this.Player.HairColor = hairColor;
                this.Player.SkinColor = skinColor;
                this.Player.EyeColor = eyeColor;
                this.Player.ShirtColor = shirtColor;
                this.Player.UndershirtColor = undershirtColor;
                this.Player.PantsColor = pantsColor;
                this.Player.ShoesColor = shoesColor;
                this.modelViewer.ResumeModelUpdates();
            }
            catch
            {
                MessageBox.Show("Failed to open hair and color file!\r\nThe selected file is not valid!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ofd.Dispose();
        }

        #endregion

        #region "==> Buffs Tab"

        /// <summary>
        /// Deletes the selected buff.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteBuff_Click(object sender, EventArgs e)
        {
            if (this.lstPlayerBuffs.SelectedIndex < 0)
                return;

            // Delete the buff..
            this.Player.Buffs[this.lstPlayerBuffs.SelectedIndex].SetBuff(0);

            // Update the buff list..
            this.lstPlayerBuffs.Invalidate(true);
            this.lstPlayerBuffs.Refresh();
        }

        /// <summary>
        /// Maxes the selected buffs duration.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMaxBuffDuration_Click(object sender, EventArgs e)
        {
            if (this.lstPlayerBuffs.SelectedIndex < 0 &&
                this.Player.Buffs[this.lstPlayerBuffs.SelectedIndex].Id != 0)
                return;

            // Max the buff duration..
            var buff = Terraria.Instance.Buffs.Single(b => b.Id == this.Player.Buffs[this.lstPlayerBuffs.SelectedIndex].Id);
            this.Player.Buffs[this.lstPlayerBuffs.SelectedIndex].Duration = buff.Duration;

            // Update the buff list..
            this.lstPlayerBuffs.Invalidate(true);
            this.lstPlayerBuffs.Refresh();
        }

        /// <summary>
        /// Hacks the buffs duration.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHackBuffDuration_Click(object sender, EventArgs e)
        {
            if (this.lstPlayerBuffs.SelectedIndex < 0 &&
                this.Player.Buffs[this.lstPlayerBuffs.SelectedIndex].Id != 0)
                return;

            // Hack the buff duration..
            this.Player.Buffs[this.lstPlayerBuffs.SelectedIndex].Duration = int.MaxValue;

            // Update the buff list..
            this.lstPlayerBuffs.Invalidate(true);
            this.lstPlayerBuffs.Refresh();
        }

        /// <summary>
        /// Deletes all buffs.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteAllBuffs_Click(object sender, EventArgs e)
        {
            foreach (var buff in this.Player.Buffs)
                buff.SetBuff(0);

            // Update the buff list..
            this.lstPlayerBuffs.Invalidate(true);
            this.lstPlayerBuffs.Refresh();
        }

        /// <summary>
        /// Maxes all the buff durations.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMaxAllBuffDurations_Click(object sender, EventArgs e)
        {
            foreach (var buff in this.Player.Buffs.Where(b => b.Id > 0))
            {
                var origBuff = Terraria.Instance.Buffs.Single(b => b.Id == buff.Id);
                buff.Duration = origBuff.Duration;
            }

            // Update the buff list..
            this.lstPlayerBuffs.Invalidate(true);
            this.lstPlayerBuffs.Refresh();
        }

        /// <summary>
        /// Hacks all the buff durations.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHackAllBuffDurations_Click(object sender, EventArgs e)
        {
            foreach (var buff in this.Player.Buffs.Where(b => b.Id > 0))
                buff.Duration = int.MaxValue;

            // Update the buff list..
            this.lstPlayerBuffs.Invalidate(true);
            this.lstPlayerBuffs.Refresh();
        }

        /// <summary>
        /// Changes the players buff with the selected one.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstBuffSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lstBuffSelection.SelectedIndex < 0 ||
                this.lstPlayerBuffs.SelectedIndex < 0)
                return;

            // Set the new buff..
            var buff = Terraria.Instance.Buffs[this.lstBuffSelection.SelectedIndex];
            this.Player.Buffs[this.lstPlayerBuffs.SelectedIndex].SetBuff(buff.Id);

            // Update the buff list..
            this.lstPlayerBuffs.Invalidate(true);
            this.lstPlayerBuffs.Refresh();
        }

        /// <summary>
        /// Saves the current buff list to an xml file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveBuffs_Click(object sender, EventArgs e)
        {
            // Ask where to save to..
            var sfd = new SaveFileDialog
                {
                    AddExtension = true,
                    CheckPathExists = true,
                    DefaultExt = "xml",
                    Filter = "TSGE Buff Files (*.xml)|*.xml|All files (*.*)|*.*",
                    InitialDirectory = Application.StartupPath,
                    ValidateNames = true,
                };

            if (sfd.ShowDialog() != DialogResult.OK)
            {
                MessageBox.Show("Failed to save buffs!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create the new xml document..
            var xml = new XDocument(new XElement("Buffs"));
            if (xml.Root == null)
            {
                sfd.Dispose();
                MessageBox.Show("Failed to save buffs!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Loop each buff in the players buff list..
            foreach (var b in this.Player.Buffs)
            {
                // Add each item to the xml document..
                xml.Root.Add(new XElement("buff", new object[]
                    {
                        new XAttribute("id", b.Id),
                        new XAttribute("duration", b.Duration)
                    }));
            }

            // Attempt to save the document..
            xml.Save(sfd.FileName);
            sfd.Dispose();
        }

        /// <summary>
        /// Imports a saved buffs xml file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLoadBuffs_Click(object sender, EventArgs e)
        {
            // Ask what to open..
            var ofd = new OpenFileDialog
                {
                    AddExtension = true,
                    CheckFileExists = true,
                    CheckPathExists = true,
                    DefaultExt = "xml",
                    Filter = "TSGE Buff Files (*.xml)|*.xml|All files (*.*)|*.*",
                    InitialDirectory = Application.StartupPath,
                    ValidateNames = true
                };

            if (ofd.ShowDialog() != DialogResult.OK)
            {
                MessageBox.Show("Failed to open buff list!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Load the buff list dump..
                var xml = XDocument.Load(ofd.FileName);

                // Ensure the root element exists..
                var root = xml.Element("Buffs");
                if (root == null)
                    throw new InvalidDataException("File data is not valid.");

                // Obtain the buff entries..
                var itemElements = root.Elements("buff");
                var items = itemElements as IList<XElement> ?? itemElements.ToList();

                // Update each item..
                for (var x = 0; x < items.Count; x++)
                {
                    int buffId;
                    int buffDuration;

                    int.TryParse(items[x].Attribute("id").Value, out buffId);
                    int.TryParse(items[x].Attribute("duration").Value, out buffDuration);

                    this.Player.Buffs[x].SetBuff(buffId);
                    this.Player.Buffs[x].Duration = buffDuration;
                }

                this.RefreshLoadedPlayer();

                this.lstPlayerBuffs.Invalidate(true);
                this.lstPlayerBuffs.Refresh();
            }
            catch
            {
                MessageBox.Show("Failed to open buff list!\r\nThe selected file is not valid!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ofd.Dispose();
        }

        #endregion

        #region "==> Inventory Tab"

        /// <summary>
        /// Filters the inventory items list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtInvItemFilter_TextChanged(object sender, EventArgs e)
        {
            this.lstInventoryItems.SelectedIndexChanged -= this.lstInventoryItems_SelectedIndexChanged;
            var items = CreateFilteredItemList(this.txtInvItemFilter.Text, this.cboInvItemFilter.SelectedIndex);
            this.lstInventoryItems.DataSource = items.ToList();
            this.lstInventoryItems.SelectedIndexChanged += this.lstInventoryItems_SelectedIndexChanged;
        }

        /// <summary>
        /// Filters the item list based on the given selected category.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboInvItemFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lstInventoryItems.SelectedIndexChanged -= this.lstInventoryItems_SelectedIndexChanged;
            var items = CreateFilteredItemList(this.txtInvItemFilter.Text, this.cboInvItemFilter.SelectedIndex);
            this.lstInventoryItems.DataSource = items.ToList();
            this.lstInventoryItems.SelectedIndexChanged += this.lstInventoryItems_SelectedIndexChanged;
        }

        /// <summary>
        /// Filters the prefix list based on the given selected category.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboInventoryPrefixCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cboInventoryPrefix.SelectedIndexChanged -= this.cboInventoryPrefix_SelectedIndexChanged;
            var item = CreateFilteredPrefixList(this.cboInventoryPrefixCategory.SelectedIndex);
            this.cboInventoryPrefix.DataSource = item.ToList();
            this.cboInventoryPrefix.SelectedIndexChanged += this.cboInventoryPrefix_SelectedIndexChanged;
        }

        /// <summary>
        /// Selects the hovered inventory label.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void inventoryItem_Click(object sender, EventArgs e)
        {
            var lbl = (Label)sender;
            lbl.BackColor = Color.FromArgb(64, 127, 255, 0);

            this.m_SelectedInventoryItem = lbl;
            lbl.Focus();

            foreach (var label in this.m_InventoryLabels.Where(label => label != this.m_SelectedInventoryItem))
                label.BackColor = Color.Transparent;
        }

        /// <summary>
        /// Adjusts the hovered items background color.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void inventoryItem_MouseEnter(object sender, EventArgs e)
        {
            var lbl = (Label)sender;
            lbl.BackColor = Color.LightSkyBlue;
        }

        /// <summary>
        /// Adjusts the hovered items background color.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void inventoryItem_MouseLeave(object sender, EventArgs e)
        {
            var lbl = (Label)sender;
            lbl.BackColor = lbl != this.m_SelectedInventoryItem ? Color.Transparent : Color.FromArgb(64, 127, 255, 0);
        }

        /// <summary>
        /// Updates the current item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstInventoryItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.m_SelectedInventoryItem == null)
                return;

            // Set the inventory item..
            var item = (Item)this.lstInventoryItems.SelectedItem;
            var slot = (int)this.m_SelectedInventoryItem.Tag;
            this.Player.Inventory[slot].SetItem(item.NetID);
            this.Player.Inventory[slot].Count = this.Player.Inventory[slot].Stack = this.Player.Inventory[slot].MaxStack;

            if (item.NetID == 0)
                this.Player.Inventory[slot].Count = this.Player.Inventory[slot].Stack = 0;

            // Update the inventory label..
            this.m_SelectedInventoryItem.Image = new Bitmap(string.Format("{0}\\Data\\Items\\item_{1}.png", Application.StartupPath, item.NetID));
            this.m_SelectedInventoryItem.Text = this.Player.Inventory[slot].Count.ToString();
            this.m_Tooltip.SetToolTip(this.m_SelectedInventoryItem, item.ToString());
        }

        /// <summary>
        /// Updates the current items prefix.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboInventoryPrefix_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.m_SelectedInventoryItem == null)
                return;

            // Set the inventory item..
            var prefix = (ItemPrefix)this.cboInventoryPrefix.SelectedItem;
            var slot = (int)this.m_SelectedInventoryItem.Tag;

            // Ensure the slot has an item..
            if (this.Player.Inventory[slot].NetID == 0)
                return;

            // Update the prefix and tooltip..
            this.Player.Inventory[slot].Prefix = (byte)prefix.Id;
            this.m_Tooltip.SetToolTip(this.m_SelectedInventoryItem, this.Player.Inventory[slot].ToString());
        }

        /// <summary>
        /// Prevents the stack count from having non-numeric characters typed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtInventoryStackCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Updates the current items stack count with the entered amount.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtInventoryStackCount_TextChanged(object sender, EventArgs e)
        {
            if (this.m_SelectedInventoryItem == null)
                return;

            // Ensure the slot has an item..
            var slot = (int)this.m_SelectedInventoryItem.Tag;
            if (this.Player.Inventory[slot].NetID == 0)
                return;

            // Attempt to parse the new count..
            int count;
            if (!int.TryParse(this.txtInventoryStackCount.Text, out count))
                return;

            // Update the stack count..
            this.Player.Inventory[slot].Count = this.Player.Inventory[slot].Stack = count;
            this.m_SelectedInventoryItem.Text = count.ToString();
        }

        /// <summary>
        /// Deletes the selected inventory item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInventoryDeleteItem_Click(object sender, EventArgs e)
        {
            if (this.m_SelectedInventoryItem == null)
                return;

            // Ensure the slot has an item..
            var slot = (int)this.m_SelectedInventoryItem.Tag;
            if (this.Player.Inventory[slot].NetID == 0)
                return;

            // Update the inventory item..
            this.Player.Inventory[slot].SetItem(0);
            this.Player.Inventory[slot].Count = 0;

            // Update the inventory label..
            this.m_SelectedInventoryItem.Image = new Bitmap(string.Format("{0}\\Data\\Items\\item_{1}.png", Application.StartupPath, this.Player.Inventory[slot].NetID));
            this.m_SelectedInventoryItem.Text = "0";
            this.m_Tooltip.SetToolTip(this.m_SelectedInventoryItem, this.Player.Inventory[slot].ToString());
        }

        /// <summary>
        /// Maxes all inventory item stacks.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInventoryMaxAllStacks_Click(object sender, EventArgs e)
        {
            for (var x = 0; x < this.m_InventoryLabels.Count; x++)
            {
                // Update the item..
                var item = this.Player.Inventory[x];
                if (item.Id != 0)
                    item.Count = item.Stack = item.MaxStack;

                // Update the item label..
                this.m_InventoryLabels[x].Image = new Bitmap(string.Format("{0}\\Data\\Items\\item_{1}.png", Application.StartupPath, item.NetID));
                this.m_InventoryLabels[x].Text = item.Count.ToString();
                this.m_Tooltip.SetToolTip(this.m_InventoryLabels[x], item.ToString());
            }
        }

        /// <summary>
        /// Deletes all inventory items.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInventoryDeleteAllItems_Click(object sender, EventArgs e)
        {
            for (var x = 0; x < this.m_InventoryLabels.Count; x++)
            {
                // Update the item..
                var item = this.Player.Inventory[x];
                item.SetItem(0);
                item.Count = 0;

                // Update the item label..
                this.m_InventoryLabels[x].Image = new Bitmap(string.Format("{0}\\Data\\Items\\item_{1}.png", Application.StartupPath, item.NetID));
                this.m_InventoryLabels[x].Text = item.Count.ToString();
                this.m_Tooltip.SetToolTip(this.m_InventoryLabels[x], item.ToString());
            }
        }

        /// <summary>
        /// Hacks all inventory item stacks.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInventoryHackAllStacks_Click(object sender, EventArgs e)
        {
            for (var x = 0; x < this.m_InventoryLabels.Count; x++)
            {
                // Update the item..
                var item = this.Player.Inventory[x];
                if (item.Id != 0 && item.MaxStack > 1)
                    item.Count = item.Stack = int.MaxValue;

                // Update the item label..
                this.m_InventoryLabels[x].Image = new Bitmap(string.Format("{0}\\Data\\Items\\item_{1}.png", Application.StartupPath, item.NetID));
                this.m_InventoryLabels[x].Text = item.Count.ToString();
                this.m_Tooltip.SetToolTip(this.m_InventoryLabels[x], item.ToString());
            }
        }

        /// <summary>
        /// Saves the current inventory to an xml file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveInventory_Click(object sender, EventArgs e)
        {
            // Ask where to save to..
            var sfd = new SaveFileDialog
                {
                    AddExtension = true,
                    CheckPathExists = true,
                    DefaultExt = "xml",
                    Filter = "TSGE Inventory Files (*.xml)|*.xml|All files (*.*)|*.*",
                    InitialDirectory = Application.StartupPath,
                    ValidateNames = true,
                };

            if (sfd.ShowDialog() != DialogResult.OK)
            {
                MessageBox.Show("Failed to save inventory!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create the new xml document..
            var xml = new XDocument(new XElement("Inventory"));
            if (xml.Root == null)
            {
                sfd.Dispose();
                MessageBox.Show("Failed to save inventory!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Loop each item in the players inventory..
            foreach (var i in this.Player.Inventory)
            {
                // Add each item to the xml document..
                xml.Root.Add(new XElement("item", new object[]
                    {
                        new XAttribute("id", i.NetID),
                        new XAttribute("count", i.Count),
                        new XAttribute("prefix", i.Prefix)
                    }));
            }

            // Attempt to save the document..
            xml.Save(sfd.FileName);
            sfd.Dispose();
        }

        /// <summary>
        /// Imports a saved inventory xml file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLoadInventory_Click(object sender, EventArgs e)
        {
            // Ask what to open..
            var ofd = new OpenFileDialog
                {
                    AddExtension = true,
                    CheckFileExists = true,
                    CheckPathExists = true,
                    DefaultExt = "xml",
                    Filter = "TSGE Inventory Files (*.xml)|*.xml|All files (*.*)|*.*",
                    InitialDirectory = Application.StartupPath,
                    ValidateNames = true
                };

            if (ofd.ShowDialog() != DialogResult.OK)
            {
                MessageBox.Show("Failed to open inventory!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Load the inventory dump..
                var xml = XDocument.Load(ofd.FileName);

                // Ensure the root element exists..
                var root = xml.Element("Inventory");
                if (root == null)
                    throw new InvalidDataException("File data is not valid.");

                // Obtain the item entries..
                var itemElements = root.Elements("item");
                var items = itemElements as IList<XElement> ?? itemElements.ToList();
                if (items.Count != 58)
                    throw new InvalidDataException("File data is not valid.");

                // Update each item..
                for (var x = 0; x < items.Count; x++)
                {
                    int itemId;
                    int itemCount;
                    int itemPrefix;

                    int.TryParse(items[x].Attribute("id").Value, out itemId);
                    int.TryParse(items[x].Attribute("count").Value, out itemCount);
                    int.TryParse(items[x].Attribute("prefix").Value, out itemPrefix);

                    this.Player.Inventory[x].SetItem(itemId);
                    this.Player.Inventory[x].Count = itemCount;
                    this.Player.Inventory[x].Prefix = (byte)itemPrefix;
                }

                this.RefreshLoadedPlayer();
            }
            catch
            {
                MessageBox.Show("Failed to open inventory!\r\nThe selected file is not valid!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ofd.Dispose();
        }

        #endregion

        #region "==> Equipment Tab"

        /// <summary>
        /// Selects the hovered equipment label.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void equipmentItem_Click(object sender, EventArgs e)
        {
            var lbl = (Label)sender;
            lbl.BackColor = Color.FromArgb(64, 127, 255, 0);

            this.m_SelectedEquipmentItem = lbl;
            lbl.Focus();

            foreach (var label in this.m_EquipmentLabels.Where(label => label != this.m_SelectedEquipmentItem))
                label.BackColor = Color.Transparent;

            this.SetEquipmentListContext();
        }

        /// <summary>
        /// Adjusts the hovered items background color.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void equipmentItem_MouseEnter(object sender, EventArgs e)
        {
            var lbl = (Label)sender;
            lbl.BackColor = Color.LightSkyBlue;
        }

        /// <summary>
        /// Adjusts the hovered items background color.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void equipmentItem_MouseLeave(object sender, EventArgs e)
        {
            var lbl = (Label)sender;
            lbl.BackColor = lbl != this.m_SelectedEquipmentItem ? Color.Transparent : Color.FromArgb(64, 127, 255, 0);
        }

        /// <summary>
        /// Filters the equipment item list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtEquipmentFilter_TextChanged(object sender, EventArgs e)
        {
            this.SetEquipmentListContext();
        }

        /// <summary>
        /// Selects and sets the equipment item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstEquipmentItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.m_SelectedEquipmentItem == null || this.lstEquipmentItems.SelectedIndex < 0)
                return;

            var item = (Item)this.lstEquipmentItems.SelectedItem;
            var slot = (int)this.m_SelectedEquipmentItem.Tag;

            // Equipment..
            if (slot == 0 || slot == 1 || slot == 2)
            {
                this.Player.Armor[slot].SetItem(item.NetID);
            }

                // Vanity..
            else if (slot == 3 || slot == 4 || slot == 5)
            {
                this.Player.Vanity[slot - 3].SetItem(item.NetID);
            }

                // Dye..
            else if (slot == 6 || slot == 7 || slot == 8)
            {
                this.Player.Dye[slot - 6].SetItem(item.NetID);
            }

                // Accessories..
            else
            {
                this.Player.Accessories[slot - 9].SetItem(item.NetID);
            }

            // Update the inventory label..
            this.m_SelectedEquipmentItem.Image = new Bitmap(string.Format("{0}\\Data\\Items\\item_{1}.png", Application.StartupPath, item.NetID));
            this.m_SelectedEquipmentItem.Text = item.MaxStack.ToString();
            this.m_Tooltip.SetToolTip(this.m_SelectedEquipmentItem, item.ToString());
        }

        /// <summary>
        /// Filters the equipment prefix list based on the selected category.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboEquipmentPrefixCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cboEquipmentPrefix.SelectedIndexChanged -= this.cboEquipmentPrefix_SelectedIndexChanged;
            var item = CreateFilteredPrefixList(this.cboEquipmentPrefixCategory.SelectedIndex);
            this.cboEquipmentPrefix.DataSource = item.ToList();
            this.cboEquipmentPrefix.SelectedIndexChanged += this.cboEquipmentPrefix_SelectedIndexChanged;
        }

        /// <summary>
        /// Sets the equipment item prefix.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboEquipmentPrefix_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.m_SelectedEquipmentItem == null)
                return;

            var prefix = (ItemPrefix)this.cboEquipmentPrefix.SelectedItem;
            var slot = (int)this.m_SelectedEquipmentItem.Tag;

            // Equipment..
            if (slot == 0 || slot == 1 || slot == 2)
            {
                if (this.Player.Armor[slot].NetID == 0)
                    return;
                this.Player.Armor[slot].Prefix = (byte)prefix.Id;
                this.m_Tooltip.SetToolTip(this.m_SelectedEquipmentItem, this.Player.Armor[slot].ToString());
            }

                // Vanity..
            else if (slot == 3 || slot == 4 || slot == 5)
            {
                if (this.Player.Vanity[slot - 3].NetID == 0)
                    return;
                this.Player.Vanity[slot - 3].Prefix = (byte)prefix.Id;
                this.m_Tooltip.SetToolTip(this.m_SelectedEquipmentItem, this.Player.Vanity[slot - 3].ToString());
            }

                // Dye..
            else if (slot == 6 || slot == 7 || slot == 8)
            {
                if (this.Player.Dye[slot - 6].NetID == 0)
                    return;
                this.Player.Dye[slot - 6].Prefix = (byte)prefix.Id;
                this.m_Tooltip.SetToolTip(this.m_SelectedEquipmentItem, this.Player.Dye[slot - 6].ToString());
            }

                // Accessories..
            else
            {
                if (this.Player.Accessories[slot - 9].NetID == 0)
                    return;
                this.Player.Accessories[slot - 9].Prefix = (byte)prefix.Id;
                this.m_Tooltip.SetToolTip(this.m_SelectedEquipmentItem, this.Player.Accessories[slot - 9].ToString());
            }
        }

        /// <summary>
        /// Updates the equipment item list based on the selected slot and filter.
        /// </summary>
        private void SetEquipmentListContext()
        {
            // Do not set a source if no item is selected..
            if (this.m_SelectedEquipmentItem == null)
            {
                this.lstEquipmentItems.DataSource = null;
                return;
            }

            // Remove the selection changed event while we update..
            this.lstEquipmentItems.SelectedIndexChanged -= this.lstEquipmentItems_SelectedIndexChanged;
            this.lstEquipmentItems.SuspendLayout();

            // Determine the slot type..
            var slot = (int)this.m_SelectedEquipmentItem.Tag;
            switch (slot)
            {
                case 0: // Armor (Head)
                case 3: // Vanity (Head)
                    {
                        var items = CreateFilteredItemList(this.txtEquipmentFilter.Text, 1);
                        this.lstEquipmentItems.DataSource = items.Where(i => i.HeadSlot > -1 || i.NetID == 0).ToList();
                        break;
                    }

                case 1: // Armor (Body)
                case 4: // Vanity (Body)
                    {
                        var items = CreateFilteredItemList(this.txtEquipmentFilter.Text, 1);
                        this.lstEquipmentItems.DataSource = items.Where(i => i.BodySlot > -1 || i.NetID == 0).ToList();
                        break;
                    }

                case 2: // Armor (Legs)
                case 5: // Vanity (Legs)
                    {
                        var items = CreateFilteredItemList(this.txtEquipmentFilter.Text, 1);
                        this.lstEquipmentItems.DataSource = items.Where(i => i.LegSlot > -1 || i.NetID == 0).ToList();
                        break;
                    }
                case 6: // Dye
                case 7: // Dye
                case 8: // Dye
                    {
                        var items = CreateFilteredItemList(this.txtEquipmentFilter.Text, 0);
                        this.lstEquipmentItems.DataSource = items.Where(i => i.Dye > 0 || i.NetID == 0).ToList();
                        break;
                    }

                case 9: // Accessory
                case 10: // Accessory
                case 11: // Accessory
                case 12: // Accessory
                case 13: // Accessory
                    {
                        var items = CreateFilteredItemList(this.txtEquipmentFilter.Text, 2);
                        this.lstEquipmentItems.DataSource = items.ToList();
                        break;
                    }
            }

            // Restore the listbox..
            this.lstEquipmentItems.SelectedIndex = -1;
            this.lstEquipmentItems.ResumeLayout();
            this.lstEquipmentItems.SelectedIndexChanged += this.lstEquipmentItems_SelectedIndexChanged;
        }

        /// <summary>
        /// Saves the current players gear to an xml file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveEquipmentSet_Click(object sender, EventArgs e)
        {
            // Ask where to save to..
            var sfd = new SaveFileDialog
                {
                    AddExtension = true,
                    CheckPathExists = true,
                    DefaultExt = "xml",
                    Filter = "TSGE Equipment Files (*.xml)|*.xml|All files (*.*)|*.*",
                    InitialDirectory = Application.StartupPath,
                    ValidateNames = true,
                };

            if (sfd.ShowDialog() != DialogResult.OK)
            {
                MessageBox.Show("Failed to save equipment!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create the new xml document..
            var xml = new XDocument(new XElement("Equipment"));
            if (xml.Root == null)
            {
                sfd.Dispose();
                MessageBox.Show("Failed to save equipment!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Loop each armor piece..
            foreach (var i in this.Player.Armor)
            {
                // Add each item to the xml document..
                xml.Root.Add(new XElement("armor", new object[]
                    {
                        new XAttribute("id", i.NetID),
                        new XAttribute("prefix", i.Prefix)
                    }));
            }

            // Loop each vanity piece..
            foreach (var i in this.Player.Vanity)
            {
                // Add each item to the xml document..
                xml.Root.Add(new XElement("vanity", new object[]
                    {
                        new XAttribute("id", i.NetID),
                        new XAttribute("prefix", i.Prefix)
                    }));
            }

            // Loop each dye piece..
            foreach (var i in this.Player.Dye)
            {
                // Add each item to the xml document..
                xml.Root.Add(new XElement("dye", new object[]
                    {
                        new XAttribute("id", i.NetID),
                        new XAttribute("prefix", i.Prefix)
                    }));
            }

            // Loop each accessory piece..
            foreach (var i in this.Player.Accessories)
            {
                // Add each item to the xml document..
                xml.Root.Add(new XElement("accessory", new object[]
                    {
                        new XAttribute("id", i.NetID),
                        new XAttribute("prefix", i.Prefix)
                    }));
            }

            // Attempt to save the document..
            xml.Save(sfd.FileName);
            sfd.Dispose();
        }

        /// <summary>
        /// Imports a saved equipment set.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLoadEquipmentSet_Click(object sender, EventArgs e)
        {
            // Ask what to open..
            var ofd = new OpenFileDialog
                {
                    AddExtension = true,
                    CheckFileExists = true,
                    CheckPathExists = true,
                    DefaultExt = "xml",
                    Filter = "TSGE Equipment Files (*.xml)|*.xml|All files (*.*)|*.*",
                    InitialDirectory = Application.StartupPath,
                    ValidateNames = true
                };

            if (ofd.ShowDialog() != DialogResult.OK)
            {
                MessageBox.Show("Failed to open equipment save!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Load the equipment dump..
                var xml = XDocument.Load(ofd.FileName);

                // Ensure the root element exists..
                var root = xml.Element("Equipment");
                if (root == null)
                    throw new InvalidDataException("File data is not valid.");

                // Obtain each categories items..
                var armorElements = root.Elements("armor");
                var vanityElements = root.Elements("vanity");
                var dyeElements = root.Elements("dye");
                var accessoryElements = root.Elements("accessory");

                // Convert the items to lists..
                var armor = armorElements as IList<XElement> ?? armorElements.ToList();
                var vanity = vanityElements as IList<XElement> ?? vanityElements.ToList();
                var dye = dyeElements as IList<XElement> ?? dyeElements.ToList();
                var accessory = accessoryElements as IList<XElement> ?? accessoryElements.ToList();

                // Validate the data..
                if (armor.Count != 3 || vanity.Count != 3 || dye.Count != 3 || accessory.Count != 5)
                    throw new InvalidDataException("File data is not valid.");

                // Update the armor..
                this.Player.Armor[0].SetItem(int.Parse(armor[0].Attribute("id").Value));
                this.Player.Armor[0].Prefix = (byte)int.Parse(armor[0].Attribute("prefix").Value);
                this.Player.Armor[1].SetItem(int.Parse(armor[1].Attribute("id").Value));
                this.Player.Armor[1].Prefix = (byte)int.Parse(armor[1].Attribute("prefix").Value);
                this.Player.Armor[2].SetItem(int.Parse(armor[2].Attribute("id").Value));
                this.Player.Armor[2].Prefix = (byte)int.Parse(armor[2].Attribute("prefix").Value);

                // Update the vanity..
                this.Player.Vanity[0].SetItem(int.Parse(vanity[0].Attribute("id").Value));
                this.Player.Vanity[0].Prefix = (byte)int.Parse(vanity[0].Attribute("prefix").Value);
                this.Player.Vanity[1].SetItem(int.Parse(vanity[1].Attribute("id").Value));
                this.Player.Vanity[1].Prefix = (byte)int.Parse(vanity[1].Attribute("prefix").Value);
                this.Player.Vanity[2].SetItem(int.Parse(vanity[2].Attribute("id").Value));
                this.Player.Vanity[2].Prefix = (byte)int.Parse(vanity[2].Attribute("prefix").Value);

                // Update the dye..
                this.Player.Dye[0].SetItem(int.Parse(dye[0].Attribute("id").Value));
                this.Player.Dye[0].Prefix = (byte)int.Parse(dye[0].Attribute("prefix").Value);
                this.Player.Dye[1].SetItem(int.Parse(dye[1].Attribute("id").Value));
                this.Player.Dye[1].Prefix = (byte)int.Parse(dye[1].Attribute("prefix").Value);
                this.Player.Dye[2].SetItem(int.Parse(dye[2].Attribute("id").Value));
                this.Player.Dye[2].Prefix = (byte)int.Parse(dye[2].Attribute("prefix").Value);

                // Update the accessories..
                this.Player.Accessories[0].SetItem(int.Parse(accessory[0].Attribute("id").Value));
                this.Player.Accessories[0].Prefix = (byte)int.Parse(accessory[0].Attribute("prefix").Value);
                this.Player.Accessories[1].SetItem(int.Parse(accessory[1].Attribute("id").Value));
                this.Player.Accessories[1].Prefix = (byte)int.Parse(accessory[1].Attribute("prefix").Value);
                this.Player.Accessories[2].SetItem(int.Parse(accessory[2].Attribute("id").Value));
                this.Player.Accessories[2].Prefix = (byte)int.Parse(accessory[2].Attribute("prefix").Value);
                this.Player.Accessories[3].SetItem(int.Parse(accessory[3].Attribute("id").Value));
                this.Player.Accessories[3].Prefix = (byte)int.Parse(accessory[3].Attribute("prefix").Value);
                this.Player.Accessories[4].SetItem(int.Parse(accessory[4].Attribute("id").Value));
                this.Player.Accessories[4].Prefix = (byte)int.Parse(accessory[4].Attribute("prefix").Value);

                // Refresh the player..
                this.RefreshLoadedPlayer();
            }
            catch
            {
                MessageBox.Show("Failed to open equipment file!\r\nThe selected file is not valid!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ofd.Dispose();
        }

        #endregion

        #region "==> Bank / Safe Tab"

        /// <summary>
        /// Filters the bank/safe items list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBankSafeFilter_TextChanged(object sender, EventArgs e)
        {
            this.lstBankSafeItems.SelectedIndexChanged -= this.lstBankSafeItems_SelectedIndexChanged;
            var items = CreateFilteredItemList(this.txtBankSafeFilter.Text, this.cboBankSafeItemFilter.SelectedIndex);
            this.lstBankSafeItems.DataSource = items.ToList();
            this.lstBankSafeItems.SelectedIndexChanged += this.lstBankSafeItems_SelectedIndexChanged;
        }

        /// <summary>
        /// Filters the bank/safe items list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboBankSafeItemFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lstBankSafeItems.SelectedIndexChanged -= this.lstBankSafeItems_SelectedIndexChanged;
            var items = CreateFilteredItemList(this.txtBankSafeFilter.Text, this.cboBankSafeItemFilter.SelectedIndex);
            this.lstBankSafeItems.DataSource = items.ToList();
            this.lstBankSafeItems.SelectedIndexChanged += this.lstBankSafeItems_SelectedIndexChanged;
        }

        /// <summary>
        /// Filters the bank/safe prefix list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboBankSafePrefixCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cboBankSafePrefix.SelectedIndexChanged -= this.cboBankSafePrefix_SelectedIndexChanged;
            var item = CreateFilteredPrefixList(this.cboBankSafePrefixCategory.SelectedIndex);
            this.cboBankSafePrefix.DataSource = item.ToList();
            this.cboBankSafePrefix.SelectedIndexChanged += this.cboBankSafePrefix_SelectedIndexChanged;
        }

        /// <summary>
        /// Selects the hovered bank/safe label.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bankSafeItem_Click(object sender, EventArgs e)
        {
            var lbl = (Label)sender;
            lbl.BackColor = Color.FromArgb(64, 127, 255, 0);

            this.m_SelectedBankSafeItem = lbl;
            lbl.Focus();

            foreach (var label in this.m_BankSafeLabels.Where(label => label != this.m_SelectedBankSafeItem))
                label.BackColor = Color.Transparent;
        }

        /// <summary>
        /// Adjusts the hovered items background color.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bankSafeItem_MouseEnter(object sender, EventArgs e)
        {
            var lbl = (Label)sender;
            lbl.BackColor = Color.LightSkyBlue;
        }

        /// <summary>
        /// Adjusts the hovered items background color.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bankSafeItem_MouseLeave(object sender, EventArgs e)
        {
            var lbl = (Label)sender;
            lbl.BackColor = lbl != this.m_SelectedBankSafeItem ? Color.Transparent : Color.FromArgb(64, 127, 255, 0);
        }

        /// <summary>
        /// Updates the current item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstBankSafeItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.m_SelectedBankSafeItem == null)
                return;

            // Set the inventory item..
            var item = (Item)this.lstBankSafeItems.SelectedItem;
            var slot = (int)this.m_SelectedBankSafeItem.Tag;
            int count;

            if (slot <= 39)
            {
                this.Player.Bank1[slot].SetItem(item.NetID);
                this.Player.Bank1[slot].Count = this.Player.Bank1[slot].Stack = this.Player.Bank1[slot].MaxStack;

                if (item.NetID == 0)
                    this.Player.Bank1[slot].Count = this.Player.Bank1[slot].Stack = 0;

                count = this.Player.Bank1[slot].Count;
            }
            else
            {
                this.Player.Bank2[slot - 40].SetItem(item.NetID);
                this.Player.Bank2[slot - 40].Count = this.Player.Bank2[slot - 40].Stack = this.Player.Bank2[slot - 40].MaxStack;

                if (item.NetID == 0)
                    this.Player.Bank2[slot - 40].Count = this.Player.Bank2[slot - 40].Stack = 0;

                count = this.Player.Bank2[slot - 40].Count;
            }

            // Update the inventory label..
            this.m_SelectedBankSafeItem.Image = new Bitmap(string.Format("{0}\\Data\\Items\\item_{1}.png", Application.StartupPath, item.NetID));
            this.m_SelectedBankSafeItem.Text = count.ToString();
            this.m_Tooltip.SetToolTip(this.m_SelectedBankSafeItem, item.ToString());
        }

        /// <summary>
        /// Updates the current items prefix.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboBankSafePrefix_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.m_SelectedBankSafeItem == null)
                return;

            // Set the bank/safe item..
            var prefix = (ItemPrefix)this.cboBankSafePrefix.SelectedItem;
            var slot = (int)this.m_SelectedBankSafeItem.Tag;

            if (slot <= 39)
            {
                if (this.Player.Bank1[slot].NetID == 0)
                    return;
                this.Player.Bank1[slot].Prefix = (byte)prefix.Id;
                this.m_Tooltip.SetToolTip(this.m_SelectedBankSafeItem, this.Player.Bank1[slot].ToString());
            }
            else
            {
                if (this.Player.Bank2[slot].NetID == 0)
                    return;
                this.Player.Bank2[slot - 40].Prefix = (byte)prefix.Id;
                this.m_Tooltip.SetToolTip(this.m_SelectedBankSafeItem, this.Player.Bank2[slot - 40].ToString());
            }
        }

        /// <summary>
        /// Prevents the stack count from having non-numeric characters typed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBankSafeStackCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Updates the current items stack count with the entered amount.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBankSafeStackCount_TextChanged(object sender, EventArgs e)
        {
            if (this.m_SelectedBankSafeItem == null)
                return;

            // Attempt to parse the new count..
            int count;
            if (!int.TryParse(this.txtBankSafeStackCount.Text, out count))
                return;

            // Ensure the slot has an item..
            var slot = (int)this.m_SelectedBankSafeItem.Tag;

            if (slot <= 39)
            {
                if (this.Player.Bank1[slot].NetID == 0)
                    return;

                // Update the item and label..
                this.Player.Bank1[slot].Count = this.Player.Bank1[slot].Stack = count;
                this.m_SelectedBankSafeItem.Text = count.ToString();
            }
            else
            {
                if (this.Player.Bank2[slot - 40].NetID == 0)
                    return;

                // Update the item and label..
                this.Player.Bank2[slot - 40].Count = this.Player.Bank2[slot - 40].Stack = count;
                this.m_SelectedBankSafeItem.Text = count.ToString();
            }
        }

        /// <summary>
        /// Deletes all items in the players bank.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteAllBankItems_Click(object sender, EventArgs e)
        {
            for (var x = 0; x < 40; x++)
            {
                // Update the item..
                var item = this.Player.Bank1[x];
                item.SetItem(0);
                item.Count = 0;

                // Update the item label..
                this.m_BankSafeLabels[x].Image = new Bitmap(string.Format("{0}\\Data\\Items\\item_{1}.png", Application.StartupPath, item.NetID));
                this.m_BankSafeLabels[x].Text = item.Count.ToString();
                this.m_Tooltip.SetToolTip(this.m_BankSafeLabels[x], item.ToString());
            }
        }

        /// <summary>
        /// Deletes all the items in the players safe.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteAllSafeItems_Click(object sender, EventArgs e)
        {
            for (var x = 0; x < 40; x++)
            {
                // Update the item..
                var item = this.Player.Bank2[x];
                item.SetItem(0);
                item.Count = 0;

                // Update the item label..
                this.m_BankSafeLabels[x + 40].Image = new Bitmap(string.Format("{0}\\Data\\Items\\item_{1}.png", Application.StartupPath, item.NetID));
                this.m_BankSafeLabels[x + 40].Text = item.Count.ToString();
                this.m_Tooltip.SetToolTip(this.m_BankSafeLabels[x + 40], item.ToString());
            }
        }

        /// <summary>
        /// Maxes all bank and safe stack counts.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMaxAllBankSafeStacks_Click(object sender, EventArgs e)
        {
            for (var x = 0; x < this.m_BankSafeLabels.Count; x++)
            {
                // Update the item..
                var item = (x < 40) ? this.Player.Bank1[x] : this.Player.Bank2[x - 40];
                if (item.Id != 0 && item.MaxStack > 1)
                    item.Count = item.Stack = item.MaxStack;

                // Update the item label..
                this.m_BankSafeLabels[x].Image = new Bitmap(string.Format("{0}\\Data\\Items\\item_{1}.png", Application.StartupPath, item.NetID));
                this.m_BankSafeLabels[x].Text = item.Count.ToString();
                this.m_Tooltip.SetToolTip(this.m_BankSafeLabels[x], item.ToString());
            }
        }

        /// <summary>
        /// Hacks all the bank and safe item stack counts.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHackAllBankSafeStacks_Click(object sender, EventArgs e)
        {
            for (var x = 0; x < this.m_BankSafeLabels.Count; x++)
            {
                // Update the item..
                var item = (x < 40) ? this.Player.Bank1[x] : this.Player.Bank2[x - 40];
                if (item.Id != 0 && item.MaxStack > 1)
                    item.Count = item.Stack = int.MaxValue;

                // Update the item label..
                this.m_BankSafeLabels[x].Image = new Bitmap(string.Format("{0}\\Data\\Items\\item_{1}.png", Application.StartupPath, item.NetID));
                this.m_BankSafeLabels[x].Text = item.Count.ToString();
                this.m_Tooltip.SetToolTip(this.m_BankSafeLabels[x], item.ToString());
            }
        }

        /// <summary>
        /// Saves the players current bank items to an xml file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveBankItems_Click(object sender, EventArgs e)
        {
            // Ask where to save to..
            var sfd = new SaveFileDialog
                {
                    AddExtension = true,
                    CheckPathExists = true,
                    DefaultExt = "xml",
                    Filter = "TSGE Bank Files (*.xml)|*.xml|All files (*.*)|*.*",
                    InitialDirectory = Application.StartupPath,
                    ValidateNames = true,
                };

            if (sfd.ShowDialog() != DialogResult.OK)
            {
                MessageBox.Show("Failed to save bank!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create the new xml document..
            var xml = new XDocument(new XElement("BankSafe"));
            if (xml.Root == null)
            {
                sfd.Dispose();
                MessageBox.Show("Failed to save bank!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Loop each item in the players bank..
            foreach (var i in this.Player.Bank1)
            {
                // Add each item to the xml document..
                xml.Root.Add(new XElement("item", new object[]
                    {
                        new XAttribute("id", i.NetID),
                        new XAttribute("count", i.Count),
                        new XAttribute("prefix", i.Prefix)
                    }));
            }

            // Attempt to save the document..
            xml.Save(sfd.FileName);
            sfd.Dispose();
        }

        /// <summary>
        /// Imports a bank save file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLoadBankItems_Click(object sender, EventArgs e)
        {
            // Ask what to open..
            var ofd = new OpenFileDialog
                {
                    AddExtension = true,
                    CheckFileExists = true,
                    CheckPathExists = true,
                    DefaultExt = "xml",
                    Filter = "TSGE Bank Files (*.xml)|*.xml|All files (*.*)|*.*",
                    InitialDirectory = Application.StartupPath,
                    ValidateNames = true
                };

            if (ofd.ShowDialog() != DialogResult.OK)
            {
                MessageBox.Show("Failed to open bank!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Load the bank dump..
                var xml = XDocument.Load(ofd.FileName);

                // Ensure the root element exists..
                var root = xml.Element("BankSafe");
                if (root == null)
                    throw new InvalidDataException("File data is not valid.");

                // Obtain the item entries..
                var itemElements = root.Elements("item");
                var items = itemElements as IList<XElement> ?? itemElements.ToList();
                if (items.Count != 40)
                    throw new InvalidDataException("File data is not valid.");

                // Update each item..
                for (var x = 0; x < items.Count; x++)
                {
                    int itemId;
                    int itemCount;
                    int itemPrefix;

                    int.TryParse(items[x].Attribute("id").Value, out itemId);
                    int.TryParse(items[x].Attribute("count").Value, out itemCount);
                    int.TryParse(items[x].Attribute("prefix").Value, out itemPrefix);

                    this.Player.Bank1[x].SetItem(itemId);
                    this.Player.Bank1[x].Count = itemCount;
                    this.Player.Bank1[x].Prefix = (byte)itemPrefix;
                }

                this.RefreshLoadedPlayer();
            }
            catch
            {
                MessageBox.Show("Failed to open bank!\r\nThe selected file is not valid!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ofd.Dispose();
        }

        /// <summary>
        /// Saves the players current safe items into an xml file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveSafeItems_Click(object sender, EventArgs e)
        {
            // Ask where to save to..
            var sfd = new SaveFileDialog
                {
                    AddExtension = true,
                    CheckPathExists = true,
                    DefaultExt = "xml",
                    Filter = "TSGE Safe Files (*.xml)|*.xml|All files (*.*)|*.*",
                    InitialDirectory = Application.StartupPath,
                    ValidateNames = true,
                };

            if (sfd.ShowDialog() != DialogResult.OK)
            {
                MessageBox.Show("Failed to save safe!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create the new xml document..
            var xml = new XDocument(new XElement("BankSafe"));
            if (xml.Root == null)
            {
                sfd.Dispose();
                MessageBox.Show("Failed to save safe!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Loop each item in the players safe..
            foreach (var i in this.Player.Bank2)
            {
                // Add each item to the xml document..
                xml.Root.Add(new XElement("item", new object[]
                    {
                        new XAttribute("id", i.NetID),
                        new XAttribute("count", i.Count),
                        new XAttribute("prefix", i.Prefix)
                    }));
            }

            // Attempt to save the document..
            xml.Save(sfd.FileName);
            sfd.Dispose();
        }

        /// <summary>
        /// Imports a safe save file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLoadSafeItems_Click(object sender, EventArgs e)
        {
            // Ask what to open..
            var ofd = new OpenFileDialog
                {
                    AddExtension = true,
                    CheckFileExists = true,
                    CheckPathExists = true,
                    DefaultExt = "xml",
                    Filter = "TSGE Safe Files (*.xml)|*.xml|All files (*.*)|*.*",
                    InitialDirectory = Application.StartupPath,
                    ValidateNames = true
                };

            if (ofd.ShowDialog() != DialogResult.OK)
            {
                MessageBox.Show("Failed to open safe!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Load the safe dump..
                var xml = XDocument.Load(ofd.FileName);

                // Ensure the root element exists..
                var root = xml.Element("BankSafe");
                if (root == null)
                    throw new InvalidDataException("File data is not valid.");

                // Obtain the item entries..
                var itemElements = root.Elements("item");
                var items = itemElements as IList<XElement> ?? itemElements.ToList();
                if (items.Count != 40)
                    throw new InvalidDataException("File data is not valid.");

                // Update each item..
                for (var x = 0; x < items.Count; x++)
                {
                    int itemId;
                    int itemCount;
                    int itemPrefix;

                    int.TryParse(items[x].Attribute("id").Value, out itemId);
                    int.TryParse(items[x].Attribute("count").Value, out itemCount);
                    int.TryParse(items[x].Attribute("prefix").Value, out itemPrefix);

                    this.Player.Bank2[x].SetItem(itemId);
                    this.Player.Bank2[x].Count = itemCount;
                    this.Player.Bank2[x].Prefix = (byte)itemPrefix;
                }

                this.RefreshLoadedPlayer();
            }
            catch
            {
                MessageBox.Show("Failed to open safe!\r\nThe selected file is not valid!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ofd.Dispose();
        }

        #endregion

        #region "==> Hotkey Handlers"

        /// <summary>
        /// PreviewKeyDown event for inventory items to allow usage of hotkeys.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void inventoryItem_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            // Ensure we have a selected item..
            if (this.m_SelectedInventoryItem == null)
                return;

            // Ensure the slot has a valid item..
            var slot = (int)this.m_SelectedInventoryItem.Tag;
            if (this.Player.Inventory[slot].NetID == 0)
                return;

            // Handle the key accordingly..
            switch (e.KeyCode)
            {
                case Keys.D: // Delete current item.. 
                    {
                        // Delete the item..
                        this.Player.Inventory[slot].SetItem(0);
                        this.Player.Inventory[slot].Count = 0;

                        // Update the inventory label..
                        this.m_SelectedInventoryItem.Image = new Bitmap(string.Format("{0}\\Data\\Items\\item_{1}.png", Application.StartupPath, this.Player.Inventory[slot].NetID));
                        this.m_SelectedInventoryItem.Text = "0";
                        this.m_Tooltip.SetToolTip(this.m_SelectedInventoryItem, this.Player.Inventory[slot].ToString());
                        break;
                    }

                case Keys.P: // Set prefix..
                    {
                        // Update the prefix and tooltip..
                        var prefix = (ItemPrefix)this.cboInventoryPrefix.SelectedItem;
                        this.Player.Inventory[slot].Prefix = (byte)prefix.Id;
                        this.m_Tooltip.SetToolTip(this.m_SelectedInventoryItem, this.Player.Inventory[slot].ToString());
                        break;
                    }

                case Keys.M: // Set max stack..
                    {
                        // Update the stack count..
                        var item = this.Player.Inventory[slot];
                        item.Count = item.Stack = item.MaxStack;

                        // Update the item label..
                        this.m_SelectedInventoryItem.Image = new Bitmap(string.Format("{0}\\Data\\Items\\item_{1}.png", Application.StartupPath, item.NetID));
                        this.m_SelectedInventoryItem.Text = item.Count.ToString();
                        this.m_Tooltip.SetToolTip(this.m_SelectedInventoryItem, item.ToString());
                        break;
                    }

                case Keys.H: // Set hacked stack..
                    {
                        // Update the stack count..
                        var item = this.Player.Inventory[slot];
                        if (item.MaxStack > 1)
                            item.Count = item.Stack = 999;

                        // Update the item label..
                        this.m_SelectedInventoryItem.Image = new Bitmap(string.Format("{0}\\Data\\Items\\item_{1}.png", Application.StartupPath, item.NetID));
                        this.m_SelectedInventoryItem.Text = item.Count.ToString();
                        this.m_Tooltip.SetToolTip(this.m_SelectedInventoryItem, item.ToString());
                        break;
                    }
                case Keys.I: // Set item..
                    {
                        // Ensure we have a selected item..
                        var item = (Item)this.lstInventoryItems.SelectedItem;
                        if (item == null)
                            return;

                        // Set the item..
                        this.Player.Inventory[slot].SetItem(item.Id);
                        this.Player.Inventory[slot].Count = this.Player.Inventory[slot].Stack = this.Player.Inventory[slot].MaxStack;
                        break;
                    }
            }

        }

        /// <summary>
        /// PreviewKeyDown event for equipment items to allow usage of hotkeys.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void equipmentItem_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            // Ensure we have a selected item..
            if (this.m_SelectedEquipmentItem == null)
                return;

            // Ensure the slot has a valid item..
            var slot = (int)this.m_SelectedEquipmentItem.Tag;
            if ((slot == 0 || slot == 1 || slot == 2) && this.Player.Armor[slot].NetID == 0)
                return;
            if ((slot == 3 || slot == 4 || slot == 5) && this.Player.Vanity[slot - 3].NetID == 0)
                return;
            if ((slot == 6 || slot == 7 || slot == 8) && this.Player.Dye[slot - 6].NetID == 0)
                return;
            if (slot >= 9 && this.Player.Accessories[slot - 9].NetID == 0)
                return;

            // Obtain the editing item.
            Item item = null;
            if (slot == 0 || slot == 1 || slot == 2)
                item = this.Player.Armor[slot];
            if (slot == 3 || slot == 4 || slot == 5)
                item = this.Player.Vanity[slot - 3];
            if (slot == 6 || slot == 7 || slot == 8)
                item = this.Player.Dye[slot - 6];
            if (slot >= 9)
                item = this.Player.Accessories[slot - 9];

            if (item == null)
                return;

            // Handle the key accordingly..
            switch (e.KeyCode)
            {
                case Keys.D: // Delete current item.. 
                    {
                        item.SetItem(0);
                        item.Count = 0;
                        break;
                    }

                case Keys.P: // Set prefix..
                    {
                        var prefix = (ItemPrefix)this.cboEquipmentPrefix.SelectedItem;
                        item.Prefix = (byte)prefix.Id;
                        break;
                    }
            }

            // Update the equipment label..
            this.m_SelectedEquipmentItem.Image = new Bitmap(string.Format("{0}\\Data\\Items\\item_{1}.png", Application.StartupPath, item.NetID));
            this.m_SelectedEquipmentItem.Text = item.MaxStack.ToString();
            this.m_Tooltip.SetToolTip(this.m_SelectedEquipmentItem, item.ToString());
        }

        /// <summary>
        /// PreviewKeyDown event for bank and safe items to allow usage of hotkeys.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bankSafeItem_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            // Ensure we have a selected item..
            if (this.m_SelectedBankSafeItem == null)
                return;

            // Ensure the slot has a valid item..
            var slot = (int)this.m_SelectedBankSafeItem.Tag;
            if (((slot <= 39 && this.Player.Bank1[slot].NetID == 0) ||
                 (slot > 39 && this.Player.Bank2[slot - 40].NetID == 0)) &&
                e.KeyCode != Keys.I)
                return;

            // Obtain the editing item..
            var item = slot <= 39 ? this.Player.Bank1[slot] : this.Player.Bank2[slot - 40];

            // Handle the key accordingly..
            switch (e.KeyCode)
            {
                case Keys.D: // Delete current item.. 
                    {
                        item.SetItem(0);
                        item.Count = 0;
                        break;
                    }
                case Keys.P: // Set prefix..
                    {
                        var prefix = (ItemPrefix)this.cboBankSafePrefix.SelectedItem;
                        item.Prefix = (byte)prefix.Id;
                        break;
                    }
                case Keys.M: // Set max stack..
                    {
                        item.Count = item.Stack = item.MaxStack;
                        break;
                    }
                case Keys.H: // Set hacked stack..
                    {
                        if (item.MaxStack > 1)
                            item.Count = item.Stack = 999;
                        break;
                    }
                case Keys.I: // Set item..
                    {
                        // Ensure we have a selected item..
                        var selItem = (Item)this.lstBankSafeItems.SelectedItem;
                        if (selItem == null)
                            return;

                        // Set the item..
                        item.SetItem(selItem.Id);
                        item.Count = item.Stack = item.MaxStack;
                        break;
                    }
            }

            // Update the item label..
            this.m_SelectedBankSafeItem.Image = new Bitmap(string.Format("{0}\\Data\\Items\\item_{1}.png", Application.StartupPath, item.NetID));
            this.m_SelectedBankSafeItem.Text = item.Count.ToString();
            this.m_Tooltip.SetToolTip(this.m_SelectedBankSafeItem, item.ToString());
        }

        #endregion

        /// <summary>
        /// Adjusts the form size for each tab.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tcMainTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.tcMainTabControl.SelectedIndex)
            {
                case 0: // Main Player
                case 1: // Buffs                
                case 3: // Equipment
                    {
                        this.Width = DpiHelper.ScaleAsDpi(628);
                        this.Height = DpiHelper.ScaleAsDpi(493);
                        break;
                    }
                case 2: // Inventory
                    {
                        this.Width = DpiHelper.ScaleAsDpi(800);
                        this.Height = DpiHelper.ScaleAsDpi(493);
                        break;
                    }
                case 4: // Bank / Safe
                    {
                        this.Width = DpiHelper.ScaleAsDpi(705);
                        this.Height = DpiHelper.ScaleAsDpi(550);
                        break;
                    }
            }
        }
    }
}
