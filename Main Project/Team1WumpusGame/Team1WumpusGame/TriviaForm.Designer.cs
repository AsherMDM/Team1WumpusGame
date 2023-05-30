namespace Team1WumpusGame
{
    partial class TriviaForm
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
            this.labelQuestion = new System.Windows.Forms.Label();
            this.radioButtonAnswer1 = new System.Windows.Forms.RadioButton();
            this.radioButtonAnswer2 = new System.Windows.Forms.RadioButton();
            this.radioButtonAnswer3 = new System.Windows.Forms.RadioButton();
            this.radioButtonAnswer4 = new System.Windows.Forms.RadioButton();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuestion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelQuestion.Location = new System.Drawing.Point(21, 40);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(98, 21);
            this.labelQuestion.TabIndex = 0;
            this.labelQuestion.Text = "Question";
            this.labelQuestion.Click += new System.EventHandler(this.labelQuestion_Click);
            // 
            // radioButtonAnswer1
            // 
            this.radioButtonAnswer1.AutoSize = true;
            this.radioButtonAnswer1.Font = new System.Drawing.Font("MS PGothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonAnswer1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButtonAnswer1.Location = new System.Drawing.Point(25, 99);
            this.radioButtonAnswer1.Name = "radioButtonAnswer1";
            this.radioButtonAnswer1.Size = new System.Drawing.Size(87, 23);
            this.radioButtonAnswer1.TabIndex = 13;
            this.radioButtonAnswer1.TabStop = true;
            this.radioButtonAnswer1.Text = "Answer";
            this.radioButtonAnswer1.UseVisualStyleBackColor = true;
            // 
            // radioButtonAnswer2
            // 
            this.radioButtonAnswer2.AutoSize = true;
            this.radioButtonAnswer2.Font = new System.Drawing.Font("MS PGothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonAnswer2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButtonAnswer2.Location = new System.Drawing.Point(25, 128);
            this.radioButtonAnswer2.Name = "radioButtonAnswer2";
            this.radioButtonAnswer2.Size = new System.Drawing.Size(87, 23);
            this.radioButtonAnswer2.TabIndex = 14;
            this.radioButtonAnswer2.TabStop = true;
            this.radioButtonAnswer2.Text = "Answer";
            this.radioButtonAnswer2.UseVisualStyleBackColor = true;
            // 
            // radioButtonAnswer3
            // 
            this.radioButtonAnswer3.AutoSize = true;
            this.radioButtonAnswer3.Font = new System.Drawing.Font("MS PGothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonAnswer3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButtonAnswer3.Location = new System.Drawing.Point(25, 157);
            this.radioButtonAnswer3.Name = "radioButtonAnswer3";
            this.radioButtonAnswer3.Size = new System.Drawing.Size(87, 23);
            this.radioButtonAnswer3.TabIndex = 15;
            this.radioButtonAnswer3.TabStop = true;
            this.radioButtonAnswer3.Text = "Answer";
            this.radioButtonAnswer3.UseVisualStyleBackColor = true;
            // 
            // radioButtonAnswer4
            // 
            this.radioButtonAnswer4.AutoSize = true;
            this.radioButtonAnswer4.Font = new System.Drawing.Font("MS PGothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonAnswer4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButtonAnswer4.Location = new System.Drawing.Point(25, 186);
            this.radioButtonAnswer4.Name = "radioButtonAnswer4";
            this.radioButtonAnswer4.Size = new System.Drawing.Size(87, 23);
            this.radioButtonAnswer4.TabIndex = 16;
            this.radioButtonAnswer4.TabStop = true;
            this.radioButtonAnswer4.Text = "Answer";
            this.radioButtonAnswer4.UseVisualStyleBackColor = true;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(68)))), ((int)(((byte)(80)))));
            this.buttonSubmit.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSubmit.Location = new System.Drawing.Point(235, 248);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(133, 56);
            this.buttonSubmit.TabIndex = 18;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // TriviaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(78)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(611, 318);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.radioButtonAnswer4);
            this.Controls.Add(this.radioButtonAnswer3);
            this.Controls.Add(this.radioButtonAnswer2);
            this.Controls.Add(this.radioButtonAnswer1);
            this.Controls.Add(this.labelQuestion);
            this.Name = "TriviaForm";
            this.Text = "Trivia";
            this.Load += new System.EventHandler(this.TriviaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.RadioButton radioButtonAnswer1;
        private System.Windows.Forms.RadioButton radioButtonAnswer2;
        private System.Windows.Forms.RadioButton radioButtonAnswer3;
        private System.Windows.Forms.RadioButton radioButtonAnswer4;
        private System.Windows.Forms.Button buttonSubmit;
    }
}