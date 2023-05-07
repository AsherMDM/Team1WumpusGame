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
            this.comboBoxChooseMap = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBoxAdjacentRooms
            // 
            this.richTextBoxAdjacentRooms.Location = new System.Drawing.Point(60, 86);
            this.richTextBoxAdjacentRooms.Name = "richTextBoxAdjacentRooms";
            this.richTextBoxAdjacentRooms.ReadOnly = true;
            this.richTextBoxAdjacentRooms.Size = new System.Drawing.Size(198, 126);
            this.richTextBoxAdjacentRooms.TabIndex = 0;
            this.richTextBoxAdjacentRooms.Text = "";
            // 
            // textBoxRoomNumber
            // 
            this.textBoxRoomNumber.Location = new System.Drawing.Point(418, 83);
            this.textBoxRoomNumber.Name = "textBoxRoomNumber";
            this.textBoxRoomNumber.Size = new System.Drawing.Size(86, 26);
            this.textBoxRoomNumber.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(300, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Current Room";
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(320, 162);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(184, 68);
            this.buttonCalculate.TabIndex = 3;
            this.buttonCalculate.Text = "Calculate Adjacent Rooms";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // comboBoxChooseMap
            // 
            this.comboBoxChooseMap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChooseMap.FormattingEnabled = true;
            this.comboBoxChooseMap.Items.AddRange(new object[] {
            "Cave 1",
            "Cave 2",
            "Cave 3",
            "Cave 4",
            "Cave 5"});
            this.comboBoxChooseMap.Location = new System.Drawing.Point(152, 277);
            this.comboBoxChooseMap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxChooseMap.Name = "comboBoxChooseMap";
            this.comboBoxChooseMap.Size = new System.Drawing.Size(226, 28);
            this.comboBoxChooseMap.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 282);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Choose Map";
            // 
            // CaveTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 334);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxChooseMap);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxRoomNumber);
            this.Controls.Add(this.richTextBoxAdjacentRooms);
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
        private System.Windows.Forms.ComboBox comboBoxChooseMap;
        private System.Windows.Forms.Label label2;
    }
}

