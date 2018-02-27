using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Beatrix Moroz, 2018.01.14.

namespace AnimalHotel
{
    public partial class Form1 : Form
    {
        private AnimalManager m_anim_mngr;        
        private RecipeManager m_food_Mngr;

       

        //Default Constructor
        public Form1()
        {
            InitializeComponent();
            InitializeGui();
            m_anim_mngr = new AnimalManager();
           
            m_food_Mngr = new RecipeManager();
        }

        //Default values
        private void InitializeGui()
        {
            //All textbox is empty at the start
            nameTxtBox.Text = String.Empty;
            ageTxtBox.Text = String.Empty;
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;

            // gender combobox is set for male at the start
            genderCmb.Items.Clear();
            genderCmb.Items.AddRange(Enum.GetNames(typeof(Gender)));
            this.genderCmb.SelectedIndex = (int)Gender.Male;

            //category combobox is set for Bird at the start
            categoryCmb.Items.Clear();
            categoryCmb.Items.AddRange(Enum.GetNames(typeof(Category)));
            this.categoryCmb.SelectedIndex = (int)Category.Bird;

            comboBoxEaterType.Items.Clear();
            comboBoxEaterType.Items.AddRange(Enum.GetNames(typeof(EaterType)));
            this.comboBoxEaterType.SelectedIndex = (int)EaterType.Herbivore;

            //if(string.IsNullOrEmpty(nameTxtBox.Text))
            //{
            //    AddAnimalButton.Enabled = false;
            //}
        }

        // Add an animal Button
        private void AddAnimalButton_Click(object sender, EventArgs e)
        {
            if (categoryCmb.SelectedIndex == -1)
            {
                MessageBox.Show("Nothing is Selected!");
                return;
            }
            if (animalObjCmb.SelectedIndex == -1)
            {
                MessageBox.Show("Nothing is selected!");
                return;
            }

            //Read numbers from textbox
            int age_value = int.Parse(ageTxtBox.Text);
            int textbox1_value = int.Parse(textBox1.Text);

            Category cat = (Category)categoryCmb.SelectedIndex;

            m_anim_mngr.AddAnimal(CreateAnimal());

            //Update the listbox
            UpdateList();

            //Set the textboxes to empty after the animal is added and the combobox to default value
            nameTxtBox.Text = string.Empty;
            ageTxtBox.Text = string.Empty;
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            this.categoryCmb.SelectedIndex = (int)Category.Bird;
            this.genderCmb.SelectedIndex = (int)Gender.Male;
        }

        // Update listbox
        void UpdateList()
        {
            listBox_Animals.Items.Clear();
            listBox_Animals.Items.AddRange(m_anim_mngr.ToStringArray());
            List<String> list = new List<string>();
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            for (int i = 0; i < listBox_Animals.Items.Count; i++)
            {
                Console.WriteLine(listBox_Animals.Items[i]);
            }
        }

        // Change the animals combobox after what is chosen Mammals or Birds
        private void categoryCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (categoryCmb.SelectedIndex > -1)
            {

                if (categoryCmb.SelectedIndex == 1)
                {
                    animalObjCmb.Items.Clear();
                    animalObjCmb.Items.AddRange(Enum.GetNames(typeof(Mammal)));
                    this.animalObjCmb.SelectedIndex = (int)Mammal.Cat;
                    UpdateLabel(Category.Mammal);
                }
                if (categoryCmb.SelectedIndex == 0)
                {
                    animalObjCmb.Items.Clear();
                    animalObjCmb.Items.AddRange(Enum.GetNames(typeof(Bird)));
                    this.animalObjCmb.SelectedIndex = (int)Bird.Eagle;
                    UpdateLabel(Category.Bird);
                }
            }
        }

        // Update labels for Mammals or for Birds
        private void UpdateLabel(Category ctg)
        {
            switch (ctg)
            {
                case Category.Bird:
                    {
                        label_SpecialChar1.Text = "Length of the wings: ";
                        label_SpecialChar2.Text = "Bird type: ";
                        groupBox3.Text = "BirdSpec";
                        break;
                    }
                case Category.Mammal:
                    {
                        label_SpecialChar1.Text = "Number of tooth: ";
                        label_SpecialChar2.Text = "Length of tail: ";
                        groupBox3.Text = "MammalsSpec";
                        break;
                    }
            }
        }

