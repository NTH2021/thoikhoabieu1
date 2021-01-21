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
    public partial class QL_TKB : Form
    {
        public QL_TKB()
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
                string sql = @"select *from TKB ";
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
        private void QL_TKB_Load(object sender, EventArgs e)
        {
            ketnoi();
        }

        private void dgv_quanlytkb_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgv_quanlytkb.CurrentRow.Index;
            txt_tiethoc.Text = dgv_quanlytkb.Rows[index].Cells[0].Value.ToString();
            txt_t2.Text = dgv_quanlytkb.Rows[index].Cells[1].Value.ToString();
            txt_t3.Text = dgv_quanlytkb.Rows[index].Cells[2].Value.ToString();
            txt_t4.Text = dgv_quanlytkb.Rows[index].Cells[3].Value.ToString();
            txt_t5.Text = dgv_quanlytkb.Rows[index].Cells[4].Value.ToString();
            txt_t6.Text = dgv_quanlytkb.Rows[index].Cells[5].Value.ToString();
            txt_t7.Text = dgv_quanlytkb.Rows[index].Cells[6].Value.ToString();
            txt_cn.Text = dgv_quanlytkb.Rows[index].Cells[7].Value.ToString();
            txt_magd.Text = dgv_quanlytkb.Rows[index].Cells[8].Value.ToString();
            txt_magv.Text = dgv_quanlytkb.Rows[index].Cells[9].Value.ToString();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection kn = new SqlConnection(sqlconnectStr);
                kn.Open();
                string them = @"INSERT INTO TKB(SoTiet,Thu2,Thu3,Thu4,Thu5,Thu6,Thu7,ChuNhat,MaGiangDay,MaGiaoVien)
            VALUES (N'" + txt_tiethoc.Text + @"',N'" + txt_t2.Text + @"',N'" + txt_t3.Text + @"',N'" + txt_t4.Text + @"',N'" + txt_t5.Text + @"',N'" + txt_t6.Text + @"',N'" + txt_t7.Text + @"',N'" + txt_cn.Text + @"',N'" + txt_magd.Text + @"',N'" + txt_magv.Text + @"')";
                SqlCommand commandthem = new SqlCommand(them, kn);
                commandthem.ExecuteNonQuery();
                ketnoi();
                MessageBox.Show("Thêm thông tin thành công!", "Thông báo", MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show("Lỗi !!!");
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
                    string xoa = @"DELETE FROM TKB WHERE (SoTiet=N'" + txt_tiethoc.Text + @"')";
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
                string sua = @"UPDATE TKB set
                    SoTiet=N'" + txt_tiethoc.Text + @"',Thu2=N'" + txt_t2.Text + @"',Thu3=N'" + txt_t3.Text + @"',Thu4=N'" + txt_t4.Text + @"',Thu5=N'" + txt_t5.Text + @"',Thu6=N'" + txt_t6.Text + @"',Thu7=N'" + txt_t7.Text + @"',ChuNhat=N'" + txt_cn.Text + @"',MaGiangDay=N'" + txt_magd.Text + @"',MaGiaoVien=N'" + txt_magv.Text + @"'
                    WHERE(SoTiet=N'" + txt_tiethoc.Text + @"')";
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_chitiet_Click(object sender, EventArgs e)
        {
            ChitietTKB tkb = new ChitietTKB();
            tkb.Show();
            this.Hide();
        }
    }
}
