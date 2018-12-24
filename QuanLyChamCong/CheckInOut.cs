using AForge.Video;
using System;
using System.Drawing;
using System.Windows.Forms;
using ZXing;

namespace QuanLyChamCong
{
    public partial class CheckInOut : Form
    {
        public CheckInOut()
        {
            InitializeComponent();
        }
        MJPEGStream stream;

        private void btn_conect_Click(object sender, EventArgs e)
        {
            if (btn_connect.Tag.ToString() == "connect")
            {
                stream = new MJPEGStream(tb_ip.Text);
                stream.NewFrame += stream_NewFrame;
                stream.Start();
                t_render.Enabled = true;
                t_render.Start();
                btn_connect.Text = "Dừng";
                btn_connect.Tag = "disconnect";
            }
            else
            {
                btn_connect.Text = "Kết nối";
                btn_connect.Tag = "connect";
                t_render.Stop();
                stream.Stop();
            }
        }
        public void stream_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bmp = (Bitmap)eventArgs.Frame.Clone();
            pic_scanCode.Image = bmp;
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            string code = tb_code.Text;
        }

        private void t_render_Tick(object sender, EventArgs e)
        {
            Bitmap img = (Bitmap)pic_scanCode.Image;
            if (img != null)
            {
                ZXing.BarcodeReader Reader = new ZXing.BarcodeReader();
                Result result = Reader.Decode(img);
                try
                {
                    string decoded = result.ToString().Trim();
                    tb_code.Clear();
                    tb_code.Text = decoded;

                    img.Dispose();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message + "");
                }

            }
        }

    }
}
