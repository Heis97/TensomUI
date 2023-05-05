using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connection
{
    public class Tensom : DeviceArduino
    {
        string port;
        int baudrate = 250000;
        int dir_move = 13, 
            vel_move = 1,
            force_dest = 2,
            force_en=3, 
            cycle_type = 4, 
            sensor_up=5, 
            sensor_down=6,  
            force_max = 7,
            time_force = 8,
            time_relax = 9,
            light_en = 10,
            k_p_p = 11,
            k_v_p = 12,
            temperature = 15,
            heat_en = 14;

        int on = 1, off = 0;
        int up = 2, stop = 1, down = 0;
        int cycle_stop = 0, cycle_meandr = 1, cycle_triangle = 2, cycle_sinus = 3;
      
        public Tensom(string _port)
        {
            port = _port;
            connect(port, baudrate);
        }
        public bool connectStart()
        {
            return connect(port, baudrate);
        }
        public void connectStop()
        {
            close();
        }
        public void set_k_p_p(double val)
        {
            send((int)(val * 100),k_p_p);
        }
        public void set_k_v_p(double val)
        {
            send((int)(val * 100),k_v_p);
        }
        public void move_stop()
        {
            send(stop,dir_move);
        }
        public void up_vel(double vel)
        {
            send(up,dir_move);
            send((int) (vel * 100),vel_move);
        }

        public void down_vel(double vel)
        {
            send(down,dir_move);
            send((int)(vel * 100),vel_move);
        }
        public void sensorUp()
        {
            send(on, sensor_up);
        }
        public void sensorDown()
        {
            send(on, sensor_down);
        }
        public void setForce(int _force)
        {
            send(_force, force_dest);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_enable">0 - выкл, 1 - вкл</param>
        public void enableForce(int _enable)
        {
            send(_enable, force_en);
        }
        /// <summary>
        /// Установка параметров цикла сжатия
        /// </summary>
        /// <param name="_time_force"> время усилия, мс</param>
        /// <param name="_time_relax"> время без усилия, мс</param>
        /// <param name="_force_max"> максимальная амплитуда сжатия, граммы</param>
        public void setSettings(int _time_force, int _time_relax, int _force_max)
        {
            send(_time_force, time_force);
            send(_time_relax, time_relax);
            send(_force_max, force_max);
        }
        /// <summary>
        /// Установка типа цикла
        /// </summary>
        /// <param name="_cycle_type">
        /// 0 - выключен, 1 - меандр, 2 - треугольник, 3 - синус
        /// </param>
        public void setCycle(int _cycle_type)
        {
            send(_cycle_type, cycle_type);
        }

        public void enableLight(int _enable)
        {
            send(_enable, light_en);
        }

        public void enableHeat(int _enable)
        {
            send(_enable, heat_en);
        }
        public void set_temperature(int _temperatue)
        {
            send(_temperatue, temperature);
        }
    }
}
