namespace AnimalHotel
{
    partial class FoodForm
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
            this.Food_Name_TextBox = new System.Windows.Forms.TextBox();
            this.Ingredients_GrpBox = new System.Windows.Forms.GroupBox();
            this.Food_ListBox = new System.Windows.Forms.ListBox();
            this.Delete_Food_Button = new System.Windows.Forms.Button();
            this.Change_Food_Button = new System.Windows.Forms.Button();
            this.Add_Food_Button = new System.Windows.Forms.Button();
            this.Ingredients_textBox = new System.Windows.Forms.TextBox();
            this.Ingredients_Lbl = new System.Windows.Forms.Label();
            this.Name_Food_Lbl = new System.Windows.Forms.Label();
            this.button_Ok_Food = new System.Windows.Forms.Button();
            this.Ingredients_GrpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Food_Name_TextBox
            // 
            this.Food_Name_TextBox.Location = new System.Drawing.Point(104, 20);
            this.Food_Name_TextBox.Name = "Food_Name_TextBox";
            this.Food_Name_TextBox.Size = new System.Drawing.Size(162, 20);
            this.Food_Name_TextBox.TabIndex = 5;
            // 
            // Ingredients_GrpBox
            // 
            this.Ingredients_GrpBox.Controls.Add(this.Food_ListBox);
            this.Ingredients_GrpBox.Controls.Add(this.Delete_Food_Button);
            this.Ingredients_GrpBox.Controls.Add(this.Change_Food_Button);
            this.Ingredients_GrpBox.Controls.Add(this.Add_Food_Button);
            this.Ingredients_GrpBox.Controls.Add(this.Ingredients_textBox);
            this.Ingredients_GrpBox.Controls.Add(this.Ingredients_Lbl);
            this.Ingredients_GrpBox.Location = new System.Drawing.Point(13, 54);
            this.Ingredients_GrpBox.Name = "Ingredients_GrpBox";
            this.Ingredients_GrpBox.Size = new System.Drawing.Size(407, 187);
            this.Ingredients_GrpBox.TabIndex = 4;
            this.Ingredients_GrpBox.TabStop = false;
            this.Ingredients_GrpBox.Text = "Add Ingredients";
            // 
            // Food_ListBox
            // 
            this.Food_ListBox.FormattingEnabled = true;
            this.Food_ListBox.Location = new System.Drawing.Point(90, 70);
            this.Food_ListBox.Name = "Food_ListBox";
            this.Food_ListBox.Size = new System.Drawing.Size(311, 95);
            this.Food_ListBox.TabIndex = 7;
            // 
            // Delete_Food_Button
            // 
            this.Delete_Food_Button.Location = new System.Drawing.Point(9, 147);
            this.Delete_Food_Button.Name = "Delete_Food_Button";
            this.Delete_Food_Button.Size = new System.Drawing.Size(75, 23);
            this.Delete_Food_Button.TabIndex = 6;
            this.Delete_Food_Button.Text = "Delete";
            this.Delete_Food_Button.UseVisualStyleBackColor = true;
            this.Delete_Food_Button.Click += new System.EventHandler(this.Delete_Food_Button_Click);
            // 
            // Change_Food_Button
            // 
            this.Change_Food_Button.Location = new System.Drawing.Point(9, 109);
            this.Change_Food_Button.Name = "Change_Food_Button";
            this.Change_Food_Button.Size = new System.Drawing.Size(75, 23);
            this.Change_Food_Button.TabIndex = 5;
            this.Change_Food_Button.Text = "Change";
            this.Change_Food_Button.UseVisualStyleBackColor = true;
            this.Change_Food_Button.Click += new System.EventHandler(this.Change_Food_Button_Click);
            // 
            // Add_Food_Button
            // 
            this.Add_Food_Button.Location = new System.Drawing.Point(9, 70);
            this.Add_Food_Button.Name = "Add_Food_Button";
            this.Add_Food_Button.Size = new System.Drawing.Size(75, 23);
            this.Add_Food_Button.TabIndex = 4;
            this.Add_Food_Button.Text = "Add";
            this.Add_Food_Button.UseVisualStyleBackColor = true;
            this.Add_Food_Button.Click += new System.EventHandler(this.Add_Food_Button_Click);
            // 
            // Ingredients_textBox
            // 
            this.Ingredients_textBox.Location = new System.Drawing.Point(91, 20);
            this.Ingredients_textBox.Name = "Ingredients_textBox";
            this.Ingredients_textBox.Size = new System.Drawing.Size(162, 20);
            this.Ingredients_textBox.TabIndex = 3;
            // 
            // Ingredients_Lbl
            // 
            this.Ingredients_Lbl.AutoSize = true;
            this.Ingredients_Lbl.Location = new System.Drawing.Point(6, 25);
            this.Ingredients_Lbl.Name = "Ingredients_Lbl";
            this.Ingredients_Lbl.Size = new System.Drawing.Size(59, 13);
            this.Ingredients_Lbl.TabIndex = 2;
            this.Ingredients_Lbl.Text = "Ingredients";
            // 
            // Name_Food_Lbl
            // 
            this.Name_Food_Lbl.AutoSize = true;
            this.Name_Food_Lbl.Location = new System.Drawing.Point(19, 27);
            this.Name_Food_Lbl.Name = "Name_Food_Lbl";
            this.Name_Food_Lbl.Size = new System.Drawing.Size(35, 13);
            this.Name_Food_Lbl.TabIndex = 3;
            this.Name_Food_Lbl.Text = "Name";
            // 
            // button_Ok_Food
            // 
            this.button_Ok_Food.Location = new System.Drawing.Point(72, 247);
            this.button_Ok_Food.Name = "button_Ok_Food";
            this.button_Ok_Food.Size = new System.Drawing.Size(135, 23);
            this.button_Ok_Food.TabIndex = 6;
            this.button_Ok_Food.Text = "OK";
            this.button_Ok_Food.UseVisualStyleBackColor = true;
            this.button_Ok_Food.Click += new System.EventHandler(this.button_Ok_Food_Click);
            // 
            // FoodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 279);
            this.Controls.Add(this.button_Ok_Food);
            this.Controls.Add(this.Food_Name_TextBox);
            this.Controls.Add(this.Ingredients_GrpBox);
            this.Controls.Add(this.Name_Food_Lbl);
            this.Name = "FoodForm";
            this.Text = "Food Register";
            this.Ingredients_GrpBox.ResumeLayout(false);
            this.Ingredients_GrpBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Food_Name_TextBox;
        private System.Windows.Forms.GroupBox Ingredients_GrpBox;
        private System.Windows.Forms.ListBox Food_ListBox;
        private System.Windows.Forms.Button Delete_Food_Button;
        private System.Windows.Forms.Button Change_Food_Button;
        private System.Windows.Forms.Button Add_Food_Button;
        private System.Windows.Forms.TextBox Ingredients_textBox;
        private System.Windows.Forms.Label Ingredients_Lbl;
        private System.Windows.Forms.Label Name_Food_Lbl;
        private System.Windows.Forms.Button button_Ok_Food;
    }
}