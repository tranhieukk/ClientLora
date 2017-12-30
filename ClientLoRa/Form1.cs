
using System;
using System.Drawing;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;

namespace ClientLoRa
{

    public partial class Form1 : Form
    {
        public bool _continue;
        public SerialPort _serialPort;
        public string name = "";
        public string message = "";
        public StringComparer stringComparer = StringComparer.OrdinalIgnoreCase;
        Thread readThread = null;
        void create(string defaultPortName, int defaultPortBaudRate, Parity defaultPortParity, int defaultPortDataBits, StopBits defaultPortStopBits, Handshake defaultPortHandshake)
        {//_serialPort.PortName, _serialPort.BaudRate, _serialPort.Parity, _serialPort.DataBits, _serialPort.StopBits, _serialPort.Handshake
            cbxPortName.Items.Clear();
            cbbparity.Items.Clear();
            cbbStopBits.Items.Clear();
            cbbhandshake.Items.Clear();
            foreach (string s in SerialPort.GetPortNames())
            {
                cbxPortName.Items.Add(s);
            }



            foreach (string s in Enum.GetNames(typeof(Parity)))
            {
                cbbparity.Items.Add(s);
            }


            foreach (string s in Enum.GetNames(typeof(StopBits)))
            {
                cbbStopBits.Items.Add(s);
            }


            foreach (string s in Enum.GetNames(typeof(Handshake)))
            {
                cbbhandshake.Items.Add(s);
            }
            cbxPortName.SelectedIndex = cbxPortName.Items.Count - 1;
            txbdataBits.Text = defaultPortDataBits.ToString();
            txbBaudRate.Text = defaultPortBaudRate.ToString();
            cbbhandshake.SelectedItem = defaultPortHandshake.ToString();
            cbbparity.SelectedItem = defaultPortParity.ToString();
            cbbStopBits.SelectedItem = defaultPortStopBits.ToString();
        }

        public void Read()
        {
            while (_continue)
            {
                try
                {
                   
                    TextBox rtxbnhan = new TextBox();
                    rtxbnhan.BackColor = System.Drawing.Color.SandyBrown;
                    string message = _serialPort.ReadLine();
                     rtxbnhan.Size = new System.Drawing.Size(630, 54);
                    rtxbnhan.Multiline = true;
                    rtxbnhan.Text = message;
                   
                    try { 
                    noidung.Invoke(new MethodInvoker(delegate
                    {
                        noidung.Controls.Add(rtxbnhan);
                        noidung.AutoScrollPosition = new Point(rtxbnhan.Right, rtxbnhan.Bottom);

                    }));
                    }
                    catch (Exception ex) { throw ex; }
                }
                catch (TimeoutException) { }
            }
        }
        public Form1()
        {
            InitializeComponent(); _serialPort = new SerialPort();
            create(_serialPort.PortName, _serialPort.BaudRate, _serialPort.Parity, _serialPort.DataBits, _serialPort.StopBits, _serialPort.Handshake);



        }
        public string SetPortName()
        {
            return cbxPortName.SelectedItem.ToString();

        }
        public int SetPortBaudRate(int defaultPortBaudRate)
        {
            string baudRate;
            baudRate = txbBaudRate.Text;

            if (baudRate == "")
            {
                baudRate = defaultPortBaudRate.ToString();
            }

            return int.Parse(baudRate);
        }

        // Display PortParity values and prompt user to enter a value.
        public Parity SetPortParity(Parity defaultPortParity)
        {
            string parity;



            parity = cbbparity.SelectedText;

            if (parity == "")
            {
                parity = defaultPortParity.ToString();
            }

            return (Parity)Enum.Parse(typeof(Parity), parity, true);
        }
        // Display DataBits values and prompt user to enter a value.
        public int SetPortDataBits(int defaultPortDataBits)
        {
            string dataBits;

            dataBits = txbdataBits.Text;

            if (dataBits == "")
            {
                dataBits = defaultPortDataBits.ToString();
            }

            return int.Parse(dataBits.ToUpperInvariant());
        }

        // Display StopBits values and prompt user to enter a value.
        public StopBits SetPortStopBits(StopBits defaultPortStopBits)
        {
            string stopBits = cbbStopBits.SelectedText;
            if (stopBits == "")
            {
                stopBits = defaultPortStopBits.ToString();
            }

            return (StopBits)Enum.Parse(typeof(StopBits), stopBits, true);
        }
        public Handshake SetPortHandshake(Handshake defaultPortHandshake)
        {
            string handshake;
            handshake = cbbhandshake.SelectedItem.ToString();
            if (handshake == "")
            {
                handshake = defaultPortHandshake.ToString();
            }

            return (Handshake)Enum.Parse(typeof(Handshake), handshake, true);
        }
        string convertToJson(string nguoiGui, string nguoiNhan, string noiDung)
        {

            string json;
            json = "{\"from\":\"" + nguoiGui + "\",\"to\": \"" + nguoiNhan + "\",\"content\": \"" + noiDung + "\"}";
            return json;
        }
        private void btnsend_Click(object sender, EventArgs e)
        {
            
            message = convertToJson(name, txbNgNhan.Text, rtxbgui.Text);
            rtxbgui.Text = "";
            _serialPort.WriteLine(String.Format("<{0}>: {1}", name, message));
        }

        private void btnEXit_Click(object sender, EventArgs e)
        {
            _continue = false;
            if (readThread != null)
                readThread.Join();
            _serialPort.Close();
        }

        private void btncreate_Click(object sender, EventArgs e)
        {

            // Allow the user to set the appropriate properties.
            _serialPort.PortName = SetPortName();
            _serialPort.BaudRate = SetPortBaudRate(_serialPort.BaudRate);
            _serialPort.Parity = SetPortParity(_serialPort.Parity);
            _serialPort.DataBits = SetPortDataBits(_serialPort.DataBits);
            _serialPort.StopBits = SetPortStopBits(_serialPort.StopBits);
            _serialPort.Handshake = SetPortHandshake(_serialPort.Handshake);

            // Set the read/write timeouts
            _serialPort.ReadTimeout = 1000;
            _serialPort.WriteTimeout = 1000;

            _serialPort.Open();
            _continue = true;
            readThread = new Thread(new ThreadStart(Read));
            readThread.Start();
            name = txbClientName.Text;

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            _continue = false;
            if (readThread != null)
                readThread.Join();
            _serialPort.Close();
            create(_serialPort.PortName, _serialPort.BaudRate, _serialPort.Parity, _serialPort.DataBits, _serialPort.StopBits, _serialPort.Handshake);

        }
    }
}
