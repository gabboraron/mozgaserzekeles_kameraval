using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using AForge.Imaging.Filters;
using System.Drawing;
using System.Drawing.Imaging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Text.RegularExpressions;
using AForge.Video;
using System.Diagnostics;
using AForge.Video.DirectShow;
using System.Collections;
using System.IO;
using System.Drawing.Imaging;
using System.IO.Ports;
using System.Globalization;
using System.Net;

namespace WebcamApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
                cboCamera.Items.Add(filterInfo.Name);
            cboCamera.SelectedIndex = 0;
            videoCaptureDevice = new VideoCaptureDevice();
        }

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;

        private int dTime = 0;
        private DateTime lastTime;
        private int justStarted = 0;

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (videoCaptureDevice.IsRunning == true)
            {
                videoCaptureDevice.Stop();
            }
            else
            {
                dTime = Convert.ToInt32(time.Text);
                lastTime = DateTime.Now;
                justStarted = 1;

                videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cboCamera.SelectedIndex].MonikerString);

                videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;

                System.Threading.Thread.Sleep(dTime);

                videoCaptureDevice.Start();
            }
        }

        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            if (justStarted == 1)
            {
                justStarted = 0;
                picOld.Image = (Bitmap)eventArgs.Frame.Clone();
            }
            else
            {

                if (DateTime.Now.Second >= lastTime.Second + dTime)
                {
                    picNew.Image = picOld.Image;
                    lastTime = DateTime.Now;
                    Bitmap tmp1 = new Bitmap(picNew.Image); //sometimes buggy here...
                    Bitmap tmp2 = new Bitmap(picOld.Image);
                    compare(tmp1, tmp2);
                }
                picOld.Image = (Bitmap)eventArgs.Frame.Clone();

            }
        }

        private Thread thread2 = null;
        private float inPercentage;

        private void compare(Bitmap picold, Bitmap picnew)
        {
            //Bitmap bm = new Bitmap(280, 110);
            float diff = 0;

            Bitmap img1 = new Bitmap(picold);
            Bitmap img2 = new Bitmap(picnew);

            Bitmap difference = new Bitmap(img1.Width, img1.Height);

            for (int y = 0; y < img1.Height; y++)
                for (int x = 0; x < img1.Width; x++)
                {
                    
                    Color pixel1 = img1.GetPixel(x, y);
                    Color pixel2 = img2.GetPixel(x, y);

                    float tmpDiff = Math.Abs(pixel1.R - pixel2.R);
                    tmpDiff += Math.Abs(pixel1.G - pixel2.G);
                    tmpDiff += Math.Abs(pixel1.B - pixel2.B);

                    diff += tmpDiff;
                    if (tmpDiff > 0)
                        difference.SetPixel(x, y, pixel2);
                }
            

            inPercentage = diff; //100 * (diff / 255) / (img1.Width * img1.Height * 3);

            thread2 = new Thread(new ThreadStart(SetText));
            thread2.Start();
            Thread.Sleep(100);

            picDiff.Image = new Bitmap(difference);
            Console.WriteLine(diff);            
        }

        private delegate void SafeCallDelegate(string text);
        private void SetText()
        {
            WriteTextSafe(inPercentage + "%");
        }
        private void WriteTextSafe(string text)
        {
            if (textBoxDifference.InvokeRequired)
            {
                var d = new SafeCallDelegate(WriteTextSafe);
                textBoxDifference.Invoke(d, new object[] { text });
            }
            else
            {
                textBoxDifference.Text = text;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoCaptureDevice.IsRunning == true)
                videoCaptureDevice.Stop();
        }

        private void cboCamera_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {

        }
    }
}