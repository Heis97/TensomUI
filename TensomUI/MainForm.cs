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

namespace TensomUI
{
    public partial class MainForm : Form
    {
        Tensom tensom;
        string arduino_port;
        int cycle_type;
        string[] cycle_types = { "меандр","треугольник","синус" };
        int cur_time = 0;

        List<double[]> data_arr = new List<double[]>();


        public MainForm()
        {
            InitializeComponent();
            combo_cycle_type.Items.AddRange(cycle_types);
            combo_cycle_type.SelectedIndex = 0;
        }

        private void but_find_ports_Click(object sender, EventArgs e)
        {
            Tensom.find_ports(combo_ard_port);
            
        }

        private void but_disconnect_Click(object sender, EventArgs e)
        {
            tensom?.connectStop();
        }

        private void but_connect_Click(object sender, EventArgs e)
        {
            tensom = new Tensom(arduino_port);
            try
            {
              //  Thread myThread = new Thread(feedback);
              //  myThread.Start(); //запускаем поток
                timer_feedback.Start();
            }
            catch
            {

            }
            //tensom?.connectStart();
        }
        async void feedback()
        {
            while (tensom.isOpen())
            {
                await Task.Delay(20);
                try
                {

                    var res = tensom.reseav();
                    if (res.Length>5)
                    {
                        var vals = res.Trim().Split(' ');
                        var data = new double[] { cur_time, Convert.ToDouble(vals[0]), Convert.ToDouble(vals[1]), Convert.ToDouble(vals[2])};
                        data_arr.Add(data);
                        cur_time++;
                        imB_graphics.Image = DataProcessing.data_to_mat(data_arr, imB_graphics.Size);
                        //imB_graphics.Update();
                        //Console.WriteLine(vals[0]+", "+ vals[1] + ", " + vals[2]);
                    }
                    
                }
                catch
                {

                }
                
            }
        }

        private void but_enable_force_Click(object sender, EventArgs e)
        {
            tensom?.enableForce(1);
        }

        private void but_disable_force_Click(object sender, EventArgs e)
        {
            tensom?.enableForce(0);
        }

        private void but_tens_up_Click(object sender, EventArgs e)
        {
            tensom?.sensorUp();
        }

        private void but_tens_down_Click(object sender, EventArgs e)
        {
            tensom?.sensorDown();
        }

        private void but_set_force_Click(object sender, EventArgs e)
        {
            int force = Convert.ToInt32(text_b_force_dest.Text);
           tensom?.setForce(force);
        }
        private void but_cycle_settings_Click(object sender, EventArgs e)
        {
            int time_force = Convert.ToInt32(text_b_time_force.Text);
            int time_relax = Convert.ToInt32(text_b_time_relax.Text);
            int force_max = Convert.ToInt32(text_b_force_max.Text);
            tensom?.setSettings(time_force, time_relax, force_max);  

        }


        private void but_cycle_start_Click(object sender, EventArgs e)
        {
            tensom?.setCycle(cycle_type);
        }

        private void but_cycle_stop_Click(object sender, EventArgs e)
        {
            tensom?.setCycle(0);
        }

        private void combo_ard_port_SelectedIndexChanged(object sender, EventArgs e)
        {
            arduino_port = (string)combo_ard_port.SelectedItem;
        }

        private void combo_cycle_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            cycle_type = combo_cycle_type.SelectedIndex+1;
        }

        private void but_enable_light_Click(object sender, EventArgs e)
        {
            tensom?.enableLight(0);
        }

        private void but_disable_light_Click(object sender, EventArgs e)
        {
            tensom?.enableLight(1);
        }

        private void but_test_Click(object sender, EventArgs e)
        {
            imB_graphics.Image = DataProcessing.data_to_mat(data_arr, imB_graphics.Size);
            imB_graphics.Update();
        }

        private void timer_feedback_Tick(object sender, EventArgs e)
        {
            try
            {

                var res = tensom.reseav();
                if (res.Length > 5)
                {
                    var vals = res.Trim().Split(' ');
                    var data = new double[] { cur_time, Convert.ToDouble(vals[0]), Convert.ToDouble(vals[1]), Convert.ToDouble(vals[2]) };
                    label_feedback.Text = res;
                    data_arr.Add(data);
                    cur_time++;
                    imB_graphics.Image = DataProcessing.data_to_mat(data_arr, imB_graphics.Size);
                    //imB_graphics.Update();
                    //Console.WriteLine(vals[0]+", "+ vals[1] + ", " + vals[2]);
                }

            }
            catch
            {

            }
        }

        private void but_clear_data_Click(object sender, EventArgs e)
        {
            data_arr = new List<double[]>();
            cur_time = 0;
        }

        private void but_save_data_Click(object sender, EventArgs e)
        {
            DataProcessing.saveData(data_arr, DateTime.Now.Month.ToString()+"_"+ DateTime.Now.Day.ToString() + "_" +
                DateTime.Now.Hour.ToString() + "_" + DateTime.Now.Minute.ToString() + "_" +
                DateTime.Now.Second.ToString() + "_");
        }
    }
}
