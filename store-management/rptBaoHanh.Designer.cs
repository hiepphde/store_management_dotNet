namespace QuanLiCuaHang
{
    partial class rptBaoHanh
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.cbxIN = new System.Windows.Forms.ComboBox();
            this.btnIN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(786, 344);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // cbxIN
            // 
            this.cbxIN.FormattingEnabled = true;
            this.cbxIN.Location = new System.Drawing.Point(12, 75);
            this.cbxIN.Name = "cbxIN";
            this.cbxIN.Size = new System.Drawing.Size(177, 21);
            this.cbxIN.TabIndex = 1;
            // 
            // btnIN
            // 
            this.btnIN.Location = new System.Drawing.Point(57, 102);
            this.btnIN.Name = "btnIN";
            this.btnIN.Size = new System.Drawing.Size(75, 23);
            this.btnIN.TabIndex = 2;
            this.btnIN.Text = "IN";
            this.btnIN.UseVisualStyleBackColor = true;
            this.btnIN.Click += new System.EventHandler(this.btnIN_Click);
            // 
            // rptBaoHanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 344);
            this.Controls.Add(this.btnIN);
            this.Controls.Add(this.cbxIN);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "rptBaoHanh";
            this.Text = "rptBaoHanh";
            this.Load += new System.EventHandler(this.rptBaoHanh_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.ComboBox cbxIN;
        private System.Windows.Forms.Button btnIN;
    }
}