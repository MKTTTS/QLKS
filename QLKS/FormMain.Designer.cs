﻿namespace QLKS
{
     partial class FormMain
     {
          /// <summary>
          /// Required designer variable.
          /// </summary>
          private System.ComponentModel.IContainer components = null;

          /// <summary>
          /// Clean up any resources being used.
          /// </summary>
          /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
          protected override void Dispose(bool disposing)
          {
               if (disposing && (components != null))
               {
                    components.Dispose();
               }
               base.Dispose(disposing);
          }

          #region Windows Form Designer generated code

          /// <summary>
          /// Required method for Designer support - do not modify
          /// the contents of this method with the code editor.
          /// </summary>
          private void InitializeComponent()
          {
            this.Tabphong = new System.Windows.Forms.TabControl();
            this.tpDanhSanh = new System.Windows.Forms.TabPage();
            this.dtgvDanhSachphong = new System.Windows.Forms.DataGridView();
            this.maPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btndangxuat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tpThuePhong = new System.Windows.Forms.TabPage();
            this.bHuyBo = new System.Windows.Forms.Button();
            this.btThuePhongOK = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dgkhachhang = new System.Windows.Forms.DataGridView();
            this.maKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chungMinhNhanDan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quocTich = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtmakhtp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBDatPhong = new System.Windows.Forms.GroupBox();
            this.dtngaydattruoc = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtphongdt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBDatPhongTruoc = new System.Windows.Forms.CheckBox();
            this.txtPhongtp = new System.Windows.Forms.TextBox();
            this.dtTuNgaytp = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tpTimKiem = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.dtgvTimKiem = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.TKTheoDiaChi = new System.Windows.Forms.TextBox();
            this.cbTheoDiaChi = new System.Windows.Forms.CheckBox();
            this.TKTheoSoDT = new System.Windows.Forms.TextBox();
            this.cbTheoDT = new System.Windows.Forms.CheckBox();
            this.btTimKiem = new System.Windows.Forms.Button();
            this.TKTheoCMND = new System.Windows.Forms.TextBox();
            this.cbTheoCMND = new System.Windows.Forms.CheckBox();
            this.TKTheoMa = new System.Windows.Forms.TextBox();
            this.cbTheoMaKH = new System.Windows.Forms.CheckBox();
            this.TKDenNgay = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.TKTuNgay = new System.Windows.Forms.DateTimePicker();
            this.TKTheoTen = new System.Windows.Forms.TextBox();
            this.TKTheoPhong = new System.Windows.Forms.ComboBox();
            this.cbThoiGian = new System.Windows.Forms.CheckBox();
            this.cbTheoTen = new System.Windows.Forms.CheckBox();
            this.cbTheoPhong = new System.Windows.Forms.CheckBox();
            this.tpTraPhong = new System.Windows.Forms.TabPage();
            this.Tabphong.SuspendLayout();
            this.tpDanhSanh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachphong)).BeginInit();
            this.tpThuePhong.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgkhachhang)).BeginInit();
            this.groupBDatPhong.SuspendLayout();
            this.tpTimKiem.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTimKiem)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tabphong
            // 
            this.Tabphong.Controls.Add(this.tpDanhSanh);
            this.Tabphong.Controls.Add(this.tpThuePhong);
            this.Tabphong.Controls.Add(this.tpTimKiem);
            this.Tabphong.Controls.Add(this.tpTraPhong);
            this.Tabphong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Tabphong.Location = new System.Drawing.Point(2, 2);
            this.Tabphong.Name = "Tabphong";
            this.Tabphong.SelectedIndex = 0;
            this.Tabphong.Size = new System.Drawing.Size(1010, 597);
            this.Tabphong.TabIndex = 1;
            // 
            // tpDanhSanh
            // 
            this.tpDanhSanh.AccessibleName = "";
            this.tpDanhSanh.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.tpDanhSanh.Controls.Add(this.dtgvDanhSachphong);
            this.tpDanhSanh.Controls.Add(this.btndangxuat);
            this.tpDanhSanh.Controls.Add(this.label2);
            this.tpDanhSanh.Location = new System.Drawing.Point(4, 25);
            this.tpDanhSanh.Name = "tpDanhSanh";
            this.tpDanhSanh.Padding = new System.Windows.Forms.Padding(3);
            this.tpDanhSanh.Size = new System.Drawing.Size(1002, 568);
            this.tpDanhSanh.TabIndex = 0;
            this.tpDanhSanh.Text = "Danh Sách";
            this.tpDanhSanh.UseVisualStyleBackColor = true;
            // 
            // dtgvDanhSachphong
            // 
            this.dtgvDanhSachphong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDanhSachphong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDanhSachphong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maPhong,
            this.loaiPhong,
            this.tinhTrang,
            this.donGia});
            this.dtgvDanhSachphong.Location = new System.Drawing.Point(3, 52);
            this.dtgvDanhSachphong.MultiSelect = false;
            this.dtgvDanhSachphong.Name = "dtgvDanhSachphong";
            this.dtgvDanhSachphong.ReadOnly = true;
            this.dtgvDanhSachphong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvDanhSachphong.Size = new System.Drawing.Size(974, 331);
            this.dtgvDanhSachphong.TabIndex = 1;
            // 
            // maPhong
            // 
            this.maPhong.DataPropertyName = "maPhong";
            this.maPhong.HeaderText = "Phòng";
            this.maPhong.Name = "maPhong";
            this.maPhong.ReadOnly = true;
            // 
            // loaiPhong
            // 
            this.loaiPhong.DataPropertyName = "loaiPhong";
            this.loaiPhong.HeaderText = "Loại Phòng";
            this.loaiPhong.Name = "loaiPhong";
            this.loaiPhong.ReadOnly = true;
            // 
            // tinhTrang
            // 
            this.tinhTrang.DataPropertyName = "tinhTrang";
            this.tinhTrang.HeaderText = "Tình trạng";
            this.tinhTrang.Name = "tinhTrang";
            this.tinhTrang.ReadOnly = true;
            // 
            // donGia
            // 
            this.donGia.DataPropertyName = "donGia";
            this.donGia.HeaderText = "Đơn Giá";
            this.donGia.Name = "donGia";
            this.donGia.ReadOnly = true;
            // 
            // btndangxuat
            // 
            this.btndangxuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btndangxuat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btndangxuat.Location = new System.Drawing.Point(853, 20);
            this.btndangxuat.Name = "btndangxuat";
            this.btndangxuat.Size = new System.Drawing.Size(109, 26);
            this.btndangxuat.TabIndex = 2;
            this.btndangxuat.Text = "Đăng xuất";
            this.btndangxuat.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Fuchsia;
            this.label2.Location = new System.Drawing.Point(267, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(426, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "DANH SÁCH PHÒNG TRONG KHÁCH SẠN";
            // 
            // tpThuePhong
            // 
            this.tpThuePhong.Controls.Add(this.bHuyBo);
            this.tpThuePhong.Controls.Add(this.btThuePhongOK);
            this.tpThuePhong.Controls.Add(this.groupBox5);
            this.tpThuePhong.Location = new System.Drawing.Point(4, 25);
            this.tpThuePhong.Name = "tpThuePhong";
            this.tpThuePhong.Padding = new System.Windows.Forms.Padding(3);
            this.tpThuePhong.Size = new System.Drawing.Size(1002, 568);
            this.tpThuePhong.TabIndex = 1;
            this.tpThuePhong.Text = "Thuê Phòng";
            this.tpThuePhong.UseVisualStyleBackColor = true;
            // 
            // bHuyBo
            // 
            this.bHuyBo.Location = new System.Drawing.Point(504, 462);
            this.bHuyBo.Name = "bHuyBo";
            this.bHuyBo.Size = new System.Drawing.Size(115, 38);
            this.bHuyBo.TabIndex = 24;
            this.bHuyBo.Text = "Hủy bỏ";
            this.bHuyBo.UseVisualStyleBackColor = true;
            // 
            // btThuePhongOK
            // 
            this.btThuePhongOK.Location = new System.Drawing.Point(277, 462);
            this.btThuePhongOK.Name = "btThuePhongOK";
            this.btThuePhongOK.Size = new System.Drawing.Size(115, 38);
            this.btThuePhongOK.TabIndex = 23;
            this.btThuePhongOK.Text = "OK";
            this.btThuePhongOK.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dgkhachhang);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.txtmakhtp);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.groupBDatPhong);
            this.groupBox5.Controls.Add(this.txtPhongtp);
            this.groupBox5.Controls.Add(this.dtTuNgaytp);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Location = new System.Drawing.Point(19, 5);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(939, 436);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            // 
            // dgkhachhang
            // 
            this.dgkhachhang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgkhachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgkhachhang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maKhachHang,
            this.tenKhachHang,
            this.ngaySinh,
            this.gioiTinh,
            this.chungMinhNhanDan,
            this.soDienThoai,
            this.diaChi,
            this.quocTich});
            this.dgkhachhang.Location = new System.Drawing.Point(6, 49);
            this.dgkhachhang.Name = "dgkhachhang";
            this.dgkhachhang.ReadOnly = true;
            this.dgkhachhang.Size = new System.Drawing.Size(915, 171);
            this.dgkhachhang.TabIndex = 31;
            // 
            // maKhachHang
            // 
            this.maKhachHang.DataPropertyName = "maKhachHang";
            this.maKhachHang.HeaderText = "Mã khách hàng";
            this.maKhachHang.Name = "maKhachHang";
            this.maKhachHang.ReadOnly = true;
            // 
            // tenKhachHang
            // 
            this.tenKhachHang.DataPropertyName = "tenKhachHang";
            this.tenKhachHang.HeaderText = "Tên khách hàng";
            this.tenKhachHang.Name = "tenKhachHang";
            this.tenKhachHang.ReadOnly = true;
            // 
            // ngaySinh
            // 
            this.ngaySinh.DataPropertyName = "ngaySinh";
            this.ngaySinh.HeaderText = "Ngày sinh";
            this.ngaySinh.Name = "ngaySinh";
            this.ngaySinh.ReadOnly = true;
            // 
            // gioiTinh
            // 
            this.gioiTinh.DataPropertyName = "gioiTinh";
            this.gioiTinh.HeaderText = "Giới tính";
            this.gioiTinh.Name = "gioiTinh";
            this.gioiTinh.ReadOnly = true;
            // 
            // chungMinhNhanDan
            // 
            this.chungMinhNhanDan.DataPropertyName = "chungMinhNhanDan";
            this.chungMinhNhanDan.HeaderText = "Chứng minh thư";
            this.chungMinhNhanDan.Name = "chungMinhNhanDan";
            this.chungMinhNhanDan.ReadOnly = true;
            // 
            // soDienThoai
            // 
            this.soDienThoai.DataPropertyName = "soDienThoai";
            this.soDienThoai.HeaderText = "Số điện thoại";
            this.soDienThoai.Name = "soDienThoai";
            this.soDienThoai.ReadOnly = true;
            // 
            // diaChi
            // 
            this.diaChi.DataPropertyName = "diaChi";
            this.diaChi.HeaderText = "Địa chỉ";
            this.diaChi.Name = "diaChi";
            this.diaChi.ReadOnly = true;
            // 
            // quocTich
            // 
            this.quocTich.DataPropertyName = "quocTich";
            this.quocTich.HeaderText = "Quốc tịch";
            this.quocTich.Name = "quocTich";
            this.quocTich.ReadOnly = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(296, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(289, 24);
            this.label6.TabIndex = 30;
            this.label6.Text = "THÔNG TIN KHÁCH HÀNG :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(132, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 29;
            this.label5.Text = "Mã KH :";
            // 
            // txtmakhtp
            // 
            this.txtmakhtp.Enabled = false;
            this.txtmakhtp.Location = new System.Drawing.Point(222, 238);
            this.txtmakhtp.Name = "txtmakhtp";
            this.txtmakhtp.Size = new System.Drawing.Size(189, 22);
            this.txtmakhtp.TabIndex = 29;
            this.txtmakhtp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(128, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 28;
            // 
            // groupBDatPhong
            // 
            this.groupBDatPhong.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBDatPhong.Controls.Add(this.dtngaydattruoc);
            this.groupBDatPhong.Controls.Add(this.label3);
            this.groupBDatPhong.Controls.Add(this.txtphongdt);
            this.groupBDatPhong.Controls.Add(this.label1);
            this.groupBDatPhong.Controls.Add(this.checkBDatPhongTruoc);
            this.groupBDatPhong.Location = new System.Drawing.Point(114, 319);
            this.groupBDatPhong.Name = "groupBDatPhong";
            this.groupBDatPhong.Size = new System.Drawing.Size(688, 96);
            this.groupBDatPhong.TabIndex = 26;
            this.groupBDatPhong.TabStop = false;
            // 
            // dtngaydattruoc
            // 
            this.dtngaydattruoc.CustomFormat = "dd/MM/yyyy";
            this.dtngaydattruoc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtngaydattruoc.Location = new System.Drawing.Point(102, 54);
            this.dtngaydattruoc.Name = "dtngaydattruoc";
            this.dtngaydattruoc.Size = new System.Drawing.Size(189, 22);
            this.dtngaydattruoc.TabIndex = 28;
            this.dtngaydattruoc.Value = new System.DateTime(2008, 12, 13, 0, 53, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 27;
            this.label3.Text = "Từ Ngày :";
            // 
            // txtphongdt
            // 
            this.txtphongdt.Location = new System.Drawing.Point(460, 52);
            this.txtphongdt.Name = "txtphongdt";
            this.txtphongdt.Size = new System.Drawing.Size(189, 22);
            this.txtphongdt.TabIndex = 28;
            this.txtphongdt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(383, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 27;
            this.label1.Text = "Phòng :";
            // 
            // checkBDatPhongTruoc
            // 
            this.checkBDatPhongTruoc.AutoSize = true;
            this.checkBDatPhongTruoc.Location = new System.Drawing.Point(16, 21);
            this.checkBDatPhongTruoc.Name = "checkBDatPhongTruoc";
            this.checkBDatPhongTruoc.Size = new System.Drawing.Size(126, 20);
            this.checkBDatPhongTruoc.TabIndex = 27;
            this.checkBDatPhongTruoc.Text = "Đặt phòng trước :";
            this.checkBDatPhongTruoc.UseVisualStyleBackColor = true;
            // 
            // txtPhongtp
            // 
            this.txtPhongtp.Location = new System.Drawing.Point(590, 280);
            this.txtPhongtp.Name = "txtPhongtp";
            this.txtPhongtp.Size = new System.Drawing.Size(189, 22);
            this.txtPhongtp.TabIndex = 22;
            this.txtPhongtp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dtTuNgaytp
            // 
            this.dtTuNgaytp.CustomFormat = "dd/MM/yyyy";
            this.dtTuNgaytp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTuNgaytp.Location = new System.Drawing.Point(221, 282);
            this.dtTuNgaytp.Name = "dtTuNgaytp";
            this.dtTuNgaytp.Size = new System.Drawing.Size(189, 22);
            this.dtTuNgaytp.TabIndex = 18;
            this.dtTuNgaytp.Value = new System.DateTime(2008, 12, 13, 0, 53, 0, 0);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(513, 282);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 16);
            this.label12.TabIndex = 9;
            this.label12.Text = "Phòng :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(131, 282);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 16);
            this.label9.TabIndex = 6;
            this.label9.Text = "Từ Ngày :";
            // 
            // tpTimKiem
            // 
            this.tpTimKiem.Controls.Add(this.groupBox7);
            this.tpTimKiem.Controls.Add(this.groupBox6);
            this.tpTimKiem.Location = new System.Drawing.Point(4, 25);
            this.tpTimKiem.Name = "tpTimKiem";
            this.tpTimKiem.Padding = new System.Windows.Forms.Padding(3);
            this.tpTimKiem.Size = new System.Drawing.Size(1002, 568);
            this.tpTimKiem.TabIndex = 2;
            this.tpTimKiem.Text = "Tìm Kiếm";
            this.tpTimKiem.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.dtgvTimKiem);
            this.groupBox7.Location = new System.Drawing.Point(41, 207);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(926, 215);
            this.groupBox7.TabIndex = 1;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Kết quả tìm kiếm :";
            // 
            // dtgvTimKiem
            // 
            this.dtgvTimKiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgvTimKiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTimKiem.Location = new System.Drawing.Point(15, 18);
            this.dtgvTimKiem.Name = "dtgvTimKiem";
            this.dtgvTimKiem.ReadOnly = true;
            this.dtgvTimKiem.Size = new System.Drawing.Size(902, 193);
            this.dtgvTimKiem.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.TKTheoDiaChi);
            this.groupBox6.Controls.Add(this.cbTheoDiaChi);
            this.groupBox6.Controls.Add(this.TKTheoSoDT);
            this.groupBox6.Controls.Add(this.cbTheoDT);
            this.groupBox6.Controls.Add(this.btTimKiem);
            this.groupBox6.Controls.Add(this.TKTheoCMND);
            this.groupBox6.Controls.Add(this.cbTheoCMND);
            this.groupBox6.Controls.Add(this.TKTheoMa);
            this.groupBox6.Controls.Add(this.cbTheoMaKH);
            this.groupBox6.Controls.Add(this.TKDenNgay);
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Controls.Add(this.TKTuNgay);
            this.groupBox6.Controls.Add(this.TKTheoTen);
            this.groupBox6.Controls.Add(this.TKTheoPhong);
            this.groupBox6.Controls.Add(this.cbThoiGian);
            this.groupBox6.Controls.Add(this.cbTheoTen);
            this.groupBox6.Controls.Add(this.cbTheoPhong);
            this.groupBox6.Location = new System.Drawing.Point(41, 46);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(926, 157);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Chọn thông tin tìm kiếm : ";
            // 
            // TKTheoDiaChi
            // 
            this.TKTheoDiaChi.Enabled = false;
            this.TKTheoDiaChi.Location = new System.Drawing.Point(578, 114);
            this.TKTheoDiaChi.Name = "TKTheoDiaChi";
            this.TKTheoDiaChi.Size = new System.Drawing.Size(137, 22);
            this.TKTheoDiaChi.TabIndex = 16;
            // 
            // cbTheoDiaChi
            // 
            this.cbTheoDiaChi.AutoSize = true;
            this.cbTheoDiaChi.Location = new System.Drawing.Point(462, 115);
            this.cbTheoDiaChi.Name = "cbTheoDiaChi";
            this.cbTheoDiaChi.Size = new System.Drawing.Size(110, 20);
            this.cbTheoDiaChi.TabIndex = 15;
            this.cbTheoDiaChi.Text = "Theo Địa Chị :";
            this.cbTheoDiaChi.UseVisualStyleBackColor = true;
            // 
            // TKTheoSoDT
            // 
            this.TKTheoSoDT.Location = new System.Drawing.Point(204, 112);
            this.TKTheoSoDT.Name = "TKTheoSoDT";
            this.TKTheoSoDT.Size = new System.Drawing.Size(183, 22);
            this.TKTheoSoDT.TabIndex = 14;
            // 
            // cbTheoDT
            // 
            this.cbTheoDT.AutoSize = true;
            this.cbTheoDT.Location = new System.Drawing.Point(83, 113);
            this.cbTheoDT.Name = "cbTheoDT";
            this.cbTheoDT.Size = new System.Drawing.Size(104, 20);
            this.cbTheoDT.TabIndex = 13;
            this.cbTheoDT.Text = "Theo số ĐT :";
            this.cbTheoDT.UseVisualStyleBackColor = true;
            // 
            // btTimKiem
            // 
            this.btTimKiem.Location = new System.Drawing.Point(763, 52);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(109, 51);
            this.btTimKiem.TabIndex = 12;
            this.btTimKiem.Text = "Tìm Kiếm";
            this.btTimKiem.UseVisualStyleBackColor = true;
            // 
            // TKTheoCMND
            // 
            this.TKTheoCMND.Enabled = false;
            this.TKTheoCMND.Location = new System.Drawing.Point(576, 52);
            this.TKTheoCMND.Name = "TKTheoCMND";
            this.TKTheoCMND.Size = new System.Drawing.Size(139, 22);
            this.TKTheoCMND.TabIndex = 11;
            // 
            // cbTheoCMND
            // 
            this.cbTheoCMND.AutoSize = true;
            this.cbTheoCMND.Location = new System.Drawing.Point(462, 54);
            this.cbTheoCMND.Name = "cbTheoCMND";
            this.cbTheoCMND.Size = new System.Drawing.Size(102, 20);
            this.cbTheoCMND.TabIndex = 10;
            this.cbTheoCMND.Text = "Theo CMND";
            this.cbTheoCMND.UseVisualStyleBackColor = true;
            // 
            // TKTheoMa
            // 
            this.TKTheoMa.Enabled = false;
            this.TKTheoMa.Location = new System.Drawing.Point(576, 21);
            this.TKTheoMa.Name = "TKTheoMa";
            this.TKTheoMa.Size = new System.Drawing.Size(139, 22);
            this.TKTheoMa.TabIndex = 9;
            // 
            // cbTheoMaKH
            // 
            this.cbTheoMaKH.AutoSize = true;
            this.cbTheoMaKH.Location = new System.Drawing.Point(462, 27);
            this.cbTheoMaKH.Name = "cbTheoMaKH";
            this.cbTheoMaKH.Size = new System.Drawing.Size(102, 20);
            this.cbTheoMaKH.TabIndex = 8;
            this.cbTheoMaKH.Text = "Theo mã KH";
            this.cbTheoMaKH.UseVisualStyleBackColor = true;
            // 
            // TKDenNgay
            // 
            this.TKDenNgay.CustomFormat = "dd/MM/yyyy";
            this.TKDenNgay.Enabled = false;
            this.TKDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TKDenNgay.Location = new System.Drawing.Point(576, 81);
            this.TKDenNgay.Name = "TKDenNgay";
            this.TKDenNgay.Size = new System.Drawing.Size(140, 22);
            this.TKDenNgay.TabIndex = 7;
            this.TKDenNgay.Value = new System.DateTime(2008, 12, 15, 0, 0, 0, 0);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(470, 83);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 16);
            this.label13.TabIndex = 6;
            this.label13.Text = "đến ngày :";
            // 
            // TKTuNgay
            // 
            this.TKTuNgay.CustomFormat = "dd/MM/yyyy";
            this.TKTuNgay.Enabled = false;
            this.TKTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TKTuNgay.Location = new System.Drawing.Point(204, 80);
            this.TKTuNgay.Name = "TKTuNgay";
            this.TKTuNgay.Size = new System.Drawing.Size(183, 22);
            this.TKTuNgay.TabIndex = 5;
            this.TKTuNgay.Value = new System.DateTime(2008, 12, 15, 0, 0, 0, 0);
            // 
            // TKTheoTen
            // 
            this.TKTheoTen.Enabled = false;
            this.TKTheoTen.Location = new System.Drawing.Point(204, 53);
            this.TKTheoTen.Name = "TKTheoTen";
            this.TKTheoTen.Size = new System.Drawing.Size(183, 22);
            this.TKTheoTen.TabIndex = 4;
            // 
            // TKTheoPhong
            // 
            this.TKTheoPhong.Enabled = false;
            this.TKTheoPhong.FormattingEnabled = true;
            this.TKTheoPhong.Location = new System.Drawing.Point(204, 25);
            this.TKTheoPhong.Name = "TKTheoPhong";
            this.TKTheoPhong.Size = new System.Drawing.Size(183, 24);
            this.TKTheoPhong.TabIndex = 3;
            // 
            // cbThoiGian
            // 
            this.cbThoiGian.AutoSize = true;
            this.cbThoiGian.Location = new System.Drawing.Point(83, 81);
            this.cbThoiGian.Name = "cbThoiGian";
            this.cbThoiGian.Size = new System.Drawing.Size(97, 20);
            this.cbThoiGian.TabIndex = 2;
            this.cbThoiGian.Text = "Thời gian ở ";
            this.cbThoiGian.UseVisualStyleBackColor = true;
            // 
            // cbTheoTen
            // 
            this.cbTheoTen.AutoSize = true;
            this.cbTheoTen.Location = new System.Drawing.Point(83, 54);
            this.cbTheoTen.Name = "cbTheoTen";
            this.cbTheoTen.Size = new System.Drawing.Size(89, 20);
            this.cbTheoTen.TabIndex = 1;
            this.cbTheoTen.Text = "Theo Tên ";
            this.cbTheoTen.UseVisualStyleBackColor = true;
            // 
            // cbTheoPhong
            // 
            this.cbTheoPhong.AutoSize = true;
            this.cbTheoPhong.Location = new System.Drawing.Point(83, 27);
            this.cbTheoPhong.Name = "cbTheoPhong";
            this.cbTheoPhong.Size = new System.Drawing.Size(100, 20);
            this.cbTheoPhong.TabIndex = 0;
            this.cbTheoPhong.Text = "Theo phòng";
            this.cbTheoPhong.UseVisualStyleBackColor = true;
            // 
            // tpTraPhong
            // 
            this.tpTraPhong.Location = new System.Drawing.Point(4, 25);
            this.tpTraPhong.Name = "tpTraPhong";
            this.tpTraPhong.Size = new System.Drawing.Size(1002, 568);
            this.tpTraPhong.TabIndex = 3;
            this.tpTraPhong.Text = "Trả Phòng";
            this.tpTraPhong.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 600);
            this.Controls.Add(this.Tabphong);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Tabphong.ResumeLayout(false);
            this.tpDanhSanh.ResumeLayout(false);
            this.tpDanhSanh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachphong)).EndInit();
            this.tpThuePhong.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgkhachhang)).EndInit();
            this.groupBDatPhong.ResumeLayout(false);
            this.groupBDatPhong.PerformLayout();
            this.tpTimKiem.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTimKiem)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

          }

          #endregion

          private System.Windows.Forms.TabControl Tabphong;
          private System.Windows.Forms.TabPage tpDanhSanh;
          private System.Windows.Forms.DataGridView dtgvDanhSachphong;
          private System.Windows.Forms.Button btndangxuat;
          private System.Windows.Forms.Label label2;
          private System.Windows.Forms.TabPage tpThuePhong;
          private System.Windows.Forms.Button bHuyBo;
          private System.Windows.Forms.Button btThuePhongOK;
          private System.Windows.Forms.GroupBox groupBox5;
          private System.Windows.Forms.DataGridView dgkhachhang;
          private System.Windows.Forms.Label label6;
          private System.Windows.Forms.Label label5;
          private System.Windows.Forms.TextBox txtmakhtp;
          private System.Windows.Forms.Label label4;
          private System.Windows.Forms.GroupBox groupBDatPhong;
          internal System.Windows.Forms.DateTimePicker dtngaydattruoc;
          private System.Windows.Forms.Label label3;
          private System.Windows.Forms.TextBox txtphongdt;
          private System.Windows.Forms.Label label1;
          private System.Windows.Forms.CheckBox checkBDatPhongTruoc;
          private System.Windows.Forms.TextBox txtPhongtp;
          internal System.Windows.Forms.DateTimePicker dtTuNgaytp;
          private System.Windows.Forms.Label label12;
          private System.Windows.Forms.Label label9;
          private System.Windows.Forms.TabPage tpTimKiem;
          private System.Windows.Forms.GroupBox groupBox7;
          private System.Windows.Forms.DataGridView dtgvTimKiem;
          private System.Windows.Forms.GroupBox groupBox6;
          private System.Windows.Forms.TextBox TKTheoDiaChi;
          private System.Windows.Forms.CheckBox cbTheoDiaChi;
          private System.Windows.Forms.TextBox TKTheoSoDT;
          private System.Windows.Forms.CheckBox cbTheoDT;
          private System.Windows.Forms.Button btTimKiem;
          private System.Windows.Forms.TextBox TKTheoCMND;
          private System.Windows.Forms.CheckBox cbTheoCMND;
          private System.Windows.Forms.TextBox TKTheoMa;
          private System.Windows.Forms.CheckBox cbTheoMaKH;
          private System.Windows.Forms.DateTimePicker TKDenNgay;
          private System.Windows.Forms.Label label13;
          private System.Windows.Forms.DateTimePicker TKTuNgay;
          private System.Windows.Forms.TextBox TKTheoTen;
          private System.Windows.Forms.ComboBox TKTheoPhong;
          private System.Windows.Forms.CheckBox cbThoiGian;
          private System.Windows.Forms.CheckBox cbTheoTen;
          private System.Windows.Forms.CheckBox cbTheoPhong;
          private System.Windows.Forms.DataGridViewTextBoxColumn maPhong;
          private System.Windows.Forms.DataGridViewTextBoxColumn loaiPhong;
          private System.Windows.Forms.DataGridViewTextBoxColumn tinhTrang;
          private System.Windows.Forms.DataGridViewTextBoxColumn donGia;
          private System.Windows.Forms.DataGridViewTextBoxColumn maKhachHang;
          private System.Windows.Forms.DataGridViewTextBoxColumn tenKhachHang;
          private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinh;
          private System.Windows.Forms.DataGridViewTextBoxColumn gioiTinh;
          private System.Windows.Forms.DataGridViewTextBoxColumn chungMinhNhanDan;
          private System.Windows.Forms.DataGridViewTextBoxColumn soDienThoai;
          private System.Windows.Forms.DataGridViewTextBoxColumn diaChi;
          private System.Windows.Forms.DataGridViewTextBoxColumn quocTich;
        private System.Windows.Forms.TabPage tpTraPhong;
    }
}