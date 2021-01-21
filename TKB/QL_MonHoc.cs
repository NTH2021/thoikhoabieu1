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
    public partial class QL_MonHoc : Form
    {
        public QL_MonHoc()
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
                string sql = "select * from MonHoc";
                SqlCommand commandsql = new SqlCommand(sql, kn);
                SqlDataAdapter com = new SqlDataAdapter(commandsql);
                DataTable table = new DataTable();
                com.Fill(table);
                dgv_quanlymonhoc.DataSource = table;
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

        private void QL_MonHoc_Load(object sender, EventArgs e)
        {
            ketnoi();
        }

        private void dgv_quanlymonhoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgv_quanlymonhoc.CurrentRow.Index;
            txt_mamonhoc.Text = dgv_quanlymonhoc.Rows[index].Cells[0].Value.ToString();
            txt_tenmonhoc.Text = dgv_quanlymonhoc.Rows[index].Cells[1].Value.ToString();
            txt_sotiet.Text = dgv_quanlymonhoc.Rows[index].Cells[2].Value.ToString();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection kn = new SqlConnection(sqlconnectStr);
                kn.Open();
                string them = @"INSERT INTO MonHoc(MaMonHoc,TenMonHoc,SoTiet)
            VALUES (N'" + txt_mamonhoc.Text + @"',N'" + txt_tenmonhoc.Text + @"',N'" + txt_sotiet.Text + @"')";
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
                    string xoa = @"DELETE FROM MonHoc WHERE (MaMonHoc=N'" + txt_mamonhoc.Text + @"')";
                    SqlCommand commandxoa = new SqlCommand(xoa, kn);
                    commandxoa.ExecuteNonQuery();
                    ketnoi();
                    MessageBox.Show("Xóa thông tin thành công!", "Thông báo", MessageBoxButtons.OK);
                }
            }
            catch
            {
                MessageBox.Show("Lỗi! Phải xóa phiếu thuê phòng trước");
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
                string sua = @"UPDATE MonHoc set
                    MaMonHoc=N'" + txt_mamonhoc.Text + @"',TenMonHoc=N'" + txt_tenmonhoc.Text + @"',SoTiet=N'" + txt_sotiet.Text + @"'
                    WHERE(MaMonHoc=N'" + txt_mamonhoc.Text + @"')";
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
    }
}
