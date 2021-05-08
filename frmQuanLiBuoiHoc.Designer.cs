
namespace QuanLiHocThem
{
    partial class frmQuanLiBuoiHoc
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
            this.components = new System.ComponentModel.Container();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.dgvContent = new System.Windows.Forms.DataGridView();
            this.MaBuoiHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHocSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DaDiemDanh = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.NgayHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CaHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoThuTu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMonHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemDanh = new System.Windows.Forms.DataGridViewButtonColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hocSinhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.btnDiemDanhTatCa = new System.Windows.Forms.Button();
            this.btnDatLai = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hocSinhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnDatLai);
            this.panelControl1.Controls.Add(this.btnDiemDanhTatCa);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1045, 126);
            this.panelControl1.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(483, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(102, 33);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Buoi hoc";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.dgvContent);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 126);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1045, 460);
            this.panelControl2.TabIndex = 1;
            // 
            // dgvContent
            // 
            this.dgvContent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaBuoiHoc,
            this.MaHocSinh,
            this.Ten,
            this.DaDiemDanh,
            this.NgayHoc,
            this.CaHoc,
            this.SoThuTu,
            this.TenMonHoc,
            this.NgaySinh,
            this.DiaChi,
            this.DiemDanh});
            this.dgvContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvContent.Location = new System.Drawing.Point(2, 2);
            this.dgvContent.Name = "dgvContent";
            this.dgvContent.Size = new System.Drawing.Size(1041, 456);
            this.dgvContent.TabIndex = 1;
            this.dgvContent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContent_CellContentClick);
            // 
            // MaBuoiHoc
            // 
            this.MaBuoiHoc.DataPropertyName = "MaBuoiHoc";
            this.MaBuoiHoc.HeaderText = "Ma buoi hoc";
            this.MaBuoiHoc.Name = "MaBuoiHoc";
            this.MaBuoiHoc.Visible = false;
            // 
            // MaHocSinh
            // 
            this.MaHocSinh.DataPropertyName = "MaHocSinh";
            this.MaHocSinh.HeaderText = "Ma hoc sinh";
            this.MaHocSinh.Name = "MaHocSinh";
            this.MaHocSinh.Visible = false;
            // 
            // Ten
            // 
            this.Ten.DataPropertyName = "TenHocSinh";
            this.Ten.HeaderText = "Tên";
            this.Ten.Name = "Ten";
            // 
            // DaDiemDanh
            // 
            this.DaDiemDanh.DataPropertyName = "DaDiemDanh";
            this.DaDiemDanh.HeaderText = "Đã điểm danh";
            this.DaDiemDanh.Name = "DaDiemDanh";
            // 
            // NgayHoc
            // 
            this.NgayHoc.DataPropertyName = "NgayHoc";
            this.NgayHoc.HeaderText = "Ngay hoc";
            this.NgayHoc.Name = "NgayHoc";
            // 
            // CaHoc
            // 
            this.CaHoc.DataPropertyName = "CaHoc";
            this.CaHoc.HeaderText = "Ca hoc";
            this.CaHoc.Name = "CaHoc";
            // 
            // SoThuTu
            // 
            this.SoThuTu.DataPropertyName = "BuoiHocThu";
            this.SoThuTu.HeaderText = "Buoi hoc thu";
            this.SoThuTu.Name = "SoThuTu";
            // 
            // TenMonHoc
            // 
            this.TenMonHoc.DataPropertyName = "TenMonHoc";
            this.TenMonHoc.HeaderText = "Ten mon hoc";
            this.TenMonHoc.Name = "TenMonHoc";
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngay sinh";
            this.NgaySinh.Name = "NgaySinh";
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Dia chi";
            this.DiaChi.Name = "DiaChi";
            // 
            // DiemDanh
            // 
            this.DiemDanh.HeaderText = "Diem danh";
            this.DiemDanh.Name = "DiemDanh";
            this.DiemDanh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DiemDanh.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.DiemDanh.Text = "Diem danh";
            this.DiemDanh.UseColumnTextForButtonValue = true;
            // 
            // hocSinhBindingSource
            // 
            this.hocSinhBindingSource.DataSource = typeof(QuanLiHocThem.HocSinh);
            // 
            // bindingSource2
            // 
            this.bindingSource2.DataSource = typeof(QuanLiHocThem.DiemDanh);
            // 
            // btnDiemDanhTatCa
            // 
            this.btnDiemDanhTatCa.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnDiemDanhTatCa.Location = new System.Drawing.Point(38, 59);
            this.btnDiemDanhTatCa.Name = "btnDiemDanhTatCa";
            this.btnDiemDanhTatCa.Size = new System.Drawing.Size(123, 33);
            this.btnDiemDanhTatCa.TabIndex = 1;
            this.btnDiemDanhTatCa.Text = "Diem danh tat ca";
            this.btnDiemDanhTatCa.UseVisualStyleBackColor = true;
            this.btnDiemDanhTatCa.Click += new System.EventHandler(this.btnDiemDanhTatCa_Click);
            // 
            // btnDatLai
            // 
            this.btnDatLai.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnDatLai.Location = new System.Drawing.Point(194, 59);
            this.btnDatLai.Name = "btnDatLai";
            this.btnDatLai.Size = new System.Drawing.Size(123, 33);
            this.btnDatLai.TabIndex = 2;
            this.btnDatLai.Text = "Dat lai";
            this.btnDatLai.UseVisualStyleBackColor = true;
            this.btnDatLai.Click += new System.EventHandler(this.btnDatLai_Click);
            // 
            // frmQuanLiBuoiHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 586);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelControl2);
            this.Name = "frmQuanLiBuoiHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmQuanLiBuoiHoc";
            this.Load += new System.EventHandler(this.frmQuanLiBuoiHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hocSinhBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridView dgvContent;
        private System.Windows.Forms.BindingSource hocSinhBindingSource;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBuoiHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHocSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DaDiemDanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn CaHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoThuTu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMonHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewButtonColumn DiemDanh;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Button btnDatLai;
        private System.Windows.Forms.Button btnDiemDanhTatCa;
    }
}