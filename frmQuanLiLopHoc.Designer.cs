
namespace QuanLiHocThem
{
    partial class frmQuanLiLopHoc
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
            this.ChiTiet = new System.Windows.Forms.DataGridViewButtonColumn();
            this.maDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayHocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maLopHocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maCaHocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soThuTuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buoiHocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.caHocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lopHocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buoiHocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.caHocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopHocBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(950, 91);
            this.panelControl1.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(414, 31);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(169, 33);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Lich giang day";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.dgvContent);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 91);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(950, 563);
            this.panelControl2.TabIndex = 1;
            // 
            // dgvContent
            // 
            this.dgvContent.AutoGenerateColumns = false;
            this.dgvContent.BackgroundColor = System.Drawing.Color.White;
            this.dgvContent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maDataGridViewTextBoxColumn,
            this.ngayHocDataGridViewTextBoxColumn,
            this.maLopHocDataGridViewTextBoxColumn,
            this.maCaHocDataGridViewTextBoxColumn,
            this.soThuTuDataGridViewTextBoxColumn,
            this.ChiTiet});
            this.dgvContent.DataSource = this.buoiHocBindingSource;
            this.dgvContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvContent.GridColor = System.Drawing.Color.LightGray;
            this.dgvContent.Location = new System.Drawing.Point(2, 2);
            this.dgvContent.Name = "dgvContent";
            this.dgvContent.Size = new System.Drawing.Size(946, 559);
            this.dgvContent.TabIndex = 0;
            this.dgvContent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ChiTiet
            // 
            this.ChiTiet.HeaderText = "Chi tiet";
            this.ChiTiet.Name = "ChiTiet";
            this.ChiTiet.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ChiTiet.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ChiTiet.Text = "Chi tiet";
            this.ChiTiet.UseColumnTextForButtonValue = true;
            // 
            // maDataGridViewTextBoxColumn
            // 
            this.maDataGridViewTextBoxColumn.DataPropertyName = "Ma";
            this.maDataGridViewTextBoxColumn.HeaderText = "Ma";
            this.maDataGridViewTextBoxColumn.Name = "maDataGridViewTextBoxColumn";
            this.maDataGridViewTextBoxColumn.Width = 200;
            // 
            // ngayHocDataGridViewTextBoxColumn
            // 
            this.ngayHocDataGridViewTextBoxColumn.DataPropertyName = "NgayHoc";
            this.ngayHocDataGridViewTextBoxColumn.HeaderText = "NgayHoc";
            this.ngayHocDataGridViewTextBoxColumn.Name = "ngayHocDataGridViewTextBoxColumn";
            this.ngayHocDataGridViewTextBoxColumn.Width = 150;
            // 
            // maLopHocDataGridViewTextBoxColumn
            // 
            this.maLopHocDataGridViewTextBoxColumn.DataPropertyName = "MaLopHoc";
            this.maLopHocDataGridViewTextBoxColumn.HeaderText = "MaLopHoc";
            this.maLopHocDataGridViewTextBoxColumn.Name = "maLopHocDataGridViewTextBoxColumn";
            this.maLopHocDataGridViewTextBoxColumn.Width = 150;
            // 
            // maCaHocDataGridViewTextBoxColumn
            // 
            this.maCaHocDataGridViewTextBoxColumn.DataPropertyName = "MaCaHoc";
            this.maCaHocDataGridViewTextBoxColumn.HeaderText = "MaCaHoc";
            this.maCaHocDataGridViewTextBoxColumn.Name = "maCaHocDataGridViewTextBoxColumn";
            this.maCaHocDataGridViewTextBoxColumn.Width = 150;
            // 
            // soThuTuDataGridViewTextBoxColumn
            // 
            this.soThuTuDataGridViewTextBoxColumn.DataPropertyName = "SoThuTu";
            this.soThuTuDataGridViewTextBoxColumn.HeaderText = "SoThuTu";
            this.soThuTuDataGridViewTextBoxColumn.Name = "soThuTuDataGridViewTextBoxColumn";
            this.soThuTuDataGridViewTextBoxColumn.Width = 150;
            // 
            // buoiHocBindingSource
            // 
            this.buoiHocBindingSource.DataSource = typeof(QuanLiHocThem.BuoiHoc);
            // 
            // caHocBindingSource
            // 
            this.caHocBindingSource.DataSource = typeof(QuanLiHocThem.CaHoc);
            // 
            // lopHocBindingSource
            // 
            this.lopHocBindingSource.DataSource = typeof(QuanLiHocThem.LopHoc);
            // 
            // frmQuanLiLopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 654);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmQuanLiLopHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmQuanLiLopHoc";
            this.Load += new System.EventHandler(this.frmQuanLiLopHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buoiHocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.caHocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopHocBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.DataGridView dgvContent;
        private System.Windows.Forms.BindingSource buoiHocBindingSource;
        private System.Windows.Forms.BindingSource caHocBindingSource;
        private System.Windows.Forms.BindingSource lopHocBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayHocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLopHocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maCaHocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soThuTuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn ChiTiet;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}