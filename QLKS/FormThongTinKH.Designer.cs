﻿namespace QLKS
{
     partial class FormThongTinKH
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
               this.button1 = new System.Windows.Forms.Button();
               this.cbquoctich = new System.Windows.Forms.ComboBox();
               this.dtngaysinh = new System.Windows.Forms.DateTimePicker();
               this.cbgiotinhkh = new System.Windows.Forms.ComboBox();
               this.label9 = new System.Windows.Forms.Label();
               this.txtsdt = new System.Windows.Forms.TextBox();
               this.txtdiachi = new System.Windows.Forms.TextBox();
               this.txtcmt = new System.Windows.Forms.TextBox();
               this.txttenkh = new System.Windows.Forms.TextBox();
               this.txtmakhachhang = new System.Windows.Forms.TextBox();
               this.btnthoat = new System.Windows.Forms.Button();
               this.btnluu = new System.Windows.Forms.Button();
               this.btnxoa = new System.Windows.Forms.Button();
               this.btnsua = new System.Windows.Forms.Button();
               this.label6 = new System.Windows.Forms.Label();
               this.label7 = new System.Windows.Forms.Label();
               this.label8 = new System.Windows.Forms.Label();
               this.label3 = new System.Windows.Forms.Label();
               this.label2 = new System.Windows.Forms.Label();
               this.label1 = new System.Windows.Forms.Label();
               this.label5 = new System.Windows.Forms.Label();
               this.quocTich = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.diaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.soDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.chungMinhNhanDan = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.gioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.ngaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.tenKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.maKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.label4 = new System.Windows.Forms.Label();
               this.dataGridView1 = new System.Windows.Forms.DataGridView();
               ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
               this.SuspendLayout();
               // 
               // button1
               // 
               this.button1.Location = new System.Drawing.Point(130, 434);
               this.button1.Name = "button1";
               this.button1.Size = new System.Drawing.Size(78, 37);
               this.button1.TabIndex = 50;
               this.button1.Text = "&Thêm";
               this.button1.UseVisualStyleBackColor = true;
               // 
               // cbquoctich
               // 
               this.cbquoctich.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               this.cbquoctich.FormattingEnabled = true;
               this.cbquoctich.Items.AddRange(new object[] {
            "VIỆT NAM",
            "LÀO",
            "THÁI LAN"});
               this.cbquoctich.Location = new System.Drawing.Point(560, 383);
               this.cbquoctich.Name = "cbquoctich";
               this.cbquoctich.Size = new System.Drawing.Size(158, 27);
               this.cbquoctich.TabIndex = 49;
               // 
               // dtngaysinh
               // 
               this.dtngaysinh.CalendarFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               this.dtngaysinh.CustomFormat = "dd/MM/yyyy";
               this.dtngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
               this.dtngaysinh.Location = new System.Drawing.Point(211, 381);
               this.dtngaysinh.Name = "dtngaysinh";
               this.dtngaysinh.Size = new System.Drawing.Size(159, 20);
               this.dtngaysinh.TabIndex = 48;
               this.dtngaysinh.TabStop = false;
               // 
               // cbgiotinhkh
               // 
               this.cbgiotinhkh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               this.cbgiotinhkh.FormattingEnabled = true;
               this.cbgiotinhkh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
               this.cbgiotinhkh.Location = new System.Drawing.Point(211, 341);
               this.cbgiotinhkh.Name = "cbgiotinhkh";
               this.cbgiotinhkh.Size = new System.Drawing.Size(158, 27);
               this.cbgiotinhkh.TabIndex = 47;
               // 
               // label9
               // 
               this.label9.AutoSize = true;
               this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               this.label9.Location = new System.Drawing.Point(77, 383);
               this.label9.Name = "label9";
               this.label9.Size = new System.Drawing.Size(76, 19);
               this.label9.TabIndex = 46;
               this.label9.Text = "Ngày sinh :";
               // 
               // txtsdt
               // 
               this.txtsdt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               this.txtsdt.Location = new System.Drawing.Point(560, 341);
               this.txtsdt.Name = "txtsdt";
               this.txtsdt.Size = new System.Drawing.Size(159, 26);
               this.txtsdt.TabIndex = 45;
               // 
               // txtdiachi
               // 
               this.txtdiachi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               this.txtdiachi.Location = new System.Drawing.Point(560, 304);
               this.txtdiachi.Name = "txtdiachi";
               this.txtdiachi.Size = new System.Drawing.Size(159, 26);
               this.txtdiachi.TabIndex = 44;
               // 
               // txtcmt
               // 
               this.txtcmt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               this.txtcmt.Location = new System.Drawing.Point(560, 256);
               this.txtcmt.Name = "txtcmt";
               this.txtcmt.Size = new System.Drawing.Size(159, 26);
               this.txtcmt.TabIndex = 43;
               // 
               // txttenkh
               // 
               this.txttenkh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               this.txttenkh.Location = new System.Drawing.Point(211, 304);
               this.txttenkh.Name = "txttenkh";
               this.txttenkh.Size = new System.Drawing.Size(159, 26);
               this.txttenkh.TabIndex = 42;
               // 
               // txtmakhachhang
               // 
               this.txtmakhachhang.Enabled = false;
               this.txtmakhachhang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               this.txtmakhachhang.Location = new System.Drawing.Point(211, 256);
               this.txtmakhachhang.Name = "txtmakhachhang";
               this.txtmakhachhang.Size = new System.Drawing.Size(159, 26);
               this.txtmakhachhang.TabIndex = 41;
               // 
               // btnthoat
               // 
               this.btnthoat.Location = new System.Drawing.Point(605, 434);
               this.btnthoat.Name = "btnthoat";
               this.btnthoat.Size = new System.Drawing.Size(78, 37);
               this.btnthoat.TabIndex = 39;
               this.btnthoat.Text = "Thoát";
               this.btnthoat.UseVisualStyleBackColor = true;
               // 
               // btnluu
               // 
               this.btnluu.Location = new System.Drawing.Point(487, 434);
               this.btnluu.Name = "btnluu";
               this.btnluu.Size = new System.Drawing.Size(78, 37);
               this.btnluu.TabIndex = 38;
               this.btnluu.Text = "&Lưu";
               this.btnluu.UseVisualStyleBackColor = true;
               // 
               // btnxoa
               // 
               this.btnxoa.Location = new System.Drawing.Point(366, 434);
               this.btnxoa.Name = "btnxoa";
               this.btnxoa.Size = new System.Drawing.Size(78, 37);
               this.btnxoa.TabIndex = 37;
               this.btnxoa.Text = "&Xóa";
               this.btnxoa.UseVisualStyleBackColor = true;
               // 
               // btnsua
               // 
               this.btnsua.Location = new System.Drawing.Point(248, 434);
               this.btnsua.Name = "btnsua";
               this.btnsua.Size = new System.Drawing.Size(78, 37);
               this.btnsua.TabIndex = 36;
               this.btnsua.Text = "&Sửa";
               this.btnsua.UseVisualStyleBackColor = true;
               // 
               // label6
               // 
               this.label6.AutoSize = true;
               this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               this.label6.Location = new System.Drawing.Point(442, 383);
               this.label6.Name = "label6";
               this.label6.Size = new System.Drawing.Size(75, 19);
               this.label6.TabIndex = 35;
               this.label6.Text = "Quốc tịch :";
               // 
               // label7
               // 
               this.label7.AutoSize = true;
               this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               this.label7.Location = new System.Drawing.Point(442, 346);
               this.label7.Name = "label7";
               this.label7.Size = new System.Drawing.Size(95, 19);
               this.label7.TabIndex = 34;
               this.label7.Text = "Số điện thoại :";
               // 
               // label8
               // 
               this.label8.AutoSize = true;
               this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               this.label8.Location = new System.Drawing.Point(442, 304);
               this.label8.Name = "label8";
               this.label8.Size = new System.Drawing.Size(58, 19);
               this.label8.TabIndex = 33;
               this.label8.Text = "Địa chỉ :";
               // 
               // label3
               // 
               this.label3.AutoSize = true;
               this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               this.label3.Location = new System.Drawing.Point(77, 348);
               this.label3.Name = "label3";
               this.label3.Size = new System.Drawing.Size(66, 19);
               this.label3.TabIndex = 31;
               this.label3.Text = "Giới tính :";
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               this.label2.Location = new System.Drawing.Point(77, 304);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(111, 19);
               this.label2.TabIndex = 30;
               this.label2.Text = "Tên khách hàng :";
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               this.label1.Location = new System.Drawing.Point(77, 258);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(109, 19);
               this.label1.TabIndex = 29;
               this.label1.Text = "Mã khách hàng :";
               // 
               // label5
               // 
               this.label5.AutoSize = true;
               this.label5.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               this.label5.ForeColor = System.Drawing.Color.Red;
               this.label5.Location = new System.Drawing.Point(217, 9);
               this.label5.Name = "label5";
               this.label5.Size = new System.Drawing.Size(367, 31);
               this.label5.TabIndex = 40;
               this.label5.Text = "THÔNG TIN KHÁCH HÀNG";
               // 
               // quocTich
               // 
               this.quocTich.DataPropertyName = "quocTich";
               this.quocTich.HeaderText = "Quốc tịch";
               this.quocTich.Name = "quocTich";
               this.quocTich.ReadOnly = true;
               // 
               // diaChi
               // 
               this.diaChi.DataPropertyName = "diaChi";
               this.diaChi.HeaderText = "Địa chỉ";
               this.diaChi.Name = "diaChi";
               this.diaChi.ReadOnly = true;
               // 
               // soDienThoai
               // 
               this.soDienThoai.DataPropertyName = "soDienThoai";
               this.soDienThoai.HeaderText = "Số điện thoại";
               this.soDienThoai.Name = "soDienThoai";
               this.soDienThoai.ReadOnly = true;
               // 
               // chungMinhNhanDan
               // 
               this.chungMinhNhanDan.DataPropertyName = "chungMinhNhanDan";
               this.chungMinhNhanDan.HeaderText = "Chứng minh thư";
               this.chungMinhNhanDan.Name = "chungMinhNhanDan";
               this.chungMinhNhanDan.ReadOnly = true;
               // 
               // gioiTinh
               // 
               this.gioiTinh.DataPropertyName = "gioiTinh";
               this.gioiTinh.HeaderText = "Giới tính";
               this.gioiTinh.Name = "gioiTinh";
               this.gioiTinh.ReadOnly = true;
               // 
               // ngaySinh
               // 
               this.ngaySinh.DataPropertyName = "ngaySinh";
               this.ngaySinh.HeaderText = "Ngày sinh";
               this.ngaySinh.Name = "ngaySinh";
               this.ngaySinh.ReadOnly = true;
               // 
               // tenKhachHang
               // 
               this.tenKhachHang.DataPropertyName = "tenKhachHang";
               this.tenKhachHang.HeaderText = "Tên khách hàng";
               this.tenKhachHang.Name = "tenKhachHang";
               this.tenKhachHang.ReadOnly = true;
               // 
               // maKhachHang
               // 
               this.maKhachHang.DataPropertyName = "maKhachHang";
               this.maKhachHang.HeaderText = "Mã khách hàng";
               this.maKhachHang.Name = "maKhachHang";
               this.maKhachHang.ReadOnly = true;
               // 
               // label4
               // 
               this.label4.AutoSize = true;
               this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               this.label4.Location = new System.Drawing.Point(442, 259);
               this.label4.Name = "label4";
               this.label4.Size = new System.Drawing.Size(86, 19);
               this.label4.TabIndex = 32;
               this.label4.Text = "Số CMNN :";
               // 
               // dataGridView1
               // 
               this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maKhachHang,
            this.tenKhachHang,
            this.ngaySinh,
            this.gioiTinh,
            this.chungMinhNhanDan,
            this.soDienThoai,
            this.diaChi,
            this.quocTich});
               this.dataGridView1.Location = new System.Drawing.Point(14, 57);
               this.dataGridView1.Name = "dataGridView1";
               this.dataGridView1.ReadOnly = true;
               this.dataGridView1.Size = new System.Drawing.Size(774, 177);
               this.dataGridView1.TabIndex = 28;
               // 
               // FormThongTinKH
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(807, 514);
               this.Controls.Add(this.button1);
               this.Controls.Add(this.cbquoctich);
               this.Controls.Add(this.dtngaysinh);
               this.Controls.Add(this.cbgiotinhkh);
               this.Controls.Add(this.label9);
               this.Controls.Add(this.txtsdt);
               this.Controls.Add(this.txtdiachi);
               this.Controls.Add(this.txtcmt);
               this.Controls.Add(this.txttenkh);
               this.Controls.Add(this.txtmakhachhang);
               this.Controls.Add(this.btnthoat);
               this.Controls.Add(this.btnluu);
               this.Controls.Add(this.btnxoa);
               this.Controls.Add(this.btnsua);
               this.Controls.Add(this.label6);
               this.Controls.Add(this.label7);
               this.Controls.Add(this.label8);
               this.Controls.Add(this.label3);
               this.Controls.Add(this.label2);
               this.Controls.Add(this.label1);
               this.Controls.Add(this.label5);
               this.Controls.Add(this.label4);
               this.Controls.Add(this.dataGridView1);
               this.Name = "FormThongTinKH";
               this.Text = "FormThongTinKH";
               ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.Button button1;
          private System.Windows.Forms.ComboBox cbquoctich;
          private System.Windows.Forms.DateTimePicker dtngaysinh;
          private System.Windows.Forms.ComboBox cbgiotinhkh;
          private System.Windows.Forms.Label label9;
          private System.Windows.Forms.TextBox txtsdt;
          private System.Windows.Forms.TextBox txtdiachi;
          private System.Windows.Forms.TextBox txtcmt;
          private System.Windows.Forms.TextBox txttenkh;
          private System.Windows.Forms.TextBox txtmakhachhang;
          private System.Windows.Forms.Button btnthoat;
          private System.Windows.Forms.Button btnluu;
          private System.Windows.Forms.Button btnxoa;
          private System.Windows.Forms.Button btnsua;
          private System.Windows.Forms.Label label6;
          private System.Windows.Forms.Label label7;
          private System.Windows.Forms.Label label8;
          private System.Windows.Forms.Label label3;
          private System.Windows.Forms.Label label2;
          private System.Windows.Forms.Label label1;
          private System.Windows.Forms.Label label5;
          private System.Windows.Forms.DataGridViewTextBoxColumn quocTich;
          private System.Windows.Forms.DataGridViewTextBoxColumn diaChi;
          private System.Windows.Forms.DataGridViewTextBoxColumn soDienThoai;
          private System.Windows.Forms.DataGridViewTextBoxColumn chungMinhNhanDan;
          private System.Windows.Forms.DataGridViewTextBoxColumn gioiTinh;
          private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinh;
          private System.Windows.Forms.DataGridViewTextBoxColumn tenKhachHang;
          private System.Windows.Forms.DataGridViewTextBoxColumn maKhachHang;
          private System.Windows.Forms.Label label4;
          private System.Windows.Forms.DataGridView dataGridView1;
     }
}