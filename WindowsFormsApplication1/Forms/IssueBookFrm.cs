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
    public partial class IssueBookFrm : Form
    {
        public IssueBookFrm()
        {
            InitializeComponent();
        }

        private void NotificationFrm_Load(object sender, EventArgs e)
        {
            LoadTheme();

            /*
            Books obj = new Books();
            for (int i = 0; i < obj.books.Count; i++)
            {
                comboBox.Items.Add(i);
            }*/

            string[] txtLine = File.ReadAllLines(Application.StartupPath + "\\books.txt");
            foreach (var data in txtLine)
            {
                string[] books = data.Split(',');
                comboBox.Items.Add(books[0]);
            }
        }

        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }

            label4.ForeColor = ThemeColor.SecondaryColor;
            label5.ForeColor = ThemeColor.PrimaryColor;
        }

        private void btnSrchStdById_Click(object sender, EventArgs e)
        {
            if (txtBx1.Text != string.Empty)
            {
                string[] txtLine = File.ReadAllLines(Application.StartupPath + "\\students.txt");
                foreach (var data in txtLine)
                {
                    string[] books = data.Split(',');
                    if (books[1] == txtBx1.Text)
                    {
                        txtBx2.Text = books[0];
                        txtBx3.Text = books[1];
                        txtBx4.Text = books[2];
                        txtBx5.Text = books[3];
                    }
                }
            }
        }

        private void btnIsuBok_Click(object sender, EventArgs e)
        {
            string stdName = txtBx2.Text;
            string stdId = txtBx3.Text;
            string bkName = comboBox.Text;

            IssueBook obj = new IssueBook();

            if (txtBx2.Text != string.Empty && comboBox.Text != string.Empty)
            {
                if (MessageBox.Show("Are you sure?", "The book will be reserved to this student!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    string data = stdName + "," + stdId + "," + bkName;
                    obj.Insert(data);

                    this.Close();
                }
            }
            else
                MessageBox.Show("Please fill the empty field first!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
