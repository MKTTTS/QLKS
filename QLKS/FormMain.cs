using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View;

namespace QLKS
{
     public partial class FormMain : Form
     {
          string conString = ConfigurationManager.ConnectionStrings["myconnection"].ConnectionString;
          int dem = 0;
        private string CMND;
        string flag = "";
        private int Level;
        
        System.Data.DataTable table = new System.Data.DataTable();
        public FormMain()
          {
               InitializeComponent();
          }

          private void FormMain_Load(object sender, EventArgs e)
          {
               SqlConnection sqlCon = new SqlConnection(conString);
               sqlCon.Open();

               //Cap nhat cac phong duoc dat trc nhung qua han ngay su dung
               string qry_DatHetHan = "select MaPhong from DatPhong where NgaySuDung < GETDATE()";
               SqlCommand cmd_DatHetHan = new SqlCommand(qry_DatHetHan, sqlCon);
               SqlDataReader reader_DatHetHan = cmd_DatHetHan.ExecuteReader();
               string[] maPhongHetHan = new string[10000];
               int j = 0;

               if (reader_DatHetHan.HasRows)
               {
                    while (reader_DatHetHan.Read())
                    {
                         maPhongHetHan[j] = reader_DatHetHan.GetString(0);
                         j++;
                    }
                    j--;
               }

               reader_DatHetHan.Close();

               while(j >= 0)
               {
                    string qry_updateTinhTrang = "update Phong set TinhTrang='Trong' where MaPhong='" + maPhongHetHan[j] + "'";
                    string qry_xoaPhongDat = "delete from DatPhong where MaPhong='" + maPhongHetHan[j] + "'";
                    SqlCommand cmd_updateTinhTrang = new SqlCommand(qry_updateTinhTrang, sqlCon); //update phòng về tình trạng trống
                    SqlCommand cmd_xoaPhongDat = new SqlCommand(qry_xoaPhongDat, sqlCon); //xóa phòng này trong danh sách đc đặt
                    cmd_updateTinhTrang.ExecuteNonQuery();
                    cmd_xoaPhongDat.ExecuteNonQuery();
                    j--;
               }               


               //Tab Danh sach Phong
               string qry_DSPhong = "select * from Phong";
               SqlDataAdapter da_DSPhong = new SqlDataAdapter(qry_DSPhong, sqlCon);
               DataTable dt_DSPhong = new DataTable();
               da_DSPhong.Fill(dt_DSPhong);
               dem = dt_DSPhong.Rows.Count;
               dtgvDanhSachphong.DataSource = dt_DSPhong;

               //Tab Thue Phong
               string qry_MaPhong = "select MaPhong from Phong where TinhTrang='Trong'";
               SqlDataAdapter da_MaPhong = new SqlDataAdapter(qry_MaPhong, sqlCon);
               DataTable dt_MaPhong = new DataTable();
               da_MaPhong.Fill(dt_MaPhong);

               cbxPhongReady.Items.Clear(); // Moi khi load lai form phai cap nhat danh sach phong

               for(int i=0;i<dt_MaPhong.Rows.Count;i++)
               {
                    cbxPhongReady.Items.Add(dt_MaPhong.Rows[i]["MaPhong"]);
               }


               sqlCon.Close();
          }

          private void dtgvDanhSachphong_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
          {
               int test = 0;
               foreach (DataGridViewRow row in dtgvDanhSachphong.Rows)
               {
                    string ok = row.Cells[3].Value.ToString();

                    if (ok.TrimEnd() == "Trong")
                    {
                         row.DefaultCellStyle.ForeColor = Color.Green;
                    }

                    if (ok.TrimEnd() == "Coc")
                    {
                         row.DefaultCellStyle.ForeColor = Color.YellowGreen;
                    }

                    if (ok.TrimEnd() == "Het")
                    {
                         row.DefaultCellStyle.ForeColor = Color.Red;
                    }

                    test++;

                    if (test == dem) break;


               }
          }

          private void btThuePhongOK_Click(object sender, EventArgs e)
          {

          }

