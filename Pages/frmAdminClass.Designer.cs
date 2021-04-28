
namespace QuanLiHocThem.Pages
{
    partial class frmAdminClass
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.dgvContent = new System.Windows.Forms.DataGridView();
            this.Ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DaKetThuc = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.SoLuongHocSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMonHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhoaHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaoVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HocPhiMotBuoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MucHocPhi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContent)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(862, 172);
            this.panelControl1.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(404, 5);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(56, 19);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Lop hoc";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.dgvContent);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 172);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(862, 379);
            this.panelControl2.TabIndex = 2;
            // 
            // dgvContent
            // 
            this.dgvContent.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvContent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ma,
            this.DaKetThuc,
            this.SoLuongHocSinh,
            this.TenMonHoc,
            this.TenKhoaHoc,
            this.GiaoVien,
            this.HocPhiMotBuoi,
            this.MucHocPhi});
            this.dgvContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvContent.Location = new System.Drawing.Point(2, 2);
            this.dgvContent.Name = "dgvContent";
            this.dgvContent.Size = new System.Drawing.Size(858, 375);
            this.dgvContent.TabIndex = 0;
            // 
            // Ma
            // 
            this.Ma.DataPropertyName = "Ma";
            this.Ma.HeaderText = "Ma";
            this.Ma.Name = "Ma";
            // 
            // DaKetThuc
            // 
            this.DaKetThuc.DataPropertyName = "DaKetThuc";
            this.DaKetThuc.HeaderText = "DaKetThuc";
            this.DaKetThuc.Name = "DaKetThuc";
            // 
            // SoLuongHocSinh
            // 
            this.SoLuongHocSinh.DataPropertyName = "SoLuongHocSinh";
            this.SoLuongHocSinh.HeaderText = "So hoc sinh";
            this.SoLuongHocSinh.Name = "SoLuongHocSinh";
            // 
            // TenMonHoc
            // 
            this.TenMonHoc.DataPropertyName = "MonHoc";
            this.TenMonHoc.HeaderText = "Mon hoc";
            this.TenMonHoc.Name = "TenMonHoc";
            // 
            // TenKhoaHoc
            // 
            this.TenKhoaHoc.DataPropertyName = "KhoaHoc";
            this.TenKhoaHoc.HeaderText = "Khoa hoc";
            this.TenKhoaHoc.Name = "TenKhoaHoc";
            // 
            // GiaoVien
            // 
            this.GiaoVien.DataPropertyName = "GiaoVien";
            this.GiaoVien.HeaderText = "Giao vien";
            this.GiaoVien.Name = "GiaoVien";
            // 
            // HocPhiMotBuoi
            // 
            this.HocPhiMotBuoi.DataPropertyName = "HocPhiMotBuoi";
            this.HocPhiMotBuoi.HeaderText = "Hoc phi mot buoi";
            this.HocPhiMotBuoi.Name = "HocPhiMotBuoi";
            // 
            // MucHocPhi
            // 
            this.MucHocPhi.DataPropertyName = "MucHocPhi";
            this.MucHocPhi.HeaderText = "Muc hoc phi (%)";
            this.MucHocPhi.Name = "MucHocPhi";
            // 
            // frmAdminClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 551);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmAdminClass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdminClass";
            this.Load += new System.EventHandler(this.frmAdminClass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.DataGridView dgvContent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DaKetThuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongHocSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMonHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhoaHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaoVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn HocPhiMotBuoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn MucHocPhi;
    }
}