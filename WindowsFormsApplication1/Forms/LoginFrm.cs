using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1.Forms
{
    public partial class LoginFrm : Form
    {
        public LoginFrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool bValid = false;
            using (StreamReader reader = new StreamReader(Application.StartupPath + "\\login.txt"))
            {
                string txtLine;
                while ((txtLine = reader.ReadLine()) != null)
                {
                    string[] data = txtLine.Split(' ');
                    string user = data[0];
                    string passcode = data[1];
                    if (txtUsrnm.Text == user && txtPswrd.Text == passcode)
                    {
                        //login sucessfull so far
                        bValid = true;
                        break;
                    }
                }
            }
            if (bValid)
            {
                new DashboardFrm().Show();
                this.Hide();
                MessageBox.Show("You're logedin successfully!", "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Invalid Username or Password, Please try again!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsrnm.Text = "";
                txtPswrd.Text = "";
                chckBxShoPass.Checked = false;
                txtUsrnm.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtUsrnm.Text = "";
            txtPswrd.Text = "";
            chckBxShoPass.Checked = false;
            txtUsrnm.Focus();
        }

        private void chckBxShoPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chckBxShoPass.Checked)
            {
                txtPswrd.PasswordChar = '\0';
            }
            else
            {
                // press Alt + 7
                txtPswrd.PasswordChar = '•';
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new RegisterFrm().Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Relax and try to remember your password...", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
