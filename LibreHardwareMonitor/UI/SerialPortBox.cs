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

namespace LibreHardwareMonitor.UI
{

    public partial class SerialPortBox : Form
    {
        private readonly MainForm _parent;

        public SerialPortBox(MainForm parent)
        {
            InitializeComponent();
            _parent = parent;

            // Wire up the Load event of the form
            this.Load += SerialPortBox_Load;
        }



        private void SerialPortBox_Load(object sender, EventArgs e)
        {
            //Only get ports that we can actually open
            List<string> validPorts = new List<string>();
            foreach (string port in SerialPort.GetPortNames())
            {
                try
                {
                    using (SerialPort sp = new SerialPort(port))
                    {
                        sp.Open();
                        sp.Close();
                        validPorts.Add(port);
                    }
                }
                catch
                {
                    // Port is unavailable or invalid, skip it
                }
            }
            SerialPortcomboBox.Items.AddRange(validPorts.ToArray());

            //// Get an array of available COM port names
            //string[] portNames = SerialPort.GetPortNames();

            //// Populate the SerialPortcomboBox dropdown with the available COM ports
            //SerialPortcomboBox.Items.AddRange(portNames);

            // Optionally, select the first port by default if there are any ports available
            //if (portNames.Length > 0)
            if (validPorts.ToArray().Length > 0)
            {
                SerialPortcomboBox.SelectedIndex = 0;
                
                SerialPortSpeedcomboBox.Enabled = true;
                string[] portSpeeds = { "9600", "115200" };
                SerialPortSpeedcomboBox.Items.AddRange(portSpeeds);
                SerialPortSpeedcomboBox.SelectedIndex = 1;
            }
            else
            {

                SerialPortSpeedcomboBox.Enabled = false;
                SerialPortcomboBox.Enabled = false;
            }


        }

        private void SerialOKButton_Click(object sender, EventArgs e)
        {
            // Save the selected COM port to the selectedComPort variable
            selectedComPort = SerialPortcomboBox.SelectedItem.ToString();
            selectedComPortSpeed= SerialPortSpeedcomboBox.SelectedItem.ToString();
            DialogResult = DialogResult.OK;

            /*Properties.Settings.Default.ComPortName = selectedComPort;
            Properties.Settings.Default.ComPortSpeed = selectedComPortSpeed;
            Properties.Settings.Default.Save();*/

            // Close the SerialPortBox form
            Close();
        }

        private void SerialCancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SerialPortcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (SerialPortcomboBox.SelectedItem.ToString()==null)
            {
                selectedComPort = SerialPortcomboBox.SelectedItem.ToString();
            }
            
        }

        private void SerialPortSpeedcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (SerialPortcomboBox.SelectedItem.ToString()==null)
            {
                selectedComPortSpeed = SerialPortSpeedcomboBox.SelectedItem.ToString();
            }

        }

        private string selectedComPort;
        public string SelectedComPort
        {
            get { return selectedComPort; }
        }

        private string selectedComPortSpeed;
        public string SelectedComPortSpeed
        {
            get { return selectedComPortSpeed; }
        }

        private void SerialPortBox_Load_1(object sender, EventArgs e)
        {

        }

/*        private string serialMenuItem.click(object sender, EventArgs e)
        {

        }*/
        /*        private void SerialPortSpeedcomboBox_SelectedIndexChanged(object sender, EventArgs e)
                {

                }*/
    }
}
