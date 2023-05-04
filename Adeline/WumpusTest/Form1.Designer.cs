namespace WumpusTest
{
    partial class CaveTestForm
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
            this.richTextBoxAdjacentRooms = new System.Windows.Forms.RichTextBox();
            this.textBoxRoomNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBoxAdjacentRooms
            // 
            this.richTextBoxAdjacentRooms.Location = new System.Drawing.Point(40, 56);
            this.richTextBoxAdjacentRooms.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBoxAdjacentRooms.Name = "richTextBoxAdjacentRooms";
            this.richTextBoxAdjacentRooms.ReadOnly = true;
            this.richTextBoxAdjacentRooms.Size = new System.Drawing.Size(133, 83);
            this.richTextBoxAdjacentRooms.TabIndex = 0;
            this.richTextBoxAdjacentRooms.Text = "";
            // 
            // textBoxRoomNumber
            // 
            this.textBoxRoomNumber.Location = new System.Drawing.Point(279, 54);
            this.textBoxRoomNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxRoomNumber.Name = "textBoxRoomNumber";
            this.textBoxRoomNumber.Size = new System.Drawing.Size(59, 20);
            this.textBoxRoomNumber.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Current Room";
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(215, 105);
            this.buttonCalculate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(123, 44);
            this.buttonCalculate.TabIndex = 3;
            this.buttonCalculate.Text = "Calculate Adjacent Rooms";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // CaveTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 217);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxRoomNumber);
            this.Controls.Add(this.richTextBoxAdjacentRooms);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CaveTestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CaveTestForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxAdjacentRooms;
        private System.Windows.Forms.TextBox textBoxRoomNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCalculate;
    }
}

