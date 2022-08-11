using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Connection;

namespace TensomUI
{
    public partial class MainForm : Form
    {
        Tensom tensom;
        string arduino_port;
        int cycle_type;
        string[] cycle_types = { "меандр","треугольник","синус" };
        
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
            //tensom?.connectStart();
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

        
    }
}
