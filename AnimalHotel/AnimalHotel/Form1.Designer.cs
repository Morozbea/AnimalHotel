namespace AnimalHotel
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
            this.AddButton = new System.Windows.Forms.GroupBox();
            this.Delete = new System.Windows.Forms.Button();
            this.change_button = new System.Windows.Forms.Button();
            this.AddAnimalButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label_SpecialChar2 = new System.Windows.Forms.Label();
            this.label_SpecialChar1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.categoryLbl = new System.Windows.Forms.Label();
            this.animalObjCmb = new System.Windows.Forms.ComboBox();
            this.categoryCmb = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.genderCmb = new System.Windows.Forms.ComboBox();
            this.ageLbl = new System.Windows.Forms.Label();
            this.ageTxtBox = new System.Windows.Forms.TextBox();
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.checkBoxListAllAnimals = new System.Windows.Forms.CheckBox();
            this.listBox_Animals = new System.Windows.Forms.ListBox();
            this.idLbl = new System.Windows.Forms.Label();
            this.nameLblBottom = new System.Windows.Forms.Label();
            this.ageLblBottom = new System.Windows.Forms.Label();
            this.genderLbl = new System.Windows.Forms.Label();
            this.SCLblBottom = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBoxFeedingSchedule = new System.Windows.Forms.GroupBox();
            this.SpecieNameLbl = new System.Windows.Forms.Label();
            this.animalSpecieLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listbox_Food_Schedule = new System.Windows.Forms.ListBox();
            this.comboBoxEaterType = new System.Windows.Forms.ComboBox();
            this.AddSchedule = new System.Windows.Forms.Button();
            this.ChangeSchedule = new System.Windows.Forms.Button();
            this.DeleteSchedule = new System.Windows.Forms.Button();
            this.button_Sort = new System.Windows.Forms.Button();
            this.button_AgeSorter = new System.Windows.Forms.Button();
            this.button_Add_Food = new System.Windows.Forms.Button();
            this.button_Add_Staff = new System.Windows.Forms.Button();
            this.groupBox_Food_Details = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.AddButton.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxFeedingSchedule.SuspendLayout();
            this.groupBox_Food_Details.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Controls.Add(this.Delete);
            this.AddButton.Controls.Add(this.change_button);
            this.AddButton.Controls.Add(this.AddAnimalButton);
            this.AddButton.Controls.Add(this.groupBox3);
            this.AddButton.Controls.Add(this.label1);
            this.AddButton.Controls.Add(this.categoryLbl);
            this.AddButton.Controls.Add(this.animalObjCmb);
            this.AddButton.Controls.Add(this.categoryCmb);
            this.AddButton.Controls.Add(this.groupBox2);
            this.AddButton.Controls.Add(this.ageLbl);
            this.AddButton.Controls.Add(this.ageTxtBox);
            this.AddButton.Controls.Add(this.nameTxtBox);
            this.AddButton.Controls.Add(this.nameLabel);
            this.AddButton.Location = new System.Drawing.Point(12, 12);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(592, 328);
            this.AddButton.TabIndex = 0;
            this.AddButton.TabStop = false;
            this.AddButton.Text = "Animal Specifications";
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(442, 272);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(91, 30);
            this.Delete.TabIndex = 12;
            this.Delete.Text = "Delete animal";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // change_button
            // 
            this.change_button.Location = new System.Drawing.Point(346, 272);
            this.change_button.Name = "change_button";
            this.change_button.Size = new System.Drawing.Size(88, 30);
            this.change_button.TabIndex = 11;
            this.change_button.Text = "Change animal";
            this.change_button.UseVisualStyleBackColor = true;
            this.change_button.Click += new System.EventHandler(this.change_button_Click);
            // 
            // AddAnimalButton
            // 
            this.AddAnimalButton.Location = new System.Drawing.Point(210, 272);
            this.AddAnimalButton.Name = "AddAnimalButton";
            this.AddAnimalButton.Size = new System.Drawing.Size(115, 30);
            this.AddAnimalButton.TabIndex = 10;
            this.AddAnimalButton.Text = "Add this new animal";
            this.AddAnimalButton.UseVisualStyleBackColor = true;
            this.AddAnimalButton.Click += new System.EventHandler(this.AddAnimalButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label_SpecialChar2);
            this.groupBox3.Controls.Add(this.label_SpecialChar1);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Location = new System.Drawing.Point(9, 228);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(182, 94);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // label_SpecialChar2
            // 
            this.label_SpecialChar2.AutoSize = true;
            this.label_SpecialChar2.Location = new System.Drawing.Point(6, 61);
            this.label_SpecialChar2.Name = "label_SpecialChar2";
            this.label_SpecialChar2.Size = new System.Drawing.Size(118, 13);
            this.label_SpecialChar2.TabIndex = 12;
            this.label_SpecialChar2.Text = "Special Characteristic 2";
            // 
            // label_SpecialChar1
            // 
            this.label_SpecialChar1.AutoSize = true;
            this.label_SpecialChar1.Location = new System.Drawing.Point(5, 35);
            this.label_SpecialChar1.Name = "label_SpecialChar1";
            this.label_SpecialChar1.Size = new System.Drawing.Size(118, 13);
            this.label_SpecialChar1.TabIndex = 11;
            this.label_SpecialChar1.Text = "Special Characteristic 1";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(130, 58);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(46, 20);
            this.textBox2.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(129, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(47, 20);
            this.textBox1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(438, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Animal Species";
            // 
            // categoryLbl
            // 
            this.categoryLbl.AutoSize = true;
            this.categoryLbl.Location = new System.Drawing.Point(276, 31);
            this.categoryLbl.Name = "categoryLbl";
            this.categoryLbl.Size = new System.Drawing.Size(49, 13);
            this.categoryLbl.TabIndex = 7;
            this.categoryLbl.Text = "Category";
            // 
            // animalObjCmb
            // 
            this.animalObjCmb.FormattingEnabled = true;
            this.animalObjCmb.Location = new System.Drawing.Point(395, 58);
            this.animalObjCmb.Name = "animalObjCmb";
            this.animalObjCmb.Size = new System.Drawing.Size(159, 21);
            this.animalObjCmb.TabIndex = 6;
            // 
            // categoryCmb
            // 
            this.categoryCmb.FormattingEnabled = true;
            this.categoryCmb.Location = new System.Drawing.Point(217, 59);
            this.categoryCmb.Name = "categoryCmb";
            this.categoryCmb.Size = new System.Drawing.Size(159, 21);
            this.categoryCmb.TabIndex = 5;
            this.categoryCmb.SelectedIndexChanged += new System.EventHandler(this.categoryCmb_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.genderCmb);
            this.groupBox2.Location = new System.Drawing.Point(9, 140);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(182, 81);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gender";
            // 
            // genderCmb
            // 
            this.genderCmb.FormattingEnabled = true;
            this.genderCmb.Location = new System.Drawing.Point(38, 19);
            this.genderCmb.Name = "genderCmb";
            this.genderCmb.Size = new System.Drawing.Size(138, 21);
            this.genderCmb.TabIndex = 5;
            // 
            // ageLbl
            // 
            this.ageLbl.AutoSize = true;
            this.ageLbl.Location = new System.Drawing.Point(6, 100);
            this.ageLbl.Name = "ageLbl";
            this.ageLbl.Size = new System.Drawing.Size(26, 13);
            this.ageLbl.TabIndex = 3;
            this.ageLbl.Text = "Age";
            // 
            // ageTxtBox
            // 
            this.ageTxtBox.Location = new System.Drawing.Point(47, 97);
            this.ageTxtBox.Name = "ageTxtBox";
            this.ageTxtBox.Size = new System.Drawing.Size(48, 20);
            this.ageTxtBox.TabIndex = 2;
            this.ageTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ageTxtBox_KeyPress);
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Location = new System.Drawing.Point(47, 59);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(144, 20);
            this.nameTxtBox.TabIndex = 1;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(6, 62);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            // 
            // checkBoxListAllAnimals
            // 
            this.checkBoxListAllAnimals.AutoSize = true;
            this.checkBoxListAllAnimals.Location = new System.Drawing.Point(620, 216);
            this.checkBoxListAllAnimals.Name = "checkBoxListAllAnimals";
            this.checkBoxListAllAnimals.Size = new System.Drawing.Size(95, 17);
            this.checkBoxListAllAnimals.TabIndex = 13;
            this.checkBoxListAllAnimals.Text = "List All Animals";
            this.checkBoxListAllAnimals.UseVisualStyleBackColor = true;
            this.checkBoxListAllAnimals.CheckedChanged += new System.EventHandler(this.checkBoxListAllAnimals_CheckedChanged);
            // 
            // listBox_Animals
            // 
            this.listBox_Animals.FormattingEnabled = true;
            this.listBox_Animals.Location = new System.Drawing.Point(12, 386);
            this.listBox_Animals.Name = "listBox_Animals";
            this.listBox_Animals.Size = new System.Drawing.Size(771, 95);
            this.listBox_Animals.TabIndex = 1;
            this.listBox_Animals.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // idLbl
            // 
            this.idLbl.AutoSize = true;
            this.idLbl.Location = new System.Drawing.Point(26, 370);
            this.idLbl.Name = "idLbl";
            this.idLbl.Size = new System.Drawing.Size(18, 13);
            this.idLbl.TabIndex = 2;
            this.idLbl.Text = "ID";
            // 
            // nameLblBottom
            // 
            this.nameLblBottom.AutoSize = true;
            this.nameLblBottom.Location = new System.Drawing.Point(89, 370);
            this.nameLblBottom.Name = "nameLblBottom";
            this.nameLblBottom.Size = new System.Drawing.Size(35, 13);
            this.nameLblBottom.TabIndex = 3;
            this.nameLblBottom.Text = "Name";
            // 
            // ageLblBottom
            // 
            this.ageLblBottom.AutoSize = true;
            this.ageLblBottom.Location = new System.Drawing.Point(188, 370);
            this.ageLblBottom.Name = "ageLblBottom";
            this.ageLblBottom.Size = new System.Drawing.Size(26, 13);
            this.ageLblBottom.TabIndex = 4;
            this.ageLblBottom.Text = "Age";
            // 
            // genderLbl
            // 
            this.genderLbl.AutoSize = true;
            this.genderLbl.Location = new System.Drawing.Point(269, 370);
            this.genderLbl.Name = "genderLbl";
            this.genderLbl.Size = new System.Drawing.Size(42, 13);
            this.genderLbl.TabIndex = 5;
            this.genderLbl.Text = "Gender";
            // 
            // SCLblBottom
            // 
            this.SCLblBottom.AutoSize = true;
            this.SCLblBottom.Location = new System.Drawing.Point(373, 370);
            this.SCLblBottom.Name = "SCLblBottom";
            this.SCLblBottom.Size = new System.Drawing.Size(110, 13);
            this.SCLblBottom.TabIndex = 6;
            this.SCLblBottom.Text = "Special characreistics";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(620, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Load Image";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(620, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 130);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // groupBoxFeedingSchedule
            // 
            this.groupBoxFeedingSchedule.Controls.Add(this.SpecieNameLbl);
            this.groupBoxFeedingSchedule.Controls.Add(this.animalSpecieLbl);
            this.groupBoxFeedingSchedule.Controls.Add(this.label4);
            this.groupBoxFeedingSchedule.Controls.Add(this.listbox_Food_Schedule);
            this.groupBoxFeedingSchedule.Controls.Add(this.comboBoxEaterType);
            this.groupBoxFeedingSchedule.Location = new System.Drawing.Point(789, 301);
            this.groupBoxFeedingSchedule.Name = "groupBoxFeedingSchedule";
            this.groupBoxFeedingSchedule.Size = new System.Drawing.Size(338, 180);
            this.groupBoxFeedingSchedule.TabIndex = 16;
            this.groupBoxFeedingSchedule.TabStop = false;
            this.groupBoxFeedingSchedule.Text = "Feeding Schedule";
            // 
            // SpecieNameLbl
            // 
            this.SpecieNameLbl.AutoSize = true;
            this.SpecieNameLbl.Location = new System.Drawing.Point(112, 31);
            this.SpecieNameLbl.Name = "SpecieNameLbl";
            this.SpecieNameLbl.Size = new System.Drawing.Size(19, 13);
            this.SpecieNameLbl.TabIndex = 4;
            this.SpecieNameLbl.Text = "....";
            // 
            // animalSpecieLbl
            // 
            this.animalSpecieLbl.AutoSize = true;
            this.animalSpecieLbl.Location = new System.Drawing.Point(7, 30);
            this.animalSpecieLbl.Name = "animalSpecieLbl";
            this.animalSpecieLbl.Size = new System.Drawing.Size(77, 13);
            this.animalSpecieLbl.TabIndex = 3;
            this.animalSpecieLbl.Text = "Animal Specie:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "EaterType";
            // 
            // listbox_Food_Schedule
            // 
            this.listbox_Food_Schedule.FormattingEnabled = true;
            this.listbox_Food_Schedule.Location = new System.Drawing.Point(6, 90);
            this.listbox_Food_Schedule.Name = "listbox_Food_Schedule";
            this.listbox_Food_Schedule.Size = new System.Drawing.Size(322, 82);
            this.listbox_Food_Schedule.TabIndex = 20;
            // 
            // comboBoxEaterType
            // 
            this.comboBoxEaterType.FormattingEnabled = true;
            this.comboBoxEaterType.Location = new System.Drawing.Point(115, 58);
            this.comboBoxEaterType.Name = "comboBoxEaterType";
            this.comboBoxEaterType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEaterType.TabIndex = 0;
            // 
            // AddSchedule
            // 
            this.AddSchedule.Location = new System.Drawing.Point(789, 506);
            this.AddSchedule.Name = "AddSchedule";
            this.AddSchedule.Size = new System.Drawing.Size(106, 23);
            this.AddSchedule.TabIndex = 17;
            this.AddSchedule.Text = "Add Schedule";
            this.AddSchedule.UseVisualStyleBackColor = true;
            this.AddSchedule.Click += new System.EventHandler(this.AddSchedule_Click);
            // 
            // ChangeSchedule
            // 
            this.ChangeSchedule.Location = new System.Drawing.Point(789, 535);
            this.ChangeSchedule.Name = "ChangeSchedule";
            this.ChangeSchedule.Size = new System.Drawing.Size(106, 23);
            this.ChangeSchedule.TabIndex = 18;
            this.ChangeSchedule.Text = "Change Schedule";
            this.ChangeSchedule.UseVisualStyleBackColor = true;
            this.ChangeSchedule.Click += new System.EventHandler(this.ChangeSchedule_Click);
            // 
            // DeleteSchedule
            // 
            this.DeleteSchedule.Location = new System.Drawing.Point(919, 506);
            this.DeleteSchedule.Name = "DeleteSchedule";
            this.DeleteSchedule.Size = new System.Drawing.Size(106, 23);
            this.DeleteSchedule.TabIndex = 19;
            this.DeleteSchedule.Text = "Delete Schedule";
            this.DeleteSchedule.UseVisualStyleBackColor = true;
            this.DeleteSchedule.Click += new System.EventHandler(this.DeleteSchedule_Click);
            // 
            // button_Sort
            // 
            this.button_Sort.Location = new System.Drawing.Point(701, 316);
            this.button_Sort.Name = "button_Sort";
            this.button_Sort.Size = new System.Drawing.Size(75, 23);
            this.button_Sort.TabIndex = 21;
            this.button_Sort.Text = "Sort";
            this.button_Sort.UseVisualStyleBackColor = true;
            this.button_Sort.Click += new System.EventHandler(this.button_Sort_Click);
            // 
            // button_AgeSorter
            // 
            this.button_AgeSorter.Location = new System.Drawing.Point(620, 316);
            this.button_AgeSorter.Name = "button_AgeSorter";
            this.button_AgeSorter.Size = new System.Drawing.Size(75, 23);
            this.button_AgeSorter.TabIndex = 22;
            this.button_AgeSorter.Text = "Age Sorter";
            this.button_AgeSorter.UseVisualStyleBackColor = true;
            this.button_AgeSorter.Click += new System.EventHandler(this.button_AgeSorter_Click);
            // 
            // button_Add_Food
            // 
            this.button_Add_Food.Location = new System.Drawing.Point(9, 217);
            this.button_Add_Food.Name = "button_Add_Food";
            this.button_Add_Food.Size = new System.Drawing.Size(75, 23);
            this.button_Add_Food.TabIndex = 23;
            this.button_Add_Food.Text = "Add Food";
            this.button_Add_Food.UseVisualStyleBackColor = true;
            this.button_Add_Food.Click += new System.EventHandler(this.button_Add_Food_Click);
            // 
            // button_Add_Staff
            // 
            this.button_Add_Staff.Location = new System.Drawing.Point(102, 217);
            this.button_Add_Staff.Name = "button_Add_Staff";
            this.button_Add_Staff.Size = new System.Drawing.Size(75, 23);
            this.button_Add_Staff.TabIndex = 24;
            this.button_Add_Staff.Text = "Add Staff";
            this.button_Add_Staff.UseVisualStyleBackColor = true;
            this.button_Add_Staff.Click += new System.EventHandler(this.button_Add_Staff_Click);
            // 
            // groupBox_Food_Details
            // 
            this.groupBox_Food_Details.Controls.Add(this.listBox1);
            this.groupBox_Food_Details.Controls.Add(this.button_Add_Food);
            this.groupBox_Food_Details.Controls.Add(this.button_Add_Staff);
            this.groupBox_Food_Details.Location = new System.Drawing.Point(789, 23);
            this.groupBox_Food_Details.Name = "groupBox_Food_Details";
            this.groupBox_Food_Details.Size = new System.Drawing.Size(338, 265);
            this.groupBox_Food_Details.TabIndex = 25;
            this.groupBox_Food_Details.TabStop = false;
            this.groupBox_Food_Details.Text = "Food details";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(11, 22);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(317, 147);
            this.listBox1.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 592);
            this.Controls.Add(this.groupBox_Food_Details);
            this.Controls.Add(this.button_AgeSorter);
            this.Controls.Add(this.button_Sort);
            this.Controls.Add(this.checkBoxListAllAnimals);
            this.Controls.Add(this.DeleteSchedule);
            this.Controls.Add(this.ChangeSchedule);
            this.Controls.Add(this.AddSchedule);
            this.Controls.Add(this.groupBoxFeedingSchedule);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SCLblBottom);
            this.Controls.Add(this.genderLbl);
            this.Controls.Add(this.ageLblBottom);
            this.Controls.Add(this.nameLblBottom);
            this.Controls.Add(this.idLbl);
            this.Controls.Add(this.listBox_Animals);
            this.Controls.Add(this.AddButton);
            this.Name = "Form1";
            this.Text = "Apu\'s Animal Hotel";
            this.AddButton.ResumeLayout(false);
            this.AddButton.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxFeedingSchedule.ResumeLayout(false);
            this.groupBoxFeedingSchedule.PerformLayout();
            this.groupBox_Food_Details.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox AddButton;
        private System.Windows.Forms.Button AddAnimalButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label categoryLbl;
        private System.Windows.Forms.ComboBox animalObjCmb;
        private System.Windows.Forms.ComboBox categoryCmb;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox genderCmb;
        private System.Windows.Forms.Label ageLbl;
        private System.Windows.Forms.TextBox ageTxtBox;
        private System.Windows.Forms.TextBox nameTxtBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.ListBox listBox_Animals;
        private System.Windows.Forms.Label idLbl;
        private System.Windows.Forms.Label nameLblBottom;
        private System.Windows.Forms.Label ageLblBottom;
        private System.Windows.Forms.Label genderLbl;
        private System.Windows.Forms.Label SCLblBottom;
        private System.Windows.Forms.Label label_SpecialChar2;
        private System.Windows.Forms.Label label_SpecialChar1;
        private System.Windows.Forms.Button change_button;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.CheckBox checkBoxListAllAnimals;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBoxFeedingSchedule;
        private System.Windows.Forms.ComboBox comboBoxEaterType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AddSchedule;
        private System.Windows.Forms.Button ChangeSchedule;
        private System.Windows.Forms.Button DeleteSchedule;
        private System.Windows.Forms.Label SpecieNameLbl;
        private System.Windows.Forms.Label animalSpecieLbl;
        private System.Windows.Forms.ListBox listbox_Food_Schedule;
        private System.Windows.Forms.Button button_Sort;
        private System.Windows.Forms.Button button_AgeSorter;
        private System.Windows.Forms.Button button_Add_Food;
        private System.Windows.Forms.Button button_Add_Staff;
        private System.Windows.Forms.GroupBox groupBox_Food_Details;
        private System.Windows.Forms.ListBox listBox1;
    }
}

