using NganHangPhanTan.DAO;
using NganHangPhanTan.DTO;
using NganHangPhanTan.Util;
using System;
using System.Data;

namespace NganHangPhanTan.SimpleForm
{
    public partial class fEmployeeMove : DevExpress.XtraEditors.XtraForm
    {
        public fEmployeeMove()
        {
            InitializeComponent();
        }

        public Action<string,string> ReqMoveEmployeeToBrandId;

        private void btnMove_Click(object sender, EventArgs e)
        {
            string selectedBrandId = ((DataRowView)bdsBrandOption[bdsBrandOption.Position])[Brand.ID_HEADER].ToString();
            // Kiểm tra các ràng buộc
            string employeeID = txbId.Text.Trim();
            if (string.IsNullOrEmpty(employeeID))
            {
                MessageUtil.ShowErrorMsgDialog("Mã nhân viên không được để trống.");
                txbId.Focus();
                return;
            }

            if (employeeID.Contains(" "))
            {
                MessageUtil.ShowErrorMsgDialog("Mã nhân viên không hợp lệ");
                txbId.Focus();
                return;
            }

            if (employeeID.Length > 10)
            {
                MessageUtil.ShowErrorMsgDialog("Mã nhân viên không được vượt quá 10 kí tự");
                txbId.Focus();
                return;
            }

            // Kiểm tra mã nhân viên tồn tại trên site chủ
            if (EmployeeDAO.Instance.IsEmployeeIDExisted(employeeID))
            {
                MessageUtil.ShowErrorMsgDialog("Mã nhân viên đã tồn tại. Vui lòng chọn mã khác");
                txbId.Focus();
                return;
            }

            employeeID = employeeID.ToUpper();
            txbId.Text = employeeID;

            ReqMoveEmployeeToBrandId.Invoke(selectedBrandId,employeeID);
        }

        private void fEmployeeMove_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.usp_GetOtherBrandFromSubcriber' table. You can move, or remove it, as needed.
            this.usp_GetOtherBrandFromSubcriberTableAdapter.Connection.ConnectionString = DataProvider.Instance.ConnectionStr;
            this.usp_GetOtherBrandFromSubcriberTableAdapter.Fill(this.dS.usp_GetOtherBrandFromSubcriber);
            if (bdsBrandOption.Count > 0)
                bdsBrandOption.Position = 0;
            btnMove.Enabled = bdsBrandOption.Count > 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}