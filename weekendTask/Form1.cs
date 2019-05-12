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
    public partial class Form1 : Form
    {
        public object NameTxt { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void Button2_Click(object sender, EventArgs e)
        {
            string loginName = LoginNameTxt.Text;
            string loginPassword = LoginPasswordTxt.Text;
            string[] user = { LoginNameTxt.Text, LoginPasswordTxt.Text };
            string[] pass = { LoginNameTxt.Text, LoginPasswordTxt.Text };

            if (user.Contains(LoginNameTxt.Text) && pass.Contains(LoginPasswordTxt.Text))
            {
                this.Hide();
                Form2 f2 = new Form2();
                f2.Show();
            }
            else
            {
                Message("psjsjsjsjs");
            }  

        
        }

        private void Message(string v)
        {
            throw new NotImplementedException();
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.Show();
        }
    }
}
