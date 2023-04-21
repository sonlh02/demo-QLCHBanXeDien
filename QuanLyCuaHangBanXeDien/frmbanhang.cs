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
    public partial class frmbanhang : Form
    {
        public frmbanhang()
        {
            InitializeComponent();
        }
        ketnoi kn = new ketnoi();
        public void getdata()
        {
            string query = "select * from XeDien";
            DataSet ds = kn.laydulieu(query, "XeDien");
            dgvsanpham.DataSource = ds.Tables["XeDien"];
        }
        private void frmbanhang_Load(object sender, EventArgs e)
        {
            getdata();  
        }
    }
}
