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
    public partial class FoodForm : Form
    {
        RecipeManager recipeMngr;
       
        public FoodForm()
        {
            InitializeComponent();
            recipeMngr = new RecipeManager();
            
            InitializeGUI();
        }

        private void InitializeGUI()
        {
            Food_Name_TextBox.Text = String.Empty;
           
        }

        private void button_Ok_Food_Click(object sender, EventArgs e)
        {
            string name = Food_Name_TextBox.Text;
            List<string> lista = new List<string>();

            Recipe recipe = new Recipe(name, lista);

            

            for (int i = 0; i < Food_ListBox.Items.Count; i++)
            {
                lista.Add((string)Food_ListBox.Items[i]);
            }

            recipeMngr.Add(recipe);
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Add_Food_Button_Click(object sender, EventArgs e)
        {
            Food_ListBox.Items.Add(Food_Name_TextBox.Text);
        }

        

        private void Change_Food_Button_Click(object sender, EventArgs e)
        {

        }

        private void Delete_Food_Button_Click(object sender, EventArgs e)
        {

        }

        private void UpdateList()
        {
            Food_ListBox.Items.Clear();
            Food_ListBox.Items.AddRange(recipeMngr.ToStringArray());
        }

        private void Food_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
