using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Ajouter_Click(object sender, EventArgs e)
        {
          
            string str = user_input.Text.Trim();
            if (str != null && str!= "" && listBox1.FindStringExact(str) < 0)
                listBox1.Items.Add(str);
                user_input.Text = "";
        }

        private void Current_Element_Click(object sender, EventArgs e)
        {
            MessageBox.Show("elements seelectionner est " + listBox1.SelectedItem);
        }

        private void Current_index_Click(object sender, EventArgs e)
        {
            MessageBox.Show("l'indice de l'elements seelectionner est " + listBox1.SelectedIndex);

        }

        private void Check_selection_Click(object sender, EventArgs e)
        {
            int ind = listBox1.FindStringExact(user_input.Text);
            if ( ind >= 0)
            {
                MessageBox.Show(user_input.Text+" est d'indice "+ ind);
            }
            else
            {
                MessageBox.Show(user_input+" n existe pas Exist ");
            }

        }

        private void Delete_element_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void Empty_list_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
 
        }

        private void Check_existance_Click(object sender, EventArgs e)
        {
            if (listBox1.FindStringExact(user_input.Text) >= 0)
            {
                MessageBox.Show("Exist ");
            }
            else
            {
                MessageBox.Show("Not Exist ");
            }

        }

        private void Quitter_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void user_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
