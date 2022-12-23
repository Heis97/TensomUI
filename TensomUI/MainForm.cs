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
using Connection;
using Processing;
using Video;

namespace TensomUI
{
    public partial class MainForm : Form
    {
        Scara scara;
        string arduino_port;
        int cur_time = 0;

        List<double[]> data_arr = new List<double[]>();


        public MainForm()
        {
            InitializeComponent();            
        }

        private void but_find_ports_Click(object sender, EventArgs e)
        {
            Scara.find_ports(combo_ard_port);
            
        }

        private void but_disconnect_Click(object sender, EventArgs e)
        {
            scara?.connectStop();
        }

        private void but_connect_Click(object sender, EventArgs e)
        {
            scara = new Scara(arduino_port);
            try
            {
                timer_feedback.Start();
            }
            catch
            {

            }
        }


        private void combo_ard_port_SelectedIndexChanged(object sender, EventArgs e)
        {
            arduino_port = (string)combo_ard_port.SelectedItem;
        }


        private void timer_feedback_Tick(object sender, EventArgs e)
        {
            try
            {

                var res = scara.reseav();
               /* if (res.Length > 5)
                {
                    var vals = res.Trim().Split(' ');
                    var data = new double[] { cur_time, Convert.ToDouble(vals[0]), Convert.ToDouble(vals[1]), Convert.ToDouble(vals[2]) };
                    data_arr.Add(data);
                    cur_time++;
                    imB_graphics.Image = DataProcessing.data_to_mat(data_arr, imB_graphics.Size);
                    //imB_graphics.Update();
                    //Console.WriteLine(vals[0]+", "+ vals[1] + ", " + vals[2]);
                }*/

            }
            catch
            {

            }
        }

        private void but_move_pos_Click(object sender, EventArgs e)
        {
            var x = Convert.ToSingle(tb_pos_x.Text);
            var y = Convert.ToSingle(tb_pos_y.Text);
            scara.move(x, y, 8000);
        }
    }
}
