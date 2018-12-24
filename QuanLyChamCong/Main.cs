using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.IO;
using OfficeOpenXml;
using System.Windows.Forms;

namespace QuanLyChamCong
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        // khợi tạo biến lưu trữ mode
        string mode = "info";
        //đối tượng được chọn
        string code_point = "";
        List<Employee> employees = new List<Employee>();
        //khởi tạo loal host
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-SDNF56S\SQLEXPRESS;Initial Catalog=info_nhanvien;Integrated Security=True");
        //load data vào datagrid
        private void Load_Data(SqlConnection con)
        {
            con.Open();
            SqlDataAdapter ada1 = new SqlDataAdapter(
                "select HOTEN as 'Họ tên'," +
                " MANV as 'Mã nhân viên', " +
                "SODIENTHOAI as 'Số điện thoại', " +
                "CHUCVU as 'Chức vụ', " +
                "GIOITINH as 'Giới tính', " +
                "NGAYSINH as 'Ngày sinh', " +
                "Email " +
                "from NHANVIEN",
                con);
            System.Data.DataTable table = new System.Data.DataTable();
            ada1.Fill(table);
            dt_listNV.DataSource = table;
            con.Close();
        }
        //load data ra 1 list nhana vien
        private void loadDataToList()
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("select * from NHANVIEN", connection);
                using (IDataReader dr = cmd.ExecuteReader())
                    while (dr.Read())
                    {
                        employees.Add(new Employee(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString(), dr[9].ToString(), dr[10].ToString()));
                    }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        // đóng tất cả các tiện ích
        private void closeAllUtility()
        {
            btn_add.Visible = false;
            btn_edit.Visible = false;
            btn_delete.Visible = false;
            tb_searchCode.Visible = false;
            btn_search.Visible = false;
            btn_sprintInfo.Visible = false;
            btn_sprintList.Visible = false;
        } 
        // bật tiện ích quản lý
        private void openManageUtility()
        {
            btn_add.Visible = true;
            btn_edit.Visible = true;
            btn_delete.Visible = true;
        }
        // bật tiện ích kiểm tra
        private void openCheckUtility()
        {
            tb_searchCode.Visible = true;
            btn_search.Visible = true;
        }
        // bật tiện ích in
        private void openSprintUtility()
        {
            btn_sprintInfo.Visible = true;
            btn_sprintList.Visible = true;
        }
        // xử lý nút Quản Lí
        private void btn_manage_Click(object sender, EventArgs e)
        {
            closeAllUtility();
            openManageUtility();
        }
        // xử lý nút Kiểm Tra
        private void btn_check_Click(object sender, EventArgs e)
        {
            closeAllUtility();
            openCheckUtility();
        }
        // xử lý nút In
        private void btn_sprint_Click(object sender, EventArgs e)
        {
            closeAllUtility();
            openSprintUtility();
        }
        //xử lý nút Thêm
        private void btn_add_Click(object sender, EventArgs e)
        {
            closeAllUtility();
            Form1 form1 = new Form1("ADD");
            form1.Show();
        }
        //xử lý nút Sửa
        private void btn_edit_Click(object sender, EventArgs e)
        {
            closeAllUtility();
            Form1 form1 = new Form1("MODIFY", code_point);
            form1.Show();

        }
        //xử lý nút Xóa
        private void btn_delete_Click(object sender, EventArgs e)
        {
            closeAllUtility();
            DialogResult dialog = MessageBox.Show("Xóa vĩnh viễn nhân viên này!?", "Message", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {

                connection.Open();
                int rowIndex = dt_listNV.CurrentCell.RowIndex;

                SqlCommand command = connection.CreateCommand();
                string text = dt_listNV.Rows[rowIndex].Cells["Mã nhân viên"].Value.ToString();
                command.CommandText = "Delete from NHANVIEN where MANV = '" + text + "'";
                int Result = command.ExecuteNonQuery();
                connection.Close();


                if (Result > 0)
                {
                    dt_listNV.Rows.RemoveAt(rowIndex);
                    MessageBox.Show("Xóa thành công");
                }
            }
            else
            {
                //
            }
        }
        //xử lý nút Thông Tin
        private void btn_info_Click(object sender, EventArgs e)
        {
            closeAllUtility();
            Personal_Info personal_Info = new Personal_Info(tb_searchCode.Text);
            personal_Info.Show();
        }
        //xử lý nút In Thông Tin
        private void btn_sprintInfo_Click(object sender, EventArgs e)
        {
            closeAllUtility();
        }

        // gửi mail cần sử lý với sql
        
        //xử lý nút Gửi mail
        private void btn_mail_Click(object sender, EventArgs e)
        {
            SendingMail f_mail = new SendingMail();
            f_mail.Show();
            closeAllUtility();
        }
        //xử lý nút In Danh Sách
        private void btn_sprintList_Click(object sender, EventArgs e)
        {
            closeAllUtility();
            try
            {
                var dia = new System.Windows.Forms.SaveFileDialog();
                dia.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                dia.Filter = "Excel Worksheets (.xlsx)|.xlsx|xls file (.xls)|.xls|All files (.)|*.*";
                if (dia.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                {
                    System.Data.DataTable data = (System.Data.DataTable)dt_listNV.DataSource;// use the DataSource of the DataGridView here
                    dt_listNV.DataSource = data;

                    var excel = new OfficeOpenXml.ExcelPackage();
                    var ws = excel.Workbook.Worksheets.Add("worksheet-DANH SACH NHAN VIEN");
                    // you can also use LoadFromCollection with an IEnumerable<SomeType>
                    ws.Cells["A1"].LoadFromDataTable(data, true, OfficeOpenXml.Table.TableStyles.Light1);
                    ws.Cells[ws.Dimension.Address.ToString()].AutoFitColumns();

                    using (var file = File.Create(dia.FileName))
                        excel.SaveAs(file);
                    MessageBox.Show("Xuất tập tin excel thành công!!");
                }
            }
            catch
            {
                MessageBox.Show("Lỗi truy xuất thông tin!!");
            }
            
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Load_Data(connection);
            loadDataToList();
        }

        private void btn_addPosition_Click(object sender, EventArgs e)
        {
            Position_Manage position_Manage = new Position_Manage();
            position_Manage.Show();
        }

        private void dt_listNV_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Employee employee = new Employee();
            try
            {
                DataGridViewCellCollection infos = dt_listNV.CurrentRow.Cells;
                string code = infos[1].Value.ToString();
                code_point = code;
                employee = employees.Find(employ => employ.getCode() == code);
                lb_name.Text = employee.getName();
                lb_position.Text = employee.getPosition();
                lb_code.Text = employee.getCode();
                lb_join.Text = employee.getJoinDate().ToString();
                string dt = (DateTime.Now.Date - DateTime.Parse(employee.getJoinDate()).Date).ToString();
                dt = dt.Substring(0, 3);
                float time = float.Parse(dt) * 24;
                lb_sumTimeJob.Text = time + " giờ";
            }
            catch
            {
                MessageBox.Show("Không thể chọn dòng này!!");
            }
        }

        private void showQuickInfo()
        {
            Employee employee = new Employee();
            employee = employees.Find(employ => employ.getCode() == code_point);
            lb_name.Text = employee.getName();
            lb_position.Text = employee.getPosition();
            lb_code.Text = employee.getCode();
            lb_join.Text = employee.getJoinDate().ToString();
            string dt = (DateTime.Now.Date - DateTime.Parse(employee.getJoinDate()).Date).ToString();
            dt = dt.Substring(0, 3);
            float time = float.Parse(dt) * 24;
            lb_sumTimeJob.Text = time + " giờ";
        }
        private void dt_listNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dt_listNV.Rows[e.RowIndex];
                code_point = row.Cells["Mã nhân viên"].Value.ToString();
                showQuickInfo();
            }
        }
    }
}
