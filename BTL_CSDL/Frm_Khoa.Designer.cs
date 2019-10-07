namespace BTL_CSDL
{
    partial class Frm_Khoa
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1_Mo_Ta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_Tang = new System.Windows.Forms.Label();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox_SDT = new System.Windows.Forms.TextBox();
            this.textBox_Dia_Chi = new System.Windows.Forms.TextBox();
            this.textBox_Ngay_Sinh = new System.Windows.Forms.TextBox();
            this.textBox_Gioi_Tinh = new System.Windows.Forms.TextBox();
            this.textBox_Ho_Ten = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Tang = new System.Windows.Forms.TextBox();
            this.textBox_So_Phong = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(34, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn Khoa";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(124, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(198, 22);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(34, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "Thông Tin";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBox_So_Phong);
            this.panel1.Controls.Add(this.textBox_Tang);
            this.panel1.Controls.Add(this.textBox1_Mo_Ta);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lbl_Tang);
            this.panel1.Location = new System.Drawing.Point(37, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 280);
            this.panel1.TabIndex = 6;
            // 
            // textBox1_Mo_Ta
            // 
            this.textBox1_Mo_Ta.Location = new System.Drawing.Point(19, 130);
            this.textBox1_Mo_Ta.Multiline = true;
            this.textBox1_Mo_Ta.Name = "textBox1_Mo_Ta";
            this.textBox1_Mo_Ta.ReadOnly = true;
            this.textBox1_Mo_Ta.Size = new System.Drawing.Size(234, 134);
            this.textBox1_Mo_Ta.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(16, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 14);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mô Tả";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(16, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 14);
            this.label3.TabIndex = 1;
            this.label3.Text = "Số Lượng Phòng";
            // 
            // lbl_Tang
            // 
            this.lbl_Tang.AutoSize = true;
            this.lbl_Tang.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Tang.Location = new System.Drawing.Point(16, 20);
            this.lbl_Tang.Name = "lbl_Tang";
            this.lbl_Tang.Size = new System.Drawing.Size(35, 14);
            this.lbl_Tang.TabIndex = 0;
            this.lbl_Tang.Text = "Tầng";
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(572, 389);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(71, 37);
            this.btn_Thoat.TabIndex = 7;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.textBox_SDT);
            this.panel2.Controls.Add(this.textBox_Dia_Chi);
            this.panel2.Controls.Add(this.textBox_Ngay_Sinh);
            this.panel2.Controls.Add(this.textBox_Gioi_Tinh);
            this.panel2.Controls.Add(this.textBox_Ho_Ten);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(330, 90);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(313, 280);
            this.panel2.TabIndex = 7;
            // 
            // textBox_SDT
            // 
            this.textBox_SDT.Location = new System.Drawing.Point(117, 177);
            this.textBox_SDT.Name = "textBox_SDT";
            this.textBox_SDT.ReadOnly = true;
            this.textBox_SDT.Size = new System.Drawing.Size(178, 22);
            this.textBox_SDT.TabIndex = 9;
            // 
            // textBox_Dia_Chi
            // 
            this.textBox_Dia_Chi.Location = new System.Drawing.Point(117, 137);
            this.textBox_Dia_Chi.Name = "textBox_Dia_Chi";
            this.textBox_Dia_Chi.ReadOnly = true;
            this.textBox_Dia_Chi.Size = new System.Drawing.Size(178, 22);
            this.textBox_Dia_Chi.TabIndex = 8;
            // 
            // textBox_Ngay_Sinh
            // 
            this.textBox_Ngay_Sinh.Location = new System.Drawing.Point(117, 97);
            this.textBox_Ngay_Sinh.Name = "textBox_Ngay_Sinh";
            this.textBox_Ngay_Sinh.ReadOnly = true;
            this.textBox_Ngay_Sinh.Size = new System.Drawing.Size(178, 22);
            this.textBox_Ngay_Sinh.TabIndex = 7;
            // 
            // textBox_Gioi_Tinh
            // 
            this.textBox_Gioi_Tinh.Location = new System.Drawing.Point(117, 57);
            this.textBox_Gioi_Tinh.Name = "textBox_Gioi_Tinh";
            this.textBox_Gioi_Tinh.ReadOnly = true;
            this.textBox_Gioi_Tinh.Size = new System.Drawing.Size(178, 22);
            this.textBox_Gioi_Tinh.TabIndex = 6;
            // 
            // textBox_Ho_Ten
            // 
            this.textBox_Ho_Ten.Location = new System.Drawing.Point(117, 15);
            this.textBox_Ho_Ten.Name = "textBox_Ho_Ten";
            this.textBox_Ho_Ten.ReadOnly = true;
            this.textBox_Ho_Ten.Size = new System.Drawing.Size(178, 22);
            this.textBox_Ho_Ten.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(19, 180);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 14);
            this.label10.TabIndex = 4;
            this.label10.Text = "Số Điện Thoại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(19, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 14);
            this.label6.TabIndex = 3;
            this.label6.Text = "Địa chỉ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(19, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 14);
            this.label7.TabIndex = 2;
            this.label7.Text = "Ngày Sinh";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(19, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 14);
            this.label8.TabIndex = 1;
            this.label8.Text = "Giới Tính";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(19, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 14);
            this.label9.TabIndex = 0;
            this.label9.Text = "Họ Tên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(327, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 14);
            this.label5.TabIndex = 8;
            this.label5.Text = "Trưởng Khoa";
            // 
            // textBox_Tang
            // 
            this.textBox_Tang.Location = new System.Drawing.Point(154, 15);
            this.textBox_Tang.Name = "textBox_Tang";
            this.textBox_Tang.ReadOnly = true;
            this.textBox_Tang.Size = new System.Drawing.Size(98, 22);
            this.textBox_Tang.TabIndex = 4;
            // 
            // textBox_So_Phong
            // 
            this.textBox_So_Phong.Location = new System.Drawing.Point(154, 57);
            this.textBox_So_Phong.Name = "textBox_So_Phong";
            this.textBox_So_Phong.ReadOnly = true;
            this.textBox_So_Phong.Size = new System.Drawing.Size(98, 22);
            this.textBox_So_Phong.TabIndex = 5;
            // 
            // Frm_Khoa
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "Frm_Khoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông Tin Khoa";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1_Mo_Ta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_Tang;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox_SDT;
        private System.Windows.Forms.TextBox textBox_Dia_Chi;
        private System.Windows.Forms.TextBox textBox_Ngay_Sinh;
        private System.Windows.Forms.TextBox textBox_Gioi_Tinh;
        private System.Windows.Forms.TextBox textBox_Ho_Ten;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_So_Phong;
        private System.Windows.Forms.TextBox textBox_Tang;
    }
}