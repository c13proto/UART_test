using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UART_test
{
    public partial class Main : Form
    {
        bool CONNECTED = false;
        string COM_PORT = "COM1";
        int BAURATE = 9600;
        //arduinoのデフォルトは8bit、パリティなし、1ストップビット(SERIAL_8N1)
        SerialPort SERIAL;
        public Main()
        {
            InitializeComponent();
            COM_PORT_init();
            BAURATE_init();
        }

        private void Click_send(object sender, EventArgs e)
        {
            if (CONNECTED) SERIAL.Write(textBox_send.Text+'\n');
        }



        private void Click_connect(object sender, EventArgs e)
        {          
            if (!CONNECTED)
            {                
                Serial_start();
                button_connect.Text = "stop";
            }
            else
            {                
                SERIAL.Close();
                CONNECTED = false;
                button_connect.Text = "connect";                
            }
            
            Console.WriteLine("CONNECTED:{0}", CONNECTED);
        }

        private void Serial_start()
        {
            if (SERIAL != null) SERIAL = null;
            SERIAL = new SerialPort(COM_PORT, BAURATE, Parity.None, 8, StopBits.One);//8bit、パリティなし、1ストップビット
            //SERIAL.Encoding = Encoding.Unicode;//! 文字コードをセットする
            try
            {
                SERIAL.Open();
                CONNECTED = true;
                Console.WriteLine("Serial_start:{0},{1}", COM_PORT, BAURATE);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                CONNECTED = false;
            }
        }

        private void COM_PORT_init()
        {
            //! 利用可能なシリアルポート名の配列を取得する.
            string[] PortList = SerialPort.GetPortNames();

            //! シリアルポート名をコンボボックスにセットする.
            foreach (string PortName in PortList)
            {
                comboBox_COMポート.Items.Add(PortName);
            }
            if (comboBox_COMポート.Items.Count > 0)
            {
                comboBox_COMポート.SelectedIndex = 0;//キャストしないとだめだった
                COM_PORT = comboBox_COMポート.SelectedItem.ToString();
                Console.WriteLine("COM_init:{0}",COM_PORT);
            }
        }
        private void BAURATE_init()
        {
            comboBox_ボーレート.Items.Add("4800");
            comboBox_ボーレート.Items.Add("9600");
            comboBox_ボーレート.Items.Add("19200");
            comboBox_ボーレート.Items.Add("38400");
            comboBox_ボーレート.Items.Add("57600");
            comboBox_ボーレート.Items.Add("115200");
            comboBox_ボーレート.SelectedIndex = 1;
            BAURATE = int.Parse(comboBox_ボーレート.SelectedItem.ToString());
            Console.WriteLine("BAU_init:{0}", BAURATE);
        }

        private void SelectedIndexChanged_COMポート(object sender, EventArgs e)
        {
            COM_PORT = comboBox_COMポート.SelectedItem.ToString();
            Console.WriteLine("COM_changed:{0}", COM_PORT);
        }

        private void SelectedIndexChanged_ボーレート(object sender, EventArgs e)
        {
            BAURATE = int.Parse(comboBox_ボーレート.SelectedItem.ToString());
            Console.WriteLine("BAU_changed:{0}", BAURATE);
        }


    }
}
