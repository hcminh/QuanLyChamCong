namespace QuanLyChamCong
{
    partial class SendingMail
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
            this.btn_send = new System.Windows.Forms.Button();
            this.tb_content = new System.Windows.Forms.TextBox();
            this.lb_body = new System.Windows.Forms.Label();
            this.lb_subject = new System.Windows.Forms.Label();
            this.tb_subject = new System.Windows.Forms.TextBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.cb_object = new System.Windows.Forms.ComboBox();
            this.lb_object = new System.Windows.Forms.Label();
            this.lb_errSubject = new System.Windows.Forms.Label();
            this.lb_errContent = new System.Windows.Forms.Label();
            this.lb_errObject = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(601, 449);
            this.btn_send.Margin = new System.Windows.Forms.Padding(4);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(156, 67);
            this.btn_send.TabIndex = 9;
            this.btn_send.Text = "Gửi";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // tb_content
            // 
            this.tb_content.Location = new System.Drawing.Point(26, 150);
            this.tb_content.Margin = new System.Windows.Forms.Padding(4);
            this.tb_content.Multiline = true;
            this.tb_content.Name = "tb_content";
            this.tb_content.Size = new System.Drawing.Size(731, 272);
            this.tb_content.TabIndex = 8;
            this.tb_content.TextChanged += new System.EventHandler(this.tb_content_TextChanged);
            // 
            // lb_body
            // 
            this.lb_body.AutoSize = true;
            this.lb_body.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_body.Location = new System.Drawing.Point(21, 93);
            this.lb_body.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_body.Name = "lb_body";
            this.lb_body.Size = new System.Drawing.Size(96, 24);
            this.lb_body.TabIndex = 7;
            this.lb_body.Text = "Nội dung:";
            // 
            // lb_subject
            // 
            this.lb_subject.AutoSize = true;
            this.lb_subject.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_subject.Location = new System.Drawing.Point(21, 41);
            this.lb_subject.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_subject.Name = "lb_subject";
            this.lb_subject.Size = new System.Drawing.Size(84, 24);
            this.lb_subject.TabIndex = 6;
            this.lb_subject.Text = "Tiêu đề:";
            // 
            // tb_subject
            // 
            this.tb_subject.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_subject.Location = new System.Drawing.Point(146, 38);
            this.tb_subject.Margin = new System.Windows.Forms.Padding(4);
            this.tb_subject.Name = "tb_subject";
            this.tb_subject.Size = new System.Drawing.Size(611, 32);
            this.tb_subject.TabIndex = 5;
            this.tb_subject.TextChanged += new System.EventHandler(this.tb_subject_TextChanged);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(26, 449);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(156, 67);
            this.btn_exit.TabIndex = 10;
            this.btn_exit.Text = "Thoát";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // cb_object
            // 
            this.cb_object.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_object.FormattingEnabled = true;
            this.cb_object.Location = new System.Drawing.Point(353, 463);
            this.cb_object.Name = "cb_object";
            this.cb_object.Size = new System.Drawing.Size(222, 30);
            this.cb_object.TabIndex = 11;
            this.cb_object.SelectedIndexChanged += new System.EventHandler(this.cb_object_SelectedIndexChanged);
            // 
            // lb_object
            // 
            this.lb_object.AutoSize = true;
            this.lb_object.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_object.Location = new System.Drawing.Point(229, 469);
            this.lb_object.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_object.Name = "lb_object";
            this.lb_object.Size = new System.Drawing.Size(105, 24);
            this.lb_object.TabIndex = 12;
            this.lb_object.Text = "Đối tượng:";
            // 
            // lb_errSubject
            // 
            this.lb_errSubject.AutoSize = true;
            this.lb_errSubject.BackColor = System.Drawing.SystemColors.Control;
            this.lb_errSubject.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_errSubject.ForeColor = System.Drawing.Color.Red;
            this.lb_errSubject.Location = new System.Drawing.Point(143, 17);
            this.lb_errSubject.Name = "lb_errSubject";
            this.lb_errSubject.Size = new System.Drawing.Size(198, 17);
            this.lb_errSubject.TabIndex = 13;
            this.lb_errSubject.Text = "Yêu cầu nhập tiều đề cho thư!!";
            this.lb_errSubject.Visible = false;
            // 
            // lb_errContent
            // 
            this.lb_errContent.AutoSize = true;
            this.lb_errContent.BackColor = System.Drawing.SystemColors.Control;
            this.lb_errContent.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_errContent.ForeColor = System.Drawing.Color.Red;
            this.lb_errContent.Location = new System.Drawing.Point(23, 129);
            this.lb_errContent.Name = "lb_errContent";
            this.lb_errContent.Size = new System.Drawing.Size(211, 17);
            this.lb_errContent.TabIndex = 14;
            this.lb_errContent.Text = "Yêu cầu nhập nội dung cho thư!!";
            this.lb_errContent.Visible = false;
            // 
            // lb_errObject
            // 
            this.lb_errObject.AutoSize = true;
            this.lb_errObject.BackColor = System.Drawing.SystemColors.Control;
            this.lb_errObject.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_errObject.ForeColor = System.Drawing.Color.Red;
            this.lb_errObject.Location = new System.Drawing.Point(350, 443);
            this.lb_errObject.Name = "lb_errObject";
            this.lb_errObject.Size = new System.Drawing.Size(136, 17);
            this.lb_errObject.TabIndex = 15;
            this.lb_errObject.Text = "Chọn đối tượng gửi!!";
            this.lb_errObject.Visible = false;
            // 
            // SendingMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 539);
            this.Controls.Add(this.lb_errObject);
            this.Controls.Add(this.lb_errContent);
            this.Controls.Add(this.lb_errSubject);
            this.Controls.Add(this.lb_object);
            this.Controls.Add(this.cb_object);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.tb_content);
            this.Controls.Add(this.lb_body);
            this.Controls.Add(this.lb_subject);
            this.Controls.Add(this.tb_subject);
            this.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SendingMail";
            this.Text = "SendingMail";
            this.Load += new System.EventHandler(this.SendingMail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.TextBox tb_content;
        private System.Windows.Forms.Label lb_body;
        private System.Windows.Forms.Label lb_subject;
        private System.Windows.Forms.TextBox tb_subject;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.ComboBox cb_object;
        private System.Windows.Forms.Label lb_object;
        private System.Windows.Forms.Label lb_errSubject;
        private System.Windows.Forms.Label lb_errContent;
        private System.Windows.Forms.Label lb_errObject;
    }
}