using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyChamCong
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-SDNF56S\SQLEXPRESS;Initial Catalog=info_nhanvien;Integrated Security=True");

        private void showMainForm()
        {
            Main f_main = new Main();
            f_main.FormClosed += new FormClosedEventHandler(main_FormClosed);
            f_main.Show();
            this.Hide();
        }

        private void main_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            //kết nối sql kiểm tra đăng nhập
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("select password_user from manage_account where name_user='"+ tb_username.Text +"'", connection);
                var result = cmd.ExecuteScalar();
                connection.Close();
                if (result != null)
                    showMainForm();
                else MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btn_checkInOut_Click(object sender, EventArgs e)
        {
            CheckInOut f_checkInOut = new CheckInOut();
            f_checkInOut.Show();
            //gọi hàm mở lại form khi form con đóng
            f_checkInOut.FormClosed += new FormClosedEventHandler(checkInOut_FormClosed);
            this.Hide();
        }

        private void checkInOut_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
      

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            if(tb_username.Text == "admin" && tb_password.Text == "admin")
            {
                Create_User create_User = new Create_User();
                create_User.FormClosed += new FormClosedEventHandler(createUserClose);
                this.Hide();
                create_User.Show();
            }
        }

        private void createUserClose(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}
