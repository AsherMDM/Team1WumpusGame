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
            this.richTextBoxWarnings = new System.Windows.Forms.RichTextBox();
            this.labelWarnings = new System.Windows.Forms.Label();
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
            this.groupBoxObjects.SuspendLayout();
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
            this.groupBoxObjects.Location = new System.Drawing.Point(488, 507);
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
            this.outputInfoBox.Location = new System.Drawing.Point(71, 477);
            this.outputInfoBox.Name = "outputInfoBox";
            this.outputInfoBox.Size = new System.Drawing.Size(411, 124);
            this.outputInfoBox.TabIndex = 4;
            this.outputInfoBox.Text = "";
            this.outputInfoBox.TextChanged += new System.EventHandler(this.richTextBoxInfo_TextChanged);
            // 
            // richTextBoxWarnings
            // 
            this.richTextBoxWarnings.BackColor = System.Drawing.Color.White;
            this.richTextBoxWarnings.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.richTextBoxWarnings.Location = new System.Drawing.Point(23, 32);
            this.richTextBoxWarnings.Name = "richTextBoxWarnings";
            this.richTextBoxWarnings.ReadOnly = true;
            this.richTextBoxWarnings.Size = new System.Drawing.Size(154, 109);
            this.richTextBoxWarnings.TabIndex = 5;
            this.richTextBoxWarnings.Text = "";
            // 
            // labelWarnings
            // 
            this.labelWarnings.AutoSize = true;
            this.labelWarnings.Location = new System.Drawing.Point(20, 16);
            this.labelWarnings.Name = "labelWarnings";
            this.labelWarnings.Size = new System.Drawing.Size(52, 13);
            this.labelWarnings.TabIndex = 6;
            this.labelWarnings.Text = "Warnings";
            // 
            // buttonGetWarnings
            // 
            this.buttonGetWarnings.BackColor = System.Drawing.Color.White;
            this.buttonGetWarnings.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonGetWarnings.Location = new System.Drawing.Point(23, 147);
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
            this.textBoxNearbyCaves.Location = new System.Drawing.Point(197, 32);
            this.textBoxNearbyCaves.Name = "textBoxNearbyCaves";
            this.textBoxNearbyCaves.Size = new System.Drawing.Size(100, 20);
            this.textBoxNearbyCaves.TabIndex = 8;
            this.textBoxNearbyCaves.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(194, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nearby Caves";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(194, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "bat Locations";
            // 
            // textBoxBatLocs
            // 
            this.textBoxBatLocs.BackColor = System.Drawing.Color.White;
            this.textBoxBatLocs.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxBatLocs.Location = new System.Drawing.Point(197, 71);
            this.textBoxBatLocs.Name = "textBoxBatLocs";
            this.textBoxBatLocs.Size = new System.Drawing.Size(100, 20);
            this.textBoxBatLocs.TabIndex = 10;
            this.textBoxBatLocs.Text = "2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(194, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "pit locations";
            // 
            // textBoxPitLocs
            // 
            this.textBoxPitLocs.BackColor = System.Drawing.Color.White;
            this.textBoxPitLocs.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxPitLocs.Location = new System.Drawing.Point(197, 110);
            this.textBoxPitLocs.Name = "textBoxPitLocs";
            this.textBoxPitLocs.Size = new System.Drawing.Size(100, 20);
            this.textBoxPitLocs.TabIndex = 12;
            this.textBoxPitLocs.Text = "3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(194, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Wumpus location";
            // 
            // textBoxWumpusLoc
            // 
            this.textBoxWumpusLoc.BackColor = System.Drawing.Color.White;
            this.textBoxWumpusLoc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxWumpusLoc.Location = new System.Drawing.Point(197, 147);
            this.textBoxWumpusLoc.Name = "textBoxWumpusLoc";
            this.textBoxWumpusLoc.Size = new System.Drawing.Size(100, 20);
            this.textBoxWumpusLoc.TabIndex = 14;
            this.textBoxWumpusLoc.Text = "4";
            // 
            // buttonGetPlayerLocation
            // 
            this.buttonGetPlayerLocation.BackColor = System.Drawing.Color.White;
            this.buttonGetPlayerLocation.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonGetPlayerLocation.Location = new System.Drawing.Point(23, 227);
            this.buttonGetPlayerLocation.Name = "buttonGetPlayerLocation";
            this.buttonGetPlayerLocation.Size = new System.Drawing.Size(154, 38);
            this.buttonGetPlayerLocation.TabIndex = 16;
            this.buttonGetPlayerLocation.Text = "Get Player Location";
            this.buttonGetPlayerLocation.UseVisualStyleBackColor = false;
            this.buttonGetPlayerLocation.Click += new System.EventHandler(this.buttonGetPlayerLocation_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(194, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Player location";
            // 
            // textBoxPlayerLocationInput
            // 
            this.textBoxPlayerLocationInput.BackColor = System.Drawing.Color.White;
            this.textBoxPlayerLocationInput.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxPlayerLocationInput.Location = new System.Drawing.Point(197, 227);
            this.textBoxPlayerLocationInput.Name = "textBoxPlayerLocationInput";
            this.textBoxPlayerLocationInput.Size = new System.Drawing.Size(100, 20);
            this.textBoxPlayerLocationInput.TabIndex = 17;
            this.textBoxPlayerLocationInput.Text = "5";
            // 
            // textBoxPlayerCurrentLocation
            // 
            this.textBoxPlayerCurrentLocation.Location = new System.Drawing.Point(23, 271);
            this.textBoxPlayerCurrentLocation.Name = "textBoxPlayerCurrentLocation";
            this.textBoxPlayerCurrentLocation.ReadOnly = true;
            this.textBoxPlayerCurrentLocation.Size = new System.Drawing.Size(274, 20);
            this.textBoxPlayerCurrentLocation.TabIndex = 19;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxPlayerCurrentLocation);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxPlayerLocationInput);
            this.Controls.Add(this.buttonGetPlayerLocation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxWumpusLoc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPitLocs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxBatLocs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNearbyCaves);
            this.Controls.Add(this.buttonGetWarnings);
            this.Controls.Add(this.labelWarnings);
            this.Controls.Add(this.richTextBoxWarnings);
            this.Controls.Add(this.outputInfoBox);
            this.Controls.Add(this.groupBoxObjects);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "FormMain";
            this.Text = "Wumpus testing";
            this.groupBoxObjects.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCreateSelectedObject;
        private System.Windows.Forms.Button buttonCreateAllObjects;
        private System.Windows.Forms.ListBox listBoxObjects;
        private System.Windows.Forms.GroupBox groupBoxObjects;
        private System.Windows.Forms.RichTextBox outputInfoBox;
        private System.Windows.Forms.RichTextBox richTextBoxWarnings;
        private System.Windows.Forms.Label labelWarnings;
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
    }
}

