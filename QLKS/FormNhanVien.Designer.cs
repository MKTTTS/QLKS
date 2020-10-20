namespace QLKS
{
     partial class FormNhanVien
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
               this.ngayVaoLam = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.soDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.btnhuy = new System.Windows.Forms.Button();
               this.dtngayvaolam = new System.Windows.Forms.DateTimePicker();
               this.dtngaysinh = new System.Windows.Forms.DateTimePicker();
               this.cbgioitinh = new System.Windows.Forms.ComboBox();
               this.btnthem = new System.Windows.Forms.Button();
               this.label6 = new System.Windows.Forms.Label();
               this.label9 = new System.Windows.Forms.Label();
               this.txtsdt = new System.Windows.Forms.TextBox();
               this.txtdiachi = new System.Windows.Forms.TextBox();
               this.txtscm = new System.Windows.Forms.TextBox();
               this.txttennv = new System.Windows.Forms.TextBox();
               this.txtmanv = new System.Windows.Forms.TextBox();
               this.btnthoat = new System.Windows.Forms.Button();
               this.btnluu = new System.Windows.Forms.Button();
               this.btnxoa = new System.Windows.Forms.Button();
               this.btnsua = new System.Windows.Forms.Button();
               this.label7 = new System.Windows.Forms.Label();
               this.label8 = new System.Windows.Forms.Label();
               this.label4 = new System.Windows.Forms.Label();
               this.label3 = new System.Windows.Forms.Label();
               this.label2 = new System.Windows.Forms.Label();
               this.soChungMinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.ngaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.label5 = new System.Windows.Forms.Label();
               this.gioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.hoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.maNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.label1 = new System.Windows.Forms.Label();
               this.diaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.dataGridView1 = new System.Windows.Forms.DataGridView();
               ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
               this.SuspendLayout();
               // 
               // ngayVaoLam
               // 
               this.ngayVaoLam.DataPropertyName = "ngayVaoLam";
               this.ngayVaoLam.HeaderText = "Ngày Vào Làm";
               this.ngayVaoLam.Name = "ngayVaoLam";
               this.ngayVaoLam.ReadOnly = true;
               // 
               // soDienThoai
               // 
               this.soDienThoai.DataPropertyName = "soDienThoai";
               this.soDienThoai.HeaderText = "Số điện thoại";
               this.soDienThoai.Name = "soDienThoai";
               this.soDienThoai.ReadOnly = true;
               // 
               // btnhuy
               // 
               this.btnhuy.Location = new System.Drawing.Point(604, 439);
               this.btnhuy.Name = "btnhuy";
               this.btnhuy.Size = new System.Drawing.Size(78, 37);
               this.btnhuy.TabIndex = 77;
               this.btnhuy.Text = "&Hủy";
               this.btnhuy.UseVisualStyleBackColor = true;
               // 
               // dtngayvaolam
               // 
               this.dtngayvaolam.CalendarFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               this.dtngayvaolam.CustomFormat = "dd/MM/yyyy";
               this.dtngayvaolam.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
               this.dtngayvaolam.Location = new System.Drawing.Point(619, 386);
               this.dtngayvaolam.Name = "dtngayvaolam";
               this.dtngayvaolam.Size = new System.Drawing.Size(159, 20);
               this.dtngayvaolam.TabIndex = 76;
               this.dtngayvaolam.TabStop = false;
               // 
               // dtngaysinh
               // 
               this.dtngaysinh.CalendarFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               this.dtngaysinh.CustomFormat = "dd/MM/yyyy";
               this.dtngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
               this.dtngaysinh.Location = new System.Drawing.Point(270, 386);
               this.dtngaysinh.Name = "dtngaysinh";
               this.dtngaysinh.Size = new System.Drawing.Size(159, 20);
               this.dtngaysinh.TabIndex = 75;
               this.dtngaysinh.TabStop = false;
               // 
               // cbgioitinh
               // 
               this.cbgioitinh.FormattingEnabled = true;
               this.cbgioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
               this.cbgioitinh.Location = new System.Drawing.Point(270, 349);
               this.cbgioitinh.Name = "cbgioitinh";
               this.cbgioitinh.Size = new System.Drawing.Size(159, 21);
               this.cbgioitinh.TabIndex = 74;
               // 
               // btnthem
               // 
               this.btnthem.Location = new System.Drawing.Point(140, 439);
               this.btnthem.Name = "btnthem";
               this.btnthem.Size = new System.Drawing.Size(78, 37);
               this.btnthem.TabIndex = 73;
               this.btnthem.Text = "&Thêm";
               this.btnthem.UseVisualStyleBackColor = true;
               // 
               // label6
               // 
               this.label6.AutoSize = true;
               this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               this.label6.Location = new System.Drawing.Point(501, 388);
               this.label6.Name = "label6";
               this.label6.Size = new System.Drawing.Size(100, 19);
               this.label6.TabIndex = 72;
               this.label6.Text = "Ngày vào làm :";
               // 
               // label9
               // 
               this.label9.AutoSize = true;
               this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               this.label9.Location = new System.Drawing.Point(136, 388);
               this.label9.Name = "label9";
               this.label9.Size = new System.Drawing.Size(76, 19);
               this.label9.TabIndex = 71;
               this.label9.Text = "Ngày sinh :";
               // 
               // txtsdt
               // 
               this.txtsdt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               this.txtsdt.Location = new System.Drawing.Point(619, 348);
               this.txtsdt.Multiline = true;
               this.txtsdt.Name = "txtsdt";
               this.txtsdt.Size = new System.Drawing.Size(159, 21);
               this.txtsdt.TabIndex = 70;
               // 
               // txtdiachi
               // 
               this.txtdiachi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               this.txtdiachi.Location = new System.Drawing.Point(619, 306);
               this.txtdiachi.Multiline = true;
               this.txtdiachi.Name = "txtdiachi";
               this.txtdiachi.Size = new System.Drawing.Size(159, 21);
               this.txtdiachi.TabIndex = 69;
               // 
               // txtscm
               // 
               this.txtscm.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               this.txtscm.Location = new System.Drawing.Point(619, 261);
               this.txtscm.Multiline = true;
               this.txtscm.Name = "txtscm";
               this.txtscm.Size = new System.Drawing.Size(159, 20);
               this.txtscm.TabIndex = 68;
               // 
               // txttennv
               // 
               this.txttennv.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               this.txttennv.Location = new System.Drawing.Point(270, 306);
               this.txttennv.Multiline = true;
               this.txttennv.Name = "txttennv";
               this.txttennv.Size = new System.Drawing.Size(159, 21);
               this.txttennv.TabIndex = 67;
               // 
               // txtmanv
               // 
               this.txtmanv.Enabled = false;
               this.txtmanv.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               this.txtmanv.Location = new System.Drawing.Point(270, 260);
               this.txtmanv.Multiline = true;
               this.txtmanv.Name = "txtmanv";
               this.txtmanv.Size = new System.Drawing.Size(159, 20);
               this.txtmanv.TabIndex = 66;
               // 
               // btnthoat
               // 
               this.btnthoat.Location = new System.Drawing.Point(700, 439);
               this.btnthoat.Name = "btnthoat";
               this.btnthoat.Size = new System.Drawing.Size(78, 37);
               this.btnthoat.TabIndex = 64;
               this.btnthoat.Text = "Thoát";
               this.btnthoat.UseVisualStyleBackColor = true;
               // 
               // btnluu
               // 
               this.btnluu.Location = new System.Drawing.Point(505, 439);
               this.btnluu.Name = "btnluu";
               this.btnluu.Size = new System.Drawing.Size(78, 37);
               this.btnluu.TabIndex = 63;
               this.btnluu.Text = "&Lưu";
               this.btnluu.UseVisualStyleBackColor = true;
               // 
               // btnxoa
               // 
               this.btnxoa.Location = new System.Drawing.Point(351, 439);
               this.btnxoa.Name = "btnxoa";
               this.btnxoa.Size = new System.Drawing.Size(78, 37);
               this.btnxoa.TabIndex = 62;
               this.btnxoa.Text = "&Xóa";
               this.btnxoa.UseVisualStyleBackColor = true;
               // 
               // btnsua
               // 
               this.btnsua.Location = new System.Drawing.Point(248, 439);
               this.btnsua.Name = "btnsua";
               this.btnsua.Size = new System.Drawing.Size(78, 37);
               this.btnsua.TabIndex = 61;
               this.btnsua.Text = "&Sửa";
               this.btnsua.UseVisualStyleBackColor = true;
               // 
               // label7
               // 
               this.label7.AutoSize = true;
               this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               this.label7.Location = new System.Drawing.Point(501, 351);
               this.label7.Name = "label7";
               this.label7.Size = new System.Drawing.Size(95, 19);
               this.label7.TabIndex = 60;
               this.label7.Text = "Số điện thoại :";
               // 
               // label8
               // 
               this.label8.AutoSize = true;
               this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               this.label8.Location = new System.Drawing.Point(501, 309);
               this.label8.Name = "label8";
               this.label8.Size = new System.Drawing.Size(58, 19);
               this.label8.TabIndex = 59;
               this.label8.Text = "Địa chỉ :";
               // 
               // label4
               // 
               this.label4.AutoSize = true;
               this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               this.label4.Location = new System.Drawing.Point(501, 264);
               this.label4.Name = "label4";
               this.label4.Size = new System.Drawing.Size(86, 19);
               this.label4.TabIndex = 58;
               this.label4.Text = "Số CMNN :";
               // 
               // label3
               // 
               this.label3.AutoSize = true;
               this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               this.label3.Location = new System.Drawing.Point(136, 353);
               this.label3.Name = "label3";
               this.label3.Size = new System.Drawing.Size(66, 19);
               this.label3.TabIndex = 57;
               this.label3.Text = "Giới tính :";
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               this.label2.Location = new System.Drawing.Point(136, 309);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(99, 19);
               this.label2.TabIndex = 56;
               this.label2.Text = "Tên nhân viên :";
               // 
               // soChungMinh
               // 
               this.soChungMinh.DataPropertyName = "soChungMinh";
               this.soChungMinh.HeaderText = "Số chứng minh";
               this.soChungMinh.Name = "soChungMinh";
               this.soChungMinh.ReadOnly = true;
               // 
               // ngaySinh
               // 
               this.ngaySinh.DataPropertyName = "ngaySinh";
               this.ngaySinh.HeaderText = "Ngày sinh";
               this.ngaySinh.Name = "ngaySinh";
               this.ngaySinh.ReadOnly = true;
               // 
               // label5
               // 
               this.label5.AutoSize = true;
               this.label5.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               this.label5.ForeColor = System.Drawing.Color.Red;
               this.label5.Location = new System.Drawing.Point(293, 9);
               this.label5.Name = "label5";
               this.label5.Size = new System.Drawing.Size(331, 31);
               this.label5.TabIndex = 65;
               this.label5.Text = "THÔNG TIN NHÂN VIÊN";
               // 
               // gioiTinh
               // 
               this.gioiTinh.DataPropertyName = "gioiTinh";
               this.gioiTinh.HeaderText = "Giới tính";
               this.gioiTinh.Name = "gioiTinh";
               this.gioiTinh.ReadOnly = true;
               // 
               // hoTen
               // 
               this.hoTen.DataPropertyName = "hoTen";
               this.hoTen.HeaderText = "Họ tên";
               this.hoTen.Name = "hoTen";
               this.hoTen.ReadOnly = true;
               // 
               // maNhanVien
               // 
               this.maNhanVien.DataPropertyName = "maNhanVien";
               this.maNhanVien.HeaderText = "Mã nhân viên";
               this.maNhanVien.Name = "maNhanVien";
               this.maNhanVien.ReadOnly = true;
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               this.label1.Location = new System.Drawing.Point(136, 263);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(97, 19);
               this.label1.TabIndex = 55;
               this.label1.Text = "Mã nhân viên :";
               // 
               // diaChi
               // 
               this.diaChi.DataPropertyName = "diaChi";
               this.diaChi.HeaderText = "Địa chỉ";
               this.diaChi.Name = "diaChi";
               this.diaChi.ReadOnly = true;
               // 
               // dataGridView1
               // 
               this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNhanVien,
            this.hoTen,
            this.gioiTinh,
            this.ngaySinh,
            this.soChungMinh,
            this.diaChi,
            this.soDienThoai,
            this.ngayVaoLam});
               this.dataGridView1.Location = new System.Drawing.Point(29, 57);
               this.dataGridView1.Name = "dataGridView1";
               this.dataGridView1.ReadOnly = true;
               this.dataGridView1.Size = new System.Drawing.Size(844, 177);
               this.dataGridView1.TabIndex = 54;
               // 
               // FormNhanVien
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(908, 522);
               this.Controls.Add(this.btnhuy);
               this.Controls.Add(this.dtngayvaolam);
               this.Controls.Add(this.dtngaysinh);
               this.Controls.Add(this.cbgioitinh);
               this.Controls.Add(this.btnthem);
               this.Controls.Add(this.label6);
               this.Controls.Add(this.label9);
               this.Controls.Add(this.txtsdt);
               this.Controls.Add(this.txtdiachi);
               this.Controls.Add(this.txtscm);
               this.Controls.Add(this.txttennv);
               this.Controls.Add(this.txtmanv);
               this.Controls.Add(this.btnthoat);
               this.Controls.Add(this.btnluu);
               this.Controls.Add(this.btnxoa);
               this.Controls.Add(this.btnsua);
               this.Controls.Add(this.label7);
               this.Controls.Add(this.label8);
               this.Controls.Add(this.label4);
               this.Controls.Add(this.label3);
               this.Controls.Add(this.label2);
               this.Controls.Add(this.label5);
               this.Controls.Add(this.label1);
               this.Controls.Add(this.dataGridView1);
               this.Name = "FormNhanVien";
               this.Text = "FormNhanVien";
               ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.DataGridViewTextBoxColumn ngayVaoLam;
          private System.Windows.Forms.DataGridViewTextBoxColumn soDienThoai;
          private System.Windows.Forms.Button btnhuy;
          private System.Windows.Forms.DateTimePicker dtngayvaolam;
          private System.Windows.Forms.DateTimePicker dtngaysinh;
          private System.Windows.Forms.ComboBox cbgioitinh;
          private System.Windows.Forms.Button btnthem;
          private System.Windows.Forms.Label label6;
          private System.Windows.Forms.Label label9;
          private System.Windows.Forms.TextBox txtsdt;
          private System.Windows.Forms.TextBox txtdiachi;
          private System.Windows.Forms.TextBox txtscm;
          private System.Windows.Forms.TextBox txttennv;
          private System.Windows.Forms.TextBox txtmanv;
          private System.Windows.Forms.Button btnthoat;
          private System.Windows.Forms.Button btnluu;
          private System.Windows.Forms.Button btnxoa;
          private System.Windows.Forms.Button btnsua;
          private System.Windows.Forms.Label label7;
          private System.Windows.Forms.Label label8;
          private System.Windows.Forms.Label label4;
          private System.Windows.Forms.Label label3;
          private System.Windows.Forms.Label label2;
          private System.Windows.Forms.DataGridViewTextBoxColumn soChungMinh;
          private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinh;
          private System.Windows.Forms.Label label5;
          private System.Windows.Forms.DataGridViewTextBoxColumn gioiTinh;
          private System.Windows.Forms.DataGridViewTextBoxColumn hoTen;
          private System.Windows.Forms.DataGridViewTextBoxColumn maNhanVien;
          private System.Windows.Forms.Label label1;
          private System.Windows.Forms.DataGridViewTextBoxColumn diaChi;
          private System.Windows.Forms.DataGridView dataGridView1;
     }
}