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
    public partial class DeleteFrm : Form
    {
        public string label;
        public DeleteFrm(string text)
        {
            InitializeComponent();
            this.label = text;
        }

        private void ReportingFrm_Load(object sender, EventArgs e)
        {
            LoadTheme();

            txtBx1.Enabled = false;
            txtBx2.Enabled = false;
            txtBx3.Enabled = false;
            btnDlt.Enabled = false;

            if (label == "viewBooks")
            {
                label1.Text += " Book";
                label3.Text = "Book Name";
                label4.Text = "Book Author";
                label5.Text = "Publisher";

                Books obj = new Books();
                for (int i = 0; i < obj.books.Count; i++)
                {
                    comboBox.Items.Add(i);
                }
            }
            else if (label == "viewStudents")
            {
                label1.Text += " Student";
                label3.Text = "Student Name";
                label4.Text = "Student ID";
                label5.Text = "National Code";

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
            btnDlt.Enabled = true;

            int var = Convert.ToInt32(comboBox.SelectedItem.ToString());

            if (label == "viewBooks")
            {
                Books obj = new Books();

                string[] arr = obj.books[var].Split(',');
                txtBx1.Text = arr[0];
                txtBx2.Text = arr[1];
                txtBx3.Text = arr[2];

            }
            else if (label == "viewStudents")
            {
                Students obj = new Students();

                string[] arr = obj.students[var].Split(',');
                txtBx1.Text = arr[0];
                txtBx2.Text = arr[1];
                txtBx3.Text = arr[2];
            }
        }

        private void btnDlt_Click(object sender, EventArgs e)
        {
            int var = Convert.ToInt32(comboBox.SelectedItem.ToString());

            if (label == "viewBooks")
            {
                if (MessageBox.Show("Are you sure?", "Item will be deleted permanently!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Books obj = new Books();
                    obj.Delete(var);

                    MessageBox.Show("Item deleted successfully.", "deleted!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else if (label == "viewStudents")
            {
                if (MessageBox.Show("Are you sure?", "Item will be deleted permanently!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Students obj = new Students();
                    obj.Delete(var);

                    MessageBox.Show("Item deleted successfully.", "deleted!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        private void btnCncl_Click(object sender, EventArgs e)
        {
            txtBx1.Clear();
            txtBx2.Clear();
            txtBx3.Clear();

            txtBx1.Enabled = false;
            txtBx2.Enabled = false;
            txtBx3.Enabled = false;
            btnDlt.Enabled = false;
        }
    }
}
