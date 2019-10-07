namespace BTL_CSDL
{
    partial class Frm_Thong_Tin_Phong
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
            this.lbl_Phong = new System.Windows.Forms.Label();
            this.btn_Hien_Thi_Thong_Tin = new System.Windows.Forms.Button();
            this.dataGridView_Benh_Nhan = new System.Windows.Forms.DataGridView();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.dataGridView_Nhan_Vien = new System.Windows.Forms.DataGridView();
            this.lbl_Khoa = new System.Windows.Forms.Label();
            this.comboBox_Khoa = new System.Windows.Forms.ComboBox();
            this.comboBox_Phong = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Benh_Nhan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Nhan_Vien)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Phong
            // 
            this.lbl_Phong.AutoSize = true;
            this.lbl_Phong.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Phong.Location = new System.Drawing.Point(278, 37);
            this.lbl_Phong.Name = "lbl_Phong";
            this.lbl_Phong.Size = new System.Drawing.Size(63, 14);
            this.lbl_Phong.TabIndex = 0;
            this.lbl_Phong.Text = "Phòng số";
            // 
            // btn_Hien_Thi_Thong_Tin
            // 
            this.btn_Hien_Thi_Thong_Tin.Location = new System.Drawing.Point(518, 34);
            this.btn_Hien_Thi_Thong_Tin.Name = "btn_Hien_Thi_Thong_Tin";
            this.btn_Hien_Thi_Thong_Tin.Size = new System.Drawing.Size(147, 24);
            this.btn_Hien_Thi_Thong_Tin.TabIndex = 2;
            this.btn_Hien_Thi_Thong_Tin.Text = "Hiển thị thông tin";
            this.btn_Hien_Thi_Thong_Tin.UseVisualStyleBackColor = true;
            this.btn_Hien_Thi_Thong_Tin.Click += new System.EventHandler(this.btn_Hien_Thi_Thong_Tin_Click);
            // 
            // dataGridView_Benh_Nhan
            // 
            this.dataGridView_Benh_Nhan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView_Benh_Nhan.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView_Benh_Nhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Benh_Nhan.Location = new System.Drawing.Point(37, 105);
            this.dataGridView_Benh_Nhan.Name = "dataGridView_Benh_Nhan";
            this.dataGridView_Benh_Nhan.ReadOnly = true;
            this.dataGridView_Benh_Nhan.Size = new System.Drawing.Size(304, 314);
            this.dataGridView_Benh_Nhan.TabIndex = 3;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(518, 425);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(147, 24);
            this.btn_Thoat.TabIndex = 4;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // dataGridView_Nhan_Vien
            // 
            this.dataGridView_Nhan_Vien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Nhan_Vien.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView_Nhan_Vien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Nhan_Vien.Location = new System.Drawing.Point(361, 105);
            this.dataGridView_Nhan_Vien.Name = "dataGridView_Nhan_Vien";
            this.dataGridView_Nhan_Vien.ReadOnly = true;
            this.dataGridView_Nhan_Vien.Size = new System.Drawing.Size(304, 314);
            this.dataGridView_Nhan_Vien.TabIndex = 5;
            // 
            // lbl_Khoa
            // 
            this.lbl_Khoa.AutoSize = true;
            this.lbl_Khoa.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Khoa.Location = new System.Drawing.Point(34, 37);
            this.lbl_Khoa.Name = "lbl_Khoa";
            this.lbl_Khoa.Size = new System.Drawing.Size(35, 14);
            this.lbl_Khoa.TabIndex = 6;
            this.lbl_Khoa.Text = "Khoa";
            // 
            // comboBox_Khoa
            // 
            this.comboBox_Khoa.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.comboBox_Khoa.FormattingEnabled = true;
            this.comboBox_Khoa.Location = new System.Drawing.Point(75, 31);
            this.comboBox_Khoa.Name = "comboBox_Khoa";
            this.comboBox_Khoa.Size = new System.Drawing.Size(153, 22);
            this.comboBox_Khoa.TabIndex = 7;
            this.comboBox_Khoa.SelectedIndexChanged += new System.EventHandler(this.comboBox_Khoa_SelectedIndexChanged);
            // 
            // comboBox_Phong
            // 
            this.comboBox_Phong.FormattingEnabled = true;
            this.comboBox_Phong.Location = new System.Drawing.Point(343, 31);
            this.comboBox_Phong.Name = "comboBox_Phong";
            this.comboBox_Phong.Size = new System.Drawing.Size(153, 22);
            this.comboBox_Phong.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(34, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 14);
            this.label1.TabIndex = 9;
            this.label1.Text = "Bệnh Nhân Trong Phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(358, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 14);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nhân Viên Trong Phòng";
            // 
            // Frm_Thong_Tin_Phong
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_Phong);
            this.Controls.Add(this.comboBox_Khoa);
            this.Controls.Add(this.lbl_Khoa);
            this.Controls.Add(this.dataGridView_Nhan_Vien);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.dataGridView_Benh_Nhan);
            this.Controls.Add(this.btn_Hien_Thi_Thong_Tin);
            this.Controls.Add(this.lbl_Phong);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Frm_Thong_Tin_Phong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông Tin Phòng";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Benh_Nhan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Nhan_Vien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Phong;
        private System.Windows.Forms.Button btn_Hien_Thi_Thong_Tin;
        private System.Windows.Forms.DataGridView dataGridView_Benh_Nhan;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.DataGridView dataGridView_Nhan_Vien;
        private System.Windows.Forms.Label lbl_Khoa;
        private System.Windows.Forms.ComboBox comboBox_Khoa;
        private System.Windows.Forms.ComboBox comboBox_Phong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}