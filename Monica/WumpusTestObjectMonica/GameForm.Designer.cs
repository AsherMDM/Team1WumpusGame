namespace WumpusTestObjectMonica
{
    partial class GameForm
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
            this.buttonShootArrows = new System.Windows.Forms.Button();
            this.buttonCave1 = new System.Windows.Forms.Button();
            this.buttonBuyArrows = new System.Windows.Forms.Button();
            this.buttonCave2 = new System.Windows.Forms.Button();
            this.buttonCave3 = new System.Windows.Forms.Button();
            this.labelCurrentCave = new System.Windows.Forms.Label();
            this.labelBatWarning = new System.Windows.Forms.Label();
            this.labelPitWarning = new System.Windows.Forms.Label();
            this.labelWumpusWarning = new System.Windows.Forms.Label();
            this.buttonWarnings = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // buttonShootArrows
            // 
            this.buttonShootArrows.Location = new System.Drawing.Point(12, 77);
            this.buttonShootArrows.Name = "buttonShootArrows";
            this.buttonShootArrows.Size = new System.Drawing.Size(163, 59);
            this.buttonShootArrows.TabIndex = 0;
            this.buttonShootArrows.Text = "Shoot Arrows";
            this.buttonShootArrows.UseVisualStyleBackColor = true;
            this.buttonShootArrows.Click += new System.EventHandler(this.buttonShootArrows_Click);
            // 
            // buttonCave1
            // 
            this.buttonCave1.Location = new System.Drawing.Point(291, 77);
            this.buttonCave1.Name = "buttonCave1";
            this.buttonCave1.Size = new System.Drawing.Size(76, 42);
            this.buttonCave1.TabIndex = 1;
            this.buttonCave1.Text = "1";
            this.buttonCave1.UseVisualStyleBackColor = true;
            this.buttonCave1.Click += new System.EventHandler(this.buttonCave1_Click);
            // 
            // buttonBuyArrows
            // 
            this.buttonBuyArrows.Location = new System.Drawing.Point(12, 12);
            this.buttonBuyArrows.Name = "buttonBuyArrows";
            this.buttonBuyArrows.Size = new System.Drawing.Size(163, 59);
            this.buttonBuyArrows.TabIndex = 2;
            this.buttonBuyArrows.Text = "Buy Arrows";
            this.buttonBuyArrows.UseVisualStyleBackColor = true;
            this.buttonBuyArrows.Click += new System.EventHandler(this.buttonBuyArrows_Click);
            // 
            // buttonCave2
            // 
            this.buttonCave2.Location = new System.Drawing.Point(390, 34);
            this.buttonCave2.Name = "buttonCave2";
            this.buttonCave2.Size = new System.Drawing.Size(76, 42);
            this.buttonCave2.TabIndex = 3;
            this.buttonCave2.Text = "Cave ___";
            this.buttonCave2.UseVisualStyleBackColor = true;
            this.buttonCave2.Click += new System.EventHandler(this.buttonCave2_Click);
            // 
            // buttonCave3
            // 
            this.buttonCave3.Location = new System.Drawing.Point(489, 77);
            this.buttonCave3.Name = "buttonCave3";
            this.buttonCave3.Size = new System.Drawing.Size(76, 42);
            this.buttonCave3.TabIndex = 4;
            this.buttonCave3.Text = "Cave ___";
            this.buttonCave3.UseVisualStyleBackColor = true;
            this.buttonCave3.Click += new System.EventHandler(this.buttonCave3_Click);
            // 
            // labelCurrentCave
            // 
            this.labelCurrentCave.AutoSize = true;
            this.labelCurrentCave.Location = new System.Drawing.Point(408, 109);
            this.labelCurrentCave.Name = "labelCurrentCave";
            this.labelCurrentCave.Size = new System.Drawing.Size(13, 13);
            this.labelCurrentCave.TabIndex = 5;
            this.labelCurrentCave.Text = "2";
            // 
            // labelBatWarning
            // 
            this.labelBatWarning.AutoSize = true;
            this.labelBatWarning.Location = new System.Drawing.Point(54, 190);
            this.labelBatWarning.Name = "labelBatWarning";
            this.labelBatWarning.Size = new System.Drawing.Size(85, 13);
            this.labelBatWarning.TabIndex = 6;
            this.labelBatWarning.Text = "I hear something";
            this.labelBatWarning.Visible = false;
            // 
            // labelPitWarning
            // 
            this.labelPitWarning.AutoSize = true;
            this.labelPitWarning.Location = new System.Drawing.Point(54, 218);
            this.labelPitWarning.Name = "labelPitWarning";
            this.labelPitWarning.Size = new System.Drawing.Size(63, 13);
            this.labelPitWarning.TabIndex = 7;
            this.labelPitWarning.Text = "I feel a draft";
            this.labelPitWarning.Visible = false;
            // 
            // labelWumpusWarning
            // 
            this.labelWumpusWarning.AutoSize = true;
            this.labelWumpusWarning.Location = new System.Drawing.Point(54, 244);
            this.labelWumpusWarning.Name = "labelWumpusWarning";
            this.labelWumpusWarning.Size = new System.Drawing.Size(90, 13);
            this.labelWumpusWarning.TabIndex = 8;
            this.labelWumpusWarning.Text = "I smell a Wumpus";
            this.labelWumpusWarning.Visible = false;
            // 
            // buttonWarnings
            // 
            this.buttonWarnings.Location = new System.Drawing.Point(41, 274);
            this.buttonWarnings.Name = "buttonWarnings";
            this.buttonWarnings.Size = new System.Drawing.Size(118, 24);
            this.buttonWarnings.TabIndex = 9;
            this.buttonWarnings.Text = "Get Warnings";
            this.buttonWarnings.UseVisualStyleBackColor = true;
            this.buttonWarnings.Click += new System.EventHandler(this.buttonWarnings_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 190);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(12, 218);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 11;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(12, 244);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(15, 14);
            this.checkBox3.TabIndex = 12;
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 322);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.buttonWarnings);
            this.Controls.Add(this.labelWumpusWarning);
            this.Controls.Add(this.labelPitWarning);
            this.Controls.Add(this.labelBatWarning);
            this.Controls.Add(this.labelCurrentCave);
            this.Controls.Add(this.buttonCave3);
            this.Controls.Add(this.buttonCave2);
            this.Controls.Add(this.buttonBuyArrows);
            this.Controls.Add(this.buttonCave1);
            this.Controls.Add(this.buttonShootArrows);
            this.Name = "GameForm";
            this.Text = "GameForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonShootArrows;
        private System.Windows.Forms.Button buttonCave1;
        private System.Windows.Forms.Button buttonBuyArrows;
        private System.Windows.Forms.Button buttonCave2;
        private System.Windows.Forms.Button buttonCave3;
        private System.Windows.Forms.Label labelCurrentCave;
        private System.Windows.Forms.Label labelBatWarning;
        private System.Windows.Forms.Label labelPitWarning;
        private System.Windows.Forms.Label labelWumpusWarning;
        private System.Windows.Forms.Button buttonWarnings;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
    }
}