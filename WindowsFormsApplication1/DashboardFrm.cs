using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class DashboardFrm : Form
    {
        /* ---------- Fields ---------- */
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        /* ---------- Constructor ---------- */
        public DashboardFrm()
        {
            InitializeComponent();
            random = new Random();
            btnCloseChildForm.Visible = false;

            // Addin functionality of dargging form
            this.Text = string.Empty;
            this.ControlBox = false;

            // Indicates the limits of the maximized (Equal to the working area of the desk)
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        /* ---------- Drag Form ---------- */
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        /* ---------- Methods ---------- */
        private void DashboardFrm_Load(object sender, EventArgs e)
        {
            // Create the ToolTip and associate with the form container
            ToolTip tooltip = new ToolTip();

            // Set up the delays for the ToolTip
            tooltip.AutoPopDelay = 5000;
            tooltip.InitialDelay = 500;
            tooltip.ReshowDelay = 500;

            // Set up the ToolTip text for the Controls in the form
            tooltip.SetToolTip(this.btnClose, "Close");
            tooltip.SetToolTip(this.btnMxmz, "Maximize");
            tooltip.SetToolTip(this.btnMnmz, "Minimize");
        }

        private Color SelectThemeColor()
        {
            // We select random color from the list of colors for the theme
            int index = random.Next(ThemeColor.ColorList.Count);

            // If the color has already been selected, we select again to choose a different one
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            /*
                We highlight the button that has been clicked
                1) We select a random color from the theme
                2) We change the backgrounf color of the button
                3) We change the font color of the button
                4) We change the font size of the button
            */
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;

                    // By Activating, we increase the size of the Font-zoom effect
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                    panelTitleBar.BackColor = color;
                    // The value must be in decimals
                    panelLogo.BackColor = ThemeColor.changeColorBrightness(color, -0.3);

                    // Save the current theme color
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.changeColorBrightness(color, -0.3);

                    btnCloseChildForm.Visible = true;
                }
            }
        }

        private void DisableButton()
        {
            // We deactivate the highlighting of the button - Default values
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        /* ---------- Open the forms in the container panel ---------- */
        private void openChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            // We highlight the button (Activate)
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

            // We show the title (Text) of the childe form in the title bar (lblTitle)
            lblTitle.Text = childForm.Text;
        }

        private void btnPrdct_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms.MainFrm("viewBooks"), sender);
        }

        private void btnOrdr_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms.MainFrm("viewStudents"), sender);
        }

        private void btnCstmr_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms.AddDataFrm("addBooks"), sender);
        }

        private void btnRprt_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms.AddDataFrm("addStudents"), sender);
        }

        private void btnNtfction_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms.IssueBookFrm(), sender);
        }

        private void btnStng_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms.ReturnBookFrm(), sender);
        }

        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            lblTitle.Text = "HOME";
            panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            btnCloseChildForm.Visible = false;
        }

        /* ---------- For Dragging Form ---------- */
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMxmz_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnMnmz_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to logout?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                new LoginFrm().Show();
                this.Hide();
            }
        }
    }
}
