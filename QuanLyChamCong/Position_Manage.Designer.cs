namespace QuanLyChamCong
{
    partial class Position_Manage
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.addPositon = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_salary = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dt_positon = new System.Windows.Forms.DataGridView();
            this.btn_add = new System.Windows.Forms.Button();
            this.tb_position = new System.Windows.Forms.TextBox();
            this.editPositon = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_getSalary = new System.Windows.Forms.Button();
            this.tb_salaryEdit = new System.Windows.Forms.TextBox();
            this.cb_position = new System.Windows.Forms.ComboBox();
            this.deletePositon = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.cb_positonDelete = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.addPositon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_positon)).BeginInit();
            this.editPositon.SuspendLayout();
            this.deletePositon.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.addPositon);
            this.tabControl1.Controls.Add(this.editPositon);
            this.tabControl1.Controls.Add(this.deletePositon);
            this.tabControl1.Location = new System.Drawing.Point(14, 16);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(572, 327);
            this.tabControl1.TabIndex = 0;
            // 
            // addPositon
            // 
            this.addPositon.Controls.Add(this.label3);
            this.addPositon.Controls.Add(this.label2);
            this.addPositon.Controls.Add(this.tb_salary);
            this.addPositon.Controls.Add(this.label1);
            this.addPositon.Controls.Add(this.dt_positon);
            this.addPositon.Controls.Add(this.btn_add);
            this.addPositon.Controls.Add(this.tb_position);
            this.addPositon.Location = new System.Drawing.Point(4, 30);
            this.addPositon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addPositon.Name = "addPositon";
            this.addPositon.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addPositon.Size = new System.Drawing.Size(564, 293);
            this.addPositon.TabIndex = 0;
            this.addPositon.Text = "Thêm Vị Trí";
            this.addPositon.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(301, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nhập hệ số lương:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nhập tên vị trí:";
            // 
            // tb_salary
            // 
            this.tb_salary.Location = new System.Drawing.Point(304, 37);
            this.tb_salary.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_salary.Multiline = true;
            this.tb_salary.Name = "tb_salary";
            this.tb_salary.Size = new System.Drawing.Size(251, 34);
            this.tb_salary.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Các vị trí đã tồn tại";
            // 
            // dt_positon
            // 
            this.dt_positon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_positon.Location = new System.Drawing.Point(6, 143);
            this.dt_positon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dt_positon.Name = "dt_positon";
            this.dt_positon.RowTemplate.Height = 24;
            this.dt_positon.Size = new System.Drawing.Size(549, 140);
            this.dt_positon.TabIndex = 2;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(443, 88);
            this.btn_add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(112, 47);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // tb_position
            // 
            this.tb_position.Location = new System.Drawing.Point(11, 37);
            this.tb_position.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_position.Multiline = true;
            this.tb_position.Name = "tb_position";
            this.tb_position.Size = new System.Drawing.Size(251, 34);
            this.tb_position.TabIndex = 0;
            // 
            // editPositon
            // 
            this.editPositon.Controls.Add(this.label5);
            this.editPositon.Controls.Add(this.label4);
            this.editPositon.Controls.Add(this.btn_save);
            this.editPositon.Controls.Add(this.btn_getSalary);
            this.editPositon.Controls.Add(this.tb_salaryEdit);
            this.editPositon.Controls.Add(this.cb_position);
            this.editPositon.Location = new System.Drawing.Point(4, 30);
            this.editPositon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.editPositon.Name = "editPositon";
            this.editPositon.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.editPositon.Size = new System.Drawing.Size(564, 293);
            this.editPositon.TabIndex = 1;
            this.editPositon.Text = "Sửa Vị Trí";
            this.editPositon.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(120, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Chọn vị trí cần sửa:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(120, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nhập hệ số lương:";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(349, 156);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(84, 40);
            this.btn_save.TabIndex = 3;
            this.btn_save.Text = "Lưu";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_getSalary
            // 
            this.btn_getSalary.Location = new System.Drawing.Point(349, 83);
            this.btn_getSalary.Name = "btn_getSalary";
            this.btn_getSalary.Size = new System.Drawing.Size(84, 32);
            this.btn_getSalary.TabIndex = 2;
            this.btn_getSalary.Text = "Kiểm tra";
            this.btn_getSalary.UseVisualStyleBackColor = true;
            this.btn_getSalary.Click += new System.EventHandler(this.btn_getSalary_Click);
            // 
            // tb_salaryEdit
            // 
            this.tb_salaryEdit.Location = new System.Drawing.Point(123, 156);
            this.tb_salaryEdit.Multiline = true;
            this.tb_salaryEdit.Name = "tb_salaryEdit";
            this.tb_salaryEdit.Size = new System.Drawing.Size(194, 40);
            this.tb_salaryEdit.TabIndex = 1;
            // 
            // cb_position
            // 
            this.cb_position.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_position.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_position.FormattingEnabled = true;
            this.cb_position.ItemHeight = 24;
            this.cb_position.Location = new System.Drawing.Point(123, 86);
            this.cb_position.Name = "cb_position";
            this.cb_position.Size = new System.Drawing.Size(194, 32);
            this.cb_position.TabIndex = 0;
            // 
            // deletePositon
            // 
            this.deletePositon.Controls.Add(this.label6);
            this.deletePositon.Controls.Add(this.btn_delete);
            this.deletePositon.Controls.Add(this.cb_positonDelete);
            this.deletePositon.Location = new System.Drawing.Point(4, 30);
            this.deletePositon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.deletePositon.Name = "deletePositon";
            this.deletePositon.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.deletePositon.Size = new System.Drawing.Size(564, 293);
            this.deletePositon.TabIndex = 2;
            this.deletePositon.Text = "Xóa Vị Trí";
            this.deletePositon.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(116, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Chọn vị trí cần xóa:";
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(345, 130);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(84, 35);
            this.btn_delete.TabIndex = 10;
            this.btn_delete.Text = "Xóa";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // cb_positonDelete
            // 
            this.cb_positonDelete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_positonDelete.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_positonDelete.FormattingEnabled = true;
            this.cb_positonDelete.ItemHeight = 24;
            this.cb_positonDelete.Location = new System.Drawing.Point(119, 133);
            this.cb_positonDelete.Name = "cb_positonDelete";
            this.cb_positonDelete.Size = new System.Drawing.Size(194, 32);
            this.cb_positonDelete.TabIndex = 9;
            // 
            // Position_Manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 346);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Position_Manage";
            this.Text = "Quản lý vị trí";
            this.Load += new System.EventHandler(this.Position_Manage_Load);
            this.tabControl1.ResumeLayout(false);
            this.addPositon.ResumeLayout(false);
            this.addPositon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_positon)).EndInit();
            this.editPositon.ResumeLayout(false);
            this.editPositon.PerformLayout();
            this.deletePositon.ResumeLayout(false);
            this.deletePositon.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage addPositon;
        private System.Windows.Forms.TabPage editPositon;
        private System.Windows.Forms.TabPage deletePositon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dt_positon;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox tb_position;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_salary;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_getSalary;
        private System.Windows.Forms.TextBox tb_salaryEdit;
        private System.Windows.Forms.ComboBox cb_position;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.ComboBox cb_positonDelete;
    }
}