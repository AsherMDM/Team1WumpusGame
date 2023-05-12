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
            this.pictureBoxBuyArrows = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBoxShootArrows = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBoxExit = new System.Windows.Forms.PictureBox();
            this.pictureBoxGame = new System.Windows.Forms.PictureBox();
            this.pictureBoxMoveRoom1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxMoveRoom2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxMoveRoom3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxPlayer = new System.Windows.Forms.PictureBox();
            this.labelBatWarning = new System.Windows.Forms.Label();
            this.labelPitWarning = new System.Windows.Forms.Label();
            this.textBoxShootArrowLocation = new System.Windows.Forms.TextBox();
            this.labelWumpusWarning = new System.Windows.Forms.Label();
            this.labelCoins = new System.Windows.Forms.Label();
            this.labelArrows = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBuyArrows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShootArrows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMoveRoom1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMoveRoom2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMoveRoom3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxShootArrowLocation);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.pictureBoxExit);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.pictureBoxShootArrows);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBoxBuyArrows);
            this.groupBox1.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(143, 331);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu";
            // 
            // pictureBoxBuyArrows
            // 
            this.pictureBoxBuyArrows.Location = new System.Drawing.Point(19, 36);
            this.pictureBoxBuyArrows.Name = "pictureBoxBuyArrows";
            this.pictureBoxBuyArrows.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxBuyArrows.TabIndex = 0;
            this.pictureBoxBuyArrows.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buy Arrows";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Shoot Arrows";
            // 
            // pictureBoxShootArrows
            // 
            this.pictureBoxShootArrows.Location = new System.Drawing.Point(19, 113);
            this.pictureBoxShootArrows.Name = "pictureBoxShootArrows";
            this.pictureBoxShootArrows.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxShootArrows.TabIndex = 2;
            this.pictureBoxShootArrows.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "Exit";
            // 
            // pictureBoxExit
            // 
            this.pictureBoxExit.Location = new System.Drawing.Point(19, 265);
            this.pictureBoxExit.Name = "pictureBoxExit";
            this.pictureBoxExit.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxExit.TabIndex = 4;
            this.pictureBoxExit.TabStop = false;
            this.pictureBoxExit.Click += new System.EventHandler(this.pictureBoxExit_Click);
            // 
            // pictureBoxGame
            // 
            this.pictureBoxGame.Location = new System.Drawing.Point(178, 31);
            this.pictureBoxGame.Name = "pictureBoxGame";
            this.pictureBoxGame.Size = new System.Drawing.Size(209, 191);
            this.pictureBoxGame.TabIndex = 6;
            this.pictureBoxGame.TabStop = false;
            // 
            // pictureBoxMoveRoom1
            // 
            this.pictureBoxMoveRoom1.Location = new System.Drawing.Point(442, 91);
            this.pictureBoxMoveRoom1.Name = "pictureBoxMoveRoom1";
            this.pictureBoxMoveRoom1.Size = new System.Drawing.Size(60, 58);
            this.pictureBoxMoveRoom1.TabIndex = 7;
            this.pictureBoxMoveRoom1.TabStop = false;
            // 
            // pictureBoxMoveRoom2
            // 
            this.pictureBoxMoveRoom2.Location = new System.Drawing.Point(509, 31);
            this.pictureBoxMoveRoom2.Name = "pictureBoxMoveRoom2";
            this.pictureBoxMoveRoom2.Size = new System.Drawing.Size(60, 58);
            this.pictureBoxMoveRoom2.TabIndex = 8;
            this.pictureBoxMoveRoom2.TabStop = false;
            // 
            // pictureBoxMoveRoom3
            // 
            this.pictureBoxMoveRoom3.Location = new System.Drawing.Point(575, 91);
            this.pictureBoxMoveRoom3.Name = "pictureBoxMoveRoom3";
            this.pictureBoxMoveRoom3.Size = new System.Drawing.Size(60, 58);
            this.pictureBoxMoveRoom3.TabIndex = 9;
            this.pictureBoxMoveRoom3.TabStop = false;
            // 
            // pictureBoxPlayer
            // 
            this.pictureBoxPlayer.Location = new System.Drawing.Point(509, 95);
            this.pictureBoxPlayer.Name = "pictureBoxPlayer";
            this.pictureBoxPlayer.Size = new System.Drawing.Size(60, 127);
            this.pictureBoxPlayer.TabIndex = 10;
            this.pictureBoxPlayer.TabStop = false;
            // 
            // labelBatWarning
            // 
            this.labelBatWarning.AutoSize = true;
            this.labelBatWarning.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBatWarning.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelBatWarning.Location = new System.Drawing.Point(175, 257);
            this.labelBatWarning.Name = "labelBatWarning";
            this.labelBatWarning.Size = new System.Drawing.Size(119, 13);
            this.labelBatWarning.TabIndex = 11;
            this.labelBatWarning.Text = "I hear something";
            // 
            // labelPitWarning
            // 
            this.labelPitWarning.AutoSize = true;
            this.labelPitWarning.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPitWarning.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelPitWarning.Location = new System.Drawing.Point(175, 285);
            this.labelPitWarning.Name = "labelPitWarning";
            this.labelPitWarning.Size = new System.Drawing.Size(105, 13);
            this.labelPitWarning.TabIndex = 12;
            this.labelPitWarning.Text = "I feel a draft";
            // 
            // textBoxShootArrowLocation
            // 
            this.textBoxShootArrowLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(78)))), ((int)(((byte)(83)))));
            this.textBoxShootArrowLocation.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxShootArrowLocation.Location = new System.Drawing.Point(19, 169);
            this.textBoxShootArrowLocation.Name = "textBoxShootArrowLocation";
            this.textBoxShootArrowLocation.Size = new System.Drawing.Size(100, 19);
            this.textBoxShootArrowLocation.TabIndex = 6;
            // 
            // labelWumpusWarning
            // 
            this.labelWumpusWarning.AutoSize = true;
            this.labelWumpusWarning.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWumpusWarning.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelWumpusWarning.Location = new System.Drawing.Point(175, 314);
            this.labelWumpusWarning.Name = "labelWumpusWarning";
            this.labelWumpusWarning.Size = new System.Drawing.Size(119, 13);
            this.labelWumpusWarning.TabIndex = 13;
            this.labelWumpusWarning.Text = "I smell a wumpus";
            // 
            // labelCoins
            // 
            this.labelCoins.AutoSize = true;
            this.labelCoins.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCoins.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelCoins.Location = new System.Drawing.Point(439, 257);
            this.labelCoins.Name = "labelCoins";
            this.labelCoins.Size = new System.Drawing.Size(42, 13);
            this.labelCoins.TabIndex = 14;
            this.labelCoins.Text = "Coins";
            // 
            // labelArrows
            // 
            this.labelArrows.AutoSize = true;
            this.labelArrows.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelArrows.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelArrows.Location = new System.Drawing.Point(439, 285);
            this.labelArrows.Name = "labelArrows";
            this.labelArrows.Size = new System.Drawing.Size(49, 13);
            this.labelArrows.TabIndex = 15;
            this.labelArrows.Text = "Arrows";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(652, 353);
            this.Controls.Add(this.labelArrows);
            this.Controls.Add(this.labelCoins);
            this.Controls.Add(this.labelWumpusWarning);
            this.Controls.Add(this.labelPitWarning);
            this.Controls.Add(this.labelBatWarning);
            this.Controls.Add(this.pictureBoxPlayer);
            this.Controls.Add(this.pictureBoxMoveRoom3);
            this.Controls.Add(this.pictureBoxMoveRoom2);
            this.Controls.Add(this.pictureBoxMoveRoom1);
            this.Controls.Add(this.pictureBoxGame);
            this.Controls.Add(this.groupBox1);
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hunt The Wumpus";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBuyArrows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShootArrows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMoveRoom1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMoveRoom2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMoveRoom3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxShootArrowLocation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBoxExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBoxShootArrows;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxBuyArrows;
        private System.Windows.Forms.PictureBox pictureBoxGame;
        private System.Windows.Forms.PictureBox pictureBoxMoveRoom1;
        private System.Windows.Forms.PictureBox pictureBoxMoveRoom2;
        private System.Windows.Forms.PictureBox pictureBoxMoveRoom3;
        private System.Windows.Forms.PictureBox pictureBoxPlayer;
        private System.Windows.Forms.Label labelBatWarning;
        private System.Windows.Forms.Label labelPitWarning;
        private System.Windows.Forms.Label labelWumpusWarning;
        private System.Windows.Forms.Label labelCoins;
        private System.Windows.Forms.Label labelArrows;
    }
}