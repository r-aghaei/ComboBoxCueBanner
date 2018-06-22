namespace ComboBoxCueBanner
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
            this.label1 = new System.Windows.Forms.Label();
            this.myComboBox3 = new ComboBoxCueBanner.MyComboBox();
            this.myComboBox2 = new ComboBoxCueBanner.MyComboBox();
            this.myComboBox1 = new ComboBoxCueBanner.MyComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Press Ctrl + 0 to reset combo box selection.";
            // 
            // myComboBox3
            // 
            this.myComboBox3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.myComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.myComboBox3.FormattingEnabled = true;
            this.myComboBox3.Hint = "Select an Item";
            this.myComboBox3.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.myComboBox3.Location = new System.Drawing.Point(11, 79);
            this.myComboBox3.Name = "myComboBox3";
            this.myComboBox3.Size = new System.Drawing.Size(121, 96);
            this.myComboBox3.TabIndex = 0;
            // 
            // myComboBox2
            // 
            this.myComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.myComboBox2.FormattingEnabled = true;
            this.myComboBox2.Hint = "Select an Item";
            this.myComboBox2.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.myComboBox2.Location = new System.Drawing.Point(11, 52);
            this.myComboBox2.Name = "myComboBox2";
            this.myComboBox2.Size = new System.Drawing.Size(121, 21);
            this.myComboBox2.TabIndex = 0;
            // 
            // myComboBox1
            // 
            this.myComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.myComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.myComboBox1.FormattingEnabled = true;
            this.myComboBox1.Hint = "Select an Item";
            this.myComboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.myComboBox1.Location = new System.Drawing.Point(11, 25);
            this.myComboBox1.Name = "myComboBox1";
            this.myComboBox1.Size = new System.Drawing.Size(121, 21);
            this.myComboBox1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 179);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.myComboBox3);
            this.Controls.Add(this.myComboBox2);
            this.Controls.Add(this.myComboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyComboBox myComboBox1;
        private MyComboBox myComboBox2;
        private MyComboBox myComboBox3;
        private System.Windows.Forms.Label label1;
    }
}

