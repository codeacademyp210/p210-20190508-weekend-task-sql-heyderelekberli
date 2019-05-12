using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace weekendTask
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            dataGridView1.ColumnCount = 7;
            dataGridView1.Columns[0].Name = "Name";
            dataGridView1.Columns[1].Name = "Price";
            dataGridView1.Columns[2].Name = "Category";
            dataGridView1.Columns[3].Name = "Brand";
            dataGridView1.Columns[4].Name = "Color";
            dataGridView1.Columns[4].Name = "Barcod";
            dataGridView1.Columns[4].Name = "Stock";

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = true;
        }
        private void add(string name, double price, string category, string brand, string color, string barcod, string stock)
        {
            dataGridView1.Rows.Add(name, price, category, brand, color,barcod,stock);
            clearText();
        }
        private void clearText()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox2.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                add(textBox1.Text, Convert.ToDouble(textBox2.Text), textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text);

            }
            catch (Exception)
            {

                MessageBox.Show("Please, enter the price with number");            }
        }

   
    }
}
