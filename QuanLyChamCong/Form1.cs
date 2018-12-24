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
    public partial class Form1 : Form
    {
        string method = "ADD";
        bool isNullCode = true;
        bool isNullId = true;
        bool isNullName = true;
        bool isNullMail = true;

        //đối tượng được trỏ
        string code;
        public Form1()
        {
            InitializeComponent();
        }

        public Form1(string method)
        {
            InitializeComponent();
            this.method = method;
        }
        public Form1(string method, string code)
        {
            InitializeComponent();
            this.method = method;
            this.code = code;
        }
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-SDNF56S\SQLEXPRESS;Initial Catalog=info_nhanvien;Integrated Security=True");
        //load position
        private void loadPositon()
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("select TENCHUCVU from CHUCVU", connection);
                using (IDataReader dr = cmd.ExecuteReader())
                    while (dr.Read())
                    {
                        cb_position.Items.Add(dr[0].ToString());
                    }
                connection.Close();
            }
            catch
            {
                MessageBox.Show("Lỗi khi truy xuất dữ liệu!!");
                this.Close();
            }
        }

        private void lb_birth_Click(object sender, EventArgs e)
        {

        }

        private void tb_name_TextChanged(object sender, EventArgs e)
        {
            tb_name.Text = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(this.tb_name.Text);
            tb_name.Select(tb_name.Text.Length, 0);
            lb_errName.Visible = false;
        }
        
        private void tb_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                lb_errPhone.Visible = true;
            }
            else
            {
                lb_errPhone.Visible = false;
            }
        }

        private void tb_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private bool isReadyData()
        {
            if (tb_name.Text == "")
            {
                isNullName = true;
                return false;
            }
            else
                isNullName = false;
            if (tb_id.Text == "")
            {
                isNullId = true;
                return false;
            }
            else
                isNullId = false;
            if (tb_code.Text == "")
            {
                isNullCode = true;
                return false;
            }
            else
                isNullCode = false;
            if (tb_mail.Text == "")
            {
                isNullMail = true;
                return false;
            }
            else
                isNullMail = false;
            return true;
        } 

        private void saveData_methodADD() {
            try
            {
                string birth = dtp_birth.Value.Day.ToString() + "/" + dtp_birth.Value.Month.ToString() + "/" + dtp_birth.Value.Year.ToString();
                string join = dtp_join.Value.Day.ToString() + "/" + dtp_join.Value.Month.ToString() + "/" + dtp_join.Value.Year.ToString();
                connection.Open();
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO NHANVIEN VALUES('" +
                    tb_code.Text + "', N'" +
                    tb_name.Text + "', '" +
                    tb_id.Text + "', '" +
                    tb_phone.Text + "', N'" +
                    birth + "', N'" +
                    cb_gender.Text + "', N'" +
                    tb_address.Text + "', N'" +
                    tb_country.Text + "', '" +
                    join + "', N'" +
                    cb_position.Text + "', '" +
                    tb_mail.Text + "', '" +
                    tb_link.Text + "')",
                    connection);
                cmd.ExecuteReader();
                connection.Close();
                MessageBox.Show("Thêm thông tin thành công!!");
                resetDataTextBox();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        } 
        //load data từ code
        private void loatData()
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("select * from NHANVIEN where MANV='" + code + "'", connection);
                using (IDataReader dr = cmd.ExecuteReader())
                    while (dr.Read())
                    {
                        tb_code.Text = dr[0].ToString();
                        tb_name.Text = dr[1].ToString();
                        tb_id.Text = dr[2].ToString();
                        tb_phone.Text = dr[3].ToString();
                        dtp_birth.Value = DateTime.Parse(dr[4].ToString());
                        cb_gender.Text = dr[5].ToString();
                        tb_address.Text = dr[6].ToString();
                        tb_country.Text = dr[7].ToString();
                        dtp_join.Value = DateTime.Parse(dr[8].ToString());
                        cb_position.Text = dr[9].ToString();
                        tb_mail.Text = dr[10].ToString();
                        tb_link.Text = dr[11].ToString();
                    }
                connection.Close();
            }
            catch
            {
                MessageBox.Show("Lỗi trong quá trình truy xuất dữ liệu!!");
                this.Close();
            }
        }
        private void saveData_methodModify() {
            try
            {
                string birth = dtp_birth.Value.Day.ToString() + "/" + dtp_birth.Value.Month.ToString() + "/" + dtp_birth.Value.Year.ToString();
                string join = dtp_join.Value.Day.ToString() + "/" + dtp_join.Value.Month.ToString() + "/" + dtp_join.Value.Year.ToString();
                connection.Open();
                SqlCommand cmd = new SqlCommand(
                    "UPDATE NHANVIEN set HOTEN=" +
                    "N'" + tb_name.Text + "', CMND='" +
                    tb_id.Text + "', SODIENTHOAI='" +
                    tb_phone.Text + "', NGAYSINH='" +
                    birth + "',GIOITINH= N'" +
                    cb_gender.Text + "',DIACHI= N'" +
                    tb_address.Text + "',QUEQUAN= N'" +
                    tb_country.Text + "',NGAYVL= '" +
                    join + "',CHUCVU= N'" +
                    cb_position.Text + "',EMAIL= '" +
                    tb_mail.Text + "',PICTURELINK= '" +
                    tb_link.Text + "' where MANV='"+code+"'",
                    connection);
                cmd.ExecuteReader();
                connection.Close();
                MessageBox.Show("Lưu thông tin thành công!!");
                resetDataTextBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        } //chua lam
        private void resetDataTextBox()
        {
            //reset all textbox in new activities
            tb_name.Text = "";
            tb_id.Text = "";
            tb_code.Text = "";
            tb_phone.Text = "";
            tb_address.Text = "";
            tb_mail.Text = "";
            tb_country.Visible = false;
            cb_gender.SelectedIndex = 0;
            cb_position.SelectedIndex = 0;
            dtp_birth.Value = DateTime.Now;
            dtp_join.Value = DateTime.Now;
        }
        

        private void button_reset_Click(object sender, EventArgs e)
        {
            resetDataTextBox();
        }
        

        private void button_save_Click(object sender, EventArgs e)
        {
            if (isReadyData())
            {
                if (method == "ADD")
                {
                    // save data
                    saveData_methodADD();
                    resetDataTextBox();
                }
                else if (method == "MODIFY")
                {
                    // save data
                    saveData_methodModify();
                }
            }
            else
            {
                MessageBox.Show("Nhập Thiếu Thông Tin");
                if (isNullName)
                {
                    lb_errName.Visible = true;
                    tb_name.Focus();
                }
                else if (isNullId)
                {
                    lb_errId.Visible = true;
                    tb_id.Focus();
                }
                else if (isNullCode)
                {
                    lb_errCode.Visible = true;
                    tb_code.Focus();
                }
                else if (isNullMail)
                {
                    lb_errMail.Visible = true;
                    tb_mail.Focus();
                }
            }
        }

        private void group_info_Enter(object sender, EventArgs e)
        {

        }

        private void btn_browers_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            //pictureNhanvien.ImageLocation = openFileDialog.FileName;
            openFileDialog.ShowDialog();
            pic_pro.ImageLocation = openFileDialog.FileName;
            tb_link.Text = pic_pro.ImageLocation.ToString();

            string sql = "update NHANVIEN set PICTURELINK = '" + pic_pro.ImageLocation.ToString() + "' where MANV = '" + tb_code.Text + "'";
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sql;
            command.ExecuteNonQuery();

            connection.Close();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadPositon();
            if (method == "ADD")
            {
                btn_save.Tag = "ADD";
            }
            else if (method == "MODIFY")
            {
                loatData();
                btn_save.Tag = "MODIFY";
                tb_code.Enabled = false;
            }
        }
    }
}
