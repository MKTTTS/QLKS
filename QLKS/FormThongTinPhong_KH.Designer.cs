﻿namespace QLKS
{
     partial class FormThongTinPhong_KH
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
               this.dataGridView1 = new System.Windows.Forms.DataGridView();
               this.maPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.loaiPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.tinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.donGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.thoat = new System.Windows.Forms.Button();
               this.button1 = new System.Windows.Forms.Button();
               this.label5 = new System.Windows.Forms.Label();
               ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
               this.SuspendLayout();
               // 
               // dataGridView1
               // 
               this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
               this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maPhong,
            this.loaiPhong,
            this.tinhTrang,
            this.donGia});
               this.dataGridView1.Location = new System.Drawing.Point(14, 48);
               this.dataGridView1.Name = "dataGridView1";
               this.dataGridView1.ReadOnly = true;
               this.dataGridView1.Size = new System.Drawing.Size(772, 353);
               this.dataGridView1.TabIndex = 20;
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
               this.tinhTrang.HeaderText = "Tình Trạng";
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
               // thoat
               // 
               this.thoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               this.thoat.Location = new System.Drawing.Point(461, 409);
               this.thoat.Name = "thoat";
               this.thoat.Size = new System.Drawing.Size(102, 40);
               this.thoat.TabIndex = 22;
               this.thoat.Text = "Thoát";
               this.thoat.UseVisualStyleBackColor = true;
               // 
               // button1
               // 
               this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               this.button1.Location = new System.Drawing.Point(249, 409);
               this.button1.Name = "button1";
               this.button1.Size = new System.Drawing.Size(102, 40);
               this.button1.TabIndex = 21;
               this.button1.Text = "Đăng xuất";
               this.button1.UseVisualStyleBackColor = true;
               // 
               // label5
               // 
               this.label5.AutoSize = true;
               this.label5.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               this.label5.ForeColor = System.Drawing.Color.Red;
               this.label5.Location = new System.Drawing.Point(277, 9);
               this.label5.Name = "label5";
               this.label5.Size = new System.Drawing.Size(277, 31);
               this.label5.TabIndex = 19;
               this.label5.Text = "THÔNG TIN PHÒNG";
               // 
               // FormThongTinPhong_KH
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(800, 456);
               this.Controls.Add(this.dataGridView1);
               this.Controls.Add(this.thoat);
               this.Controls.Add(this.button1);
               this.Controls.Add(this.label5);
               this.Name = "FormThongTinPhong_KH";
               this.Text = "FormThongTinPhong_KH";
               ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.DataGridView dataGridView1;
          private System.Windows.Forms.DataGridViewTextBoxColumn maPhong;
          private System.Windows.Forms.DataGridViewTextBoxColumn loaiPhong;
          private System.Windows.Forms.DataGridViewTextBoxColumn tinhTrang;
          private System.Windows.Forms.DataGridViewTextBoxColumn donGia;
          private System.Windows.Forms.Button thoat;
          private System.Windows.Forms.Button button1;
          private System.Windows.Forms.Label label5;
     }
}