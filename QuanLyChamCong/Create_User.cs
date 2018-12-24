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
    public partial class Create_User : Form
    {
        public Create_User()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-SDNF56S\SQLEXPRESS;Initial Catalog=info_nhanvien;Integrated Security=True");
        private void btn_return_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //kiểm tra tk đã tồn tại
        private bool isNewUser()
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("select name_user from manage_account where name_user='" + tb_username.Text + "'",connection);
                var result = cmd.ExecuteScalar();
                connection.Close();
                if (result != null)
                {
                    MessageBox.Show("Tài khoản đã tồn tại");
                    return false;

                }
                else return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }
        private void btn_signIn_Click(object sender, EventArgs e)
        {
            if (tb_pass.Text == tb_rePass.Text && isNewUser())
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("insert into manage_account values ('" + tb_username.Text + "', '" + tb_pass.Text + "')", connection);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
                catch
                {
                    MessageBox.Show("Lỗi trong quá trình truy xuất dữ liệu!!");
                }
            }
            else
                MessageBox.Show("Mật khẩu không trùng nhau!!");
            this.Close();
        }
    }
}
