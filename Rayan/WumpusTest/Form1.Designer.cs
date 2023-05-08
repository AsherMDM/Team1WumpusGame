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
            this.labelAnswer1 = new System.Windows.Forms.Label();
            this.labelAnswer2 = new System.Windows.Forms.Label();
            this.labelAnswer3 = new System.Windows.Forms.Label();
            this.labelAnswer4 = new System.Windows.Forms.Label();
            this.labelYourAnswer = new System.Windows.Forms.Label();
            this.labelCorrect = new System.Windows.Forms.Label();
            this.buttonSubmitAnswer = new System.Windows.Forms.Button();
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
            this.textBoxAnswer.Location = new System.Drawing.Point(526, 198);
            this.textBoxAnswer.Name = "textBoxAnswer";
            this.textBoxAnswer.Size = new System.Drawing.Size(188, 20);
            this.textBoxAnswer.TabIndex = 3;
            this.textBoxAnswer.TextChanged += new System.EventHandler(this.textBoxAnswer_TextChanged);
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
            this.labelQuestion.Location = new System.Drawing.Point(277, 205);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(41, 13);
            this.labelQuestion.TabIndex = 5;
            this.labelQuestion.Text = "Correct";
            // 
            // labelAnswer1
            // 
            this.labelAnswer1.AutoSize = true;
            this.labelAnswer1.Location = new System.Drawing.Point(277, 245);
            this.labelAnswer1.Name = "labelAnswer1";
            this.labelAnswer1.Size = new System.Drawing.Size(51, 13);
            this.labelAnswer1.TabIndex = 6;
            this.labelAnswer1.Text = "Answer 1";
            // 
            // labelAnswer2
            // 
            this.labelAnswer2.AutoSize = true;
            this.labelAnswer2.Location = new System.Drawing.Point(277, 282);
            this.labelAnswer2.Name = "labelAnswer2";
            this.labelAnswer2.Size = new System.Drawing.Size(51, 13);
            this.labelAnswer2.TabIndex = 7;
            this.labelAnswer2.Text = "Answer 2";
            // 
            // labelAnswer3
            // 
            this.labelAnswer3.AutoSize = true;
            this.labelAnswer3.Location = new System.Drawing.Point(277, 315);
            this.labelAnswer3.Name = "labelAnswer3";
            this.labelAnswer3.Size = new System.Drawing.Size(51, 13);
            this.labelAnswer3.TabIndex = 8;
            this.labelAnswer3.Text = "Answer 3";
            // 
            // labelAnswer4
            // 
            this.labelAnswer4.AutoSize = true;
            this.labelAnswer4.Location = new System.Drawing.Point(277, 356);
            this.labelAnswer4.Name = "labelAnswer4";
            this.labelAnswer4.Size = new System.Drawing.Size(18, 13);
            this.labelAnswer4.TabIndex = 9;
            this.labelAnswer4.Text = "xd";
            // 
            // labelYourAnswer
            // 
            this.labelYourAnswer.AutoSize = true;
            this.labelYourAnswer.Location = new System.Drawing.Point(523, 147);
            this.labelYourAnswer.Name = "labelYourAnswer";
            this.labelYourAnswer.Size = new System.Drawing.Size(67, 13);
            this.labelYourAnswer.TabIndex = 10;
            this.labelYourAnswer.Text = "Your Answer";
            // 
            // labelCorrect
            // 
            this.labelCorrect.AutoSize = true;
            this.labelCorrect.Location = new System.Drawing.Point(523, 356);
            this.labelCorrect.Name = "labelCorrect";
            this.labelCorrect.Size = new System.Drawing.Size(51, 13);
            this.labelCorrect.TabIndex = 11;
            this.labelCorrect.Text = "Answer 4";
            // 
            // buttonSubmitAnswer
            // 
            this.buttonSubmitAnswer.Location = new System.Drawing.Point(514, 73);
            this.buttonSubmitAnswer.Name = "buttonSubmitAnswer";
            this.buttonSubmitAnswer.Size = new System.Drawing.Size(145, 23);
            this.buttonSubmitAnswer.TabIndex = 12;
            this.buttonSubmitAnswer.Text = "buttonSubmitAnswer";
            this.buttonSubmitAnswer.UseVisualStyleBackColor = true;
            this.buttonSubmitAnswer.Click += new System.EventHandler(this.buttonSubmitAnswer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSubmitAnswer);
            this.Controls.Add(this.labelCorrect);
            this.Controls.Add(this.labelYourAnswer);
            this.Controls.Add(this.labelAnswer4);
            this.Controls.Add(this.labelAnswer3);
            this.Controls.Add(this.labelAnswer2);
            this.Controls.Add(this.labelAnswer1);
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
        private System.Windows.Forms.Label labelAnswer1;
        private System.Windows.Forms.Label labelAnswer2;
        private System.Windows.Forms.Label labelAnswer3;
        private System.Windows.Forms.Label labelAnswer4;
        private System.Windows.Forms.Label labelYourAnswer;
        private System.Windows.Forms.Label labelCorrect;
        private System.Windows.Forms.Button buttonSubmitAnswer;
    }
}

