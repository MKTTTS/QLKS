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
            this.GridView = new System.Windows.Forms.DataGridView();
            this.btnthoatphong = new System.Windows.Forms.Button();
            this.btnsuaphong = new System.Windows.Forms.Button();
            this.btnthemphong = new System.Windows.Forms.Button();
            this.txtdongiaphong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtphong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtloaiphong = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // GridView
            // 
            this.GridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView.Location = new System.Drawing.Point(19, 81);
            this.GridView.Margin = new System.Windows.Forms.Padding(4);
            this.GridView.Name = "GridView";
            this.GridView.ReadOnly = true;
            this.GridView.RowHeadersWidth = 51;
            this.GridView.Size = new System.Drawing.Size(1029, 218);
            this.GridView.TabIndex = 68;
            // 
            // btnthoatphong
            // 
            this.btnthoatphong.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnthoatphong.Location = new System.Drawing.Point(643, 497);
            this.btnthoatphong.Margin = new System.Windows.Forms.Padding(4);
            this.btnthoatphong.Name = "btnthoatphong";
            this.btnthoatphong.Size = new System.Drawing.Size(97, 38);
            this.btnthoatphong.TabIndex = 66;
            this.btnthoatphong.Text = "Thoát";
            this.btnthoatphong.UseVisualStyleBackColor = true;
            this.btnthoatphong.Click += new System.EventHandler(this.btnthoatphong_Click);
            // 
            // btnsuaphong
            // 
            this.btnsuaphong.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnsuaphong.Location = new System.Drawing.Point(434, 497);
            this.btnsuaphong.Margin = new System.Windows.Forms.Padding(4);
            this.btnsuaphong.Name = "btnsuaphong";
            this.btnsuaphong.Size = new System.Drawing.Size(97, 38);
            this.btnsuaphong.TabIndex = 63;
            this.btnsuaphong.Text = "Sửa";
            this.btnsuaphong.UseVisualStyleBackColor = true;
            this.btnsuaphong.Click += new System.EventHandler(this.btnsuaphong_Click);
            // 
            // btnthemphong
            // 
            this.btnthemphong.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnthemphong.Location = new System.Drawing.Point(249, 497);
            this.btnthemphong.Margin = new System.Windows.Forms.Padding(4);
            this.btnthemphong.Name = "btnthemphong";
            this.btnthemphong.Size = new System.Drawing.Size(97, 38);
            this.btnthemphong.TabIndex = 62;
            this.btnthemphong.Text = "Thêm";
            this.btnthemphong.UseVisualStyleBackColor = true;
            this.btnthemphong.Click += new System.EventHandler(this.btnthemphong_Click);
            // 
            // txtdongiaphong
            // 
            this.txtdongiaphong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtdongiaphong.Location = new System.Drawing.Point(761, 343);
            this.txtdongiaphong.Margin = new System.Windows.Forms.Padding(4);
            this.txtdongiaphong.Name = "txtdongiaphong";
            this.txtdongiaphong.Size = new System.Drawing.Size(211, 30);
            this.txtdongiaphong.TabIndex = 60;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(583, 346);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 22);
            this.label4.TabIndex = 59;
            this.label4.Text = "Đơn giá :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(47, 421);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 22);
            this.label2.TabIndex = 57;
            this.label2.Text = "Loại phòng :";
            // 
            // txtphong
            // 
            this.txtphong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtphong.Location = new System.Drawing.Point(225, 342);
            this.txtphong.Margin = new System.Windows.Forms.Padding(4);
            this.txtphong.Name = "txtphong";
            this.txtphong.Size = new System.Drawing.Size(211, 30);
            this.txtphong.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(47, 345);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 22);
            this.label1.TabIndex = 55;
            this.label1.Text = "Phòng :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(367, 18);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(345, 38);
            this.label5.TabIndex = 54;
            this.label5.Text = "THÔNG TIN PHÒNG";
            // 
            // txtloaiphong
            // 
            this.txtloaiphong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtloaiphong.Location = new System.Drawing.Point(225, 418);
            this.txtloaiphong.Margin = new System.Windows.Forms.Padding(4);
            this.txtloaiphong.Name = "txtloaiphong";
            this.txtloaiphong.Size = new System.Drawing.Size(211, 30);
            this.txtloaiphong.TabIndex = 69;
            // 
            // FormThongTinPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.txtloaiphong);
            this.Controls.Add(this.GridView);
            this.Controls.Add(this.btnthoatphong);
            this.Controls.Add(this.btnsuaphong);
            this.Controls.Add(this.btnthemphong);
            this.Controls.Add(this.txtdongiaphong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtphong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormThongTinPhong";
            this.Text = "FormThongTinPhong";
            this.Load += new System.EventHandler(this.FormThongTinPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView GridView;
        private System.Windows.Forms.Button btnthoatphong;
        private System.Windows.Forms.Button btnsuaphong;
        private System.Windows.Forms.Button btnthemphong;
        private System.Windows.Forms.TextBox txtdongiaphong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtphong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtloaiphong;
    }
}