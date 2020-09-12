using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.Face;
using Emgu.CV.CvEnum;

namespace Simple_Facial_Recognition_App
{
    public partial class Form1 : Form
    {
        #region Variables
        private Capture videoCapture = null;
        private Image<Bgr, Byte> currentFrame = null;
        Mat frame = new Mat();
        #endregion
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCapture_Click(object sender, EventArgs e)
        {
            videoCapture = new Capture();
            videoCapture.ImageGrabbed += ProcessFrame;
            videoCapture.Start();
        }
        private void ProcessFrame(object sender, EventArgs e)
        {
            //Step 1: Video Capture 
            videoCapture.Retrieve(frame, 0);
            currentFrame = frame.ToImage<Bgr, Byte>().Resize(picCapture.Width, picCapture.Height, Inter.Cubic);

            //Render the video capture into the Picture Box picCapture
            picCapture.Image = currentFrame.Bitmap;

        }
    }
}
