namespace WumpusTestObjectMonica
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
            this.buttonConstructor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonConstructor
            // 
            this.buttonConstructor.Location = new System.Drawing.Point(122, 172);
            this.buttonConstructor.Name = "buttonConstructor";
            this.buttonConstructor.Size = new System.Drawing.Size(188, 60);
            this.buttonConstructor.TabIndex = 0;
            this.buttonConstructor.Text = "Constructor";
            this.buttonConstructor.UseVisualStyleBackColor = true;
            this.buttonConstructor.Click += new System.EventHandler(this.buttonConstructor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 263);
            this.Controls.Add(this.buttonConstructor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonConstructor;
    }
}

