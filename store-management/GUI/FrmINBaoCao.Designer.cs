namespace QuanLiCuaHang
{
    partial class FrmINBaoCao
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
            this.rpBaoCao = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // rpBaoCao
            // 
            this.rpBaoCao.ActiveViewIndex = -1;
            this.rpBaoCao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rpBaoCao.Cursor = System.Windows.Forms.Cursors.Default;
            this.rpBaoCao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpBaoCao.Location = new System.Drawing.Point(0, 0);
            this.rpBaoCao.Name = "rpBaoCao";
            this.rpBaoCao.Size = new System.Drawing.Size(682, 418);
            this.rpBaoCao.TabIndex = 0;
            // 
            // FrmINBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 418);
            this.Controls.Add(this.rpBaoCao);
            this.Name = "FrmINBaoCao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmINBaoCao";
            this.Load += new System.EventHandler(this.FrmINBaoCao_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer rpBaoCao;
    }
}