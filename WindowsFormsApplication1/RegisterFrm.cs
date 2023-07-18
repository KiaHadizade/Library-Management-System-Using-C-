using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class RegisterFrm : Form
    {
        public RegisterFrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsrnm.Text == "" && txtPswrd.Text == "" && txtComPswrd.Text == "")
            {
                MessageBox.Show("Username and Password fields are empty!", "Registeration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPswrd.Text == txtComPswrd.Text)
            {
                txtUsrnm.Text = "";
                txtPswrd.Text = "";
                txtComPswrd.Text = "";


                MessageBox.Show("Your account has been successfully created!", "Registeration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Passwords does NOT match, Please re-enter passwords", "Registeration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPswrd.Text = "";
                txtComPswrd.Text = "";
                txtPswrd.Focus();
            }
        }

        private void chckBxShoPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chckBxShoPass.Checked)
            {
                txtPswrd.PasswordChar = '\0';
                txtComPswrd.PasswordChar = '\0';
            }
            else
            {
                // press Alt + 7
                txtPswrd.PasswordChar = '•';
                txtComPswrd.PasswordChar = '•';
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtUsrnm.Text = "";
            txtPswrd.Text = "";
            txtComPswrd.Text = "";
            txtUsrnm.Focus();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new LoginFrm().Show();
            this.Hide();
        }
    }
}
