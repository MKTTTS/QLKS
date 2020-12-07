namespace QLKS
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
            this.btn_add = new System.Windows.Forms.Button();
            this.cbquoctich = new System.Windows.Forms.ComboBox();
            this.dtngaysinh = new System.Windows.Forms.DateTimePicker();
            this.cbgiotinhkh = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.txtcmt = new System.Windows.Forms.TextBox();
            this.txttenkh = new System.Windows.Forms.TextBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgKH = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgKH)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(173, 534);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(104, 46);
            this.btn_add.TabIndex = 50;
            this.btn_add.Text = "&Thêm";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // cbquoctich
            // 
            this.cbquoctich.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbquoctich.FormattingEnabled = true;
            this.cbquoctich.Items.AddRange(new object[] {
            "VIỆT NAM",
            "LÀO",
            "THÁI LAN"});
            this.cbquoctich.Location = new System.Drawing.Point(745, 429);
            this.cbquoctich.Margin = new System.Windows.Forms.Padding(4);
            this.cbquoctich.Name = "cbquoctich";
            this.cbquoctich.Size = new System.Drawing.Size(209, 30);
            this.cbquoctich.TabIndex = 49;
            // 
            // dtngaysinh
            // 
            this.dtngaysinh.CalendarFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtngaysinh.CustomFormat = "dd/MM/yyyy";
            this.dtngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtngaysinh.Location = new System.Drawing.Point(281, 428);
            this.dtngaysinh.Margin = new System.Windows.Forms.Padding(4);
            this.dtngaysinh.Name = "dtngaysinh";
            this.dtngaysinh.Size = new System.Drawing.Size(211, 22);
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
            this.cbgiotinhkh.Location = new System.Drawing.Point(281, 374);
            this.cbgiotinhkh.Margin = new System.Windows.Forms.Padding(4);
            this.cbgiotinhkh.Name = "cbgiotinhkh";
            this.cbgiotinhkh.Size = new System.Drawing.Size(211, 30);
            this.cbgiotinhkh.TabIndex = 47;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(103, 429);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 22);
            this.label9.TabIndex = 46;
            this.label9.Text = "Ngày sinh :";
            // 
            // txtsdt
            // 
            this.txtsdt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtsdt.Location = new System.Drawing.Point(745, 377);
            this.txtsdt.Margin = new System.Windows.Forms.Padding(4);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(211, 30);
            this.txtsdt.TabIndex = 45;
            this.txtsdt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsdt_KeyPress);
            // 
            // txtdiachi
            // 
            this.txtdiachi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtdiachi.Location = new System.Drawing.Point(281, 471);
            this.txtdiachi.Margin = new System.Windows.Forms.Padding(4);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(211, 30);
            this.txtdiachi.TabIndex = 44;
            // 
            // txtcmt
            // 
            this.txtcmt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtcmt.Location = new System.Drawing.Point(747, 315);
            this.txtcmt.Margin = new System.Windows.Forms.Padding(4);
            this.txtcmt.Name = "txtcmt";
            this.txtcmt.Size = new System.Drawing.Size(211, 30);
            this.txtcmt.TabIndex = 43;
            this.txtcmt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcmt_KeyPress);
            // 
            // txttenkh
            // 
            this.txttenkh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txttenkh.Location = new System.Drawing.Point(281, 323);
            this.txttenkh.Margin = new System.Windows.Forms.Padding(4);
            this.txttenkh.Name = "txttenkh";
            this.txttenkh.Size = new System.Drawing.Size(211, 30);
            this.txttenkh.TabIndex = 42;
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(785, 534);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(104, 46);
            this.btn_exit.TabIndex = 39;
            this.btn_exit.Text = "Thoát";
            this.btn_exit.UseVisualStyleBackColor = true;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(582, 534);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(104, 46);
            this.btn_save.TabIndex = 38;
            this.btn_save.Text = "&Lưu";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(379, 534);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(104, 46);
            this.btn_edit.TabIndex = 36;
            this.btn_edit.Text = "&Sửa";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(589, 429);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 22);
            this.label6.TabIndex = 35;
            this.label6.Text = "Quốc tịch :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(589, 377);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 22);
            this.label7.TabIndex = 34;
            this.label7.Text = "Số điện thoại :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(103, 479);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 22);
            this.label8.TabIndex = 33;
            this.label8.Text = "Địa chỉ :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(103, 377);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 22);
            this.label3.TabIndex = 31;
            this.label3.Text = "Giới tính :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(103, 323);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 22);
            this.label2.TabIndex = 30;
            this.label2.Text = "Tên khách hàng :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(289, 11);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(460, 38);
            this.label5.TabIndex = 40;
            this.label5.Text = "THÔNG TIN KHÁCH HÀNG";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(589, 319);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 22);
            this.label4.TabIndex = 32;
            this.label4.Text = "Số CMNN :";
            // 
            // dgKH
            // 
            this.dgKH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgKH.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgKH.Location = new System.Drawing.Point(30, 63);
            this.dgKH.Name = "dgKH";
            this.dgKH.RowHeadersWidth = 51;
            this.dgKH.RowTemplate.Height = 24;
            this.dgKH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgKH.Size = new System.Drawing.Size(1022, 227);
            this.dgKH.TabIndex = 51;
            this.dgKH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgKH_CellClick);
            // 
            // FormThongTinKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 633);
            this.Controls.Add(this.dgKH);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.cbquoctich);
            this.Controls.Add(this.dtngaysinh);
            this.Controls.Add(this.cbgiotinhkh);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtsdt);
            this.Controls.Add(this.txtdiachi);
            this.Controls.Add(this.txtcmt);
            this.Controls.Add(this.txttenkh);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormThongTinKH";
            this.Text = "FormThongTinKH";
            this.Load += new System.EventHandler(this.FormThongTinKH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgKH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.Button btn_add;
          private System.Windows.Forms.ComboBox cbquoctich;
          private System.Windows.Forms.DateTimePicker dtngaysinh;
          private System.Windows.Forms.ComboBox cbgiotinhkh;
          private System.Windows.Forms.Label label9;
          private System.Windows.Forms.TextBox txtsdt;
          private System.Windows.Forms.TextBox txtdiachi;
          private System.Windows.Forms.TextBox txtcmt;
          private System.Windows.Forms.TextBox txttenkh;
          private System.Windows.Forms.Button btn_exit;
          private System.Windows.Forms.Button btn_save;
          private System.Windows.Forms.Button btn_edit;
          private System.Windows.Forms.Label label6;
          private System.Windows.Forms.Label label7;
          private System.Windows.Forms.Label label8;
          private System.Windows.Forms.Label label3;
          private System.Windows.Forms.Label label2;
          private System.Windows.Forms.Label label5;
          private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgKH;
    }
}