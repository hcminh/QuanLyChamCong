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
    public partial class Position_Manage : Form
    {
        public Position_Manage()
        {
            InitializeComponent();
        }
        //khởi tạo loal host
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-SDNF56S\SQLEXPRESS;Initial Catalog=info_nhanvien;Integrated Security=True");
        //tạo danh sách chức vụ
        List<Position> positions = new List<Position>();
        //load list position
        private void loadPositon()
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("select TENCHUCVU, HSLUONG from CHUCVU", connection);
                using (IDataReader dr = cmd.ExecuteReader())
                    while (dr.Read())
                    {
                        positions.Add(new Position(dr[0].ToString(), float.Parse(dr[1].ToString())));
                    }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Position_Manage_Load(object sender, EventArgs e)
        {
            loadPositon();
            connection.Open();
            SqlDataAdapter ada1 = new SqlDataAdapter(
                "select TENCHUCVU as 'Vị Trí'," +
                " HSLUONG as 'Hệ Số Lương' " +
                "from CHUCVU",
                connection);
            System.Data.DataTable table = new System.Data.DataTable();
            ada1.Fill(table);
            dt_positon.DataSource = table;
            connection.Close();
            foreach (Position position in positions)
            {
                cb_position.Items.Add(position.getName());
                cb_positonDelete.Items.Add(position.getName());
            }
        }

        private void refeshData()
        {
            connection.Open();
            SqlDataAdapter ada1 = new SqlDataAdapter(
                "select TENCHUCVU as 'Vị Trí'," +
                " HSLUONG as 'Hệ Số Lương' " +
                "from CHUCVU",
                connection);
            System.Data.DataTable table = new System.Data.DataTable();
            ada1.Fill(table);
            dt_positon.DataSource = table;
            connection.Close();
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            bool checkErr = true;
            string getPosition = tb_position.Text;
            foreach(Position positon in positions)
            {
                if(getPosition.ToUpper() == positon.getName().ToUpper())
                {
                    MessageBox.Show("Vị trí đã tồn tại!!");
                    checkErr = false;
                    break;
                }
            }
            if (checkErr)
            {
                positions.Add(new Position(tb_position.Text, float.Parse(tb_salary.Text)));
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO CHUCVU VALUES('" + tb_position.Text + "'," + float.Parse(tb_salary.Text) + ")", connection);
                    cmd.ExecuteReader();
                    connection.Close();
                    refeshData();
                    MessageBox.Show("Thêm thành công!");
                    updateCB_Position();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xảy ra lỗi trong quá trình nhập liệu!! vui lòng thử lại sau");
                }
            }
        }

        private void btn_getSalary_Click(object sender, EventArgs e)
        {
            try
            {
                tb_salaryEdit.Text = positions[positions.FindIndex(position => position.getName().ToUpper() == cb_position.Text.ToUpper())].getSalary().ToString();
            }
            catch
            {
                MessageBox.Show("Vị trí không hợp lệ!!");
            }
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                positions[positions.FindIndex(position => position.getName().ToUpper() == cb_position.Text.ToUpper())].setSalary(float.Parse(tb_salaryEdit.Text));
            }
            catch
            {
                MessageBox.Show("Không tìm thấy vị trí tương ứng!!");
            }
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("UPDATE CHUCVU set HSLUONG=" + float.Parse(tb_salaryEdit.Text) + " WHERE TENCHUCVU=" + "'" + cb_position.Text + "'", connection);
                cmd.ExecuteReader();
                connection.Close();
                refeshData();
                MessageBox.Show("Sửa thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình nhập liệu!! vui lòng thử lại sau");
            }
        }

        private void updateCB_Position()
        {
            cb_position.Text = "";
            cb_positonDelete.Text = "";
            cb_position.Items.Clear();
            cb_positonDelete.Items.Clear();
            foreach (Position item in positions)
            {
                cb_position.Items.Add(item.getName());
                cb_positonDelete.Items.Add(item.getName());
            }
        }
        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Chỉ cho phép xóa vị trí chưa có nhân viên làm!!", "Bạn có chắc chắn muốn xóa?", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {

                connection.Open();
                SqlCommand command = new SqlCommand("select MANV from NHANVIEN where CHUCVU = " +"'" + cb_positonDelete.Text + "'", connection);
                var result = command.ExecuteScalar();
                connection.Close();
                if (result != null)
                    MessageBox.Show("Không thể xóa vị trí đang có nhân viên làm việc!!");
                else
                {
                    try
                    {
                        connection.Open();
                        command.CommandText = "Delete from CHUCVU where TENCHUCVU = '" + cb_positonDelete.Text + "'";
                        result = command.ExecuteReader();
                        connection.Close();
                        //xóa thành phần của list 
                        positions.RemoveAt(positions.FindIndex(position => position.getName().ToUpper() == cb_positonDelete.Text.ToUpper()));
                        MessageBox.Show("Xóa thành công");
                        updateCB_Position();
                    }
                    catch
                    {
                        MessageBox.Show("Lỗi trong quá trình xóa vị trí!! vui lòng thử lại sau!!");
                    }
                }
            }
        }
    }
}
