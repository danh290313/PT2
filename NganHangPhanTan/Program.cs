using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using System.Data;
using System.Data.SqlClient;
using NganHangPhanTan.Util;
using System.Text.RegularExpressions;

namespace NganHangPhanTan
{
    public static class Program
    {
        
        public static SqlConnection conn = new SqlConnection();
        public static String ConnectionStr; 
        public static SqlDataReader myReader;
        public static String serverName = "";
        public static String currentServer = "";
        public static String username = "";
        public static String mlogin = "";
        public static String password = "";

        public static String database = "NGANHANG";
        public static String remotelogin = "HTKN";
        public static String remotepassword = "123456";
        public static String mloginDN = "";
        public static String passwordDN = "";
        public static String mGroup = "";
        public static String mHoten = "";
        public static int brand = 0;//mChiNhanh

        public static string DISTRIBUTOR_NAME = "DESKTOP-AQV5G2G";
        public static string CONNECTION_STR_TEMPLATE = "Data Source={0};Initial Catalog=NGANHANG;{1}";
        public static string REMOTE_LOGIN = "HTKN";
        public static string REMOTE_PASS = "123456";
        public static String connstrPublisher = "Data Source=DESKTOP-AQV5G2G;Initial Catalog=NGANHANG;Integrated Security=true";

        public static BindingSource bindingSource = new BindingSource();

        public static fMain frmChinh;

       

        public static void SetServerToRemote(string subcriber)
        {
            serverName = subcriber;
            ConnectionStr = string.Format(CONNECTION_STR_TEMPLATE, serverName, $"User ID={REMOTE_LOGIN};password={REMOTE_PASS}");
        }

        public static void SetServerToSubcriber(string subcriber, string loginName, string pass)
        {
            serverName = subcriber;
            ConnectionStr = string.Format(CONNECTION_STR_TEMPLATE, serverName, $"User ID={loginName};password={pass}");


        }

        public static void SetServerToDistributor()
        {
            serverName = DISTRIBUTOR_NAME;
            ConnectionStr = string.Format(CONNECTION_STR_TEMPLATE, serverName, "Integrated Security=True");
        }



        public static bool CheckConnection()
        {
            
            if (Program.conn != null && Program.conn.State == ConnectionState.Open)
                Program.conn.Close();
            try
            {    
                Program.conn.ConnectionString = ConnectionStr;
                Program.conn.Open();
                return true ;
            }

            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nXem lại tài khoản và mật khẩu.\n " + e.Message, "", MessageBoxButtons.OK);
                //Console.WriteLine(e.Message);
                return false;
            }

        }



        public static SqlDataReader ExecuteSqlDataReader(string query)
        {
            SqlCommand sqlCommand = new SqlCommand
            {
                Connection = new SqlConnection(ConnectionStr),
                CommandText = query,
                CommandType = CommandType.Text
            };

            SqlDataReader sqlDataReader;
            try
            {
                if (sqlCommand.Connection.State == ConnectionState.Closed)
                    sqlCommand.Connection.Open();
                sqlDataReader = sqlCommand.ExecuteReader();
                return sqlDataReader;
            }
            catch (Exception ex)
            {
                MessageUtil.ShowErrorMsgDialog($"Lỗi kết nối cơ sở dữ liệu.\nKiểm tra lại tên đăng nhập và mật khẩu.\nChi tiết lỗi: {ex.Message}");
                return null;
            }
        }

        /// <summary>
        /// Execute query and return result as data table. Return null if connection is closed.
        /// </summary>
        /// <param name="query"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public static DataTable ExecuteDataTable(string query, object[] parameters = null)
        {
            DataTable data = new DataTable();

            using (SqlConnection connection = new SqlConnection(ConnectionStr))
            {
                SqlCommand command = new SqlCommand(query, connection);

                if (parameters != null)
                {
                    int i = 0;
                    foreach (string item in Regex.Split(query, @"\s+"))
                    {
                        if (item.Contains("@"))
                        {
                            int id = item.IndexOf(',');
                            if (id > 0)
                                command.Parameters.AddWithValue(item.Remove(id), parameters[i]);
                            else
                                command.Parameters.AddWithValue(item, parameters[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                try
                {
                    adapter.Fill(data);
                }
                catch (Exception ex)
                {
                    MessageUtil.ShowErrorMsgDialog(ex.Message);
                    data = null;
                }
            }

            return data;
        }


        public static int ExecuteNonQuery(string query, object[] parameters = null)
        {
            int rowsAffected = -1;

            using (SqlConnection connection = new SqlConnection(ConnectionStr))
            {
                SqlCommand command = new SqlCommand(query, connection)
                {
                    CommandTimeout = 600, // 10 mins
                };

                if (parameters != null)
                {
                    int i = 0;
                    foreach (string item in Regex.Split(query, @"\s+"))
                    {
                        if (item.Contains("@"))
                        {
                            int id = item.IndexOf(',');
                            if (id > 0)
                                command.Parameters.AddWithValue(item.Remove(id), parameters[i]);
                            else
                                command.Parameters.AddWithValue(item, parameters[i]);
                            i++;
                        }
                    }
                }

                try
                {
                    connection.Open();
                    rowsAffected = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageUtil.ShowErrorMsgDialog(ex.Message);
                    rowsAffected = -2;
                }
            }

            return rowsAffected;
        }


        public static int ExecuteNonQuery(string spName, SqlParameter[] parameters)
        {
            int rowsAffected = -1;

            using (SqlConnection connection = new SqlConnection(ConnectionStr))
            {
                SqlCommand command = new SqlCommand(spName, connection)
                {
                    CommandTimeout = 600, // 10 mins
                    CommandType = CommandType.StoredProcedure
                };

                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }

                try
                {
                    connection.Open();
                    rowsAffected = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageUtil.ShowErrorMsgDialog(ex.Message);
                    rowsAffected = -2;
                }
            }

            return rowsAffected;
        }


        public static object ExecuteScalar(string query, object[] parameters = null)
        {
            object data = null;

            using (SqlConnection connection = new SqlConnection(ConnectionStr))
            {
                SqlCommand command = new SqlCommand(query, connection);

                if (parameters != null)
                {
                    int i = 0;
                    foreach (string item in Regex.Split(query, @"\s+"))
                    {
                        if (item.Contains("@"))
                        {
                            int id = item.IndexOf(',');
                            if (id > 0)
                                command.Parameters.AddWithValue(item.Remove(id), parameters[i]);
                            else
                                command.Parameters.AddWithValue(item, parameters[i]);
                            i++;
                        }
                    }
                }

                try
                {
                    connection.Open();
                    data = command.ExecuteScalar();
                }
                catch (SqlException ex)
                {
                    MessageUtil.ShowErrorMsgDialog(ex.Message);
                    return null;
                }
            }

            return data;
        }
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Program.frmChinh = new fMain();
            Application.Run(frmChinh);
        }
    }
}
