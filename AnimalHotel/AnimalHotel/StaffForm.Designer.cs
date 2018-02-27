namespace AnimalHotel
{
    partial class StaffForm
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
            this.Name_Staff_Lbl = new System.Windows.Forms.Label();
            this.Qualifications_GrpBox = new System.Windows.Forms.GroupBox();
            this.Staff_ListBox = new System.Windows.Forms.ListBox();
            this.Delete_Staff_Button = new System.Windows.Forms.Button();
            this.Change_Staff_Button = new System.Windows.Forms.Button();
            this.Add_Staff_Button = new System.Windows.Forms.Button();
            this.Qualification_textBox = new System.Windows.Forms.TextBox();
            this.Qualification_Lbl = new System.Windows.Forms.Label();
            this.Staff_Name_TextBox = new System.Windows.Forms.TextBox();
            this.button_Ok_Staff = new System.Windows.Forms.Button();
            this.Qualifications_GrpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Name_Staff_Lbl
            // 
            this.Name_Staff_Lbl.AutoSize = true;
            this.Name_Staff_Lbl.Location = new System.Drawing.Point(19, 18);
            this.Name_Staff_Lbl.Name = "Name_Staff_Lbl";
            this.Name_Staff_Lbl.Size = new System.Drawing.Size(35, 13);
            this.Name_Staff_Lbl.TabIndex = 0;
            this.Name_Staff_Lbl.Text = "Name";
            // 
            // Qualifications_GrpBox
            // 
            this.Qualifications_GrpBox.Controls.Add(this.Staff_ListBox);
            this.Qualifications_GrpBox.Controls.Add(this.Delete_Staff_Button);
            this.Qualifications_GrpBox.Controls.Add(this.Change_Staff_Button);
            this.Qualifications_GrpBox.Controls.Add(this.Add_Staff_Button);
            this.Qualifications_GrpBox.Controls.Add(this.Qualification_textBox);
            this.Qualifications_GrpBox.Controls.Add(this.Qualification_Lbl);
            this.Qualifications_GrpBox.Location = new System.Drawing.Point(13, 45);
            this.Qualifications_GrpBox.Name = "Qualifications_GrpBox";
            this.Qualifications_GrpBox.Size = new System.Drawing.Size(259, 187);
            this.Qualifications_GrpBox.TabIndex = 1;
            this.Qualifications_GrpBox.TabStop = false;
            this.Qualifications_GrpBox.Text = "Qualifications";
            // 
            // Staff_ListBox
            // 
            this.Staff_ListBox.FormattingEnabled = true;
            this.Staff_ListBox.Location = new System.Drawing.Point(91, 70);
            this.Staff_ListBox.Name = "Staff_ListBox";
            this.Staff_ListBox.Size = new System.Drawing.Size(162, 108);
            this.Staff_ListBox.TabIndex = 7;
            // 
            // Delete_Staff_Button
            // 
            this.Delete_Staff_Button.Location = new System.Drawing.Point(9, 147);
            this.Delete_Staff_Button.Name = "Delete_Staff_Button";
            this.Delete_Staff_Button.Size = new System.Drawing.Size(75, 23);
            this.Delete_Staff_Button.TabIndex = 6;
            this.Delete_Staff_Button.Text = "Delete";
            this.Delete_Staff_Button.UseVisualStyleBackColor = true;
            // 
            // Change_Staff_Button
            // 
            this.Change_Staff_Button.Location = new System.Drawing.Point(9, 109);
            this.Change_Staff_Button.Name = "Change_Staff_Button";
            this.Change_Staff_Button.Size = new System.Drawing.Size(75, 23);
            this.Change_Staff_Button.TabIndex = 5;
            this.Change_Staff_Button.Text = "Change";
            this.Change_Staff_Button.UseVisualStyleBackColor = true;
            // 
            // Add_Staff_Button
            // 
            this.Add_Staff_Button.Location = new System.Drawing.Point(9, 70);
            this.Add_Staff_Button.Name = "Add_Staff_Button";
            this.Add_Staff_Button.Size = new System.Drawing.Size(75, 23);
            this.Add_Staff_Button.TabIndex = 4;
            this.Add_Staff_Button.Text = "Add";
            this.Add_Staff_Button.UseVisualStyleBackColor = true;
            this.Add_Staff_Button.Click += new System.EventHandler(this.Add_Staff_Button_Click);
            // 
            // Qualification_textBox
            // 
            this.Qualification_textBox.Location = new System.Drawing.Point(91, 20);
            this.Qualification_textBox.Name = "Qualification_textBox";
            this.Qualification_textBox.Size = new System.Drawing.Size(162, 20);
            this.Qualification_textBox.TabIndex = 3;
            // 
            // Qualification_Lbl
            // 
            this.Qualification_Lbl.AutoSize = true;
            this.Qualification_Lbl.Location = new System.Drawing.Point(6, 25);
            this.Qualification_Lbl.Name = "Qualification_Lbl";
            this.Qualification_Lbl.Size = new System.Drawing.Size(65, 13);
            this.Qualification_Lbl.TabIndex = 2;
            this.Qualification_Lbl.Text = "Qualification";
            // 
            // Staff_Name_TextBox
            // 
            this.Staff_Name_TextBox.Location = new System.Drawing.Point(104, 11);
            this.Staff_Name_TextBox.Name = "Staff_Name_TextBox";
            this.Staff_Name_TextBox.Size = new System.Drawing.Size(162, 20);
            this.Staff_Name_TextBox.TabIndex = 2;
            // 
            // button_Ok_Staff
            // 
            this.button_Ok_Staff.Location = new System.Drawing.Point(74, 238);
            this.button_Ok_Staff.Name = "button_Ok_Staff";
            this.button_Ok_Staff.Size = new System.Drawing.Size(124, 23);
            this.button_Ok_Staff.TabIndex = 3;
            this.button_Ok_Staff.Text = "OK";
            this.button_Ok_Staff.UseVisualStyleBackColor = true;
            this.button_Ok_Staff.Click += new System.EventHandler(this.button_Ok_Staff_Click);
            // 
            // StaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 266);
            this.Controls.Add(this.button_Ok_Staff);
            this.Controls.Add(this.Staff_Name_TextBox);
            this.Controls.Add(this.Qualifications_GrpBox);
            this.Controls.Add(this.Name_Staff_Lbl);
            this.Name = "StaffForm";
            this.Text = "Staff Planning";
            this.Qualifications_GrpBox.ResumeLayout(false);
            this.Qualifications_GrpBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Name_Staff_Lbl;
        private System.Windows.Forms.GroupBox Qualifications_GrpBox;
        private System.Windows.Forms.Button Delete_Staff_Button;
        private System.Windows.Forms.Button Change_Staff_Button;
        private System.Windows.Forms.Button Add_Staff_Button;
        private System.Windows.Forms.TextBox Qualification_textBox;
        private System.Windows.Forms.Label Qualification_Lbl;
        private System.Windows.Forms.ListBox Staff_ListBox;
        private System.Windows.Forms.TextBox Staff_Name_TextBox;
        private System.Windows.Forms.Button button_Ok_Staff;
    }
}