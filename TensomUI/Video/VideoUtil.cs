using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Video
{
    public static class VideoUtil
    {
        static Mat mat_com = new Mat();
        static  int videoframe_counts;
        static int videoframe_counts_stop;
        static VideoWriter video_writer = null;
        static Size size_frame = new Size(640, 480);
        static int fps = 15;
        static string video_name = " 1";
        private static int videoframe_count;
        static ImageBox imBox1 = null;

        static void capturingVideo(object sender, EventArgs e)
        {
            drawCameras((VideoCapture)sender);
        }


        static void drawCameras(VideoCapture cap)
        {

            cap.Retrieve(mat_com);
            imBox1.Image = findContour( mat_com);
        }
        static Size calcSize(Size size)
        {
            var w = 600;
            var k1 = (double)size.Width / (double)w;
            var w_1 = (int)((double)size.Width / (double)k1);
            var h_1 = (int)((double)size.Height / (double)k1);
            return new Size(w_1, h_1);
        }
        static public Image<Gray, byte> sobel(Image<Gray, byte> im)
        {
            var size_1 = calcSize(im.Size);
            var im_sob = new Image<Gray, byte>(im.Size);
            im.CopyTo(im_sob);
            //CvInvoke.Resize(im, im_sob, size_1);
            var gray_x = im_sob.Sobel(1, 0, 3);
            var gray_y = im_sob.Sobel(0, 1, 3);


            for (int x = 0; x < im_sob.Width; x++)
            {
                for (int y = 0; y < im_sob.Height; y++)
                {
                    var sob = (int)(Math.Abs(gray_x.Data[y, x, 0]) + Math.Abs(gray_y.Data[y, x, 0]));
                    if (sob > 255)
                    {
                        im_sob.Data[y, x, 0] = 255;
                    }
                    else
                    {
                        im_sob.Data[y, x, 0] = (byte)sob;
                    }

                }
            }
            return im_sob;
        }
        static Mat findContour(Mat mat)
        {
            var sob = sobel(mat.ToImage<Gray, Byte>()).Mat;
            //CvInvoke.Threshold(sob, sob, 220, 255,ThresholdType.Binary);
            return sob;
        }
        static void imProcess(Mat mat)
        {

            if (videoframe_counts == 0)
            {
                initWrite(video_name);
                videoframe_counts++;
            }

            if (videoframe_counts > 0 && videoframe_counts < videoframe_counts_stop)
            {
                video_writer?.Write(mat);
                videoframe_counts++;
            }
            else
            {

                videoframe_counts = -1;

            }

        }

        static void initWrite(string name)
        {
            int fcc = VideoWriter.Fourcc('M', 'P', '4', 'V'); //'M', 'J', 'P', 'G'
            int fps = 15;
            video_writer = new VideoWriter(name + ".mp4", fcc, fps, size_frame, true);
        }

        static void startWrite(int count)
        {
            videoframe_counts_stop = count;
            videoframe_counts = 0;
        }

        static private void videoStart_Click(object sender, EventArgs e)
        {
            var contr = (TextBox)sender;
            videoStart(Convert.ToInt32(contr.Text));
        }
        static private void videoStart(int number)
        {
            var capture = new VideoCapture(number);

            //capture.SetCaptureProperty(CapProp.
            capture.Set(CapProp.FrameWidth, size_frame.Width);
            // capture.SetCaptureProperty(CapProp.FrameHeight, cameraSize.Height);
            capture.Set(CapProp.Fps, fps);
            //Console.WriteLine(capture.Get(CapProp.FrameWidth) + " " + capture.Get(CapProp.FrameHeight) + " " + capture.Get(CapProp.Fps));
            fps = (int)capture.Get(CapProp.Fps);
            size_frame.Width = (int)capture.Get(CapProp.FrameWidth);
            size_frame.Height = (int)capture.Get(CapProp.FrameHeight);
            //capture.SetCaptureProperty(CapProp.Contrast, 30);
            capture.ImageGrabbed += capturingVideo;
            capture.Start();
        }

        static public void loadVideo_stereo(string filepath,ImageBox imageBox)
        {
            videoframe_count = 0;
            var capture = new VideoCapture(filepath);
            var all_frames = capture.Get(CapProp.FrameCount);

            while (videoframe_count < all_frames)
            {
                Mat im = new Mat();
                while (!capture.Read(im)) { }
                imageBox.Image = im;
                videoframe_count++;
                GC.Collect();
                Console.WriteLine("loading...      " + videoframe_count + "/" + all_frames);
            }
            Console.WriteLine("complete.");
        }

        static public void loadVideo_stereo_1(string filepath, ImageBox imageBox)
        {
            imBox1 = imageBox;
            videoframe_count = 0;
            var capture = new VideoCapture(filepath);
            var all_frames = capture.Get(CapProp.FrameCount);
            capture.Set(CapProp.PosMsec,100*1000);
            capture.ImageGrabbed += capturingVideo;
            capture.Start();
        }
    }
}
