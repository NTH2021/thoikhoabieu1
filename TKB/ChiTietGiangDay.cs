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
    public partial class ChiTietGiangDay : Form
    {
        public ChiTietGiangDay()
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
                string sql = @"select MaGiangDay,TenGiaoVien,TenLop,TenMonHoc,BatDauGiangDay,KetThucGiangDay 
                            from GiangDay inner join GiaoVien ON GiangDay.MaGiaoVien = GiaoVien.MaGiaovien
                                    inner join Lop ON GiangDay.MaLop = Lop.MaLop
                                    inner join MonHoc ON GiangDay.MaMonHoc = MonHoc.MaMonHoc

                                      
                            ";
             
                SqlCommand commandsql = new SqlCommand(sql, kn);
                SqlDataAdapter com = new SqlDataAdapter(commandsql);
                DataTable table = new DataTable();
                com.Fill(table);
                dgv_quanlygiangvien.DataSource = table;

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
            private void ChiTietGiangDay_Load(object sender, EventArgs e)
        {
            ketnoi();
        }

        private void dgv_quanlygiangvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgv_quanlygiangvien.CurrentRow.Index;
            txt_magd.Text = dgv_quanlygiangvien.Rows[index].Cells[0].Value.ToString();
            txt_tengv.Text = dgv_quanlygiangvien.Rows[index].Cells[1].Value.ToString();
            txt_tenlop.Text = dgv_quanlygiangvien.Rows[index].Cells[2].Value.ToString();
            txt_tenmon.Text = dgv_quanlygiangvien.Rows[index].Cells[3].Value.ToString();
            txt_bd.Text = dgv_quanlygiangvien.Rows[index].Cells[4].Value.ToString();
            txt_kt.Text = dgv_quanlygiangvien.Rows[index].Cells[5].Value.ToString();
        }



        private void btn_thoat_Click(object sender, EventArgs e)
        {
            QL_GiangDay gd = new QL_GiangDay();
            gd.Show();
            this.Hide();
        }
    }
}
