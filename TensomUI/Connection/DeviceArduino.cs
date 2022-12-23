using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO.Ports;
using System.IO;
using System.Windows.Forms;

namespace Connection
{
    public class DeviceArduino
    {
        protected SerialPort serialPort;
        protected bool isConnected = false;
        public StringBuilder buff;

        protected DeviceArduino()
        {
            serialPort = new SerialPort();
            buff = new StringBuilder();
        }
        static public void find_ports(ComboBox comboBox_portsArd)
        {

            //comboBox_portsArd.Items.Add("COM3");
            comboBox_portsArd.Items.Clear();

            // Получаем список COM портов доступных в системе
            string[] portnames = SerialPort.GetPortNames();
            // Проверяем есть ли доступные
            if (portnames.Length == 0)
            {
                MessageBox.Show("COM PORT not found");
            }
            foreach (string portName in portnames)
            {
                //добавляем доступные COM порты в список           
                comboBox_portsArd.Items.Add(portName);
                //Console.WriteLine(portnames.Length);
                if (portnames[0] != null)
                {
                    comboBox_portsArd.SelectedItem = portnames[0];
                }
            }
        }
        protected bool connect(string port, int baudrate)
        {
            try
            {
                serialPort.PortName = port;
                serialPort.BaudRate = baudrate;
                Console.WriteLine("try open " + port + " " + baudrate);
                serialPort.Open();
                isConnected = true;
                Console.WriteLine("open " + port + " " + baudrate);
                return true;
            }
            catch
            {
                Console.WriteLine("open failed");
                return false;
            }
        }



        protected void close()
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();
            }
        }
        protected void send(int val, int var)
        {
            if (isConnected)
            {

                string Mes1 = "0";
                string Mes2 = "0";
                try
                {
                    Mes1 = Convert.ToString(val);
                    Mes2 = Convert.ToString(var);
                }
                catch
                {
                    Console.WriteLine("except convert");
                }
                if (Mes1.Length <= 4 && Mes2.Length <= 3)
                {

                    while (Mes1.Length < 4)
                    {
                        Mes1 = "0" + Mes1;
                    }
                    while (Mes2.Length < 3)
                    {
                        Mes2 = "0" + Mes2;
                    }
                    Mes1 = "b" + Mes1 + Mes2;
                    try
                    {
                        Console.WriteLine("Out: " + Mes1);

                        this.serialPort.WriteLine(Mes1);
                    }
                    catch
                    {
                        Console.WriteLine("except sending");
                    }

                }
                else
                {
                    Console.WriteLine("message lengh too long");
                }

            }
        }
        public string reseav()
        {
            try
            {

                var res = serialPort.ReadExisting();
                if (res != null)
                    if (res.Length != 0)
                    {
                        if (buff.Length > 1000)
                        {
                            buff.Clear();
                        }
                        buff.Append(res);

                    }
                return res;
            }
            catch
            {
                return "PORT closed";
            }

        }
        public bool isOpen()
        {
            return serialPort.IsOpen;
        }
    }
}