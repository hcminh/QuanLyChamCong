using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            showMainForm();
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
        
        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
