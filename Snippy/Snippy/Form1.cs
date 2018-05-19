using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snippy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
    }
}
