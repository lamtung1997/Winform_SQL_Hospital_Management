namespace BTL_CSDL
{
    partial class Frm_Dang_Nhap
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
            this.lbl_Dang_Nhap = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_Dang_Nhap = new System.Windows.Forms.Button();
            this.textBox_Mat_Khau = new System.Windows.Forms.TextBox();
            this.textBox_Dang_Nhap = new System.Windows.Forms.TextBox();
            this.lbl_Mat_Khau = new System.Windows.Forms.Label();
            this.lbl_Ten_Dang_Nhap = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Dang_Nhap
            // 
            this.lbl_Dang_Nhap.AutoSize = true;
            this.lbl_Dang_Nhap.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Dang_Nhap.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Dang_Nhap.Location = new System.Drawing.Point(152, 23);
            this.lbl_Dang_Nhap.Name = "lbl_Dang_Nhap";
            this.lbl_Dang_Nhap.Size = new System.Drawing.Size(171, 19);
            this.lbl_Dang_Nhap.TabIndex = 0;
            this.lbl_Dang_Nhap.Text = "ĐĂNG NHẬP HỆ THỐNG";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_Thoat);
            this.panel1.Controls.Add(this.btn_Dang_Nhap);
            this.panel1.Controls.Add(this.textBox_Mat_Khau);
            this.panel1.Controls.Add(this.textBox_Dang_Nhap);
            this.panel1.Controls.Add(this.lbl_Mat_Khau);
            this.panel1.Controls.Add(this.lbl_Ten_Dang_Nhap);
            this.panel1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(49, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 278);
            this.panel1.TabIndex = 4;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(273, 230);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(78, 29);
            this.btn_Thoat.TabIndex = 5;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_Dang_Nhap
            // 
            this.btn_Dang_Nhap.Location = new System.Drawing.Point(172, 230);
            this.btn_Dang_Nhap.Name = "btn_Dang_Nhap";
            this.btn_Dang_Nhap.Size = new System.Drawing.Size(78, 29);
            this.btn_Dang_Nhap.TabIndex = 4;
            this.btn_Dang_Nhap.Text = "Đăng Nhập";
            this.btn_Dang_Nhap.UseVisualStyleBackColor = true;
            this.btn_Dang_Nhap.Click += new System.EventHandler(this.btn_Dang_Nhap_Click);
            // 
            // textBox_Mat_Khau
            // 
            this.textBox_Mat_Khau.Location = new System.Drawing.Point(172, 72);
            this.textBox_Mat_Khau.Name = "textBox_Mat_Khau";
            this.textBox_Mat_Khau.PasswordChar = '*';
            this.textBox_Mat_Khau.Size = new System.Drawing.Size(179, 23);
            this.textBox_Mat_Khau.TabIndex = 3;
            // 
            // textBox_Dang_Nhap
            // 
            this.textBox_Dang_Nhap.Location = new System.Drawing.Point(172, 29);
            this.textBox_Dang_Nhap.Name = "textBox_Dang_Nhap";
            this.textBox_Dang_Nhap.Size = new System.Drawing.Size(179, 23);
            this.textBox_Dang_Nhap.TabIndex = 2;
            // 
            // lbl_Mat_Khau
            // 
            this.lbl_Mat_Khau.AutoSize = true;
            this.lbl_Mat_Khau.Location = new System.Drawing.Point(42, 79);
            this.lbl_Mat_Khau.Name = "lbl_Mat_Khau";
            this.lbl_Mat_Khau.Size = new System.Drawing.Size(63, 15);
            this.lbl_Mat_Khau.TabIndex = 1;
            this.lbl_Mat_Khau.Text = "Mật Khẩu";
            // 
            // lbl_Ten_Dang_Nhap
            // 
            this.lbl_Ten_Dang_Nhap.AutoSize = true;
            this.lbl_Ten_Dang_Nhap.Location = new System.Drawing.Point(42, 36);
            this.lbl_Ten_Dang_Nhap.Name = "lbl_Ten_Dang_Nhap";
            this.lbl_Ten_Dang_Nhap.Size = new System.Drawing.Size(98, 15);
            this.lbl_Ten_Dang_Nhap.TabIndex = 0;
            this.lbl_Ten_Dang_Nhap.Text = "Tên Đăng Nhập";
            // 
            // Frm_Dang_Nhap
            // 
            this.AcceptButton = this.btn_Dang_Nhap;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_Dang_Nhap);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "Frm_Dang_Nhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Dang_Nhap;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_Dang_Nhap;
        private System.Windows.Forms.TextBox textBox_Mat_Khau;
        private System.Windows.Forms.TextBox textBox_Dang_Nhap;
        private System.Windows.Forms.Label lbl_Mat_Khau;
        private System.Windows.Forms.Label lbl_Ten_Dang_Nhap;
    }
}

