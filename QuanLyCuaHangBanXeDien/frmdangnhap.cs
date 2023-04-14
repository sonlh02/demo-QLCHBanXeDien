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
    public partial class frmdangnhap : Form
    {
        public frmdangnhap()
        {
            InitializeComponent();
        }
        ketnoi kn = new ketnoi();
        private void btndangnhap_Click(object sender, EventArgs e)
        {
            string query = string.Format("select * from TaiKhoan where Username = '{0}' and Password = '{1}'", txtusername.Text, txtpassword.Text);
            DataSet ds = kn.laydulieu(query, "TaiKhoan");
            if (ds.Tables["TaiKhoan"].Rows.Count == 1)
            {
                MessageBox.Show("Dang nhap thanh cong");
                Form1 frm = new Form1();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Dang nhap that bai");
            }
        }
    }
}
