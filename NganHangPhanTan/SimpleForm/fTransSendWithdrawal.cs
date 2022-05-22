using NganHangPhanTan.DAO;
using NganHangPhanTan.DTO;
using NganHangPhanTan.Util;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace NganHangPhanTan.SimpleForm
{
    public partial class fTransSendWithdrawal : DevExpress.XtraEditors.XtraForm
    {
        private Action<Form, bool> reqUpdateCanCloseState;
        private Action<Form> reqClose;

        public Action<Form, bool> ReqUpdateCanCloseState { get => reqUpdateCanCloseState; set => reqUpdateCanCloseState = value; }
        public Action<Form> ReqClose { get => reqClose; set => reqClose = value; }

        public fTransSendWithdrawal()
        {
            InitializeComponent();
        }

        private void fTransSendWithdrawal_Load(object sender, EventArgs e)
        {

            DS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'DS.GD_CHUYENTIEN' table. You can move, or remove it, as needed.
            // this.gD_CHUYENTIENTableAdapter.Fill(this.DS.GD_CHUYENTIEN);
            // TODO: This line of code loads data into the 'DS.GD_GOIRUT' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'DS.TaiKhoan' table. You can move, or remove it, as needed.
           // this.taiKhoanTableAdapter.Fill(this.DS.TaiKhoan);
            //this.taCustomer.Connection.ConnectionString = Program.ConnectionStr;
            // this.taCustomer.Fill(this.DS.usp_GetCustomerHavingAccountInSubcriber);

            this.taiKhoanTableAdapter.Connection.ConnectionString = Program.ConnectionStr;
            this.taiKhoanTableAdapter.Fill(this.DS.TaiKhoan);
            this.gD_GOIRUTTableAdapter.Connection.ConnectionString = Program.ConnectionStr;
            this.gD_GOIRUTTableAdapter.Fill(this.DS.GD_GOIRUT);

            //this.taTrans.Connection.ConnectionString = Program.ConnectionStr;

            cbBrand.DataSource = Program.bindingSource;/*sao chep bingding source tu form dang nhap*/
            cbBrand.DisplayMember = "TENCN";
            cbBrand.ValueMember = "TENSERVER";
            cbBrand.SelectedIndex = Program.brand;

            cbBrand.SelectedIndex = SecurityContext.User.BrandIndex;

            switch (SecurityContext.User.Group)
            {
                case DTO.User.GroupENM.NGAN_HANG:
                    cbBrand.Enabled = true;
                    btnInsert.Enabled = false;
                    break;
                case DTO.User.GroupENM.CHI_NHANH:
                    cbBrand.Enabled = false;
                    btnInsert.Enabled = true;
                    break;
                default:
                    // DEBUG
                    throw new Exception("User group is unidentified");
            }

            btnReload.Enabled = true;
            btnCancel.Enabled = btnSave.Enabled = false;
           // cbBrand_SelectionChangeCommitted(null, null);
        }

        //private void LoadAccountFromCustomer()
        //{
        //    if (bdsCustomer.Count > 0)
        //    {
        //        string customerId = ((DataRowView)bdsCustomer.Current)[Customer.ID_HEADER].ToString();
        //        try
        //        {
        //            this.taAccount.Fill(this.DS.usp_GetAccountByCustomerId, customerId);
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageUtil.ShowErrorMsgDialog(ex.Message);
        //        }
        //    }
        //}

        private void gvCustomer_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            //LoadAccountFromCustomer();
        }

        //private void LoadTransFromAccount()
        //{
        //    if (bdsAccount.Count > 0)
        //    {
        //        string accountId = ((DataRowView)bdsAccount.Current)[Account.ID_HEADER].ToString();
        //        try
        //        {
        //            this.taTrans.Fill(this.DS.usp_GetTransSendWithdrawalByAccountId, accountId);
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageUtil.ShowErrorMsgDialog(ex.Message);
        //        }
        //    }
        //    pnInput.Enabled = btnSave.Enabled = false;
        //}

        //private void gvAccount_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        //{
        //    if (bdsAccount.Count > 0)
        //        teAccountId.Text = ((DataRowView)bdsAccount.Current)[Account.ID_HEADER].ToString();
        //    else
        //        teAccountId.Text = null;

        //    LoadTransFromAccount();
        //}

        //private void cbBrand_SelectionChangeCommitted(object sender, EventArgs e)
        //{
        //    // Nếu combobox chi nhánh chưa load danh sách phân mãnh thì thoát
        //    if (cbBrand.SelectedValue.ToString().Equals("System.Data.RowView"))
        //        return;
        //    string serverName = cbBrand.SelectedValue.ToString();
        //    User user = SecurityContext.User;
        //    if (cbBrand.SelectedIndex != user.BrandIndex)
        //        Program.SetServerToRemote(serverName);
        //    else
        //        Program.SetServerToSubcriber(serverName, user.Login, user.Pass);
        //    if (Program.CheckConnection() == false)
        //    {
        //        MessageBox.Show("Lỗi kết nối sang chi nhánh mới.");
        //        return;
        //    }

        //    // Load lại dữ liệu khách hàng
        //    //this.taCustomer.Connection.ConnectionString = Program.ConnectionStr;
        //   // this.taCustomer.Fill(this.DS.usp_GetCustomerHavingAccountInSubcriber);

        //   // this.taAccount.Connection.ConnectionString = Program.ConnectionStr;

        //  //  this.taTrans.Connection.ConnectionString = Program.ConnectionStr;

        //    // Load lại dữ liệu tài khoản theo khách hàng
        //    //LoadAccountFromCustomer();
        //    // Load lại dữ liệu giao dich theo tài khoản
        //    LoadTransFromAccount();
        //}

        private void btnInsertAcc_Click(object sender, EventArgs e)
        {
            gD_GOIRUTBindingSource.AddNew();

            pnInput.Enabled = true;
            gcTaiKhoan.Enabled = gcGoiRut.Enabled= false;

            cbTransTypeName.SelectedIndex = 0;
            teSoTK.Text = ((DataRowView)taiKhoanBindingSource.Current)[Account.ID_HEADER].ToString();
            teMaNV.Text = SecurityContext.User.Username;
            deNgayGD.DateTime = DateTime.Now;

            btnInsert.Enabled = btnReload.Enabled = false;
            btnCancel.Enabled = btnSave.Enabled = true;

            ReqUpdateCanCloseState.Invoke(this, false);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(teSoTien.EditValue.ToString()))
            {
                MessageUtil.ShowErrorMsgDialog("Vui lòng điền số tiền cần thực hiện giao dịch");
                return;
            }

            double amount = double.Parse(teSoTien.EditValue.ToString());

            if (amount < 50000)
            {
                MessageUtil.ShowErrorMsgDialog("Số tiền giao dịch cần tối thiểu là 50.000 đ");
                return;
            }

            string accountId = teSoTK.Text;

            string transTypeName = cbTransTypeName.Text;
            string transTypeCode = "";
            if (transTypeName.StartsWith("R"))
                transTypeCode = "RT";
            else if (transTypeName.StartsWith("G"))
                transTypeCode = "GT";

            double balance = double.Parse(((DataRowView)taiKhoanBindingSource.Current)[Account.BALANCE_HEADER].ToString());

            if (transTypeCode.Equals("RT") && balance < amount)
            {
                MessageUtil.ShowErrorMsgDialog("Số dư tài khoản không đủ để thực hiện rút tiền");
                return;
            }

            if (MessageUtil.ShowInfoConfirmDialog($"Xác nhận thực hiện giao dịch {transTypeName} cho tài khoản {accountId}?") != DialogResult.OK)
                return;

            try
            {
                gD_GOIRUTBindingSource.RemoveCurrent();

                int rowAffected = AccountDAO.Instance.AddSendWithdrawalTransaction(accountId, transTypeCode, amount);

                if (rowAffected <= 0)
                    return;

                // Cập nhật lại số dư của tài khoản
                //LoadAccountFromCustomer();
                taiKhoanBindingSource.Position = taiKhoanBindingSource.Find(Account.ID_HEADER, accountId);

                // Cập nhật giao dịch mới được thêm
                this.gD_GOIRUTTableAdapter.Fill(this.DS.GD_GOIRUT);

                MessageUtil.ShowInfoMsgDialog("Lưu giao dịch thành công!");
            }
            catch (Exception ex)
            {
                MessageUtil.ShowErrorMsgDialog($"Lỗi không thể lưu giao dịch.\nChi tiết: {ex.Message}");
                return;
            }

            gcTaiKhoan.Enabled = gcGoiRut.Enabled = true;
            pnInput.Enabled = false;
            btnInsert.Enabled = btnReload.Enabled = true;
            btnCancel.Enabled = btnSave.Enabled = false;

            ReqUpdateCanCloseState.Invoke(this, true);
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            try
            {
                // do du lieu moi tu dataSet vao gridControl NHANVIEN
                this.taiKhoanTableAdapter.Connection.ConnectionString = Program.ConnectionStr;
                this.taiKhoanTableAdapter.Fill(this.DS.TaiKhoan);
                this.gD_GOIRUTTableAdapter.Connection.ConnectionString = Program.ConnectionStr;
                this.gD_GOIRUTTableAdapter.Fill(this.DS.GD_GOIRUT);

                //this.gcDonDatHang.Enabled = true;
              //  this.gcChiTietDonDatHang.Enabled = true;

               // bdsDonDatHang.Position = viTri;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Làm mới" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            gD_GOIRUTBindingSource.RemoveCurrent();
            gcTaiKhoan.Enabled = gcGoiRut.Enabled = true;
            pnInput.Enabled = false;
            btnInsert.Enabled = btnReload.Enabled = true;
            btnCancel.Enabled = btnSave.Enabled = false;

            ReqUpdateCanCloseState.Invoke(this, true);
        }

        private void fTransSendWithdrawal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                ReqClose.Invoke(this);
                e.Cancel = btnSave.Enabled;
            }
        }


        private void teLoaiGD_EditValueChanged(object sender, EventArgs e)
        {
            if (teLoaiGD.Text.StartsWith("R"))
                cbTransTypeName.SelectedItem = "Rút tiền";
            else if (teLoaiGD.Text.StartsWith("G"))
                cbTransTypeName.SelectedItem = "Gửi tiền";
        }
    }
}