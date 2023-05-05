namespace WumpusTest
{
    partial class Form1
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
            this.ConstructorButton = new System.Windows.Forms.Button();
            this.buttonAskQuestion = new System.Windows.Forms.Button();
            this.textBoxAnswer = new System.Windows.Forms.TextBox();
            this.listBoxQuestion = new System.Windows.Forms.ListBox();
            this.labelQuestion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ConstructorButton
            // 
            this.ConstructorButton.Location = new System.Drawing.Point(298, 27);
            this.ConstructorButton.Name = "ConstructorButton";
            this.ConstructorButton.Size = new System.Drawing.Size(167, 69);
            this.ConstructorButton.TabIndex = 0;
            this.ConstructorButton.Text = "Constructor Button";
            this.ConstructorButton.UseVisualStyleBackColor = true;
            this.ConstructorButton.Click += new System.EventHandler(this.ConstructorButton_Click);
            // 
            // buttonAskQuestion
            // 
            this.buttonAskQuestion.Location = new System.Drawing.Point(298, 137);
            this.buttonAskQuestion.Name = "buttonAskQuestion";
            this.buttonAskQuestion.Size = new System.Drawing.Size(145, 23);
            this.buttonAskQuestion.TabIndex = 2;
            this.buttonAskQuestion.Text = "buttonAskQuestion";
            this.buttonAskQuestion.UseVisualStyleBackColor = true;
            this.buttonAskQuestion.Click += new System.EventHandler(this.buttonAskQuestion_Click);
            // 
            // textBoxAnswer
            // 
            this.textBoxAnswer.Location = new System.Drawing.Point(526, 140);
            this.textBoxAnswer.Name = "textBoxAnswer";
            this.textBoxAnswer.Size = new System.Drawing.Size(188, 20);
            this.textBoxAnswer.TabIndex = 3;
            // 
            // listBoxQuestion
            // 
            this.listBoxQuestion.FormattingEnabled = true;
            this.listBoxQuestion.Location = new System.Drawing.Point(82, 137);
            this.listBoxQuestion.Name = "listBoxQuestion";
            this.listBoxQuestion.Size = new System.Drawing.Size(120, 95);
            this.listBoxQuestion.TabIndex = 4;
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.Location = new System.Drawing.Point(320, 205);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(35, 13);
            this.labelQuestion.TabIndex = 5;
            this.labelQuestion.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelQuestion);
            this.Controls.Add(this.listBoxQuestion);
            this.Controls.Add(this.textBoxAnswer);
            this.Controls.Add(this.buttonAskQuestion);
            this.Controls.Add(this.ConstructorButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConstructorButton;
        private System.Windows.Forms.Button buttonAskQuestion;
        private System.Windows.Forms.TextBox textBoxAnswer;
        private System.Windows.Forms.ListBox listBoxQuestion;
        private System.Windows.Forms.Label labelQuestion;
    }
}

