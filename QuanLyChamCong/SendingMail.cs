using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace QuanLyChamCong
{
    public partial class SendingMail : Form
    {
        public SendingMail()
        {
            InitializeComponent();
        }
        //tạo kết nối
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-SDNF56S\SQLEXPRESS;Initial Catalog=info_nhanvien;Integrated Security=True");
        //tạo danh sách nhân viên
        List<Employee> employees;
        //tạo kết nối gửi mail
        MailMessage message = new MailMessage();
        SmtpClient smtp = new SmtpClient();
        //setup mail
        private void configMail(string adress, string pass)
        {
            try
            {
                message.From = new MailAddress(adress);
                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                //phải khai báo Credentials cuối cùng thì mới chạy dc
                smtp.Credentials = new NetworkCredential(adress, pass);
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                message.Subject = tb_subject.Text;
                message.Body = tb_content.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi khởi tạo thư điện tử, kiểm tra mạng và thử lại!!");
            }
        }
        private void loadMail(SqlConnection con)
        {
            try
            {
                employees = new List<Employee>();
                con.Open();
                SqlCommand cmd = new SqlCommand("select " + "MaNV, " + "Mail" + " from NhanVien where ViTri=" + "'" + cb_object.Text + "'", con);
                using (IDataReader dr = cmd.ExecuteReader())
                    while (dr.Read())
                    {
                        employees.Add(new Employee(dr[0].ToString(), dr[1].ToString()));
                    }
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi khi truy xuất dữ liệu");
            }
        }
        //Kiểm tra thông tin hợp lệ để gửi
        private bool isReady()
        {
            if(tb_subject.Text == "")
            {
                lb_errSubject.Visible = true;
                tb_subject.Focus();
                return false;
            }
            else if (tb_content.Text == "")
            {
                lb_errContent.Visible = true;
                tb_content.Focus();
                return false;
            }
            else if (cb_object.Text == "")
            {
                lb_errObject.Visible = true;
                cb_object.Focus();
                return false;
            }
            return true;
        }
        //xóa text box
        private void clearTextBox()
        {
            tb_content.Clear();
            tb_subject.Clear();
            cb_object.Text = "";
        }
        //Gửi thư theo từng đối tượng
        private void sendingGmail()
        {
            loadMailForPositon(cb_object.Text);
            //cài phương thức gửi mail
            configMail("company.lttq@gmail.com", "MyCompany123");
            string codeOfErrMails = "";
            foreach (Employee employee in employees)
            {
                try
                {
                    message.To.Add(new MailAddress(employee.getMail()));
                }
                catch (Exception ex)
                {
                    codeOfErrMails += employee.getCode() + " ";
                }
            }
            try
            {
                smtp.Send(message);
                if(codeOfErrMails != "")
                    MessageBox.Show("Lỗi trong quá trình gửi thư điện tử đến nhân viên có mã: " + codeOfErrMails);
                else
                {
                    MessageBox.Show("Đã gửi thư thành công!!");
                    clearTextBox();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi trong quá trình gửi thư điện tử");
            }
        }

        //lấy những nhân viên hợp với yêu cầu
        private void loadMailForPositon(string position)
        {
            try
            {
                connection.Open();
                employees = new List<Employee>();
                SqlCommand cmd = new SqlCommand("select MANV, EMAIL from NHANVIEN where CHUCVU=" + "N'" + position + "'", connection);
                using (IDataReader dr = cmd.ExecuteReader())
                    while (dr.Read())
                    {
                        employees.Add(new Employee(dr[0].ToString(), dr[1].ToString()));
                    }
                connection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btn_send_Click(object sender, EventArgs e)
        {
            if (isReady())
            {

                sendingGmail();
            }
            else
                MessageBox.Show("Nhập thiếu thông tin, mời nhập lại!!!");
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // tắt các label error khi nhập
        private void tb_subject_TextChanged(object sender, EventArgs e)
        {
            lb_errSubject.Visible = false;
        }

        private void tb_content_TextChanged(object sender, EventArgs e)
        {
            lb_errContent.Visible = false;
        }

        private void cb_object_SelectedIndexChanged(object sender, EventArgs e)
        {
            lb_errObject.Visible = false;
        }

        private void SendingMail_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("select TENCHUCVU from CHUCVU", connection);
                using (IDataReader dr = cmd.ExecuteReader())
                    while (dr.Read())
                    {
                        cb_object.Items.Add(dr[0].ToString());
                    }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
