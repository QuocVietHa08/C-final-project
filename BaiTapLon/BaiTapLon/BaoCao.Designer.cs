
namespace BaiTapLon
{
    partial class BaoCao
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
            this.txtngaycap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtngayhethan = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dsDoiTuong = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.MaDocGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDoiTuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayHetHan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dsDoiTuong)).BeginInit();
            this.SuspendLayout();
            // 
            // txtngaycap
            // 
            this.txtngaycap.Location = new System.Drawing.Point(184, 33);
            this.txtngaycap.Name = "txtngaycap";
            this.txtngaycap.Size = new System.Drawing.Size(144, 20);
            this.txtngaycap.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(99, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ngay Bat Dau";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(99, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ngay Ket Thuc";
            // 
            // txtngayhethan
            // 
            this.txtngayhethan.Location = new System.Drawing.Point(184, 76);
            this.txtngayhethan.Name = "txtngayhethan";
            this.txtngayhethan.Size = new System.Drawing.Size(144, 20);
            this.txtngayhethan.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(448, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Tim";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dsDoiTuong
            // 
            this.dsDoiTuong.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dsDoiTuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsDoiTuong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDocGia,
            this.HoTen,
            this.GioiTinh,
            this.NgaySinh,
            this.MaDoiTuong,
            this.NgayCap,
            this.NgayHetHan});
            this.dsDoiTuong.Location = new System.Drawing.Point(12, 162);
            this.dsDoiTuong.Name = "dsDoiTuong";
            this.dsDoiTuong.Size = new System.Drawing.Size(744, 260);
            this.dsDoiTuong.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(448, 78);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "In";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // MaDocGia
            // 
            this.MaDocGia.DataPropertyName = "MaDocGia";
            this.MaDocGia.HeaderText = "MaDocGia";
            this.MaDocGia.Name = "MaDocGia";
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "HoTen";
            this.HoTen.Name = "HoTen";
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "GioiTinh";
            this.GioiTinh.Name = "GioiTinh";
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
            // BaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dsDoiTuong);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtngayhethan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtngaycap);
            this.Name = "BaoCao";
            this.Text = "BaoCao";
            this.Load += new System.EventHandler(this.BaoCao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsDoiTuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtngaycap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtngayhethan;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dsDoiTuong;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDoiTuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayHetHan;
    }
}