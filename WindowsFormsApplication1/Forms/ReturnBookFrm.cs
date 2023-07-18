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
    public partial class ReturnBookFrm : Form
    {
        public ReturnBookFrm()
        {
            InitializeComponent();
        }

        private void SettingFrm_Load(object sender, EventArgs e)
        {
            LoadTheme();

            dtaGrdViw.Columns.Clear();
            dtaGrdViw.Columns.Add("Column1", "ID");
            dtaGrdViw.Columns.Add("Column2", "Student Name");
            dtaGrdViw.Columns.Add("Column3", "Student Id");
            dtaGrdViw.Columns.Add("Column4", "Book Name");

            txtBx1.Enabled = false;
            txtBx2.Enabled = false;
            txtBx3.Enabled = false;
            btnRtrn.Enabled = false;

            IssueBook obj = new IssueBook();
            for (int i = 0; i < obj.issuebook.Count; i++)
            {
                comboBox.Items.Add(i);
            }

            try
            {
                //Adding data from txt file to dataGridView
                using (StreamReader sr = new StreamReader(Application.StartupPath + "\\borrow.txt"))
                {
                    int row = 0;
                    string txtLine;
                    while ((txtLine = sr.ReadLine()) != null)
                    {
                        string[] data = txtLine.Split(',');
                        dtaGrdViw.Rows.Add();
                        for (int i = 0; i < data.Length; i++)
                        {
                            dtaGrdViw[i + 1, row].Value = data[i];
                        }
                        row++;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
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
            //label5.ForeColor = ThemeColor.PrimaryColor;
        }

        private void dtaGrdViw_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            //Adding ID to each row in datagridview
            this.dtaGrdViw.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex).ToString();
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBx1.Enabled = true;
            txtBx2.Enabled = true;
            txtBx3.Enabled = true;
            btnRtrn.Enabled = true;

            int var = Convert.ToInt32(comboBox.SelectedItem.ToString());

            IssueBook obj = new IssueBook();

            string[] arr = obj.issuebook[var].Split(',');
            txtBx1.Text = arr[0];
            txtBx2.Text = arr[1];
            txtBx3.Text = arr[2];
        }

        private void btnRtrn_Click(object sender, EventArgs e)
        {
            int var = Convert.ToInt32(comboBox.SelectedItem.ToString());

            if (MessageBox.Show("Are you sure?", "Issued book will be returned!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                IssueBook obj = new IssueBook();
                obj.Delete(var);

                MessageBox.Show("Item returned successfully.", "Returned!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
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
            btnRtrn.Enabled = false;

            comboBox.Items.Clear();
            IssueBook obj = new IssueBook();
            for (int i = 0; i < obj.issuebook.Count; i++)
            {
                comboBox.Items.Add(i);
            }
        }
    }
}
