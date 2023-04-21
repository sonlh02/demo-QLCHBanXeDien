using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace QuanLyCuaHangBanXeDien
{
    public partial class frmkhachhang : Form
    {
        public frmkhachhang()
        {
            InitializeComponent();
        }
        ketnoi kn = new ketnoi();
        public void getdata()
        {
            string query = "select * from KhachHang";
            DataSet ds = kn.laydulieu(query, "KhachHang");
            dgvkhachhang.DataSource = ds.Tables["KhachHang"];
        }
        private void frmkhachhang_Load(object sender, EventArgs e)
        {
            getdata();
        }
        public void MaKhachHang()
        {

        }
        private void btnmoi_Click(object sender, EventArgs e)
        {
            foreach (Control ctr in this.groupBox1.Controls)
            {
                if ((ctr is System.Windows.Forms.TextBox) || (ctr is DateTimePicker) || (ctr is System.Windows.Forms.ComboBox))
                {
                    ctr.Text = "";
                }
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string query = string.Format("insert into KhachHang(HoTen,DiaChi,SoDienThoai,Email,NgaySinh,GioiTinh) values('{0}','{1}','{2}','{3}','{4}','{5}')", txthoten.Text, txtdiachi.Text, txtsodienthoai.Text, txtemail.Text, dtpngaysinh.Text, cbbgioitinh.Text);
            bool kt = kn.thucthi(query);
            if (kt == true)
            {
                MessageBox.Show("Them thanh cong");
                getdata();
            }
            else
            {
                MessageBox.Show("Them that bai");
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string query = string.Format("update KhachHang set HoTen = '{1}', DiaChi = '{2}', SoDienThoai = '{3}' , Email = '{4}', NgaySinh = '{5}', GioiTinh = '{6}' where mabangluong = '{0}'", cbbmakhachhang.Text ,txthoten.Text, txtdiachi.Text, txtsodienthoai.Text, txtemail.Text, dtpngaysinh.Text, cbbgioitinh.Text);
            bool kt = kn.thucthi(query);
            if (kt == true)
            {
                MessageBox.Show("Sua thanh cong");
                getdata();
            }
            else
            {
                MessageBox.Show("Sua that bai");
            }
        }
    }
}
