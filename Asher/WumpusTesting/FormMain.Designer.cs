namespace WumpusTesting
{
    partial class FormMain
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
            this.buttonCreateSelectedObject = new System.Windows.Forms.Button();
            this.buttonCreateAllObjects = new System.Windows.Forms.Button();
            this.listBoxObjects = new System.Windows.Forms.ListBox();
            this.groupBoxObjects = new System.Windows.Forms.GroupBox();
            this.outputInfoBox = new System.Windows.Forms.RichTextBox();
            this.buttonGetWarnings = new System.Windows.Forms.Button();
            this.textBoxNearbyCaves = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxBatLocs = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPitLocs = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxWumpusLoc = new System.Windows.Forms.TextBox();
            this.buttonGetPlayerLocation = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPlayerLocationInput = new System.Windows.Forms.TextBox();
            this.textBoxPlayerCurrentLocation = new System.Windows.Forms.TextBox();
            this.labelWumpus = new System.Windows.Forms.Label();
            this.labelBats = new System.Windows.Forms.Label();
            this.labelPits = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonMovePlayer = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxInvModifyAmount = new System.Windows.Forms.TextBox();
            this.buttonUpdateCoins = new System.Windows.Forms.Button();
            this.buttonUpdateArrows = new System.Windows.Forms.Button();
            this.buttonGetInventory = new System.Windows.Forms.Button();
            this.textBoxCoins = new System.Windows.Forms.TextBox();
            this.textBoxArrows = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonShootArrow = new System.Windows.Forms.Button();
            this.textBoxArrowShotOutcome = new System.Windows.Forms.TextBox();
            this.textBoxArrowShotLoc = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.buttonGeneratePitsLoc = new System.Windows.Forms.Button();
            this.buttonGenerateBatsLocs = new System.Windows.Forms.Button();
            this.buttonGenerateWumpusLoc = new System.Windows.Forms.Button();
            this.groupBoxObjects.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCreateSelectedObject
            // 
            this.buttonCreateSelectedObject.BackColor = System.Drawing.Color.DimGray;
            this.buttonCreateSelectedObject.Location = new System.Drawing.Point(6, 19);
            this.buttonCreateSelectedObject.Name = "buttonCreateSelectedObject";
            this.buttonCreateSelectedObject.Size = new System.Drawing.Size(145, 30);
            this.buttonCreateSelectedObject.TabIndex = 0;
            this.buttonCreateSelectedObject.Text = "Create Selected Object";
            this.buttonCreateSelectedObject.UseVisualStyleBackColor = false;
            this.buttonCreateSelectedObject.Click += new System.EventHandler(this.buttonCreateSelectedObject_Click);
            // 
            // buttonCreateAllObjects
            // 
            this.buttonCreateAllObjects.BackColor = System.Drawing.Color.White;
            this.buttonCreateAllObjects.Location = new System.Drawing.Point(6, 55);
            this.buttonCreateAllObjects.Name = "buttonCreateAllObjects";
            this.buttonCreateAllObjects.Size = new System.Drawing.Size(271, 30);
            this.buttonCreateAllObjects.TabIndex = 1;
            this.buttonCreateAllObjects.Text = "Create All Objects";
            this.buttonCreateAllObjects.UseVisualStyleBackColor = false;
            // 
            // listBoxObjects
            // 
            this.listBoxObjects.BackColor = System.Drawing.Color.DimGray;
            this.listBoxObjects.ForeColor = System.Drawing.Color.White;
            this.listBoxObjects.FormattingEnabled = true;
            this.listBoxObjects.Items.AddRange(new object[] {
            "Player",
            "GameLocations"});
            this.listBoxObjects.Location = new System.Drawing.Point(157, 19);
            this.listBoxObjects.Name = "listBoxObjects";
            this.listBoxObjects.Size = new System.Drawing.Size(120, 30);
            this.listBoxObjects.TabIndex = 2;
            // 
            // groupBoxObjects
            // 
            this.groupBoxObjects.Controls.Add(this.buttonCreateSelectedObject);
            this.groupBoxObjects.Controls.Add(this.listBoxObjects);
            this.groupBoxObjects.Controls.Add(this.buttonCreateAllObjects);
            this.groupBoxObjects.Location = new System.Drawing.Point(1250, -51);
            this.groupBoxObjects.Name = "groupBoxObjects";
            this.groupBoxObjects.Size = new System.Drawing.Size(284, 94);
            this.groupBoxObjects.TabIndex = 3;
            this.groupBoxObjects.TabStop = false;
            this.groupBoxObjects.Text = "Objects";
            this.groupBoxObjects.Visible = false;
            // 
            // outputInfoBox
            // 
            this.outputInfoBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.outputInfoBox.BackColor = System.Drawing.Color.DimGray;
            this.outputInfoBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputInfoBox.ForeColor = System.Drawing.Color.White;
            this.outputInfoBox.Location = new System.Drawing.Point(71, 700);
            this.outputInfoBox.Name = "outputInfoBox";
            this.outputInfoBox.Size = new System.Drawing.Size(411, 124);
            this.outputInfoBox.TabIndex = 4;
            this.outputInfoBox.Text = "";
            this.outputInfoBox.TextChanged += new System.EventHandler(this.richTextBoxInfo_TextChanged);
            // 
            // buttonGetWarnings
            // 
            this.buttonGetWarnings.BackColor = System.Drawing.Color.White;
            this.buttonGetWarnings.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonGetWarnings.Location = new System.Drawing.Point(234, 107);
            this.buttonGetWarnings.Name = "buttonGetWarnings";
            this.buttonGetWarnings.Size = new System.Drawing.Size(154, 38);
            this.buttonGetWarnings.TabIndex = 7;
            this.buttonGetWarnings.Text = "Get Warnings";
            this.buttonGetWarnings.UseVisualStyleBackColor = false;
            this.buttonGetWarnings.Click += new System.EventHandler(this.buttonGetWarnings_Click);
            // 
            // textBoxNearbyCaves
            // 
            this.textBoxNearbyCaves.BackColor = System.Drawing.Color.White;
            this.textBoxNearbyCaves.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxNearbyCaves.Location = new System.Drawing.Point(108, 19);
            this.textBoxNearbyCaves.Name = "textBoxNearbyCaves";
            this.textBoxNearbyCaves.Size = new System.Drawing.Size(100, 20);
            this.textBoxNearbyCaves.TabIndex = 8;
            this.textBoxNearbyCaves.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nearby Caves";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(13, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "bat Locations";
            // 
            // textBoxBatLocs
            // 
            this.textBoxBatLocs.BackColor = System.Drawing.Color.White;
            this.textBoxBatLocs.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxBatLocs.Location = new System.Drawing.Point(108, 58);
            this.textBoxBatLocs.Name = "textBoxBatLocs";
            this.textBoxBatLocs.Size = new System.Drawing.Size(100, 20);
            this.textBoxBatLocs.TabIndex = 10;
            this.textBoxBatLocs.Text = "2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(13, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "pit locations";
            // 
            // textBoxPitLocs
            // 
            this.textBoxPitLocs.BackColor = System.Drawing.Color.White;
            this.textBoxPitLocs.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxPitLocs.Location = new System.Drawing.Point(108, 97);
            this.textBoxPitLocs.Name = "textBoxPitLocs";
            this.textBoxPitLocs.Size = new System.Drawing.Size(100, 20);
            this.textBoxPitLocs.TabIndex = 12;
            this.textBoxPitLocs.Text = "3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(13, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Wumpus location";
            // 
            // textBoxWumpusLoc
            // 
            this.textBoxWumpusLoc.BackColor = System.Drawing.Color.White;
            this.textBoxWumpusLoc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxWumpusLoc.Location = new System.Drawing.Point(108, 134);
            this.textBoxWumpusLoc.Name = "textBoxWumpusLoc";
            this.textBoxWumpusLoc.Size = new System.Drawing.Size(100, 20);
            this.textBoxWumpusLoc.TabIndex = 14;
            this.textBoxWumpusLoc.Text = "4";
            // 
            // buttonGetPlayerLocation
            // 
            this.buttonGetPlayerLocation.BackColor = System.Drawing.Color.White;
            this.buttonGetPlayerLocation.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonGetPlayerLocation.Location = new System.Drawing.Point(15, 19);
            this.buttonGetPlayerLocation.Name = "buttonGetPlayerLocation";
            this.buttonGetPlayerLocation.Size = new System.Drawing.Size(114, 33);
            this.buttonGetPlayerLocation.TabIndex = 16;
            this.buttonGetPlayerLocation.Text = "Get Player Location";
            this.buttonGetPlayerLocation.UseVisualStyleBackColor = false;
            this.buttonGetPlayerLocation.Click += new System.EventHandler(this.buttonGetPlayerLocation_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(135, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Player location";
            // 
            // textBoxPlayerLocationInput
            // 
            this.textBoxPlayerLocationInput.BackColor = System.Drawing.Color.White;
            this.textBoxPlayerLocationInput.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxPlayerLocationInput.Location = new System.Drawing.Point(138, 77);
            this.textBoxPlayerLocationInput.Name = "textBoxPlayerLocationInput";
            this.textBoxPlayerLocationInput.Size = new System.Drawing.Size(114, 20);
            this.textBoxPlayerLocationInput.TabIndex = 17;
            this.textBoxPlayerLocationInput.Text = "5";
            // 
            // textBoxPlayerCurrentLocation
            // 
            this.textBoxPlayerCurrentLocation.Location = new System.Drawing.Point(138, 32);
            this.textBoxPlayerCurrentLocation.Name = "textBoxPlayerCurrentLocation";
            this.textBoxPlayerCurrentLocation.ReadOnly = true;
            this.textBoxPlayerCurrentLocation.Size = new System.Drawing.Size(114, 20);
            this.textBoxPlayerCurrentLocation.TabIndex = 19;
            this.textBoxPlayerCurrentLocation.Text = "1";
            // 
            // labelWumpus
            // 
            this.labelWumpus.AutoSize = true;
            this.labelWumpus.ForeColor = System.Drawing.Color.Black;
            this.labelWumpus.Location = new System.Drawing.Point(246, 26);
            this.labelWumpus.Name = "labelWumpus";
            this.labelWumpus.Size = new System.Drawing.Size(86, 13);
            this.labelWumpus.TabIndex = 20;
            this.labelWumpus.Text = "Wumpus Nearby";
            // 
            // labelBats
            // 
            this.labelBats.AutoSize = true;
            this.labelBats.ForeColor = System.Drawing.Color.Black;
            this.labelBats.Location = new System.Drawing.Point(246, 53);
            this.labelBats.Name = "labelBats";
            this.labelBats.Size = new System.Drawing.Size(65, 13);
            this.labelBats.TabIndex = 21;
            this.labelBats.Text = "Bats Nearby";
            // 
            // labelPits
            // 
            this.labelPits.AutoSize = true;
            this.labelPits.ForeColor = System.Drawing.Color.Black;
            this.labelPits.Location = new System.Drawing.Point(246, 80);
            this.labelPits.Name = "labelPits";
            this.labelPits.Size = new System.Drawing.Size(61, 13);
            this.labelPits.TabIndex = 23;
            this.labelPits.Text = "Pits Nearby";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonGetWarnings);
            this.groupBox1.Controls.Add(this.labelPits);
            this.groupBox1.Controls.Add(this.textBoxNearbyCaves);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.labelBats);
            this.groupBox1.Controls.Add(this.textBoxBatLocs);
            this.groupBox1.Controls.Add(this.labelWumpus);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxPitLocs);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxWumpusLoc);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(23, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(407, 167);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Warnings";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.buttonMovePlayer);
            this.groupBox2.Controls.Add(this.buttonGetPlayerLocation);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBoxPlayerLocationInput);
            this.groupBox2.Controls.Add(this.textBoxPlayerCurrentLocation);
            this.groupBox2.Location = new System.Drawing.Point(23, 185);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(264, 111);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Player Location";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(135, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Move to...";
            // 
            // buttonMovePlayer
            // 
            this.buttonMovePlayer.Location = new System.Drawing.Point(15, 61);
            this.buttonMovePlayer.Name = "buttonMovePlayer";
            this.buttonMovePlayer.Size = new System.Drawing.Size(114, 36);
            this.buttonMovePlayer.TabIndex = 28;
            this.buttonMovePlayer.Text = "Move Player";
            this.buttonMovePlayer.UseVisualStyleBackColor = true;
            this.buttonMovePlayer.Click += new System.EventHandler(this.buttonMovePlayer_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxInvModifyAmount);
            this.groupBox3.Controls.Add(this.buttonUpdateCoins);
            this.groupBox3.Controls.Add(this.buttonUpdateArrows);
            this.groupBox3.Controls.Add(this.buttonGetInventory);
            this.groupBox3.Controls.Add(this.textBoxCoins);
            this.groupBox3.Controls.Add(this.textBoxArrows);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(23, 302);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(348, 133);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Inventory";
            // 
            // textBoxInvModifyAmount
            // 
            this.textBoxInvModifyAmount.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxInvModifyAmount.Location = new System.Drawing.Point(176, 85);
            this.textBoxInvModifyAmount.Name = "textBoxInvModifyAmount";
            this.textBoxInvModifyAmount.Size = new System.Drawing.Size(142, 20);
            this.textBoxInvModifyAmount.TabIndex = 7;
            this.textBoxInvModifyAmount.Text = "How much to change it...";
            this.textBoxInvModifyAmount.Click += new System.EventHandler(this.textBoxInvModifyAmount_Click);
            // 
            // buttonUpdateCoins
            // 
            this.buttonUpdateCoins.Location = new System.Drawing.Point(176, 54);
            this.buttonUpdateCoins.Name = "buttonUpdateCoins";
            this.buttonUpdateCoins.Size = new System.Drawing.Size(142, 23);
            this.buttonUpdateCoins.TabIndex = 6;
            this.buttonUpdateCoins.Text = "Update Coins";
            this.buttonUpdateCoins.UseVisualStyleBackColor = true;
            this.buttonUpdateCoins.Click += new System.EventHandler(this.buttonUpdateCoins_Click);
            // 
            // buttonUpdateArrows
            // 
            this.buttonUpdateArrows.Location = new System.Drawing.Point(176, 28);
            this.buttonUpdateArrows.Name = "buttonUpdateArrows";
            this.buttonUpdateArrows.Size = new System.Drawing.Size(142, 23);
            this.buttonUpdateArrows.TabIndex = 5;
            this.buttonUpdateArrows.Text = "Update Arrows";
            this.buttonUpdateArrows.UseVisualStyleBackColor = true;
            this.buttonUpdateArrows.Click += new System.EventHandler(this.buttonUpdateArrows_Click);
            // 
            // buttonGetInventory
            // 
            this.buttonGetInventory.Location = new System.Drawing.Point(28, 82);
            this.buttonGetInventory.Name = "buttonGetInventory";
            this.buttonGetInventory.Size = new System.Drawing.Size(142, 23);
            this.buttonGetInventory.TabIndex = 4;
            this.buttonGetInventory.Text = "Get Inventory";
            this.buttonGetInventory.UseVisualStyleBackColor = true;
            this.buttonGetInventory.Click += new System.EventHandler(this.buttonGetInventory_Click);
            // 
            // textBoxCoins
            // 
            this.textBoxCoins.Location = new System.Drawing.Point(70, 56);
            this.textBoxCoins.Name = "textBoxCoins";
            this.textBoxCoins.ReadOnly = true;
            this.textBoxCoins.Size = new System.Drawing.Size(100, 20);
            this.textBoxCoins.TabIndex = 3;
            // 
            // textBoxArrows
            // 
            this.textBoxArrows.Location = new System.Drawing.Point(70, 30);
            this.textBoxArrows.Name = "textBoxArrows";
            this.textBoxArrows.ReadOnly = true;
            this.textBoxArrows.Size = new System.Drawing.Size(100, 20);
            this.textBoxArrows.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Coins";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Arrows";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(1276, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(223, 25);
            this.label8.TabIndex = 27;
            this.label8.Text = "DOES NOT WORK ^";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonShootArrow);
            this.groupBox4.Controls.Add(this.textBoxArrowShotOutcome);
            this.groupBox4.Controls.Add(this.textBoxArrowShotLoc);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Location = new System.Drawing.Point(436, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(242, 93);
            this.groupBox4.TabIndex = 28;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Shoot Arrow";
            // 
            // buttonShootArrow
            // 
            this.buttonShootArrow.Location = new System.Drawing.Point(130, 48);
            this.buttonShootArrow.Name = "buttonShootArrow";
            this.buttonShootArrow.Size = new System.Drawing.Size(100, 23);
            this.buttonShootArrow.TabIndex = 3;
            this.buttonShootArrow.Text = "Shoot Arrow";
            this.buttonShootArrow.UseVisualStyleBackColor = true;
            this.buttonShootArrow.Click += new System.EventHandler(this.buttonShootArrow_Click);
            // 
            // textBoxArrowShotOutcome
            // 
            this.textBoxArrowShotOutcome.Location = new System.Drawing.Point(14, 51);
            this.textBoxArrowShotOutcome.Name = "textBoxArrowShotOutcome";
            this.textBoxArrowShotOutcome.ReadOnly = true;
            this.textBoxArrowShotOutcome.Size = new System.Drawing.Size(100, 20);
            this.textBoxArrowShotOutcome.TabIndex = 2;
            this.textBoxArrowShotOutcome.Text = "Hit or Missed";
            // 
            // textBoxArrowShotLoc
            // 
            this.textBoxArrowShotLoc.Location = new System.Drawing.Point(130, 24);
            this.textBoxArrowShotLoc.Name = "textBoxArrowShotLoc";
            this.textBoxArrowShotLoc.Size = new System.Drawing.Size(100, 20);
            this.textBoxArrowShotLoc.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Cave to shoot arrow in";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.buttonGeneratePitsLoc);
            this.groupBox5.Controls.Add(this.buttonGenerateBatsLocs);
            this.groupBox5.Controls.Add(this.buttonGenerateWumpusLoc);
            this.groupBox5.Location = new System.Drawing.Point(297, 185);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(133, 114);
            this.groupBox5.TabIndex = 29;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Generate Locations";
            // 
            // buttonGeneratePitsLoc
            // 
            this.buttonGeneratePitsLoc.Location = new System.Drawing.Point(19, 78);
            this.buttonGeneratePitsLoc.Name = "buttonGeneratePitsLoc";
            this.buttonGeneratePitsLoc.Size = new System.Drawing.Size(95, 23);
            this.buttonGeneratePitsLoc.TabIndex = 33;
            this.buttonGeneratePitsLoc.Text = "Pits";
            this.buttonGeneratePitsLoc.UseVisualStyleBackColor = true;
            this.buttonGeneratePitsLoc.Click += new System.EventHandler(this.buttonGeneratePitsLoc_Click);
            // 
            // buttonGenerateBatsLocs
            // 
            this.buttonGenerateBatsLocs.Location = new System.Drawing.Point(19, 49);
            this.buttonGenerateBatsLocs.Name = "buttonGenerateBatsLocs";
            this.buttonGenerateBatsLocs.Size = new System.Drawing.Size(95, 23);
            this.buttonGenerateBatsLocs.TabIndex = 32;
            this.buttonGenerateBatsLocs.Text = "Bats";
            this.buttonGenerateBatsLocs.UseVisualStyleBackColor = true;
            this.buttonGenerateBatsLocs.Click += new System.EventHandler(this.buttonGenerateBatsLocs_Click);
            // 
            // buttonGenerateWumpusLoc
            // 
            this.buttonGenerateWumpusLoc.Location = new System.Drawing.Point(19, 20);
            this.buttonGenerateWumpusLoc.Name = "buttonGenerateWumpusLoc";
            this.buttonGenerateWumpusLoc.Size = new System.Drawing.Size(95, 23);
            this.buttonGenerateWumpusLoc.TabIndex = 31;
            this.buttonGenerateWumpusLoc.Text = "Wumpus";
            this.buttonGenerateWumpusLoc.UseVisualStyleBackColor = true;
            this.buttonGenerateWumpusLoc.Click += new System.EventHandler(this.buttonGenerateWumpusLoc_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1235, 673);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.outputInfoBox);
            this.Controls.Add(this.groupBoxObjects);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FormMain";
            this.Text = "Wumpus testing";
            this.groupBoxObjects.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCreateSelectedObject;
        private System.Windows.Forms.Button buttonCreateAllObjects;
        private System.Windows.Forms.ListBox listBoxObjects;
        private System.Windows.Forms.GroupBox groupBoxObjects;
        private System.Windows.Forms.RichTextBox outputInfoBox;
        private System.Windows.Forms.Button buttonGetWarnings;
        private System.Windows.Forms.TextBox textBoxNearbyCaves;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxBatLocs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPitLocs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxWumpusLoc;
        private System.Windows.Forms.Button buttonGetPlayerLocation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxPlayerLocationInput;
        private System.Windows.Forms.TextBox textBoxPlayerCurrentLocation;
        private System.Windows.Forms.Label labelWumpus;
        private System.Windows.Forms.Label labelBats;
        private System.Windows.Forms.Label labelPits;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonUpdateArrows;
        private System.Windows.Forms.Button buttonGetInventory;
        private System.Windows.Forms.TextBox textBoxCoins;
        private System.Windows.Forms.TextBox textBoxArrows;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxInvModifyAmount;
        private System.Windows.Forms.Button buttonUpdateCoins;
        private System.Windows.Forms.Button buttonMovePlayer;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonShootArrow;
        private System.Windows.Forms.TextBox textBoxArrowShotOutcome;
        private System.Windows.Forms.TextBox textBoxArrowShotLoc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button buttonGenerateWumpusLoc;
        private System.Windows.Forms.Button buttonGenerateBatsLocs;
        private System.Windows.Forms.Button buttonGeneratePitsLoc;
    }
}

