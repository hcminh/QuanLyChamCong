namespace QuanLyChamCong
{
    partial class CheckInOut
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
            this.components = new System.ComponentModel.Container();
            this.dt_checked = new System.Windows.Forms.DataGridView();
            this.tb_code = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_connect = new System.Windows.Forms.Button();
            this.tb_ip = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pic_scanCode = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.t_render = new System.Windows.Forms.Timer(this.components);
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dt_checked)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_scanCode)).BeginInit();
            this.SuspendLayout();
            // 
            // dt_checked
            // 
            this.dt_checked.AllowUserToAddRows = false;
            this.dt_checked.AllowUserToDeleteRows = false;
            this.dt_checked.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_checked.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.code,
            this.name});
            this.dt_checked.Location = new System.Drawing.Point(12, 12);
            this.dt_checked.Name = "dt_checked";
            this.dt_checked.ReadOnly = true;
            this.dt_checked.RowHeadersVisible = false;
            this.dt_checked.RowHeadersWidth = 4;
            this.dt_checked.RowTemplate.Height = 24;
            this.dt_checked.Size = new System.Drawing.Size(380, 488);
            this.dt_checked.TabIndex = 0;
            // 
            // tb_code
            // 
            this.tb_code.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_code.Location = new System.Drawing.Point(427, 100);
            this.tb_code.Multiline = true;
            this.tb_code.Name = "tb_code";
            this.tb_code.Size = new System.Drawing.Size(327, 43);
            this.tb_code.TabIndex = 1;
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(760, 100);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(57, 43);
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "+";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_connect
            // 
            this.btn_connect.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_connect.Location = new System.Drawing.Point(695, 37);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(122, 36);
            this.btn_connect.TabIndex = 4;
            this.btn_connect.Tag = "connect";
            this.btn_connect.Text = "Kết nối";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_conect_Click);
            // 
            // tb_ip
            // 
            this.tb_ip.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ip.Location = new System.Drawing.Point(427, 37);
            this.tb_ip.Multiline = true;
            this.tb_ip.Name = "tb_ip";
            this.tb_ip.Size = new System.Drawing.Size(262, 36);
            this.tb_ip.TabIndex = 3;
            this.tb_ip.Text = "http://192";
            this.tb_ip.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(427, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nhập mã nhân viên";
            // 
            // pic_scanCode
            // 
            this.pic_scanCode.Location = new System.Drawing.Point(431, 161);
            this.pic_scanCode.Name = "pic_scanCode";
            this.pic_scanCode.Size = new System.Drawing.Size(386, 339);
            this.pic_scanCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_scanCode.TabIndex = 6;
            this.pic_scanCode.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(427, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nhập địa chỉ máy quét";
            // 
            // t_render
            // 
            this.t_render.Tick += new System.EventHandler(this.t_render_Tick);
            // 
            // code
            // 
            this.code.HeaderText = "Mã nhân viên";
            this.code.Name = "code";
            this.code.ReadOnly = true;
            this.code.Width = 150;
            // 
            // name
            // 
            this.name.HeaderText = "Họ tên";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 226;
            // 
            // CheckInOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 512);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pic_scanCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.tb_ip);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.tb_code);
            this.Controls.Add(this.dt_checked);
            this.Name = "CheckInOut";
            this.Text = "CheckInOut";
            ((System.ComponentModel.ISupportInitialize)(this.dt_checked)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_scanCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dt_checked;
        private System.Windows.Forms.TextBox tb_code;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.TextBox tb_ip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pic_scanCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer t_render;
        private System.Windows.Forms.DataGridViewTextBoxColumn code;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
    }
}