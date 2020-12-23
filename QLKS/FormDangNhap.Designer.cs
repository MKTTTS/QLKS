namespace QLKS
{
     partial class FormDangNhap
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
               this.lbtb = new System.Windows.Forms.Label();
               this.btnthoat = new System.Windows.Forms.Button();
               this.btndangnhap = new System.Windows.Forms.Button();
               this.txtmatkhau = new System.Windows.Forms.TextBox();
               this.txttaikhoan = new System.Windows.Forms.TextBox();
               this.label3 = new System.Windows.Forms.Label();
               this.label2 = new System.Windows.Forms.Label();
               this.label1 = new System.Windows.Forms.Label();
               this.SuspendLayout();
               // 
               // lbtb
               // 
               this.lbtb.AutoSize = true;
               this.lbtb.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               this.lbtb.ForeColor = System.Drawing.Color.Red;
               this.lbtb.Location = new System.Drawing.Point(108, 49);
               this.lbtb.Name = "lbtb";
               this.lbtb.Size = new System.Drawing.Size(0, 15);
               this.lbtb.TabIndex = 44;
               // 
               // btnthoat
               // 
               this.btnthoat.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               this.btnthoat.Location = new System.Drawing.Point(274, 213);
               this.btnthoat.Name = "btnthoat";
               this.btnthoat.Size = new System.Drawing.Size(111, 32);
               this.btnthoat.TabIndex = 43;
               this.btnthoat.Text = "&Thoát";
               this.btnthoat.UseVisualStyleBackColor = true;
               this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
               // 
               // btndangnhap
               // 
               this.btndangnhap.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               this.btndangnhap.Location = new System.Drawing.Point(100, 213);
               this.btndangnhap.Name = "btndangnhap";
               this.btndangnhap.Size = new System.Drawing.Size(111, 32);
               this.btndangnhap.TabIndex = 42;
               this.btndangnhap.Text = "&Đăng nhập";
               this.btndangnhap.UseVisualStyleBackColor = true;
               this.btndangnhap.Click += new System.EventHandler(this.btndangnhap_Click);
               // 
               // txtmatkhau
               // 
               this.txtmatkhau.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               this.txtmatkhau.Location = new System.Drawing.Point(134, 121);
               this.txtmatkhau.Name = "txtmatkhau";
               this.txtmatkhau.Size = new System.Drawing.Size(204, 29);
               this.txtmatkhau.TabIndex = 41;
               this.txtmatkhau.UseSystemPasswordChar = true;
               // 
               // txttaikhoan
               // 
               this.txttaikhoan.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               this.txttaikhoan.Location = new System.Drawing.Point(134, 84);
               this.txttaikhoan.Name = "txttaikhoan";
               this.txttaikhoan.Size = new System.Drawing.Size(204, 29);
               this.txttaikhoan.TabIndex = 40;
               // 
               // label3
               // 
               this.label3.AutoSize = true;
               this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               this.label3.Location = new System.Drawing.Point(18, 128);
               this.label3.Name = "label3";
               this.label3.Size = new System.Drawing.Size(92, 21);
               this.label3.TabIndex = 39;
               this.label3.Text = "Mật Khẩu :";
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               this.label2.Location = new System.Drawing.Point(15, 91);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(93, 21);
               this.label2.TabIndex = 38;
               this.label2.Text = "Tài khoản :";
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
               this.label1.Location = new System.Drawing.Point(138, 33);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(184, 31);
               this.label1.TabIndex = 37;
               this.label1.Text = "ĐĂNG NHẬP ";
               // 
               // FormDangNhap
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(434, 287);
               this.Controls.Add(this.lbtb);
               this.Controls.Add(this.btnthoat);
               this.Controls.Add(this.btndangnhap);
               this.Controls.Add(this.txtmatkhau);
               this.Controls.Add(this.txttaikhoan);
               this.Controls.Add(this.label3);
               this.Controls.Add(this.label2);
               this.Controls.Add(this.label1);
               this.Name = "FormDangNhap";
               this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
               this.Text = "Form1";
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion
          private System.Windows.Forms.Label lbtb;
          private System.Windows.Forms.Button btnthoat;
          private System.Windows.Forms.Button btndangnhap;
          private System.Windows.Forms.TextBox txtmatkhau;
          private System.Windows.Forms.TextBox txttaikhoan;
          private System.Windows.Forms.Label label3;
          private System.Windows.Forms.Label label2;
          private System.Windows.Forms.Label label1;
     }
}

