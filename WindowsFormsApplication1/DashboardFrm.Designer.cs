namespace WindowsFormsApplication1
{
    partial class DashboardFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnStng = new System.Windows.Forms.Button();
            this.btnNtfction = new System.Windows.Forms.Button();
            this.btnRprt = new System.Windows.Forms.Button();
            this.btnCstmr = new System.Windows.Forms.Button();
            this.btnOrdr = new System.Windows.Forms.Button();
            this.btnPrdct = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnMnmz = new System.Windows.Forms.Button();
            this.btnMxmz = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCloseChildForm = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.button1);
            this.panelMenu.Controls.Add(this.btnStng);
            this.panelMenu.Controls.Add(this.btnNtfction);
            this.panelMenu.Controls.Add(this.btnRprt);
            this.panelMenu.Controls.Add(this.btnCstmr);
            this.panelMenu.Controls.Add(this.btnOrdr);
            this.panelMenu.Controls.Add(this.btnPrdct);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 581);
            this.panelMenu.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.Location = new System.Drawing.Point(0, 521);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(220, 60);
            this.button1.TabIndex = 7;
            this.button1.Text = "LOGOUT";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnStng
            // 
            this.btnStng.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStng.FlatAppearance.BorderSize = 0;
            this.btnStng.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStng.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStng.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnStng.Location = new System.Drawing.Point(0, 380);
            this.btnStng.Name = "btnStng";
            this.btnStng.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnStng.Size = new System.Drawing.Size(220, 60);
            this.btnStng.TabIndex = 6;
            this.btnStng.Text = "Return Book";
            this.btnStng.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStng.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStng.UseVisualStyleBackColor = true;
            this.btnStng.Click += new System.EventHandler(this.btnStng_Click);
            // 
            // btnNtfction
            // 
            this.btnNtfction.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNtfction.FlatAppearance.BorderSize = 0;
            this.btnNtfction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNtfction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNtfction.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnNtfction.Location = new System.Drawing.Point(0, 320);
            this.btnNtfction.Name = "btnNtfction";
            this.btnNtfction.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnNtfction.Size = new System.Drawing.Size(220, 60);
            this.btnNtfction.TabIndex = 5;
            this.btnNtfction.Text = "Issue Book";
            this.btnNtfction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNtfction.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNtfction.UseVisualStyleBackColor = true;
            this.btnNtfction.Click += new System.EventHandler(this.btnNtfction_Click);
            // 
            // btnRprt
            // 
            this.btnRprt.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRprt.FlatAppearance.BorderSize = 0;
            this.btnRprt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRprt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRprt.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnRprt.Location = new System.Drawing.Point(0, 260);
            this.btnRprt.Name = "btnRprt";
            this.btnRprt.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnRprt.Size = new System.Drawing.Size(220, 60);
            this.btnRprt.TabIndex = 4;
            this.btnRprt.Text = "Add New Student";
            this.btnRprt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRprt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRprt.UseVisualStyleBackColor = true;
            this.btnRprt.Click += new System.EventHandler(this.btnRprt_Click);
            // 
            // btnCstmr
            // 
            this.btnCstmr.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCstmr.FlatAppearance.BorderSize = 0;
            this.btnCstmr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCstmr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCstmr.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCstmr.Location = new System.Drawing.Point(0, 200);
            this.btnCstmr.Name = "btnCstmr";
            this.btnCstmr.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnCstmr.Size = new System.Drawing.Size(220, 60);
            this.btnCstmr.TabIndex = 3;
            this.btnCstmr.Text = "Add New Book";
            this.btnCstmr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCstmr.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCstmr.UseVisualStyleBackColor = true;
            this.btnCstmr.Click += new System.EventHandler(this.btnCstmr_Click);
            // 
            // btnOrdr
            // 
            this.btnOrdr.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrdr.FlatAppearance.BorderSize = 0;
            this.btnOrdr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrdr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdr.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnOrdr.Location = new System.Drawing.Point(0, 140);
            this.btnOrdr.Name = "btnOrdr";
            this.btnOrdr.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnOrdr.Size = new System.Drawing.Size(220, 60);
            this.btnOrdr.TabIndex = 2;
            this.btnOrdr.Text = "View Students";
            this.btnOrdr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrdr.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOrdr.UseVisualStyleBackColor = true;
            this.btnOrdr.Click += new System.EventHandler(this.btnOrdr_Click);
            // 
            // btnPrdct
            // 
            this.btnPrdct.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPrdct.FlatAppearance.BorderSize = 0;
            this.btnPrdct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrdct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrdct.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPrdct.Location = new System.Drawing.Point(0, 80);
            this.btnPrdct.Name = "btnPrdct";
            this.btnPrdct.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnPrdct.Size = new System.Drawing.Size(220, 60);
            this.btnPrdct.TabIndex = 1;
            this.btnPrdct.Text = "View Books";
            this.btnPrdct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrdct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrdct.UseVisualStyleBackColor = true;
            this.btnPrdct.Click += new System.EventHandler(this.btnPrdct_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Library Management System";
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelTitleBar.Controls.Add(this.btnMnmz);
            this.panelTitleBar.Controls.Add(this.btnMxmz);
            this.panelTitleBar.Controls.Add(this.btnClose);
            this.panelTitleBar.Controls.Add(this.btnCloseChildForm);
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(864, 80);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btnMnmz
            // 
            this.btnMnmz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMnmz.FlatAppearance.BorderSize = 0;
            this.btnMnmz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMnmz.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMnmz.ForeColor = System.Drawing.Color.White;
            this.btnMnmz.Location = new System.Drawing.Point(762, 0);
            this.btnMnmz.Name = "btnMnmz";
            this.btnMnmz.Size = new System.Drawing.Size(30, 30);
            this.btnMnmz.TabIndex = 3;
            this.btnMnmz.Text = "O";
            this.btnMnmz.UseVisualStyleBackColor = true;
            this.btnMnmz.Click += new System.EventHandler(this.btnMnmz_Click);
            // 
            // btnMxmz
            // 
            this.btnMxmz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMxmz.FlatAppearance.BorderSize = 0;
            this.btnMxmz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMxmz.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMxmz.ForeColor = System.Drawing.Color.White;
            this.btnMxmz.Location = new System.Drawing.Point(798, 0);
            this.btnMxmz.Name = "btnMxmz";
            this.btnMxmz.Size = new System.Drawing.Size(30, 30);
            this.btnMxmz.TabIndex = 3;
            this.btnMxmz.Text = "O";
            this.btnMxmz.UseVisualStyleBackColor = true;
            this.btnMxmz.Click += new System.EventHandler(this.btnMxmz_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(834, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "O";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCloseChildForm
            // 
            this.btnCloseChildForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCloseChildForm.FlatAppearance.BorderSize = 0;
            this.btnCloseChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseChildForm.Location = new System.Drawing.Point(0, 0);
            this.btnCloseChildForm.Name = "btnCloseChildForm";
            this.btnCloseChildForm.Size = new System.Drawing.Size(75, 80);
            this.btnCloseChildForm.TabIndex = 1;
            this.btnCloseChildForm.Text = "X";
            this.btnCloseChildForm.UseVisualStyleBackColor = true;
            this.btnCloseChildForm.Click += new System.EventHandler(this.btnCloseChildForm_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(475, 29);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(82, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "HOME";
            // 
            // panelDesktop
            // 
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 80);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(864, 501);
            this.panelDesktop.TabIndex = 2;
            // 
            // DashboardFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 581);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.MinimumSize = new System.Drawing.Size(950, 550);
            this.Name = "DashboardFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashboardFrm";
            this.Load += new System.EventHandler(this.DashboardFrm_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnStng;
        private System.Windows.Forms.Button btnNtfction;
        private System.Windows.Forms.Button btnRprt;
        private System.Windows.Forms.Button btnCstmr;
        private System.Windows.Forms.Button btnOrdr;
        private System.Windows.Forms.Button btnPrdct;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Button btnCloseChildForm;
        private System.Windows.Forms.Button btnMnmz;
        private System.Windows.Forms.Button btnMxmz;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button button1;
    }
}