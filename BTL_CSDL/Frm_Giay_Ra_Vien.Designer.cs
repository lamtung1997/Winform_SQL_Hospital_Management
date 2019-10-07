namespace BTL_CSDL
{
    partial class Frm_Giay_Ra_Vien
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
            this.textBox_Ho_Ten = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_Ket_Qua = new System.Windows.Forms.TextBox();
            this.comboBox_Dich_Vu = new System.Windows.Forms.ComboBox();
            this.comboBox_Co_So_Y_Te = new System.Windows.Forms.ComboBox();
            this.textBox_Khuyen = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.lbl_Chon_Benh_Nhan = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_Xong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(38, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ Tên Bệnh Nhân";
            // 
            // textBox_Ho_Ten
            // 
            this.textBox_Ho_Ten.Location = new System.Drawing.Point(171, 39);
            this.textBox_Ho_Ten.Name = "textBox_Ho_Ten";
            this.textBox_Ho_Ten.Size = new System.Drawing.Size(391, 21);
            this.textBox_Ho_Ten.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(582, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Tìm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(41, 117);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(295, 278);
            this.dataGridView.TabIndex = 3;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBox_Ket_Qua);
            this.panel1.Controls.Add(this.comboBox_Dich_Vu);
            this.panel1.Controls.Add(this.comboBox_Co_So_Y_Te);
            this.panel1.Controls.Add(this.textBox_Khuyen);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(354, 117);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 277);
            this.panel1.TabIndex = 4;
            // 
            // textBox_Ket_Qua
            // 
            this.textBox_Ket_Qua.Location = new System.Drawing.Point(134, 87);
            this.textBox_Ket_Qua.Name = "textBox_Ket_Qua";
            this.textBox_Ket_Qua.Size = new System.Drawing.Size(137, 21);
            this.textBox_Ket_Qua.TabIndex = 14;
            // 
            // comboBox_Dich_Vu
            // 
            this.comboBox_Dich_Vu.FormattingEnabled = true;
            this.comboBox_Dich_Vu.Location = new System.Drawing.Point(134, 48);
            this.comboBox_Dich_Vu.Name = "comboBox_Dich_Vu";
            this.comboBox_Dich_Vu.Size = new System.Drawing.Size(138, 23);
            this.comboBox_Dich_Vu.TabIndex = 13;
            this.comboBox_Dich_Vu.SelectedIndexChanged += new System.EventHandler(this.comboBox_Dich_Vu_SelectedIndexChanged);
            // 
            // comboBox_Co_So_Y_Te
            // 
            this.comboBox_Co_So_Y_Te.FormattingEnabled = true;
            this.comboBox_Co_So_Y_Te.Location = new System.Drawing.Point(134, 8);
            this.comboBox_Co_So_Y_Te.Name = "comboBox_Co_So_Y_Te";
            this.comboBox_Co_So_Y_Te.Size = new System.Drawing.Size(138, 23);
            this.comboBox_Co_So_Y_Te.TabIndex = 12;
            this.comboBox_Co_So_Y_Te.SelectedIndexChanged += new System.EventHandler(this.comboBox_Co_So_Y_Te_SelectedIndexChanged);
            // 
            // textBox_Khuyen
            // 
            this.textBox_Khuyen.Location = new System.Drawing.Point(6, 160);
            this.textBox_Khuyen.Multiline = true;
            this.textBox_Khuyen.Name = "textBox_Khuyen";
            this.textBox_Khuyen.Size = new System.Drawing.Size(276, 100);
            this.textBox_Khuyen.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Lời Khuyên Của Bác Sỹ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Kết Quả Điều Trị";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Dịch Vụ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cơ Sở Y Tế";
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(582, 400);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(66, 34);
            this.btn_Thoat.TabIndex = 5;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // lbl_Chon_Benh_Nhan
            // 
            this.lbl_Chon_Benh_Nhan.AutoSize = true;
            this.lbl_Chon_Benh_Nhan.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Chon_Benh_Nhan.Location = new System.Drawing.Point(38, 88);
            this.lbl_Chon_Benh_Nhan.Name = "lbl_Chon_Benh_Nhan";
            this.lbl_Chon_Benh_Nhan.Size = new System.Drawing.Size(100, 15);
            this.lbl_Chon_Benh_Nhan.TabIndex = 6;
            this.lbl_Chon_Benh_Nhan.Text = "Chọn Bệnh Nhân";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(351, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Giấy Ra Viện";
            // 
            // btn_Xong
            // 
            this.btn_Xong.Location = new System.Drawing.Point(496, 400);
            this.btn_Xong.Name = "btn_Xong";
            this.btn_Xong.Size = new System.Drawing.Size(66, 34);
            this.btn_Xong.TabIndex = 8;
            this.btn_Xong.Text = "Xong";
            this.btn_Xong.UseVisualStyleBackColor = true;
            this.btn_Xong.Click += new System.EventHandler(this.btn_Xong_Click);
            // 
            // Frm_Giay_Ra_Vien
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Xong);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl_Chon_Benh_Nhan);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_Ho_Ten);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "Frm_Giay_Ra_Vien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giấy Ra Viện";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Ho_Ten;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.TextBox textBox_Khuyen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_Chon_Benh_Nhan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_Ket_Qua;
        private System.Windows.Forms.ComboBox comboBox_Dich_Vu;
        private System.Windows.Forms.ComboBox comboBox_Co_So_Y_Te;
        private System.Windows.Forms.Button btn_Xong;
    }
}