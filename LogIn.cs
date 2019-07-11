using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void chPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chPass.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "Aynur" && txtPassword.Text == "2019")
            {
                MessageBox.Show("Congratulations");
            }
            else if (txtUserName.Text != "Aynur")
            {
                MessageBox.Show("Login is incorrect");
            }
            else if (txtPassword.Text != "2019")
            {
                MessageBox.Show("Password is incorrect");
            }
        }

       
    }
}