        // Show the selected animals informations its their textboxes or comboboxes
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_Animals.SelectedIndex > -1)
            {

                Animal an = m_anim_mngr.GetAt(listBox_Animals.SelectedIndex);

                genderCmb.SelectedIndex = (int)an.GenderOfAnimal;
                nameTxtBox.Text = an.Name;
                ageTxtBox.Text = an.Age.ToString();

                if (an is Eagle)
                {
                    Eagle eg = (Eagle)an;
                    categoryCmb.SelectedIndex = (int)Category.Bird;
                    animalObjCmb.SelectedIndex = (int)Bird.Eagle;
                    textBox1.Text = eg.WingsLength.ToString();
                    textBox2.Text = eg.BirdType;
                    UpdateLabel(Category.Bird);
                    comboBoxEaterType.SelectedIndex = (int)an.GetEaterType();
                    SpecieNameLbl.Text = an.GetSpecies();

                    string[] list = an.GetFoodSchedule().GetFoodSchedule();
                    listbox_Food_Schedule.Items.AddRange(list);
                }

                if (an is Duck)
                {
                    Duck duck = (Duck)an;
                    categoryCmb.SelectedIndex = (int)Category.Bird;
                    animalObjCmb.SelectedIndex = (int)Bird.Duck;
                    textBox1.Text = duck.WingsLength.ToString();
                    textBox2.Text = duck.BirdType;
                    UpdateLabel(Category.Bird);
                    comboBoxEaterType.SelectedIndex = (int)an.GetEaterType();
                    SpecieNameLbl.Text = an.GetSpecies();

                    string[] list = an.GetFoodSchedule().GetFoodSchedule();
                    listbox_Food_Schedule.Items.AddRange(list);
                }

                if (an is Chicken)
                {
                    Chicken chick = (Chicken)an;
                    categoryCmb.SelectedIndex = (int)Category.Bird;
                    animalObjCmb.SelectedIndex = (int)Bird.Chicken;
                    textBox1.Text = chick.WingsLength.ToString();
                    textBox2.Text = chick.BirdType;
                    UpdateLabel(Category.Bird);
                    comboBoxEaterType.SelectedIndex = (int)an.GetEaterType();
                    SpecieNameLbl.Text = an.GetSpecies();

                    string[] list = an.GetFoodSchedule().GetFoodSchedule();
                    listbox_Food_Schedule.Items.AddRange(list);
                }

                if (an is Deer)
                {
                    Deer deer = (Deer)an;
                    categoryCmb.SelectedIndex = (int)Category.Mammal;
                    animalObjCmb.SelectedIndex = (int)Mammal.Deer;
                    textBox1.Text = deer.NumberOfTooth.ToString();
                    textBox2.Text = deer.LengthOfTail;
                    UpdateLabel(Category.Mammal);
                    comboBoxEaterType.SelectedIndex = (int)an.GetEaterType();
                    SpecieNameLbl.Text = an.GetSpecies();

                    string[] list = an.GetFoodSchedule().GetFoodSchedule();
                    listbox_Food_Schedule.Items.AddRange(list);
                }

                if (an is Cat)
                {
                    Cat cat = (Cat)an;
                    categoryCmb.SelectedIndex = (int)Category.Mammal;
                    animalObjCmb.SelectedIndex = (int)Mammal.Cat;
                    textBox1.Text = cat.NumberOfTooth.ToString();
                    textBox2.Text = cat.LengthOfTail;
                    UpdateLabel(Category.Mammal);
                    comboBoxEaterType.SelectedIndex = (int)an.GetEaterType();
                    SpecieNameLbl.Text = an.GetSpecies();

                    string[] list = an.GetFoodSchedule().GetFoodSchedule();
                    listbox_Food_Schedule.Items.AddRange(list);
                }

                if (an is Dog)
                {
                    Dog cat = (Dog)an;
                    categoryCmb.SelectedIndex = (int)Category.Mammal;
                    animalObjCmb.SelectedIndex = (int)Mammal.Dog;
                    textBox1.Text = cat.NumberOfTooth.ToString();
                    textBox2.Text = cat.LengthOfTail;
                    UpdateLabel(Category.Mammal);
                    comboBoxEaterType.SelectedIndex = (int)an.GetEaterType();
                    SpecieNameLbl.Text = an.GetSpecies();

                    string[] list = an.GetFoodSchedule().GetFoodSchedule();
                    listbox_Food_Schedule.Items.AddRange(list);
                }
            }
        }

        //Create animal
        private Animal CreateAnimal()
        {
            int age_value = int.Parse(ageTxtBox.Text);
            int textbox1_value = int.Parse(textBox1.Text);

            Category cat = (Category)categoryCmb.SelectedIndex;

            switch (cat)
            {
                case Category.Mammal:
                    Mammal mammal = (Mammal)animalObjCmb.SelectedIndex;
                    switch (mammal)
                    {
                        case Mammal.Cat:
                            Cat m_cat = new Cat(nameTxtBox.Text, age_value, (Gender)genderCmb.SelectedIndex, textbox1_value, textBox2.Text);
                            return m_cat;
                        case Mammal.Dog:
                            Dog m_dog = new Dog(nameTxtBox.Text, age_value, (Gender)genderCmb.SelectedIndex, textbox1_value, textBox2.Text);
                            return m_dog;
                        case Mammal.Deer:
                            Deer m_deer = new Deer(nameTxtBox.Text, age_value, (Gender)genderCmb.SelectedIndex, textbox1_value, textBox2.Text);
                            return m_deer;
                        default:
                            break;
                    }
                    break;

                case Category.Bird:
                    Bird bird = (Bird)animalObjCmb.SelectedIndex;
                    switch (bird)
                    {
                        case Bird.Eagle:
                            Eagle m_eagle = new Eagle(nameTxtBox.Text, age_value, (Gender)genderCmb.SelectedIndex, textbox1_value, textBox2.Text);
                            return m_eagle;
                        case Bird.Duck:
                            Duck m_duck = new Duck(nameTxtBox.Text, age_value, (Gender)genderCmb.SelectedIndex, textbox1_value, textBox2.Text);
                            return m_duck;
                        case Bird.Chicken:
                            Chicken m_chicken = new Chicken(nameTxtBox.Text, age_value, (Gender)genderCmb.SelectedIndex, textbox1_value, textBox2.Text);
                            return m_chicken;
                        default:
                            break;
                    }
                    break;
            }
            return null;
        }

        //Change the selected animal
        private void change_button_Click(object sender, EventArgs e)
        {
            if (listBox_Animals.SelectedIndex == -1)
            {
                MessageBox.Show("Nothing is selected!");
                return;
            }
            m_anim_mngr.ChangeAt(CreateAnimal(), listBox_Animals.SelectedIndex);
            //update list in combobox after the change
            UpdateList();
        }

        //Delete the selected item
        private void Delete_Click(object sender, EventArgs e)
        {
            if (listBox_Animals.SelectedIndex == -1)
            {
                MessageBox.Show("Nothing is selected!");
                return;
            }
            m_anim_mngr.DeleteAt(listBox_Animals.SelectedIndex);
            //update list in combobox after the change
            UpdateList();
        }

        // If checkbox list is marked then show both enums Mammals and Birds (Allanimals) i animal specis combobox        
        private void checkBoxListAllAnimals_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxListAllAnimals.Checked) //if checked show all animals
            {
                animalObjCmb.Items.Clear();
                animalObjCmb.Items.AddRange(Enum.GetNames(typeof(Bird)));
                animalObjCmb.Items.AddRange(Enum.GetNames(typeof(Mammal)));
                this.animalObjCmb.SelectedIndex = (int)Bird.Eagle;
                categoryCmb.Enabled = false;
            }
            else // otherwise just mammals or birds
            {
                categoryCmb.Enabled = true;
                if (categoryCmb.SelectedIndex == (int)Category.Bird)
                {
                    animalObjCmb.Items.Clear();
                    animalObjCmb.Items.AddRange(Enum.GetNames(typeof(Bird)));
                    this.animalObjCmb.SelectedIndex = (int)Bird.Chicken;
                }
                else
                {
                    animalObjCmb.Items.Clear();
                    animalObjCmb.Items.AddRange(Enum.GetNames(typeof(Mammal)));
                    this.animalObjCmb.SelectedIndex = (int)Mammal.Cat;
                }
            }
        }

        // Load an jpg image from a folder
        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = "jpg files (*.jpg)|*.jpg";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = new Bitmap(dlg.FileName);
                }
            }
        }

        //Sort animals by Name
        private void button_Sort_Click(object sender, EventArgs e)
        {
            m_anim_mngr.Sort(new NameSorterer());
            UpdateList();
        }

        //Sort animals by Age
        private void button_AgeSorter_Click(object sender, EventArgs e)
        {
            m_anim_mngr.Sort(new AgeSorter());
            UpdateList();
        }

        //Only numbers can be written here
        private void ageTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }



        /// <summary>
        /// Add, Change, Delete button for FoodSchedule!!! No needed now
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddSchedule_Click(object sender, EventArgs e)
        {
            //FoodSchedule foodSchedule = new FoodSchedule();
            //foodSchedule.AddFoodScheduleItem(richTextBox_FoodSchedule.Text);
            //listBox2_Test.Items.AddRange(foodSchedule.GetFoodSchedule());
            //richTextBox_FoodSchedule.Text = String.Empty;
        }

        private void UpdateScheduleList()
        {
            //listBox2_Test.Items.Clear();
            //listBox2_Test.Items.AddRange(foodSchedule.GetFoodSchedule());
        }

        private void ChangeSchedule_Click(object sender, EventArgs e)
        {
            //foodSchedule.ChangeFoodScheduleItem(richTextBox_FoodSchedule.Text, listBox2.SelectedIndex);
            //UpdateScheduleList();
        }

        private void DeleteSchedule_Click(object sender, EventArgs e)
        {
            //foodSchedule.DeleteFoodScheduleItem(listBox1.SelectedIndex);
        }

        //Open FoodForm
        private void button_Add_Food_Click(object sender, EventArgs e)
        {
            FoodForm form_Food = new FoodForm();
            DialogResult dlgResult = form_Food.ShowDialog();
            Recipe recipe;
            if (dlgResult == DialogResult.OK)
            {
                //if(recipe.Ingredients <= 0)
            }
            else
            {

            }
        }

        private void button_Add_Staff_Click(object sender, EventArgs e)
        {
            StaffForm form_Staff = new StaffForm();
            DialogResult dlgResult = form_Staff.ShowDialog();

            if (dlgResult == DialogResult.OK)
            {

            }
            else
            {
            }
        }
    }
}
