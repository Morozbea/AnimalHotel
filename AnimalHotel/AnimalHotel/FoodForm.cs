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
        RecipeManager recipeMngr;
        //Form1 form1;
       
        public Form2(Form1 form1)
        {
            
            InitializeComponent();
            if (form1.check_Staff_or_Food)
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
            recipeMngr = new RecipeManager();
            //form1 = new Form1();
            InitializeGUI();
        }

        private void InitializeGUI()
        {
            Name_TextBox.Text = String.Empty;
            
        }

        private void button_Ok_Food_Click(object sender, EventArgs e)
        {
            string name = Name_TextBox.Text;
            List<string> lista = new List<string>();

            Recipe recipe = new Recipe(name, lista);

            

            for (int i = 0; i < ListBox.Items.Count; i++)
            {
                lista.Add((string)ListBox.Items[i]);
            }

            recipeMngr.Add(recipe);
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Add_Food_Button_Click(object sender, EventArgs e)
        {
            ListBox.Items.Add(Adds_textBox.Text);
            Adds_textBox.Text = String.Empty;
        }

        

        private void Change_Food_Button_Click(object sender, EventArgs e)
        {

        }

        private void Delete_Food_Button_Click(object sender, EventArgs e)
        {

        }

        private void UpdateList()
        {
            ListBox.Items.Clear();
            ListBox.Items.AddRange(recipeMngr.ToStringArray());
        }

        private void Food_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
