using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Connection
{
    public class Scara : DeviceMarlin
    {
       float l1=35, l2=30;
        
        enum Val { Pos};
      
        public Scara(string _port) : base(_port)
        {

        }

        public void move(float x, float y, float vel)
        {
            var p_ab = calc_pos_ab(new PointF(x, y));
            sendCommand("M92 X0 Y0");
            sendCommand("G90");
            sendCommand("G1", new string[] { "X", "Y","F" }, new object[] { p_ab.X, p_ab.Y,vel });
        }

        PointF calc_pos_ab(PointF p_xy)
        {
            var x = p_xy.X;
            var y = p_xy.Y;
            var q2 = arccos((x * x + y * y - l1 * l1 - l2 * l2) / (2 * l1 * l2));
            var q1 = arctg(y / x) - q2;

            return new PointF(toSteps(q1), toSteps(q2));
        }

        float arccos(float v)
        { 
            return (float)Math.Acos(v); 
        }
        float arctg(float v)
        {
            return (float)Math.Atan(v);
        }

        int toSteps(float ang)
        {
            return (int)(ang*6400 / (4 * Math.PI));
        }
    }
}
