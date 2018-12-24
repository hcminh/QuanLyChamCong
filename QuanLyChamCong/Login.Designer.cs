namespace QuanLyChamCong
{
    partial class Login
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
            this.tb_username = new System.Windows.Forms.TextBox();
            this.lb_username = new System.Windows.Forms.Label();
            this.lb_password = new System.Windows.Forms.Label();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_checkInOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_username
            // 
            this.tb_username.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_username.Location = new System.Drawing.Point(193, 57);
            this.tb_username.Multiline = true;
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(230, 33);
            this.tb_username.TabIndex = 0;
            this.tb_username.WordWrap = false;
            // 
            // lb_username
            // 
            this.lb_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_username.Location = new System.Drawing.Point(48, 60);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(119, 30);
            this.lb_username.TabIndex = 1;
            this.lb_username.Text = "Tài khoản:";
            // 
            // lb_password
            // 
            this.lb_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_password.Location = new System.Drawing.Point(48, 114);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(119, 30);
            this.lb_password.TabIndex = 3;
            this.lb_password.Text = "Mật khẩu:";
            // 
            // tb_password
            // 
            this.tb_password.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_password.Location = new System.Drawing.Point(193, 111);
            this.tb_password.Multiline = true;
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(230, 33);
            this.tb_password.TabIndex = 2;
            this.tb_password.WordWrap = false;
            // 
            // btn_login
            // 
            this.btn_login.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.Location = new System.Drawing.Point(351, 179);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(119, 48);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "Đăng nhập";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(12, 179);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(119, 48);
            this.btn_exit.TabIndex = 5;
            this.btn_exit.Text = "Thoát";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_checkInOut
            // 
            this.btn_checkInOut.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_checkInOut.Location = new System.Drawing.Point(181, 179);
            this.btn_checkInOut.Name = "btn_checkInOut";
            this.btn_checkInOut.Size = new System.Drawing.Size(119, 48);
            this.btn_checkInOut.TabIndex = 6;
            this.btn_checkInOut.Text = "Điểm danh";
            this.btn_checkInOut.UseVisualStyleBackColor = true;
            this.btn_checkInOut.Click += new System.EventHandler(this.btn_checkInOut_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 253);
            this.Controls.Add(this.btn_checkInOut);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.lb_password);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.lb_username);
            this.Controls.Add(this.tb_username);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.Label lb_username;
        private System.Windows.Forms.Label lb_password;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_checkInOut;
    }
}