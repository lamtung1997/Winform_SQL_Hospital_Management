namespace BTL_CSDL
{
    partial class Frm_Sua_Benh_Nhan
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_Ma_Benh_Nhan = new System.Windows.Forms.TextBox();
            this.textBox_Ho_Ten = new System.Windows.Forms.TextBox();
            this.textBox_Nghe_Nghiep = new System.Windows.Forms.TextBox();
            this.textBox_Dia_Chi = new System.Windows.Forms.TextBox();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.dateTimePicker_Ngay_Sinh = new System.Windows.Forms.DateTimePicker();
            this.radioButton_Nam = new System.Windows.Forms.RadioButton();
            this.radioButton_Nu = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(333, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(339, 354);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(28, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Bệnh Nhân";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(28, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ Tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(28, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 14);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ngày Sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(28, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 14);
            this.label4.TabIndex = 4;
            this.label4.Text = "Giới Tính";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(28, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 14);
            this.label5.TabIndex = 5;
            this.label5.Text = "Nghề Nghiệp";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(28, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 14);
            this.label6.TabIndex = 6;
            this.label6.Text = "Địa Chỉ";
            // 
            // textBox_Ma_Benh_Nhan
            // 
            this.textBox_Ma_Benh_Nhan.Location = new System.Drawing.Point(135, 22);
            this.textBox_Ma_Benh_Nhan.Name = "textBox_Ma_Benh_Nhan";
            this.textBox_Ma_Benh_Nhan.ReadOnly = true;
            this.textBox_Ma_Benh_Nhan.Size = new System.Drawing.Size(183, 22);
            this.textBox_Ma_Benh_Nhan.TabIndex = 7;
            // 
            // textBox_Ho_Ten
            // 
            this.textBox_Ho_Ten.Location = new System.Drawing.Point(135, 77);
            this.textBox_Ho_Ten.Name = "textBox_Ho_Ten";
            this.textBox_Ho_Ten.Size = new System.Drawing.Size(183, 22);
            this.textBox_Ho_Ten.TabIndex = 8;
            // 
            // textBox_Nghe_Nghiep
            // 
            this.textBox_Nghe_Nghiep.Location = new System.Drawing.Point(135, 227);
            this.textBox_Nghe_Nghiep.Name = "textBox_Nghe_Nghiep";
            this.textBox_Nghe_Nghiep.Size = new System.Drawing.Size(183, 22);
            this.textBox_Nghe_Nghiep.TabIndex = 9;
            // 
            // textBox_Dia_Chi
            // 
            this.textBox_Dia_Chi.Location = new System.Drawing.Point(31, 297);
            this.textBox_Dia_Chi.Multiline = true;
            this.textBox_Dia_Chi.Name = "textBox_Dia_Chi";
            this.textBox_Dia_Chi.Size = new System.Drawing.Size(287, 87);
            this.textBox_Dia_Chi.TabIndex = 10;
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(31, 403);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(81, 30);
            this.btn_OK.TabIndex = 11;
            this.btn_OK.Text = "Cập Nhật";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(612, 403);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(60, 30);
            this.btn_Thoat.TabIndex = 12;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // dateTimePicker_Ngay_Sinh
            // 
            this.dateTimePicker_Ngay_Sinh.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker_Ngay_Sinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_Ngay_Sinh.Location = new System.Drawing.Point(135, 124);
            this.dateTimePicker_Ngay_Sinh.Name = "dateTimePicker_Ngay_Sinh";
            this.dateTimePicker_Ngay_Sinh.Size = new System.Drawing.Size(183, 22);
            this.dateTimePicker_Ngay_Sinh.TabIndex = 13;
            // 
            // radioButton_Nam
            // 
            this.radioButton_Nam.AutoSize = true;
            this.radioButton_Nam.BackColor = System.Drawing.Color.Transparent;
            this.radioButton_Nam.Location = new System.Drawing.Point(162, 180);
            this.radioButton_Nam.Name = "radioButton_Nam";
            this.radioButton_Nam.Size = new System.Drawing.Size(46, 18);
            this.radioButton_Nam.TabIndex = 14;
            this.radioButton_Nam.TabStop = true;
            this.radioButton_Nam.Text = "Nam";
            this.radioButton_Nam.UseVisualStyleBackColor = false;
            // 
            // radioButton_Nu
            // 
            this.radioButton_Nu.AutoSize = true;
            this.radioButton_Nu.BackColor = System.Drawing.Color.Transparent;
            this.radioButton_Nu.Location = new System.Drawing.Point(249, 180);
            this.radioButton_Nu.Name = "radioButton_Nu";
            this.radioButton_Nu.Size = new System.Drawing.Size(39, 18);
            this.radioButton_Nu.TabIndex = 15;
            this.radioButton_Nu.TabStop = true;
            this.radioButton_Nu.Text = "Nữ";
            this.radioButton_Nu.UseVisualStyleBackColor = false;
            // 
            // Frm_Sua_Benh_Nhan
            // 
            this.AcceptButton = this.btn_OK;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.radioButton_Nu);
            this.Controls.Add(this.radioButton_Nam);
            this.Controls.Add(this.dateTimePicker_Ngay_Sinh);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.textBox_Dia_Chi);
            this.Controls.Add(this.textBox_Nghe_Nghiep);
            this.Controls.Add(this.textBox_Ho_Ten);
            this.Controls.Add(this.textBox_Ma_Benh_Nhan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Frm_Sua_Benh_Nhan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sửa Thông Tin Bệnh Nhân";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_Ma_Benh_Nhan;
        private System.Windows.Forms.TextBox textBox_Ho_Ten;
        private System.Windows.Forms.TextBox textBox_Nghe_Nghiep;
        private System.Windows.Forms.TextBox textBox_Dia_Chi;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Ngay_Sinh;
        private System.Windows.Forms.RadioButton radioButton_Nam;
        private System.Windows.Forms.RadioButton radioButton_Nu;
    }
}