namespace QuanLyChamCong
{
    partial class Create_User
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
            this.btn_return = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_rePass = new System.Windows.Forms.TextBox();
            this.btn_signIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(12, 41);
            this.tb_username.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_username.Multiline = true;
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(288, 45);
            this.tb_username.TabIndex = 0;
            this.tb_username.WordWrap = false;
            // 
            // btn_return
            // 
            this.btn_return.Location = new System.Drawing.Point(16, 293);
            this.btn_return.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(128, 47);
            this.btn_return.TabIndex = 1;
            this.btn_return.Text = "Quay lại";
            this.btn_return.UseVisualStyleBackColor = true;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tài khoản:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mật khẩu:";
            // 
            // tb_pass
            // 
            this.tb_pass.Location = new System.Drawing.Point(12, 127);
            this.tb_pass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_pass.Multiline = true;
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.PasswordChar = '*';
            this.tb_pass.Size = new System.Drawing.Size(288, 45);
            this.tb_pass.TabIndex = 4;
            this.tb_pass.WordWrap = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nhập lại mật khẩu:";
            // 
            // tb_rePass
            // 
            this.tb_rePass.Location = new System.Drawing.Point(12, 218);
            this.tb_rePass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_rePass.Multiline = true;
            this.tb_rePass.Name = "tb_rePass";
            this.tb_rePass.PasswordChar = '*';
            this.tb_rePass.Size = new System.Drawing.Size(288, 45);
            this.tb_rePass.TabIndex = 6;
            this.tb_rePass.WordWrap = false;
            // 
            // btn_signIn
            // 
            this.btn_signIn.Location = new System.Drawing.Point(172, 293);
            this.btn_signIn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_signIn.Name = "btn_signIn";
            this.btn_signIn.Size = new System.Drawing.Size(128, 47);
            this.btn_signIn.TabIndex = 8;
            this.btn_signIn.Text = "Đăng kí";
            this.btn_signIn.UseVisualStyleBackColor = true;
            this.btn_signIn.Click += new System.EventHandler(this.btn_signIn_Click);
            // 
            // Create_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 359);
            this.Controls.Add(this.btn_signIn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_rePass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_pass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_return);
            this.Controls.Add(this.tb_username);
            this.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Create_User";
            this.Text = "Create_User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.Button btn_return;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_pass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_rePass;
        private System.Windows.Forms.Button btn_signIn;
    }
}