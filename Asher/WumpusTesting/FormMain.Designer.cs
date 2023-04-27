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
            this.buttonCreateAllObjects.BackColor = System.Drawing.Color.DimGray;
            this.buttonCreateAllObjects.Location = new System.Drawing.Point(6, 55);
            this.buttonCreateAllObjects.Name = "buttonCreateAllObjects";
            this.buttonCreateAllObjects.Size = new System.Drawing.Size(271, 30);
            this.buttonCreateAllObjects.TabIndex = 1;
            this.buttonCreateAllObjects.Text = "Create All Objects";
            this.buttonCreateAllObjects.UseVisualStyleBackColor = false;
            this.buttonCreateAllObjects.Click += new System.EventHandler(this.buttonCreateAllObjects_Click);
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
            this.groupBoxObjects.Location = new System.Drawing.Point(12, 12);
            this.groupBoxObjects.Name = "groupBoxObjects";
            this.groupBoxObjects.Size = new System.Drawing.Size(284, 94);
            this.groupBoxObjects.TabIndex = 3;
            this.groupBoxObjects.TabStop = false;
            this.groupBoxObjects.Text = "Objects";
            // 
            // outputInfoBox
            // 
            this.outputInfoBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.outputInfoBox.BackColor = System.Drawing.Color.DimGray;
            this.outputInfoBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputInfoBox.ForeColor = System.Drawing.Color.White;
            this.outputInfoBox.Location = new System.Drawing.Point(11, 314);
            this.outputInfoBox.Name = "outputInfoBox";
            this.outputInfoBox.Size = new System.Drawing.Size(411, 124);
            this.outputInfoBox.TabIndex = 4;
            this.outputInfoBox.Text = "";
            this.outputInfoBox.TextChanged += new System.EventHandler(this.richTextBoxInfo_TextChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.outputInfoBox);
            this.Controls.Add(this.groupBoxObjects);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "FormMain";
            this.Text = "Wumpus testing";
            this.groupBoxObjects.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCreateSelectedObject;
        private System.Windows.Forms.Button buttonCreateAllObjects;
        private System.Windows.Forms.ListBox listBoxObjects;
        private System.Windows.Forms.GroupBox groupBoxObjects;
        private System.Windows.Forms.RichTextBox outputInfoBox;
    }
}

