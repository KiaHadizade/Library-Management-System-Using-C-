namespace WindowsFormsApplication1.Forms
{
    partial class IssueBookFrm
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnIsuBok = new System.Windows.Forms.Button();
            this.txtBx5 = new System.Windows.Forms.TextBox();
            this.txtBx4 = new System.Windows.Forms.TextBox();
            this.txtBx3 = new System.Windows.Forms.TextBox();
            this.txtBx2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSrchStdById = new System.Windows.Forms.Button();
            this.btnCncl = new System.Windows.Forms.Button();
            this.btnRfrsh = new System.Windows.Forms.Button();
            this.txtBx1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.comboBox);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.btnIsuBok);
            this.panel3.Controls.Add(this.txtBx5);
            this.panel3.Controls.Add(this.txtBx4);
            this.panel3.Controls.Add(this.txtBx3);
            this.panel3.Controls.Add(this.txtBx2);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(280, 147);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(419, 368);
            this.panel3.TabIndex = 24;
            // 
            // comboBox
            // 
            this.comboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(199, 185);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(200, 26);
            this.comboBox.TabIndex = 29;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(22, 341);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(377, 19);
            this.label10.TabIndex = 28;
            this.label10.Text = "NOTICE: Maximum 3 books can be issued for each one";
            // 
            // btnIsuBok
            // 
            this.btnIsuBok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIsuBok.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnIsuBok.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIsuBok.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIsuBok.Location = new System.Drawing.Point(297, 307);
            this.btnIsuBok.Name = "btnIsuBok";
            this.btnIsuBok.Size = new System.Drawing.Size(102, 31);
            this.btnIsuBok.TabIndex = 25;
            this.btnIsuBok.Text = "Issue Book";
            this.btnIsuBok.UseVisualStyleBackColor = false;
            this.btnIsuBok.Click += new System.EventHandler(this.btnIsuBok_Click);
            // 
            // txtBx5
            // 
            this.txtBx5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBx5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBx5.Location = new System.Drawing.Point(199, 143);
            this.txtBx5.Name = "txtBx5";
            this.txtBx5.ReadOnly = true;
            this.txtBx5.Size = new System.Drawing.Size(200, 24);
            this.txtBx5.TabIndex = 23;
            // 
            // txtBx4
            // 
            this.txtBx4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBx4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBx4.Location = new System.Drawing.Point(199, 99);
            this.txtBx4.Name = "txtBx4";
            this.txtBx4.ReadOnly = true;
            this.txtBx4.Size = new System.Drawing.Size(200, 24);
            this.txtBx4.TabIndex = 22;
            // 
            // txtBx3
            // 
            this.txtBx3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBx3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBx3.Location = new System.Drawing.Point(199, 54);
            this.txtBx3.Name = "txtBx3";
            this.txtBx3.ReadOnly = true;
            this.txtBx3.Size = new System.Drawing.Size(200, 24);
            this.txtBx3.TabIndex = 21;
            // 
            // txtBx2
            // 
            this.txtBx2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBx2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBx2.Location = new System.Drawing.Point(199, 13);
            this.txtBx2.Name = "txtBx2";
            this.txtBx2.ReadOnly = true;
            this.txtBx2.Size = new System.Drawing.Size(200, 24);
            this.txtBx2.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 23);
            this.label7.TabIndex = 19;
            this.label7.Text = "Book Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 23);
            this.label6.TabIndex = 18;
            this.label6.Text = "Discipline";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 23);
            this.label4.TabIndex = 17;
            this.label4.Text = "Student ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 23);
            this.label3.TabIndex = 16;
            this.label3.Text = "Student Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 23);
            this.label5.TabIndex = 15;
            this.label5.Text = "National Code";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.btnSrchStdById);
            this.panel2.Controls.Add(this.btnCncl);
            this.panel2.Controls.Add(this.btnRfrsh);
            this.panel2.Controls.Add(this.txtBx1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(15, 147);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(259, 368);
            this.panel2.TabIndex = 23;
            // 
            // btnSrchStdById
            // 
            this.btnSrchStdById.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSrchStdById.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSrchStdById.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSrchStdById.Location = new System.Drawing.Point(68, 178);
            this.btnSrchStdById.Name = "btnSrchStdById";
            this.btnSrchStdById.Size = new System.Drawing.Size(133, 41);
            this.btnSrchStdById.TabIndex = 20;
            this.btnSrchStdById.Text = "Search Student";
            this.btnSrchStdById.UseVisualStyleBackColor = false;
            this.btnSrchStdById.Click += new System.EventHandler(this.btnSrchStdById_Click);
            // 
            // btnCncl
            // 
            this.btnCncl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCncl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCncl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCncl.Location = new System.Drawing.Point(159, 308);
            this.btnCncl.Name = "btnCncl";
            this.btnCncl.Size = new System.Drawing.Size(75, 31);
            this.btnCncl.TabIndex = 19;
            this.btnCncl.Text = "Cancel";
            this.btnCncl.UseVisualStyleBackColor = false;
            // 
            // btnRfrsh
            // 
            this.btnRfrsh.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnRfrsh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRfrsh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRfrsh.Location = new System.Drawing.Point(23, 308);
            this.btnRfrsh.Name = "btnRfrsh";
            this.btnRfrsh.Size = new System.Drawing.Size(75, 31);
            this.btnRfrsh.TabIndex = 18;
            this.btnRfrsh.Text = "Refresh";
            this.btnRfrsh.UseVisualStyleBackColor = false;
            // 
            // txtBx1
            // 
            this.txtBx1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBx1.Location = new System.Drawing.Point(23, 137);
            this.txtBx1.Name = "txtBx1";
            this.txtBx1.Size = new System.Drawing.Size(211, 24);
            this.txtBx1.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 23);
            this.label2.TabIndex = 16;
            this.label2.Text = "Enter Student ID";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(15, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(683, 125);
            this.panel1.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(286, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Issue Book";
            // 
            // IssueBookFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 531);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "IssueBookFrm";
            this.Text = "NotificationFrm";
            this.Load += new System.EventHandler(this.NotificationFrm_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnIsuBok;
        private System.Windows.Forms.TextBox txtBx5;
        private System.Windows.Forms.TextBox txtBx4;
        private System.Windows.Forms.TextBox txtBx3;
        private System.Windows.Forms.TextBox txtBx2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSrchStdById;
        private System.Windows.Forms.Button btnCncl;
        private System.Windows.Forms.Button btnRfrsh;
        private System.Windows.Forms.TextBox txtBx1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;

    }
}