          private void btnOkDatPhong_Click(object sender, EventArgs e)
          {
               SqlConnection sqlCon = new SqlConnection(conString);
               sqlCon.Open();

               string ngay = dtngaydattruoc.Value.Day.ToString();
               string thang = dtngaydattruoc.Value.Month.ToString();
               string nam = dtngaydattruoc.Value.Year.ToString().Substring(2);

               string maDat = String.Concat(ngay, thang, nam, cbxPhongReady.Text);

               string qry_DatPhong = "insert into DatPhong values (" + maDat + "," + cbxPhongReady.Text + "," + txtSDTdatPhong.Text + "," 
                                      + txtTienCoc.Text + ",'" + dtngaydattruoc.Value.ToString() + "','" + dtNgayTraPhongDat.Value.ToString() + "')";

               SqlCommand cmd_DatPhong = new SqlCommand(qry_DatPhong, sqlCon);
               cmd_DatPhong.ExecuteNonQuery();
               cmd_DatPhong.Cancel();

               string qry_ChuyenTinhTrang = "Update Phong set TinhTrang = 'Het' where MaPhong = '" + cbxPhongReady.Text + "'";
               SqlCommand cmd_ChuyenTinhTrang = new SqlCommand(qry_ChuyenTinhTrang, sqlCon);
               cmd_ChuyenTinhTrang.ExecuteNonQuery();
               cmd_ChuyenTinhTrang.Cancel();

               FormMain_Load(sender, e);

               sqlCon.Close();    

          }

          private void dtNgayTraPhongDat_ValueChanged(object sender, EventArgs e)
          {

          }

          private void button6_Click(object sender, EventArgs e)
          {

          }

        private void Tabphong_Selected(object sender, TabControlEventArgs e)
        {
            this.textBoxMaNV.ReadOnly = true;
            lockcontrol();
            LoadAgain();
            show();
        }
        ////XuanTung
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

        

        private void button1Search_Click(object sender, EventArgs e)
        {
            LoadAgain();

        }

