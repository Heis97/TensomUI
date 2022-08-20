using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV;
using Emgu.CV.Structure;

namespace Processing
{
    class DataProcessing
    {
        static public Mat data_to_mat(List<double[]> data, Size size_mat)
        {

            var data_n =  normalize_data(data, size_mat);
            var colors = new Color[] {Color.Red,Color.Green,Color.Blue,Color.Pink,Color.Purple};
            var im = new Image<Bgr, byte>(size_mat);
            im.SetValue(new Bgr(255,255,255));
            for (int i = 0; i < data_n.Count; i++)
            {
                for (int j = 1; j < data_n[i].Length; j++)
                {
                    im.Data[(int)data_n[i][j], (int)data_n[i][0], 2] = colors[j].R;
                    im.Data[(int)data_n[i][j], (int)data_n[i][0], 1] = colors[j].G;
                    im.Data[(int)data_n[i][j], (int)data_n[i][0], 0] = colors[j].B;
                }
            }
            return im.Mat;
        }

        static public List<double[]>  normalize_data(List<double[]> data, Size size_mat)
        {
            List<double[]> data_norm = new List<double[]>();
            var max = new double[data[0].Length];
            for (int i = 0; i < max.Length; i++) max[i] = double.MinValue;
            var min = new double[data[0].Length];
            for (int i = 0; i < min.Length; i++) min[i] = double.MaxValue;

            for (int i = 0; i < data.Count; i++)
            {
                for (int j = 0; j < max.Length; j++)
                {
                    if (data[i][j] > max[j]) max[j] = data[i][j];
                    if (data[i][j] < min[j]) min[j] = data[i][j];
                }               
            }
            var w = size_mat.Width - 10;
            var h = size_mat.Height - 10;
            for (int i = 0; i < data.Count; i++)
            {
                var data_n = (double[])data[i].Clone();
                data_n[0] = (data_n[0] - min[0]) * w / (max[0] - min[0]);
                for(int j = 1; j < data_n.Length; j++)
                {
                    if(max[j] - min[j] == 0) data_n[j] = w/2;
                    else data_n[j] = (data_n[j] - min[j]) * h / (max[j] - min[j]);

                }
                data_norm.Add(data_n);
            }
            
            return data_norm;
        }
    }
}
