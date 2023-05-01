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
            this.buttonCave1.Text = "Cave ___";
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
            this.labelCurrentCave.Size = new System.Drawing.Size(32, 13);
            this.labelCurrentCave.TabIndex = 5;
            this.labelCurrentCave.Text = "Cave";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 322);
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
    }
}