using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace TKB
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"data source=.\SQLEXPRESS;initial catalog=TKB;integrated security=True");
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private string getID()
        {
            string id = "";
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM TaiKhoan WHERE TenTaiKhoan ='" + txttaikhoan.Text + "' and PASS='" + txtmatkhau.Text + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {

                        id = dr["MaGiaoVien"].ToString();
                        {
                            id = dr["QUYEN"].ToString();
                            MessageBox.Show("Đăng Nhập Thành Công", "thông báo", MessageBoxButtons.OK);
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Đăng Nhập Không Thành Công", "thông báo");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi xảy ra khi truy vấn dữ liệu hoặc kết nối với server thất bại !", "thông báo");
            }
            finally
            {
                con.Close();
            }
            return id;
        }

        public static string MaGiaoVien = "";
        public static string QUYEN = "";

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            MaGiaoVien = getID();
            QUYEN = getID();
            if (QUYEN != "")
            {

                Menu fmain = new Menu();
                fmain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tài khoảng và mật khẩu không đúng !", "thông báo");
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult tb = MessageBox.Show("Bạn có muốn thoát hay không?", "thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (tb == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
