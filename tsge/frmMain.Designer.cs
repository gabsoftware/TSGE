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
    using System;
    using System.Windows.Forms;

    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tcMainTabControl = new System.Windows.Forms.TabControl();
            this.tpMainPlayer = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnLoadColorHair = new System.Windows.Forms.Button();
            this.btnSaveColorHair = new System.Windows.Forms.Button();
            this.btnRandomColors = new System.Windows.Forms.Button();
            this.btnRandomHair = new System.Windows.Forms.Button();
            this.btnSelectHair = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pbShoesColor = new System.Windows.Forms.PictureBox();
            this.playerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pbPantsColor = new System.Windows.Forms.PictureBox();
            this.pbUndershirtColor = new System.Windows.Forms.PictureBox();
            this.pbShirtColor = new System.Windows.Forms.PictureBox();
            this.pbEyesColor = new System.Windows.Forms.PictureBox();
            this.pbSkinColor = new System.Windows.Forms.PictureBox();
            this.pbHairColor = new System.Windows.Forms.PictureBox();
            this.modelViewer = new tsge.Controls.ModelViewer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMaxMana = new System.Windows.Forms.TextBox();
            this.txtCurrentMana = new System.Windows.Forms.TextBox();
            this.txtMaxHealth = new System.Windows.Forms.TextBox();
            this.txtCurrentHealth = new System.Windows.Forms.TextBox();
            this.pbPlayerMana = new System.Windows.Forms.ProgressBar();
            this.pbPlayerHealth = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkHideVisual = new System.Windows.Forms.CheckBox();
            this.cboDifficulty = new System.Windows.Forms.ComboBox();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.chkHotbarLocked = new System.Windows.Forms.CheckBox();
            this.chkIsMale = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tpBuffs = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnLoadBuffs = new System.Windows.Forms.Button();
            this.btnSaveBuffs = new System.Windows.Forms.Button();
            this.btnHackAllBuffDurations = new System.Windows.Forms.Button();
            this.btnMaxAllBuffDurations = new System.Windows.Forms.Button();
            this.btnDeleteAllBuffs = new System.Windows.Forms.Button();
            this.btnHackBuffDuration = new System.Windows.Forms.Button();
            this.btnMaxBuffDuration = new System.Windows.Forms.Button();
            this.btnDeleteBuff = new System.Windows.Forms.Button();
            this.lstBuffSelection = new tsge.Controls.BuffSelectionListBox();
            this.lstPlayerBuffs = new tsge.Controls.BuffListBox();
            this.buffsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tpInventory = new System.Windows.Forms.TabPage();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtInventoryStackCount = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.cboInventoryPrefixCategory = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cboInventoryPrefix = new System.Windows.Forms.ComboBox();
            this.btnInventoryHackAllStacks = new System.Windows.Forms.Button();
            this.btnInventoryDeleteAllItems = new System.Windows.Forms.Button();
            this.btnInventoryMaxAllStacks = new System.Windows.Forms.Button();
            this.btnInventoryDeleteItem = new System.Windows.Forms.Button();
            this.btnLoadInventory = new System.Windows.Forms.Button();
            this.btnSaveInventory = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lstInventoryItems = new System.Windows.Forms.ListBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cboInvItemFilter = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtInvItemFilter = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.inventoryItem54 = new tsge.Controls.ItemLabel();
            this.inventoryItem53 = new tsge.Controls.ItemLabel();
            this.inventoryItem57 = new tsge.Controls.ItemLabel();
            this.inventoryItem52 = new tsge.Controls.ItemLabel();
            this.inventoryItem56 = new tsge.Controls.ItemLabel();
            this.inventoryItem51 = new tsge.Controls.ItemLabel();
            this.inventoryItem55 = new tsge.Controls.ItemLabel();
            this.inventoryItem50 = new tsge.Controls.ItemLabel();
            this.inventoryItem40 = new tsge.Controls.ItemLabel();
            this.inventoryItem41 = new tsge.Controls.ItemLabel();
            this.inventoryItem42 = new tsge.Controls.ItemLabel();
            this.inventoryItem43 = new tsge.Controls.ItemLabel();
            this.inventoryItem44 = new tsge.Controls.ItemLabel();
            this.inventoryItem45 = new tsge.Controls.ItemLabel();
            this.inventoryItem46 = new tsge.Controls.ItemLabel();
            this.inventoryItem47 = new tsge.Controls.ItemLabel();
            this.inventoryItem48 = new tsge.Controls.ItemLabel();
            this.inventoryItem49 = new tsge.Controls.ItemLabel();
            this.inventoryItem30 = new tsge.Controls.ItemLabel();
            this.inventoryItem31 = new tsge.Controls.ItemLabel();
            this.inventoryItem32 = new tsge.Controls.ItemLabel();
            this.inventoryItem33 = new tsge.Controls.ItemLabel();
            this.inventoryItem34 = new tsge.Controls.ItemLabel();
            this.inventoryItem35 = new tsge.Controls.ItemLabel();
            this.inventoryItem36 = new tsge.Controls.ItemLabel();
            this.inventoryItem37 = new tsge.Controls.ItemLabel();
            this.inventoryItem38 = new tsge.Controls.ItemLabel();
            this.inventoryItem39 = new tsge.Controls.ItemLabel();
            this.inventoryItem20 = new tsge.Controls.ItemLabel();
            this.inventoryItem21 = new tsge.Controls.ItemLabel();
            this.inventoryItem22 = new tsge.Controls.ItemLabel();
            this.inventoryItem23 = new tsge.Controls.ItemLabel();
            this.inventoryItem24 = new tsge.Controls.ItemLabel();
            this.inventoryItem25 = new tsge.Controls.ItemLabel();
            this.inventoryItem26 = new tsge.Controls.ItemLabel();
            this.inventoryItem27 = new tsge.Controls.ItemLabel();
            this.inventoryItem28 = new tsge.Controls.ItemLabel();
            this.inventoryItem29 = new tsge.Controls.ItemLabel();
            this.inventoryItem10 = new tsge.Controls.ItemLabel();
            this.inventoryItem11 = new tsge.Controls.ItemLabel();
            this.inventoryItem12 = new tsge.Controls.ItemLabel();
            this.inventoryItem13 = new tsge.Controls.ItemLabel();
            this.inventoryItem14 = new tsge.Controls.ItemLabel();
            this.inventoryItem15 = new tsge.Controls.ItemLabel();
            this.inventoryItem16 = new tsge.Controls.ItemLabel();
            this.inventoryItem17 = new tsge.Controls.ItemLabel();
            this.inventoryItem18 = new tsge.Controls.ItemLabel();
            this.inventoryItem19 = new tsge.Controls.ItemLabel();
            this.inventoryItem09 = new tsge.Controls.ItemLabel();
            this.inventoryItem08 = new tsge.Controls.ItemLabel();
            this.inventoryItem07 = new tsge.Controls.ItemLabel();
            this.inventoryItem06 = new tsge.Controls.ItemLabel();
            this.inventoryItem05 = new tsge.Controls.ItemLabel();
            this.inventoryItem04 = new tsge.Controls.ItemLabel();
            this.inventoryItem03 = new tsge.Controls.ItemLabel();
            this.inventoryItem02 = new tsge.Controls.ItemLabel();
            this.inventoryItem01 = new tsge.Controls.ItemLabel();
            this.inventoryItem00 = new tsge.Controls.ItemLabel();
            this.tpEquipment = new System.Windows.Forms.TabPage();
            this.equipmentItem23 = new tsge.Controls.ItemLabel();
            this.equipmentItem22 = new tsge.Controls.ItemLabel();
            this.equipmentItem21 = new tsge.Controls.ItemLabel();
            this.equipmentItem20 = new tsge.Controls.ItemLabel();
            this.equipmentItem19 = new tsge.Controls.ItemLabel();
            this.label31 = new System.Windows.Forms.Label();
            this.equipmentItem18 = new tsge.Controls.ItemLabel();
            this.equipmentItem17 = new tsge.Controls.ItemLabel();
            this.equipmentItem16 = new tsge.Controls.ItemLabel();
            this.equipmentItem15 = new tsge.Controls.ItemLabel();
            this.equipmentItem14 = new tsge.Controls.ItemLabel();
            this.btnLoadEquipmentSet = new System.Windows.Forms.Button();
            this.btnSaveEquipmentSet = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label29 = new System.Windows.Forms.Label();
            this.cboEquipmentPrefixCategory = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.cboEquipmentPrefix = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtEquipmentFilter = new System.Windows.Forms.TextBox();
            this.lstEquipmentItems = new System.Windows.Forms.ListBox();
            this.equipmentItem13 = new tsge.Controls.ItemLabel();
            this.equipmentItem12 = new tsge.Controls.ItemLabel();
            this.equipmentItem11 = new tsge.Controls.ItemLabel();
            this.equipmentItem10 = new tsge.Controls.ItemLabel();
            this.equipmentItem09 = new tsge.Controls.ItemLabel();
            this.equipmentItem08 = new tsge.Controls.ItemLabel();
            this.equipmentItem07 = new tsge.Controls.ItemLabel();
            this.equipmentItem06 = new tsge.Controls.ItemLabel();
            this.equipmentItem05 = new tsge.Controls.ItemLabel();
            this.equipmentItem04 = new tsge.Controls.ItemLabel();
            this.equipmentItem03 = new tsge.Controls.ItemLabel();
            this.equipmentItem02 = new tsge.Controls.ItemLabel();
            this.equipmentItem01 = new tsge.Controls.ItemLabel();
            this.equipmentItem00 = new tsge.Controls.ItemLabel();
            this.tpBankSafe = new System.Windows.Forms.TabPage();
            this.btnLoadSafeItems = new System.Windows.Forms.Button();
            this.btnSaveSafeItems = new System.Windows.Forms.Button();
            this.btnLoadBankItems = new System.Windows.Forms.Button();
            this.btnSaveBankItems = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label30 = new System.Windows.Forms.Label();
            this.cboBankSafePrefixCategory = new System.Windows.Forms.ComboBox();
            this.btnHackAllBankSafeStacks = new System.Windows.Forms.Button();
            this.btnMaxAllBankSafeStacks = new System.Windows.Forms.Button();
            this.btnDeleteAllSafeItems = new System.Windows.Forms.Button();
            this.btnDeleteAllBankItems = new System.Windows.Forms.Button();
            this.label27 = new System.Windows.Forms.Label();
            this.txtBankSafeStackCount = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.cboBankSafeItemFilter = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.cboBankSafePrefix = new System.Windows.Forms.ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txtBankSafeFilter = new System.Windows.Forms.TextBox();
            this.lstBankSafeItems = new System.Windows.Forms.ListBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.bankSafeItem02 = new tsge.Controls.ItemLabel();
            this.bankSafeItem01 = new tsge.Controls.ItemLabel();
            this.bankSafeItem03 = new tsge.Controls.ItemLabel();
            this.bankSafeItem04 = new tsge.Controls.ItemLabel();
            this.bankSafeItem05 = new tsge.Controls.ItemLabel();
            this.bankSafeItem06 = new tsge.Controls.ItemLabel();
            this.bankSafeItem07 = new tsge.Controls.ItemLabel();
            this.bankSafeItem08 = new tsge.Controls.ItemLabel();
            this.bankSafeItem16 = new tsge.Controls.ItemLabel();
            this.bankSafeItem15 = new tsge.Controls.ItemLabel();
            this.bankSafeItem14 = new tsge.Controls.ItemLabel();
            this.bankSafeItem13 = new tsge.Controls.ItemLabel();
            this.bankSafeItem12 = new tsge.Controls.ItemLabel();
            this.bankSafeItem11 = new tsge.Controls.ItemLabel();
            this.bankSafeItem10 = new tsge.Controls.ItemLabel();
            this.bankSafeItem09 = new tsge.Controls.ItemLabel();
            this.bankSafeItem24 = new tsge.Controls.ItemLabel();
            this.bankSafeItem23 = new tsge.Controls.ItemLabel();
            this.bankSafeItem22 = new tsge.Controls.ItemLabel();
            this.bankSafeItem21 = new tsge.Controls.ItemLabel();
            this.bankSafeItem20 = new tsge.Controls.ItemLabel();
            this.bankSafeItem19 = new tsge.Controls.ItemLabel();
            this.bankSafeItem18 = new tsge.Controls.ItemLabel();
            this.bankSafeItem17 = new tsge.Controls.ItemLabel();
            this.bankSafeItem32 = new tsge.Controls.ItemLabel();
            this.bankSafeItem31 = new tsge.Controls.ItemLabel();
            this.bankSafeItem30 = new tsge.Controls.ItemLabel();
            this.bankSafeItem29 = new tsge.Controls.ItemLabel();
            this.bankSafeItem28 = new tsge.Controls.ItemLabel();
            this.bankSafeItem27 = new tsge.Controls.ItemLabel();
            this.bankSafeItem26 = new tsge.Controls.ItemLabel();
            this.bankSafeItem25 = new tsge.Controls.ItemLabel();
            this.bankSafeItem39 = new tsge.Controls.ItemLabel();
            this.bankSafeItem38 = new tsge.Controls.ItemLabel();
            this.bankSafeItem37 = new tsge.Controls.ItemLabel();
            this.bankSafeItem36 = new tsge.Controls.ItemLabel();
            this.bankSafeItem35 = new tsge.Controls.ItemLabel();
            this.bankSafeItem34 = new tsge.Controls.ItemLabel();
            this.bankSafeItem33 = new tsge.Controls.ItemLabel();
            this.bankSafeItem00 = new tsge.Controls.ItemLabel();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.bankSafeItem40 = new tsge.Controls.ItemLabel();
            this.bankSafeItem41 = new tsge.Controls.ItemLabel();
            this.bankSafeItem79 = new tsge.Controls.ItemLabel();
            this.bankSafeItem42 = new tsge.Controls.ItemLabel();
            this.bankSafeItem78 = new tsge.Controls.ItemLabel();
            this.bankSafeItem43 = new tsge.Controls.ItemLabel();
            this.bankSafeItem77 = new tsge.Controls.ItemLabel();
            this.bankSafeItem44 = new tsge.Controls.ItemLabel();
            this.bankSafeItem76 = new tsge.Controls.ItemLabel();
            this.bankSafeItem45 = new tsge.Controls.ItemLabel();
            this.bankSafeItem75 = new tsge.Controls.ItemLabel();
            this.bankSafeItem46 = new tsge.Controls.ItemLabel();
            this.bankSafeItem74 = new tsge.Controls.ItemLabel();
            this.bankSafeItem47 = new tsge.Controls.ItemLabel();
            this.bankSafeItem73 = new tsge.Controls.ItemLabel();
            this.bankSafeItem48 = new tsge.Controls.ItemLabel();
            this.bankSafeItem72 = new tsge.Controls.ItemLabel();
            this.bankSafeItem49 = new tsge.Controls.ItemLabel();
            this.bankSafeItem71 = new tsge.Controls.ItemLabel();
            this.bankSafeItem50 = new tsge.Controls.ItemLabel();
            this.bankSafeItem70 = new tsge.Controls.ItemLabel();
            this.bankSafeItem51 = new tsge.Controls.ItemLabel();
            this.bankSafeItem69 = new tsge.Controls.ItemLabel();
            this.bankSafeItem52 = new tsge.Controls.ItemLabel();
            this.bankSafeItem68 = new tsge.Controls.ItemLabel();
            this.bankSafeItem53 = new tsge.Controls.ItemLabel();
            this.bankSafeItem67 = new tsge.Controls.ItemLabel();
            this.bankSafeItem54 = new tsge.Controls.ItemLabel();
            this.bankSafeItem66 = new tsge.Controls.ItemLabel();
            this.bankSafeItem55 = new tsge.Controls.ItemLabel();
            this.bankSafeItem65 = new tsge.Controls.ItemLabel();
            this.bankSafeItem56 = new tsge.Controls.ItemLabel();
            this.bankSafeItem64 = new tsge.Controls.ItemLabel();
            this.bankSafeItem57 = new tsge.Controls.ItemLabel();
            this.bankSafeItem63 = new tsge.Controls.ItemLabel();
            this.bankSafeItem58 = new tsge.Controls.ItemLabel();
            this.bankSafeItem62 = new tsge.Controls.ItemLabel();
            this.bankSafeItem59 = new tsge.Controls.ItemLabel();
            this.bankSafeItem61 = new tsge.Controls.ItemLabel();
            this.bankSafeItem60 = new tsge.Controls.ItemLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tscboQuickSelect = new System.Windows.Forms.ToolStripComboBox();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newCharacterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutTSGEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tcMainTabControl.SuspendLayout();
            this.tpMainPlayer.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbShoesColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPantsColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUndershirtColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShirtColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEyesColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSkinColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHairColor)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tpBuffs.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buffsBindingSource)).BeginInit();
            this.tpInventory.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tpEquipment.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.tpBankSafe.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tcMainTabControl
            // 
            this.tcMainTabControl.Controls.Add(this.tpMainPlayer);
            this.tcMainTabControl.Controls.Add(this.tpBuffs);
            this.tcMainTabControl.Controls.Add(this.tpInventory);
            this.tcMainTabControl.Controls.Add(this.tpEquipment);
            this.tcMainTabControl.Controls.Add(this.tpBankSafe);
            this.tcMainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMainTabControl.Location = new System.Drawing.Point(0, 27);
            this.tcMainTabControl.Name = "tcMainTabControl";
            this.tcMainTabControl.Padding = new System.Drawing.Point(25, 3);
            this.tcMainTabControl.SelectedIndex = 0;
            this.tcMainTabControl.Size = new System.Drawing.Size(620, 439);
            this.tcMainTabControl.TabIndex = 1;
            this.tcMainTabControl.SelectedIndexChanged += new System.EventHandler(this.tcMainTabControl_SelectedIndexChanged);
            // 
            // tpMainPlayer
            // 
            this.tpMainPlayer.Controls.Add(this.groupBox3);
            this.tpMainPlayer.Controls.Add(this.groupBox2);
            this.tpMainPlayer.Controls.Add(this.groupBox1);
            this.tpMainPlayer.Location = new System.Drawing.Point(4, 22);
            this.tpMainPlayer.Name = "tpMainPlayer";
            this.tpMainPlayer.Padding = new System.Windows.Forms.Padding(3);
            this.tpMainPlayer.Size = new System.Drawing.Size(612, 413);
            this.tpMainPlayer.TabIndex = 0;
            this.tpMainPlayer.Text = "Player";
            this.tpMainPlayer.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnLoadColorHair);
            this.groupBox3.Controls.Add(this.btnSaveColorHair);
            this.groupBox3.Controls.Add(this.btnRandomColors);
            this.groupBox3.Controls.Add(this.btnRandomHair);
            this.groupBox3.Controls.Add(this.btnSelectHair);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.pbShoesColor);
            this.groupBox3.Controls.Add(this.pbPantsColor);
            this.groupBox3.Controls.Add(this.pbUndershirtColor);
            this.groupBox3.Controls.Add(this.pbShirtColor);
            this.groupBox3.Controls.Add(this.pbEyesColor);
            this.groupBox3.Controls.Add(this.pbSkinColor);
            this.groupBox3.Controls.Add(this.pbHairColor);
            this.groupBox3.Controls.Add(this.modelViewer);
            this.groupBox3.Location = new System.Drawing.Point(8, 145);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(588, 255);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Colors";
            // 
            // btnLoadColorHair
            // 
            this.btnLoadColorHair.Location = new System.Drawing.Point(462, 226);
            this.btnLoadColorHair.Name = "btnLoadColorHair";
            this.btnLoadColorHair.Size = new System.Drawing.Size(120, 23);
            this.btnLoadColorHair.TabIndex = 21;
            this.btnLoadColorHair.Text = "Load Color && Hair";
            this.btnLoadColorHair.UseVisualStyleBackColor = true;
            this.btnLoadColorHair.Click += new System.EventHandler(this.btnLoadColorHair_Click);
            // 
            // btnSaveColorHair
            // 
            this.btnSaveColorHair.Location = new System.Drawing.Point(462, 197);
            this.btnSaveColorHair.Name = "btnSaveColorHair";
            this.btnSaveColorHair.Size = new System.Drawing.Size(120, 23);
            this.btnSaveColorHair.TabIndex = 20;
            this.btnSaveColorHair.Text = "Save Color && Hair";
            this.btnSaveColorHair.UseVisualStyleBackColor = true;
            this.btnSaveColorHair.Click += new System.EventHandler(this.btnSaveColorHair_Click);
            // 
            // btnRandomColors
            // 
            this.btnRandomColors.Location = new System.Drawing.Point(462, 83);
            this.btnRandomColors.Name = "btnRandomColors";
            this.btnRandomColors.Size = new System.Drawing.Size(120, 23);
            this.btnRandomColors.TabIndex = 19;
            this.btnRandomColors.Text = "Random Colors";
            this.btnRandomColors.UseVisualStyleBackColor = true;
            this.btnRandomColors.Click += new System.EventHandler(this.btnRandomColors_Click);
            // 
            // btnRandomHair
            // 
            this.btnRandomHair.Location = new System.Drawing.Point(462, 54);
            this.btnRandomHair.Name = "btnRandomHair";
            this.btnRandomHair.Size = new System.Drawing.Size(120, 23);
            this.btnRandomHair.TabIndex = 18;
            this.btnRandomHair.Text = "Random Hair";
            this.btnRandomHair.UseVisualStyleBackColor = true;
            this.btnRandomHair.Click += new System.EventHandler(this.btnRandomHair_Click);
            // 
            // btnSelectHair
            // 
            this.btnSelectHair.Location = new System.Drawing.Point(462, 19);
            this.btnSelectHair.Name = "btnSelectHair";
            this.btnSelectHair.Size = new System.Drawing.Size(120, 23);
            this.btnSelectHair.TabIndex = 17;
            this.btnSelectHair.Text = "Select Hair";
            this.btnSelectHair.UseVisualStyleBackColor = true;
            this.btnSelectHair.Click += new System.EventHandler(this.btnSelectHair_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(29, 225);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "Shoes Color:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(32, 192);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "Pants Color:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 159);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Undershirt Color:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(38, 126);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Shirt Color:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(37, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Eyes Color:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(39, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Skin Color:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(41, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Hair Color:";
            // 
            // pbShoesColor
            // 
            this.pbShoesColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbShoesColor.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", this.playerBindingSource, "ShoesColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.pbShoesColor.Location = new System.Drawing.Point(114, 217);
            this.pbShoesColor.Name = "pbShoesColor";
            this.pbShoesColor.Size = new System.Drawing.Size(80, 27);
            this.pbShoesColor.TabIndex = 9;
            this.pbShoesColor.TabStop = false;
            this.pbShoesColor.Click += new System.EventHandler(this.pbShoesColor_Click);
            // 
            // playerBindingSource
            // 
            this.playerBindingSource.DataSource = typeof(tsge.Classes.Player);
            // 
            // pbPantsColor
            // 
            this.pbPantsColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPantsColor.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", this.playerBindingSource, "PantsColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.pbPantsColor.Location = new System.Drawing.Point(114, 184);
            this.pbPantsColor.Name = "pbPantsColor";
            this.pbPantsColor.Size = new System.Drawing.Size(80, 27);
            this.pbPantsColor.TabIndex = 8;
            this.pbPantsColor.TabStop = false;
            this.pbPantsColor.Click += new System.EventHandler(this.pbPantsColor_Click);
            // 
            // pbUndershirtColor
            // 
            this.pbUndershirtColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbUndershirtColor.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", this.playerBindingSource, "UndershirtColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.pbUndershirtColor.Location = new System.Drawing.Point(114, 151);
            this.pbUndershirtColor.Name = "pbUndershirtColor";
            this.pbUndershirtColor.Size = new System.Drawing.Size(80, 27);
            this.pbUndershirtColor.TabIndex = 7;
            this.pbUndershirtColor.TabStop = false;
            this.pbUndershirtColor.Click += new System.EventHandler(this.pbUndershirtColor_Click);
            // 
            // pbShirtColor
            // 
            this.pbShirtColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbShirtColor.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", this.playerBindingSource, "ShirtColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.pbShirtColor.Location = new System.Drawing.Point(114, 118);
            this.pbShirtColor.Name = "pbShirtColor";
            this.pbShirtColor.Size = new System.Drawing.Size(80, 27);
            this.pbShirtColor.TabIndex = 6;
            this.pbShirtColor.TabStop = false;
            this.pbShirtColor.Click += new System.EventHandler(this.pbShirtColor_Click);
            // 
            // pbEyesColor
            // 
            this.pbEyesColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbEyesColor.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", this.playerBindingSource, "EyeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.pbEyesColor.Location = new System.Drawing.Point(114, 85);
            this.pbEyesColor.Name = "pbEyesColor";
            this.pbEyesColor.Size = new System.Drawing.Size(80, 27);
            this.pbEyesColor.TabIndex = 5;
            this.pbEyesColor.TabStop = false;
            this.pbEyesColor.Click += new System.EventHandler(this.pbEyesColor_Click);
            // 
            // pbSkinColor
            // 
            this.pbSkinColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbSkinColor.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", this.playerBindingSource, "SkinColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.pbSkinColor.Location = new System.Drawing.Point(114, 52);
            this.pbSkinColor.Name = "pbSkinColor";
            this.pbSkinColor.Size = new System.Drawing.Size(80, 27);
            this.pbSkinColor.TabIndex = 4;
            this.pbSkinColor.TabStop = false;
            this.pbSkinColor.Click += new System.EventHandler(this.pbSkinColor_Click);
            // 
            // pbHairColor
            // 
            this.pbHairColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbHairColor.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", this.playerBindingSource, "HairColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.pbHairColor.Location = new System.Drawing.Point(114, 19);
            this.pbHairColor.Name = "pbHairColor";
            this.pbHairColor.Size = new System.Drawing.Size(80, 27);
            this.pbHairColor.TabIndex = 3;
            this.pbHairColor.TabStop = false;
            this.pbHairColor.Click += new System.EventHandler(this.pbHairColor_Click);
            // 
            // modelViewer
            // 
            this.modelViewer.DataBindings.Add(new System.Windows.Forms.Binding("EyeColor", this.playerBindingSource, "EyeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.modelViewer.DataBindings.Add(new System.Windows.Forms.Binding("HairColor", this.playerBindingSource, "HairColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.modelViewer.DataBindings.Add(new System.Windows.Forms.Binding("HairId", this.playerBindingSource, "Hair", true));
            this.modelViewer.DataBindings.Add(new System.Windows.Forms.Binding("HandsColor", this.playerBindingSource, "SkinColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.modelViewer.DataBindings.Add(new System.Windows.Forms.Binding("HeadColor", this.playerBindingSource, "SkinColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.modelViewer.DataBindings.Add(new System.Windows.Forms.Binding("PantsColor", this.playerBindingSource, "PantsColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.modelViewer.DataBindings.Add(new System.Windows.Forms.Binding("ShirtColor", this.playerBindingSource, "ShirtColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.modelViewer.DataBindings.Add(new System.Windows.Forms.Binding("ShoesColor", this.playerBindingSource, "ShoesColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.modelViewer.DataBindings.Add(new System.Windows.Forms.Binding("UndershirtColor", this.playerBindingSource, "UndershirtColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.modelViewer.EyeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(90)))), ((int)(((byte)(75)))));
            this.modelViewer.EyeFile = "Data\\Eyes\\eyes.png";
            this.modelViewer.EyeWhitesColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.modelViewer.EyeWhitesFile = "Data\\Eyes\\eye_whites.png";
            this.modelViewer.HairColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(90)))), ((int)(((byte)(55)))));
            this.modelViewer.HairFile = "Data\\Hair\\hair_0.png";
            this.modelViewer.HairId = 0;
            this.modelViewer.HandsColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(75)))));
            this.modelViewer.HandsFile = "Data\\Hands\\hands.png";
            this.modelViewer.HeadColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(75)))));
            this.modelViewer.HeadFile = "Data\\Heads\\head.png";
            this.modelViewer.LargestImageHeight = 0;
            this.modelViewer.LargestImageWidth = 0;
            this.modelViewer.Location = new System.Drawing.Point(200, 19);
            this.modelViewer.Name = "modelViewer";
            this.modelViewer.PantsColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(175)))));
            this.modelViewer.PantsFile = "Data\\Pants\\pants.png";
            this.modelViewer.ShirtColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(165)))), ((int)(((byte)(140)))));
            this.modelViewer.ShirtFile = "Data\\Shirts\\shirt.png";
            this.modelViewer.ShoesColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(106)))), ((int)(((byte)(60)))));
            this.modelViewer.ShoesFile = "Data\\Shoes\\shoes.png";
            this.modelViewer.Size = new System.Drawing.Size(150, 225);
            this.modelViewer.Suspended = false;
            this.modelViewer.TabIndex = 2;
            this.modelViewer.UndershirtColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(180)))), ((int)(((byte)(215)))));
            this.modelViewer.UnderShirtFile = "Data\\UnderShirts\\undershirt.png";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMaxMana);
            this.groupBox2.Controls.Add(this.txtCurrentMana);
            this.groupBox2.Controls.Add(this.txtMaxHealth);
            this.groupBox2.Controls.Add(this.txtCurrentHealth);
            this.groupBox2.Controls.Add(this.pbPlayerMana);
            this.groupBox2.Controls.Add(this.pbPlayerHealth);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(305, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(291, 133);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Health / Mana";
            // 
            // txtMaxMana
            // 
            this.txtMaxMana.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.playerBindingSource, "ManaMax", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtMaxMana.Location = new System.Drawing.Point(211, 68);
            this.txtMaxMana.Name = "txtMaxMana";
            this.txtMaxMana.Size = new System.Drawing.Size(61, 20);
            this.txtMaxMana.TabIndex = 26;
            // 
            // txtCurrentMana
            // 
            this.txtCurrentMana.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.playerBindingSource, "Mana", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtCurrentMana.Location = new System.Drawing.Point(144, 68);
            this.txtCurrentMana.Name = "txtCurrentMana";
            this.txtCurrentMana.Size = new System.Drawing.Size(61, 20);
            this.txtCurrentMana.TabIndex = 25;
            // 
            // txtMaxHealth
            // 
            this.txtMaxHealth.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.playerBindingSource, "HealthMax", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtMaxHealth.Location = new System.Drawing.Point(211, 17);
            this.txtMaxHealth.Name = "txtMaxHealth";
            this.txtMaxHealth.Size = new System.Drawing.Size(61, 20);
            this.txtMaxHealth.TabIndex = 24;
            // 
            // txtCurrentHealth
            // 
            this.txtCurrentHealth.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.playerBindingSource, "Health", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtCurrentHealth.Location = new System.Drawing.Point(144, 17);
            this.txtCurrentHealth.Name = "txtCurrentHealth";
            this.txtCurrentHealth.Size = new System.Drawing.Size(61, 20);
            this.txtCurrentHealth.TabIndex = 23;
            // 
            // pbPlayerMana
            // 
            this.pbPlayerMana.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.playerBindingSource, "Mana", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.pbPlayerMana.DataBindings.Add(new System.Windows.Forms.Binding("Maximum", this.playerBindingSource, "ManaMax", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.pbPlayerMana.ForeColor = System.Drawing.Color.DodgerBlue;
            this.pbPlayerMana.Location = new System.Drawing.Point(16, 94);
            this.pbPlayerMana.Name = "pbPlayerMana";
            this.pbPlayerMana.Size = new System.Drawing.Size(256, 23);
            this.pbPlayerMana.TabIndex = 22;
            this.pbPlayerMana.Value = 100;
            // 
            // pbPlayerHealth
            // 
            this.pbPlayerHealth.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.playerBindingSource, "Health", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.pbPlayerHealth.DataBindings.Add(new System.Windows.Forms.Binding("Maximum", this.playerBindingSource, "HealthMax", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.pbPlayerHealth.ForeColor = System.Drawing.Color.Chartreuse;
            this.pbPlayerHealth.Location = new System.Drawing.Point(16, 43);
            this.pbPlayerHealth.Name = "pbPlayerHealth";
            this.pbPlayerHealth.Size = new System.Drawing.Size(256, 23);
            this.pbPlayerHealth.TabIndex = 21;
            this.pbPlayerHealth.Value = 100;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Mana:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Health:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkHideVisual);
            this.groupBox1.Controls.Add(this.cboDifficulty);
            this.groupBox1.Controls.Add(this.txtPlayerName);
            this.groupBox1.Controls.Add(this.chkHotbarLocked);
            this.groupBox1.Controls.Add(this.chkIsMale);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 133);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Player";
            // 
            // chkHideVisual
            // 
            this.chkHideVisual.AutoSize = true;
            this.chkHideVisual.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.playerBindingSource, "HideVisual", true));
            this.chkHideVisual.Location = new System.Drawing.Point(104, 100);
            this.chkHideVisual.Name = "chkHideVisual";
            this.chkHideVisual.Size = new System.Drawing.Size(85, 17);
            this.chkHideVisual.TabIndex = 6;
            this.chkHideVisual.Text = "Hide Visual?";
            this.chkHideVisual.UseVisualStyleBackColor = true;
            // 
            // cboDifficulty
            // 
            this.cboDifficulty.DataBindings.Add(new System.Windows.Forms.Binding("SelectedIndex", this.playerBindingSource, "Difficulty", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cboDifficulty.FormattingEnabled = true;
            this.cboDifficulty.Items.AddRange(new object[] {
            "Softcore",
            "Mediumcore",
            "Hardcore"});
            this.cboDifficulty.Location = new System.Drawing.Point(104, 50);
            this.cboDifficulty.Name = "cboDifficulty";
            this.cboDifficulty.Size = new System.Drawing.Size(168, 21);
            this.cboDifficulty.TabIndex = 5;
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.playerBindingSource, "Name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtPlayerName.Location = new System.Drawing.Point(104, 24);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(168, 20);
            this.txtPlayerName.TabIndex = 4;
            // 
            // chkHotbarLocked
            // 
            this.chkHotbarLocked.AutoSize = true;
            this.chkHotbarLocked.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.playerBindingSource, "IsHotbarLocked", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkHotbarLocked.Location = new System.Drawing.Point(176, 77);
            this.chkHotbarLocked.Name = "chkHotbarLocked";
            this.chkHotbarLocked.Size = new System.Drawing.Size(103, 17);
            this.chkHotbarLocked.TabIndex = 3;
            this.chkHotbarLocked.Text = "Hotbar Locked?";
            this.chkHotbarLocked.UseVisualStyleBackColor = true;
            // 
            // chkIsMale
            // 
            this.chkIsMale.AutoSize = true;
            this.chkIsMale.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.playerBindingSource, "IsMale", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkIsMale.Location = new System.Drawing.Point(104, 77);
            this.chkIsMale.Name = "chkIsMale";
            this.chkIsMale.Size = new System.Drawing.Size(66, 17);
            this.chkIsMale.TabIndex = 2;
            this.chkIsMale.Text = "Is Male?";
            this.chkIsMale.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Difficulty:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player Name:";
            // 
            // tpBuffs
            // 
            this.tpBuffs.Controls.Add(this.groupBox4);
            this.tpBuffs.Controls.Add(this.lstPlayerBuffs);
            this.tpBuffs.Location = new System.Drawing.Point(4, 22);
            this.tpBuffs.Name = "tpBuffs";
            this.tpBuffs.Padding = new System.Windows.Forms.Padding(3);
            this.tpBuffs.Size = new System.Drawing.Size(612, 413);
            this.tpBuffs.TabIndex = 1;
            this.tpBuffs.Text = "Buffs";
            this.tpBuffs.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnLoadBuffs);
            this.groupBox4.Controls.Add(this.btnSaveBuffs);
            this.groupBox4.Controls.Add(this.btnHackAllBuffDurations);
            this.groupBox4.Controls.Add(this.btnMaxAllBuffDurations);
            this.groupBox4.Controls.Add(this.btnDeleteAllBuffs);
            this.groupBox4.Controls.Add(this.btnHackBuffDuration);
            this.groupBox4.Controls.Add(this.btnMaxBuffDuration);
            this.groupBox4.Controls.Add(this.btnDeleteBuff);
            this.groupBox4.Controls.Add(this.lstBuffSelection);
            this.groupBox4.Location = new System.Drawing.Point(309, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(287, 391);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Buff Editor";
            // 
            // btnLoadBuffs
            // 
            this.btnLoadBuffs.Location = new System.Drawing.Point(156, 362);
            this.btnLoadBuffs.Name = "btnLoadBuffs";
            this.btnLoadBuffs.Size = new System.Drawing.Size(125, 23);
            this.btnLoadBuffs.TabIndex = 8;
            this.btnLoadBuffs.Text = "Load Buffs";
            this.btnLoadBuffs.UseVisualStyleBackColor = true;
            this.btnLoadBuffs.Click += new System.EventHandler(this.btnLoadBuffs_Click);
            // 
            // btnSaveBuffs
            // 
            this.btnSaveBuffs.Location = new System.Drawing.Point(6, 362);
            this.btnSaveBuffs.Name = "btnSaveBuffs";
            this.btnSaveBuffs.Size = new System.Drawing.Size(125, 23);
            this.btnSaveBuffs.TabIndex = 7;
            this.btnSaveBuffs.Text = "Save Buffs";
            this.btnSaveBuffs.UseVisualStyleBackColor = true;
            this.btnSaveBuffs.Click += new System.EventHandler(this.btnSaveBuffs_Click);
            // 
            // btnHackAllBuffDurations
            // 
            this.btnHackAllBuffDurations.Location = new System.Drawing.Point(156, 322);
            this.btnHackAllBuffDurations.Name = "btnHackAllBuffDurations";
            this.btnHackAllBuffDurations.Size = new System.Drawing.Size(125, 23);
            this.btnHackAllBuffDurations.TabIndex = 6;
            this.btnHackAllBuffDurations.Text = "Hack All Durations";
            this.btnHackAllBuffDurations.UseVisualStyleBackColor = true;
            this.btnHackAllBuffDurations.Click += new System.EventHandler(this.btnHackAllBuffDurations_Click);
            // 
            // btnMaxAllBuffDurations
            // 
            this.btnMaxAllBuffDurations.Location = new System.Drawing.Point(156, 293);
            this.btnMaxAllBuffDurations.Name = "btnMaxAllBuffDurations";
            this.btnMaxAllBuffDurations.Size = new System.Drawing.Size(125, 23);
            this.btnMaxAllBuffDurations.TabIndex = 5;
            this.btnMaxAllBuffDurations.Text = "Max All Durations";
            this.btnMaxAllBuffDurations.UseVisualStyleBackColor = true;
            this.btnMaxAllBuffDurations.Click += new System.EventHandler(this.btnMaxAllBuffDurations_Click);
            // 
            // btnDeleteAllBuffs
            // 
            this.btnDeleteAllBuffs.Location = new System.Drawing.Point(156, 264);
            this.btnDeleteAllBuffs.Name = "btnDeleteAllBuffs";
            this.btnDeleteAllBuffs.Size = new System.Drawing.Size(125, 23);
            this.btnDeleteAllBuffs.TabIndex = 4;
            this.btnDeleteAllBuffs.Text = "Delete All";
            this.btnDeleteAllBuffs.UseVisualStyleBackColor = true;
            this.btnDeleteAllBuffs.Click += new System.EventHandler(this.btnDeleteAllBuffs_Click);
            // 
            // btnHackBuffDuration
            // 
            this.btnHackBuffDuration.Location = new System.Drawing.Point(6, 322);
            this.btnHackBuffDuration.Name = "btnHackBuffDuration";
            this.btnHackBuffDuration.Size = new System.Drawing.Size(125, 23);
            this.btnHackBuffDuration.TabIndex = 3;
            this.btnHackBuffDuration.Text = "Hack Duration";
            this.btnHackBuffDuration.UseVisualStyleBackColor = true;
            this.btnHackBuffDuration.Click += new System.EventHandler(this.btnHackBuffDuration_Click);
            // 
            // btnMaxBuffDuration
            // 
            this.btnMaxBuffDuration.Location = new System.Drawing.Point(6, 293);
            this.btnMaxBuffDuration.Name = "btnMaxBuffDuration";
            this.btnMaxBuffDuration.Size = new System.Drawing.Size(125, 23);
            this.btnMaxBuffDuration.TabIndex = 2;
            this.btnMaxBuffDuration.Text = "Max Duration";
            this.btnMaxBuffDuration.UseVisualStyleBackColor = true;
            this.btnMaxBuffDuration.Click += new System.EventHandler(this.btnMaxBuffDuration_Click);
            // 
            // btnDeleteBuff
            // 
            this.btnDeleteBuff.Location = new System.Drawing.Point(6, 264);
            this.btnDeleteBuff.Name = "btnDeleteBuff";
            this.btnDeleteBuff.Size = new System.Drawing.Size(125, 23);
            this.btnDeleteBuff.TabIndex = 1;
            this.btnDeleteBuff.Text = "Delete";
            this.btnDeleteBuff.UseVisualStyleBackColor = true;
            this.btnDeleteBuff.Click += new System.EventHandler(this.btnDeleteBuff_Click);
            // 
            // lstBuffSelection
            // 
            this.lstBuffSelection.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.lstBuffSelection.FormattingEnabled = true;
            this.lstBuffSelection.ItemHeight = 38;
            this.lstBuffSelection.Location = new System.Drawing.Point(6, 19);
            this.lstBuffSelection.Name = "lstBuffSelection";
            this.lstBuffSelection.Size = new System.Drawing.Size(275, 239);
            this.lstBuffSelection.TabIndex = 0;
            this.lstBuffSelection.SelectedIndexChanged += new System.EventHandler(this.lstBuffSelection_SelectedIndexChanged);
            // 
            // lstPlayerBuffs
            // 
            this.lstPlayerBuffs.DataSource = this.buffsBindingSource;
            this.lstPlayerBuffs.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.lstPlayerBuffs.FormattingEnabled = true;
            this.lstPlayerBuffs.ItemHeight = 60;
            this.lstPlayerBuffs.Location = new System.Drawing.Point(8, 6);
            this.lstPlayerBuffs.Name = "lstPlayerBuffs";
            this.lstPlayerBuffs.Size = new System.Drawing.Size(295, 394);
            this.lstPlayerBuffs.TabIndex = 0;
            // 
            // buffsBindingSource
            // 
            this.buffsBindingSource.DataMember = "Buffs";
            this.buffsBindingSource.DataSource = this.playerBindingSource;
            // 
            // tpInventory
            // 
            this.tpInventory.Controls.Add(this.groupBox11);
            this.tpInventory.Controls.Add(this.btnInventoryHackAllStacks);
            this.tpInventory.Controls.Add(this.btnInventoryDeleteAllItems);
            this.tpInventory.Controls.Add(this.btnInventoryMaxAllStacks);
            this.tpInventory.Controls.Add(this.btnInventoryDeleteItem);
            this.tpInventory.Controls.Add(this.btnLoadInventory);
            this.tpInventory.Controls.Add(this.btnSaveInventory);
            this.tpInventory.Controls.Add(this.groupBox5);
            this.tpInventory.Controls.Add(this.label6);
            this.tpInventory.Controls.Add(this.label5);
            this.tpInventory.Controls.Add(this.inventoryItem54);
            this.tpInventory.Controls.Add(this.inventoryItem53);
            this.tpInventory.Controls.Add(this.inventoryItem57);
            this.tpInventory.Controls.Add(this.inventoryItem52);
            this.tpInventory.Controls.Add(this.inventoryItem56);
            this.tpInventory.Controls.Add(this.inventoryItem51);
            this.tpInventory.Controls.Add(this.inventoryItem55);
            this.tpInventory.Controls.Add(this.inventoryItem50);
            this.tpInventory.Controls.Add(this.inventoryItem40);
            this.tpInventory.Controls.Add(this.inventoryItem41);
            this.tpInventory.Controls.Add(this.inventoryItem42);
            this.tpInventory.Controls.Add(this.inventoryItem43);
            this.tpInventory.Controls.Add(this.inventoryItem44);
            this.tpInventory.Controls.Add(this.inventoryItem45);
            this.tpInventory.Controls.Add(this.inventoryItem46);
            this.tpInventory.Controls.Add(this.inventoryItem47);
            this.tpInventory.Controls.Add(this.inventoryItem48);
            this.tpInventory.Controls.Add(this.inventoryItem49);
            this.tpInventory.Controls.Add(this.inventoryItem30);
            this.tpInventory.Controls.Add(this.inventoryItem31);
            this.tpInventory.Controls.Add(this.inventoryItem32);
            this.tpInventory.Controls.Add(this.inventoryItem33);
            this.tpInventory.Controls.Add(this.inventoryItem34);
            this.tpInventory.Controls.Add(this.inventoryItem35);
            this.tpInventory.Controls.Add(this.inventoryItem36);
            this.tpInventory.Controls.Add(this.inventoryItem37);
            this.tpInventory.Controls.Add(this.inventoryItem38);
            this.tpInventory.Controls.Add(this.inventoryItem39);
            this.tpInventory.Controls.Add(this.inventoryItem20);
            this.tpInventory.Controls.Add(this.inventoryItem21);
            this.tpInventory.Controls.Add(this.inventoryItem22);
            this.tpInventory.Controls.Add(this.inventoryItem23);
            this.tpInventory.Controls.Add(this.inventoryItem24);
            this.tpInventory.Controls.Add(this.inventoryItem25);
            this.tpInventory.Controls.Add(this.inventoryItem26);
            this.tpInventory.Controls.Add(this.inventoryItem27);
            this.tpInventory.Controls.Add(this.inventoryItem28);
            this.tpInventory.Controls.Add(this.inventoryItem29);
            this.tpInventory.Controls.Add(this.inventoryItem10);
            this.tpInventory.Controls.Add(this.inventoryItem11);
            this.tpInventory.Controls.Add(this.inventoryItem12);
            this.tpInventory.Controls.Add(this.inventoryItem13);
            this.tpInventory.Controls.Add(this.inventoryItem14);
            this.tpInventory.Controls.Add(this.inventoryItem15);
            this.tpInventory.Controls.Add(this.inventoryItem16);
            this.tpInventory.Controls.Add(this.inventoryItem17);
            this.tpInventory.Controls.Add(this.inventoryItem18);
            this.tpInventory.Controls.Add(this.inventoryItem19);
            this.tpInventory.Controls.Add(this.inventoryItem09);
            this.tpInventory.Controls.Add(this.inventoryItem08);
            this.tpInventory.Controls.Add(this.inventoryItem07);
            this.tpInventory.Controls.Add(this.inventoryItem06);
            this.tpInventory.Controls.Add(this.inventoryItem05);
            this.tpInventory.Controls.Add(this.inventoryItem04);
            this.tpInventory.Controls.Add(this.inventoryItem03);
            this.tpInventory.Controls.Add(this.inventoryItem02);
            this.tpInventory.Controls.Add(this.inventoryItem01);
            this.tpInventory.Controls.Add(this.inventoryItem00);
            this.tpInventory.Location = new System.Drawing.Point(4, 22);
            this.tpInventory.Name = "tpInventory";
            this.tpInventory.Size = new System.Drawing.Size(612, 413);
            this.tpInventory.TabIndex = 2;
            this.tpInventory.Text = "Inventory";
            this.tpInventory.UseVisualStyleBackColor = true;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.label17);
            this.groupBox11.Controls.Add(this.txtInventoryStackCount);
            this.groupBox11.Controls.Add(this.label28);
            this.groupBox11.Controls.Add(this.cboInventoryPrefixCategory);
            this.groupBox11.Controls.Add(this.label16);
            this.groupBox11.Controls.Add(this.cboInventoryPrefix);
            this.groupBox11.Location = new System.Drawing.Point(186, 267);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(234, 129);
            this.groupBox11.TabIndex = 75;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Item Editor";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(50, 103);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(72, 13);
            this.label17.TabIndex = 74;
            this.label17.Text = "Item Stack:";
            // 
            // txtInventoryStackCount
            // 
            this.txtInventoryStackCount.Location = new System.Drawing.Point(128, 100);
            this.txtInventoryStackCount.Name = "txtInventoryStackCount";
            this.txtInventoryStackCount.Size = new System.Drawing.Size(100, 20);
            this.txtInventoryStackCount.TabIndex = 73;
            this.txtInventoryStackCount.TextChanged += new System.EventHandler(this.txtInventoryStackCount_TextChanged);
            this.txtInventoryStackCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInventoryStackCount_KeyPress);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(6, 17);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(97, 13);
            this.label28.TabIndex = 72;
            this.label28.Text = "Prefix Category:";
            // 
            // cboInventoryPrefixCategory
            // 
            this.cboInventoryPrefixCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboInventoryPrefixCategory.Items.AddRange(new object[] {
            "All",
            "Universal",
            "Common",
            "Melee",
            "Ranged",
            "Magic",
            "Accessories"});
            this.cboInventoryPrefixCategory.Location = new System.Drawing.Point(6, 33);
            this.cboInventoryPrefixCategory.Name = "cboInventoryPrefixCategory";
            this.cboInventoryPrefixCategory.Size = new System.Drawing.Size(222, 21);
            this.cboInventoryPrefixCategory.TabIndex = 71;
            this.cboInventoryPrefixCategory.SelectedIndexChanged += new System.EventHandler(this.cboInventoryPrefixCategory_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(6, 57);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(71, 13);
            this.label16.TabIndex = 70;
            this.label16.Text = "Item Prefix:";
            // 
            // cboInventoryPrefix
            // 
            this.cboInventoryPrefix.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboInventoryPrefix.Location = new System.Drawing.Point(6, 73);
            this.cboInventoryPrefix.Name = "cboInventoryPrefix";
            this.cboInventoryPrefix.Size = new System.Drawing.Size(222, 21);
            this.cboInventoryPrefix.TabIndex = 69;
            this.cboInventoryPrefix.SelectedIndexChanged += new System.EventHandler(this.cboInventoryPrefix_SelectedIndexChanged);
            // 
            // btnInventoryHackAllStacks
            // 
            this.btnInventoryHackAllStacks.Location = new System.Drawing.Point(535, 301);
            this.btnInventoryHackAllStacks.Name = "btnInventoryHackAllStacks";
            this.btnInventoryHackAllStacks.Size = new System.Drawing.Size(100, 23);
            this.btnInventoryHackAllStacks.TabIndex = 74;
            this.btnInventoryHackAllStacks.Text = "Hack Item Stacks";
            this.btnInventoryHackAllStacks.UseVisualStyleBackColor = true;
            this.btnInventoryHackAllStacks.Click += new System.EventHandler(this.btnInventoryHackAllStacks_Click);
            // 
            // btnInventoryDeleteAllItems
            // 
            this.btnInventoryDeleteAllItems.Location = new System.Drawing.Point(535, 272);
            this.btnInventoryDeleteAllItems.Name = "btnInventoryDeleteAllItems";
            this.btnInventoryDeleteAllItems.Size = new System.Drawing.Size(100, 23);
            this.btnInventoryDeleteAllItems.TabIndex = 73;
            this.btnInventoryDeleteAllItems.Text = "Delete All Items";
            this.btnInventoryDeleteAllItems.UseVisualStyleBackColor = true;
            this.btnInventoryDeleteAllItems.Click += new System.EventHandler(this.btnInventoryDeleteAllItems_Click);
            // 
            // btnInventoryMaxAllStacks
            // 
            this.btnInventoryMaxAllStacks.Location = new System.Drawing.Point(429, 300);
            this.btnInventoryMaxAllStacks.Name = "btnInventoryMaxAllStacks";
            this.btnInventoryMaxAllStacks.Size = new System.Drawing.Size(100, 23);
            this.btnInventoryMaxAllStacks.TabIndex = 72;
            this.btnInventoryMaxAllStacks.Text = "Max Item Stacks";
            this.btnInventoryMaxAllStacks.UseVisualStyleBackColor = true;
            this.btnInventoryMaxAllStacks.Click += new System.EventHandler(this.btnInventoryMaxAllStacks_Click);
            // 
            // btnInventoryDeleteItem
            // 
            this.btnInventoryDeleteItem.Location = new System.Drawing.Point(429, 272);
            this.btnInventoryDeleteItem.Name = "btnInventoryDeleteItem";
            this.btnInventoryDeleteItem.Size = new System.Drawing.Size(100, 23);
            this.btnInventoryDeleteItem.TabIndex = 71;
            this.btnInventoryDeleteItem.Text = "Delete Item";
            this.btnInventoryDeleteItem.UseVisualStyleBackColor = true;
            this.btnInventoryDeleteItem.Click += new System.EventHandler(this.btnInventoryDeleteItem_Click);
            // 
            // btnLoadInventory
            // 
            this.btnLoadInventory.Location = new System.Drawing.Point(535, 373);
            this.btnLoadInventory.Name = "btnLoadInventory";
            this.btnLoadInventory.Size = new System.Drawing.Size(100, 23);
            this.btnLoadInventory.TabIndex = 66;
            this.btnLoadInventory.Text = "Load Inventory";
            this.btnLoadInventory.UseVisualStyleBackColor = true;
            this.btnLoadInventory.Click += new System.EventHandler(this.btnLoadInventory_Click);
            // 
            // btnSaveInventory
            // 
            this.btnSaveInventory.Location = new System.Drawing.Point(429, 373);
            this.btnSaveInventory.Name = "btnSaveInventory";
            this.btnSaveInventory.Size = new System.Drawing.Size(100, 23);
            this.btnSaveInventory.TabIndex = 65;
            this.btnSaveInventory.Text = "Save Inventory";
            this.btnSaveInventory.UseVisualStyleBackColor = true;
            this.btnSaveInventory.Click += new System.EventHandler(this.btnSaveInventory_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lstInventoryItems);
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Location = new System.Drawing.Point(8, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(172, 393);
            this.groupBox5.TabIndex = 63;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Inventory Editor";
            // 
            // lstInventoryItems
            // 
            this.lstInventoryItems.FormattingEnabled = true;
            this.lstInventoryItems.Location = new System.Drawing.Point(6, 19);
            this.lstInventoryItems.Name = "lstInventoryItems";
            this.lstInventoryItems.Size = new System.Drawing.Size(160, 251);
            this.lstInventoryItems.TabIndex = 0;
            this.lstInventoryItems.SelectedIndexChanged += new System.EventHandler(this.lstInventoryItems_SelectedIndexChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.cboInvItemFilter);
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Controls.Add(this.txtInvItemFilter);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Location = new System.Drawing.Point(0, 282);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(172, 111);
            this.groupBox6.TabIndex = 64;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Item Filter";
            // 
            // cboInvItemFilter
            // 
            this.cboInvItemFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboInvItemFilter.FormattingEnabled = true;
            this.cboInvItemFilter.Items.AddRange(new object[] {
            "All",
            "Armor / Social Gear",
            "Accessories",
            "Ammunition",
            "Building Objects",
            "Consumables",
            "Money",
            "Tools",
            "Weapons"});
            this.cboInvItemFilter.Location = new System.Drawing.Point(6, 84);
            this.cboInvItemFilter.Name = "cboInvItemFilter";
            this.cboInvItemFilter.Size = new System.Drawing.Size(160, 21);
            this.cboInvItemFilter.TabIndex = 3;
            this.cboInvItemFilter.SelectedIndexChanged += new System.EventHandler(this.cboInvItemFilter_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(3, 68);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 13);
            this.label15.TabIndex = 2;
            this.label15.Text = "Item Type:";
            // 
            // txtInvItemFilter
            // 
            this.txtInvItemFilter.Location = new System.Drawing.Point(6, 35);
            this.txtInvItemFilter.Name = "txtInvItemFilter";
            this.txtInvItemFilter.Size = new System.Drawing.Size(160, 20);
            this.txtInvItemFilter.TabIndex = 1;
            this.txtInvItemFilter.TextChanged += new System.EventHandler(this.txtInvItemFilter_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(3, 19);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Item Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(739, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 62;
            this.label6.Text = "Ammo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(693, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 61;
            this.label5.Text = "Coins";
            // 
            // inventoryItem54
            // 
            this.inventoryItem54.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inventoryItem54.Location = new System.Drawing.Point(736, 9);
            this.inventoryItem54.Name = "inventoryItem54";
            this.inventoryItem54.ShowItemCount = true;
            this.inventoryItem54.Size = new System.Drawing.Size(42, 42);
            this.inventoryItem54.TabIndex = 59;
            this.inventoryItem54.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.inventoryItem54.Click += new System.EventHandler(this.inventoryItem_Click);
            this.inventoryItem54.MouseEnter += new System.EventHandler(this.inventoryItem_MouseEnter);
            this.inventoryItem54.MouseLeave += new System.EventHandler(this.inventoryItem_MouseLeave);
            this.inventoryItem54.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.inventoryItem_PreviewKeyDown);
            // 
            // inventoryItem53
            // 
            this.inventoryItem53.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inventoryItem53.Location = new System.Drawing.Point(688, 150);
            this.inventoryItem53.Name = "inventoryItem53";
            this.inventoryItem53.ShowItemCount = true;
            this.inventoryItem53.Size = new System.Drawing.Size(42, 42);
            this.inventoryItem53.TabIndex = 57;
            this.inventoryItem53.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.inventoryItem53.Click += new System.EventHandler(this.inventoryItem_Click);
            this.inventoryItem53.MouseEnter += new System.EventHandler(this.inventoryItem_MouseEnter);
            this.inventoryItem53.MouseLeave += new System.EventHandler(this.inventoryItem_MouseLeave);
            this.inventoryItem53.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.inventoryItem_PreviewKeyDown);
            // 
            // inventoryItem57
            // 
            this.inventoryItem57.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inventoryItem57.Location = new System.Drawing.Point(736, 150);
            this.inventoryItem57.Name = "inventoryItem57";
            this.inventoryItem57.ShowItemCount = true;
            this.inventoryItem57.Size = new System.Drawing.Size(42, 42);
            this.inventoryItem57.TabIndex = 56;
            this.inventoryItem57.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.inventoryItem57.Click += new System.EventHandler(this.inventoryItem_Click);
            this.inventoryItem57.MouseEnter += new System.EventHandler(this.inventoryItem_MouseEnter);
            this.inventoryItem57.MouseLeave += new System.EventHandler(this.inventoryItem_MouseLeave);
            this.inventoryItem57.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.inventoryItem_PreviewKeyDown);
            // 
            // inventoryItem52
            // 
            this.inventoryItem52.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inventoryItem52.Location = new System.Drawing.Point(688, 103);
            this.inventoryItem52.Name = "inventoryItem52";
            this.inventoryItem52.ShowItemCount = true;
            this.inventoryItem52.Size = new System.Drawing.Size(42, 42);
            this.inventoryItem52.TabIndex = 55;
            this.inventoryItem52.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.inventoryItem52.Click += new System.EventHandler(this.inventoryItem_Click);
            this.inventoryItem52.MouseEnter += new System.EventHandler(this.inventoryItem_MouseEnter);
            this.inventoryItem52.MouseLeave += new System.EventHandler(this.inventoryItem_MouseLeave);
            this.inventoryItem52.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.inventoryItem_PreviewKeyDown);
            // 
            // inventoryItem56
            // 
            this.inventoryItem56.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inventoryItem56.Location = new System.Drawing.Point(736, 103);
            this.inventoryItem56.Name = "inventoryItem56";
            this.inventoryItem56.ShowItemCount = true;
            this.inventoryItem56.Size = new System.Drawing.Size(42, 42);
            this.inventoryItem56.TabIndex = 54;
            this.inventoryItem56.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.inventoryItem56.Click += new System.EventHandler(this.inventoryItem_Click);
            this.inventoryItem56.MouseEnter += new System.EventHandler(this.inventoryItem_MouseEnter);
            this.inventoryItem56.MouseLeave += new System.EventHandler(this.inventoryItem_MouseLeave);
            this.inventoryItem56.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.inventoryItem_PreviewKeyDown);
            // 
            // inventoryItem51
            // 
            this.inventoryItem51.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inventoryItem51.Location = new System.Drawing.Point(688, 56);
            this.inventoryItem51.Name = "inventoryItem51";
            this.inventoryItem51.ShowItemCount = true;
            this.inventoryItem51.Size = new System.Drawing.Size(42, 42);
            this.inventoryItem51.TabIndex = 53;
            this.inventoryItem51.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.inventoryItem51.Click += new System.EventHandler(this.inventoryItem_Click);
            this.inventoryItem51.MouseEnter += new System.EventHandler(this.inventoryItem_MouseEnter);
            this.inventoryItem51.MouseLeave += new System.EventHandler(this.inventoryItem_MouseLeave);
            this.inventoryItem51.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.inventoryItem_PreviewKeyDown);
            // 
            // inventoryItem55
            // 
            this.inventoryItem55.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inventoryItem55.Location = new System.Drawing.Point(736, 56);
            this.inventoryItem55.Name = "inventoryItem55";
            this.inventoryItem55.ShowItemCount = true;
            this.inventoryItem55.Size = new System.Drawing.Size(42, 42);
            this.inventoryItem55.TabIndex = 52;
            this.inventoryItem55.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.inventoryItem55.Click += new System.EventHandler(this.inventoryItem_Click);
            this.inventoryItem55.MouseEnter += new System.EventHandler(this.inventoryItem_MouseEnter);
            this.inventoryItem55.MouseLeave += new System.EventHandler(this.inventoryItem_MouseLeave);
            this.inventoryItem55.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.inventoryItem_PreviewKeyDown);
            // 
            // inventoryItem50
            // 
            this.inventoryItem50.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inventoryItem50.Location = new System.Drawing.Point(688, 9);
            this.inventoryItem50.Name = "inventoryItem50";
            this.inventoryItem50.ShowItemCount = true;
            this.inventoryItem50.Size = new System.Drawing.Size(42, 42);
            this.inventoryItem50.TabIndex = 51;
            this.inventoryItem50.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.inventoryItem50.Click += new System.EventHandler(this.inventoryItem_Click);
            this.inventoryItem50.MouseEnter += new System.EventHandler(this.inventoryItem_MouseEnter);
            this.inventoryItem50.MouseLeave += new System.EventHandler(this.inventoryItem_MouseLeave);
            this.inventoryItem50.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.inventoryItem_PreviewKeyDown);
            // 
            // inventoryItem40
            // 
            this.inventoryItem40.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inventoryItem40.Location = new System.Drawing.Point(189, 197);
            this.inventoryItem40.Name = "inventoryItem40";
            this.inventoryItem40.ShowItemCount = true;
            this.inventoryItem40.Size = new System.Drawing.Size(42, 42);
            this.inventoryItem40.TabIndex = 50;
            this.inventoryItem40.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.inventoryItem40.Click += new System.EventHandler(this.inventoryItem_Click);
            this.inventoryItem40.MouseEnter += new System.EventHandler(this.inventoryItem_MouseEnter);
            this.inventoryItem40.MouseLeave += new System.EventHandler(this.inventoryItem_MouseLeave);
            this.inventoryItem40.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.inventoryItem_PreviewKeyDown);
            // 
            // inventoryItem41
            // 
            this.inventoryItem41.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inventoryItem41.Location = new System.Drawing.Point(237, 197);
            this.inventoryItem41.Name = "inventoryItem41";
            this.inventoryItem41.ShowItemCount = true;
            this.inventoryItem41.Size = new System.Drawing.Size(42, 42);
            this.inventoryItem41.TabIndex = 49;
            this.inventoryItem41.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.inventoryItem41.Click += new System.EventHandler(this.inventoryItem_Click);
            this.inventoryItem41.MouseEnter += new System.EventHandler(this.inventoryItem_MouseEnter);
            this.inventoryItem41.MouseLeave += new System.EventHandler(this.inventoryItem_MouseLeave);
            this.inventoryItem41.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.inventoryItem_PreviewKeyDown);
            // 
            // inventoryItem42
            // 
            this.inventoryItem42.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inventoryItem42.Location = new System.Drawing.Point(285, 197);
            this.inventoryItem42.Name = "inventoryItem42";
            this.inventoryItem42.ShowItemCount = true;
            this.inventoryItem42.Size = new System.Drawing.Size(42, 42);
            this.inventoryItem42.TabIndex = 48;
            this.inventoryItem42.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.inventoryItem42.Click += new System.EventHandler(this.inventoryItem_Click);
            this.inventoryItem42.MouseEnter += new System.EventHandler(this.inventoryItem_MouseEnter);
            this.inventoryItem42.MouseLeave += new System.EventHandler(this.inventoryItem_MouseLeave);
            this.inventoryItem42.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.inventoryItem_PreviewKeyDown);
            // 
            // inventoryItem43
            // 
            this.inventoryItem43.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inventoryItem43.Location = new System.Drawing.Point(333, 197);
            this.inventoryItem43.Name = "inventoryItem43";
            this.inventoryItem43.ShowItemCount = true;
            this.inventoryItem43.Size = new System.Drawing.Size(42, 42);
            this.inventoryItem43.TabIndex = 47;
            this.inventoryItem43.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.inventoryItem43.Click += new System.EventHandler(this.inventoryItem_Click);
            this.inventoryItem43.MouseEnter += new System.EventHandler(this.inventoryItem_MouseEnter);
            this.inventoryItem43.MouseLeave += new System.EventHandler(this.inventoryItem_MouseLeave);
            this.inventoryItem43.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.inventoryItem_PreviewKeyDown);
            // 
            // inventoryItem44
            // 
            this.inventoryItem44.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inventoryItem44.Location = new System.Drawing.Point(381, 197);
            this.inventoryItem44.Name = "inventoryItem44";
            this.inventoryItem44.ShowItemCount = true;
            this.inventoryItem44.Size = new System.Drawing.Size(42, 42);
            this.inventoryItem44.TabIndex = 46;
            this.inventoryItem44.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.inventoryItem44.Click += new System.EventHandler(this.inventoryItem_Click);
            this.inventoryItem44.MouseEnter += new System.EventHandler(this.inventoryItem_MouseEnter);
            this.inventoryItem44.MouseLeave += new System.EventHandler(this.inventoryItem_MouseLeave);
            this.inventoryItem44.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.inventoryItem_PreviewKeyDown);
            // 
            // inventoryItem45
            // 
            this.inventoryItem45.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inventoryItem45.Location = new System.Drawing.Point(429, 197);
            this.inventoryItem45.Name = "inventoryItem45";
            this.inventoryItem45.ShowItemCount = true;
            this.inventoryItem45.Size = new System.Drawing.Size(42, 42);
            this.inventoryItem45.TabIndex = 45;
            this.inventoryItem45.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.inventoryItem45.Click += new System.EventHandler(this.inventoryItem_Click);
            this.inventoryItem45.MouseEnter += new System.EventHandler(this.inventoryItem_MouseEnter);
            this.inventoryItem45.MouseLeave += new System.EventHandler(this.inventoryItem_MouseLeave);
            this.inventoryItem45.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.inventoryItem_PreviewKeyDown);
            // 
            // inventoryItem46
            // 
            this.inventoryItem46.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inventoryItem46.Location = new System.Drawing.Point(477, 197);
            this.inventoryItem46.Name = "inventoryItem46";
            this.inventoryItem46.ShowItemCount = true;
            this.inventoryItem46.Size = new System.Drawing.Size(42, 42);
            this.inventoryItem46.TabIndex = 44;
            this.inventoryItem46.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.inventoryItem46.Click += new System.EventHandler(this.inventoryItem_Click);
            this.inventoryItem46.MouseEnter += new System.EventHandler(this.inventoryItem_MouseEnter);
            this.inventoryItem46.MouseLeave += new System.EventHandler(this.inventoryItem_MouseLeave);
            this.inventoryItem46.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.inventoryItem_PreviewKeyDown);
            // 
            // inventoryItem47
            // 
            this.inventoryItem47.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inventoryItem47.Location = new System.Drawing.Point(525, 197);
            this.inventoryItem47.Name = "inventoryItem47";
            this.inventoryItem47.ShowItemCount = true;
            this.inventoryItem47.Size = new System.Drawing.Size(42, 42);
            this.inventoryItem47.TabIndex = 43;
            this.inventoryItem47.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.inventoryItem47.Click += new System.EventHandler(this.inventoryItem_Click);
            this.inventoryItem47.MouseEnter += new System.EventHandler(this.inventoryItem_MouseEnter);
            this.inventoryItem47.MouseLeave += new System.EventHandler(this.inventoryItem_MouseLeave);
            this.inventoryItem47.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.inventoryItem_PreviewKeyDown);
            // 
            // inventoryItem48
            // 
            this.inventoryItem48.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inventoryItem48.Location = new System.Drawing.Point(573, 197);
            this.inventoryItem48.Name = "inventoryItem48";
            this.inventoryItem48.ShowItemCount = true;
            this.inventoryItem48.Size = new System.Drawing.Size(42, 42);
            this.inventoryItem48.TabIndex = 42;
            this.inventoryItem48.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.inventoryItem48.Click += new System.EventHandler(this.inventoryItem_Click);
            this.inventoryItem48.MouseEnter += new System.EventHandler(this.inventoryItem_MouseEnter);
            this.inventoryItem48.MouseLeave += new System.EventHandler(this.inventoryItem_MouseLeave);
            this.inventoryItem48.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.inventoryItem_PreviewKeyDown);
            // 
            // inventoryItem49
            // 
            this.inventoryItem49.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inventoryItem49.Location = new System.Drawing.Point(621, 197);
            this.inventoryItem49.Name = "inventoryItem49";
            this.inventoryItem49.ShowItemCount = true;
            this.inventoryItem49.Size = new System.Drawing.Size(42, 42);
            this.inventoryItem49.TabIndex = 41;
            this.inventoryItem49.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.inventoryItem49.Click += new System.EventHandler(this.inventoryItem_Click);
            this.inventoryItem49.MouseEnter += new System.EventHandler(this.inventoryItem_MouseEnter);
            this.inventoryItem49.MouseLeave += new System.EventHandler(this.inventoryItem_MouseLeave);
            this.inventoryItem49.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.inventoryItem_PreviewKeyDown);
            // 
            // inventoryItem30
            // 
            this.inventoryItem30.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inventoryItem30.Location = new System.Drawing.Point(189, 150);
            this.inventoryItem30.Name = "inventoryItem30";
            this.inventoryItem30.ShowItemCount = true;
            this.inventoryItem30.Size = new System.Drawing.Size(42, 42);
            this.inventoryItem30.TabIndex = 40;
            this.inventoryItem30.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.inventoryItem30.Click += new System.EventHandler(this.inventoryItem_Click);
            this.inventoryItem30.MouseEnter += new System.EventHandler(this.inventoryItem_MouseEnter);
            this.inventoryItem30.MouseLeave += new System.EventHandler(this.inventoryItem_MouseLeave);
            this.inventoryItem30.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.inventoryItem_PreviewKeyDown);
            // 
            // inventoryItem31
            // 
            this.inventoryItem31.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inventoryItem31.Location = new System.Drawing.Point(237, 150);
            this.inventoryItem31.Name = "inventoryItem31";
            this.inventoryItem31.ShowItemCount = true;
            this.inventoryItem31.Size = new System.Drawing.Size(42, 42);
            this.inventoryItem31.TabIndex = 39;
            this.inventoryItem31.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.inventoryItem31.Click += new System.EventHandler(this.inventoryItem_Click);
            this.inventoryItem31.MouseEnter += new System.EventHandler(this.inventoryItem_MouseEnter);
            this.inventoryItem31.MouseLeave += new System.EventHandler(this.inventoryItem_MouseLeave);
            this.inventoryItem31.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.inventoryItem_PreviewKeyDown);
            // 
            // inventoryItem32
            // 
            this.inventoryItem32.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inventoryItem32.Location = new System.Drawing.Point(285, 150);
            this.inventoryItem32.Name = "inventoryItem32";
            this.inventoryItem32.ShowItemCount = true;
            this.inventoryItem32.Size = new System.Drawing.Size(42, 42);
            this.inventoryItem32.TabIndex = 38;
            this.inventoryItem32.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.inventoryItem32.Click += new System.EventHandler(this.inventoryItem_Click);
            this.inventoryItem32.MouseEnter += new System.EventHandler(this.inventoryItem_MouseEnter);
            this.inventoryItem32.MouseLeave += new System.EventHandler(this.inventoryItem_MouseLeave);
            this.inventoryItem32.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.inventoryItem_PreviewKeyDown);
            // 
            // inventoryItem33
            // 
            this.inventoryItem33.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inventoryItem33.Location = new System.Drawing.Point(333, 150);
            this.inventoryItem33.Name = "inventoryItem33";
            this.inventoryItem33.ShowItemCount = true;
            this.inventoryItem33.Size = new System.Drawing.Size(42, 42);
            this.inventoryItem33.TabIndex = 37;
            this.inventoryItem33.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.inventoryItem33.Click += new System.EventHandler(this.inventoryItem_Click);
            this.inventoryItem33.MouseEnter += new System.EventHandler(this.inventoryItem_MouseEnter);
            this.inventoryItem33.MouseLeave += new System.EventHandler(this.inventoryItem_MouseLeave);
            this.inventoryItem33.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.inventoryItem_PreviewKeyDown);
            // 
            // inventoryItem34
            // 
            this.inventoryItem34.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inventoryItem34.Location = new System.Drawing.Point(381, 150);
            this.inventoryItem34.Name = "inventoryItem34";
            this.inventoryItem34.ShowItemCount = true;
            this.inventoryItem34.Size = new System.Drawing.Size(42, 42);
            this.inventoryItem34.TabIndex = 36;
            this.inventoryItem34.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.inventoryItem34.Click += new System.EventHandler(this.inventoryItem_Click);
            this.inventoryItem34.MouseEnter += new System.EventHandler(this.inventoryItem_MouseEnter);
            this.inventoryItem34.MouseLeave += new System.EventHandler(this.inventoryItem_MouseLeave);
            this.inventoryItem34.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.inventoryItem_PreviewKeyDown);
            // 
            // inventoryItem35
            // 
            this.inventoryItem35.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inventoryItem35.Location = new System.Drawing.Point(429, 150);
            this.inventoryItem35.Name = "inventoryItem35";
            this.inventoryItem35.ShowItemCount = true;
            this.inventoryItem35.Size = new System.Drawing.Size(42, 42);
            this.inventoryItem35.TabIndex = 35;
            this.inventoryItem35.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.inventoryItem35.Click += new System.EventHandler(this.inventoryItem_Click);
            this.inventoryItem35.MouseEnter += new System.EventHandler(this.inventoryItem_MouseEnter);
            this.inventoryItem35.MouseLeave += new System.EventHandler(this.inventoryItem_MouseLeave);
            this.inventoryItem35.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.inventoryItem_PreviewKeyDown);
            // 
            // inventoryItem36
            // 
            this.inventoryItem36.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inventoryItem36.Location = new System.Drawing.Point(477, 150);
            this.inventoryItem36.Name = "inventoryItem36";
            this.inventoryItem36.ShowItemCount = true;
            this.inventoryItem36.Size = new System.Drawing.Size(42, 42);
            this.inventoryItem36.TabIndex = 34;
            this.inventoryItem36.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.inventoryItem36.Click += new System.EventHandler(this.inventoryItem_Click);
            this.inventoryItem36.MouseEnter += new System.EventHandler(this.inventoryItem_MouseEnter);
            this.inventoryItem36.MouseLeave += new System.EventHandler(this.inventoryItem_MouseLeave);
            this.inventoryItem36.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.inventoryItem_PreviewKeyDown);
            // 
            // inventoryItem37
            // 
            this.inventoryItem37.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inventoryItem37.Location = new System.Drawing.Point(525, 150);
            this.inventoryItem37.Name = "inventoryItem37";
            this.inventoryItem37.ShowItemCount = true;
            this.inventoryItem37.Size = new System.Drawing.Size(42, 42);
            this.inventoryItem37.TabIndex = 33;
            this.inventoryItem37.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.inventoryItem37.Click += new System.EventHandler(this.inventoryItem_Click);
            this.inventoryItem37.MouseEnter += new System.EventHandler(this.inventoryItem_MouseEnter);
            this.inventoryItem37.MouseLeave += new System.EventHandler(this.inventoryItem_MouseLeave);
            this.inventoryItem37.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.inventoryItem_PreviewKeyDown);
            // 
            // inventoryItem38
            // 
            this.inventoryItem38.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inventoryItem38.Location = new System.Drawing.Point(573, 150);
            this.inventoryItem38.Name = "inventoryItem38";
            this.inventoryItem38.ShowItemCount = true;
            this.inventoryItem38.Size = new System.Drawing.Size(42, 42);
            this.inventoryItem38.TabIndex = 32;
            this.inventoryItem38.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.inventoryItem38.Click += new System.EventHandler(this.inventoryItem_Click);
            this.inventoryItem38.MouseEnter += new System.EventHandler(this.inventoryItem_MouseEnter);
            this.inventoryItem38.MouseLeave += new System.EventHandler(this.inventoryItem_MouseLeave);
            this.inventoryItem38.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.inventoryItem_PreviewKeyDown);
            // 
            // inventoryItem39
            // 
            this.inventoryItem39.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inventoryItem39.Location = new System.Drawing.Point(621, 150);
            this.inventoryItem39.Name = "inventoryItem39";
            this.inventoryItem39.ShowItemCount = true;
            this.inventoryItem39.Size = new System.Drawing.Size(42, 42);
            this.inventoryItem39.TabIndex = 31;
            this.inventoryItem39.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.inventoryItem39.Click += new System.EventHandler(this.inventoryItem_Click);
            this.inventoryItem39.MouseEnter += new System.EventHandler(this.inventoryItem_MouseEnter);
            this.inventoryItem39.MouseLeave += new System.EventHandler(this.inventoryItem_MouseLeave);
            this.inventoryItem39.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.inventoryItem_PreviewKeyDown);
            // 
            // inventoryItem20
            // 
            this.inventoryItem20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inventoryItem20.Location = new System.Drawing.Point(189, 103);
            this.inventoryItem20.Name = "inventoryItem20";
            this.inventoryItem20.ShowItemCount = true;
            this.inventoryItem20.Size = new System.Drawing.Size(42, 42);
            this.inventoryItem20.TabIndex = 30;
            this.inventoryItem20.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.inventoryItem20.Click += new System.EventHandler(this.inventoryItem_Click);
            this.inventoryItem20.MouseEnter += new System.EventHandler(this.inventoryItem_MouseEnter);
            this.inventoryItem20.MouseLeave += new System.EventHandler(this.inventoryItem_MouseLeave);
            this.inventoryItem20.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.inventoryItem_PreviewKeyDown);
            // 
            // inventoryItem21
            // 
            this.inventoryItem21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inventoryItem21.Location = new System.Drawing.Point(237, 103);
            this.inventoryItem21.Name = "inventoryItem21";
            this.inventoryItem21.ShowItemCount = true;
            this.inventoryItem21.Size = new System.Drawing.Size(42, 42);
            this.inventoryItem21.TabIndex = 29;
            this.inventoryItem21.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.inventoryItem21.Click += new System.EventHandler(this.inventoryItem_Click);
            this.inventoryItem21.MouseEnter += new System.EventHandler(this.inventoryItem_MouseEnter);
            this.inventoryItem21.MouseLeave += new System.EventHandler(this.inventoryItem_MouseLeave);
            this.inventoryItem21.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.inventoryItem_PreviewKeyDown);
            // 
            // inventoryItem22
            // 
            this.inventoryItem22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inventoryItem22.Location = new System.Drawing.Point(285, 103);
            this.inventoryItem22.Name = "inventoryItem22";
            this.inventoryItem22.ShowItemCount = true;
            this.inventoryItem22.Size = new System.Drawing.Size(42, 42);
            this.inventoryItem22.TabIndex = 28;
            this.inventoryItem22.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.inventoryItem22.Click += new System.EventHandler(this.inventoryItem_Click);
            this.inventoryItem22.MouseEnter += new System.EventHandler(this.inventoryItem_MouseEnter);
            this.inventoryItem22.MouseLeave += new System.EventHandler(this.inventoryItem_MouseLeave);
            this.inventoryItem22.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.inventoryItem_PreviewKeyDown);
            // 
            // inventoryItem23
            // 
            this.inventoryItem23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inventoryItem23.Location = new System.Drawing.Point(333, 103);
            this.inventoryItem23.Name = "inventoryItem23";
            this.inventoryItem23.ShowItemCount = true;
            this.inventoryItem23.Size = new System.Drawing.Size(42, 42);
            this.inventoryItem23.TabIndex = 27;
            this.inventoryItem23.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.inventoryItem23.Click += new System.EventHandler(this.inventoryItem_Click);
            this.inventoryItem23.MouseEnter += new System.EventHandler(this.inventoryItem_MouseEnter);
            this.inventoryItem23.MouseLeave += new System.EventHandler(this.inventoryItem_MouseLeave);
            this.inventoryItem23.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.inventoryItem_PreviewKeyDown);
            // 
            // inventoryItem24
            // 
            this.inventoryItem24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inventoryItem24.Location = new System.Drawing.Point(381, 103);
            this.inventoryItem24.Name = "inventoryItem24";
            this.inventoryItem24.ShowItemCount = true;
            this.inventoryItem24.Size = new System.Drawing.Size(42, 42);
            this.inventoryItem24.TabIndex = 26;
            this.inventoryItem24.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.inventoryItem24.Click += new System.EventHandler(this.inventoryItem_Click);
            this.inventoryItem24.MouseEnter += new System.EventHandler(this.inventoryItem_MouseEnter);
            this.inventoryItem24.MouseLeave += new System.EventHandler(this.inventoryItem_MouseLeave);
            this.inventoryItem24.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.inventoryItem_PreviewKeyDown);
            // 
            // inventoryItem25
            // 
            this.inventoryItem25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inventoryItem25.Location = new System.Drawing.Point(429, 103);
            this.inventoryItem25.Name = "inventoryItem25";
            this.inventoryItem25.ShowItemCount = true;
            this.inventoryItem25.Size = new System.Drawing.Size(42, 42);
            this.inventoryItem25.TabIndex = 25;
            this.inventoryItem25.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.inventoryItem25.Click += new System.EventHandler(this.inventoryItem_Click);
            this.inventoryItem25.MouseEnter += new System.EventHandler(this.inventoryItem_MouseEnter);
            this.inventoryItem25.MouseLeave += new System.EventHandler(this.inventoryItem_MouseLeave);
            this.inventoryItem25.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.inventoryItem_PreviewKeyDown);
            // 
            // inventoryItem26
            // 
            this.inventoryItem26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inventoryItem26.Location = new System.Drawing.Point(477, 103);
            this.inventoryItem26.Name = "inventoryItem26";
            this.inventoryItem26.ShowItemCount = true;
            this.inventoryItem26.Size = new System.Drawing.Size(42, 42);
            this.inventoryItem26.TabIndex = 24;
            this.inventoryItem26.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.inventoryItem26.Click += new System.EventHandler(this.inventoryItem_Click);
            this.inventoryItem26.MouseEnter += new System.EventHandler(this.inventoryItem_MouseEnter);
            this.inventoryItem26.MouseLeave += new System.EventHandler(this.inventoryItem_MouseLeave);
            this.inventoryItem26.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.inventoryItem_PreviewKeyDown);
            // 
            // inventoryItem27
            // 
            this.inventoryItem27.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inventoryItem27.Location = new System.Drawing.Point(525, 103);
            this.inventoryItem27.Name = "inventoryItem27";
            this.inventoryItem27.ShowItemCount = true;
            this.inventoryItem27.Size = new System.Drawing.Size(42, 42);
            this.inventoryItem27.TabIndex = 23;
            this.inventoryItem27.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.inventoryItem27.Click += new System.EventHandler(this.inventoryItem_Click);
            this.inventoryItem27.MouseEnter += new System.EventHandler(this.inventoryItem_MouseEnter);
            this.inventoryItem27.MouseLeave += new System.EventHandler(this.inventoryItem_MouseLeave);
            this.inventoryItem27.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.inventoryItem_PreviewKeyDown);
            // 
            // inventoryItem28
            // 
            this.inventoryItem28.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inventoryItem28.Location = new System.Drawing.Point(573, 103);
            this.inventoryItem28.Name = "inventoryItem28";
            this.inventoryItem28.ShowItemCount = true;
            this.inventoryItem28.Size = new System.Drawing.Size(42, 42);
            this.inventoryItem28.TabIndex = 22;
            this.inventoryItem28.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.inventoryItem28.Click += new System.EventHandler(this.inventoryItem_Click);
            this.inventoryItem28.MouseEnter += new System.EventHandler(this.inventoryItem_MouseEnter);
            this.inventoryItem28.MouseLeave += new System.EventHandler(this.inventoryItem_MouseLeave);
            this.inventoryItem28.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.inventoryItem_PreviewKeyDown);
            // 
            // inventoryItem29
            // 
            this.inventoryItem29.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inventoryItem29.Location = new System.Drawing.Point(621, 103);
            this.inventoryItem29.Name = "inventoryItem29";
            this.inventoryItem29.ShowItemCount = true;
            this.inventoryItem29.Size = new System.Drawing.Size(42, 42);
            this.inventoryItem29.TabIndex = 21;
            this.inventoryItem29.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.inventoryItem29.Click += new System.EventHandler(this.inventoryItem_Click);
            this.inventoryItem29.MouseEnter += new System.EventHandler(this.inventoryItem_MouseEnter);
            this.inventoryItem29.MouseLeave += new System.EventHandler(this.inventoryItem_MouseLeave);
            this.inventoryItem29.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.inventoryItem_PreviewKeyDown);
            // 
            // inventoryItem10
            // 
            this.inventoryItem10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inventoryItem10.Location = new System.Drawing.Point(189, 56);
            this.inventoryItem10.Name = "inventoryItem10";
            this.inventoryItem10.ShowItemCount = true;
            this.inventoryItem10.Size = new System.Drawing.Size(42, 42);
            this.inventoryItem10.TabIndex = 20;
            this.inventoryItem10.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.inventoryItem10.Click += new System.EventHandler(this.inventoryItem_Click);
            this.inventoryItem10.MouseEnter += new System.EventHandler(this.inventoryItem_MouseEnter);
            this.inventoryItem10.MouseLeave += new System.EventHandler(this.inventoryItem_MouseLeave);
            this.inventoryItem10.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.inventoryItem_PreviewKeyDown);
            // 
            // inventoryItem11
            // 
            this.inventoryItem11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inventoryItem11.Location = new System.Drawing.Point(237, 56);
            this.inventoryItem11.Name = "inventoryItem11";
            this.inventoryItem11.ShowItemCount = true;
            this.inventoryItem11.Size = new System.Drawing.Size(42, 42);
            this.inventoryItem11.TabIndex = 19;
            this.inventoryItem11.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.inventoryItem11.Click += new System.EventHandler(this.inventoryItem_Click);
            this.inventoryItem11.MouseEnter += new System.EventHandler(this.inventoryItem_MouseEnter);
            this.inventoryItem11.MouseLeave += new System.EventHandler(this.inventoryItem_MouseLeave);
            this.inventoryItem11.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.inventoryItem_PreviewKeyDown);
            // 
            // inventoryItem12
            // 
            this.inventoryItem12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inventoryItem12.Location = new System.Drawing.Point(285, 56);
            this.inventoryItem12.Name = "inventoryItem12";
            this.inventoryItem12.ShowItemCount = true;
            this.inventoryItem12.Size = new System.Drawing.Size(42, 42);
            this.inventoryItem12.TabIndex = 18;
            this.inventoryItem12.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.inventoryItem12.Click += new System.EventHandler(this.inventoryItem_Click);
            this.inventoryItem12.MouseEnter += new System.EventHandler(this.inventoryItem_MouseEnter);
            this.inventoryItem12.MouseLeave += new System.EventHandler(this.inventoryItem_MouseLeave);
            this.inventoryItem12.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.inventoryItem_PreviewKeyDown);
            // 
            // inventoryItem13
            // 
            this.inventoryItem13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inventoryItem13.Location = new System.Drawing.Point(333, 56);
            this.inventoryItem13.Name = "inventoryItem13";
            this.inventoryItem13.ShowItemCount = true;
            this.inventoryItem13.Size = new System.Drawing.Size(42, 42);
            this.inventoryItem13.TabIndex = 17;
            this.inventoryItem13.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.inventoryItem13.Click += new System.EventHandler(this.inventoryItem_Click);
            this.inventoryItem13.MouseEnter += new System.EventHandler(this.inventoryItem_MouseEnter);
            this.inventoryItem13.MouseLeave += new System.EventHandler(this.inventoryItem_MouseLeave);
            this.inventoryItem13.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.inventoryItem_PreviewKeyDown);
            // 
            // inventoryItem14
            // 
            this.inventoryItem14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inventoryItem14.Location = new System.Drawing.Point(381, 56);
            this.inventoryItem14.Name = "inventoryItem14";
            this.inventoryItem14.ShowItemCount = true;
            this.inventoryItem14.Size = new System.Drawing.Size(42, 42);
            this.inventoryItem14.TabIndex = 16;
            this.inventoryItem14.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.inventoryItem14.Click += new System.EventHandler(this.inventoryItem_Click);
            this.inventoryItem14.MouseEnter += new System.EventHandler(this.inventoryItem_MouseEnter);
            this.inventoryItem14.MouseLeave += new System.EventHandler(this.inventoryItem_MouseLeave);
            this.inventoryItem14.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.inventoryItem_PreviewKeyDown);
            // 
            // inventoryItem15
            // 
            this.inventoryItem15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inventoryItem15.Location = new System.Drawing.Point(429, 56);
            this.inventoryItem15.Name = "inventoryItem15";
            this.inventoryItem15.ShowItemCount = true;
            this.inventoryItem15.Size = new System.Drawing.Size(42, 42);
            this.inventoryItem15.TabIndex = 15;
            this.inventoryItem15.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.inventoryItem15.Click += new System.EventHandler(this.inventoryItem_Click);
            this.inventoryItem15.MouseEnter += new System.EventHandler(this.inventoryItem_MouseEnter);
            this.inventoryItem15.MouseLeave += new System.EventHandler(this.inventoryItem_MouseLeave);
            this.inventoryItem15.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.inventoryItem_PreviewKeyDown);
            // 
            // inventoryItem16
            // 
            this.inventoryItem16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inventoryItem16.Location = new System.Drawing.Point(477, 56);
            this.inventoryItem16.Name = "inventoryItem16";
            this.inventoryItem16.ShowItemCount = true;
            this.inventoryItem16.Size = new System.Drawing.Size(42, 42);
            this.inventoryItem16.TabIndex = 14;
            this.inventoryItem16.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.inventoryItem16.Click += new System.EventHandler(this.inventoryItem_Click);
            this.inventoryItem16.MouseEnter += new System.EventHandler(this.inventoryItem_MouseEnter);
            this.inventoryItem16.MouseLeave += new System.EventHandler(this.inventoryItem_MouseLeave);
            this.inventoryItem16.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.inventoryItem_PreviewKeyDown);
            // 
            // inventoryItem17
            // 
            this.inventoryItem17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inventoryItem17.Location = new System.Drawing.Point(525, 56);
            this.inventoryItem17.Name = "inventoryItem17";
            this.inventoryItem17.ShowItemCount = true;
            this.inventoryItem17.Size = new System.Drawing.Size(42, 42);
            this.inventoryItem17.TabIndex = 13;
            this.inventoryItem17.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.inventoryItem17.Click += new System.EventHandler(this.inventoryItem_Click);
            this.inventoryItem17.MouseEnter += new System.EventHandler(this.inventoryItem_MouseEnter);
            this.inventoryItem17.MouseLeave += new System.EventHandler(this.inventoryItem_MouseLeave);
            this.inventoryItem17.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.inventoryItem_PreviewKeyDown);
            // 
            // inventoryItem18
            // 
            this.inventoryItem18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inventoryItem18.Location = new System.Drawing.Point(573, 56);
            this.inventoryItem18.Name = "inventoryItem18";
            this.inventoryItem18.ShowItemCount = true;
            this.inventoryItem18.Size = new System.Drawing.Size(42, 42);
            this.inventoryItem18.TabIndex = 12;
            this.inventoryItem18.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.inventoryItem18.Click += new System.EventHandler(this.inventoryItem_Click);
            this.inventoryItem18.MouseEnter += new System.EventHandler(this.inventoryItem_MouseEnter);
            this.inventoryItem18.MouseLeave += new System.EventHandler(this.inventoryItem_MouseLeave);
            this.inventoryItem18.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.inventoryItem_PreviewKeyDown);
            // 
            // inventoryItem19
            // 
            this.inventoryItem19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inventoryItem19.Location = new System.Drawing.Point(621, 56);
            this.inventoryItem19.Name = "inventoryItem19";
            this.inventoryItem19.ShowItemCount = true;
            this.inventoryItem19.Size = new System.Drawing.Size(42, 42);
            this.inventoryItem19.TabIndex = 11;
            this.inventoryItem19.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.inventoryItem19.Click += new System.EventHandler(this.inventoryItem_Click);
            this.inventoryItem19.MouseEnter += new System.EventHandler(this.inventoryItem_MouseEnter);
            this.inventoryItem19.MouseLeave += new System.EventHandler(this.inventoryItem_MouseLeave);
            this.inventoryItem19.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.inventoryItem_PreviewKeyDown);
            // 
            // inventoryItem09
            // 
            this.inventoryItem09.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inventoryItem09.Location = new System.Drawing.Point(621, 9);
            this.inventoryItem09.Name = "inventoryItem09";
            this.inventoryItem09.ShowItemCount = true;
            this.inventoryItem09.Size = new System.Drawing.Size(42, 42);
            this.inventoryItem09.TabIndex = 10;
            this.inventoryItem09.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.inventoryItem09.Click += new System.EventHandler(this.inventoryItem_Click);
            this.inventoryItem09.MouseEnter += new System.EventHandler(this.inventoryItem_MouseEnter);
            this.inventoryItem09.MouseLeave += new System.EventHandler(this.inventoryItem_MouseLeave);
            this.inventoryItem09.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.inventoryItem_PreviewKeyDown);
            // 
            // inventoryItem08
            // 
            this.inventoryItem08.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inventoryItem08.Location = new System.Drawing.Point(573, 9);
            this.inventoryItem08.Name = "inventoryItem08";
            this.inventoryItem08.ShowItemCount = true;
            this.inventoryItem08.Size = new System.Drawing.Size(42, 42);
            this.inventoryItem08.TabIndex = 9;
            this.inventoryItem08.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.inventoryItem08.Click += new System.EventHandler(this.inventoryItem_Click);
            this.inventoryItem08.MouseEnter += new System.EventHandler(this.inventoryItem_MouseEnter);
            this.inventoryItem08.MouseLeave += new System.EventHandler(this.inventoryItem_MouseLeave);
            this.inventoryItem08.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.inventoryItem_PreviewKeyDown);
            // 
            // inventoryItem07
            // 
            this.inventoryItem07.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inventoryItem07.Location = new System.Drawing.Point(525, 9);
            this.inventoryItem07.Name = "inventoryItem07";
            this.inventoryItem07.ShowItemCount = true;
            this.inventoryItem07.Size = new System.Drawing.Size(42, 42);
            this.inventoryItem07.TabIndex = 8;
            this.inventoryItem07.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.inventoryItem07.Click += new System.EventHandler(this.inventoryItem_Click);
            this.inventoryItem07.MouseEnter += new System.EventHandler(this.inventoryItem_MouseEnter);
            this.inventoryItem07.MouseLeave += new System.EventHandler(this.inventoryItem_MouseLeave);
            this.inventoryItem07.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.inventoryItem_PreviewKeyDown);
            // 
            // inventoryItem06
            // 
            this.inventoryItem06.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inventoryItem06.Location = new System.Drawing.Point(477, 9);
            this.inventoryItem06.Name = "inventoryItem06";
            this.inventoryItem06.ShowItemCount = true;
            this.inventoryItem06.Size = new System.Drawing.Size(42, 42);
            this.inventoryItem06.TabIndex = 7;
            this.inventoryItem06.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.inventoryItem06.Click += new System.EventHandler(this.inventoryItem_Click);
            this.inventoryItem06.MouseEnter += new System.EventHandler(this.inventoryItem_MouseEnter);
            this.inventoryItem06.MouseLeave += new System.EventHandler(this.inventoryItem_MouseLeave);
            this.inventoryItem06.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.inventoryItem_PreviewKeyDown);
            // 
            // inventoryItem05
            // 
            this.inventoryItem05.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inventoryItem05.Location = new System.Drawing.Point(429, 9);
            this.inventoryItem05.Name = "inventoryItem05";
            this.inventoryItem05.ShowItemCount = true;
            this.inventoryItem05.Size = new System.Drawing.Size(42, 42);
            this.inventoryItem05.TabIndex = 6;
            this.inventoryItem05.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.inventoryItem05.Click += new System.EventHandler(this.inventoryItem_Click);
            this.inventoryItem05.MouseEnter += new System.EventHandler(this.inventoryItem_MouseEnter);
            this.inventoryItem05.MouseLeave += new System.EventHandler(this.inventoryItem_MouseLeave);
            this.inventoryItem05.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.inventoryItem_PreviewKeyDown);
            // 
            // inventoryItem04
            // 
            this.inventoryItem04.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inventoryItem04.Location = new System.Drawing.Point(381, 9);
            this.inventoryItem04.Name = "inventoryItem04";
            this.inventoryItem04.ShowItemCount = true;
            this.inventoryItem04.Size = new System.Drawing.Size(42, 42);
            this.inventoryItem04.TabIndex = 5;
            this.inventoryItem04.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.inventoryItem04.Click += new System.EventHandler(this.inventoryItem_Click);
            this.inventoryItem04.MouseEnter += new System.EventHandler(this.inventoryItem_MouseEnter);
            this.inventoryItem04.MouseLeave += new System.EventHandler(this.inventoryItem_MouseLeave);
            this.inventoryItem04.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.inventoryItem_PreviewKeyDown);
            // 
            // inventoryItem03
            // 
            this.inventoryItem03.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inventoryItem03.Location = new System.Drawing.Point(333, 9);
            this.inventoryItem03.Name = "inventoryItem03";
            this.inventoryItem03.ShowItemCount = true;
            this.inventoryItem03.Size = new System.Drawing.Size(42, 42);
            this.inventoryItem03.TabIndex = 4;
            this.inventoryItem03.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.inventoryItem03.Click += new System.EventHandler(this.inventoryItem_Click);
            this.inventoryItem03.MouseEnter += new System.EventHandler(this.inventoryItem_MouseEnter);
            this.inventoryItem03.MouseLeave += new System.EventHandler(this.inventoryItem_MouseLeave);
            this.inventoryItem03.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.inventoryItem_PreviewKeyDown);
            // 
            // inventoryItem02
            // 
            this.inventoryItem02.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inventoryItem02.Location = new System.Drawing.Point(285, 9);
            this.inventoryItem02.Name = "inventoryItem02";
            this.inventoryItem02.ShowItemCount = true;
            this.inventoryItem02.Size = new System.Drawing.Size(42, 42);
            this.inventoryItem02.TabIndex = 3;
            this.inventoryItem02.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.inventoryItem02.Click += new System.EventHandler(this.inventoryItem_Click);
            this.inventoryItem02.MouseEnter += new System.EventHandler(this.inventoryItem_MouseEnter);
            this.inventoryItem02.MouseLeave += new System.EventHandler(this.inventoryItem_MouseLeave);
            this.inventoryItem02.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.inventoryItem_PreviewKeyDown);
            // 
            // inventoryItem01
            // 
            this.inventoryItem01.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inventoryItem01.Location = new System.Drawing.Point(237, 9);
            this.inventoryItem01.Name = "inventoryItem01";
            this.inventoryItem01.ShowItemCount = true;
            this.inventoryItem01.Size = new System.Drawing.Size(42, 42);
            this.inventoryItem01.TabIndex = 1;
            this.inventoryItem01.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.inventoryItem01.Click += new System.EventHandler(this.inventoryItem_Click);
            this.inventoryItem01.MouseEnter += new System.EventHandler(this.inventoryItem_MouseEnter);
            this.inventoryItem01.MouseLeave += new System.EventHandler(this.inventoryItem_MouseLeave);
            this.inventoryItem01.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.inventoryItem_PreviewKeyDown);
            // 
            // inventoryItem00
            // 
            this.inventoryItem00.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inventoryItem00.Location = new System.Drawing.Point(189, 9);
            this.inventoryItem00.Name = "inventoryItem00";
            this.inventoryItem00.ShowItemCount = true;
            this.inventoryItem00.Size = new System.Drawing.Size(42, 42);
            this.inventoryItem00.TabIndex = 2;
            this.inventoryItem00.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.inventoryItem00.Click += new System.EventHandler(this.inventoryItem_Click);
            this.inventoryItem00.MouseEnter += new System.EventHandler(this.inventoryItem_MouseEnter);
            this.inventoryItem00.MouseLeave += new System.EventHandler(this.inventoryItem_MouseLeave);
            this.inventoryItem00.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.inventoryItem_PreviewKeyDown);
            // 
            // tpEquipment
            // 
            this.tpEquipment.Controls.Add(this.equipmentItem23);
            this.tpEquipment.Controls.Add(this.equipmentItem22);
            this.tpEquipment.Controls.Add(this.equipmentItem21);
            this.tpEquipment.Controls.Add(this.equipmentItem20);
            this.tpEquipment.Controls.Add(this.equipmentItem19);
            this.tpEquipment.Controls.Add(this.label31);
            this.tpEquipment.Controls.Add(this.equipmentItem18);
            this.tpEquipment.Controls.Add(this.equipmentItem17);
            this.tpEquipment.Controls.Add(this.equipmentItem16);
            this.tpEquipment.Controls.Add(this.equipmentItem15);
            this.tpEquipment.Controls.Add(this.equipmentItem14);
            this.tpEquipment.Controls.Add(this.btnLoadEquipmentSet);
            this.tpEquipment.Controls.Add(this.btnSaveEquipmentSet);
            this.tpEquipment.Controls.Add(this.label23);
            this.tpEquipment.Controls.Add(this.label22);
            this.tpEquipment.Controls.Add(this.label21);
            this.tpEquipment.Controls.Add(this.label20);
            this.tpEquipment.Controls.Add(this.groupBox7);
            this.tpEquipment.Controls.Add(this.equipmentItem13);
            this.tpEquipment.Controls.Add(this.equipmentItem12);
            this.tpEquipment.Controls.Add(this.equipmentItem11);
            this.tpEquipment.Controls.Add(this.equipmentItem10);
            this.tpEquipment.Controls.Add(this.equipmentItem09);
            this.tpEquipment.Controls.Add(this.equipmentItem08);
            this.tpEquipment.Controls.Add(this.equipmentItem07);
            this.tpEquipment.Controls.Add(this.equipmentItem06);
            this.tpEquipment.Controls.Add(this.equipmentItem05);
            this.tpEquipment.Controls.Add(this.equipmentItem04);
            this.tpEquipment.Controls.Add(this.equipmentItem03);
            this.tpEquipment.Controls.Add(this.equipmentItem02);
            this.tpEquipment.Controls.Add(this.equipmentItem01);
            this.tpEquipment.Controls.Add(this.equipmentItem00);
            this.tpEquipment.Location = new System.Drawing.Point(4, 22);
            this.tpEquipment.Name = "tpEquipment";
            this.tpEquipment.Size = new System.Drawing.Size(612, 413);
            this.tpEquipment.TabIndex = 3;
            this.tpEquipment.Text = "Equipment";
            this.tpEquipment.UseVisualStyleBackColor = true;
            // 
            // equipmentItem23
            // 
            this.equipmentItem23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.equipmentItem23.Location = new System.Drawing.Point(505, 355);
            this.equipmentItem23.Name = "equipmentItem23";
            this.equipmentItem23.ShowItemCount = true;
            this.equipmentItem23.Size = new System.Drawing.Size(42, 42);
            this.equipmentItem23.TabIndex = 33;
            this.equipmentItem23.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.equipmentItem23.Click += new System.EventHandler(this.equipmentItem_Click);
            this.equipmentItem23.MouseEnter += new System.EventHandler(this.equipmentItem_MouseEnter);
            this.equipmentItem23.MouseLeave += new System.EventHandler(this.equipmentItem_MouseLeave);
            // 
            // equipmentItem22
            // 
            this.equipmentItem22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.equipmentItem22.Location = new System.Drawing.Point(505, 308);
            this.equipmentItem22.Name = "equipmentItem22";
            this.equipmentItem22.ShowItemCount = true;
            this.equipmentItem22.Size = new System.Drawing.Size(42, 42);
            this.equipmentItem22.TabIndex = 32;
            this.equipmentItem22.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.equipmentItem22.Click += new System.EventHandler(this.equipmentItem_Click);
            this.equipmentItem22.MouseEnter += new System.EventHandler(this.equipmentItem_MouseEnter);
            this.equipmentItem22.MouseLeave += new System.EventHandler(this.equipmentItem_MouseLeave);
            // 
            // equipmentItem21
            // 
            this.equipmentItem21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.equipmentItem21.Location = new System.Drawing.Point(505, 261);
            this.equipmentItem21.Name = "equipmentItem21";
            this.equipmentItem21.ShowItemCount = true;
            this.equipmentItem21.Size = new System.Drawing.Size(42, 42);
            this.equipmentItem21.TabIndex = 31;
            this.equipmentItem21.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.equipmentItem21.Click += new System.EventHandler(this.equipmentItem_Click);
            this.equipmentItem21.MouseEnter += new System.EventHandler(this.equipmentItem_MouseEnter);
            this.equipmentItem21.MouseLeave += new System.EventHandler(this.equipmentItem_MouseLeave);
            // 
            // equipmentItem20
            // 
            this.equipmentItem20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.equipmentItem20.Location = new System.Drawing.Point(505, 214);
            this.equipmentItem20.Name = "equipmentItem20";
            this.equipmentItem20.ShowItemCount = true;
            this.equipmentItem20.Size = new System.Drawing.Size(42, 42);
            this.equipmentItem20.TabIndex = 30;
            this.equipmentItem20.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.equipmentItem20.Click += new System.EventHandler(this.equipmentItem_Click);
            this.equipmentItem20.MouseEnter += new System.EventHandler(this.equipmentItem_MouseEnter);
            this.equipmentItem20.MouseLeave += new System.EventHandler(this.equipmentItem_MouseLeave);
            // 
            // equipmentItem19
            // 
            this.equipmentItem19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.equipmentItem19.Location = new System.Drawing.Point(505, 167);
            this.equipmentItem19.Name = "equipmentItem19";
            this.equipmentItem19.ShowItemCount = true;
            this.equipmentItem19.Size = new System.Drawing.Size(42, 42);
            this.equipmentItem19.TabIndex = 29;
            this.equipmentItem19.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.equipmentItem19.Click += new System.EventHandler(this.equipmentItem_Click);
            this.equipmentItem19.MouseEnter += new System.EventHandler(this.equipmentItem_MouseEnter);
            this.equipmentItem19.MouseLeave += new System.EventHandler(this.equipmentItem_MouseLeave);
            // 
            // label31
            // 
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(488, 126);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(78, 36);
            this.label31.TabIndex = 28;
            this.label31.Text = "(Social)\r\nAccessories";
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // equipmentItem18
            // 
            this.equipmentItem18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.equipmentItem18.Location = new System.Drawing.Point(434, 355);
            this.equipmentItem18.Name = "equipmentItem18";
            this.equipmentItem18.ShowItemCount = true;
            this.equipmentItem18.Size = new System.Drawing.Size(42, 42);
            this.equipmentItem18.TabIndex = 27;
            this.equipmentItem18.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.equipmentItem18.Click += new System.EventHandler(this.equipmentItem_Click);
            this.equipmentItem18.MouseEnter += new System.EventHandler(this.equipmentItem_MouseEnter);
            this.equipmentItem18.MouseLeave += new System.EventHandler(this.equipmentItem_MouseLeave);
            // 
            // equipmentItem17
            // 
            this.equipmentItem17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.equipmentItem17.Location = new System.Drawing.Point(434, 308);
            this.equipmentItem17.Name = "equipmentItem17";
            this.equipmentItem17.ShowItemCount = true;
            this.equipmentItem17.Size = new System.Drawing.Size(42, 42);
            this.equipmentItem17.TabIndex = 26;
            this.equipmentItem17.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.equipmentItem17.Click += new System.EventHandler(this.equipmentItem_Click);
            this.equipmentItem17.MouseEnter += new System.EventHandler(this.equipmentItem_MouseEnter);
            this.equipmentItem17.MouseLeave += new System.EventHandler(this.equipmentItem_MouseLeave);
            // 
            // equipmentItem16
            // 
            this.equipmentItem16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.equipmentItem16.Location = new System.Drawing.Point(434, 261);
            this.equipmentItem16.Name = "equipmentItem16";
            this.equipmentItem16.ShowItemCount = true;
            this.equipmentItem16.Size = new System.Drawing.Size(42, 42);
            this.equipmentItem16.TabIndex = 25;
            this.equipmentItem16.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.equipmentItem16.Click += new System.EventHandler(this.equipmentItem_Click);
            this.equipmentItem16.MouseEnter += new System.EventHandler(this.equipmentItem_MouseEnter);
            this.equipmentItem16.MouseLeave += new System.EventHandler(this.equipmentItem_MouseLeave);
            // 
            // equipmentItem15
            // 
            this.equipmentItem15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.equipmentItem15.Location = new System.Drawing.Point(434, 214);
            this.equipmentItem15.Name = "equipmentItem15";
            this.equipmentItem15.ShowItemCount = true;
            this.equipmentItem15.Size = new System.Drawing.Size(42, 42);
            this.equipmentItem15.TabIndex = 24;
            this.equipmentItem15.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.equipmentItem15.Click += new System.EventHandler(this.equipmentItem_Click);
            this.equipmentItem15.MouseEnter += new System.EventHandler(this.equipmentItem_MouseEnter);
            this.equipmentItem15.MouseLeave += new System.EventHandler(this.equipmentItem_MouseLeave);
            // 
            // equipmentItem14
            // 
            this.equipmentItem14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.equipmentItem14.Location = new System.Drawing.Point(434, 167);
            this.equipmentItem14.Name = "equipmentItem14";
            this.equipmentItem14.ShowItemCount = true;
            this.equipmentItem14.Size = new System.Drawing.Size(42, 42);
            this.equipmentItem14.TabIndex = 23;
            this.equipmentItem14.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.equipmentItem14.Click += new System.EventHandler(this.equipmentItem_Click);
            this.equipmentItem14.MouseEnter += new System.EventHandler(this.equipmentItem_MouseEnter);
            this.equipmentItem14.MouseLeave += new System.EventHandler(this.equipmentItem_MouseLeave);
            // 
            // btnLoadEquipmentSet
            // 
            this.btnLoadEquipmentSet.Location = new System.Drawing.Point(214, 368);
            this.btnLoadEquipmentSet.Name = "btnLoadEquipmentSet";
            this.btnLoadEquipmentSet.Size = new System.Drawing.Size(120, 23);
            this.btnLoadEquipmentSet.TabIndex = 22;
            this.btnLoadEquipmentSet.Text = "Load Equipment Set";
            this.btnLoadEquipmentSet.UseVisualStyleBackColor = true;
            this.btnLoadEquipmentSet.Click += new System.EventHandler(this.btnLoadEquipmentSet_Click);
            // 
            // btnSaveEquipmentSet
            // 
            this.btnSaveEquipmentSet.Location = new System.Drawing.Point(214, 339);
            this.btnSaveEquipmentSet.Name = "btnSaveEquipmentSet";
            this.btnSaveEquipmentSet.Size = new System.Drawing.Size(120, 23);
            this.btnSaveEquipmentSet.TabIndex = 21;
            this.btnSaveEquipmentSet.Text = "Save Equipment Set";
            this.btnSaveEquipmentSet.UseVisualStyleBackColor = true;
            this.btnSaveEquipmentSet.Click += new System.EventHandler(this.btnSaveEquipmentSet_Click);
            // 
            // label23
            // 
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(415, 139);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(78, 23);
            this.label23.TabIndex = 20;
            this.label23.Text = "Accessories";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label22
            // 
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(347, 3);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(45, 23);
            this.label22.TabIndex = 14;
            this.label22.Text = "Dye";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label21
            // 
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(289, 3);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(45, 23);
            this.label21.TabIndex = 10;
            this.label21.Text = "Vanity";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(234, 3);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(42, 23);
            this.label20.TabIndex = 9;
            this.label20.Text = "Armor";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label29);
            this.groupBox7.Controls.Add(this.cboEquipmentPrefixCategory);
            this.groupBox7.Controls.Add(this.label19);
            this.groupBox7.Controls.Add(this.cboEquipmentPrefix);
            this.groupBox7.Controls.Add(this.label18);
            this.groupBox7.Controls.Add(this.txtEquipmentFilter);
            this.groupBox7.Controls.Add(this.lstEquipmentItems);
            this.groupBox7.Location = new System.Drawing.Point(8, 3);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(200, 394);
            this.groupBox7.TabIndex = 0;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Item Editor";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(6, 303);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(97, 13);
            this.label29.TabIndex = 6;
            this.label29.Text = "Prefix Category:";
            // 
            // cboEquipmentPrefixCategory
            // 
            this.cboEquipmentPrefixCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEquipmentPrefixCategory.FormattingEnabled = true;
            this.cboEquipmentPrefixCategory.Items.AddRange(new object[] {
            "All",
            "Universal",
            "Common",
            "Melee",
            "Ranged",
            "Magic",
            "Accessories"});
            this.cboEquipmentPrefixCategory.Location = new System.Drawing.Point(6, 319);
            this.cboEquipmentPrefixCategory.Name = "cboEquipmentPrefixCategory";
            this.cboEquipmentPrefixCategory.Size = new System.Drawing.Size(188, 21);
            this.cboEquipmentPrefixCategory.TabIndex = 5;
            this.cboEquipmentPrefixCategory.SelectedIndexChanged += new System.EventHandler(this.cboEquipmentPrefixCategory_SelectedIndexChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(6, 348);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(71, 13);
            this.label19.TabIndex = 4;
            this.label19.Text = "Item Prefix:";
            // 
            // cboEquipmentPrefix
            // 
            this.cboEquipmentPrefix.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEquipmentPrefix.FormattingEnabled = true;
            this.cboEquipmentPrefix.Location = new System.Drawing.Point(6, 367);
            this.cboEquipmentPrefix.Name = "cboEquipmentPrefix";
            this.cboEquipmentPrefix.Size = new System.Drawing.Size(188, 21);
            this.cboEquipmentPrefix.TabIndex = 3;
            this.cboEquipmentPrefix.SelectedIndexChanged += new System.EventHandler(this.cboEquipmentPrefix_SelectedIndexChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(6, 22);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(67, 13);
            this.label18.TabIndex = 2;
            this.label18.Text = "Item Filter:";
            // 
            // txtEquipmentFilter
            // 
            this.txtEquipmentFilter.Location = new System.Drawing.Point(79, 19);
            this.txtEquipmentFilter.Name = "txtEquipmentFilter";
            this.txtEquipmentFilter.Size = new System.Drawing.Size(115, 20);
            this.txtEquipmentFilter.TabIndex = 1;
            this.txtEquipmentFilter.TextChanged += new System.EventHandler(this.txtEquipmentFilter_TextChanged);
            // 
            // lstEquipmentItems
            // 
            this.lstEquipmentItems.FormattingEnabled = true;
            this.lstEquipmentItems.Location = new System.Drawing.Point(6, 45);
            this.lstEquipmentItems.Name = "lstEquipmentItems";
            this.lstEquipmentItems.Size = new System.Drawing.Size(188, 251);
            this.lstEquipmentItems.TabIndex = 0;
            this.lstEquipmentItems.SelectedIndexChanged += new System.EventHandler(this.lstEquipmentItems_SelectedIndexChanged);
            // 
            // equipmentItem13
            // 
            this.equipmentItem13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.equipmentItem13.Location = new System.Drawing.Point(350, 355);
            this.equipmentItem13.Name = "equipmentItem13";
            this.equipmentItem13.ShowItemCount = true;
            this.equipmentItem13.Size = new System.Drawing.Size(42, 42);
            this.equipmentItem13.TabIndex = 19;
            this.equipmentItem13.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.equipmentItem13.Click += new System.EventHandler(this.equipmentItem_Click);
            this.equipmentItem13.MouseEnter += new System.EventHandler(this.equipmentItem_MouseEnter);
            this.equipmentItem13.MouseLeave += new System.EventHandler(this.equipmentItem_MouseLeave);
            this.equipmentItem13.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.equipmentItem_PreviewKeyDown);
            // 
            // equipmentItem12
            // 
            this.equipmentItem12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.equipmentItem12.Location = new System.Drawing.Point(350, 308);
            this.equipmentItem12.Name = "equipmentItem12";
            this.equipmentItem12.ShowItemCount = true;
            this.equipmentItem12.Size = new System.Drawing.Size(42, 42);
            this.equipmentItem12.TabIndex = 18;
            this.equipmentItem12.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.equipmentItem12.Click += new System.EventHandler(this.equipmentItem_Click);
            this.equipmentItem12.MouseEnter += new System.EventHandler(this.equipmentItem_MouseEnter);
            this.equipmentItem12.MouseLeave += new System.EventHandler(this.equipmentItem_MouseLeave);
            this.equipmentItem12.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.equipmentItem_PreviewKeyDown);
            // 
            // equipmentItem11
            // 
            this.equipmentItem11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.equipmentItem11.Location = new System.Drawing.Point(350, 261);
            this.equipmentItem11.Name = "equipmentItem11";
            this.equipmentItem11.ShowItemCount = true;
            this.equipmentItem11.Size = new System.Drawing.Size(42, 42);
            this.equipmentItem11.TabIndex = 17;
            this.equipmentItem11.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.equipmentItem11.Click += new System.EventHandler(this.equipmentItem_Click);
            this.equipmentItem11.MouseEnter += new System.EventHandler(this.equipmentItem_MouseEnter);
            this.equipmentItem11.MouseLeave += new System.EventHandler(this.equipmentItem_MouseLeave);
            this.equipmentItem11.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.equipmentItem_PreviewKeyDown);
            // 
            // equipmentItem10
            // 
            this.equipmentItem10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.equipmentItem10.Location = new System.Drawing.Point(350, 214);
            this.equipmentItem10.Name = "equipmentItem10";
            this.equipmentItem10.ShowItemCount = true;
            this.equipmentItem10.Size = new System.Drawing.Size(42, 42);
            this.equipmentItem10.TabIndex = 16;
            this.equipmentItem10.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.equipmentItem10.Click += new System.EventHandler(this.equipmentItem_Click);
            this.equipmentItem10.MouseEnter += new System.EventHandler(this.equipmentItem_MouseEnter);
            this.equipmentItem10.MouseLeave += new System.EventHandler(this.equipmentItem_MouseLeave);
            this.equipmentItem10.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.equipmentItem_PreviewKeyDown);
            // 
            // equipmentItem09
            // 
            this.equipmentItem09.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.equipmentItem09.Location = new System.Drawing.Point(350, 167);
            this.equipmentItem09.Name = "equipmentItem09";
            this.equipmentItem09.ShowItemCount = true;
            this.equipmentItem09.Size = new System.Drawing.Size(42, 42);
            this.equipmentItem09.TabIndex = 15;
            this.equipmentItem09.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.equipmentItem09.Click += new System.EventHandler(this.equipmentItem_Click);
            this.equipmentItem09.MouseEnter += new System.EventHandler(this.equipmentItem_MouseEnter);
            this.equipmentItem09.MouseLeave += new System.EventHandler(this.equipmentItem_MouseLeave);
            this.equipmentItem09.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.equipmentItem_PreviewKeyDown);
            // 
            // equipmentItem08
            // 
            this.equipmentItem08.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.equipmentItem08.Location = new System.Drawing.Point(350, 120);
            this.equipmentItem08.Name = "equipmentItem08";
            this.equipmentItem08.ShowItemCount = true;
            this.equipmentItem08.Size = new System.Drawing.Size(42, 42);
            this.equipmentItem08.TabIndex = 13;
            this.equipmentItem08.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.equipmentItem08.Click += new System.EventHandler(this.equipmentItem_Click);
            this.equipmentItem08.MouseEnter += new System.EventHandler(this.equipmentItem_MouseEnter);
            this.equipmentItem08.MouseLeave += new System.EventHandler(this.equipmentItem_MouseLeave);
            this.equipmentItem08.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.equipmentItem_PreviewKeyDown);
            // 
            // equipmentItem07
            // 
            this.equipmentItem07.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.equipmentItem07.Location = new System.Drawing.Point(350, 73);
            this.equipmentItem07.Name = "equipmentItem07";
            this.equipmentItem07.ShowItemCount = true;
            this.equipmentItem07.Size = new System.Drawing.Size(42, 42);
            this.equipmentItem07.TabIndex = 12;
            this.equipmentItem07.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.equipmentItem07.Click += new System.EventHandler(this.equipmentItem_Click);
            this.equipmentItem07.MouseEnter += new System.EventHandler(this.equipmentItem_MouseEnter);
            this.equipmentItem07.MouseLeave += new System.EventHandler(this.equipmentItem_MouseLeave);
            this.equipmentItem07.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.equipmentItem_PreviewKeyDown);
            // 
            // equipmentItem06
            // 
            this.equipmentItem06.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.equipmentItem06.Location = new System.Drawing.Point(350, 26);
            this.equipmentItem06.Name = "equipmentItem06";
            this.equipmentItem06.ShowItemCount = true;
            this.equipmentItem06.Size = new System.Drawing.Size(42, 42);
            this.equipmentItem06.TabIndex = 11;
            this.equipmentItem06.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.equipmentItem06.Click += new System.EventHandler(this.equipmentItem_Click);
            this.equipmentItem06.MouseEnter += new System.EventHandler(this.equipmentItem_MouseEnter);
            this.equipmentItem06.MouseLeave += new System.EventHandler(this.equipmentItem_MouseLeave);
            this.equipmentItem06.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.equipmentItem_PreviewKeyDown);
            // 
            // equipmentItem05
            // 
            this.equipmentItem05.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.equipmentItem05.Location = new System.Drawing.Point(292, 120);
            this.equipmentItem05.Name = "equipmentItem05";
            this.equipmentItem05.ShowItemCount = true;
            this.equipmentItem05.Size = new System.Drawing.Size(42, 42);
            this.equipmentItem05.TabIndex = 8;
            this.equipmentItem05.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.equipmentItem05.Click += new System.EventHandler(this.equipmentItem_Click);
            this.equipmentItem05.MouseEnter += new System.EventHandler(this.equipmentItem_MouseEnter);
            this.equipmentItem05.MouseLeave += new System.EventHandler(this.equipmentItem_MouseLeave);
            this.equipmentItem05.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.equipmentItem_PreviewKeyDown);
            // 
            // equipmentItem04
            // 
            this.equipmentItem04.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.equipmentItem04.Location = new System.Drawing.Point(292, 73);
            this.equipmentItem04.Name = "equipmentItem04";
            this.equipmentItem04.ShowItemCount = true;
            this.equipmentItem04.Size = new System.Drawing.Size(42, 42);
            this.equipmentItem04.TabIndex = 7;
            this.equipmentItem04.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.equipmentItem04.Click += new System.EventHandler(this.equipmentItem_Click);
            this.equipmentItem04.MouseEnter += new System.EventHandler(this.equipmentItem_MouseEnter);
            this.equipmentItem04.MouseLeave += new System.EventHandler(this.equipmentItem_MouseLeave);
            this.equipmentItem04.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.equipmentItem_PreviewKeyDown);
            // 
            // equipmentItem03
            // 
            this.equipmentItem03.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.equipmentItem03.Location = new System.Drawing.Point(292, 26);
            this.equipmentItem03.Name = "equipmentItem03";
            this.equipmentItem03.ShowItemCount = true;
            this.equipmentItem03.Size = new System.Drawing.Size(42, 42);
            this.equipmentItem03.TabIndex = 6;
            this.equipmentItem03.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.equipmentItem03.Click += new System.EventHandler(this.equipmentItem_Click);
            this.equipmentItem03.MouseEnter += new System.EventHandler(this.equipmentItem_MouseEnter);
            this.equipmentItem03.MouseLeave += new System.EventHandler(this.equipmentItem_MouseLeave);
            this.equipmentItem03.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.equipmentItem_PreviewKeyDown);
            // 
            // equipmentItem02
            // 
            this.equipmentItem02.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.equipmentItem02.Location = new System.Drawing.Point(234, 120);
            this.equipmentItem02.Name = "equipmentItem02";
            this.equipmentItem02.ShowItemCount = true;
            this.equipmentItem02.Size = new System.Drawing.Size(42, 42);
            this.equipmentItem02.TabIndex = 5;
            this.equipmentItem02.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.equipmentItem02.Click += new System.EventHandler(this.equipmentItem_Click);
            this.equipmentItem02.MouseEnter += new System.EventHandler(this.equipmentItem_MouseEnter);
            this.equipmentItem02.MouseLeave += new System.EventHandler(this.equipmentItem_MouseLeave);
            this.equipmentItem02.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.equipmentItem_PreviewKeyDown);
            // 
            // equipmentItem01
            // 
            this.equipmentItem01.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.equipmentItem01.Location = new System.Drawing.Point(234, 73);
            this.equipmentItem01.Name = "equipmentItem01";
            this.equipmentItem01.ShowItemCount = true;
            this.equipmentItem01.Size = new System.Drawing.Size(42, 42);
            this.equipmentItem01.TabIndex = 4;
            this.equipmentItem01.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.equipmentItem01.Click += new System.EventHandler(this.equipmentItem_Click);
            this.equipmentItem01.MouseEnter += new System.EventHandler(this.equipmentItem_MouseEnter);
            this.equipmentItem01.MouseLeave += new System.EventHandler(this.equipmentItem_MouseLeave);
            this.equipmentItem01.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.equipmentItem_PreviewKeyDown);
            // 
            // equipmentItem00
            // 
            this.equipmentItem00.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.equipmentItem00.Location = new System.Drawing.Point(234, 26);
            this.equipmentItem00.Name = "equipmentItem00";
            this.equipmentItem00.ShowItemCount = true;
            this.equipmentItem00.Size = new System.Drawing.Size(42, 42);
            this.equipmentItem00.TabIndex = 3;
            this.equipmentItem00.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.equipmentItem00.Click += new System.EventHandler(this.equipmentItem_Click);
            this.equipmentItem00.MouseEnter += new System.EventHandler(this.equipmentItem_MouseEnter);
            this.equipmentItem00.MouseLeave += new System.EventHandler(this.equipmentItem_MouseLeave);
            this.equipmentItem00.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.equipmentItem_PreviewKeyDown);
            // 
            // tpBankSafe
            // 
            this.tpBankSafe.Controls.Add(this.btnLoadSafeItems);
            this.tpBankSafe.Controls.Add(this.btnSaveSafeItems);
            this.tpBankSafe.Controls.Add(this.btnLoadBankItems);
            this.tpBankSafe.Controls.Add(this.btnSaveBankItems);
            this.tpBankSafe.Controls.Add(this.groupBox8);
            this.tpBankSafe.Controls.Add(this.groupBox9);
            this.tpBankSafe.Controls.Add(this.groupBox10);
            this.tpBankSafe.Location = new System.Drawing.Point(4, 22);
            this.tpBankSafe.Name = "tpBankSafe";
            this.tpBankSafe.Size = new System.Drawing.Size(612, 413);
            this.tpBankSafe.TabIndex = 4;
            this.tpBankSafe.Text = "Bank / Safe";
            this.tpBankSafe.UseVisualStyleBackColor = true;
            // 
            // btnLoadSafeItems
            // 
            this.btnLoadSafeItems.Location = new System.Drawing.Point(384, 383);
            this.btnLoadSafeItems.Name = "btnLoadSafeItems";
            this.btnLoadSafeItems.Size = new System.Drawing.Size(106, 23);
            this.btnLoadSafeItems.TabIndex = 89;
            this.btnLoadSafeItems.Text = "Load Safe Items";
            this.btnLoadSafeItems.UseVisualStyleBackColor = true;
            this.btnLoadSafeItems.Click += new System.EventHandler(this.btnLoadSafeItems_Click);
            // 
            // btnSaveSafeItems
            // 
            this.btnSaveSafeItems.Location = new System.Drawing.Point(272, 383);
            this.btnSaveSafeItems.Name = "btnSaveSafeItems";
            this.btnSaveSafeItems.Size = new System.Drawing.Size(106, 23);
            this.btnSaveSafeItems.TabIndex = 88;
            this.btnSaveSafeItems.Text = "Save Safe Items";
            this.btnSaveSafeItems.UseVisualStyleBackColor = true;
            this.btnSaveSafeItems.Click += new System.EventHandler(this.btnSaveSafeItems_Click);
            // 
            // btnLoadBankItems
            // 
            this.btnLoadBankItems.Location = new System.Drawing.Point(384, 173);
            this.btnLoadBankItems.Name = "btnLoadBankItems";
            this.btnLoadBankItems.Size = new System.Drawing.Size(106, 23);
            this.btnLoadBankItems.TabIndex = 87;
            this.btnLoadBankItems.Text = "Load Bank Items";
            this.btnLoadBankItems.UseVisualStyleBackColor = true;
            this.btnLoadBankItems.Click += new System.EventHandler(this.btnLoadBankItems_Click);
            // 
            // btnSaveBankItems
            // 
            this.btnSaveBankItems.Location = new System.Drawing.Point(272, 173);
            this.btnSaveBankItems.Name = "btnSaveBankItems";
            this.btnSaveBankItems.Size = new System.Drawing.Size(106, 23);
            this.btnSaveBankItems.TabIndex = 86;
            this.btnSaveBankItems.Text = "Save Bank Items";
            this.btnSaveBankItems.UseVisualStyleBackColor = true;
            this.btnSaveBankItems.Click += new System.EventHandler(this.btnSaveBankItems_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label30);
            this.groupBox8.Controls.Add(this.cboBankSafePrefixCategory);
            this.groupBox8.Controls.Add(this.btnHackAllBankSafeStacks);
            this.groupBox8.Controls.Add(this.btnMaxAllBankSafeStacks);
            this.groupBox8.Controls.Add(this.btnDeleteAllSafeItems);
            this.groupBox8.Controls.Add(this.btnDeleteAllBankItems);
            this.groupBox8.Controls.Add(this.label27);
            this.groupBox8.Controls.Add(this.txtBankSafeStackCount);
            this.groupBox8.Controls.Add(this.label26);
            this.groupBox8.Controls.Add(this.cboBankSafeItemFilter);
            this.groupBox8.Controls.Add(this.label24);
            this.groupBox8.Controls.Add(this.cboBankSafePrefix);
            this.groupBox8.Controls.Add(this.label25);
            this.groupBox8.Controls.Add(this.txtBankSafeFilter);
            this.groupBox8.Controls.Add(this.lstBankSafeItems);
            this.groupBox8.Location = new System.Drawing.Point(8, 3);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(258, 463);
            this.groupBox8.TabIndex = 83;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Item Editor";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(6, 297);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(97, 13);
            this.label30.TabIndex = 14;
            this.label30.Text = "Prefix Category:";
            // 
            // cboBankSafePrefixCategory
            // 
            this.cboBankSafePrefixCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBankSafePrefixCategory.FormattingEnabled = true;
            this.cboBankSafePrefixCategory.Items.AddRange(new object[] {
            "All",
            "Universal",
            "Common",
            "Melee",
            "Ranged",
            "Magic",
            "Accessories"});
            this.cboBankSafePrefixCategory.Location = new System.Drawing.Point(6, 313);
            this.cboBankSafePrefixCategory.Name = "cboBankSafePrefixCategory";
            this.cboBankSafePrefixCategory.Size = new System.Drawing.Size(246, 21);
            this.cboBankSafePrefixCategory.TabIndex = 13;
            this.cboBankSafePrefixCategory.SelectedIndexChanged += new System.EventHandler(this.cboBankSafePrefixCategory_SelectedIndexChanged);
            // 
            // btnHackAllBankSafeStacks
            // 
            this.btnHackAllBankSafeStacks.Location = new System.Drawing.Point(127, 435);
            this.btnHackAllBankSafeStacks.Name = "btnHackAllBankSafeStacks";
            this.btnHackAllBankSafeStacks.Size = new System.Drawing.Size(125, 23);
            this.btnHackAllBankSafeStacks.TabIndex = 12;
            this.btnHackAllBankSafeStacks.Text = "Hack All Item Stacks";
            this.btnHackAllBankSafeStacks.UseVisualStyleBackColor = true;
            this.btnHackAllBankSafeStacks.Click += new System.EventHandler(this.btnHackAllBankSafeStacks_Click);
            // 
            // btnMaxAllBankSafeStacks
            // 
            this.btnMaxAllBankSafeStacks.Location = new System.Drawing.Point(127, 406);
            this.btnMaxAllBankSafeStacks.Name = "btnMaxAllBankSafeStacks";
            this.btnMaxAllBankSafeStacks.Size = new System.Drawing.Size(125, 23);
            this.btnMaxAllBankSafeStacks.TabIndex = 11;
            this.btnMaxAllBankSafeStacks.Text = "Max All Item Stacks";
            this.btnMaxAllBankSafeStacks.UseVisualStyleBackColor = true;
            this.btnMaxAllBankSafeStacks.Click += new System.EventHandler(this.btnMaxAllBankSafeStacks_Click);
            // 
            // btnDeleteAllSafeItems
            // 
            this.btnDeleteAllSafeItems.Location = new System.Drawing.Point(9, 435);
            this.btnDeleteAllSafeItems.Name = "btnDeleteAllSafeItems";
            this.btnDeleteAllSafeItems.Size = new System.Drawing.Size(112, 23);
            this.btnDeleteAllSafeItems.TabIndex = 10;
            this.btnDeleteAllSafeItems.Text = "Delete All Safe";
            this.btnDeleteAllSafeItems.UseVisualStyleBackColor = true;
            this.btnDeleteAllSafeItems.Click += new System.EventHandler(this.btnDeleteAllSafeItems_Click);
            // 
            // btnDeleteAllBankItems
            // 
            this.btnDeleteAllBankItems.Location = new System.Drawing.Point(9, 406);
            this.btnDeleteAllBankItems.Name = "btnDeleteAllBankItems";
            this.btnDeleteAllBankItems.Size = new System.Drawing.Size(112, 23);
            this.btnDeleteAllBankItems.TabIndex = 9;
            this.btnDeleteAllBankItems.Text = "Delete All Bank";
            this.btnDeleteAllBankItems.UseVisualStyleBackColor = true;
            this.btnDeleteAllBankItems.Click += new System.EventHandler(this.btnDeleteAllBankItems_Click);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(76, 383);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(72, 13);
            this.label27.TabIndex = 8;
            this.label27.Text = "Item Stack:";
            // 
            // txtBankSafeStackCount
            // 
            this.txtBankSafeStackCount.Location = new System.Drawing.Point(154, 380);
            this.txtBankSafeStackCount.Name = "txtBankSafeStackCount";
            this.txtBankSafeStackCount.Size = new System.Drawing.Size(98, 20);
            this.txtBankSafeStackCount.TabIndex = 7;
            this.txtBankSafeStackCount.TextChanged += new System.EventHandler(this.txtBankSafeStackCount_TextChanged);
            this.txtBankSafeStackCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBankSafeStackCount_KeyPress);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(6, 48);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(67, 13);
            this.label26.TabIndex = 6;
            this.label26.Text = "Item Type:";
            // 
            // cboBankSafeItemFilter
            // 
            this.cboBankSafeItemFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBankSafeItemFilter.FormattingEnabled = true;
            this.cboBankSafeItemFilter.Items.AddRange(new object[] {
            "All",
            "Armor / Social Gear",
            "Accessories",
            "Ammunition",
            "Building Objects",
            "Consumables",
            "Money",
            "Tools",
            "Weapons"});
            this.cboBankSafeItemFilter.Location = new System.Drawing.Point(79, 45);
            this.cboBankSafeItemFilter.Name = "cboBankSafeItemFilter";
            this.cboBankSafeItemFilter.Size = new System.Drawing.Size(173, 21);
            this.cboBankSafeItemFilter.TabIndex = 5;
            this.cboBankSafeItemFilter.SelectedIndexChanged += new System.EventHandler(this.cboBankSafeItemFilter_SelectedIndexChanged);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(6, 337);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(71, 13);
            this.label24.TabIndex = 4;
            this.label24.Text = "Item Prefix:";
            // 
            // cboBankSafePrefix
            // 
            this.cboBankSafePrefix.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBankSafePrefix.FormattingEnabled = true;
            this.cboBankSafePrefix.Location = new System.Drawing.Point(6, 353);
            this.cboBankSafePrefix.Name = "cboBankSafePrefix";
            this.cboBankSafePrefix.Size = new System.Drawing.Size(246, 21);
            this.cboBankSafePrefix.TabIndex = 3;
            this.cboBankSafePrefix.SelectedIndexChanged += new System.EventHandler(this.cboBankSafePrefix_SelectedIndexChanged);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(6, 22);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(67, 13);
            this.label25.TabIndex = 2;
            this.label25.Text = "Item Filter:";
            // 
            // txtBankSafeFilter
            // 
            this.txtBankSafeFilter.Location = new System.Drawing.Point(79, 19);
            this.txtBankSafeFilter.Name = "txtBankSafeFilter";
            this.txtBankSafeFilter.Size = new System.Drawing.Size(173, 20);
            this.txtBankSafeFilter.TabIndex = 1;
            this.txtBankSafeFilter.TextChanged += new System.EventHandler(this.txtBankSafeFilter_TextChanged);
            // 
            // lstBankSafeItems
            // 
            this.lstBankSafeItems.FormattingEnabled = true;
            this.lstBankSafeItems.Location = new System.Drawing.Point(6, 71);
            this.lstBankSafeItems.Name = "lstBankSafeItems";
            this.lstBankSafeItems.Size = new System.Drawing.Size(246, 225);
            this.lstBankSafeItems.TabIndex = 0;
            this.lstBankSafeItems.SelectedIndexChanged += new System.EventHandler(this.lstBankSafeItems_SelectedIndexChanged);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.bankSafeItem02);
            this.groupBox9.Controls.Add(this.bankSafeItem01);
            this.groupBox9.Controls.Add(this.bankSafeItem03);
            this.groupBox9.Controls.Add(this.bankSafeItem04);
            this.groupBox9.Controls.Add(this.bankSafeItem05);
            this.groupBox9.Controls.Add(this.bankSafeItem06);
            this.groupBox9.Controls.Add(this.bankSafeItem07);
            this.groupBox9.Controls.Add(this.bankSafeItem08);
            this.groupBox9.Controls.Add(this.bankSafeItem16);
            this.groupBox9.Controls.Add(this.bankSafeItem15);
            this.groupBox9.Controls.Add(this.bankSafeItem14);
            this.groupBox9.Controls.Add(this.bankSafeItem13);
            this.groupBox9.Controls.Add(this.bankSafeItem12);
            this.groupBox9.Controls.Add(this.bankSafeItem11);
            this.groupBox9.Controls.Add(this.bankSafeItem10);
            this.groupBox9.Controls.Add(this.bankSafeItem09);
            this.groupBox9.Controls.Add(this.bankSafeItem24);
            this.groupBox9.Controls.Add(this.bankSafeItem23);
            this.groupBox9.Controls.Add(this.bankSafeItem22);
            this.groupBox9.Controls.Add(this.bankSafeItem21);
            this.groupBox9.Controls.Add(this.bankSafeItem20);
            this.groupBox9.Controls.Add(this.bankSafeItem19);
            this.groupBox9.Controls.Add(this.bankSafeItem18);
            this.groupBox9.Controls.Add(this.bankSafeItem17);
            this.groupBox9.Controls.Add(this.bankSafeItem32);
            this.groupBox9.Controls.Add(this.bankSafeItem31);
            this.groupBox9.Controls.Add(this.bankSafeItem30);
            this.groupBox9.Controls.Add(this.bankSafeItem29);
            this.groupBox9.Controls.Add(this.bankSafeItem28);
            this.groupBox9.Controls.Add(this.bankSafeItem27);
            this.groupBox9.Controls.Add(this.bankSafeItem26);
            this.groupBox9.Controls.Add(this.bankSafeItem25);
            this.groupBox9.Controls.Add(this.bankSafeItem39);
            this.groupBox9.Controls.Add(this.bankSafeItem38);
            this.groupBox9.Controls.Add(this.bankSafeItem37);
            this.groupBox9.Controls.Add(this.bankSafeItem36);
            this.groupBox9.Controls.Add(this.bankSafeItem35);
            this.groupBox9.Controls.Add(this.bankSafeItem34);
            this.groupBox9.Controls.Add(this.bankSafeItem33);
            this.groupBox9.Controls.Add(this.bankSafeItem00);
            this.groupBox9.Location = new System.Drawing.Point(272, 3);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(399, 164);
            this.groupBox9.TabIndex = 84;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Bank Items";
            // 
            // bankSafeItem02
            // 
            this.bankSafeItem02.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bankSafeItem02.Location = new System.Drawing.Point(88, 15);
            this.bankSafeItem02.Name = "bankSafeItem02";
            this.bankSafeItem02.ShowItemCount = true;
            this.bankSafeItem02.Size = new System.Drawing.Size(32, 32);
            this.bankSafeItem02.TabIndex = 4;
            this.bankSafeItem02.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.bankSafeItem02.Click += new System.EventHandler(this.bankSafeItem_Click);
            this.bankSafeItem02.MouseEnter += new System.EventHandler(this.bankSafeItem_MouseEnter);
            this.bankSafeItem02.MouseLeave += new System.EventHandler(this.bankSafeItem_MouseLeave);
            this.bankSafeItem02.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.bankSafeItem_PreviewKeyDown);
            // 
            // bankSafeItem01
            // 
            this.bankSafeItem01.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bankSafeItem01.Location = new System.Drawing.Point(50, 15);
            this.bankSafeItem01.Name = "bankSafeItem01";
            this.bankSafeItem01.ShowItemCount = true;
            this.bankSafeItem01.Size = new System.Drawing.Size(32, 32);
            this.bankSafeItem01.TabIndex = 3;
            this.bankSafeItem01.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.bankSafeItem01.Click += new System.EventHandler(this.bankSafeItem_Click);
            this.bankSafeItem01.MouseEnter += new System.EventHandler(this.bankSafeItem_MouseEnter);
            this.bankSafeItem01.MouseLeave += new System.EventHandler(this.bankSafeItem_MouseLeave);
            this.bankSafeItem01.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.bankSafeItem_PreviewKeyDown);
            // 
            // bankSafeItem03
            // 
            this.bankSafeItem03.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bankSafeItem03.Location = new System.Drawing.Point(126, 15);
            this.bankSafeItem03.Name = "bankSafeItem03";
            this.bankSafeItem03.ShowItemCount = true;
            this.bankSafeItem03.Size = new System.Drawing.Size(32, 32);
            this.bankSafeItem03.TabIndex = 5;
            this.bankSafeItem03.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.bankSafeItem03.Click += new System.EventHandler(this.bankSafeItem_Click);
            this.bankSafeItem03.MouseEnter += new System.EventHandler(this.bankSafeItem_MouseEnter);
            this.bankSafeItem03.MouseLeave += new System.EventHandler(this.bankSafeItem_MouseLeave);
            this.bankSafeItem03.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.bankSafeItem_PreviewKeyDown);
            // 
            // bankSafeItem04
            // 
            this.bankSafeItem04.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bankSafeItem04.Location = new System.Drawing.Point(164, 15);
            this.bankSafeItem04.Name = "bankSafeItem04";
            this.bankSafeItem04.ShowItemCount = true;
            this.bankSafeItem04.Size = new System.Drawing.Size(32, 32);
            this.bankSafeItem04.TabIndex = 6;
            this.bankSafeItem04.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.bankSafeItem04.Click += new System.EventHandler(this.bankSafeItem_Click);
            this.bankSafeItem04.MouseEnter += new System.EventHandler(this.bankSafeItem_MouseEnter);
            this.bankSafeItem04.MouseLeave += new System.EventHandler(this.bankSafeItem_MouseLeave);
            this.bankSafeItem04.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.bankSafeItem_PreviewKeyDown);
            // 
            // bankSafeItem05
            // 
            this.bankSafeItem05.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bankSafeItem05.Location = new System.Drawing.Point(202, 15);
            this.bankSafeItem05.Name = "bankSafeItem05";
            this.bankSafeItem05.ShowItemCount = true;
            this.bankSafeItem05.Size = new System.Drawing.Size(32, 32);
            this.bankSafeItem05.TabIndex = 7;
            this.bankSafeItem05.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.bankSafeItem05.Click += new System.EventHandler(this.bankSafeItem_Click);
            this.bankSafeItem05.MouseEnter += new System.EventHandler(this.bankSafeItem_MouseEnter);
            this.bankSafeItem05.MouseLeave += new System.EventHandler(this.bankSafeItem_MouseLeave);
            this.bankSafeItem05.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.bankSafeItem_PreviewKeyDown);
            // 
            // bankSafeItem06
            // 
            this.bankSafeItem06.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bankSafeItem06.Location = new System.Drawing.Point(240, 15);
            this.bankSafeItem06.Name = "bankSafeItem06";
            this.bankSafeItem06.ShowItemCount = true;
            this.bankSafeItem06.Size = new System.Drawing.Size(32, 32);
            this.bankSafeItem06.TabIndex = 8;
            this.bankSafeItem06.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.bankSafeItem06.Click += new System.EventHandler(this.bankSafeItem_Click);
            this.bankSafeItem06.MouseEnter += new System.EventHandler(this.bankSafeItem_MouseEnter);
            this.bankSafeItem06.MouseLeave += new System.EventHandler(this.bankSafeItem_MouseLeave);
            this.bankSafeItem06.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.bankSafeItem_PreviewKeyDown);
            // 
            // bankSafeItem07
            // 
            this.bankSafeItem07.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bankSafeItem07.Location = new System.Drawing.Point(278, 15);
            this.bankSafeItem07.Name = "bankSafeItem07";
            this.bankSafeItem07.ShowItemCount = true;
            this.bankSafeItem07.Size = new System.Drawing.Size(32, 32);
            this.bankSafeItem07.TabIndex = 9;
            this.bankSafeItem07.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.bankSafeItem07.Click += new System.EventHandler(this.bankSafeItem_Click);
            this.bankSafeItem07.MouseEnter += new System.EventHandler(this.bankSafeItem_MouseEnter);
            this.bankSafeItem07.MouseLeave += new System.EventHandler(this.bankSafeItem_MouseLeave);
            this.bankSafeItem07.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.bankSafeItem_PreviewKeyDown);
            // 
            // bankSafeItem08
            // 
            this.bankSafeItem08.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bankSafeItem08.Location = new System.Drawing.Point(316, 15);
            this.bankSafeItem08.Name = "bankSafeItem08";
            this.bankSafeItem08.ShowItemCount = true;
            this.bankSafeItem08.Size = new System.Drawing.Size(32, 32);
            this.bankSafeItem08.TabIndex = 10;
            this.bankSafeItem08.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.bankSafeItem08.Click += new System.EventHandler(this.bankSafeItem_Click);
            this.bankSafeItem08.MouseEnter += new System.EventHandler(this.bankSafeItem_MouseEnter);
            this.bankSafeItem08.MouseLeave += new System.EventHandler(this.bankSafeItem_MouseLeave);
            this.bankSafeItem08.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.bankSafeItem_PreviewKeyDown);
            // 
            // bankSafeItem16
            // 
            this.bankSafeItem16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bankSafeItem16.Location = new System.Drawing.Point(240, 49);
            this.bankSafeItem16.Name = "bankSafeItem16";
            this.bankSafeItem16.ShowItemCount = true;
            this.bankSafeItem16.Size = new System.Drawing.Size(32, 32);
            this.bankSafeItem16.TabIndex = 11;
            this.bankSafeItem16.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.bankSafeItem16.Click += new System.EventHandler(this.bankSafeItem_Click);
            this.bankSafeItem16.MouseEnter += new System.EventHandler(this.bankSafeItem_MouseEnter);
            this.bankSafeItem16.MouseLeave += new System.EventHandler(this.bankSafeItem_MouseLeave);
            this.bankSafeItem16.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.bankSafeItem_PreviewKeyDown);
            // 
            // bankSafeItem15
            // 
            this.bankSafeItem15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bankSafeItem15.Location = new System.Drawing.Point(202, 49);
            this.bankSafeItem15.Name = "bankSafeItem15";
            this.bankSafeItem15.ShowItemCount = true;
            this.bankSafeItem15.Size = new System.Drawing.Size(32, 32);
            this.bankSafeItem15.TabIndex = 12;
            this.bankSafeItem15.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.bankSafeItem15.Click += new System.EventHandler(this.bankSafeItem_Click);
            this.bankSafeItem15.MouseEnter += new System.EventHandler(this.bankSafeItem_MouseEnter);
            this.bankSafeItem15.MouseLeave += new System.EventHandler(this.bankSafeItem_MouseLeave);
            this.bankSafeItem15.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.bankSafeItem_PreviewKeyDown);
            // 
            // bankSafeItem14
            // 
            this.bankSafeItem14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bankSafeItem14.Location = new System.Drawing.Point(164, 49);
            this.bankSafeItem14.Name = "bankSafeItem14";
            this.bankSafeItem14.ShowItemCount = true;
            this.bankSafeItem14.Size = new System.Drawing.Size(32, 32);
            this.bankSafeItem14.TabIndex = 13;
            this.bankSafeItem14.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.bankSafeItem14.Click += new System.EventHandler(this.bankSafeItem_Click);
            this.bankSafeItem14.MouseEnter += new System.EventHandler(this.bankSafeItem_MouseEnter);
            this.bankSafeItem14.MouseLeave += new System.EventHandler(this.bankSafeItem_MouseLeave);
            this.bankSafeItem14.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.bankSafeItem_PreviewKeyDown);
            // 
            // bankSafeItem13
            // 
            this.bankSafeItem13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bankSafeItem13.Location = new System.Drawing.Point(126, 49);
            this.bankSafeItem13.Name = "bankSafeItem13";
            this.bankSafeItem13.ShowItemCount = true;
            this.bankSafeItem13.Size = new System.Drawing.Size(32, 32);
            this.bankSafeItem13.TabIndex = 14;
            this.bankSafeItem13.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.bankSafeItem13.Click += new System.EventHandler(this.bankSafeItem_Click);
            this.bankSafeItem13.MouseEnter += new System.EventHandler(this.bankSafeItem_MouseEnter);
            this.bankSafeItem13.MouseLeave += new System.EventHandler(this.bankSafeItem_MouseLeave);
            this.bankSafeItem13.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.bankSafeItem_PreviewKeyDown);
            // 
            // bankSafeItem12
            // 
            this.bankSafeItem12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bankSafeItem12.Location = new System.Drawing.Point(88, 49);
            this.bankSafeItem12.Name = "bankSafeItem12";
            this.bankSafeItem12.ShowItemCount = true;
            this.bankSafeItem12.Size = new System.Drawing.Size(32, 32);
            this.bankSafeItem12.TabIndex = 15;
            this.bankSafeItem12.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.bankSafeItem12.Click += new System.EventHandler(this.bankSafeItem_Click);
            this.bankSafeItem12.MouseEnter += new System.EventHandler(this.bankSafeItem_MouseEnter);
            this.bankSafeItem12.MouseLeave += new System.EventHandler(this.bankSafeItem_MouseLeave);
            this.bankSafeItem12.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.bankSafeItem_PreviewKeyDown);
            // 
            // bankSafeItem11
            // 
            this.bankSafeItem11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bankSafeItem11.Location = new System.Drawing.Point(50, 49);
            this.bankSafeItem11.Name = "bankSafeItem11";
            this.bankSafeItem11.ShowItemCount = true;
            this.bankSafeItem11.Size = new System.Drawing.Size(32, 32);
            this.bankSafeItem11.TabIndex = 16;
            this.bankSafeItem11.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.bankSafeItem11.Click += new System.EventHandler(this.bankSafeItem_Click);
            this.bankSafeItem11.MouseEnter += new System.EventHandler(this.bankSafeItem_MouseEnter);
            this.bankSafeItem11.MouseLeave += new System.EventHandler(this.bankSafeItem_MouseLeave);
            this.bankSafeItem11.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.bankSafeItem_PreviewKeyDown);
            // 
            // bankSafeItem10
            // 
            this.bankSafeItem10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bankSafeItem10.Location = new System.Drawing.Point(12, 49);
            this.bankSafeItem10.Name = "bankSafeItem10";
            this.bankSafeItem10.ShowItemCount = true;
            this.bankSafeItem10.Size = new System.Drawing.Size(32, 32);
            this.bankSafeItem10.TabIndex = 17;
            this.bankSafeItem10.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.bankSafeItem10.Click += new System.EventHandler(this.bankSafeItem_Click);
            this.bankSafeItem10.MouseEnter += new System.EventHandler(this.bankSafeItem_MouseEnter);
            this.bankSafeItem10.MouseLeave += new System.EventHandler(this.bankSafeItem_MouseLeave);
            this.bankSafeItem10.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.bankSafeItem_PreviewKeyDown);
            // 
            // bankSafeItem09
            // 
            this.bankSafeItem09.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bankSafeItem09.Location = new System.Drawing.Point(354, 15);
            this.bankSafeItem09.Name = "bankSafeItem09";
            this.bankSafeItem09.ShowItemCount = true;
            this.bankSafeItem09.Size = new System.Drawing.Size(32, 32);
            this.bankSafeItem09.TabIndex = 18;
            this.bankSafeItem09.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.bankSafeItem09.Click += new System.EventHandler(this.bankSafeItem_Click);
            this.bankSafeItem09.MouseEnter += new System.EventHandler(this.bankSafeItem_MouseEnter);
            this.bankSafeItem09.MouseLeave += new System.EventHandler(this.bankSafeItem_MouseLeave);
            this.bankSafeItem09.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.bankSafeItem_PreviewKeyDown);
            // 
            // bankSafeItem24
            // 
            this.bankSafeItem24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bankSafeItem24.Location = new System.Drawing.Point(164, 84);
            this.bankSafeItem24.Name = "bankSafeItem24";
            this.bankSafeItem24.ShowItemCount = true;
            this.bankSafeItem24.Size = new System.Drawing.Size(32, 32);
            this.bankSafeItem24.TabIndex = 19;
            this.bankSafeItem24.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.bankSafeItem24.Click += new System.EventHandler(this.bankSafeItem_Click);
            this.bankSafeItem24.MouseEnter += new System.EventHandler(this.bankSafeItem_MouseEnter);
            this.bankSafeItem24.MouseLeave += new System.EventHandler(this.bankSafeItem_MouseLeave);
            this.bankSafeItem24.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.bankSafeItem_PreviewKeyDown);
            // 
            // bankSafeItem23
            // 
            this.bankSafeItem23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bankSafeItem23.Location = new System.Drawing.Point(126, 84);
            this.bankSafeItem23.Name = "bankSafeItem23";
            this.bankSafeItem23.ShowItemCount = true;
            this.bankSafeItem23.Size = new System.Drawing.Size(32, 32);
            this.bankSafeItem23.TabIndex = 20;
            this.bankSafeItem23.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.bankSafeItem23.Click += new System.EventHandler(this.bankSafeItem_Click);
            this.bankSafeItem23.MouseEnter += new System.EventHandler(this.bankSafeItem_MouseEnter);
            this.bankSafeItem23.MouseLeave += new System.EventHandler(this.bankSafeItem_MouseLeave);
            this.bankSafeItem23.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.bankSafeItem_PreviewKeyDown);
            // 
            // bankSafeItem22
            // 
            this.bankSafeItem22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bankSafeItem22.Location = new System.Drawing.Point(88, 84);
            this.bankSafeItem22.Name = "bankSafeItem22";
            this.bankSafeItem22.ShowItemCount = true;
            this.bankSafeItem22.Size = new System.Drawing.Size(32, 32);
            this.bankSafeItem22.TabIndex = 21;
            this.bankSafeItem22.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.bankSafeItem22.Click += new System.EventHandler(this.bankSafeItem_Click);
            this.bankSafeItem22.MouseEnter += new System.EventHandler(this.bankSafeItem_MouseEnter);
            this.bankSafeItem22.MouseLeave += new System.EventHandler(this.bankSafeItem_MouseLeave);
            this.bankSafeItem22.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.bankSafeItem_PreviewKeyDown);
            // 
            // bankSafeItem21
            // 
            this.bankSafeItem21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bankSafeItem21.Location = new System.Drawing.Point(50, 84);
            this.bankSafeItem21.Name = "bankSafeItem21";
            this.bankSafeItem21.ShowItemCount = true;
            this.bankSafeItem21.Size = new System.Drawing.Size(32, 32);
            this.bankSafeItem21.TabIndex = 22;
            this.bankSafeItem21.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.bankSafeItem21.Click += new System.EventHandler(this.bankSafeItem_Click);
            this.bankSafeItem21.MouseEnter += new System.EventHandler(this.bankSafeItem_MouseEnter);
            this.bankSafeItem21.MouseLeave += new System.EventHandler(this.bankSafeItem_MouseLeave);
            this.bankSafeItem21.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.bankSafeItem_PreviewKeyDown);
            // 
            // bankSafeItem20
            // 
            this.bankSafeItem20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bankSafeItem20.Location = new System.Drawing.Point(12, 84);
            this.bankSafeItem20.Name = "bankSafeItem20";
            this.bankSafeItem20.ShowItemCount = true;
            this.bankSafeItem20.Size = new System.Drawing.Size(32, 32);
            this.bankSafeItem20.TabIndex = 23;
            this.bankSafeItem20.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.bankSafeItem20.Click += new System.EventHandler(this.bankSafeItem_Click);
            this.bankSafeItem20.MouseEnter += new System.EventHandler(this.bankSafeItem_MouseEnter);
            this.bankSafeItem20.MouseLeave += new System.EventHandler(this.bankSafeItem_MouseLeave);
            this.bankSafeItem20.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.bankSafeItem_PreviewKeyDown);
            // 
            // bankSafeItem19
            // 
            this.bankSafeItem19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bankSafeItem19.Location = new System.Drawing.Point(354, 49);
            this.bankSafeItem19.Name = "bankSafeItem19";
            this.bankSafeItem19.ShowItemCount = true;
            this.bankSafeItem19.Size = new System.Drawing.Size(32, 32);
            this.bankSafeItem19.TabIndex = 24;
            this.bankSafeItem19.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.bankSafeItem19.Click += new System.EventHandler(this.bankSafeItem_Click);
            this.bankSafeItem19.MouseEnter += new System.EventHandler(this.bankSafeItem_MouseEnter);
            this.bankSafeItem19.MouseLeave += new System.EventHandler(this.bankSafeItem_MouseLeave);
            this.bankSafeItem19.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.bankSafeItem_PreviewKeyDown);
            // 
            // bankSafeItem18
            // 
            this.bankSafeItem18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bankSafeItem18.Location = new System.Drawing.Point(316, 49);
            this.bankSafeItem18.Name = "bankSafeItem18";
            this.bankSafeItem18.ShowItemCount = true;
            this.bankSafeItem18.Size = new System.Drawing.Size(32, 32);
            this.bankSafeItem18.TabIndex = 25;
            this.bankSafeItem18.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.bankSafeItem18.Click += new System.EventHandler(this.bankSafeItem_Click);
            this.bankSafeItem18.MouseEnter += new System.EventHandler(this.bankSafeItem_MouseEnter);
            this.bankSafeItem18.MouseLeave += new System.EventHandler(this.bankSafeItem_MouseLeave);
            this.bankSafeItem18.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.bankSafeItem_PreviewKeyDown);
            // 
            // bankSafeItem17
            // 
            this.bankSafeItem17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bankSafeItem17.Location = new System.Drawing.Point(278, 49);
            this.bankSafeItem17.Name = "bankSafeItem17";
            this.bankSafeItem17.ShowItemCount = true;
            this.bankSafeItem17.Size = new System.Drawing.Size(32, 32);
            this.bankSafeItem17.TabIndex = 26;
            this.bankSafeItem17.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.bankSafeItem17.Click += new System.EventHandler(this.bankSafeItem_Click);
            this.bankSafeItem17.MouseEnter += new System.EventHandler(this.bankSafeItem_MouseEnter);
            this.bankSafeItem17.MouseLeave += new System.EventHandler(this.bankSafeItem_MouseLeave);
            this.bankSafeItem17.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.bankSafeItem_PreviewKeyDown);
            // 
            // bankSafeItem32
            // 
            this.bankSafeItem32.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bankSafeItem32.Location = new System.Drawing.Point(88, 120);
            this.bankSafeItem32.Name = "bankSafeItem32";
            this.bankSafeItem32.ShowItemCount = true;
            this.bankSafeItem32.Size = new System.Drawing.Size(32, 32);
            this.bankSafeItem32.TabIndex = 27;
            this.bankSafeItem32.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.bankSafeItem32.Click += new System.EventHandler(this.bankSafeItem_Click);
            this.bankSafeItem32.MouseEnter += new System.EventHandler(this.bankSafeItem_MouseEnter);
            this.bankSafeItem32.MouseLeave += new System.EventHandler(this.bankSafeItem_MouseLeave);
            this.bankSafeItem32.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.bankSafeItem_PreviewKeyDown);
            // 
            // bankSafeItem31
            // 
            this.bankSafeItem31.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bankSafeItem31.Location = new System.Drawing.Point(50, 120);
            this.bankSafeItem31.Name = "bankSafeItem31";
            this.bankSafeItem31.ShowItemCount = true;
            this.bankSafeItem31.Size = new System.Drawing.Size(32, 32);
            this.bankSafeItem31.TabIndex = 28;
            this.bankSafeItem31.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.bankSafeItem31.Click += new System.EventHandler(this.bankSafeItem_Click);
            this.bankSafeItem31.MouseEnter += new System.EventHandler(this.bankSafeItem_MouseEnter);
            this.bankSafeItem31.MouseLeave += new System.EventHandler(this.bankSafeItem_MouseLeave);
            this.bankSafeItem31.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.bankSafeItem_PreviewKeyDown);
            // 
            // bankSafeItem30
            // 
            this.bankSafeItem30.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bankSafeItem30.Location = new System.Drawing.Point(12, 120);
            this.bankSafeItem30.Name = "bankSafeItem30";
            this.bankSafeItem30.ShowItemCount = true;
            this.bankSafeItem30.Size = new System.Drawing.Size(32, 32);
            this.bankSafeItem30.TabIndex = 29;
            this.bankSafeItem30.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.bankSafeItem30.Click += new System.EventHandler(this.bankSafeItem_Click);
            this.bankSafeItem30.MouseEnter += new System.EventHandler(this.bankSafeItem_MouseEnter);
            this.bankSafeItem30.MouseLeave += new System.EventHandler(this.bankSafeItem_MouseLeave);
            this.bankSafeItem30.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.bankSafeItem_PreviewKeyDown);
            // 
            // bankSafeItem29
            // 
            this.bankSafeItem29.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bankSafeItem29.Location = new System.Drawing.Point(354, 84);
            this.bankSafeItem29.Name = "bankSafeItem29";
            this.bankSafeItem29.ShowItemCount = true;
            this.bankSafeItem29.Size = new System.Drawing.Size(32, 32);
            this.bankSafeItem29.TabIndex = 30;
            this.bankSafeItem29.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.bankSafeItem29.Click += new System.EventHandler(this.bankSafeItem_Click);
            this.bankSafeItem29.MouseEnter += new System.EventHandler(this.bankSafeItem_MouseEnter);
            this.bankSafeItem29.MouseLeave += new System.EventHandler(this.bankSafeItem_MouseLeave);
            this.bankSafeItem29.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.bankSafeItem_PreviewKeyDown);
            // 
            // bankSafeItem28
            // 
            this.bankSafeItem28.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bankSafeItem28.Location = new System.Drawing.Point(316, 84);
            this.bankSafeItem28.Name = "bankSafeItem28";
            this.bankSafeItem28.ShowItemCount = true;
            this.bankSafeItem28.Size = new System.Drawing.Size(32, 32);
            this.bankSafeItem28.TabIndex = 31;
            this.bankSafeItem28.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.bankSafeItem28.Click += new System.EventHandler(this.bankSafeItem_Click);
            this.bankSafeItem28.MouseEnter += new System.EventHandler(this.bankSafeItem_MouseEnter);
            this.bankSafeItem28.MouseLeave += new System.EventHandler(this.bankSafeItem_MouseLeave);
            this.bankSafeItem28.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.bankSafeItem_PreviewKeyDown);
            // 
            // bankSafeItem27
            // 
            this.bankSafeItem27.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bankSafeItem27.Location = new System.Drawing.Point(278, 84);
            this.bankSafeItem27.Name = "bankSafeItem27";
            this.bankSafeItem27.ShowItemCount = true;
            this.bankSafeItem27.Size = new System.Drawing.Size(32, 32);
            this.bankSafeItem27.TabIndex = 32;
            this.bankSafeItem27.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.bankSafeItem27.Click += new System.EventHandler(this.bankSafeItem_Click);
            this.bankSafeItem27.MouseEnter += new System.EventHandler(this.bankSafeItem_MouseEnter);
            this.bankSafeItem27.MouseLeave += new System.EventHandler(this.bankSafeItem_MouseLeave);
            this.bankSafeItem27.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.bankSafeItem_PreviewKeyDown);
            // 
            // bankSafeItem26
            // 
            this.bankSafeItem26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bankSafeItem26.Location = new System.Drawing.Point(240, 84);
            this.bankSafeItem26.Name = "bankSafeItem26";
            this.bankSafeItem26.ShowItemCount = true;
            this.bankSafeItem26.Size = new System.Drawing.Size(32, 32);
            this.bankSafeItem26.TabIndex = 33;
            this.bankSafeItem26.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.bankSafeItem26.Click += new System.EventHandler(this.bankSafeItem_Click);
            this.bankSafeItem26.MouseEnter += new System.EventHandler(this.bankSafeItem_MouseEnter);
            this.bankSafeItem26.MouseLeave += new System.EventHandler(this.bankSafeItem_MouseLeave);
            this.bankSafeItem26.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.bankSafeItem_PreviewKeyDown);
            // 
            // bankSafeItem25
            // 
            this.bankSafeItem25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bankSafeItem25.Location = new System.Drawing.Point(202, 84);
            this.bankSafeItem25.Name = "bankSafeItem25";
            this.bankSafeItem25.ShowItemCount = true;
            this.bankSafeItem25.Size = new System.Drawing.Size(32, 32);
            this.bankSafeItem25.TabIndex = 34;
            this.bankSafeItem25.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.bankSafeItem25.Click += new System.EventHandler(this.bankSafeItem_Click);
            this.bankSafeItem25.MouseEnter += new System.EventHandler(this.bankSafeItem_MouseEnter);
            this.bankSafeItem25.MouseLeave += new System.EventHandler(this.bankSafeItem_MouseLeave);
            this.bankSafeItem25.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.bankSafeItem_PreviewKeyDown);
            // 
            // bankSafeItem39
            // 
            this.bankSafeItem39.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bankSafeItem39.Location = new System.Drawing.Point(354, 120);
            this.bankSafeItem39.Name = "bankSafeItem39";
            this.bankSafeItem39.ShowItemCount = true;
            this.bankSafeItem39.Size = new System.Drawing.Size(32, 32);
            this.bankSafeItem39.TabIndex = 36;
            this.bankSafeItem39.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.bankSafeItem39.Click += new System.EventHandler(this.bankSafeItem_Click);
            this.bankSafeItem39.MouseEnter += new System.EventHandler(this.bankSafeItem_MouseEnter);
            this.bankSafeItem39.MouseLeave += new System.EventHandler(this.bankSafeItem_MouseLeave);
            this.bankSafeItem39.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.bankSafeItem_PreviewKeyDown);
            // 
            // bankSafeItem38
            // 
            this.bankSafeItem38.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bankSafeItem38.Location = new System.Drawing.Point(316, 120);
            this.bankSafeItem38.Name = "bankSafeItem38";
            this.bankSafeItem38.ShowItemCount = true;
            this.bankSafeItem38.Size = new System.Drawing.Size(32, 32);
            this.bankSafeItem38.TabIndex = 37;
            this.bankSafeItem38.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.bankSafeItem38.Click += new System.EventHandler(this.bankSafeItem_Click);
            this.bankSafeItem38.MouseEnter += new System.EventHandler(this.bankSafeItem_MouseEnter);
            this.bankSafeItem38.MouseLeave += new System.EventHandler(this.bankSafeItem_MouseLeave);
            this.bankSafeItem38.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.bankSafeItem_PreviewKeyDown);
            // 
            // bankSafeItem37
            // 
            this.bankSafeItem37.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bankSafeItem37.Location = new System.Drawing.Point(278, 120);
            this.bankSafeItem37.Name = "bankSafeItem37";
            this.bankSafeItem37.ShowItemCount = true;
            this.bankSafeItem37.Size = new System.Drawing.Size(32, 32);
            this.bankSafeItem37.TabIndex = 38;
            this.bankSafeItem37.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.bankSafeItem37.Click += new System.EventHandler(this.bankSafeItem_Click);
            this.bankSafeItem37.MouseEnter += new System.EventHandler(this.bankSafeItem_MouseEnter);
            this.bankSafeItem37.MouseLeave += new System.EventHandler(this.bankSafeItem_MouseLeave);
            this.bankSafeItem37.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.bankSafeItem_PreviewKeyDown);
            // 
            // bankSafeItem36
            // 
            this.bankSafeItem36.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bankSafeItem36.Location = new System.Drawing.Point(240, 120);
            this.bankSafeItem36.Name = "bankSafeItem36";
            this.bankSafeItem36.ShowItemCount = true;
            this.bankSafeItem36.Size = new System.Drawing.Size(32, 32);
            this.bankSafeItem36.TabIndex = 39;
            this.bankSafeItem36.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.bankSafeItem36.Click += new System.EventHandler(this.bankSafeItem_Click);
            this.bankSafeItem36.MouseEnter += new System.EventHandler(this.bankSafeItem_MouseEnter);
            this.bankSafeItem36.MouseLeave += new System.EventHandler(this.bankSafeItem_MouseLeave);
            this.bankSafeItem36.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.bankSafeItem_PreviewKeyDown);
            // 
            // bankSafeItem35
            // 
            this.bankSafeItem35.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bankSafeItem35.Location = new System.Drawing.Point(202, 120);
            this.bankSafeItem35.Name = "bankSafeItem35";
            this.bankSafeItem35.ShowItemCount = true;
            this.bankSafeItem35.Size = new System.Drawing.Size(32, 32);
            this.bankSafeItem35.TabIndex = 40;
            this.bankSafeItem35.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.bankSafeItem35.Click += new System.EventHandler(this.bankSafeItem_Click);
            this.bankSafeItem35.MouseEnter += new System.EventHandler(this.bankSafeItem_MouseEnter);
            this.bankSafeItem35.MouseLeave += new System.EventHandler(this.bankSafeItem_MouseLeave);
            this.bankSafeItem35.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.bankSafeItem_PreviewKeyDown);
            // 
            // bankSafeItem34
            // 
            this.bankSafeItem34.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bankSafeItem34.Location = new System.Drawing.Point(164, 120);
            this.bankSafeItem34.Name = "bankSafeItem34";
            this.bankSafeItem34.ShowItemCount = true;
            this.bankSafeItem34.Size = new System.Drawing.Size(32, 32);
            this.bankSafeItem34.TabIndex = 41;
            this.bankSafeItem34.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.bankSafeItem34.Click += new System.EventHandler(this.bankSafeItem_Click);
            this.bankSafeItem34.MouseEnter += new System.EventHandler(this.bankSafeItem_MouseEnter);
            this.bankSafeItem34.MouseLeave += new System.EventHandler(this.bankSafeItem_MouseLeave);
            this.bankSafeItem34.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.bankSafeItem_PreviewKeyDown);
            // 
            // bankSafeItem33
            // 
            this.bankSafeItem33.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bankSafeItem33.Location = new System.Drawing.Point(126, 120);
            this.bankSafeItem33.Name = "bankSafeItem33";
            this.bankSafeItem33.ShowItemCount = true;
            this.bankSafeItem33.Size = new System.Drawing.Size(32, 32);
            this.bankSafeItem33.TabIndex = 42;
            this.bankSafeItem33.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.bankSafeItem33.Click += new System.EventHandler(this.bankSafeItem_Click);
            this.bankSafeItem33.MouseEnter += new System.EventHandler(this.bankSafeItem_MouseEnter);
            this.bankSafeItem33.MouseLeave += new System.EventHandler(this.bankSafeItem_MouseLeave);
            this.bankSafeItem33.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.bankSafeItem_PreviewKeyDown);
            // 
            // bankSafeItem00
            // 
            this.bankSafeItem00.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bankSafeItem00.Location = new System.Drawing.Point(12, 15);
            this.bankSafeItem00.Name = "bankSafeItem00";
            this.bankSafeItem00.ShowItemCount = true;
            this.bankSafeItem00.Size = new System.Drawing.Size(32, 32);
            this.bankSafeItem00.TabIndex = 43;
            this.bankSafeItem00.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.bankSafeItem00.Click += new System.EventHandler(this.bankSafeItem_Click);
            this.bankSafeItem00.MouseEnter += new System.EventHandler(this.bankSafeItem_MouseEnter);
            this.bankSafeItem00.MouseLeave += new System.EventHandler(this.bankSafeItem_MouseLeave);
            this.bankSafeItem00.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.bankSafeItem_PreviewKeyDown);
            // 
            // groupBox10
            // 
            this.groupBox10.BackColor = System.Drawing.Color.Transparent;
            this.groupBox10.Controls.Add(this.bankSafeItem40);
            this.groupBox10.Controls.Add(this.bankSafeItem41);
            this.groupBox10.Controls.Add(this.bankSafeItem79);
            this.groupBox10.Controls.Add(this.bankSafeItem42);
            this.groupBox10.Controls.Add(this.bankSafeItem78);
            this.groupBox10.Controls.Add(this.bankSafeItem43);
            this.groupBox10.Controls.Add(this.bankSafeItem77);
            this.groupBox10.Controls.Add(this.bankSafeItem44);
            this.groupBox10.Controls.Add(this.bankSafeItem76);
            this.groupBox10.Controls.Add(this.bankSafeItem45);
            this.groupBox10.Controls.Add(this.bankSafeItem75);
            this.groupBox10.Controls.Add(this.bankSafeItem46);
            this.groupBox10.Controls.Add(this.bankSafeItem74);
            this.groupBox10.Controls.Add(this.bankSafeItem47);
            this.groupBox10.Controls.Add(this.bankSafeItem73);
            this.groupBox10.Controls.Add(this.bankSafeItem48);
            this.groupBox10.Controls.Add(this.bankSafeItem72);
            this.groupBox10.Controls.Add(this.bankSafeItem49);
            this.groupBox10.Controls.Add(this.bankSafeItem71);
            this.groupBox10.Controls.Add(this.bankSafeItem50);
            this.groupBox10.Controls.Add(this.bankSafeItem70);
            this.groupBox10.Controls.Add(this.bankSafeItem51);
            this.groupBox10.Controls.Add(this.bankSafeItem69);
            this.groupBox10.Controls.Add(this.bankSafeItem52);
            this.groupBox10.Controls.Add(this.bankSafeItem68);
            this.groupBox10.Controls.Add(this.bankSafeItem53);
            this.groupBox10.Controls.Add(this.bankSafeItem67);
            this.groupBox10.Controls.Add(this.bankSafeItem54);
            this.groupBox10.Controls.Add(this.bankSafeItem66);
            this.groupBox10.Controls.Add(this.bankSafeItem55);
            this.groupBox10.Controls.Add(this.bankSafeItem65);
            this.groupBox10.Controls.Add(this.bankSafeItem56);
            this.groupBox10.Controls.Add(this.bankSafeItem64);
            this.groupBox10.Controls.Add(this.bankSafeItem57);
            this.groupBox10.Controls.Add(this.bankSafeItem63);
            this.groupBox10.Controls.Add(this.bankSafeItem58);
            this.groupBox10.Controls.Add(this.bankSafeItem62);
            this.groupBox10.Controls.Add(this.bankSafeItem59);
            this.groupBox10.Controls.Add(this.bankSafeItem61);
            this.groupBox10.Controls.Add(this.bankSafeItem60);
            this.groupBox10.Location = new System.Drawing.Point(272, 208);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(399, 169);
            this.groupBox10.TabIndex = 85;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Safe Items";
            // 
            // bankSafeItem40
            // 
            this.bankSafeItem40.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bankSafeItem40.Location = new System.Drawing.Point(12, 16);
            this.bankSafeItem40.Name = "bankSafeItem40";
            this.bankSafeItem40.ShowItemCount = true;
            this.bankSafeItem40.Size = new System.Drawing.Size(32, 32);
            this.bankSafeItem40.TabIndex = 35;
            this.bankSafeItem40.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.bankSafeItem40.Click += new System.EventHandler(this.bankSafeItem_Click);
            this.bankSafeItem40.MouseEnter += new System.EventHandler(this.bankSafeItem_MouseEnter);
            this.bankSafeItem40.MouseLeave += new System.EventHandler(this.bankSafeItem_MouseLeave);
            this.bankSafeItem40.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.bankSafeItem_PreviewKeyDown);
            // 
            // bankSafeItem41
            // 
            this.bankSafeItem41.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bankSafeItem41.Location = new System.Drawing.Point(50, 16);
            this.bankSafeItem41.Name = "bankSafeItem41";
            this.bankSafeItem41.ShowItemCount = true;
            this.bankSafeItem41.Size = new System.Drawing.Size(32, 32);
            this.bankSafeItem41.TabIndex = 82;
            this.bankSafeItem41.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.bankSafeItem41.Click += new System.EventHandler(this.bankSafeItem_Click);
            this.bankSafeItem41.MouseEnter += new System.EventHandler(this.bankSafeItem_MouseEnter);
            this.bankSafeItem41.MouseLeave += new System.EventHandler(this.bankSafeItem_MouseLeave);
            this.bankSafeItem41.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.bankSafeItem_PreviewKeyDown);
            // 
            // bankSafeItem79
            // 
            this.bankSafeItem79.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bankSafeItem79.Location = new System.Drawing.Point(354, 127);
            this.bankSafeItem79.Name = "bankSafeItem79";
            this.bankSafeItem79.ShowItemCount = true;
            this.bankSafeItem79.Size = new System.Drawing.Size(32, 32);
            this.bankSafeItem79.TabIndex = 44;
            this.bankSafeItem79.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.bankSafeItem79.Click += new System.EventHandler(this.bankSafeItem_Click);
            this.bankSafeItem79.MouseEnter += new System.EventHandler(this.bankSafeItem_MouseEnter);
            this.bankSafeItem79.MouseLeave += new System.EventHandler(this.bankSafeItem_MouseLeave);
            this.bankSafeItem79.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.bankSafeItem_PreviewKeyDown);
            // 
            // bankSafeItem42
            // 
            this.bankSafeItem42.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bankSafeItem42.Location = new System.Drawing.Point(88, 16);
            this.bankSafeItem42.Name = "bankSafeItem42";
            this.bankSafeItem42.ShowItemCount = true;
            this.bankSafeItem42.Size = new System.Drawing.Size(32, 32);
            this.bankSafeItem42.TabIndex = 81;
            this.bankSafeItem42.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.bankSafeItem42.Click += new System.EventHandler(this.bankSafeItem_Click);
            this.bankSafeItem42.MouseEnter += new System.EventHandler(this.bankSafeItem_MouseEnter);
            this.bankSafeItem42.MouseLeave += new System.EventHandler(this.bankSafeItem_MouseLeave);
            this.bankSafeItem42.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.bankSafeItem_PreviewKeyDown);
            // 
            // bankSafeItem78
            // 
            this.bankSafeItem78.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bankSafeItem78.Location = new System.Drawing.Point(316, 127);
            this.bankSafeItem78.Name = "bankSafeItem78";
            this.bankSafeItem78.ShowItemCount = true;
            this.bankSafeItem78.Size = new System.Drawing.Size(32, 32);
            this.bankSafeItem78.TabIndex = 45;
            this.bankSafeItem78.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.bankSafeItem78.Click += new System.EventHandler(this.bankSafeItem_Click);
            this.bankSafeItem78.MouseEnter += new System.EventHandler(this.bankSafeItem_MouseEnter);
            this.bankSafeItem78.MouseLeave += new System.EventHandler(this.bankSafeItem_MouseLeave);
            this.bankSafeItem78.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.bankSafeItem_PreviewKeyDown);
            // 
            // bankSafeItem43
            // 
            this.bankSafeItem43.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bankSafeItem43.Location = new System.Drawing.Point(126, 16);
            this.bankSafeItem43.Name = "bankSafeItem43";
            this.bankSafeItem43.ShowItemCount = true;
            this.bankSafeItem43.Size = new System.Drawing.Size(32, 32);
            this.bankSafeItem43.TabIndex = 80;
            this.bankSafeItem43.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.bankSafeItem43.Click += new System.EventHandler(this.bankSafeItem_Click);
            this.bankSafeItem43.MouseEnter += new System.EventHandler(this.bankSafeItem_MouseEnter);
            this.bankSafeItem43.MouseLeave += new System.EventHandler(this.bankSafeItem_MouseLeave);
            this.bankSafeItem43.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.bankSafeItem_PreviewKeyDown);
            // 
            // bankSafeItem77
            // 
            this.bankSafeItem77.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bankSafeItem77.Location = new System.Drawing.Point(278, 127);
            this.bankSafeItem77.Name = "bankSafeItem77";
            this.bankSafeItem77.ShowItemCount = true;
            this.bankSafeItem77.Size = new System.Drawing.Size(32, 32);
            this.bankSafeItem77.TabIndex = 46;
            this.bankSafeItem77.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.bankSafeItem77.Click += new System.EventHandler(this.bankSafeItem_Click);
            this.bankSafeItem77.MouseEnter += new System.EventHandler(this.bankSafeItem_MouseEnter);
            this.bankSafeItem77.MouseLeave += new System.EventHandler(this.bankSafeItem_MouseLeave);
            this.bankSafeItem77.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.bankSafeItem_PreviewKeyDown);
            // 
            // bankSafeItem44
            // 
            this.bankSafeItem44.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bankSafeItem44.Location = new System.Drawing.Point(164, 16);
            this.bankSafeItem44.Name = "bankSafeItem44";
            this.bankSafeItem44.ShowItemCount = true;
            this.bankSafeItem44.Size = new System.Drawing.Size(32, 32);
            this.bankSafeItem44.TabIndex = 79;
            this.bankSafeItem44.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.bankSafeItem44.Click += new System.EventHandler(this.bankSafeItem_Click);
            this.bankSafeItem44.MouseEnter += new System.EventHandler(this.bankSafeItem_MouseEnter);
            this.bankSafeItem44.MouseLeave += new System.EventHandler(this.bankSafeItem_MouseLeave);
            this.bankSafeItem44.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.bankSafeItem_PreviewKeyDown);
            // 
            // bankSafeItem76
            // 
            this.bankSafeItem76.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bankSafeItem76.Location = new System.Drawing.Point(240, 127);
            this.bankSafeItem76.Name = "bankSafeItem76";
            this.bankSafeItem76.ShowItemCount = true;
            this.bankSafeItem76.Size = new System.Drawing.Size(32, 32);
            this.bankSafeItem76.TabIndex = 47;
            this.bankSafeItem76.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.bankSafeItem76.Click += new System.EventHandler(this.bankSafeItem_Click);
            this.bankSafeItem76.MouseEnter += new System.EventHandler(this.bankSafeItem_MouseEnter);
            this.bankSafeItem76.MouseLeave += new System.EventHandler(this.bankSafeItem_MouseLeave);
            this.bankSafeItem76.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.bankSafeItem_PreviewKeyDown);
            // 
            // bankSafeItem45
            // 
            this.bankSafeItem45.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bankSafeItem45.Location = new System.Drawing.Point(202, 16);
            this.bankSafeItem45.Name = "bankSafeItem45";
            this.bankSafeItem45.ShowItemCount = true;
            this.bankSafeItem45.Size = new System.Drawing.Size(32, 32);
            this.bankSafeItem45.TabIndex = 78;
            this.bankSafeItem45.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.bankSafeItem45.Click += new System.EventHandler(this.bankSafeItem_Click);
            this.bankSafeItem45.MouseEnter += new System.EventHandler(this.bankSafeItem_MouseEnter);
            this.bankSafeItem45.MouseLeave += new System.EventHandler(this.bankSafeItem_MouseLeave);
            this.bankSafeItem45.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.bankSafeItem_PreviewKeyDown);
            // 
            // bankSafeItem75
            // 
            this.bankSafeItem75.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bankSafeItem75.Location = new System.Drawing.Point(202, 127);
            this.bankSafeItem75.Name = "bankSafeItem75";
            this.bankSafeItem75.ShowItemCount = true;
            this.bankSafeItem75.Size = new System.Drawing.Size(32, 32);
            this.bankSafeItem75.TabIndex = 48;
            this.bankSafeItem75.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.bankSafeItem75.Click += new System.EventHandler(this.bankSafeItem_Click);
            this.bankSafeItem75.MouseEnter += new System.EventHandler(this.bankSafeItem_MouseEnter);
            this.bankSafeItem75.MouseLeave += new System.EventHandler(this.bankSafeItem_MouseLeave);
            this.bankSafeItem75.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.bankSafeItem_PreviewKeyDown);
            // 
            // bankSafeItem46
            // 
            this.bankSafeItem46.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bankSafeItem46.Location = new System.Drawing.Point(240, 16);
            this.bankSafeItem46.Name = "bankSafeItem46";
            this.bankSafeItem46.ShowItemCount = true;
            this.bankSafeItem46.Size = new System.Drawing.Size(32, 32);
            this.bankSafeItem46.TabIndex = 77;
            this.bankSafeItem46.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.bankSafeItem46.Click += new System.EventHandler(this.bankSafeItem_Click);
            this.bankSafeItem46.MouseEnter += new System.EventHandler(this.bankSafeItem_MouseEnter);
            this.bankSafeItem46.MouseLeave += new System.EventHandler(this.bankSafeItem_MouseLeave);
            this.bankSafeItem46.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.bankSafeItem_PreviewKeyDown);
            // 
            // bankSafeItem74
            // 
            this.bankSafeItem74.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bankSafeItem74.Location = new System.Drawing.Point(164, 127);
            this.bankSafeItem74.Name = "bankSafeItem74";
            this.bankSafeItem74.ShowItemCount = true;
            this.bankSafeItem74.Size = new System.Drawing.Size(32, 32);
            this.bankSafeItem74.TabIndex = 49;
            this.bankSafeItem74.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.bankSafeItem74.Click += new System.EventHandler(this.bankSafeItem_Click);
            this.bankSafeItem74.MouseEnter += new System.EventHandler(this.bankSafeItem_MouseEnter);
            this.bankSafeItem74.MouseLeave += new System.EventHandler(this.bankSafeItem_MouseLeave);
            this.bankSafeItem74.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.bankSafeItem_PreviewKeyDown);
            // 
            // bankSafeItem47
            // 
            this.bankSafeItem47.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bankSafeItem47.Location = new System.Drawing.Point(278, 16);
            this.bankSafeItem47.Name = "bankSafeItem47";
            this.bankSafeItem47.ShowItemCount = true;
            this.bankSafeItem47.Size = new System.Drawing.Size(32, 32);
            this.bankSafeItem47.TabIndex = 76;
            this.bankSafeItem47.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.bankSafeItem47.Click += new System.EventHandler(this.bankSafeItem_Click);
            this.bankSafeItem47.MouseEnter += new System.EventHandler(this.bankSafeItem_MouseEnter);
            this.bankSafeItem47.MouseLeave += new System.EventHandler(this.bankSafeItem_MouseLeave);
            this.bankSafeItem47.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.bankSafeItem_PreviewKeyDown);
            // 
            // bankSafeItem73
            // 
            this.bankSafeItem73.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bankSafeItem73.Location = new System.Drawing.Point(126, 127);
            this.bankSafeItem73.Name = "bankSafeItem73";
            this.bankSafeItem73.ShowItemCount = true;
            this.bankSafeItem73.Size = new System.Drawing.Size(32, 32);
            this.bankSafeItem73.TabIndex = 50;
            this.bankSafeItem73.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.bankSafeItem73.Click += new System.EventHandler(this.bankSafeItem_Click);
            this.bankSafeItem73.MouseEnter += new System.EventHandler(this.bankSafeItem_MouseEnter);
            this.bankSafeItem73.MouseLeave += new System.EventHandler(this.bankSafeItem_MouseLeave);
            this.bankSafeItem73.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.bankSafeItem_PreviewKeyDown);
            // 
            // bankSafeItem48
            // 
            this.bankSafeItem48.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bankSafeItem48.Location = new System.Drawing.Point(316, 16);
            this.bankSafeItem48.Name = "bankSafeItem48";
            this.bankSafeItem48.ShowItemCount = true;
            this.bankSafeItem48.Size = new System.Drawing.Size(32, 32);
            this.bankSafeItem48.TabIndex = 75;
            this.bankSafeItem48.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.bankSafeItem48.Click += new System.EventHandler(this.bankSafeItem_Click);
            this.bankSafeItem48.MouseEnter += new System.EventHandler(this.bankSafeItem_MouseEnter);
            this.bankSafeItem48.MouseLeave += new System.EventHandler(this.bankSafeItem_MouseLeave);
            this.bankSafeItem48.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.bankSafeItem_PreviewKeyDown);
            // 
            // bankSafeItem72
            // 
            this.bankSafeItem72.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bankSafeItem72.Location = new System.Drawing.Point(88, 127);
            this.bankSafeItem72.Name = "bankSafeItem72";
            this.bankSafeItem72.ShowItemCount = true;
            this.bankSafeItem72.Size = new System.Drawing.Size(32, 32);
            this.bankSafeItem72.TabIndex = 51;
            this.bankSafeItem72.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.bankSafeItem72.Click += new System.EventHandler(this.bankSafeItem_Click);
            this.bankSafeItem72.MouseEnter += new System.EventHandler(this.bankSafeItem_MouseEnter);
            this.bankSafeItem72.MouseLeave += new System.EventHandler(this.bankSafeItem_MouseLeave);
            this.bankSafeItem72.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.bankSafeItem_PreviewKeyDown);
            // 
            // bankSafeItem49
            // 
            this.bankSafeItem49.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bankSafeItem49.Location = new System.Drawing.Point(354, 16);
            this.bankSafeItem49.Name = "bankSafeItem49";
            this.bankSafeItem49.ShowItemCount = true;
            this.bankSafeItem49.Size = new System.Drawing.Size(32, 32);
            this.bankSafeItem49.TabIndex = 74;
            this.bankSafeItem49.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.bankSafeItem49.Click += new System.EventHandler(this.bankSafeItem_Click);
            this.bankSafeItem49.MouseEnter += new System.EventHandler(this.bankSafeItem_MouseEnter);
            this.bankSafeItem49.MouseLeave += new System.EventHandler(this.bankSafeItem_MouseLeave);
            this.bankSafeItem49.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.bankSafeItem_PreviewKeyDown);
            // 
            // bankSafeItem71
            // 
            this.bankSafeItem71.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bankSafeItem71.Location = new System.Drawing.Point(50, 127);
            this.bankSafeItem71.Name = "bankSafeItem71";
            this.bankSafeItem71.ShowItemCount = true;
            this.bankSafeItem71.Size = new System.Drawing.Size(32, 32);
            this.bankSafeItem71.TabIndex = 52;
            this.bankSafeItem71.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.bankSafeItem71.Click += new System.EventHandler(this.bankSafeItem_Click);
            this.bankSafeItem71.MouseEnter += new System.EventHandler(this.bankSafeItem_MouseEnter);
            this.bankSafeItem71.MouseLeave += new System.EventHandler(this.bankSafeItem_MouseLeave);
            this.bankSafeItem71.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.bankSafeItem_PreviewKeyDown);
            // 
            // bankSafeItem50
            // 
            this.bankSafeItem50.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bankSafeItem50.Location = new System.Drawing.Point(12, 53);
            this.bankSafeItem50.Name = "bankSafeItem50";
            this.bankSafeItem50.ShowItemCount = true;
            this.bankSafeItem50.Size = new System.Drawing.Size(32, 32);
            this.bankSafeItem50.TabIndex = 73;
            this.bankSafeItem50.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.bankSafeItem50.Click += new System.EventHandler(this.bankSafeItem_Click);
            this.bankSafeItem50.MouseEnter += new System.EventHandler(this.bankSafeItem_MouseEnter);
            this.bankSafeItem50.MouseLeave += new System.EventHandler(this.bankSafeItem_MouseLeave);
            this.bankSafeItem50.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.bankSafeItem_PreviewKeyDown);
            // 
            // bankSafeItem70
            // 
            this.bankSafeItem70.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bankSafeItem70.Location = new System.Drawing.Point(12, 127);
            this.bankSafeItem70.Name = "bankSafeItem70";
            this.bankSafeItem70.ShowItemCount = true;
            this.bankSafeItem70.Size = new System.Drawing.Size(32, 32);
            this.bankSafeItem70.TabIndex = 53;
            this.bankSafeItem70.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.bankSafeItem70.Click += new System.EventHandler(this.bankSafeItem_Click);
            this.bankSafeItem70.MouseEnter += new System.EventHandler(this.bankSafeItem_MouseEnter);
            this.bankSafeItem70.MouseLeave += new System.EventHandler(this.bankSafeItem_MouseLeave);
            this.bankSafeItem70.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.bankSafeItem_PreviewKeyDown);
            // 
            // bankSafeItem51
            // 
            this.bankSafeItem51.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bankSafeItem51.Location = new System.Drawing.Point(50, 53);
            this.bankSafeItem51.Name = "bankSafeItem51";
            this.bankSafeItem51.ShowItemCount = true;
            this.bankSafeItem51.Size = new System.Drawing.Size(32, 32);
            this.bankSafeItem51.TabIndex = 72;
            this.bankSafeItem51.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.bankSafeItem51.Click += new System.EventHandler(this.bankSafeItem_Click);
            this.bankSafeItem51.MouseEnter += new System.EventHandler(this.bankSafeItem_MouseEnter);
            this.bankSafeItem51.MouseLeave += new System.EventHandler(this.bankSafeItem_MouseLeave);
            this.bankSafeItem51.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.bankSafeItem_PreviewKeyDown);
            // 
            // bankSafeItem69
            // 
            this.bankSafeItem69.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bankSafeItem69.Location = new System.Drawing.Point(354, 90);
            this.bankSafeItem69.Name = "bankSafeItem69";
            this.bankSafeItem69.ShowItemCount = true;
            this.bankSafeItem69.Size = new System.Drawing.Size(32, 32);
            this.bankSafeItem69.TabIndex = 54;
            this.bankSafeItem69.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.bankSafeItem69.Click += new System.EventHandler(this.bankSafeItem_Click);
            this.bankSafeItem69.MouseEnter += new System.EventHandler(this.bankSafeItem_MouseEnter);
            this.bankSafeItem69.MouseLeave += new System.EventHandler(this.bankSafeItem_MouseLeave);
            this.bankSafeItem69.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.bankSafeItem_PreviewKeyDown);
            // 
            // bankSafeItem52
            // 
            this.bankSafeItem52.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bankSafeItem52.Location = new System.Drawing.Point(88, 53);
            this.bankSafeItem52.Name = "bankSafeItem52";
            this.bankSafeItem52.ShowItemCount = true;
            this.bankSafeItem52.Size = new System.Drawing.Size(32, 32);
            this.bankSafeItem52.TabIndex = 71;
            this.bankSafeItem52.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.bankSafeItem52.Click += new System.EventHandler(this.bankSafeItem_Click);
            this.bankSafeItem52.MouseEnter += new System.EventHandler(this.bankSafeItem_MouseEnter);
            this.bankSafeItem52.MouseLeave += new System.EventHandler(this.bankSafeItem_MouseLeave);
            this.bankSafeItem52.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.bankSafeItem_PreviewKeyDown);
            // 
            // bankSafeItem68
            // 
            this.bankSafeItem68.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bankSafeItem68.Location = new System.Drawing.Point(316, 92);
            this.bankSafeItem68.Name = "bankSafeItem68";
            this.bankSafeItem68.ShowItemCount = true;
            this.bankSafeItem68.Size = new System.Drawing.Size(32, 32);
            this.bankSafeItem68.TabIndex = 55;
            this.bankSafeItem68.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.bankSafeItem68.Click += new System.EventHandler(this.bankSafeItem_Click);
            this.bankSafeItem68.MouseEnter += new System.EventHandler(this.bankSafeItem_MouseEnter);
            this.bankSafeItem68.MouseLeave += new System.EventHandler(this.bankSafeItem_MouseLeave);
            this.bankSafeItem68.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.bankSafeItem_PreviewKeyDown);
            // 
            // bankSafeItem53
            // 
            this.bankSafeItem53.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bankSafeItem53.Location = new System.Drawing.Point(126, 53);
            this.bankSafeItem53.Name = "bankSafeItem53";
            this.bankSafeItem53.ShowItemCount = true;
            this.bankSafeItem53.Size = new System.Drawing.Size(32, 32);
            this.bankSafeItem53.TabIndex = 70;
            this.bankSafeItem53.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.bankSafeItem53.Click += new System.EventHandler(this.bankSafeItem_Click);
            this.bankSafeItem53.MouseEnter += new System.EventHandler(this.bankSafeItem_MouseEnter);
            this.bankSafeItem53.MouseLeave += new System.EventHandler(this.bankSafeItem_MouseLeave);
            this.bankSafeItem53.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.bankSafeItem_PreviewKeyDown);
            // 
            // bankSafeItem67
            // 
            this.bankSafeItem67.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bankSafeItem67.Location = new System.Drawing.Point(278, 92);
            this.bankSafeItem67.Name = "bankSafeItem67";
            this.bankSafeItem67.ShowItemCount = true;
            this.bankSafeItem67.Size = new System.Drawing.Size(32, 32);
            this.bankSafeItem67.TabIndex = 56;
            this.bankSafeItem67.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.bankSafeItem67.Click += new System.EventHandler(this.bankSafeItem_Click);
            this.bankSafeItem67.MouseEnter += new System.EventHandler(this.bankSafeItem_MouseEnter);
            this.bankSafeItem67.MouseLeave += new System.EventHandler(this.bankSafeItem_MouseLeave);
            this.bankSafeItem67.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.bankSafeItem_PreviewKeyDown);
            // 
            // bankSafeItem54
            // 
            this.bankSafeItem54.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bankSafeItem54.Location = new System.Drawing.Point(164, 53);
            this.bankSafeItem54.Name = "bankSafeItem54";
            this.bankSafeItem54.ShowItemCount = true;
            this.bankSafeItem54.Size = new System.Drawing.Size(32, 32);
            this.bankSafeItem54.TabIndex = 69;
            this.bankSafeItem54.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.bankSafeItem54.Click += new System.EventHandler(this.bankSafeItem_Click);
            this.bankSafeItem54.MouseEnter += new System.EventHandler(this.bankSafeItem_MouseEnter);
            this.bankSafeItem54.MouseLeave += new System.EventHandler(this.bankSafeItem_MouseLeave);
            this.bankSafeItem54.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.bankSafeItem_PreviewKeyDown);
            // 
            // bankSafeItem66
            // 
            this.bankSafeItem66.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bankSafeItem66.Location = new System.Drawing.Point(240, 92);
            this.bankSafeItem66.Name = "bankSafeItem66";
            this.bankSafeItem66.ShowItemCount = true;
            this.bankSafeItem66.Size = new System.Drawing.Size(32, 32);
            this.bankSafeItem66.TabIndex = 57;
            this.bankSafeItem66.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.bankSafeItem66.Click += new System.EventHandler(this.bankSafeItem_Click);
            this.bankSafeItem66.MouseEnter += new System.EventHandler(this.bankSafeItem_MouseEnter);
            this.bankSafeItem66.MouseLeave += new System.EventHandler(this.bankSafeItem_MouseLeave);
            this.bankSafeItem66.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.bankSafeItem_PreviewKeyDown);
            // 
            // bankSafeItem55
            // 
            this.bankSafeItem55.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bankSafeItem55.Location = new System.Drawing.Point(202, 53);
            this.bankSafeItem55.Name = "bankSafeItem55";
            this.bankSafeItem55.ShowItemCount = true;
            this.bankSafeItem55.Size = new System.Drawing.Size(32, 32);
            this.bankSafeItem55.TabIndex = 68;
            this.bankSafeItem55.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.bankSafeItem55.Click += new System.EventHandler(this.bankSafeItem_Click);
            this.bankSafeItem55.MouseEnter += new System.EventHandler(this.bankSafeItem_MouseEnter);
            this.bankSafeItem55.MouseLeave += new System.EventHandler(this.bankSafeItem_MouseLeave);
            this.bankSafeItem55.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.bankSafeItem_PreviewKeyDown);
            // 
            // bankSafeItem65
            // 
            this.bankSafeItem65.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bankSafeItem65.Location = new System.Drawing.Point(202, 92);
            this.bankSafeItem65.Name = "bankSafeItem65";
            this.bankSafeItem65.ShowItemCount = true;
            this.bankSafeItem65.Size = new System.Drawing.Size(32, 32);
            this.bankSafeItem65.TabIndex = 58;
            this.bankSafeItem65.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.bankSafeItem65.Click += new System.EventHandler(this.bankSafeItem_Click);
            this.bankSafeItem65.MouseEnter += new System.EventHandler(this.bankSafeItem_MouseEnter);
            this.bankSafeItem65.MouseLeave += new System.EventHandler(this.bankSafeItem_MouseLeave);
            this.bankSafeItem65.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.bankSafeItem_PreviewKeyDown);
            // 
            // bankSafeItem56
            // 
            this.bankSafeItem56.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bankSafeItem56.Location = new System.Drawing.Point(240, 53);
            this.bankSafeItem56.Name = "bankSafeItem56";
            this.bankSafeItem56.ShowItemCount = true;
            this.bankSafeItem56.Size = new System.Drawing.Size(32, 32);
            this.bankSafeItem56.TabIndex = 67;
            this.bankSafeItem56.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.bankSafeItem56.Click += new System.EventHandler(this.bankSafeItem_Click);
            this.bankSafeItem56.MouseEnter += new System.EventHandler(this.bankSafeItem_MouseEnter);
            this.bankSafeItem56.MouseLeave += new System.EventHandler(this.bankSafeItem_MouseLeave);
            this.bankSafeItem56.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.bankSafeItem_PreviewKeyDown);
            // 
            // bankSafeItem64
            // 
            this.bankSafeItem64.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bankSafeItem64.Location = new System.Drawing.Point(164, 92);
            this.bankSafeItem64.Name = "bankSafeItem64";
            this.bankSafeItem64.ShowItemCount = true;
            this.bankSafeItem64.Size = new System.Drawing.Size(32, 32);
            this.bankSafeItem64.TabIndex = 59;
            this.bankSafeItem64.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.bankSafeItem64.Click += new System.EventHandler(this.bankSafeItem_Click);
            this.bankSafeItem64.MouseEnter += new System.EventHandler(this.bankSafeItem_MouseEnter);
            this.bankSafeItem64.MouseLeave += new System.EventHandler(this.bankSafeItem_MouseLeave);
            this.bankSafeItem64.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.bankSafeItem_PreviewKeyDown);
            // 
            // bankSafeItem57
            // 
            this.bankSafeItem57.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bankSafeItem57.Location = new System.Drawing.Point(278, 53);
            this.bankSafeItem57.Name = "bankSafeItem57";
            this.bankSafeItem57.ShowItemCount = true;
            this.bankSafeItem57.Size = new System.Drawing.Size(32, 32);
            this.bankSafeItem57.TabIndex = 66;
            this.bankSafeItem57.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.bankSafeItem57.Click += new System.EventHandler(this.bankSafeItem_Click);
            this.bankSafeItem57.MouseEnter += new System.EventHandler(this.bankSafeItem_MouseEnter);
            this.bankSafeItem57.MouseLeave += new System.EventHandler(this.bankSafeItem_MouseLeave);
            this.bankSafeItem57.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.bankSafeItem_PreviewKeyDown);
            // 
            // bankSafeItem63
            // 
            this.bankSafeItem63.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bankSafeItem63.Location = new System.Drawing.Point(126, 90);
            this.bankSafeItem63.Name = "bankSafeItem63";
            this.bankSafeItem63.ShowItemCount = true;
            this.bankSafeItem63.Size = new System.Drawing.Size(32, 32);
            this.bankSafeItem63.TabIndex = 60;
            this.bankSafeItem63.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.bankSafeItem63.Click += new System.EventHandler(this.bankSafeItem_Click);
            this.bankSafeItem63.MouseEnter += new System.EventHandler(this.bankSafeItem_MouseEnter);
            this.bankSafeItem63.MouseLeave += new System.EventHandler(this.bankSafeItem_MouseLeave);
            this.bankSafeItem63.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.bankSafeItem_PreviewKeyDown);
            // 
            // bankSafeItem58
            // 
            this.bankSafeItem58.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bankSafeItem58.Location = new System.Drawing.Point(316, 53);
            this.bankSafeItem58.Name = "bankSafeItem58";
            this.bankSafeItem58.ShowItemCount = true;
            this.bankSafeItem58.Size = new System.Drawing.Size(32, 32);
            this.bankSafeItem58.TabIndex = 65;
            this.bankSafeItem58.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.bankSafeItem58.Click += new System.EventHandler(this.bankSafeItem_Click);
            this.bankSafeItem58.MouseEnter += new System.EventHandler(this.bankSafeItem_MouseEnter);
            this.bankSafeItem58.MouseLeave += new System.EventHandler(this.bankSafeItem_MouseLeave);
            this.bankSafeItem58.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.bankSafeItem_PreviewKeyDown);
            // 
            // bankSafeItem62
            // 
            this.bankSafeItem62.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bankSafeItem62.Location = new System.Drawing.Point(88, 90);
            this.bankSafeItem62.Name = "bankSafeItem62";
            this.bankSafeItem62.ShowItemCount = true;
            this.bankSafeItem62.Size = new System.Drawing.Size(32, 32);
            this.bankSafeItem62.TabIndex = 61;
            this.bankSafeItem62.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.bankSafeItem62.Click += new System.EventHandler(this.bankSafeItem_Click);
            this.bankSafeItem62.MouseEnter += new System.EventHandler(this.bankSafeItem_MouseEnter);
            this.bankSafeItem62.MouseLeave += new System.EventHandler(this.bankSafeItem_MouseLeave);
            this.bankSafeItem62.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.bankSafeItem_PreviewKeyDown);
            // 
            // bankSafeItem59
            // 
            this.bankSafeItem59.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bankSafeItem59.Location = new System.Drawing.Point(354, 53);
            this.bankSafeItem59.Name = "bankSafeItem59";
            this.bankSafeItem59.ShowItemCount = true;
            this.bankSafeItem59.Size = new System.Drawing.Size(32, 32);
            this.bankSafeItem59.TabIndex = 64;
            this.bankSafeItem59.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.bankSafeItem59.Click += new System.EventHandler(this.bankSafeItem_Click);
            this.bankSafeItem59.MouseEnter += new System.EventHandler(this.bankSafeItem_MouseEnter);
            this.bankSafeItem59.MouseLeave += new System.EventHandler(this.bankSafeItem_MouseLeave);
            this.bankSafeItem59.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.bankSafeItem_PreviewKeyDown);
            // 
            // bankSafeItem61
            // 
            this.bankSafeItem61.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bankSafeItem61.Location = new System.Drawing.Point(50, 90);
            this.bankSafeItem61.Name = "bankSafeItem61";
            this.bankSafeItem61.ShowItemCount = true;
            this.bankSafeItem61.Size = new System.Drawing.Size(32, 32);
            this.bankSafeItem61.TabIndex = 62;
            this.bankSafeItem61.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.bankSafeItem61.Click += new System.EventHandler(this.bankSafeItem_Click);
            this.bankSafeItem61.MouseEnter += new System.EventHandler(this.bankSafeItem_MouseEnter);
            this.bankSafeItem61.MouseLeave += new System.EventHandler(this.bankSafeItem_MouseLeave);
            this.bankSafeItem61.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.bankSafeItem_PreviewKeyDown);
            // 
            // bankSafeItem60
            // 
            this.bankSafeItem60.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bankSafeItem60.Location = new System.Drawing.Point(12, 90);
            this.bankSafeItem60.Name = "bankSafeItem60";
            this.bankSafeItem60.ShowItemCount = true;
            this.bankSafeItem60.Size = new System.Drawing.Size(32, 32);
            this.bankSafeItem60.TabIndex = 63;
            this.bankSafeItem60.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.bankSafeItem60.Click += new System.EventHandler(this.bankSafeItem_Click);
            this.bankSafeItem60.MouseEnter += new System.EventHandler(this.bankSafeItem_MouseEnter);
            this.bankSafeItem60.MouseLeave += new System.EventHandler(this.bankSafeItem_MouseLeave);
            this.bankSafeItem60.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.bankSafeItem_PreviewKeyDown);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tscboQuickSelect,
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(620, 27);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tscboQuickSelect
            // 
            this.tscboQuickSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tscboQuickSelect.Name = "tscboQuickSelect";
            this.tscboQuickSelect.Size = new System.Drawing.Size(121, 23);
            this.tscboQuickSelect.DropDown += new System.EventHandler(this.tscboQuickSelect_DropDown);
            this.tscboQuickSelect.SelectedIndexChanged += new System.EventHandler(this.tscboQuickSelect_SelectedIndexChanged);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newCharacterToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator1,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 23);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newCharacterToolStripMenuItem
            // 
            this.newCharacterToolStripMenuItem.Image = global::tsge.Properties.Resources.status_online;
            this.newCharacterToolStripMenuItem.Name = "newCharacterToolStripMenuItem";
            this.newCharacterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newCharacterToolStripMenuItem.Text = "New Character";
            this.newCharacterToolStripMenuItem.Click += new System.EventHandler(this.newCharacterToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = global::tsge.Properties.Resources.folder_user;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = global::tsge.Properties.Resources.page_save;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Image = global::tsge.Properties.Resources.script_save;
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::tsge.Properties.Resources.stop;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutTSGEToolStripMenuItem,
            this.checkForUpdatesToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 23);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutTSGEToolStripMenuItem
            // 
            this.aboutTSGEToolStripMenuItem.Image = global::tsge.Properties.Resources.information;
            this.aboutTSGEToolStripMenuItem.Name = "aboutTSGEToolStripMenuItem";
            this.aboutTSGEToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.aboutTSGEToolStripMenuItem.Text = "About TSGE";
            this.aboutTSGEToolStripMenuItem.Click += new System.EventHandler(this.aboutTSGEToolStripMenuItem_Click);
            // 
            // checkForUpdatesToolStripMenuItem
            // 
            this.checkForUpdatesToolStripMenuItem.Image = global::tsge.Properties.Resources._new;
            this.checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
            this.checkForUpdatesToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.checkForUpdatesToolStripMenuItem.Text = "Check For Updates";
            this.checkForUpdatesToolStripMenuItem.Click += new System.EventHandler(this.checkForUpdatesToolStripMenuItem_Click);
            // 
            // inventoryBindingSource
            // 
            this.inventoryBindingSource.DataMember = "Inventory";
            this.inventoryBindingSource.DataSource = this.playerBindingSource;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(620, 466);
            this.Controls.Add(this.tcMainTabControl);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "TSGE - by atom0s";
            this.tcMainTabControl.ResumeLayout(false);
            this.tpMainPlayer.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbShoesColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPantsColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUndershirtColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShirtColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEyesColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSkinColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHairColor)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tpBuffs.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buffsBindingSource)).EndInit();
            this.tpInventory.ResumeLayout(false);
            this.tpInventory.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.tpEquipment.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.tpBankSafe.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        private void BuffsBindingSourceOnCurrentChanged(object sender, EventArgs eventArgs)
        {
            this.lstPlayerBuffs.Refresh();
        }

        #endregion

        private System.Windows.Forms.TabControl tcMainTabControl;
        private System.Windows.Forms.TabPage tpMainPlayer;
        private System.Windows.Forms.TabPage tpBuffs;
        private System.Windows.Forms.TabPage tpInventory;
        private System.Windows.Forms.TabPage tpEquipment;
        private System.Windows.Forms.TabPage tpBankSafe;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboDifficulty;
        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.CheckBox chkHotbarLocked;
        private System.Windows.Forms.CheckBox chkIsMale;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pbShoesColor;
        private System.Windows.Forms.PictureBox pbPantsColor;
        private System.Windows.Forms.PictureBox pbUndershirtColor;
        private System.Windows.Forms.PictureBox pbShirtColor;
        private System.Windows.Forms.PictureBox pbEyesColor;
        private System.Windows.Forms.PictureBox pbSkinColor;
        private System.Windows.Forms.PictureBox pbHairColor;
        private Controls.ModelViewer modelViewer;
        private System.Windows.Forms.Button btnRandomColors;
        private System.Windows.Forms.Button btnRandomHair;
        private System.Windows.Forms.Button btnSelectHair;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ProgressBar pbPlayerHealth;
        private System.Windows.Forms.ProgressBar pbPlayerMana;
        private System.Windows.Forms.TextBox txtMaxMana;
        private System.Windows.Forms.TextBox txtCurrentMana;
        private System.Windows.Forms.TextBox txtMaxHealth;
        private System.Windows.Forms.TextBox txtCurrentHealth;
        private Controls.BuffListBox lstPlayerBuffs;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newCharacterToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutTSGEToolStripMenuItem;
        private System.Windows.Forms.BindingSource playerBindingSource;
        private BindingSource buffsBindingSource;
        private GroupBox groupBox4;
        private Controls.BuffSelectionListBox lstBuffSelection;
        private Button btnHackAllBuffDurations;
        private Button btnMaxAllBuffDurations;
        private Button btnDeleteAllBuffs;
        private Button btnHackBuffDuration;
        private Button btnMaxBuffDuration;
        private Button btnDeleteBuff;
        private BindingSource inventoryBindingSource;
        private Controls.ItemLabel inventoryItem00;
        private Controls.ItemLabel inventoryItem01;
        private Controls.ItemLabel inventoryItem40;
        private Controls.ItemLabel inventoryItem41;
        private Controls.ItemLabel inventoryItem42;
        private Controls.ItemLabel inventoryItem43;
        private Controls.ItemLabel inventoryItem44;
        private Controls.ItemLabel inventoryItem45;
        private Controls.ItemLabel inventoryItem46;
        private Controls.ItemLabel inventoryItem47;
        private Controls.ItemLabel inventoryItem48;
        private Controls.ItemLabel inventoryItem49;
        private Controls.ItemLabel inventoryItem30;
        private Controls.ItemLabel inventoryItem31;
        private Controls.ItemLabel inventoryItem32;
        private Controls.ItemLabel inventoryItem33;
        private Controls.ItemLabel inventoryItem34;
        private Controls.ItemLabel inventoryItem35;
        private Controls.ItemLabel inventoryItem36;
        private Controls.ItemLabel inventoryItem37;
        private Controls.ItemLabel inventoryItem38;
        private Controls.ItemLabel inventoryItem39;
        private Controls.ItemLabel inventoryItem20;
        private Controls.ItemLabel inventoryItem21;
        private Controls.ItemLabel inventoryItem22;
        private Controls.ItemLabel inventoryItem23;
        private Controls.ItemLabel inventoryItem24;
        private Controls.ItemLabel inventoryItem25;
        private Controls.ItemLabel inventoryItem26;
        private Controls.ItemLabel inventoryItem27;
        private Controls.ItemLabel inventoryItem28;
        private Controls.ItemLabel inventoryItem29;
        private Controls.ItemLabel inventoryItem10;
        private Controls.ItemLabel inventoryItem11;
        private Controls.ItemLabel inventoryItem12;
        private Controls.ItemLabel inventoryItem13;
        private Controls.ItemLabel inventoryItem14;
        private Controls.ItemLabel inventoryItem15;
        private Controls.ItemLabel inventoryItem16;
        private Controls.ItemLabel inventoryItem17;
        private Controls.ItemLabel inventoryItem18;
        private Controls.ItemLabel inventoryItem19;
        private Controls.ItemLabel inventoryItem09;
        private Controls.ItemLabel inventoryItem08;
        private Controls.ItemLabel inventoryItem07;
        private Controls.ItemLabel inventoryItem06;
        private Controls.ItemLabel inventoryItem05;
        private Controls.ItemLabel inventoryItem04;
        private Controls.ItemLabel inventoryItem03;
        private Controls.ItemLabel inventoryItem02;
        private GroupBox groupBox5;
        private ListBox lstInventoryItems;
        private Label label6;
        private Label label5;
        private Controls.ItemLabel inventoryItem54;
        private Controls.ItemLabel inventoryItem53;
        private Controls.ItemLabel inventoryItem57;
        private Controls.ItemLabel inventoryItem52;
        private Controls.ItemLabel inventoryItem56;
        private Controls.ItemLabel inventoryItem51;
        private Controls.ItemLabel inventoryItem55;
        private Controls.ItemLabel inventoryItem50;
        private GroupBox groupBox7;
        private Label label19;
        private ComboBox cboEquipmentPrefix;
        private Label label18;
        private TextBox txtEquipmentFilter;
        private ListBox lstEquipmentItems;
        private Label label23;
        private Controls.ItemLabel equipmentItem13;
        private Controls.ItemLabel equipmentItem12;
        private Controls.ItemLabel equipmentItem11;
        private Controls.ItemLabel equipmentItem10;
        private Controls.ItemLabel equipmentItem09;
        private Label label22;
        private Controls.ItemLabel equipmentItem08;
        private Controls.ItemLabel equipmentItem07;
        private Controls.ItemLabel equipmentItem06;
        private Label label21;
        private Label label20;
        private Controls.ItemLabel equipmentItem05;
        private Controls.ItemLabel equipmentItem04;
        private Controls.ItemLabel equipmentItem03;
        private Controls.ItemLabel equipmentItem02;
        private Controls.ItemLabel equipmentItem01;
        private Controls.ItemLabel equipmentItem00;
        private Controls.ItemLabel bankSafeItem07;
        private Controls.ItemLabel bankSafeItem06;
        private Controls.ItemLabel bankSafeItem05;
        private Controls.ItemLabel bankSafeItem04;
        private Controls.ItemLabel bankSafeItem03;
        private Controls.ItemLabel bankSafeItem02;
        private Controls.ItemLabel bankSafeItem01;
        private Controls.ItemLabel bankSafeItem33;
        private Controls.ItemLabel bankSafeItem34;
        private Controls.ItemLabel bankSafeItem35;
        private Controls.ItemLabel bankSafeItem36;
        private Controls.ItemLabel bankSafeItem37;
        private Controls.ItemLabel bankSafeItem38;
        private Controls.ItemLabel bankSafeItem39;
        private Controls.ItemLabel bankSafeItem40;
        private Controls.ItemLabel bankSafeItem25;
        private Controls.ItemLabel bankSafeItem26;
        private Controls.ItemLabel bankSafeItem27;
        private Controls.ItemLabel bankSafeItem28;
        private Controls.ItemLabel bankSafeItem29;
        private Controls.ItemLabel bankSafeItem30;
        private Controls.ItemLabel bankSafeItem31;
        private Controls.ItemLabel bankSafeItem32;
        private Controls.ItemLabel bankSafeItem17;
        private Controls.ItemLabel bankSafeItem18;
        private Controls.ItemLabel bankSafeItem19;
        private Controls.ItemLabel bankSafeItem20;
        private Controls.ItemLabel bankSafeItem21;
        private Controls.ItemLabel bankSafeItem22;
        private Controls.ItemLabel bankSafeItem23;
        private Controls.ItemLabel bankSafeItem24;
        private Controls.ItemLabel bankSafeItem09;
        private Controls.ItemLabel bankSafeItem10;
        private Controls.ItemLabel bankSafeItem11;
        private Controls.ItemLabel bankSafeItem12;
        private Controls.ItemLabel bankSafeItem13;
        private Controls.ItemLabel bankSafeItem14;
        private Controls.ItemLabel bankSafeItem15;
        private Controls.ItemLabel bankSafeItem16;
        private Controls.ItemLabel bankSafeItem08;
        private Controls.ItemLabel bankSafeItem41;
        private Controls.ItemLabel bankSafeItem42;
        private Controls.ItemLabel bankSafeItem43;
        private Controls.ItemLabel bankSafeItem44;
        private Controls.ItemLabel bankSafeItem45;
        private Controls.ItemLabel bankSafeItem46;
        private Controls.ItemLabel bankSafeItem47;
        private Controls.ItemLabel bankSafeItem48;
        private Controls.ItemLabel bankSafeItem49;
        private Controls.ItemLabel bankSafeItem50;
        private Controls.ItemLabel bankSafeItem51;
        private Controls.ItemLabel bankSafeItem52;
        private Controls.ItemLabel bankSafeItem53;
        private Controls.ItemLabel bankSafeItem54;
        private Controls.ItemLabel bankSafeItem55;
        private Controls.ItemLabel bankSafeItem56;
        private Controls.ItemLabel bankSafeItem57;
        private Controls.ItemLabel bankSafeItem58;
        private Controls.ItemLabel bankSafeItem59;
        private Controls.ItemLabel bankSafeItem60;
        private Controls.ItemLabel bankSafeItem61;
        private Controls.ItemLabel bankSafeItem62;
        private Controls.ItemLabel bankSafeItem63;
        private Controls.ItemLabel bankSafeItem64;
        private Controls.ItemLabel bankSafeItem65;
        private Controls.ItemLabel bankSafeItem66;
        private Controls.ItemLabel bankSafeItem67;
        private Controls.ItemLabel bankSafeItem68;
        private Controls.ItemLabel bankSafeItem69;
        private Controls.ItemLabel bankSafeItem70;
        private Controls.ItemLabel bankSafeItem71;
        private Controls.ItemLabel bankSafeItem72;
        private Controls.ItemLabel bankSafeItem73;
        private Controls.ItemLabel bankSafeItem74;
        private Controls.ItemLabel bankSafeItem75;
        private Controls.ItemLabel bankSafeItem76;
        private Controls.ItemLabel bankSafeItem77;
        private Controls.ItemLabel bankSafeItem78;
        private Controls.ItemLabel bankSafeItem79;
        private Controls.ItemLabel bankSafeItem00;
        private GroupBox groupBox8;
        private Label label26;
        private ComboBox cboBankSafeItemFilter;
        private Label label24;
        private ComboBox cboBankSafePrefix;
        private Label label25;
        private TextBox txtBankSafeFilter;
        private ListBox lstBankSafeItems;
        private Label label27;
        private TextBox txtBankSafeStackCount;
        private GroupBox groupBox9;
        private GroupBox groupBox10;
        private Button btnHackAllBankSafeStacks;
        private Button btnMaxAllBankSafeStacks;
        private Button btnDeleteAllSafeItems;
        private Button btnDeleteAllBankItems;
        private ToolStripComboBox tscboQuickSelect;
        private ToolStripMenuItem checkForUpdatesToolStripMenuItem;
        private Button btnLoadEquipmentSet;
        private Button btnSaveEquipmentSet;
        private Button btnLoadSafeItems;
        private Button btnSaveSafeItems;
        private Button btnLoadBankItems;
        private Button btnSaveBankItems;
        private GroupBox groupBox11;
        private Label label17;
        private TextBox txtInventoryStackCount;
        private Label label28;
        private ComboBox cboInventoryPrefixCategory;
        private Label label16;
        private ComboBox cboInventoryPrefix;
        private Button btnInventoryHackAllStacks;
        private Button btnInventoryDeleteAllItems;
        private Button btnInventoryMaxAllStacks;
        private Button btnInventoryDeleteItem;
        private Button btnLoadInventory;
        private Button btnSaveInventory;
        private GroupBox groupBox6;
        private ComboBox cboInvItemFilter;
        private Label label15;
        private TextBox txtInvItemFilter;
        private Label label14;
        private Label label29;
        private ComboBox cboEquipmentPrefixCategory;
        private Label label30;
        private ComboBox cboBankSafePrefixCategory;
        private Button btnSaveColorHair;
        private Button btnLoadColorHair;
        private Button btnLoadBuffs;
        private Button btnSaveBuffs;
        private CheckBox chkHideVisual;
        private Label label31;
        private Controls.ItemLabel equipmentItem18;
        private Controls.ItemLabel equipmentItem17;
        private Controls.ItemLabel equipmentItem16;
        private Controls.ItemLabel equipmentItem15;
        private Controls.ItemLabel equipmentItem14;
        private Controls.ItemLabel equipmentItem23;
        private Controls.ItemLabel equipmentItem22;
        private Controls.ItemLabel equipmentItem21;
        private Controls.ItemLabel equipmentItem20;
        private Controls.ItemLabel equipmentItem19;

    }
}

