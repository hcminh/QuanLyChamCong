using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace QuanLyChamCong
{
    public partial class Personal_Info : Form
    {
        public Personal_Info()
        {
            InitializeComponent();
        }

        public Personal_Info(string code)
        {
            InitializeComponent();
            this.code = code;
        }
        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        string code;
        //khởi tạo loal host
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-SDNF56S\SQLEXPRESS;Initial Catalog=info_nhanvien;Integrated Security=True");

        private void btn_sprint_Click(object sender, EventArgs e)
        {
            PrintDialog pd = new PrintDialog();
            PrintDocument doc = new PrintDocument();
            doc.PrintPage += Doc_PrintPage;
            pd.Document = doc;
            if (pd.ShowDialog() == DialogResult.OK)
            {
                doc.Print();
            }
            MessageBox.Show("In thành công!!");
        }
        private void Doc_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.panel1.Width, this.panel1.Height);
            panel1.DrawToBitmap(bm, new System.Drawing.Rectangle(panel1.Left, panel1.Top, this.panel1.Width, this.panel1.Height));
            e.Graphics.DrawImage(bm, panel1.Left, panel1.Top);
        }

        private void Personal_Info_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            Employee employee = new Employee();
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("select * from NHANVIEN where MANV=" + "'" + code + "'", connection);
                using (IDataReader dr = cmd.ExecuteReader())
                    while (dr.Read())
                    {
                        lb_code.Text = dr[0].ToString();
                        lb_name.Text = dr[1].ToString();
                        lb_id.Text = dr[2].ToString();
                        lb_phone.Text = dr[3].ToString();
                        lb_birth.Text = dr[4].ToString();
                        lb_gender.Text = dr[5].ToString();
                        lb_address.Text = dr[6].ToString();
                        lb_country.Text = dr[7].ToString();
                        lb_join.Text = dr[8].ToString();
                        lb_position.Text = dr[9].ToString();
                        lb_mail.Text = dr[10].ToString();
                        pic_em.ImageLocation = dr[11].ToString();
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
