namespace BTL_CSDL
{
    partial class Frm_Thong_Tin_Benh_Nhan
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
            this.lbl_Ho_Ten = new System.Windows.Forms.Label();
            this.textBox_Ho_Ten = new System.Windows.Forms.TextBox();
            this.btn_Tim = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.button_Sua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Ho_Ten
            // 
            this.lbl_Ho_Ten.AutoSize = true;
            this.lbl_Ho_Ten.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Ho_Ten.Location = new System.Drawing.Point(48, 66);
            this.lbl_Ho_Ten.Name = "lbl_Ho_Ten";
            this.lbl_Ho_Ten.Size = new System.Drawing.Size(128, 15);
            this.lbl_Ho_Ten.TabIndex = 0;
            this.lbl_Ho_Ten.Text = "Họ Và Tên Bệnh Nhân";
            // 
            // textBox_Ho_Ten
            // 
            this.textBox_Ho_Ten.Location = new System.Drawing.Point(182, 60);
            this.textBox_Ho_Ten.Name = "textBox_Ho_Ten";
            this.textBox_Ho_Ten.Size = new System.Drawing.Size(364, 21);
            this.textBox_Ho_Ten.TabIndex = 1;
            // 
            // btn_Tim
            // 
            this.btn_Tim.Location = new System.Drawing.Point(552, 50);
            this.btn_Tim.Name = "btn_Tim";
            this.btn_Tim.Size = new System.Drawing.Size(85, 31);
            this.btn_Tim.TabIndex = 2;
            this.btn_Tim.Text = "Tìm";
            this.btn_Tim.UseVisualStyleBackColor = true;
            this.btn_Tim.Click += new System.EventHandler(this.btn_Tim_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(51, 100);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(586, 300);
            this.dataGridView.TabIndex = 3;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(552, 406);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(85, 31);
            this.btn_Thoat.TabIndex = 4;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // button_Sua
            // 
            this.button_Sua.Location = new System.Drawing.Point(51, 406);
            this.button_Sua.Name = "button_Sua";
            this.button_Sua.Size = new System.Drawing.Size(85, 31);
            this.button_Sua.TabIndex = 5;
            this.button_Sua.Text = "Sửa";
            this.button_Sua.UseVisualStyleBackColor = true;
            this.button_Sua.Click += new System.EventHandler(this.button_Sua_Click);
            // 
            // Frm_Thong_Tin_Benh_Nhan
            // 
            this.AcceptButton = this.btn_Tim;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.ControlBox = false;
            this.Controls.Add(this.button_Sua);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btn_Tim);
            this.Controls.Add(this.textBox_Ho_Ten);
            this.Controls.Add(this.lbl_Ho_Ten);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Frm_Thong_Tin_Benh_Nhan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông Tin Bệnh Nhân";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Ho_Ten;
        private System.Windows.Forms.TextBox textBox_Ho_Ten;
        private System.Windows.Forms.Button btn_Tim;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button button_Sua;
    }
}