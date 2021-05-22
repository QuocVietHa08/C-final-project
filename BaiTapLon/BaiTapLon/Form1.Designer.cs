
namespace BaiTapLon
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtmadocgia = new System.Windows.Forms.TextBox();
            this.dsdocgia = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.cbogioitinh = new System.Windows.Forms.ComboBox();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtngaycap = new System.Windows.Forms.TextBox();
            this.txtngayhethan = new System.Windows.Forms.TextBox();
            this.txtngaysinh = new System.Windows.Forms.TextBox();
            this.cbomadoituong = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.MaDocGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gioittinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDoiTuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayHetHan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dsdocgia)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 87);
            this.label1.MaximumSize = new System.Drawing.Size(500, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Độc Giả";
            // 
            // txtmadocgia
            // 
            this.txtmadocgia.Location = new System.Drawing.Point(150, 86);
            this.txtmadocgia.Name = "txtmadocgia";
            this.txtmadocgia.Size = new System.Drawing.Size(204, 20);
            this.txtmadocgia.TabIndex = 1;
            // 
            // dsdocgia
            // 
            this.dsdocgia.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dsdocgia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsdocgia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDocGia,
            this.Hoten,
            this.Gioittinh,
            this.NgaySinh,
            this.MaDoiTuong,
            this.NgayCap,
            this.NgayHetHan});
            this.dsdocgia.Location = new System.Drawing.Point(12, 249);
            this.dsdocgia.Name = "dsdocgia";
            this.dsdocgia.Size = new System.Drawing.Size(727, 259);
            this.dsdocgia.TabIndex = 2;
            this.dsdocgia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dsdocgia_CellClick);
            this.dsdocgia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dsdocgia_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(822, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "Nhập Lại";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbogioitinh
            // 
            this.cbogioitinh.FormattingEnabled = true;
            this.cbogioitinh.Items.AddRange(new object[] {
            "Nam ",
            "Nu"});
            this.cbogioitinh.Location = new System.Drawing.Point(150, 168);
            this.cbogioitinh.Name = "cbogioitinh";
            this.cbogioitinh.Size = new System.Drawing.Size(204, 21);
            this.cbogioitinh.TabIndex = 4;
            // 
            // txthoten
            // 
            this.txthoten.Location = new System.Drawing.Point(150, 129);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(204, 20);
            this.txthoten.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(49, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Họ Tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(34, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Giới Tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(23, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ngày Sinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(374, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Mã Đối Tượng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(374, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ngày Hết Hạn";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(384, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 24);
            this.label7.TabIndex = 11;
            this.label7.Text = "Ngày Cấp";
            // 
            // txtngaycap
            // 
            this.txtngaycap.Location = new System.Drawing.Point(510, 134);
            this.txtngaycap.Name = "txtngaycap";
            this.txtngaycap.Size = new System.Drawing.Size(204, 20);
            this.txtngaycap.TabIndex = 12;
            // 
            // txtngayhethan
            // 
            this.txtngayhethan.Location = new System.Drawing.Point(510, 177);
            this.txtngayhethan.Name = "txtngayhethan";
            this.txtngayhethan.Size = new System.Drawing.Size(204, 20);
            this.txtngayhethan.TabIndex = 13;
            // 
            // txtngaysinh
            // 
            this.txtngaysinh.Location = new System.Drawing.Point(150, 209);
            this.txtngaysinh.Name = "txtngaysinh";
            this.txtngaysinh.Size = new System.Drawing.Size(204, 20);
            this.txtngaysinh.TabIndex = 14;
            // 
            // cbomadoituong
            // 
            this.cbomadoituong.FormattingEnabled = true;
            this.cbomadoituong.Location = new System.Drawing.Point(510, 85);
            this.cbomadoituong.Name = "cbomadoituong";
            this.cbomadoituong.Size = new System.Drawing.Size(204, 21);
            this.cbomadoituong.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(822, 84);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 30);
            this.button2.TabIndex = 16;
            this.button2.Text = "Thêm";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Control;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(822, 129);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 30);
            this.button3.TabIndex = 17;
            this.button3.Text = "Sửa";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Control;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(822, 173);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 30);
            this.button4.TabIndex = 18;
            this.button4.Text = "Xóa";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.Control;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(822, 225);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 30);
            this.button5.TabIndex = 19;
            this.button5.Text = "Tìm";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.Control;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(822, 278);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 30);
            this.button6.TabIndex = 20;
            this.button6.Text = "Xem";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.Control;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(822, 331);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(100, 30);
            this.button7.TabIndex = 21;
            this.button7.Text = "Thoát";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.Control;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(822, 376);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(100, 30);
            this.button8.TabIndex = 22;
            this.button8.Text = "Báo Cáo";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // MaDocGia
            // 
            this.MaDocGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.MaDocGia.DataPropertyName = "MaDocGia";
            this.MaDocGia.HeaderText = "MaDonGia";
            this.MaDocGia.Name = "MaDocGia";
            this.MaDocGia.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MaDocGia.Width = 83;
            // 
            // Hoten
            // 
            this.Hoten.DataPropertyName = "HoTen";
            this.Hoten.HeaderText = "HoTen";
            this.Hoten.Name = "Hoten";
            // 
            // Gioittinh
            // 
            this.Gioittinh.DataPropertyName = "GioiTinh";
            this.Gioittinh.HeaderText = "GioiTinh";
            this.Gioittinh.Name = "Gioittinh";
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "NgaySinh";
            this.NgaySinh.Name = "NgaySinh";
            // 
            // MaDoiTuong
            // 
            this.MaDoiTuong.DataPropertyName = "MaDoiTuong";
            this.MaDoiTuong.HeaderText = "MaDoiTuong";
            this.MaDoiTuong.Name = "MaDoiTuong";
            // 
            // NgayCap
            // 
            this.NgayCap.DataPropertyName = "NgayCap";
            this.NgayCap.HeaderText = "NgayCap";
            this.NgayCap.Name = "NgayCap";
            // 
            // NgayHetHan
            // 
            this.NgayHetHan.DataPropertyName = "NgayHetHan";
            this.NgayHetHan.HeaderText = "NgayHetHan";
            this.NgayHetHan.Name = "NgayHetHan";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(213, 23);
            this.label8.MaximumSize = new System.Drawing.Size(500, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(375, 33);
            this.label8.TabIndex = 23;
            this.label8.Text = "Bảng Thông Tin Mượn Sách";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1004, 541);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cbomadoituong);
            this.Controls.Add(this.txtngaysinh);
            this.Controls.Add(this.txtngayhethan);
            this.Controls.Add(this.txtngaycap);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txthoten);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbogioitinh);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dsdocgia);
            this.Controls.Add(this.txtmadocgia);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Thong tin";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsdocgia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmadocgia;
        private System.Windows.Forms.DataGridView dsdocgia;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbogioitinh;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtngaycap;
        private System.Windows.Forms.TextBox txtngayhethan;
        private System.Windows.Forms.TextBox txtngaysinh;
        private System.Windows.Forms.ComboBox cbomadoituong;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gioittinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDoiTuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayHetHan;
        private System.Windows.Forms.Label label8;
    }
}

