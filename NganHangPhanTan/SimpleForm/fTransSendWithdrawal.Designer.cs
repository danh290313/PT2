
namespace NganHangPhanTan.SimpleForm
{
    partial class fTransSendWithdrawal
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
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label sOTIENLabel;
            System.Windows.Forms.Label nGAYGDLabel;
            System.Windows.Forms.Label lOAIGDLabel;
            System.Windows.Forms.Label sOTKLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fTransSendWithdrawal));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cbBrand = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DS = new NganHangPhanTan.DS();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.pnInput = new System.Windows.Forms.Panel();
            this.teLoaiGD = new DevExpress.XtraEditors.TextEdit();
            this.gD_GOIRUTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taiKhoanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teSoTien = new DevExpress.XtraEditors.TextEdit();
            this.teMaNV = new DevExpress.XtraEditors.TextEdit();
            this.deNgayGD = new DevExpress.XtraEditors.DateEdit();
            this.teSoTK = new DevExpress.XtraEditors.TextEdit();
            this.cbTransTypeName = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReload = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnInsert = new DevExpress.XtraEditors.SimpleButton();
            this.pnBody = new System.Windows.Forms.Panel();
            this.gcGoiRut = new DevExpress.XtraGrid.GridControl();
            this.gvGoiRut = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAGD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTK1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLOAIGD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYGD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTIEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcTaiKhoan = new DevExpress.XtraGrid.GridControl();
            this.gvTaiKhoan = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSOTK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCMND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSODU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.taiKhoanTableAdapter = new NganHangPhanTan.DSTableAdapters.TaiKhoanTableAdapter();
            this.gD_GOIRUTTableAdapter = new NganHangPhanTan.DSTableAdapters.GD_GOIRUTTableAdapter();
            this.tableAdapterManager = new NganHangPhanTan.DSTableAdapters.TableAdapterManager();
            mANVLabel = new System.Windows.Forms.Label();
            sOTIENLabel = new System.Windows.Forms.Label();
            nGAYGDLabel = new System.Windows.Forms.Label();
            lOAIGDLabel = new System.Windows.Forms.Label();
            sOTKLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.pnInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teLoaiGD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD_GOIRUTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teSoTien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teMaNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayGD.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayGD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teSoTK.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcGoiRut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvGoiRut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTaiKhoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTaiKhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mANVLabel.Location = new System.Drawing.Point(10, 119);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(145, 30);
            mANVLabel.TabIndex = 29;
            mANVLabel.Text = "Mã nhân viên:";
            // 
            // sOTIENLabel
            // 
            sOTIENLabel.AutoSize = true;
            sOTIENLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sOTIENLabel.Location = new System.Drawing.Point(777, 34);
            sOTIENLabel.Name = "sOTIENLabel";
            sOTIENLabel.Size = new System.Drawing.Size(82, 30);
            sOTIENLabel.TabIndex = 26;
            sOTIENLabel.Text = "Số tiền:";
            // 
            // nGAYGDLabel
            // 
            nGAYGDLabel.AutoSize = true;
            nGAYGDLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nGAYGDLabel.Location = new System.Drawing.Point(369, 119);
            nGAYGDLabel.Name = "nGAYGDLabel";
            nGAYGDLabel.Size = new System.Drawing.Size(160, 30);
            nGAYGDLabel.TabIndex = 24;
            nGAYGDLabel.Text = "Ngày thực hiện:";
            // 
            // lOAIGDLabel
            // 
            lOAIGDLabel.AutoSize = true;
            lOAIGDLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lOAIGDLabel.Location = new System.Drawing.Point(68, 37);
            lOAIGDLabel.Name = "lOAIGDLabel";
            lOAIGDLabel.Size = new System.Drawing.Size(91, 30);
            lOAIGDLabel.TabIndex = 23;
            lOAIGDLabel.Text = "Loại GD:";
            // 
            // sOTKLabel
            // 
            sOTKLabel.AutoSize = true;
            sOTKLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sOTKLabel.Location = new System.Drawing.Point(376, 39);
            sOTKLabel.Name = "sOTKLabel";
            sOTKLabel.Size = new System.Drawing.Size(133, 30);
            sOTKLabel.TabIndex = 20;
            sOTKLabel.Text = "Số tài khoản:";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cbBrand);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1514, 68);
            this.panelControl1.TabIndex = 7;
            // 
            // cbBrand
            // 
            this.cbBrand.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBrand.FormattingEnabled = true;
            this.cbBrand.Location = new System.Drawing.Point(140, 24);
            this.cbBrand.Name = "cbBrand";
            this.cbBrand.Size = new System.Drawing.Size(391, 36);
            this.cbBrand.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chi nhánh:";
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.pnInput);
            this.groupControl2.Controls.Add(this.panel1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl2.Location = new System.Drawing.Point(0, 624);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1514, 435);
            this.groupControl2.TabIndex = 13;
            this.groupControl2.Text = "Thông tin giao dịch gửi/rút tiền";
            // 
            // pnInput
            // 
            this.pnInput.AutoScroll = true;
            this.pnInput.Controls.Add(this.teLoaiGD);
            this.pnInput.Controls.Add(this.teSoTien);
            this.pnInput.Controls.Add(this.teMaNV);
            this.pnInput.Controls.Add(this.deNgayGD);
            this.pnInput.Controls.Add(this.teSoTK);
            this.pnInput.Controls.Add(mANVLabel);
            this.pnInput.Controls.Add(sOTIENLabel);
            this.pnInput.Controls.Add(sOTKLabel);
            this.pnInput.Controls.Add(nGAYGDLabel);
            this.pnInput.Controls.Add(lOAIGDLabel);
            this.pnInput.Controls.Add(this.cbTransTypeName);
            this.pnInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnInput.Location = new System.Drawing.Point(2, 74);
            this.pnInput.Name = "pnInput";
            this.pnInput.Size = new System.Drawing.Size(1510, 359);
            this.pnInput.TabIndex = 19;
            // 
            // teLoaiGD
            // 
            this.teLoaiGD.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.gD_GOIRUTBindingSource, "LOAIGD", true));
            this.teLoaiGD.Location = new System.Drawing.Point(1006, 328);
            this.teLoaiGD.Name = "teLoaiGD";
            this.teLoaiGD.Size = new System.Drawing.Size(150, 28);
            this.teLoaiGD.TabIndex = 37;
            this.teLoaiGD.EditValueChanged += new System.EventHandler(this.teLoaiGD_EditValueChanged);
            // 
            // gD_GOIRUTBindingSource
            // 
            this.gD_GOIRUTBindingSource.DataMember = "FK_GD_GOIRUT_TaiKhoan";
            this.gD_GOIRUTBindingSource.DataSource = this.taiKhoanBindingSource;
            // 
            // taiKhoanBindingSource
            // 
            this.taiKhoanBindingSource.DataMember = "TaiKhoan";
            this.taiKhoanBindingSource.DataSource = this.DS;
            // 
            // teSoTien
            // 
            this.teSoTien.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.gD_GOIRUTBindingSource, "SOTIEN", true));
            this.teSoTien.Location = new System.Drawing.Point(883, 36);
            this.teSoTien.Name = "teSoTien";
            this.teSoTien.Properties.DisplayFormat.FormatString = "{0:c0}";
            this.teSoTien.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.teSoTien.Properties.EditFormat.FormatString = "{0:c0}";
            this.teSoTien.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.teSoTien.Size = new System.Drawing.Size(150, 28);
            this.teSoTien.TabIndex = 36;
            // 
            // teMaNV
            // 
            this.teMaNV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.gD_GOIRUTBindingSource, "MANV", true));
            this.teMaNV.Enabled = false;
            this.teMaNV.Location = new System.Drawing.Point(161, 122);
            this.teMaNV.Name = "teMaNV";
            this.teMaNV.Size = new System.Drawing.Size(150, 28);
            this.teMaNV.TabIndex = 35;
            // 
            // deNgayGD
            // 
            this.deNgayGD.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.gD_GOIRUTBindingSource, "NGAYGD", true));
            this.deNgayGD.EditValue = null;
            this.deNgayGD.Enabled = false;
            this.deNgayGD.Location = new System.Drawing.Point(535, 122);
            this.deNgayGD.Name = "deNgayGD";
            this.deNgayGD.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deNgayGD.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deNgayGD.Size = new System.Drawing.Size(150, 28);
            this.deNgayGD.TabIndex = 33;
            // 
            // teSoTK
            // 
            this.teSoTK.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.gD_GOIRUTBindingSource, "SOTK", true));
            this.teSoTK.Enabled = false;
            this.teSoTK.Location = new System.Drawing.Point(535, 37);
            this.teSoTK.Name = "teSoTK";
            this.teSoTK.Size = new System.Drawing.Size(150, 28);
            this.teSoTK.TabIndex = 32;
            // 
            // cbTransTypeName
            // 
            this.cbTransTypeName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTransTypeName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTransTypeName.FormattingEnabled = true;
            this.cbTransTypeName.Items.AddRange(new object[] {
            "Rút tiền",
            "Gửi tiền"});
            this.cbTransTypeName.Location = new System.Drawing.Point(169, 39);
            this.cbTransTypeName.Name = "cbTransTypeName";
            this.cbTransTypeName.Size = new System.Drawing.Size(170, 36);
            this.cbTransTypeName.TabIndex = 25;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnReload);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnInsert);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(2, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1510, 40);
            this.panel1.TabIndex = 11;
            // 
            // btnReload
            // 
            this.btnReload.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.Appearance.Options.UseFont = true;
            this.btnReload.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnReload.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.btnReload.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.ImageOptions.Image")));
            this.btnReload.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftBottom;
            this.btnReload.Location = new System.Drawing.Point(338, 0);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(119, 40);
            this.btnReload.TabIndex = 27;
            this.btnReload.Text = "Xem lại";
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSave.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.btnSave.ImageOptions.Image = global::NganHangPhanTan.Properties.Resources.diskette;
            this.btnSave.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftBottom;
            this.btnSave.Location = new System.Drawing.Point(230, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(108, 40);
            this.btnSave.TabIndex = 26;
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCancel.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.btnCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.ImageOptions.Image")));
            this.btnCancel.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftBottom;
            this.btnCancel.Location = new System.Drawing.Point(115, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(115, 40);
            this.btnCancel.TabIndex = 25;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Appearance.Options.UseFont = true;
            this.btnInsert.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnInsert.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.btnInsert.ImageOptions.Image = global::NganHangPhanTan.Properties.Resources.add;
            this.btnInsert.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftBottom;
            this.btnInsert.Location = new System.Drawing.Point(0, 0);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(115, 40);
            this.btnInsert.TabIndex = 11;
            this.btnInsert.Text = "Thêm";
            this.btnInsert.Click += new System.EventHandler(this.btnInsertAcc_Click);
            // 
            // pnBody
            // 
            this.pnBody.Controls.Add(this.gcGoiRut);
            this.pnBody.Controls.Add(this.gcTaiKhoan);
            this.pnBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBody.Location = new System.Drawing.Point(0, 68);
            this.pnBody.Name = "pnBody";
            this.pnBody.Size = new System.Drawing.Size(1514, 556);
            this.pnBody.TabIndex = 15;
            // 
            // gcGoiRut
            // 
            this.gcGoiRut.DataSource = this.gD_GOIRUTBindingSource;
            this.gcGoiRut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcGoiRut.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            gridLevelNode1.RelationName = "Level1";
            this.gcGoiRut.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gcGoiRut.Location = new System.Drawing.Point(738, 0);
            this.gcGoiRut.MainView = this.gvGoiRut;
            this.gcGoiRut.Name = "gcGoiRut";
            this.gcGoiRut.Size = new System.Drawing.Size(776, 556);
            this.gcGoiRut.TabIndex = 1;
            this.gcGoiRut.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvGoiRut});
            // 
            // gvGoiRut
            // 
            this.gvGoiRut.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAGD,
            this.colSOTK1,
            this.colLOAIGD,
            this.colNGAYGD,
            this.colSOTIEN,
            this.colMANV});
            this.gvGoiRut.GridControl = this.gcGoiRut;
            this.gvGoiRut.Name = "gvGoiRut";
            // 
            // colMAGD
            // 
            this.colMAGD.FieldName = "MAGD";
            this.colMAGD.MinWidth = 30;
            this.colMAGD.Name = "colMAGD";
            this.colMAGD.Visible = true;
            this.colMAGD.VisibleIndex = 0;
            this.colMAGD.Width = 112;
            // 
            // colSOTK1
            // 
            this.colSOTK1.FieldName = "SOTK";
            this.colSOTK1.MinWidth = 30;
            this.colSOTK1.Name = "colSOTK1";
            this.colSOTK1.Visible = true;
            this.colSOTK1.VisibleIndex = 1;
            this.colSOTK1.Width = 112;
            // 
            // colLOAIGD
            // 
            this.colLOAIGD.FieldName = "LOAIGD";
            this.colLOAIGD.MinWidth = 30;
            this.colLOAIGD.Name = "colLOAIGD";
            this.colLOAIGD.Visible = true;
            this.colLOAIGD.VisibleIndex = 2;
            this.colLOAIGD.Width = 112;
            // 
            // colNGAYGD
            // 
            this.colNGAYGD.FieldName = "NGAYGD";
            this.colNGAYGD.MinWidth = 30;
            this.colNGAYGD.Name = "colNGAYGD";
            this.colNGAYGD.Visible = true;
            this.colNGAYGD.VisibleIndex = 3;
            this.colNGAYGD.Width = 112;
            // 
            // colSOTIEN
            // 
            this.colSOTIEN.FieldName = "SOTIEN";
            this.colSOTIEN.MinWidth = 30;
            this.colSOTIEN.Name = "colSOTIEN";
            this.colSOTIEN.Visible = true;
            this.colSOTIEN.VisibleIndex = 4;
            this.colSOTIEN.Width = 112;
            // 
            // colMANV
            // 
            this.colMANV.FieldName = "MANV";
            this.colMANV.MinWidth = 30;
            this.colMANV.Name = "colMANV";
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 5;
            this.colMANV.Width = 112;
            // 
            // gcTaiKhoan
            // 
            this.gcTaiKhoan.DataSource = this.taiKhoanBindingSource;
            this.gcTaiKhoan.Dock = System.Windows.Forms.DockStyle.Left;
            this.gcTaiKhoan.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.gcTaiKhoan.Location = new System.Drawing.Point(0, 0);
            this.gcTaiKhoan.MainView = this.gvTaiKhoan;
            this.gcTaiKhoan.Name = "gcTaiKhoan";
            this.gcTaiKhoan.Size = new System.Drawing.Size(738, 556);
            this.gcTaiKhoan.TabIndex = 0;
            this.gcTaiKhoan.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTaiKhoan});
            // 
            // gvTaiKhoan
            // 
            this.gvTaiKhoan.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSOTK,
            this.colCMND,
            this.colSODU,
            this.colMACN});
            this.gvTaiKhoan.GridControl = this.gcTaiKhoan;
            this.gvTaiKhoan.Name = "gvTaiKhoan";
            // 
            // colSOTK
            // 
            this.colSOTK.Caption = "Số Tài khoản";
            this.colSOTK.FieldName = "SOTK";
            this.colSOTK.MinWidth = 30;
            this.colSOTK.Name = "colSOTK";
            this.colSOTK.Visible = true;
            this.colSOTK.VisibleIndex = 0;
            this.colSOTK.Width = 112;
            // 
            // colCMND
            // 
            this.colCMND.Caption = "CMND";
            this.colCMND.FieldName = "CMND";
            this.colCMND.MinWidth = 30;
            this.colCMND.Name = "colCMND";
            this.colCMND.Visible = true;
            this.colCMND.VisibleIndex = 1;
            this.colCMND.Width = 112;
            // 
            // colSODU
            // 
            this.colSODU.Caption = "Số Dư";
            this.colSODU.FieldName = "SODU";
            this.colSODU.MinWidth = 30;
            this.colSODU.Name = "colSODU";
            this.colSODU.Visible = true;
            this.colSODU.VisibleIndex = 2;
            this.colSODU.Width = 112;
            // 
            // colMACN
            // 
            this.colMACN.Caption = "Chi Nhánh";
            this.colMACN.FieldName = "MACN";
            this.colMACN.MinWidth = 30;
            this.colMACN.Name = "colMACN";
            this.colMACN.Visible = true;
            this.colMACN.VisibleIndex = 3;
            this.colMACN.Width = 112;
            // 
            // taiKhoanTableAdapter
            // 
            this.taiKhoanTableAdapter.ClearBeforeFill = true;
            // 
            // gD_GOIRUTTableAdapter
            // 
            this.gD_GOIRUTTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GD_CHUYENTIENTableAdapter = null;
            this.tableAdapterManager.GD_GOIRUTTableAdapter = this.gD_GOIRUTTableAdapter;
            this.tableAdapterManager.KhachHangTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.TaiKhoanTableAdapter = this.taiKhoanTableAdapter;
            this.tableAdapterManager.UpdateOrder = NganHangPhanTan.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // fTransSendWithdrawal
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1514, 1059);
            this.Controls.Add(this.pnBody);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.panelControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fTransSendWithdrawal";
            this.Text = "Giao dịch gửi rút tiền";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fTransSendWithdrawal_FormClosing);
            this.Load += new System.EventHandler(this.fTransSendWithdrawal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.pnInput.ResumeLayout(false);
            this.pnInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teLoaiGD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD_GOIRUTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teSoTien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teMaNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayGD.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayGD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teSoTK.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.pnBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcGoiRut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvGoiRut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTaiKhoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTaiKhoan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ComboBox cbBrand;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DS DS;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnInsert;
        private System.Windows.Forms.Panel pnBody;
        private System.Windows.Forms.Panel pnInput;
        private System.Windows.Forms.ComboBox cbTransTypeName;
        private DevExpress.XtraEditors.SimpleButton btnReload;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private System.Windows.Forms.BindingSource taiKhoanBindingSource;
        private DSTableAdapters.TaiKhoanTableAdapter taiKhoanTableAdapter;
        private DevExpress.XtraGrid.GridControl gcTaiKhoan;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTaiKhoan;
        private System.Windows.Forms.BindingSource gD_GOIRUTBindingSource;
        private DSTableAdapters.GD_GOIRUTTableAdapter gD_GOIRUTTableAdapter;
        private DevExpress.XtraGrid.GridControl gcGoiRut;
        private DevExpress.XtraGrid.Views.Grid.GridView gvGoiRut;
        private DevExpress.XtraEditors.DateEdit deNgayGD;
        private DevExpress.XtraEditors.TextEdit teSoTK;
        private DevExpress.XtraEditors.TextEdit teSoTien;
        private DevExpress.XtraEditors.TextEdit teMaNV;
        private DevExpress.XtraEditors.TextEdit teLoaiGD;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTK;
        private DevExpress.XtraGrid.Columns.GridColumn colCMND;
        private DevExpress.XtraGrid.Columns.GridColumn colSODU;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN;
        private DevExpress.XtraGrid.Columns.GridColumn colMAGD;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTK1;
        private DevExpress.XtraGrid.Columns.GridColumn colLOAIGD;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYGD;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTIEN;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
    }
}