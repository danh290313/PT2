
namespace NganHangPhanTan.SimpleForm
{
    partial class fTransExchange
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fTransExchange));
            this.bdsCustomer = new System.Windows.Forms.BindingSource(this.components);
            this.DS = new NganHangPhanTan.DS();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cbBrand = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnBody = new System.Windows.Forms.Panel();
            this.pnTrans = new DevExpress.XtraEditors.GroupControl();
            this.gcChuyenTien = new DevExpress.XtraGrid.GridControl();
            this.gD_CHUYENTIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taiKhoanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvChuyenTien = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.gcTaiKhoan = new DevExpress.XtraGrid.GridControl();
            this.gvTaiKhoan = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bdsTrans = new System.Windows.Forms.BindingSource(this.components);
            this.bdsAccount = new System.Windows.Forms.BindingSource(this.components);
            this.gcEditEnpoint = new DevExpress.XtraEditors.GroupControl();
            this.pnInput = new System.Windows.Forms.Panel();
            this.gcEndpoints = new DevExpress.XtraGrid.GridControl();
            this.gvEndpoints = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnReload = new DevExpress.XtraEditors.SimpleButton();
            this.pnExchangeInfo = new System.Windows.Forms.Panel();
            this.btnCommit = new DevExpress.XtraEditors.SimpleButton();
            this.btnChangeEndpoints = new DevExpress.XtraEditors.SimpleButton();
            this.teRemainBalance = new DevExpress.XtraEditors.TextEdit();
            this.teInitBalance = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.taTrans = new NganHangPhanTan.DSTableAdapters.usp_GetTransExchangeByAccountIdTableAdapter();
            this.tableAdapterManager = new NganHangPhanTan.DSTableAdapters.TableAdapterManager();
            this.taCustomer = new NganHangPhanTan.DSTableAdapters.usp_GetCustomerHavingAccountInSubcriberTableAdapter();
            this.taAccount = new NganHangPhanTan.DSTableAdapters.usp_GetAccountByCustomerIdTableAdapter();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.taiKhoanTableAdapter = new NganHangPhanTan.DSTableAdapters.TaiKhoanTableAdapter();
            this.gD_CHUYENTIENTableAdapter = new NganHangPhanTan.DSTableAdapters.GD_CHUYENTIENTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.pnBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnTrans)).BeginInit();
            this.pnTrans.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcChuyenTien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD_CHUYENTIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvChuyenTien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcTaiKhoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTaiKhoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTrans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcEditEnpoint)).BeginInit();
            this.gcEditEnpoint.SuspendLayout();
            this.pnInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcEndpoints)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEndpoints)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnExchangeInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teRemainBalance.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teInitBalance.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bdsCustomer
            // 
            this.bdsCustomer.AllowNew = true;
            this.bdsCustomer.DataMember = "usp_GetCustomerHavingAccountInSubcriber";
            this.bdsCustomer.DataSource = this.DS;
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cbBrand);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1154, 59);
            this.panelControl1.TabIndex = 11;
            // 
            // cbBrand
            // 
            this.cbBrand.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBrand.FormattingEnabled = true;
            this.cbBrand.Location = new System.Drawing.Point(149, 9);
            this.cbBrand.Name = "cbBrand";
            this.cbBrand.Size = new System.Drawing.Size(391, 36);
            this.cbBrand.TabIndex = 1;
            this.cbBrand.SelectionChangeCommitted += new System.EventHandler(this.cbBrand_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chi nhánh:";
            // 
            // pnBody
            // 
            this.pnBody.Controls.Add(this.pnTrans);
            this.pnBody.Controls.Add(this.groupControl3);
            this.pnBody.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnBody.Location = new System.Drawing.Point(0, 59);
            this.pnBody.Name = "pnBody";
            this.pnBody.Size = new System.Drawing.Size(1154, 229);
            this.pnBody.TabIndex = 16;
            // 
            // pnTrans
            // 
            this.pnTrans.Controls.Add(this.gcChuyenTien);
            this.pnTrans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnTrans.Location = new System.Drawing.Point(670, 0);
            this.pnTrans.Name = "pnTrans";
            this.pnTrans.Size = new System.Drawing.Size(484, 229);
            this.pnTrans.TabIndex = 14;
            this.pnTrans.Text = "Giao dịch chuyển tiền của tài khoản";
            // 
            // gcChuyenTien
            // 
            this.gcChuyenTien.DataSource = this.gD_CHUYENTIENBindingSource;
            this.gcChuyenTien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcChuyenTien.Location = new System.Drawing.Point(2, 34);
            this.gcChuyenTien.MainView = this.gvChuyenTien;
            this.gcChuyenTien.Name = "gcChuyenTien";
            this.gcChuyenTien.Size = new System.Drawing.Size(480, 193);
            this.gcChuyenTien.TabIndex = 0;
            this.gcChuyenTien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvChuyenTien});
            // 
            // gD_CHUYENTIENBindingSource
            // 
            this.gD_CHUYENTIENBindingSource.DataMember = "FK_SOTKCHUYEN_TAIKHOAN";
            this.gD_CHUYENTIENBindingSource.DataSource = this.taiKhoanBindingSource;
            // 
            // taiKhoanBindingSource
            // 
            this.taiKhoanBindingSource.DataMember = "TaiKhoan";
            this.taiKhoanBindingSource.DataSource = this.DS;
            // 
            // gvChuyenTien
            // 
            this.gvChuyenTien.GridControl = this.gcChuyenTien;
            this.gvChuyenTien.Name = "gvChuyenTien";
            // 
            // groupControl3
            // 
            this.groupControl3.AllowTouchScroll = true;
            this.groupControl3.Controls.Add(this.gcTaiKhoan);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl3.Location = new System.Drawing.Point(0, 0);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(670, 229);
            this.groupControl3.TabIndex = 13;
            this.groupControl3.Text = "Danh sách tài khoản của khách hàng";
            this.groupControl3.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl3_Paint);
            // 
            // gcTaiKhoan
            // 
            this.gcTaiKhoan.DataSource = this.taiKhoanBindingSource;
            this.gcTaiKhoan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcTaiKhoan.Location = new System.Drawing.Point(2, 34);
            this.gcTaiKhoan.MainView = this.gvTaiKhoan;
            this.gcTaiKhoan.Name = "gcTaiKhoan";
            this.gcTaiKhoan.Size = new System.Drawing.Size(666, 193);
            this.gcTaiKhoan.TabIndex = 0;
            this.gcTaiKhoan.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTaiKhoan});
            // 
            // gvTaiKhoan
            // 
            this.gvTaiKhoan.GridControl = this.gcTaiKhoan;
            this.gvTaiKhoan.Name = "gvTaiKhoan";
            // 
            // bdsTrans
            // 
            this.bdsTrans.DataMember = "usp_GetTransExchangeByAccountId";
            this.bdsTrans.DataSource = this.DS;
            // 
            // bdsAccount
            // 
            this.bdsAccount.DataMember = "usp_GetAccountByCustomerId";
            this.bdsAccount.DataSource = this.DS;
            // 
            // gcEditEnpoint
            // 
            this.gcEditEnpoint.Controls.Add(this.pnInput);
            this.gcEditEnpoint.Location = new System.Drawing.Point(0, 414);
            this.gcEditEnpoint.Name = "gcEditEnpoint";
            this.gcEditEnpoint.Size = new System.Drawing.Size(1154, 359);
            this.gcEditEnpoint.TabIndex = 17;
            this.gcEditEnpoint.Text = "Danh sách tài khoản cần chuyển";
            // 
            // pnInput
            // 
            this.pnInput.Controls.Add(this.gcEndpoints);
            this.pnInput.Controls.Add(this.panel2);
            this.pnInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnInput.Location = new System.Drawing.Point(2, 34);
            this.pnInput.Name = "pnInput";
            this.pnInput.Size = new System.Drawing.Size(1150, 323);
            this.pnInput.TabIndex = 19;
            // 
            // gcEndpoints
            // 
            this.gcEndpoints.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcEndpoints.Location = new System.Drawing.Point(0, 0);
            this.gcEndpoints.MainView = this.gvEndpoints;
            this.gcEndpoints.Name = "gcEndpoints";
            this.gcEndpoints.Size = new System.Drawing.Size(766, 323);
            this.gcEndpoints.TabIndex = 5;
            this.gcEndpoints.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvEndpoints});
            this.gcEndpoints.Click += new System.EventHandler(this.gcEndpoints_Click);
            // 
            // gvEndpoints
            // 
            this.gvEndpoints.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvEndpoints.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvEndpoints.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvEndpoints.Appearance.Row.Options.UseFont = true;
            this.gvEndpoints.GridControl = this.gcEndpoints;
            this.gvEndpoints.Name = "gvEndpoints";
            this.gvEndpoints.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.gvEndpoints_InvalidRowException);
            this.gvEndpoints.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gvEndpoints_ValidateRow);
            this.gvEndpoints.ValidatingEditor += new DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(this.gvEndpoints_ValidatingEditor);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnReload);
            this.panel2.Controls.Add(this.pnExchangeInfo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(766, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(384, 323);
            this.panel2.TabIndex = 4;
            // 
            // btnReload
            // 
            this.btnReload.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.Appearance.Options.UseFont = true;
            this.btnReload.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.btnReload.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.ImageOptions.Image")));
            this.btnReload.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftBottom;
            this.btnReload.Location = new System.Drawing.Point(38, 163);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(297, 36);
            this.btnReload.TabIndex = 12;
            this.btnReload.Text = "Reload";
            this.btnReload.Click += new System.EventHandler(this.btnReload2_Click);
            // 
            // pnExchangeInfo
            // 
            this.pnExchangeInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnExchangeInfo.Controls.Add(this.btnCommit);
            this.pnExchangeInfo.Controls.Add(this.btnChangeEndpoints);
            this.pnExchangeInfo.Controls.Add(this.teRemainBalance);
            this.pnExchangeInfo.Controls.Add(this.teInitBalance);
            this.pnExchangeInfo.Controls.Add(this.label3);
            this.pnExchangeInfo.Controls.Add(this.label2);
            this.pnExchangeInfo.Location = new System.Drawing.Point(6, 3);
            this.pnExchangeInfo.Name = "pnExchangeInfo";
            this.pnExchangeInfo.Size = new System.Drawing.Size(375, 154);
            this.pnExchangeInfo.TabIndex = 4;
            // 
            // btnCommit
            // 
            this.btnCommit.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCommit.Appearance.Options.UseFont = true;
            this.btnCommit.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.btnCommit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCommit.ImageOptions.Image")));
            this.btnCommit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftBottom;
            this.btnCommit.Location = new System.Drawing.Point(202, 104);
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.Size = new System.Drawing.Size(126, 36);
            this.btnCommit.TabIndex = 14;
            this.btnCommit.Text = "Xác nhận";
            this.btnCommit.Click += new System.EventHandler(this.btnCommit_Click);
            // 
            // btnChangeEndpoints
            // 
            this.btnChangeEndpoints.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeEndpoints.Appearance.Options.UseFont = true;
            this.btnChangeEndpoints.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.btnChangeEndpoints.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnChangeEndpoints.ImageOptions.Image")));
            this.btnChangeEndpoints.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftBottom;
            this.btnChangeEndpoints.Location = new System.Drawing.Point(16, 104);
            this.btnChangeEndpoints.Name = "btnChangeEndpoints";
            this.btnChangeEndpoints.Size = new System.Drawing.Size(126, 36);
            this.btnChangeEndpoints.TabIndex = 13;
            this.btnChangeEndpoints.Text = "Hiệu chỉnh";
            this.btnChangeEndpoints.Click += new System.EventHandler(this.btnChangeEndpoints_Click);
            // 
            // teRemainBalance
            // 
            this.teRemainBalance.Location = new System.Drawing.Point(154, 55);
            this.teRemainBalance.Name = "teRemainBalance";
            this.teRemainBalance.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teRemainBalance.Properties.Appearance.Options.UseFont = true;
            this.teRemainBalance.Properties.DisplayFormat.FormatString = "{0:c0}";
            this.teRemainBalance.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.teRemainBalance.Properties.EditFormat.FormatString = "{0:c0}";
            this.teRemainBalance.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.teRemainBalance.Properties.Mask.EditMask = "c0";
            this.teRemainBalance.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.teRemainBalance.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.teRemainBalance.Properties.ReadOnly = true;
            this.teRemainBalance.Size = new System.Drawing.Size(174, 36);
            this.teRemainBalance.TabIndex = 3;
            // 
            // teInitBalance
            // 
            this.teInitBalance.Location = new System.Drawing.Point(154, 8);
            this.teInitBalance.Name = "teInitBalance";
            this.teInitBalance.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teInitBalance.Properties.Appearance.Options.UseFont = true;
            this.teInitBalance.Properties.DisplayFormat.FormatString = "{0:c0}";
            this.teInitBalance.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.teInitBalance.Properties.EditFormat.FormatString = "{0:c0}";
            this.teInitBalance.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.teInitBalance.Properties.Mask.EditMask = "c0";
            this.teInitBalance.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.teInitBalance.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.teInitBalance.Properties.ReadOnly = true;
            this.teInitBalance.Size = new System.Drawing.Size(174, 36);
            this.teInitBalance.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 30);
            this.label3.TabIndex = 1;
            this.label3.Text = "Số dư sau:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số dư đầu:";
            // 
            // taTrans
            // 
            this.taTrans.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.GD_CHUYENTIENTableAdapter = null;
            this.tableAdapterManager.GD_GOIRUTTableAdapter = null;
            this.tableAdapterManager.KhachHangTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.TaiKhoanTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = NganHangPhanTan.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // taCustomer
            // 
            this.taCustomer.ClearBeforeFill = true;
            // 
            // taAccount
            // 
            this.taAccount.ClearBeforeFill = true;
            // 
            // gridView1
            // 
            this.gridView1.Name = "gridView1";
            // 
            // taiKhoanTableAdapter
            // 
            this.taiKhoanTableAdapter.ClearBeforeFill = true;
            // 
            // gD_CHUYENTIENTableAdapter
            // 
            this.gD_CHUYENTIENTableAdapter.ClearBeforeFill = true;
            // 
            // fTransExchange
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 773);
            this.Controls.Add(this.gcEditEnpoint);
            this.Controls.Add(this.pnBody);
            this.Controls.Add(this.panelControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fTransExchange";
            this.Text = "Giao dịch chuyển tiền";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fTransExchange_FormClosing);
            this.Load += new System.EventHandler(this.fTransExchange_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdsCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.pnBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnTrans)).EndInit();
            this.pnTrans.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcChuyenTien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD_CHUYENTIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvChuyenTien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcTaiKhoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTaiKhoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTrans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcEditEnpoint)).EndInit();
            this.gcEditEnpoint.ResumeLayout(false);
            this.pnInput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcEndpoints)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEndpoints)).EndInit();
            this.panel2.ResumeLayout(false);
            this.pnExchangeInfo.ResumeLayout(false);
            this.pnExchangeInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teRemainBalance.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teInitBalance.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ComboBox cbBrand;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnBody;
        private DevExpress.XtraEditors.GroupControl pnTrans;
        private DevExpress.XtraEditors.GroupControl gcEditEnpoint;
        private System.Windows.Forms.Panel pnInput;
        private DS DS;
        private System.Windows.Forms.BindingSource bdsTrans;
        private DSTableAdapters.usp_GetTransExchangeByAccountIdTableAdapter taTrans;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource bdsCustomer;
        private DSTableAdapters.usp_GetCustomerHavingAccountInSubcriberTableAdapter taCustomer;
        private System.Windows.Forms.BindingSource bdsAccount;
        private DSTableAdapters.usp_GetAccountByCustomerIdTableAdapter taAccount;
        private DevExpress.XtraGrid.GridControl gcEndpoints;
        private DevExpress.XtraGrid.Views.Grid.GridView gvEndpoints;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnExchangeInfo;
        private DevExpress.XtraEditors.TextEdit teRemainBalance;
        private DevExpress.XtraEditors.TextEdit teInitBalance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton btnReload;
        private DevExpress.XtraEditors.SimpleButton btnCommit;
        private DevExpress.XtraEditors.SimpleButton btnChangeEndpoints;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource taiKhoanBindingSource;
        private DSTableAdapters.TaiKhoanTableAdapter taiKhoanTableAdapter;
        private DevExpress.XtraGrid.GridControl gcTaiKhoan;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTaiKhoan;
        private System.Windows.Forms.BindingSource gD_CHUYENTIENBindingSource;
        private DSTableAdapters.GD_CHUYENTIENTableAdapter gD_CHUYENTIENTableAdapter;
        private DevExpress.XtraGrid.GridControl gcChuyenTien;
        private DevExpress.XtraGrid.Views.Grid.GridView gvChuyenTien;
    }
}