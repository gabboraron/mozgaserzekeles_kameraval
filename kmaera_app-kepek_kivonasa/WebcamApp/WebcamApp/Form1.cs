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

namespace WebcamApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

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
                Task t = Task.Run(() =>
                {
                    videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
                });


                if (!t.Wait(TimeSpan.FromMilliseconds(dTime)))
                    Console.WriteLine("Várakozás...");

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
                    Bitmap tmp1 = new Bitmap (picNew.Image);
                    Bitmap tmp2 = new Bitmap (picOld.Image);
                    Osszehasonlitas(tmp1, tmp2);
                }
                picOld.Image = (Bitmap)eventArgs.Frame.Clone();

            }
        }

        private void Osszehasonlitas(Bitmap picold, Bitmap picnew)
        {
        //    Bitmap picnew = (Bitmap)picNew.Image;
        //    Bitmap picold = (Bitmap)picOld.Image;

            int wid = picnew.Width;
            int hgt = picnew.Height;

            int[,] diffs = new int[wid, hgt];
            int max_diff = 0;
            for (int x = 0; x < wid; x++)
            {
                for (int y = 0; y < hgt; y++)
                {
                    // Calculate the pixels' difference.
                    Color color1 = picnew.GetPixel(x, y);
                    Color color2 = picold.GetPixel(x, y);
                    diffs[x, y] = (int)(
                        Math.Abs(color1.R - color2.R) +
                        Math.Abs(color1.G - color2.G) +
                        Math.Abs(color1.B - color2.B));
                    if (diffs[x, y] > max_diff)
                        max_diff = diffs[x, y];
                }
            }
            //max_diff = 255;

            // Create the difference image.
            Bitmap bm3 = new Bitmap(wid, hgt);
            for (int x = 0; x < wid; x++)
            {
                for (int y = 0; y < hgt; y++)
                {
                    int clr = 255 - (int)(255.0 / max_diff * diffs[x, y]);
                    try
                    { bm3.SetPixel(x, y, Color.FromArgb(clr, clr, clr)); }
                    catch { }
                }
            }

            // Display the result.
            picDiff.Image = bm3;
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
    }
}
