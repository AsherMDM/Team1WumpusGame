namespace Team1WumpusGame
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxShootArrowLocation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBoxShootArrows = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxBuyArrows = new System.Windows.Forms.PictureBox();
            this.labelBatWarning = new System.Windows.Forms.Label();
            this.labelPitWarning = new System.Windows.Forms.Label();
            this.labelWumpusWarning = new System.Windows.Forms.Label();
            this.labelCoins = new System.Windows.Forms.Label();
            this.labelArrows = new System.Windows.Forms.Label();
            this.labelCurrentRoom = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelRoom1 = new System.Windows.Forms.Label();
            this.labelRoom2 = new System.Windows.Forms.Label();
            this.labelRoom3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBoxMoveRoom3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxMoveRoom2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxMoveRoom1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxGame = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShootArrows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBuyArrows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMoveRoom3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMoveRoom2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMoveRoom1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGame)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonExit);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxShootArrowLocation);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.pictureBoxShootArrows);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBoxBuyArrows);
            this.groupBox1.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(22, 22);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox1.Size = new System.Drawing.Size(262, 611);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu";
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonExit.Location = new System.Drawing.Point(33, 494);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(186, 86);
            this.buttonExit.TabIndex = 8;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 308);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Arrow Location";
            // 
            // textBoxShootArrowLocation
            // 
            this.textBoxShootArrowLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(78)))), ((int)(((byte)(91)))));
            this.textBoxShootArrowLocation.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxShootArrowLocation.Location = new System.Drawing.Point(34, 336);
            this.textBoxShootArrowLocation.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textBoxShootArrowLocation.Name = "textBoxShootArrowLocation";
            this.textBoxShootArrowLocation.Size = new System.Drawing.Size(180, 28);
            this.textBoxShootArrowLocation.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 179);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Shoot Arrows";
            // 
            // pictureBoxShootArrows
            // 
            this.pictureBoxShootArrows.Image = global::Team1WumpusGame.Properties.Resources.arrow3;
            this.pictureBoxShootArrows.Location = new System.Drawing.Point(34, 209);
            this.pictureBoxShootArrows.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.pictureBoxShootArrows.Name = "pictureBoxShootArrows";
            this.pictureBoxShootArrows.Size = new System.Drawing.Size(183, 92);
            this.pictureBoxShootArrows.TabIndex = 2;
            this.pictureBoxShootArrows.TabStop = false;
            this.pictureBoxShootArrows.Click += new System.EventHandler(this.pictureBoxShootArrows_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buy Arrows";
            // 
            // pictureBoxBuyArrows
            // 
            this.pictureBoxBuyArrows.Image = global::Team1WumpusGame.Properties.Resources.arrow2;
            this.pictureBoxBuyArrows.Location = new System.Drawing.Point(34, 66);
            this.pictureBoxBuyArrows.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.pictureBoxBuyArrows.Name = "pictureBoxBuyArrows";
            this.pictureBoxBuyArrows.Size = new System.Drawing.Size(183, 92);
            this.pictureBoxBuyArrows.TabIndex = 0;
            this.pictureBoxBuyArrows.TabStop = false;
            this.pictureBoxBuyArrows.Click += new System.EventHandler(this.pictureBoxBuyArrows_Click);
            // 
            // labelBatWarning
            // 
            this.labelBatWarning.AutoSize = true;
            this.labelBatWarning.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBatWarning.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelBatWarning.Location = new System.Drawing.Point(320, 474);
            this.labelBatWarning.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelBatWarning.Name = "labelBatWarning";
            this.labelBatWarning.Size = new System.Drawing.Size(202, 23);
            this.labelBatWarning.TabIndex = 11;
            this.labelBatWarning.Text = "I hear something";
            // 
            // labelPitWarning
            // 
            this.labelPitWarning.AutoSize = true;
            this.labelPitWarning.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPitWarning.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelPitWarning.Location = new System.Drawing.Point(320, 526);
            this.labelPitWarning.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelPitWarning.Name = "labelPitWarning";
            this.labelPitWarning.Size = new System.Drawing.Size(178, 23);
            this.labelPitWarning.TabIndex = 12;
            this.labelPitWarning.Text = "I feel a draft";
            // 
            // labelWumpusWarning
            // 
            this.labelWumpusWarning.AutoSize = true;
            this.labelWumpusWarning.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWumpusWarning.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelWumpusWarning.Location = new System.Drawing.Point(320, 580);
            this.labelWumpusWarning.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelWumpusWarning.Name = "labelWumpusWarning";
            this.labelWumpusWarning.Size = new System.Drawing.Size(202, 23);
            this.labelWumpusWarning.TabIndex = 13;
            this.labelWumpusWarning.Text = "I smell a wumpus";
            // 
            // labelCoins
            // 
            this.labelCoins.AutoSize = true;
            this.labelCoins.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCoins.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelCoins.Location = new System.Drawing.Point(1023, 432);
            this.labelCoins.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelCoins.Name = "labelCoins";
            this.labelCoins.Size = new System.Drawing.Size(22, 23);
            this.labelCoins.TabIndex = 14;
            this.labelCoins.Text = "0";
            // 
            // labelArrows
            // 
            this.labelArrows.AutoSize = true;
            this.labelArrows.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelArrows.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelArrows.Location = new System.Drawing.Point(1023, 479);
            this.labelArrows.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelArrows.Name = "labelArrows";
            this.labelArrows.Size = new System.Drawing.Size(22, 23);
            this.labelArrows.TabIndex = 15;
            this.labelArrows.Text = "0";
            // 
            // labelCurrentRoom
            // 
            this.labelCurrentRoom.AutoSize = true;
            this.labelCurrentRoom.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentRoom.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelCurrentRoom.Location = new System.Drawing.Point(408, 432);
            this.labelCurrentRoom.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelCurrentRoom.Name = "labelCurrentRoom";
            this.labelCurrentRoom.Size = new System.Drawing.Size(22, 23);
            this.labelCurrentRoom.TabIndex = 16;
            this.labelCurrentRoom.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(320, 432);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 23);
            this.label5.TabIndex = 18;
            this.label5.Text = "Room ";
            // 
            // labelRoom1
            // 
            this.labelRoom1.AutoSize = true;
            this.labelRoom1.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRoom1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelRoom1.Location = new System.Drawing.Point(831, 138);
            this.labelRoom1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelRoom1.Name = "labelRoom1";
            this.labelRoom1.Size = new System.Drawing.Size(22, 23);
            this.labelRoom1.TabIndex = 21;
            this.labelRoom1.Text = "1";
            // 
            // labelRoom2
            // 
            this.labelRoom2.AutoSize = true;
            this.labelRoom2.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRoom2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelRoom2.Location = new System.Drawing.Point(970, 28);
            this.labelRoom2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelRoom2.Name = "labelRoom2";
            this.labelRoom2.Size = new System.Drawing.Size(22, 23);
            this.labelRoom2.TabIndex = 22;
            this.labelRoom2.Text = "1";
            // 
            // labelRoom3
            // 
            this.labelRoom3.AutoSize = true;
            this.labelRoom3.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRoom3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelRoom3.Location = new System.Drawing.Point(1120, 138);
            this.labelRoom3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelRoom3.Name = "labelRoom3";
            this.labelRoom3.Size = new System.Drawing.Size(22, 23);
            this.labelRoom3.TabIndex = 23;
            this.labelRoom3.Text = "1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(922, 432);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 23);
            this.label7.TabIndex = 24;
            this.label7.Text = "Coins";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(922, 479);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 23);
            this.label8.TabIndex = 25;
            this.label8.Text = "Arrows";
            // 
            // pictureBoxMoveRoom3
            // 
            this.pictureBoxMoveRoom3.Image = global::Team1WumpusGame.Properties.Resources.rightarrow;
            this.pictureBoxMoveRoom3.Location = new System.Drawing.Point(1054, 168);
            this.pictureBoxMoveRoom3.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.pictureBoxMoveRoom3.Name = "pictureBoxMoveRoom3";
            this.pictureBoxMoveRoom3.Size = new System.Drawing.Size(110, 107);
            this.pictureBoxMoveRoom3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMoveRoom3.TabIndex = 9;
            this.pictureBoxMoveRoom3.TabStop = false;
            this.pictureBoxMoveRoom3.Click += new System.EventHandler(this.pictureBoxMoveRoom3_Click);
            // 
            // pictureBoxMoveRoom2
            // 
            this.pictureBoxMoveRoom2.Image = global::Team1WumpusGame.Properties.Resources.uparrow;
            this.pictureBoxMoveRoom2.Location = new System.Drawing.Point(934, 58);
            this.pictureBoxMoveRoom2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.pictureBoxMoveRoom2.Name = "pictureBoxMoveRoom2";
            this.pictureBoxMoveRoom2.Size = new System.Drawing.Size(110, 107);
            this.pictureBoxMoveRoom2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMoveRoom2.TabIndex = 8;
            this.pictureBoxMoveRoom2.TabStop = false;
            this.pictureBoxMoveRoom2.Click += new System.EventHandler(this.pictureBoxMoveRoom2_Click);
            // 
            // pictureBoxMoveRoom1
            // 
            this.pictureBoxMoveRoom1.Image = global::Team1WumpusGame.Properties.Resources.leftarrow;
            this.pictureBoxMoveRoom1.Location = new System.Drawing.Point(810, 168);
            this.pictureBoxMoveRoom1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.pictureBoxMoveRoom1.Name = "pictureBoxMoveRoom1";
            this.pictureBoxMoveRoom1.Size = new System.Drawing.Size(110, 107);
            this.pictureBoxMoveRoom1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMoveRoom1.TabIndex = 7;
            this.pictureBoxMoveRoom1.TabStop = false;
            this.pictureBoxMoveRoom1.Click += new System.EventHandler(this.pictureBoxMoveRoom1_Click);
            // 
            // pictureBoxGame
            // 
            this.pictureBoxGame.Image = global::Team1WumpusGame.Properties.Resources.emptycave3;
            this.pictureBoxGame.Location = new System.Drawing.Point(326, 58);
            this.pictureBoxGame.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.pictureBoxGame.Name = "pictureBoxGame";
            this.pictureBoxGame.Size = new System.Drawing.Size(384, 353);
            this.pictureBoxGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGame.TabIndex = 6;
            this.pictureBoxGame.TabStop = false;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(78)))), ((int)(((byte)(91)))));
            this.CancelButton = this.buttonExit;
            this.ClientSize = new System.Drawing.Size(1242, 652);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelRoom3);
            this.Controls.Add(this.labelRoom2);
            this.Controls.Add(this.labelRoom1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelCurrentRoom);
            this.Controls.Add(this.labelArrows);
            this.Controls.Add(this.labelCoins);
            this.Controls.Add(this.labelWumpusWarning);
            this.Controls.Add(this.labelPitWarning);
            this.Controls.Add(this.labelBatWarning);
            this.Controls.Add(this.pictureBoxMoveRoom3);
            this.Controls.Add(this.pictureBoxMoveRoom2);
            this.Controls.Add(this.pictureBoxMoveRoom1);
            this.Controls.Add(this.pictureBoxGame);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hunt The Wumpus";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShootArrows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBuyArrows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMoveRoom3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMoveRoom2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMoveRoom1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGame)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxShootArrowLocation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBoxShootArrows;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxBuyArrows;
        private System.Windows.Forms.PictureBox pictureBoxGame;
        private System.Windows.Forms.PictureBox pictureBoxMoveRoom1;
        private System.Windows.Forms.PictureBox pictureBoxMoveRoom2;
        private System.Windows.Forms.PictureBox pictureBoxMoveRoom3;
        private System.Windows.Forms.Label labelBatWarning;
        private System.Windows.Forms.Label labelPitWarning;
        private System.Windows.Forms.Label labelWumpusWarning;
        private System.Windows.Forms.Label labelCoins;
        private System.Windows.Forms.Label labelArrows;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelCurrentRoom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelRoom1;
        private System.Windows.Forms.Label labelRoom2;
        private System.Windows.Forms.Label labelRoom3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonExit;
    }
}