namespace AnimalHotel
{
    partial class Form2
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
            this.Name_TextBox = new System.Windows.Forms.TextBox();
            this.Form2_GrpBox = new System.Windows.Forms.GroupBox();
            this.Ing_listbox = new System.Windows.Forms.ListBox();
            this.Delete_Button = new System.Windows.Forms.Button();
            this.Change_Button = new System.Windows.Forms.Button();
            this.Add_Button = new System.Windows.Forms.Button();
            this.Adds_textBox = new System.Windows.Forms.TextBox();
            this.Adds_Lbl = new System.Windows.Forms.Label();
            this.Name_Lbl = new System.Windows.Forms.Label();
            this.button_Ok = new System.Windows.Forms.Button();
            this.Form2_GrpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Name_TextBox
            // 
            this.Name_TextBox.Location = new System.Drawing.Point(104, 20);
            this.Name_TextBox.Name = "Name_TextBox";
            this.Name_TextBox.Size = new System.Drawing.Size(162, 20);
            this.Name_TextBox.TabIndex = 5;
            // 
            // Form2_GrpBox
            // 
            this.Form2_GrpBox.Controls.Add(this.Ing_listbox);
            this.Form2_GrpBox.Controls.Add(this.Delete_Button);
            this.Form2_GrpBox.Controls.Add(this.Change_Button);
            this.Form2_GrpBox.Controls.Add(this.Add_Button);
            this.Form2_GrpBox.Controls.Add(this.Adds_textBox);
            this.Form2_GrpBox.Controls.Add(this.Adds_Lbl);
            this.Form2_GrpBox.Location = new System.Drawing.Point(13, 54);
            this.Form2_GrpBox.Name = "Form2_GrpBox";
            this.Form2_GrpBox.Size = new System.Drawing.Size(407, 187);
            this.Form2_GrpBox.TabIndex = 4;
            this.Form2_GrpBox.TabStop = false;
            this.Form2_GrpBox.Text = "Add Ingredients";
            // 
            // Ing_listbox
            // 
            this.Ing_listbox.FormattingEnabled = true;
            this.Ing_listbox.Location = new System.Drawing.Point(90, 70);
            this.Ing_listbox.Name = "Ing_listbox";
            this.Ing_listbox.Size = new System.Drawing.Size(311, 95);
            this.Ing_listbox.TabIndex = 7;
            this.Ing_listbox.SelectedIndexChanged += new System.EventHandler(this.Food_ListBox_SelectedIndexChanged);
            // 
            // Delete_Button
            // 
            this.Delete_Button.Location = new System.Drawing.Point(9, 147);
            this.Delete_Button.Name = "Delete_Button";
            this.Delete_Button.Size = new System.Drawing.Size(75, 23);
            this.Delete_Button.TabIndex = 6;
            this.Delete_Button.Text = "Delete";
            this.Delete_Button.UseVisualStyleBackColor = true;
            this.Delete_Button.Click += new System.EventHandler(this.Delete_Food_Button_Click);
            // 
            // Change_Button
            // 
            this.Change_Button.Location = new System.Drawing.Point(9, 109);
            this.Change_Button.Name = "Change_Button";
            this.Change_Button.Size = new System.Drawing.Size(75, 23);
            this.Change_Button.TabIndex = 5;
            this.Change_Button.Text = "Change";
            this.Change_Button.UseVisualStyleBackColor = true;
            this.Change_Button.Click += new System.EventHandler(this.Change_Food_Button_Click);
            // 
            // Add_Button
            // 
            this.Add_Button.Location = new System.Drawing.Point(9, 70);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(75, 23);
            this.Add_Button.TabIndex = 4;
            this.Add_Button.Text = "Add";
            this.Add_Button.UseVisualStyleBackColor = true;
            this.Add_Button.Click += new System.EventHandler(this.Add_Food_Button_Click);
            // 
            // Adds_textBox
            // 
            this.Adds_textBox.Location = new System.Drawing.Point(91, 20);
            this.Adds_textBox.Name = "Adds_textBox";
            this.Adds_textBox.Size = new System.Drawing.Size(162, 20);
            this.Adds_textBox.TabIndex = 3;
            // 
            // Adds_Lbl
            // 
            this.Adds_Lbl.AutoSize = true;
            this.Adds_Lbl.Location = new System.Drawing.Point(6, 25);
            this.Adds_Lbl.Name = "Adds_Lbl";
            this.Adds_Lbl.Size = new System.Drawing.Size(59, 13);
            this.Adds_Lbl.TabIndex = 2;
            this.Adds_Lbl.Text = "Ingredients";
            // 
            // Name_Lbl
            // 
            this.Name_Lbl.AutoSize = true;
            this.Name_Lbl.Location = new System.Drawing.Point(19, 27);
            this.Name_Lbl.Name = "Name_Lbl";
            this.Name_Lbl.Size = new System.Drawing.Size(35, 13);
            this.Name_Lbl.TabIndex = 3;
            this.Name_Lbl.Text = "Name";
            // 
            // button_Ok
            // 
            this.button_Ok.Location = new System.Drawing.Point(72, 247);
            this.button_Ok.Name = "button_Ok";
            this.button_Ok.Size = new System.Drawing.Size(135, 23);
            this.button_Ok.TabIndex = 6;
            this.button_Ok.Text = "OK";
            this.button_Ok.UseVisualStyleBackColor = true;
            this.button_Ok.Click += new System.EventHandler(this.button_Ok_Food_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 279);
            this.Controls.Add(this.button_Ok);
            this.Controls.Add(this.Name_TextBox);
            this.Controls.Add(this.Form2_GrpBox);
            this.Controls.Add(this.Name_Lbl);
            this.Name = "Form2";
            this.Text = "Food Register";
            this.Form2_GrpBox.ResumeLayout(false);
            this.Form2_GrpBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Name_TextBox;
        private System.Windows.Forms.GroupBox Form2_GrpBox;
        private System.Windows.Forms.ListBox Ing_listbox;
        private System.Windows.Forms.Button Delete_Button;
        private System.Windows.Forms.Button Change_Button;
        private System.Windows.Forms.Button Add_Button;
        private System.Windows.Forms.TextBox Adds_textBox;
        private System.Windows.Forms.Label Adds_Lbl;
        private System.Windows.Forms.Label Name_Lbl;
        private System.Windows.Forms.Button button_Ok;
    }
}