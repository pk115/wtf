using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
namespace WTF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // --- โค้ดเดิมของคุณ ---
            label1.Text = "lol";
            this.ShowInTaskbar = false;
            Startup.SetStartup(Application.ProductName, Application.ExecutablePath.ToString(), true);
            //timer1.Start();

            // -----------------------------------------------------------------
            // --- โค้ดสำหรับตั้งค่า Background Image (jpg หรือ png) ---
            // -----------------------------------------------------------------

            string startupPath = Application.StartupPath;


            string jpgPath = Path.Combine(startupPath, "image.jpg");

            if (File.Exists(jpgPath))
            {
                try
                {
                    this.BackgroundImage = Image.FromFile(jpgPath);
                    this.BackgroundImageLayout = ImageLayout.Stretch; // หรือ Zoom, Center, Tile
                    return; // พบไฟล์ .jpg แล้ว ออกจากฟังก์ชัน
                }
                catch (Exception ex)
                {
          
                }
            }

            string pngPath = Path.Combine(startupPath, "image.png");

            if (File.Exists(pngPath))
            {
                try
                {
                    this.BackgroundImage = Image.FromFile(pngPath);
                    this.BackgroundImageLayout = ImageLayout.Stretch; // หรือ Zoom, Center, Tile
                    return; 
                }
                catch (Exception ex)
                {
; 
                }
            }

        }

        public void random()
        { 
        Random rnd = new Random();
        for (int i = 0; i < 2; i++)
        {
            //Screen.PrimaryScreen.Bounds.Width;
            //Screen.PrimaryScreen.Bounds.Height;
            int w = rnd.Next(1, Screen.PrimaryScreen.Bounds.Width-100);
            int h = rnd.Next(1, Screen.PrimaryScreen.Bounds.Height-100);
            this.Location = new Point(w, h);
            Thread.Sleep(5000);
            i = 0;
        }
        
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            
            random();
            timer1.Stop();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Random rnd = new Random();
            int w = rnd.Next(1, Screen.PrimaryScreen.Bounds.Width - 100);
            int h = rnd.Next(1, Screen.PrimaryScreen.Bounds.Height - 100);
            this.Location = new Point(w, h);
        }

   
    }
}
