using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View;

namespace QLKS
{
     public partial class FormNhanVien : Form
     {
        private string CMND;
          public FormNhanVien()
          {
               InitializeComponent();
            this.textBoxMaNV.ReadOnly = true;
            this.buttonXoa.Enabled = false;
            //this.comboBoxGioiTinh.Text = "Nam";
            //this.comboBoxChucVu.Text = "Quan Ly";
          }
        public void LoadAgain()
        {
            var db = new DatabaseNV();
            List<CustomerParameter> lst = new List<CustomerParameter>();
            lst.Add(new CustomerParameter() { key = "@tukhoa", value = this.textBoxSearch.Text });
            string sql = "SELECTNHANVIENTHEOTUKHOA";
            this.dataGridViewNhanVien.DataSource = db.SelectData(sql, lst);
            this.buttonSua.Enabled = false;
            this.textBoxHoTen.ReadOnly = true;
            this.comboBoxGioiTinh.Enabled = false;
            this.maskedTextBoxNgaySinh.ReadOnly = true;
            this.comboBoxChucVu.Enabled = false;
            this.textBoxSoCMND.ReadOnly = true;
            this.textBoxDiaChi.ReadOnly = true;
            this.textBoxSDT.ReadOnly = true;
            this.textBoxMaNV.Text = "";
            this.textBoxHoTen.Text = "";
            //this.comboBoxGioiTinh.Text = "Nam";
            this.maskedTextBoxNgaySinh.Text = "";
            //this.comboBoxChucVu.Text = "Quan Ly";
            this.textBoxSoCMND.Text = "";
            this.textBoxDiaChi.Text = "";
            this.textBoxSDT.Text = "";
            this.buttonLuu.Enabled = false;
            this.label1MK.Visible = false;
            this.textBoxMK.Visible = false;

        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            LoadAgain();
        }

        private void button1Search_Click(object sender, EventArgs e)
        {
            LoadAgain();
            
        }

