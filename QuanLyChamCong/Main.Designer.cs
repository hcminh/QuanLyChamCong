namespace QuanLyChamCong
{
    partial class Main
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
            this.dt_listNV = new System.Windows.Forms.DataGridView();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btn_manage = new System.Windows.Forms.Button();
            this.btn_check = new System.Windows.Forms.Button();
            this.btn_sprint = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_sprintList = new System.Windows.Forms.Button();
            this.btn_sprintInfo = new System.Windows.Forms.Button();
            this.btn_mail = new System.Windows.Forms.Button();
            this.gb_modeSalary = new System.Windows.Forms.GroupBox();
            this.lb_salary = new System.Windows.Forms.Label();
            this.lb_code = new System.Windows.Forms.Label();
            this.lb_position = new System.Windows.Forms.Label();
            this.lb_sumTimeJob = new System.Windows.Forms.Label();
            this.lb_name = new System.Windows.Forms.Label();
            this.lb_join = new System.Windows.Forms.Label();
            this.lb_info7 = new System.Windows.Forms.Label();
            this.lb_info6 = new System.Windows.Forms.Label();
            this.lb_info5 = new System.Windows.Forms.Label();
            this.lb_info4 = new System.Windows.Forms.Label();
            this.lb_info2 = new System.Windows.Forms.Label();
            this.lb_info1 = new System.Windows.Forms.Label();
            this.tb_searchCode = new System.Windows.Forms.TextBox();
            this.btn_addPosition = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dt_listNV)).BeginInit();
            this.gb_modeSalary.SuspendLayout();
            this.SuspendLayout();
            // 
            // dt_listNV
            // 
            this.dt_listNV.AllowUserToAddRows = false;
            this.dt_listNV.AllowUserToDeleteRows = false;
            this.dt_listNV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dt_listNV.ColumnHeadersHeight = 35;
            this.dt_listNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dt_listNV.Location = new System.Drawing.Point(12, 279);
            this.dt_listNV.Name = "dt_listNV";
            this.dt_listNV.ReadOnly = true;
            this.dt_listNV.RowTemplate.Height = 24;
            this.dt_listNV.Size = new System.Drawing.Size(1380, 459);
            this.dt_listNV.TabIndex = 0;
            this.dt_listNV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_listNV_CellContentClick);
            this.dt_listNV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_listNV_CellContentClick);
            this.dt_listNV.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dt_listNV_RowHeaderMouseClick);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthCalendar1.Location = new System.Drawing.Point(1124, 18);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            // 
            // btn_manage
            // 
            this.btn_manage.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_manage.Location = new System.Drawing.Point(12, 12);
            this.btn_manage.Name = "btn_manage";
            this.btn_manage.Size = new System.Drawing.Size(127, 41);
            this.btn_manage.TabIndex = 3;
            this.btn_manage.Text = "Quản Lí ";
            this.btn_manage.UseVisualStyleBackColor = true;
            this.btn_manage.Click += new System.EventHandler(this.btn_manage_Click);
            // 
            // btn_check
            // 
            this.btn_check.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_check.Location = new System.Drawing.Point(12, 83);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(127, 41);
            this.btn_check.TabIndex = 4;
            this.btn_check.Text = "Kiểm tra";
            this.btn_check.UseVisualStyleBackColor = true;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // btn_sprint
            // 
            this.btn_sprint.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sprint.Location = new System.Drawing.Point(12, 151);
            this.btn_sprint.Name = "btn_sprint";
            this.btn_sprint.Size = new System.Drawing.Size(127, 41);
            this.btn_sprint.TabIndex = 5;
            this.btn_sprint.Text = "Dữ liệu";
            this.btn_sprint.UseVisualStyleBackColor = true;
            this.btn_sprint.Click += new System.EventHandler(this.btn_sprint_Click);
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(162, 15);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(108, 34);
            this.btn_add.TabIndex = 6;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Visible = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.Location = new System.Drawing.Point(276, 15);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(108, 34);
            this.btn_edit.TabIndex = 7;
            this.btn_edit.Text = "Sửa";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Visible = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(390, 15);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(108, 34);
            this.btn_delete.TabIndex = 8;
            this.btn_delete.Text = "Xóa";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Visible = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(390, 86);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(108, 34);
            this.btn_search.TabIndex = 10;
            this.btn_search.Text = "Tìm";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Visible = false;
            this.btn_search.Click += new System.EventHandler(this.btn_info_Click);
            // 
            // btn_sprintList
            // 
            this.btn_sprintList.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sprintList.Location = new System.Drawing.Point(325, 154);
            this.btn_sprintList.Name = "btn_sprintList";
            this.btn_sprintList.Size = new System.Drawing.Size(173, 34);
            this.btn_sprintList.TabIndex = 13;
            this.btn_sprintList.Text = "In danh sách";
            this.btn_sprintList.UseVisualStyleBackColor = true;
            this.btn_sprintList.Visible = false;
            this.btn_sprintList.Click += new System.EventHandler(this.btn_sprintList_Click);
            // 
            // btn_sprintInfo
            // 
            this.btn_sprintInfo.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sprintInfo.Location = new System.Drawing.Point(162, 154);
            this.btn_sprintInfo.Name = "btn_sprintInfo";
            this.btn_sprintInfo.Size = new System.Drawing.Size(157, 34);
            this.btn_sprintInfo.TabIndex = 12;
            this.btn_sprintInfo.Text = "In thông tin";
            this.btn_sprintInfo.UseVisualStyleBackColor = true;
            this.btn_sprintInfo.Visible = false;
            this.btn_sprintInfo.Click += new System.EventHandler(this.btn_sprintInfo_Click);
            // 
            // btn_mail
            // 
            this.btn_mail.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mail.Location = new System.Drawing.Point(12, 216);
            this.btn_mail.Name = "btn_mail";
            this.btn_mail.Size = new System.Drawing.Size(127, 41);
            this.btn_mail.TabIndex = 14;
            this.btn_mail.Text = "Gửi thông báo";
            this.btn_mail.UseVisualStyleBackColor = true;
            this.btn_mail.Click += new System.EventHandler(this.btn_mail_Click);
            // 
            // gb_modeSalary
            // 
            this.gb_modeSalary.Controls.Add(this.lb_salary);
            this.gb_modeSalary.Controls.Add(this.lb_code);
            this.gb_modeSalary.Controls.Add(this.lb_position);
            this.gb_modeSalary.Controls.Add(this.lb_sumTimeJob);
            this.gb_modeSalary.Controls.Add(this.lb_name);
            this.gb_modeSalary.Controls.Add(this.lb_join);
            this.gb_modeSalary.Controls.Add(this.lb_info7);
            this.gb_modeSalary.Controls.Add(this.lb_info6);
            this.gb_modeSalary.Controls.Add(this.lb_info5);
            this.gb_modeSalary.Controls.Add(this.lb_info4);
            this.gb_modeSalary.Controls.Add(this.lb_info2);
            this.gb_modeSalary.Controls.Add(this.lb_info1);
            this.gb_modeSalary.Location = new System.Drawing.Point(536, 18);
            this.gb_modeSalary.Name = "gb_modeSalary";
            this.gb_modeSalary.Size = new System.Drawing.Size(576, 245);
            this.gb_modeSalary.TabIndex = 16;
            this.gb_modeSalary.TabStop = false;
            this.gb_modeSalary.Text = "Thông tin lương";
            // 
            // lb_salary
            // 
            this.lb_salary.AutoSize = true;
            this.lb_salary.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_salary.Location = new System.Drawing.Point(467, 98);
            this.lb_salary.Name = "lb_salary";
            this.lb_salary.Size = new System.Drawing.Size(64, 18);
            this.lb_salary.TabIndex = 27;
            this.lb_salary.Text = "3000000";
            // 
            // lb_code
            // 
            this.lb_code.AutoSize = true;
            this.lb_code.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_code.Location = new System.Drawing.Point(150, 99);
            this.lb_code.Name = "lb_code";
            this.lb_code.Size = new System.Drawing.Size(48, 18);
            this.lb_code.TabIndex = 26;
            this.lb_code.Text = "12345";
            // 
            // lb_position
            // 
            this.lb_position.AutoSize = true;
            this.lb_position.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_position.Location = new System.Drawing.Point(467, 47);
            this.lb_position.Name = "lb_position";
            this.lb_position.Size = new System.Drawing.Size(32, 18);
            this.lb_position.TabIndex = 25;
            this.lb_position.Text = "pick";
            // 
            // lb_sumTimeJob
            // 
            this.lb_sumTimeJob.AutoSize = true;
            this.lb_sumTimeJob.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sumTimeJob.Location = new System.Drawing.Point(149, 201);
            this.lb_sumTimeJob.Name = "lb_sumTimeJob";
            this.lb_sumTimeJob.Size = new System.Drawing.Size(47, 18);
            this.lb_sumTimeJob.TabIndex = 24;
            this.lb_sumTimeJob.Text = "20 giờ";
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_name.Location = new System.Drawing.Point(149, 47);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(123, 18);
            this.lb_name.TabIndex = 22;
            this.lb_name.Text = "Hoàng Công Minh";
            // 
            // lb_join
            // 
            this.lb_join.AutoSize = true;
            this.lb_join.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_join.Location = new System.Drawing.Point(149, 146);
            this.lb_join.Name = "lb_join";
            this.lb_join.Size = new System.Drawing.Size(68, 18);
            this.lb_join.TabIndex = 21;
            this.lb_join.Text = "1/1/1999";
            // 
            // lb_info7
            // 
            this.lb_info7.AutoSize = true;
            this.lb_info7.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_info7.Location = new System.Drawing.Point(26, 96);
            this.lb_info7.Name = "lb_info7";
            this.lb_info7.Size = new System.Drawing.Size(118, 21);
            this.lb_info7.TabIndex = 20;
            this.lb_info7.Tag = "";
            this.lb_info7.Text = "Mã Nhân Viên:";
            // 
            // lb_info6
            // 
            this.lb_info6.AutoSize = true;
            this.lb_info6.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_info6.Location = new System.Drawing.Point(340, 44);
            this.lb_info6.Name = "lb_info6";
            this.lb_info6.Size = new System.Drawing.Size(55, 21);
            this.lb_info6.TabIndex = 12;
            this.lb_info6.Text = "Vị Trí:";
            // 
            // lb_info5
            // 
            this.lb_info5.AutoSize = true;
            this.lb_info5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_info5.Location = new System.Drawing.Point(26, 197);
            this.lb_info5.Name = "lb_info5";
            this.lb_info5.Size = new System.Drawing.Size(116, 21);
            this.lb_info5.TabIndex = 10;
            this.lb_info5.Text = "Thời gian làm:";
            // 
            // lb_info4
            // 
            this.lb_info4.AutoSize = true;
            this.lb_info4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_info4.Location = new System.Drawing.Point(26, 143);
            this.lb_info4.Name = "lb_info4";
            this.lb_info4.Size = new System.Drawing.Size(116, 21);
            this.lb_info4.TabIndex = 8;
            this.lb_info4.Text = "Ngày vào làm:";
            // 
            // lb_info2
            // 
            this.lb_info2.AutoSize = true;
            this.lb_info2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_info2.Location = new System.Drawing.Point(340, 96);
            this.lb_info2.Name = "lb_info2";
            this.lb_info2.Size = new System.Drawing.Size(115, 21);
            this.lb_info2.TabIndex = 4;
            this.lb_info2.Text = "Lương cơ bản:";
            // 
            // lb_info1
            // 
            this.lb_info1.AutoSize = true;
            this.lb_info1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_info1.Location = new System.Drawing.Point(26, 44);
            this.lb_info1.Name = "lb_info1";
            this.lb_info1.Size = new System.Drawing.Size(69, 21);
            this.lb_info1.TabIndex = 2;
            this.lb_info1.Text = "Họ Tên:";
            // 
            // tb_searchCode
            // 
            this.tb_searchCode.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_searchCode.Location = new System.Drawing.Point(162, 86);
            this.tb_searchCode.Multiline = true;
            this.tb_searchCode.Name = "tb_searchCode";
            this.tb_searchCode.Size = new System.Drawing.Size(222, 38);
            this.tb_searchCode.TabIndex = 17;
            this.tb_searchCode.Text = "Mã nhân viên";
            this.tb_searchCode.Visible = false;
            this.tb_searchCode.WordWrap = false;
            // 
            // btn_addPosition
            // 
            this.btn_addPosition.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addPosition.Location = new System.Drawing.Point(162, 216);
            this.btn_addPosition.Name = "btn_addPosition";
            this.btn_addPosition.Size = new System.Drawing.Size(127, 41);
            this.btn_addPosition.TabIndex = 18;
            this.btn_addPosition.Text = "Thêm vị trí";
            this.btn_addPosition.UseVisualStyleBackColor = true;
            this.btn_addPosition.Click += new System.EventHandler(this.btn_addPosition_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.Location = new System.Drawing.Point(313, 216);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(127, 41);
            this.btn_logout.TabIndex = 19;
            this.btn_logout.Text = "Đăng xuất";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1404, 750);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.btn_addPosition);
            this.Controls.Add(this.tb_searchCode);
            this.Controls.Add(this.gb_modeSalary);
            this.Controls.Add(this.btn_mail);
            this.Controls.Add(this.btn_sprintList);
            this.Controls.Add(this.btn_sprintInfo);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_sprint);
            this.Controls.Add(this.btn_check);
            this.Controls.Add(this.btn_manage);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.dt_listNV);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dt_listNV)).EndInit();
            this.gb_modeSalary.ResumeLayout(false);
            this.gb_modeSalary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dt_listNV;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button btn_manage;
        private System.Windows.Forms.Button btn_check;
        private System.Windows.Forms.Button btn_sprint;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_sprintList;
        private System.Windows.Forms.Button btn_sprintInfo;
        private System.Windows.Forms.Button btn_mail;
        private System.Windows.Forms.GroupBox gb_modeSalary;
        private System.Windows.Forms.Label lb_info7;
        private System.Windows.Forms.Label lb_info6;
        private System.Windows.Forms.Label lb_info5;
        private System.Windows.Forms.Label lb_info4;
        private System.Windows.Forms.Label lb_info2;
        private System.Windows.Forms.Label lb_info1;
        private System.Windows.Forms.Label lb_salary;
        private System.Windows.Forms.Label lb_code;
        private System.Windows.Forms.Label lb_position;
        private System.Windows.Forms.Label lb_sumTimeJob;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Label lb_join;
        private System.Windows.Forms.TextBox tb_searchCode;
        private System.Windows.Forms.Button btn_addPosition;
        private System.Windows.Forms.Button btn_logout;
    }
}