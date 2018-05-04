using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalHotel
{
    public partial class Form2 : Form
    {
        ListManager<string> lista = new ListManager<string>();
        Recipe m_recipe;
        Staff m_staff;
        bool checkFood;
        string name;


        public Form2(bool checkFood)
        {
            InitializeComponent();
            this.checkFood = checkFood;
            m_recipe = new Recipe(name, lista);
            m_staff = new Staff(name, lista);
            InitializeGUI();
        }

        public Recipe AddedRecipe { get { return m_recipe; } set { m_recipe = value; } }

        public Staff AddedStaff { get { return m_staff; } set { value = m_staff; } }

        private void InitializeGUI()
        {
            Name_TextBox.Text = String.Empty;
            if (checkFood)
            {
                Adds_Lbl.Text = "Ingredients";
                Form2_GrpBox.Text = "Add Ingredients: ";
                this.Text = "Food Register";
            }
            else
            {
                Adds_Lbl.Text = "Qualification";
                Form2_GrpBox.Text = "Add Qualifications: ";
                this.Text = "Staff Planning";
            }
        }

        private void button_Ok_Food_Click(object sender, EventArgs e)
        {

            if (checkFood)
            {
                //Food Recipe
                m_recipe = new Recipe(name, lista);
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                //Staff lista
                m_staff = new Staff(name, lista);
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void Add_Food_Button_Click(object sender, EventArgs e)
        {
            name = Name_TextBox.Text;
            if (checkFood)
            {
                m_recipe.Name = name;
            }
            else
            {
                m_staff.Name = name;
            }

            string word = Adds_textBox.Text;
            if (!string.IsNullOrEmpty(word))
            {
                Ing_listbox.Items.Add(word);
                lista.Add(word);
                Adds_textBox.Text = String.Empty;
            }
            else
            {
                MessageBox.Show("Empty");
            }
        }

        private void Change_Food_Button_Click(object sender, EventArgs e)
        {
            if (Ing_listbox.SelectedIndex == -1)
            {
                MessageBox.Show("Nothing is selected");
                return;
            }
            lista.ChangeAt(Adds_textBox.Text, Ing_listbox.SelectedIndex);
            UpdateListBox();
        }

        private void UpdateListBox()
        {
            Ing_listbox.Items.Clear();
            Ing_listbox.Items.AddRange(lista.ToStringArray());
        }

        private void Delete_Food_Button_Click(object sender, EventArgs e)
        {
            if (Ing_listbox.SelectedIndex != -1)
                lista.DeleteAt(Ing_listbox.SelectedIndex);
            UpdateListBox();
        }

        private void Food_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Ing_listbox.SelectedIndex != -1)
                Adds_textBox.Text = Ing_listbox.SelectedItem.ToString();
        }
    }
}
