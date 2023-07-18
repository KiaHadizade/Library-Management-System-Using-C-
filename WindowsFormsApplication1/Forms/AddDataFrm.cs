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
    public partial class AddDataFrm : Form
    {
        public string label;
        public AddDataFrm(string text)
        {
            InitializeComponent();
            this.label = text;
        }

        private void CustomerFrm_Load(object sender, EventArgs e)
        {
            LoadTheme();

            if (label == "addBooks")
            {
                label1.Text += " Books";
                label2.Text = "Book Name";
                label3.Text = "Book Author";
                label4.Text = "Publisher";
                label5.Text = "Book Price";
                label6.Text = "Book Quantity";
            }
            else if (label == "addStudents")
            {
                label1.Text += " Students";
                label2.Text = "Student Name";
                label3.Text = "Student ID";
                label4.Text = "National Code";
                label5.Text = "Discipline";
                label6.Text = "Phone No";
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

        private void btnSv_Click(object sender, EventArgs e)
        {
            if (txtBx1.Text != "" && txtBx2.Text != "" && txtBx3.Text != "" && txtBx4.Text != "" && txtBx5.Text != "")
            {
                try
                {
                    if (label == "addBooks")
                    {
                        string bkName = txtBx1.Text;
                        string atrName = txtBx2.Text;
                        string bkPblshr = txtBx3.Text;
                        int bkPrc = Convert.ToInt32(txtBx4.Text);
                        int bkQntt = Convert.ToInt32(txtBx5.Text);

                        string data = bkName + "," + atrName + "," + bkPblshr + "," + bkPrc + "," + bkQntt;

                        Books obj = new Books();
                        obj.Insert(data);
                    }
                    else if (label == "addStudents")
                    {
                        string stdName = txtBx1.Text;
                        int stdId = Convert.ToInt32(txtBx2.Text);
                        int stdCode = Convert.ToInt32(txtBx3.Text);
                        string stdDscpln = txtBx4.Text;
                        int stdNo = Convert.ToInt32(txtBx5.Text);

                        string data = stdName + "," + stdId + "," + stdCode + "," + stdDscpln + "," + stdNo;

                        Students obj = new Students();
                        obj.Insert(data);

                    }
                    MessageBox.Show("Data saved successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtBx1.Clear();
                    txtBx2.Clear();
                    txtBx3.Clear();
                    txtBx4.Clear();
                    txtBx5.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txtBx1.Clear();
                    txtBx2.Clear();
                    txtBx3.Clear();
                    txtBx4.Clear();
                    txtBx5.Clear();
                }
            }
            else
                MessageBox.Show("Empty field not allowed!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnCncl_Click(object sender, EventArgs e)
        {
            if (txtBx1.Text != "" || txtBx2.Text != "" || txtBx3.Text != "" || txtBx4.Text != "" || txtBx5.Text != "")
            {
                if (MessageBox.Show("All unsaved data will be lost!", "Are you sure you want to quit?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    this.Close();
            }
            else
                this.Close();
        }
    }
}
