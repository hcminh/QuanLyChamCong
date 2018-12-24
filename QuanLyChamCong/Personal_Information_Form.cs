using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Printing;




namespace QuanLyChamCong
{
    public partial class Personal_Information_Form : Form
    {
        string MANV;
        string chucnang;

        public Personal_Information_Form(string MANV, string chucnang)
        {
            InitializeComponent();
            LoadInfo(MANV);
            this.MANV = MANV;
            this.chucnang = "update";
            this.BackColor = Color.White;
        }
        public Personal_Information_Form(string MANV)
        {
            InitializeComponent();
            LoadInfo(MANV);
            this.MANV = MANV;
            this.chucnang = "view";
            this.BackColor = Color.White;
        }
        public Personal_Information_Form()
        {
            InitializeComponent();
            this.BackColor = Color.White;
            this.chucnang = "add";
        }

        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-SDNF56S\SQLEXPRESS;Initial Catalog=info_nhanvien;Integrated Security=True");
        private void Personal_Information_Form_Load(object sender, EventArgs e)
        {
         
        }
        private void btnExportFile_Click(object sender, EventArgs e)
        {

        }
        private void LoadInfo(string MANV)
        {
            connection.Open();
            SqlDataAdapter ada1 = new SqlDataAdapter("select * from NHANVIEN where MANV = '" + MANV + "'", connection);
            DataTable table = new DataTable();
            ada1.Fill(table);
            connection.Close();
            DataRow row = table.Rows[0];
            txtHoTen.Text = row["HOTEN"].ToString(); 
            txtMANV.Text = row["MANV"].ToString();
            txtSoDienThoai.Text = row["SODIENTHOAI"].ToString();
            txtCMND.Text = row["CMND"].ToString();
            txtDiaChi.Text = row["DIACHI"].ToString();
            txtLinkPicture.Text = row["PICTURELINK"].ToString();
            pictureNhanvien.ImageLocation = txtLinkPicture.Text;

            dateTimePickerNgaySinh.Text = row["NGAYSINH"].ToString();
            //MessageBox.Show(row["NGAYSINH"].ToString());
            if (row["GIOITINH"].ToString() == "Nam")
            {
                rdbNam.Checked = true;
                rdbNu.Checked = false;
                rdbChuaXacDinh.Checked = false;
            }
            else if (row["GIOITINH"].ToString() == "Nữ")
            {
                rdbNam.Checked = false;
                rdbNu.Checked = true;
                rdbChuaXacDinh.Checked = false;
            }
            else
            {
                rdbNam.Checked = false;
                rdbNu.Checked = false;
                rdbChuaXacDinh.Checked = true;
            }
            txtQueQuan.Text = row["QUEQUAN"].ToString(); 
            dateTimePickerNgayVaolam.Text = row["NGAYVL"].ToString();
            txtChucVu.Text = row["CHUCVU"].ToString();
            txtEmail.Text = row["EMAIL"].ToString();

            //txtHoTen.Enabled = false;
            //txtMANV.Enabled = false;
            //txtSoDienThoai.Enabled = false;
            //txtQueQuan.Enabled = false;
            //txtChucVu.Enabled = false;
            //txtQueQuan.Enabled = false;
            //dateTimePickerNgaySinh.Enabled = false;
            //dateTimePickerNgayVaolam.Enabled = false;
            //rdbChuaXacDinh.Enabled = false;
            //rdbNam.Enabled = false;
            //rdbNu.Enabled = false;
            //btnPicture.Enabled = false;


            //if (LOAINV == "employee")
            //{
            //    this.Controls.Remove(btnPicture);
            //    this.Controls.Remove(btnLuu);
            //    this.Controls.Remove(btnHuy);


            //}
            //else
            //{
            //    this.Controls.Remove(btnThayDoiMatKhau);
            //    this.Controls.Remove(btnLogOut);
            //}
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtHoTen.Text == "")
            {
                txtHoTen.Focus();
                MessageBox.Show("Bạn chưa nhập họ tên", "", MessageBoxButtons.OK);
            }
            else if (txtMANV.Text == "")
            {
                txtMANV.Focus();
                MessageBox.Show("Bạn chưa nhập MANV", "", MessageBoxButtons.OK);
            }
            else if (txtChucVu.Text == "")
            {
                txtChucVu.Focus();
                MessageBox.Show("Bạn chưa nhập chức vụ", "", MessageBoxButtons.OK);
            }
            else if (txtCMND.Text == "")
            {
                txtChucVu.Focus();
                MessageBox.Show("Bạn chưa nhập chức vụ", "", MessageBoxButtons.OK);
            }
            else if (txtSoDienThoai.Text == "")
            {
                txtSoDienThoai.Focus();
                MessageBox.Show("Bạn chưa nhập số điện thoại", "", MessageBoxButtons.OK);
            }
            else if (txtEmail.Text == "")
            {
                txtEmail.Focus();
                MessageBox.Show("Bạn chưa nhập email", "", MessageBoxButtons.OK);
            }
            else
            {
                #region Lưu thông tin vào database

                string CMND = txtCMND.Text;
                string Name = txtHoTen.Text;
                string MANV = txtMANV.Text;
                string DienThoai = txtSoDienThoai.Text;
                string NgaySinh = dateTimePickerNgaySinh.Text;
                string GioiTinh;
                string DiaChi = txtDiaChi.Text;
                string QueQuan = txtQueQuan.Text;
                string NgayVaoLam = dateTimePickerNgayVaolam.Text;
                string ChucVu = txtChucVu.Text;
                string Email = txtEmail.Text;
                string PICTURELINK = txtLinkPicture.Text;


                if (rdbNam.Checked == true)
                {
                    GioiTinh = "Nam";
                }
                else if (rdbNu.Checked == true)
                {
                    GioiTinh = "Nữ";
                }
                else
                {
                    GioiTinh = "Chưa xác định";
                }

                string sql;

                if (chucnang == "add")
                {
                    sql = "insert into NHANVIEN values('" +
                    MANV + "', N'" +
                    Name + "', '" +
                    CMND + "', '" +
                    DienThoai + "', N'" +
                    NgaySinh + "', N'" +
                    GioiTinh + "', N'" +
                    DiaChi + "', N'" +
                    QueQuan + "', '" +
                    NgayVaoLam + "', N'" +
                    ChucVu + "', '" +
                    Email + "', '" + 
                    PICTURELINK +"')";
                }
                else
                {
                    sql = "update sinhvien set Name = N'" + Name +
                    "', SODIENTHOAI = '" + DienThoai +
                    "', NgaySinh = '" + NgaySinh +
                    "', GioiTinh = N'" + GioiTinh +
                    "',  Quequan = N'" + QueQuan +
                    "', NGAYVL = '" + NgayVaoLam +
                    "', ChucVu = N'" + ChucVu +
                    "', Email = '" + Email +
                    "', Picturelink = '" + PICTURELINK +
                    "' where MAVV = '" + MANV + "'";
                }
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.CommandText = sql;
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Lưu thành công!!");
                this.Close();



                txtHoTen.Enabled = false;
                txtMANV.Enabled = false;
                txtSoDienThoai.Enabled = false;
                txtQueQuan.Enabled = false;
                txtChucVu.Enabled = false;
                txtQueQuan.Enabled = false;
                dateTimePickerNgaySinh.Enabled = false;
                dateTimePickerNgayVaolam.Enabled = false;
                rdbChuaXacDinh.Enabled = false;
                rdbNam.Enabled = false;
                rdbNu.Enabled = false;
                btnPicture.Enabled = false;


                #endregion

            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(OpenMainForm));
            t.Start();
            this.Close();
        }

     

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(OpenLoginForm));
            t.Start();
            this.Close();
        }
        public static void OpenLoginForm()
        {
            System.Windows.Forms.Application.Run(new Login());
        }
        public static void OpenMainForm()
        {
            System.Windows.Forms.Application.Run(new Main());
        }

        private void btnPicture_Click(object sender, EventArgs e)
        {
            //OpenFileDialog openFileDialog = new OpenFileDialog();
            //if (openFileDialog.ShowDialog() == DialogResult.OK)
            //{
            //    txtLinkPicture.Text = openFileDialog.FileName;
            //}
            //pictureNhanvien.Image = Image.FromFile(txtLinkPicture.Text)

            OpenFileDialog openFileDialog = new OpenFileDialog();

            //pictureNhanvien.ImageLocation = openFileDialog.FileName;
            openFileDialog.ShowDialog();
            pictureNhanvien.ImageLocation = openFileDialog.FileName;
            txtLinkPicture.Text = pictureNhanvien.ImageLocation.ToString();

            string sql = "update NHANVIEN set PICTURELINK = '" + pictureNhanvien.ImageLocation.ToString() + "' where MANV = '" + MANV +"'";
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sql;
            command.ExecuteNonQuery();

            connection.Close();
        }

        private void btnXuatPDF_Click(object sender, EventArgs e)
        {
            PrintDialog pd = new PrintDialog();
            PrintDocument doc = new PrintDocument();
            doc.PrintPage += Doc_PrintPage;
            pd.Document = doc;
            if (pd.ShowDialog() == DialogResult.OK)
            {
                doc.Print();
            }
        }
        private void Doc_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.groupBoxThongTinNhanVien.Width - 10, this.groupBoxThongTinNhanVien.Height - 10);
            groupBoxThongTinNhanVien.DrawToBitmap(bm, new System.Drawing.Rectangle(groupBoxThongTinNhanVien.Left + 10, groupBoxThongTinNhanVien.Top + 10, this.groupBoxThongTinNhanVien.Width - 10, this.groupBoxThongTinNhanVien.Height - 10));
            e.Graphics.DrawImage(bm, groupBoxThongTinNhanVien.Left, groupBoxThongTinNhanVien.Top);
        }

        private void btnSua_Click(object sender, EventArgs e)
        { 
        }


        private void rdbNam_Click(object sender, EventArgs e)
        {
            rdbNam.Checked = true;
            rdbNu.Checked = false;
            rdbChuaXacDinh.Checked = false;
        }
        private void rdbNu_Click(object sender, EventArgs e)
        {
            rdbNam.Checked = false;
            rdbNu.Checked = true;
            rdbChuaXacDinh.Checked = false;
        }
        private void rdbChuaXacDinh_Click(object sender, EventArgs e)
        {
            rdbNam.Checked = false;
            rdbNu.Checked = false;
            rdbChuaXacDinh.Checked = true;
        }
    }
}
