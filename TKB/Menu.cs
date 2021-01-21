using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TKB
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DangNhap dn = new DangNhap();
            dn.Show();
            this.Hide();
        }

        private void quảnLýGiáoViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QL_GiaoVien gv = new QL_GiaoVien();
            gv.Show();
            this.Hide();
        }

        private void quảnLýLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QL_Lop gv1 = new QL_Lop();
            gv1.Show();
            this.Hide();
        }

        private void quảnLýMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QL_MonHoc gv1 = new QL_MonHoc();
            gv1.Show();
            this.Hide();
        }

        private void quảnLýGiảngDạyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QL_GiangDay gv1 = new QL_GiangDay();
            gv1.Show();
            this.Hide();
        }

        private void quảnLýThờiKhóaBiểuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QL_TKB gv1 = new QL_TKB();
            gv1.Show();
            this.Hide();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            DangNhap dn = new DangNhap();
            if (DangNhap.MaGiaoVien != "")
            {
                quảnLýGiáoViênToolStripMenuItem.Enabled = true;
                quảnLýLớpToolStripMenuItem.Enabled = true;
                quảnLýMônHọcToolStripMenuItem.Enabled = true;
                quảnLýGiảngDạyToolStripMenuItem.Enabled = true;
                đăngXuấtToolStripMenuItem.Enabled = true;
                quảnLýThờiKhóaBiểuToolStripMenuItem.Enabled = true;
            }
            else
            {
                quảnLýGiáoViênToolStripMenuItem.Enabled = false;
                quảnLýLớpToolStripMenuItem.Enabled = false;
                quảnLýMônHọcToolStripMenuItem.Enabled = false;
                quảnLýGiảngDạyToolStripMenuItem.Enabled = false;
                đăngXuấtToolStripMenuItem.Enabled = false;
                quảnLýThờiKhóaBiểuToolStripMenuItem.Enabled = false;
            }
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DangNhap fmain = new DangNhap();
            fmain.Show();
            this.Hide();
        }
    }
}

