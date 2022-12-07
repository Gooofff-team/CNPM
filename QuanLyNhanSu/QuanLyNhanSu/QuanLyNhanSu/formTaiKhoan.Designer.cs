namespace QuanLyNhanSu
{
    partial class formTaiKhoan
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
            this.btThemTaiKhoan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgvTaiKhoan = new System.Windows.Forms.DataGridView();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.btDongFormTaiKhoan = new System.Windows.Forms.Button();
            this.btXoaTaiKhoan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTaiKhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // btThemTaiKhoan
            // 
            this.btThemTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btThemTaiKhoan.Location = new System.Drawing.Point(77, 257);
            this.btThemTaiKhoan.Name = "btThemTaiKhoan";
            this.btThemTaiKhoan.Size = new System.Drawing.Size(135, 43);
            this.btThemTaiKhoan.TabIndex = 0;
            this.btThemTaiKhoan.Text = "Thêm";
            this.btThemTaiKhoan.UseVisualStyleBackColor = true;
            this.btThemTaiKhoan.Click += new System.EventHandler(this.btThemTaiKhoan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(67, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(73, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật khẩu";
            // 
            // dtgvTaiKhoan
            // 
            this.dtgvTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTaiKhoan.Location = new System.Drawing.Point(456, 32);
            this.dtgvTaiKhoan.Name = "dtgvTaiKhoan";
            this.dtgvTaiKhoan.RowHeadersWidth = 51;
            this.dtgvTaiKhoan.RowTemplate.Height = 24;
            this.dtgvTaiKhoan.Size = new System.Drawing.Size(340, 373);
            this.dtgvTaiKhoan.TabIndex = 3;
            // 
            // tb1
            // 
            this.tb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tb1.Location = new System.Drawing.Point(175, 87);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(210, 27);
            this.tb1.TabIndex = 4;
            // 
            // tb2
            // 
            this.tb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tb2.Location = new System.Drawing.Point(175, 140);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(210, 27);
            this.tb2.TabIndex = 5;
            // 
            // btDongFormTaiKhoan
            // 
            this.btDongFormTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btDongFormTaiKhoan.Location = new System.Drawing.Point(175, 334);
            this.btDongFormTaiKhoan.Name = "btDongFormTaiKhoan";
            this.btDongFormTaiKhoan.Size = new System.Drawing.Size(118, 43);
            this.btDongFormTaiKhoan.TabIndex = 6;
            this.btDongFormTaiKhoan.Text = "Đóng";
            this.btDongFormTaiKhoan.UseVisualStyleBackColor = true;
            this.btDongFormTaiKhoan.Click += new System.EventHandler(this.btDongFormTaiKhoan_Click);
            // 
            // btXoaTaiKhoan
            // 
            this.btXoaTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btXoaTaiKhoan.Location = new System.Drawing.Point(263, 257);
            this.btXoaTaiKhoan.Name = "btXoaTaiKhoan";
            this.btXoaTaiKhoan.Size = new System.Drawing.Size(122, 43);
            this.btXoaTaiKhoan.TabIndex = 7;
            this.btXoaTaiKhoan.Text = "Xóa";
            this.btXoaTaiKhoan.UseVisualStyleBackColor = true;
            this.btXoaTaiKhoan.Click += new System.EventHandler(this.btXoaTaiKhoan_Click);
            // 
            // formTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 439);
            this.Controls.Add(this.btXoaTaiKhoan);
            this.Controls.Add(this.btDongFormTaiKhoan);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.dtgvTaiKhoan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btThemTaiKhoan);
            this.Name = "formTaiKhoan";
            this.Text = "Tài khoản";
            this.Load += new System.EventHandler(this.formTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTaiKhoan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btThemTaiKhoan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgvTaiKhoan;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.Button btDongFormTaiKhoan;
        private System.Windows.Forms.Button btXoaTaiKhoan;
    }
}