        private void dataGridViewNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                var mnv = dataGridViewNhanVien.Rows[e.RowIndex].Cells["Mã nhân viên"].Value.ToString().Trim();
                if (!string.IsNullOrEmpty(mnv))
                {
                    var rs = new DatabaseNV().Select("SELECTNhanVien '"+mnv+"'");
                    this.textBoxMaNV.Text = mnv;
                    this.textBoxHoTen.Text = rs["HoTen"].ToString().Trim();
                    this.comboBoxGioiTinh.Text = rs["GioiTinh"].ToString().Trim();
                    this.maskedTextBoxNgaySinh.Text = rs["NgaySinh"].ToString().Trim();
                    this.comboBoxChucVu.Text = rs["ChucVu"].ToString().Trim();
                    this.textBoxSoCMND.Text = rs["SoCMT"].ToString().Trim();
                    this.textBoxDiaChi.Text = rs["DiaChi"].ToString().Trim();
                    this.textBoxSDT.Text = rs["SDT"].ToString().Trim();
                    this.buttonSua.Enabled = true;
                    this.CMND = this.textBoxSoCMND.Text;

                }
            }
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            if(this.buttonSua.Text == "SỬA")
            {
                this.textBoxHoTen.ReadOnly = false;
                this.comboBoxGioiTinh.Enabled = true;
                this.textBoxDiaChi.ReadOnly = false;
                this.maskedTextBoxNgaySinh.ReadOnly = false;
                this.comboBoxChucVu.Enabled = true;
                this.textBoxSDT.ReadOnly = false;
                this.textBoxSoCMND.ReadOnly = false;
                panelLeft.Enabled = false;
                this.buttonSua.Text = "THOÁT";
                this.buttonThem.Enabled = false;
                this.buttonLuu.Enabled = true;
            }
            else
            {
                LoadAgain();
                panelLeft.Enabled = true;
                this.buttonThem.Enabled = true;
                this.buttonSua.Text = "SỬA";
                this.buttonLuu.Enabled = false;

            }
        }
        public bool CheckCMND(string S)
        {
            if (S.Length != 9)
            {
                return false;
            }
            else
            {
                bool Result = true;

                foreach (Char c in S)
                {
                    if (!Char.IsDigit(c))
                    {
                        Result = false;
                    }
                }
                if (Result == true)
                {
                    var r = new DatabaseNV().Select("EXEC CHECKCMND '" + S + "'");
                    if (r["TonTai"].ToString() == "1")
                    {
                        Result = false;
                    }
                }
                return Result;



            }
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            if(this.buttonSua.Text == "THOÁT" && this.buttonThem.Enabled == false)
            {
                if (this.textBoxHoTen.Text == "")
                {
                    MessageBox.Show("Họ tên trống");
                    return;
                }

                DateTime ngaysinh;
                
                DateTime now = DateTime.Now;
                try
                {
                    ngaysinh = DateTime.ParseExact(this.maskedTextBoxNgaySinh.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ngày sinh không hợp lệ");
                    this.maskedTextBoxNgaySinh.Select();
                    return;
                }
                if (DateTime.Compare(ngaysinh, now) >= 0)
                {
                    MessageBox.Show("Ngày sinh không hợp lệ");
                    this.maskedTextBoxNgaySinh.Select();
                    return;
                }
                if (CheckCMND(this.textBoxSoCMND.Text) == false && this.textBoxSoCMND.Text != this.CMND)
                {
                    MessageBox.Show("Số CMND không hợp lệ");
                    this.textBoxSoCMND.Select();
                    return;
                }
                string sql = "UPDATENV";
                string Name = this.textBoxHoTen.Text.Trim();
                DateTime date;
                try
                {
                    date = DateTime.ParseExact(this.maskedTextBoxNgaySinh.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ngày sinh không hợp lệ");
                    this.maskedTextBoxNgaySinh.Select();
                    return;
                }
                string GioiTinh = this.comboBoxGioiTinh.Text;
                string CMT = this.textBoxSoCMND.Text;
                string DiaChi = this.textBoxDiaChi.Text.Trim();
                string SDT = this.textBoxSDT.Text.Trim();
                string ChucVu = this.comboBoxChucVu.Text;
                List<CustomerParameter> lstpara = new List<CustomerParameter>();
                lstpara.Add(new CustomerParameter() { key = "@manhanvien", value = this.textBoxMaNV.Text });
                lstpara.Add(new CustomerParameter() { key = "@hoten", value = Name });
                lstpara.Add(new CustomerParameter() { key = "@ngaysinh", value = date.ToString("yyyy-MM-dd") });
                lstpara.Add(new CustomerParameter() { key = "@gioitinh", value = GioiTinh });
                lstpara.Add(new CustomerParameter() { key = "@socmnd", value = CMT });
                lstpara.Add(new CustomerParameter() { key = "@diachi", value = DiaChi });
                lstpara.Add(new CustomerParameter() { key = "@sdt", value = SDT });
                lstpara.Add(new CustomerParameter() { key = "@chucvu", value = ChucVu });
                var rs = new DatabaseNV().Excute(sql, lstpara, null);
                if (rs > 0)
                {
                    MessageBox.Show("Cập nhật thành công.");
                    LoadAgain();
                    this.buttonThem.Enabled = true;
                    this.panelLeft.Enabled = true;
                    this.buttonSua.Text = "SỬA";

                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại.");
                    return;
                }
            }
            if(this.buttonThem.Text == "THOÁT" && this.buttonSua.Enabled == false)
            {
                
                if (this.textBoxHoTen.Text == "")
                {
                    MessageBox.Show("Họ tên trống");
                    return;
                }

                DateTime ngaysinh;

                DateTime now = DateTime.Now;
                try
                {
                    ngaysinh = DateTime.ParseExact(this.maskedTextBoxNgaySinh.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ngày sinh không hợp lệ");
                    this.maskedTextBoxNgaySinh.Select();
                    return;
                }
                if (DateTime.Compare(ngaysinh, now) >= 0)
                {
                    MessageBox.Show("Ngày sinh không hợp lệ");
                    this.maskedTextBoxNgaySinh.Select();
                    return;
                }
                if (CheckCMND(this.textBoxSoCMND.Text) == false)
                {
                    MessageBox.Show("Số CMND không hợp lệ");
                    this.textBoxSoCMND.Select();
                    return;
                }
                if(this.textBoxSDT.Text == "")
                {
                    MessageBox.Show("Số điện thoại");
                    return;
                }
                if(this.textBoxMK.Text == "")
                {
                    MessageBox.Show("Mật khẩu trống");
                    return;
                }
                string Name = this.textBoxHoTen.Text.Trim();
                string GioiTinh = this.comboBoxGioiTinh.Text;
                string CMT = this.textBoxSoCMND.Text;
                string DiaChi = this.textBoxDiaChi.Text.Trim();
                string SDT = this.textBoxSDT.Text.Trim();
                string ChucVu = this.comboBoxChucVu.Text;
                string MaNV;
                var r = new DatabaseNV().Select("EXEC MANVMAX '"+this.comboBoxChucVu.Text+"'");
                int S = Int32.Parse(r["MaLonNhat"].ToString());
                S = S + 1;
                string ma;
                if(S < 10)
                {
                    ma = string.Concat("00", S.ToString());
                }
                else if(S > 9 && S < 100)
                {
                    ma = string.Concat("0", S.ToString());
                }
                else
                {
                    ma = S.ToString();
                }

                if(this.comboBoxChucVu.Text == "Quan Ly")
                {
                    MaNV = string.Concat("QL", ma);
                }
                else if(this.comboBoxChucVu.Text == "Le Tan")
                {
                    MaNV = string.Concat("LT", ma);
                }
                else
                {
                    MaNV = string.Concat("LC", ma);
                }
                string sql = "THEMNHANVIEN";
                List<CustomerParameter> lst = new List<CustomerParameter>();
                lst.Add(new CustomerParameter() { key = "@manhanvien", value = MaNV });
                lst.Add(new CustomerParameter() { key = "@hoten", value = Name });
                lst.Add(new CustomerParameter() { key = "@ngaysinh", value = ngaysinh.ToString("yyyy-MM-dd") });
                lst.Add(new CustomerParameter() { key = "@gioitinh", value = GioiTinh });
                lst.Add(new CustomerParameter() { key = "@socmnd", value = CMT });
                lst.Add(new CustomerParameter() { key = "@diachi", value = DiaChi });
                lst.Add(new CustomerParameter() { key = "@sdt", value = SDT });
                lst.Add(new CustomerParameter() { key = "@chucvu", value = ChucVu });
                lst.Add(new CustomerParameter() { key = "@password", value = this.textBoxMK.Text });
                var rs = new DatabaseNV().Excute(sql, lst, null);
                if(rs >= 0)
                {
                    MessageBox.Show("Thêm thành công nhân viên");
                    LoadAgain();
                    
                    this.panelLeft.Enabled = true;
                    this.buttonThem.Text = "THÊM";
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                    return;
                }
            }
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            if(this.buttonThem.Text == "THÊM")
            {
                this.buttonSua.Enabled = false;
                this.panelLeft.Enabled = false;
                this.buttonThem.Text = "THOÁT";
                this.textBoxMaNV.Text = "";
                this.textBoxHoTen.Text = "";
                this.comboBoxGioiTinh.Text = "Nam";
                this.maskedTextBoxNgaySinh.Text = "";
                this.comboBoxChucVu.Text = "Quan Ly";
                this.textBoxSoCMND.Text = "";
                this.textBoxDiaChi.Text = "";
                this.textBoxSDT.Text = "";
                this.textBoxHoTen.ReadOnly = false;
                this.comboBoxGioiTinh.Enabled = true;
                this.textBoxDiaChi.ReadOnly = false;
                this.maskedTextBoxNgaySinh.ReadOnly = false;
                this.comboBoxChucVu.Enabled = true;
                this.textBoxSDT.ReadOnly = false;
                this.textBoxSoCMND.ReadOnly = false;
                this.buttonLuu.Enabled = true;
                this.label1MK.Visible = true;
                this.textBoxMK.Visible = true;
                this.textBoxMK.Text = "123456";


            }
            else
            {
                this.buttonThem.Text = "THÊM";
                LoadAgain();
                this.panelLeft.Enabled = true;
                this.buttonLuu.Enabled = false;
            }

        }
    }
}
