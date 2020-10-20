namespace QLKS
{
     partial class FormThongTinPhong
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
               this.donGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.loaiPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.maPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.GridView = new System.Windows.Forms.DataGridView();
               this.tinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.cbloaiphong = new System.Windows.Forms.ComboBox();
               this.btnthoatphong = new System.Windows.Forms.Button();
               this.btnluuphong = new System.Windows.Forms.Button();
               this.btnxoaphong = new System.Windows.Forms.Button();
               this.btnsuaphong = new System.Windows.Forms.Button();
               this.btnthemphong = new System.Windows.Forms.Button();
               this.txtdongiaphong = new System.Windows.Forms.TextBox();
               this.label4 = new System.Windows.Forms.Label();
               this.label2 = new System.Windows.Forms.Label();
               this.txtphong = new System.Windows.Forms.TextBox();
               this.label1 = new System.Windows.Forms.Label();
               this.label5 = new System.Windows.Forms.Label();
               ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
               this.SuspendLayout();
               // 
               // donGia
               // 
               this.donGia.DataPropertyName = "donGia";
               this.donGia.HeaderText = "Đơn Giá";
               this.donGia.Name = "donGia";
               this.donGia.ReadOnly = true;
               // 
               // loaiPhong
               // 
               this.loaiPhong.DataPropertyName = "loaiPhong";
               this.loaiPhong.HeaderText = "Loại Phòng";
               this.loaiPhong.Name = "loaiPhong";
               this.loaiPhong.ReadOnly = true;
               // 
               // maPhong
               // 
               this.maPhong.DataPropertyName = "maPhong";
               this.maPhong.HeaderText = "Phòng";
               this.maPhong.Name = "maPhong";
               this.maPhong.ReadOnly = true;
               // 
               // GridView
               // 
               this.GridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
               this.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               this.GridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maPhong,
            this.loaiPhong,
            this.tinhTrang,
            this.donGia});
               this.GridView.Location = new System.Drawing.Point(14, 66);
               this.GridView.Name = "GridView";
               this.GridView.ReadOnly = true;
               this.GridView.Size = new System.Drawing.Size(772, 177);
               this.GridView.TabIndex = 68;
               // 
               // tinhTrang
               // 
               this.tinhTrang.DataPropertyName = "tinhTrang";
               this.tinhTrang.HeaderText = "Tình Trạng";
               this.tinhTrang.Name = "tinhTrang";
               this.tinhTrang.ReadOnly = true;
               // 
               // cbloaiphong
               // 
               this.cbloaiphong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               this.cbloaiphong.FormattingEnabled = true;
               this.cbloaiphong.Items.AddRange(new object[] {
            "Thường",
            "Trung",
            "Vip"});
               this.cbloaiphong.Location = new System.Drawing.Point(169, 339);
               this.cbloaiphong.Name = "cbloaiphong";
               this.cbloaiphong.Size = new System.Drawing.Size(159, 27);
               this.cbloaiphong.TabIndex = 67;
               // 
               // btnthoatphong
               // 
               this.btnthoatphong.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               this.btnthoatphong.Location = new System.Drawing.Point(655, 404);
               this.btnthoatphong.Name = "btnthoatphong";
               this.btnthoatphong.Size = new System.Drawing.Size(73, 31);
               this.btnthoatphong.TabIndex = 66;
               this.btnthoatphong.Text = "Thoát";
               this.btnthoatphong.UseVisualStyleBackColor = true;
               // 
               // btnluuphong
               // 
               this.btnluuphong.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               this.btnluuphong.Location = new System.Drawing.Point(538, 404);
               this.btnluuphong.Name = "btnluuphong";
               this.btnluuphong.Size = new System.Drawing.Size(73, 31);
               this.btnluuphong.TabIndex = 65;
               this.btnluuphong.Text = "Lưu";
               this.btnluuphong.UseVisualStyleBackColor = true;
               // 
               // btnxoaphong
               // 
               this.btnxoaphong.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               this.btnxoaphong.Location = new System.Drawing.Point(410, 404);
               this.btnxoaphong.Name = "btnxoaphong";
               this.btnxoaphong.Size = new System.Drawing.Size(73, 31);
               this.btnxoaphong.TabIndex = 64;
               this.btnxoaphong.Text = "Xóa";
               this.btnxoaphong.UseVisualStyleBackColor = true;
               // 
               // btnsuaphong
               // 
               this.btnsuaphong.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               this.btnsuaphong.Location = new System.Drawing.Point(281, 404);
               this.btnsuaphong.Name = "btnsuaphong";
               this.btnsuaphong.Size = new System.Drawing.Size(73, 31);
               this.btnsuaphong.TabIndex = 63;
               this.btnsuaphong.Text = "Sửa";
               this.btnsuaphong.UseVisualStyleBackColor = true;
               // 
               // btnthemphong
               // 
               this.btnthemphong.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               this.btnthemphong.Location = new System.Drawing.Point(169, 404);
               this.btnthemphong.Name = "btnthemphong";
               this.btnthemphong.Size = new System.Drawing.Size(73, 31);
               this.btnthemphong.TabIndex = 62;
               this.btnthemphong.Text = "Thêm";
               this.btnthemphong.UseVisualStyleBackColor = true;
               // 
               // txtdongiaphong
               // 
               this.txtdongiaphong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               this.txtdongiaphong.Location = new System.Drawing.Point(571, 279);
               this.txtdongiaphong.Name = "txtdongiaphong";
               this.txtdongiaphong.Size = new System.Drawing.Size(159, 26);
               this.txtdongiaphong.TabIndex = 60;
               // 
               // label4
               // 
               this.label4.AutoSize = true;
               this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               this.label4.ForeColor = System.Drawing.Color.Black;
               this.label4.Location = new System.Drawing.Point(437, 281);
               this.label4.Name = "label4";
               this.label4.Size = new System.Drawing.Size(63, 19);
               this.label4.TabIndex = 59;
               this.label4.Text = "Đơn giá :";
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               this.label2.ForeColor = System.Drawing.Color.Black;
               this.label2.Location = new System.Drawing.Point(35, 342);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(84, 19);
               this.label2.TabIndex = 57;
               this.label2.Text = "Loại phòng :";
               // 
               // txtphong
               // 
               this.txtphong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               this.txtphong.Location = new System.Drawing.Point(169, 278);
               this.txtphong.Name = "txtphong";
               this.txtphong.Size = new System.Drawing.Size(159, 26);
               this.txtphong.TabIndex = 56;
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               this.label1.ForeColor = System.Drawing.Color.Black;
               this.label1.Location = new System.Drawing.Point(35, 280);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(54, 19);
               this.label1.TabIndex = 55;
               this.label1.Text = "Phòng :";
               // 
               // label5
               // 
               this.label5.AutoSize = true;
               this.label5.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               this.label5.ForeColor = System.Drawing.Color.Red;
               this.label5.Location = new System.Drawing.Point(275, 15);
               this.label5.Name = "label5";
               this.label5.Size = new System.Drawing.Size(277, 31);
               this.label5.TabIndex = 54;
               this.label5.Text = "THÔNG TIN PHÒNG";
               // 
               // FormThongTinPhong
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(800, 450);
               this.Controls.Add(this.GridView);
               this.Controls.Add(this.cbloaiphong);
               this.Controls.Add(this.btnthoatphong);
               this.Controls.Add(this.btnluuphong);
               this.Controls.Add(this.btnxoaphong);
               this.Controls.Add(this.btnsuaphong);
               this.Controls.Add(this.btnthemphong);
               this.Controls.Add(this.txtdongiaphong);
               this.Controls.Add(this.label4);
               this.Controls.Add(this.label2);
               this.Controls.Add(this.txtphong);
               this.Controls.Add(this.label1);
               this.Controls.Add(this.label5);
               this.Name = "FormThongTinPhong";
               this.Text = "FormThongTinPhong";
               ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.DataGridViewTextBoxColumn donGia;
          private System.Windows.Forms.DataGridViewTextBoxColumn loaiPhong;
          private System.Windows.Forms.DataGridViewTextBoxColumn maPhong;
          private System.Windows.Forms.DataGridView GridView;
          private System.Windows.Forms.DataGridViewTextBoxColumn tinhTrang;
          private System.Windows.Forms.ComboBox cbloaiphong;
          private System.Windows.Forms.Button btnthoatphong;
          private System.Windows.Forms.Button btnluuphong;
          private System.Windows.Forms.Button btnxoaphong;
          private System.Windows.Forms.Button btnsuaphong;
          private System.Windows.Forms.Button btnthemphong;
          private System.Windows.Forms.TextBox txtdongiaphong;
          private System.Windows.Forms.Label label4;
          private System.Windows.Forms.Label label2;
          private System.Windows.Forms.TextBox txtphong;
          private System.Windows.Forms.Label label1;
          private System.Windows.Forms.Label label5;
     }
}