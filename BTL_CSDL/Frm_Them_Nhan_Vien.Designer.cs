namespace BTL_CSDL
{
    partial class Frm_Them_Nhan_Vien
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.textBox_Test = new System.Windows.Forms.TextBox();
            this.Column_MaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_ChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_SoPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView_NhanVien = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_NhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_MaNhanVien,
            this.Column_HoTen,
            this.Column_GioiTinh,
            this.Column_NgaySinh,
            this.Column_ChucVu,
            this.Column_SoPhong});
            this.dataGridView1.Location = new System.Drawing.Point(12, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(660, 111);
            this.dataGridView1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Consolas", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(659, 37);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Điền thông tin nhân viên mới vào bảng và nhấn nút Thêm. Lưu ý không được sử dụng " +
    "trùng mã Nhân Viên";
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(40, 421);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(78, 31);
            this.btn_Them.TabIndex = 2;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(570, 421);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(78, 31);
            this.btn_Thoat.TabIndex = 3;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // textBox_Test
            // 
            this.textBox_Test.Location = new System.Drawing.Point(201, 421);
            this.textBox_Test.Name = "textBox_Test";
            this.textBox_Test.Size = new System.Drawing.Size(318, 22);
            this.textBox_Test.TabIndex = 4;
            // 
            // Column_MaNhanVien
            // 
            this.Column_MaNhanVien.HeaderText = "Mã Nhân Viên";
            this.Column_MaNhanVien.Name = "Column_MaNhanVien";
            // 
            // Column_HoTen
            // 
            this.Column_HoTen.HeaderText = "Họ Tên";
            this.Column_HoTen.Name = "Column_HoTen";
            // 
            // Column_GioiTinh
            // 
            this.Column_GioiTinh.HeaderText = "Giới Tính";
            this.Column_GioiTinh.Name = "Column_GioiTinh";
            // 
            // Column_NgaySinh
            // 
            this.Column_NgaySinh.HeaderText = "Ngày Sinh";
            this.Column_NgaySinh.Name = "Column_NgaySinh";
            // 
            // Column_ChucVu
            // 
            this.Column_ChucVu.HeaderText = "Chức Vụ";
            this.Column_ChucVu.Name = "Column_ChucVu";
            // 
            // Column_SoPhong
            // 
            this.Column_SoPhong.HeaderText = "Số Phòng";
            this.Column_SoPhong.Name = "Column_SoPhong";
            // 
            // dataGridView_NhanVien
            // 
            this.dataGridView_NhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_NhanVien.Location = new System.Drawing.Point(12, 176);
            this.dataGridView_NhanVien.Name = "dataGridView_NhanVien";
            this.dataGridView_NhanVien.ReadOnly = true;
            this.dataGridView_NhanVien.Size = new System.Drawing.Size(659, 224);
            this.dataGridView_NhanVien.TabIndex = 5;
            // 
            // Frm_Them_Nhan_Vien
            // 
            this.AcceptButton = this.btn_Them;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridView_NhanVien);
            this.Controls.Add(this.textBox_Test);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "Frm_Them_Nhan_Vien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Nhân Viên";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_NhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.TextBox textBox_Test;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_MaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_ChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_SoPhong;
        private System.Windows.Forms.DataGridView dataGridView_NhanVien;
    }
}