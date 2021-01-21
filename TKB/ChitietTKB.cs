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

namespace TKB
{
    public partial class ChitietTKB : Form
    {
        public ChitietTKB()
        {
            InitializeComponent();
        }
        SqlCommand command;
        string sqlconnectStr = @"data source=.\SQLEXPRESS;initial catalog=TKB;integrated security=True";
        private void ketnoi()
        {
            try
            {
                //đổ dữ liệu bảng khách hàng vào dgv1

                SqlConnection kn = new SqlConnection(sqlconnectStr);
                kn.Open();
                string sql = @"select SoTiet,Thu2,Thu3,Thu4,Thu5,Thu6,Thu7,ChuNhat,TenGiaoVien,BatDauGiangDay,KetThucGiangDay
                            from TKB inner join GiaoVien ON TKB.MaGiaoVien = GiaoVien.MaGiaovien
                                        inner join GiangDay ON TKB.MaGiangDay = GiangDay.MaGiangDay";
                SqlCommand commandsql = new SqlCommand(sql, kn);
                SqlDataAdapter com = new SqlDataAdapter(commandsql);
                DataTable table = new DataTable();
                com.Fill(table);
                dgv_quanlytkb.DataSource = table;
            }
            catch
            {
                MessageBox.Show("lỗi");
            }
            finally
            {
                SqlConnection kn = new SqlConnection(sqlconnectStr);
                kn.Close();
            }
        }
        private void ChitietTKB_Load(object sender, EventArgs e)
        {
            ketnoi();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            QL_TKB tkb = new QL_TKB();
            tkb.Show();
            this.Hide();
        }
    }
}
