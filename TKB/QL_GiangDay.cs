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
    public partial class QL_GiangDay : Form
    {
        public QL_GiangDay()
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
                string sql = "select * from GiangDay";
                SqlCommand commandsql = new SqlCommand(sql, kn);
                SqlDataAdapter com = new SqlDataAdapter(commandsql);
                DataTable table = new DataTable();
                com.Fill(table);
                dgv_quanlygiangvien.DataSource = table;

                string sql1 = @"select MaGiaoVien, TenGiaoVien FROM GiaoVien";
                SqlCommand commandsql1 = new SqlCommand(sql1, kn);
                SqlDataAdapter com1 = new SqlDataAdapter(commandsql1);
                DataTable table1 = new DataTable();
                com1.Fill(table1);
                dgv_quanlygiaovien.DataSource = table1;


                string sql2 = @"select MaLop, TenLop from Lop";
                SqlCommand commandsql2 = new SqlCommand(sql2, kn);
                SqlDataAdapter com2 = new SqlDataAdapter(commandsql2);
                DataTable table2 = new DataTable();
                com2.Fill(table2);
                dgv_quanlylop.DataSource = table2;

                string sql3 = @"select MaMonHoc, TenMonHoc from MonHoc";
                SqlCommand commandsql3 = new SqlCommand(sql3, kn);
                SqlDataAdapter com3 = new SqlDataAdapter(commandsql3);
                DataTable table3 = new DataTable();
                com3.Fill(table3);
                dgv_quanlymon.DataSource = table3;
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
        private void QL_GiangDay_Load(object sender, EventArgs e)
        {
            ketnoi();
        }

        private void dgv_quanlygiangvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgv_quanlygiangvien.CurrentRow.Index;
            txt_magd.Text = dgv_quanlygiangvien.Rows[index].Cells[0].Value.ToString();
            txt_magv.Text = dgv_quanlygiangvien.Rows[index].Cells[1].Value.ToString();
            txt_malop.Text = dgv_quanlygiangvien.Rows[index].Cells[2].Value.ToString();
            txt_mamonhoc.Text = dgv_quanlygiangvien.Rows[index].Cells[3].Value.ToString();
            txt_bd.Text = dgv_quanlygiangvien.Rows[index].Cells[4].Value.ToString();
            txt_kt.Text = dgv_quanlygiangvien.Rows[index].Cells[5].Value.ToString();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection kn = new SqlConnection(sqlconnectStr);
                kn.Open();
                string them = @"INSERT INTO GiangDay(MaGiangDay,MaGiaoVien,MaLop,MaMonHoc,BatDauGiangDay,KetThucGiangDay)
            VALUES (N'" + txt_magd.Text + @"',N'" + txt_magv.Text + @"',N'" + txt_malop.Text + @"',N'" + txt_mamonhoc.Text + @"',N'" + txt_bd.Text + @"',N'" + txt_kt.Text + @"')";
                SqlCommand commandthem = new SqlCommand(them, kn);
                commandthem.ExecuteNonQuery();
                ketnoi();
                MessageBox.Show("Thêm thông tin thành công!", "Thông báo", MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show("Lỗi!!!");
            }
            finally
            {
                SqlConnection kn = new SqlConnection(sqlconnectStr);
                kn.Close();
            }
        }

        private void btn_xóa_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection kn = new SqlConnection(sqlconnectStr);
                kn.Open();
                DialogResult dr = MessageBox.Show("Bạn có muốn xóa ?", "YES/NO", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    string xoa = @"DELETE FROM GiangVien WHERE (MaGiangDay=N'" + txt_magd.Text + @"')";
                    SqlCommand commandxoa = new SqlCommand(xoa, kn);
                    commandxoa.ExecuteNonQuery();
                    ketnoi();
                    MessageBox.Show("Xóa thông tin thành công!", "Thông báo", MessageBoxButtons.OK);
                }
            }
            catch
            {
                MessageBox.Show("Lỗi! ");
            }
            finally
            {
                SqlConnection kn1 = new SqlConnection(sqlconnectStr);
                kn1.Close();
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection kn = new SqlConnection(sqlconnectStr);
                kn.Open();
                string sua = @"UPDATE GiangDay set
                    MaGiangDay=N'" + txt_magd.Text + @"',MaGiaoVien=N'" + txt_magv.Text + @"',MaLop=N'" + txt_malop.Text + @"',MaMon=N'" + txt_mamonhoc.Text + @"',BatDauGiangDay=N'" + txt_bd.Text + @"',KetThucGiangDay=N'" + txt_kt.Text + @"'
                    WHERE(MaGiangDay=N'" + txt_magd.Text + @"')";
                SqlCommand commandsua = new SqlCommand(sua, kn);
                commandsua.ExecuteNonQuery();
                ketnoi();
                MessageBox.Show("Sửa thông tin thành công!", "Thông báo", MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
            finally
            {
                SqlConnection kn = new SqlConnection(sqlconnectStr);
                kn.Close();
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.Show();
            this.Hide();
        }

        private void btn_chitiet_Click(object sender, EventArgs e)
        {
            ChiTietGiangDay d = new ChiTietGiangDay();
            d.Show();
            this.Hide();
        }
    }
}
