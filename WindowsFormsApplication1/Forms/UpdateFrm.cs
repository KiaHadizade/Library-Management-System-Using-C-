using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Forms
{
    public partial class UpdateFrm : Form
    {
        public string label;
        public UpdateFrm(string text)
        {
            InitializeComponent();
            this.label = text;
        }

        private void OrderFrm_Load(object sender, EventArgs e)
        {
            LoadTheme();

            txtBx1.Enabled = false;
            txtBx2.Enabled = false;
            txtBx3.Enabled = false;
            txtBx4.Enabled = false;
            txtBx5.Enabled = false;
            btnSv.Enabled = false;

            if (label == "viewBooks")
            {
                label1.Text += " Book";
                label2.Text = "Book Name";
                label3.Text = "Book Author";
                label4.Text = "Publisher";
                label5.Text = "Book Price";
                label6.Text = "Book Quantity";

                Books obj = new Books();
                for (int i = 0; i < obj.books.Count; i++)
                {
                    comboBox.Items.Add(i);
                }
            }
            else if (label == "viewStudents")
            {
                label1.Text += " Student";
                label2.Text = "Student Name";
                label3.Text = "Student ID";
                label4.Text = "National Code";
                label5.Text = "Discipline";
                label6.Text = "Phone No";

                Students obj = new Students();
                for (int i = 0; i < obj.students.Count; i++)
                {
                    comboBox.Items.Add(i);
                }
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

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBx1.Enabled = true;
            txtBx2.Enabled = true;
            txtBx3.Enabled = true;
            txtBx4.Enabled = true;
            txtBx5.Enabled = true;
            btnSv.Enabled = true;

            int var = Convert.ToInt32(comboBox.SelectedItem.ToString());

            if (label == "viewBooks")
            {
                Books obj = new Books();

                string[] arr = obj.books[var].Split(',');
                txtBx1.Text = arr[0];
                txtBx2.Text = arr[1];
                txtBx3.Text = arr[2];
                txtBx4.Text = arr[3];
                txtBx5.Text = arr[4];

            }
            else if (label == "viewStudents")
            {
                Students obj = new Students();

                string[] arr = obj.students[var].Split(',');
                txtBx1.Text = arr[0];
                txtBx2.Text = arr[1];
                txtBx3.Text = arr[2];
                txtBx4.Text = arr[3];
                txtBx5.Text = arr[4];
            }
        }

        private void btnSv_Click(object sender, EventArgs e)
        {
            int var = Convert.ToInt32(comboBox.SelectedItem.ToString());

            string first = txtBx1.Text;
            string second = txtBx2.Text;
            string third = txtBx3.Text;
            string fourth = txtBx4.Text;
            string fifth = txtBx5.Text;

            string data = first + "," + second + "," + third + "," + fourth + "," + fifth;

            if (label == "viewBooks")
            {
                if (MessageBox.Show("Are you sure?", "Item will be updated!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    Books obj = new Books();
                    obj.Update(var, data);

                    MessageBox.Show("Item updated successfully.", "Updated!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else if (label == "viewStudents")
            {
                if (MessageBox.Show("Are you sure?", "Item will be updated!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    Students obj = new Students();
                    obj.Update(var, data);

                    MessageBox.Show("Item updated successfully.", "Updated!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        private void btnCncl_Click(object sender, EventArgs e)
        {
            txtBx1.Clear();
            txtBx2.Clear();
            txtBx3.Clear();
            txtBx4.Clear();
            txtBx5.Clear();

            txtBx1.Enabled = false;
            txtBx2.Enabled = false;
            txtBx3.Enabled = false;
            txtBx4.Enabled = false;
            txtBx5.Enabled = false;
            btnSv.Enabled = false;
        }
    }
}
