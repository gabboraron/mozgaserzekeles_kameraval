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
                //lock (picOld)
                //{
                //    picOld.Image = (Bitmap)eventArgs.Frame.Clone();

                //    picOld.Image = (Bitmap)eventArgs.Frame.Clone();
                //    picNew.Image = picOld.Image;
                //    lastTime = DateTime.Now;
                  justStarted = 0;
                picOld.Image = (Bitmap)eventArgs.Frame.Clone();
                //}

            }
            else 
            {
                
                if (DateTime.Now.Second >= lastTime.Second + dTime) 
                {
                    picNew.Image = picOld.Image;
                    lastTime = DateTime.Now;
                }
                picOld.Image = (Bitmap)eventArgs.Frame.Clone();

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
    }
}
