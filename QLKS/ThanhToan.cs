using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View;

namespace QLKS
{
    public partial class ThanhToan : Form
    {
        DatabaseNV db = new DatabaseNV();
        public ThanhToan()
        {
            InitializeComponent();
            TimKiem("","sdt");
        }
        private void TimKiem(string key, string mode)
        {

            List<CustomerParameter> lstpara = new List<CustomerParameter>();
            if(mode == "sdt")
            {
                lstpara.Add(new CustomerParameter() { key = "@SoDT", value = key });
                this.phongThueBindingSource.DataSource = db.SelectData("SP_TimKiemPhongThue",lstpara);
            }
            else if (mode == "cmtnd")
            {
                lstpara.Add(new CustomerParameter() { key = "@SoCMT", value = key });
                this.phongThueBindingSource.DataSource = db.SelectData("SP_TimKiemPhongThueCMTND", lstpara);
            }   
            else if (mode == "mp")
            {
                lstpara.Add(new CustomerParameter() { key = "@MaPhong", value = key });
                this.phongThueBindingSource.DataSource = db.SelectData("SP_TimKiemPhongThueMaPhongf", lstpara);
            }
            else if (mode == "ten")
            {
                lstpara.Add(new CustomerParameter() { key = "@Name", value = key });
                this.phongThueBindingSource.DataSource = db.SelectData("SP_TimKiemPhongThueTen", lstpara);
            }

        }
        private void TimKiem_cbb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TimKiem_btn_Click(object sender, EventArgs e)
        {
            if (TimKiem_txb.Text == "")
            {
                MessageBox.Show("Vui lòng nhập nội dung tìm kiếm!");
                return;
            }
            if (comboBox1.SelectedIndex == 0)
            {
                TimKiem(TimKiem_txb.Text, "mp");
            }
            else if(comboBox1.SelectedIndex == 2)
            {
                /*cmtnd*/
                TimKiem(TimKiem_txb.Text, "cmtnd");
            }
            else if(comboBox1.SelectedIndex == 1)
            {
                // sdt
                TimKiem(TimKiem_txb.Text, "sdt");
            }
            else if(comboBox1.SelectedIndex == 3)
            {
                TimKiem(TimKiem_txb.Text, "ten");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hình thức tìm kiếm!");
            }
        }

        private void all_btn_Click(object sender, EventArgs e)
        {
            TimKiem("", "sdt");
        }

        private void XuatHoaDon_btn_Click(object sender, EventArgs e)
        {
            List<CustomerParameter> lstpara = new List<CustomerParameter>();
            lstpara.Add(new CustomerParameter() { key = "@MaHD", value = key });
            lstpara.Add(new CustomerParameter() { key = "@MaNV", value = key });
            lstpara.Add(new CustomerParameter() { key = "@SoDT", value = soDTTextBox.Text });
            lstpara.Add(new CustomerParameter() { key = "@NgayLap", value = DateTime.Today.ToString() });
            lstpara.Add(new CustomerParameter() { key = "@TongTien", value = key });

            this.phongThueBindingSource.DataSource = db.SelectData("SP_XuatHoaDon", lstpara);
        }
    }
}
