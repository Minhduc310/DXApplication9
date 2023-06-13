namespace DXApplication9
{
    partial class Password_change
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
            this.lblDoiMatKhau = new System.Windows.Forms.Label();
            this.lblOldPass = new System.Windows.Forms.Label();
            this.lblNewPass = new System.Windows.Forms.Label();
            this.lblConfirmNewPass = new System.Windows.Forms.Label();
            this.txtOldPassword = new System.Windows.Forms.TextBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.btnDongY = new System.Windows.Forms.Button();
            this.btnHuyBo = new System.Windows.Forms.Button();
            this.lblConfirmPassError = new System.Windows.Forms.Label();
            this.lblNewPassError = new System.Windows.Forms.Label();
            this.lblOldPassError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDoiMatKhau
            // 
            this.lblDoiMatKhau.BackColor = System.Drawing.Color.MidnightBlue;
            this.lblDoiMatKhau.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDoiMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoiMatKhau.ForeColor = System.Drawing.Color.White;
            this.lblDoiMatKhau.Location = new System.Drawing.Point(0, 0);
            this.lblDoiMatKhau.Name = "lblDoiMatKhau";
            this.lblDoiMatKhau.Size = new System.Drawing.Size(459, 53);
            this.lblDoiMatKhau.TabIndex = 0;
            this.lblDoiMatKhau.Text = "ĐỔI MẬT KHẨU CÁ NHÂN";
            this.lblDoiMatKhau.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOldPass
            // 
            this.lblOldPass.BackColor = System.Drawing.Color.Transparent;
            this.lblOldPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldPass.Location = new System.Drawing.Point(24, 103);
            this.lblOldPass.Name = "lblOldPass";
            this.lblOldPass.Size = new System.Drawing.Size(191, 23);
            this.lblOldPass.TabIndex = 0;
            this.lblOldPass.Text = "Mật khẩu cũ: ";
            // 
            // lblNewPass
            // 
            this.lblNewPass.BackColor = System.Drawing.Color.Transparent;
            this.lblNewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPass.Location = new System.Drawing.Point(24, 154);
            this.lblNewPass.Name = "lblNewPass";
            this.lblNewPass.Size = new System.Drawing.Size(191, 23);
            this.lblNewPass.TabIndex = 0;
            this.lblNewPass.Text = "Mật khẩu mới: ";
            // 
            // lblConfirmNewPass
            // 
            this.lblConfirmNewPass.BackColor = System.Drawing.Color.Transparent;
            this.lblConfirmNewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmNewPass.Location = new System.Drawing.Point(24, 203);
            this.lblConfirmNewPass.Name = "lblConfirmNewPass";
            this.lblConfirmNewPass.Size = new System.Drawing.Size(191, 23);
            this.lblConfirmNewPass.TabIndex = 0;
            this.lblConfirmNewPass.Text = "Nhập lại mật khẩu mới: ";
            // 
            // txtOldPassword
            // 
            this.txtOldPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOldPassword.Location = new System.Drawing.Point(221, 99);
            this.txtOldPassword.Name = "txtOldPassword";
            this.txtOldPassword.PasswordChar = '●';
            this.txtOldPassword.Size = new System.Drawing.Size(226, 27);
            this.txtOldPassword.TabIndex = 1;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassword.Location = new System.Drawing.Point(221, 150);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '●';
            this.txtNewPassword.Size = new System.Drawing.Size(226, 27);
            this.txtNewPassword.TabIndex = 2;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword.Location = new System.Drawing.Point(221, 199);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '●';
            this.txtConfirmPassword.Size = new System.Drawing.Size(226, 27);
            this.txtConfirmPassword.TabIndex = 3;
            // 
            // btnDongY
            // 
            this.btnDongY.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDongY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDongY.Location = new System.Drawing.Point(221, 248);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(93, 37);
            this.btnDongY.TabIndex = 4;
            this.btnDongY.Text = "Đồng ý";
            this.btnDongY.UseVisualStyleBackColor = true;
            this.btnDongY.Click += new System.EventHandler(this.btnDongY_Click);
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnHuyBo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyBo.Location = new System.Drawing.Point(354, 248);
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.Size = new System.Drawing.Size(93, 37);
            this.btnHuyBo.TabIndex = 5;
            this.btnHuyBo.Text = "Huỷ bỏ";
            this.btnHuyBo.UseVisualStyleBackColor = true;
            this.btnHuyBo.Click += new System.EventHandler(this.btnHuyBo_Click);
            // 
            // lblConfirmPassError
            // 
            this.lblConfirmPassError.AutoSize = true;
            this.lblConfirmPassError.BackColor = System.Drawing.Color.Transparent;
            this.lblConfirmPassError.ForeColor = System.Drawing.Color.Red;
            this.lblConfirmPassError.Location = new System.Drawing.Point(221, 229);
            this.lblConfirmPassError.Name = "lblConfirmPassError";
            this.lblConfirmPassError.Size = new System.Drawing.Size(0, 16);
            this.lblConfirmPassError.TabIndex = 0;
            // 
            // lblNewPassError
            // 
            this.lblNewPassError.AutoSize = true;
            this.lblNewPassError.BackColor = System.Drawing.Color.Transparent;
            this.lblNewPassError.ForeColor = System.Drawing.Color.Red;
            this.lblNewPassError.Location = new System.Drawing.Point(221, 180);
            this.lblNewPassError.Name = "lblNewPassError";
            this.lblNewPassError.Size = new System.Drawing.Size(0, 16);
            this.lblNewPassError.TabIndex = 0;
            // 
            // lblOldPassError
            // 
            this.lblOldPassError.AutoSize = true;
            this.lblOldPassError.BackColor = System.Drawing.Color.Transparent;
            this.lblOldPassError.ForeColor = System.Drawing.Color.Red;
            this.lblOldPassError.Location = new System.Drawing.Point(221, 129);
            this.lblOldPassError.Name = "lblOldPassError";
            this.lblOldPassError.Size = new System.Drawing.Size(0, 16);
            this.lblOldPassError.TabIndex = 7;
            // 
            // Password_change
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(459, 314);
            this.Controls.Add(this.lblOldPassError);
            this.Controls.Add(this.lblNewPassError);
            this.Controls.Add(this.lblConfirmPassError);
            this.Controls.Add(this.btnHuyBo);
            this.Controls.Add(this.btnDongY);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.txtOldPassword);
            this.Controls.Add(this.lblConfirmNewPass);
            this.Controls.Add(this.lblNewPass);
            this.Controls.Add(this.lblOldPass);
            this.Controls.Add(this.lblDoiMatKhau);
            this.Name = "Password_change";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi mật khẩu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDoiMatKhau;
        private System.Windows.Forms.Label lblOldPass;
        private System.Windows.Forms.Label lblNewPass;
        private System.Windows.Forms.Label lblConfirmNewPass;
        public System.Windows.Forms.TextBox txtOldPassword;
        public System.Windows.Forms.TextBox txtNewPassword;
        public System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Button btnDongY;
        private System.Windows.Forms.Button btnHuyBo;
        public System.Windows.Forms.Label lblConfirmPassError;
        public System.Windows.Forms.Label lblNewPassError;
        public System.Windows.Forms.Label lblOldPassError;
    }
}