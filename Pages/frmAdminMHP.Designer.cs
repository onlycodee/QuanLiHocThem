
namespace QuanLiHocThem.Pages
{
    partial class frmAdminMHP
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
            this.dgvContent = new System.Windows.Forms.DataGridView();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.tbMhp = new System.Windows.Forms.TextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.mucHocPhiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.giaoVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khoaHocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.monHocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mucHocPhiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giaoVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoaHocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monHocBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvContent
            // 
            this.dgvContent.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvContent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvContent.Location = new System.Drawing.Point(2, 2);
            this.dgvContent.Name = "dgvContent";
            this.dgvContent.Size = new System.Drawing.Size(796, 198);
            this.dgvContent.TabIndex = 0;
            this.dgvContent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContent_CellClick);
            this.dgvContent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContent_CellContentClick);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.dgvContent);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 248);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(800, 202);
            this.panelControl2.TabIndex = 6;
            this.panelControl2.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl2_Paint);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panelControl4);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(800, 248);
            this.panelControl1.TabIndex = 5;
            this.panelControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl1_Paint);
            // 
            // panelControl4
            // 
            this.panelControl4.AutoSize = true;
            this.panelControl4.Controls.Add(this.simpleButton1);
            this.panelControl4.Controls.Add(this.tbMhp);
            this.panelControl4.Controls.Add(this.labelControl1);
            this.panelControl4.Controls.Add(this.labelControl6);
            this.panelControl4.Controls.Add(this.btnXoa);
            this.panelControl4.Controls.Add(this.simpleButton2);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl4.Location = new System.Drawing.Point(2, 2);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(796, 244);
            this.panelControl4.TabIndex = 17;
            this.panelControl4.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl4_Paint);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(301, 197);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 13;
            this.simpleButton1.Text = "Reset";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // tbMhp
            // 
            this.tbMhp.Location = new System.Drawing.Point(178, 142);
            this.tbMhp.Name = "tbMhp";
            this.tbMhp.Size = new System.Drawing.Size(192, 21);
            this.tbMhp.TabIndex = 12;
            this.tbMhp.TextChanged += new System.EventHandler(this.tbMhp_TextChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(178, 79);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(206, 24);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Danh sach muc hoc phi";
            this.labelControl1.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(116, 145);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(56, 13);
            this.labelControl6.TabIndex = 11;
            this.labelControl6.Text = "Muc hoc phi";
            this.labelControl6.Click += new System.EventHandler(this.labelControl6_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(220, 197);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xoa ";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(139, 197);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 1;
            this.simpleButton2.Text = "Luu ";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // mucHocPhiBindingSource
            // 
            this.mucHocPhiBindingSource.DataSource = typeof(QuanLiHocThem.MucHocPhi);
            this.mucHocPhiBindingSource.CurrentChanged += new System.EventHandler(this.mucHocPhiBindingSource_CurrentChanged);
            // 
            // giaoVienBindingSource
            // 
            this.giaoVienBindingSource.DataSource = typeof(QuanLiHocThem.GiaoVien);
            this.giaoVienBindingSource.CurrentChanged += new System.EventHandler(this.giaoVienBindingSource_CurrentChanged);
            // 
            // khoaHocBindingSource
            // 
            this.khoaHocBindingSource.DataSource = typeof(QuanLiHocThem.KhoaHoc);
            this.khoaHocBindingSource.CurrentChanged += new System.EventHandler(this.khoaHocBindingSource_CurrentChanged);
            // 
            // monHocBindingSource
            // 
            this.monHocBindingSource.DataSource = typeof(QuanLiHocThem.MonHoc);
            this.monHocBindingSource.CurrentChanged += new System.EventHandler(this.monHocBindingSource_CurrentChanged);
            // 
            // frmAdminMHP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmAdminMHP";
            this.Text = "frmAdminMHP";
            this.Load += new System.EventHandler(this.frmAdminMHP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.panelControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mucHocPhiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giaoVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoaHocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monHocBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvContent;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.TextBox tbMhp;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.BindingSource mucHocPhiBindingSource;
        private System.Windows.Forms.BindingSource giaoVienBindingSource;
        private System.Windows.Forms.BindingSource khoaHocBindingSource;
        private System.Windows.Forms.BindingSource monHocBindingSource;
    }
}