        private void dataGridViewNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var mnv = dataGridViewNhanVien.Rows[e.RowIndex].Cells["Mã nhân viên"].Value.ToString().Trim();
                if (!string.IsNullOrEmpty(mnv))
                {
                    var rs = new DatabaseNV().Select("SELECTNhanVien '" + mnv + "'");
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
            if (this.buttonSua.Text == "SỬA")
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
            if (this.buttonSua.Text == "THOÁT" && this.buttonThem.Enabled == false)
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
            if (this.buttonThem.Text == "THOÁT" && this.buttonSua.Enabled == false)
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
                if (this.textBoxSDT.Text == "")
                {
                    MessageBox.Show("Số điện thoại");
                    return;
                }
                if (this.textBoxMK.Text == "")
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
                var r = new DatabaseNV().Select("EXEC MANVMAX '" + this.comboBoxChucVu.Text + "'");
                int S = Int32.Parse(r["MaLonNhat"].ToString());
                S = S + 1;
                string ma;
                if (S < 10)
                {
                    ma = string.Concat("00", S.ToString());
                }
                else if (S > 9 && S < 100)
                {
                    ma = string.Concat("0", S.ToString());
                }
                else
                {
                    ma = S.ToString();
                }

                if (this.comboBoxChucVu.Text == "Quan Ly")
                {
                    MaNV = string.Concat("QL", ma);
                }
                else if (this.comboBoxChucVu.Text == "Le Tan")
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
                if (rs >= 0)
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
            if (this.buttonThem.Text == "THÊM")
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



        //////////////
        ///Manh son
        ///
        void lockcontrol()
        {
            txtcmt.ReadOnly = true;
            txtdiachi.ReadOnly = true;
            txtsdt.ReadOnly = true;
            txttenkh.ReadOnly = true;
            cbgiotinhkh.Enabled = false;
            cbquoctich.Enabled = false;
            dtngaysinh.Enabled = false;
            btn_add.Enabled = true;
            btn_edit.Enabled = false;
            btn_exit.Enabled = true;
            btn_save.Enabled = false;
        }
        private void btn_edit_Click(object sender, EventArgs e)
        {
            flag = "edit";
            unlock();
        }
        void unlock()
        {
            txtcmt.ReadOnly = false;
            txtdiachi.ReadOnly = false;
            txtsdt.ReadOnly = true;
            txttenkh.ReadOnly = false;
            cbgiotinhkh.Enabled = true;
            cbquoctich.Enabled = true;
            dtngaysinh.Enabled = true;
            btn_add.Enabled = true;
            btn_edit.Enabled = false;
            btn_exit.Enabled = true;
            btn_save.Enabled = true;
        }
        void show()
        {
            SqlConnection connection;
            SqlCommand command;
            string str = ConfigurationManager.ConnectionStrings["myconnection"].ConnectionString;
            SqlDataAdapter adapter = new SqlDataAdapter();
            connection = new SqlConnection(str);
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM dbo.KhachHang";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgKH.DataSource = table;
            dgKH.ReadOnly = true;
            connection.Close();

        }
        bool check()
        {
            if (string.IsNullOrEmpty(txttenkh.Text))
            {
                MessageBox.Show("Chưa nhập tên khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txttenkh.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtsdt.Text))
            {
                MessageBox.Show("Chưa nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtsdt.Focus();
                return false;
            }
            return true;
        }
        bool checksdt(string sdt)
        {
            int check = 0;
            SqlConnection connection;
            SqlCommand command;
            string str = ConfigurationManager.ConnectionStrings["myconnection"].ConnectionString;
            SqlDataAdapter adapter = new SqlDataAdapter();
            connection = new SqlConnection(str);
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "SELECT SoDT FROM dbo.KhachHang";
            adapter.SelectCommand = command;
            DataTable tb = new DataTable();
            adapter.Fill(tb);
            connection.Close();
            if (tb.Rows.Count != 0)
            {
                for (int i = 0; i < tb.Rows.Count; i++)
                {
                    if (sdt == tb.Rows[i].ItemArray[0].ToString().Trim())
                    {
                        check++;
                        break;
                    }
                }
                if (check != 0)
                {
                    MessageBox.Show("Số điện thoại đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtsdt.Focus();
                    return false;

                }
                else return true;
            }
            else return true;
        }
        bool checkcmnd(string cmnd)
        {
            int check = 0;
            SqlConnection connection;
            SqlCommand command;
            string str = ConfigurationManager.ConnectionStrings["myconnection"].ConnectionString;
            SqlDataAdapter adapter = new SqlDataAdapter();
            connection = new SqlConnection(str);
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "SELECT SoCMT FROM dbo.KhachHang";
            adapter.SelectCommand = command;
            DataTable tb = new DataTable();
            adapter.Fill(tb);
            connection.Close();
            if (cmnd == "" || tb.Rows.Count == 0)
            {
                return true;
            }
            else
            {
                for (int i = 0; i < tb.Rows.Count; i++)
                {
                    if (cmnd == tb.Rows[i].ItemArray[0].ToString().Trim())
                    {
                        check++;
                        break;
                    }
                }
                if (check != 0)
                {
                    MessageBox.Show("Số CMND đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtcmt.Focus();
                    return false;

                }
                else return true;
            }
        }
        bool checkcmnd_2(string cmnd, string sdt)
        {
            int check = 0;
            SqlConnection connection;
            SqlCommand command;
            string str = ConfigurationManager.ConnectionStrings["myconnection"].ConnectionString;
            SqlDataAdapter adapter = new SqlDataAdapter();
            connection = new SqlConnection(str);
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "SELECT SoCMT FROM dbo.KhachHang WHERE SoDT <>'" + txtsdt.Text + "'";
            adapter.SelectCommand = command;
            DataTable tb = new DataTable();
            adapter.Fill(tb);
            connection.Close();
            if (cmnd == "" || tb.Rows.Count < 1)
            {
                return true;
            }
            else
            {
                for (int i = 0; i < tb.Rows.Count; i++)
                {
                    if (cmnd.Trim() == tb.Rows[i].ItemArray[0].ToString().Trim())
                    {
                        check++;
                        break;
                    }
                }
                if (check > 0)
                {
                    MessageBox.Show("Số CMND đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtcmt.Focus();
                    return false;

                }
                else return true;
            }
        }
        
        
        
        private void txtsdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && e.KeyChar != '+')
                e.Handled = true;
        }
        private void txtcmt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            flag = "add";
            unlock();
            txtsdt.ReadOnly = false;
            txtcmt.Text = "";
            txtdiachi.Text = "";
            txtsdt.Text = "";
            txttenkh.Text = "";
            cbgiotinhkh.SelectedIndex = 0;
            cbquoctich.SelectedIndex = 0;
            dtngaysinh.Value = DateTime.Now;
        }

        private void dgKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lockcontrol();
            int i;
            i = dgKH.CurrentRow.Index;
            if (i >= 0)
            {

                var r = dgKH.Rows[i].Cells["SoDT"].Value.ToString();
                if (!string.IsNullOrEmpty(r))
                {
                    txttenkh.Text = dgKH.Rows[i].Cells[0].Value.ToString();
                    dtngaysinh.Text = dgKH.Rows[i].Cells[1].Value.ToString();
                    cbgiotinhkh.Text = dgKH.Rows[i].Cells[2].Value.ToString();
                    txtcmt.Text = dgKH.Rows[i].Cells[3].Value.ToString();
                    txtsdt.Text = dgKH.Rows[i].Cells[4].Value.ToString();
                    txtdiachi.Text = dgKH.Rows[i].Cells[5].Value.ToString();
                    cbquoctich.Text = dgKH.Rows[i].Cells[6].Value.ToString();
                    this.btn_edit.Enabled = true;
                }
                else
                {
                    this.btn_edit.Enabled = false;
                }
            }
        }


        
        private void btn_save_Click(object sender, EventArgs e)
        {
            if (flag == "add")
            {
                if (check() && checkcmnd(txtcmt.Text) && checksdt(txtsdt.Text))
                {
                    SqlConnection connection;
                    SqlCommand command;
                    string str = ConfigurationManager.ConnectionStrings["myconnection"].ConnectionString;
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    connection = new SqlConnection(str);
                    connection.Open();
                    command = connection.CreateCommand();
                    command.CommandText = "INSERT INTO dbo.KhachHang( TenKH , NgaySinh ,GioiTinh ,SoCMT ,SoDT ,QueQuan , QuocTich )VALUES  ( N'" + txttenkh.Text + "' , '" + dtngaysinh.Text + "' , '" + cbgiotinhkh.Text + "' ,  '" + txtcmt.Text + "' , '" + txtsdt.Text + "' ,'" + txtdiachi.Text + "' , N'" + cbquoctich.Text + "')";
                    command.ExecuteNonQuery();
                    connection.Close();
                    show();
                }
            }
            else if (flag == "edit")
            {
                if (check() && checkcmnd_2(txtcmt.Text, txtsdt.Text))
                {
                    SqlConnection connection;
                    SqlCommand command;
                    string str = ConfigurationManager.ConnectionStrings["myconnection"].ConnectionString;
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    connection = new SqlConnection(str);
                    connection.Open();
                    command = connection.CreateCommand();
                    command.CommandText = "UPDATE dbo.KhachHang SET TenKH='" + txttenkh.Text + "',NgaySinh='" + dtngaysinh.Text + "',GioiTinh='" + cbgiotinhkh.Text + "',SoCMT='" + txtcmt.Text + "',QueQuan='" + txtdiachi.Text + "',QuocTich='" + cbquoctich.Text + "' WHERE SoDT='" + txtsdt.Text + "' ";
                    command.ExecuteNonQuery();
                    connection.Close();
                    show();
                }
            }
        }

        //////////////////
    }
}
