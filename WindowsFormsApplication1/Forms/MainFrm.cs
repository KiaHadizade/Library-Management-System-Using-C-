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
    public partial class MainFrm : Form
    {
        public string label;
        public MainFrm(string text)
        {
            InitializeComponent();
            this.label = text;
        }

        private void ProductFrm_Load(object sender, EventArgs e)
        {
            LoadTheme();

            if (label == "viewBooks")
            {
                label1.Text += " Books";
                label2.Text += " Book Name";
                //Books obj = new Books();

                //Adding columns to dataGridView dynamically
                dtaGrdViwInfo.Columns.Clear();
                dtaGrdViwInfo.Columns.Add("Column1", "ID");
                dtaGrdViwInfo.Columns.Add("Column2", "Book Name");
                dtaGrdViwInfo.Columns.Add("Column3", "Book Author");
                dtaGrdViwInfo.Columns.Add("Column4", "Publisher");
                dtaGrdViwInfo.Columns.Add("Column5", "Book Price");
                dtaGrdViwInfo.Columns.Add("Column6", "Book Quantity");

                try
                {
                    //Adding data from txt file to dataGridView
                    using (StreamReader sr = new StreamReader(Application.StartupPath + "\\books.txt"))
                    {
                        int row = 0;
                        string txtLine;
                        while ((txtLine = sr.ReadLine()) != null)
                        {
                            string[] data = txtLine.Split(',');
                            dtaGrdViwInfo.Rows.Add();
                            for (int i = 0; i < data.Length; i++)
                            {
                                dtaGrdViwInfo[i + 1, row].Value = data[i];
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

            else if (label == "viewStudents")
            {
                label1.Text += " Students";
                label2.Text += " Student ID";
                //Students obj = new Students();

                //Adding columns to dataGridView dynamically
                dtaGrdViwInfo.Columns.Clear();
                dtaGrdViwInfo.Columns.Add("Column1", "ID");
                dtaGrdViwInfo.Columns.Add("Column2", "Student Name");
                dtaGrdViwInfo.Columns.Add("Column3", "Student Id");
                dtaGrdViwInfo.Columns.Add("Column4", "National Code");
                dtaGrdViwInfo.Columns.Add("Column5", "Discipline");
                dtaGrdViwInfo.Columns.Add("Column6", "Phone Number");

                try
                {
                    //Adding data from txt file to dataGridView
                    using (StreamReader sr = new StreamReader(Application.StartupPath + "\\students.txt"))
                    {
                        int row = 0;
                        string txtLine;
                        while ((txtLine = sr.ReadLine()) != null)
                        {
                            string[] data = txtLine.Split(',');
                            dtaGrdViwInfo.Rows.Add();
                            for (int i = 0; i < data.Length; i++)
                            {
                                dtaGrdViwInfo[i + 1, row].Value = data[i];
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
        }

        // Apply the colors of the current theme
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

            //label4.ForeColor = ThemeColor.SecondaryColor;
            //label5.ForeColor = ThemeColor.PrimaryColor;
        }

        private void dtaGrdViwInfo_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            //Adding ID to each row in datagridview
            this.dtaGrdViwInfo.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex).ToString();
        }

        private void txtbxSrchStdID_TextChanged(object sender, EventArgs e)
        {
            if (txtbxSrchStdID.Text != string.Empty)
            {
                foreach (DataGridViewRow row in dtaGrdViwInfo.Rows)
                {
                    if ((string)row.Cells["Column4"].Value == txtbxSrchStdID.Text || (string)row.Cells["Column5"].Value == txtbxSrchStdID.Text)
                        row.Selected = true;
                    else
                        row.Selected = false;
                }
            }
        }

        private void btnEdt_Click(object sender, EventArgs e)
        {
            if (label == "viewBooks")
            {
                new Forms.UpdateFrm("viewBooks").Show();
            }
            else if (label == "viewStudents")
            {
                new Forms.UpdateFrm("viewStudents").Show();
            }
        }

        private void btnDlt_Click(object sender, EventArgs e)
        {
            if (label == "viewBooks")
            {
                new Forms.DeleteFrm("viewBooks").Show();
            }
            else if (label == "viewStudents")
            {
                new Forms.DeleteFrm("viewStudents").Show();
            }
        }
    }
}
