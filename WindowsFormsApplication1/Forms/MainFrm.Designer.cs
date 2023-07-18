namespace WindowsFormsApplication1.Forms
{
    partial class MainFrm
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
            this.dtaGrdViwInfo = new System.Windows.Forms.DataGridView();
            this.txtbxSrchStdID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEdt = new System.Windows.Forms.Button();
            this.btnDlt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtaGrdViwInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // dtaGrdViwInfo
            // 
            this.dtaGrdViwInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtaGrdViwInfo.Location = new System.Drawing.Point(12, 150);
            this.dtaGrdViwInfo.Name = "dtaGrdViwInfo";
            this.dtaGrdViwInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtaGrdViwInfo.Size = new System.Drawing.Size(690, 293);
            this.dtaGrdViwInfo.TabIndex = 26;
            this.dtaGrdViwInfo.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dtaGrdViwInfo_RowPostPaint);
            // 
            // txtbxSrchStdID
            // 
            this.txtbxSrchStdID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxSrchStdID.Location = new System.Drawing.Point(190, 104);
            this.txtbxSrchStdID.Name = "txtbxSrchStdID";
            this.txtbxSrchStdID.Size = new System.Drawing.Size(200, 24);
            this.txtbxSrchStdID.TabIndex = 25;
            this.txtbxSrchStdID.TextChanged += new System.EventHandler(this.txtbxSrchStdID_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 23);
            this.label2.TabIndex = 24;
            this.label2.Text = "Search By";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(223, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 29);
            this.label1.TabIndex = 29;
            this.label1.Text = "View";
            // 
            // btnEdt
            // 
            this.btnEdt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdt.Location = new System.Drawing.Point(451, 97);
            this.btnEdt.Name = "btnEdt";
            this.btnEdt.Size = new System.Drawing.Size(117, 40);
            this.btnEdt.TabIndex = 30;
            this.btnEdt.Text = "Edit";
            this.btnEdt.UseVisualStyleBackColor = true;
            this.btnEdt.Click += new System.EventHandler(this.btnEdt_Click);
            // 
            // btnDlt
            // 
            this.btnDlt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDlt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDlt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDlt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDlt.Location = new System.Drawing.Point(585, 97);
            this.btnDlt.Name = "btnDlt";
            this.btnDlt.Size = new System.Drawing.Size(117, 40);
            this.btnDlt.TabIndex = 31;
            this.btnDlt.Text = "Delete";
            this.btnDlt.UseVisualStyleBackColor = true;
            this.btnDlt.Click += new System.EventHandler(this.btnDlt_Click);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 531);
            this.Controls.Add(this.btnDlt);
            this.Controls.Add(this.btnEdt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtaGrdViwInfo);
            this.Controls.Add(this.txtbxSrchStdID);
            this.Controls.Add(this.label2);
            this.Name = "MainFrm";
            this.Text = "MainFrm";
            this.Load += new System.EventHandler(this.ProductFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtaGrdViwInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dtaGrdViwInfo;
        private System.Windows.Forms.TextBox txtbxSrchStdID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEdt;
        private System.Windows.Forms.Button btnDlt;

    }
}