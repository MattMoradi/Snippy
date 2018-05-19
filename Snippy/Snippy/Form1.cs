using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Snippy
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
       

      private void btnCapture_Click(object sender, EventArgs e)
        {
            Bitmap btm = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            Graphics grph = Graphics.FromImage(btm);
            grph.CopyFromScreen(0, 0, 0, 0, btm.Size);
            CaptureScrn.Image = btm;
        }

        void Capture()
        {
            while (true)
            {
                Bitmap btm = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
                Graphics grph = Graphics.FromImage(btm);
                grph.CopyFromScreen(0, 0, 0, 0, btm.Size);
                CaptureScrn.Image = btm;
                Thread.Sleep(1000);
            }
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(Capture);
            t.Start();
        }

        private void btnStopRecord_Click(object sender, EventArgs e)
        {
            try
            {
                Thread t = new Thread(Capture);
               
            }
            catch
            {
                //
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
