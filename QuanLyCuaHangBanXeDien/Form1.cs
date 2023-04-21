using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangBanXeDien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmdangnhap frm = new frmdangnhap();
            frm.MdiParent = this;
            frm.Show();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmkhachhang frm = new frmkhachhang();
            frm.MdiParent = this;
            frm.Show();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmnhanvien frm = new frmnhanvien();
            frm.MdiParent = this;
            frm.Show();
        }

        private void loạiXeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmloaixe frm = new frmloaixe();
            frm.MdiParent = this;
            frm.Show();
        }

        private void xeĐiệnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmxedien frm = new frmxedien();
            frm.MdiParent = this;
            frm.Show();
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmnhacungcap frm = new frmnhacungcap();
            frm.MdiParent = this;
            frm.Show();
        }

        private void hóaĐơnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmhoadon frm = new frmhoadon();
            frm.MdiParent = this;
            frm.Show();
        }

        private void chiTiếtHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmchitiethoadon frm = new frmchitiethoadon();
            frm.MdiParent = this;
            frm.Show();
        }

        private void bảoHànhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmbaohanh frm = new frmbaohanh();
            frm.MdiParent = this;
            frm.Show();
        }

        private void traCứuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmtracuu frm = new frmtracuu();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
