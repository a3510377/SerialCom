using System;
using System.IO.Ports;
using System.Linq;
using System.Windows.Forms;

namespace SerialCom
{
    public partial class Form1 : Form
    {
        bool isConnect = false;
        readonly SerialPort serialPort = new SerialPort();

        public Form1()
        {
            InitializeComponent();

            comboBoxStopBit.SelectedIndex = comboBoxStopBit.Items.IndexOf("1");
            comboBoxDataBit.SelectedIndex = comboBoxDataBit.Items.IndexOf("8");
            comboBoxCheckBit.SelectedIndex = comboBoxCheckBit.Items.IndexOf("None");
            comboBoxBaundRate.SelectedIndex = comboBoxBaundRate.Items.IndexOf("9600");
        }

        public void RefreshSerialPort()
        {
            string[] ports = SerialPort.GetPortNames();
            foreach (var item in comboBoxPorts.Items)
            {
                if (!ports.Contains(item.ToString()))
                {
                    comboBoxPorts.Items.Remove(item);
                }
            }

            comboBoxPorts.Items.AddRange(ports.Except(comboBoxPorts.Items.Cast<string>()).ToArray());
        }

        public void CloseSerail()
        {
            serialPort.Close();
            btnToggleConnect.Text = "連線";

            isConnect = false;
            comboBoxPorts.Enabled = true;
            comboBoxStopBit.Enabled = true;
            comboBoxDataBit.Enabled = true;
            comboBoxCheckBit.Enabled = true;
            comboBoxBaundRate.Enabled = true;
        }

        public void SendData()
        {
            if (!serialPort.IsOpen)
            {
                MessageBox.Show("串口未開啟", "Error");
                return;
            }

            String sendData = textBoxSend.Text;
            sendData.Replace("\\n", "\n");
            sendData.Replace("\\r", "\r");

            if (btnWithLR.Checked)
            {
                sendData += "\r\n";
            }

            serialPort.Write(sendData);
        }

        public void ClearReceiveBox()
        {
            textBoxReceive.Text = "";
        }

        public void ClearSendBox()
        {
            textBoxSend.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshSerialPort();

            serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceived);
        }

        private void TimerRefreshSerial_Tick(object sender, EventArgs e)
        {
            RefreshSerialPort();

            if (isConnect && !serialPort.IsOpen)
            {
                CloseSerail();
            }
        }

        private void BtnToggleConnect_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                CloseSerail();
                return;
            }

            if (comboBoxPorts.SelectedIndex == -1)
            {
                MessageBox.Show("請重新選擇連接埠", "Error");
                return;
            }

            btnToggleConnect.Text = "斷開";
            comboBoxPorts.Enabled = false;
            comboBoxStopBit.Enabled = false;
            comboBoxDataBit.Enabled = false;
            comboBoxCheckBit.Enabled = false;
            comboBoxBaundRate.Enabled = false;

            Parity parity = Parity.None;
            switch (comboBoxCheckBit.SelectedItem.ToString())
            {
                case "None":
                    parity = Parity.None;
                    break;
                case "Odd":
                    parity = Parity.Odd;
                    break;
                case "Even":
                    parity = Parity.Even;
                    break;
                case "Mark":
                    parity = Parity.Mark;
                    break;
                case "Space":
                    parity = Parity.Space;
                    break;
            }

            StopBits stopBits = StopBits.One;
            switch (comboBoxStopBit.SelectedItem.ToString())
            {
                case "1":
                    stopBits = StopBits.One;
                    break;
                case "1.5":
                    stopBits = StopBits.OnePointFive;
                    break;
                case "2":
                    stopBits = StopBits.Two;
                    break;
            }
            serialPort.Parity = parity;
            serialPort.StopBits = stopBits;
            serialPort.PortName = comboBoxPorts.SelectedItem.ToString();
            serialPort.DataBits = int.Parse(comboBoxDataBit.SelectedItem.ToString());
            serialPort.BaudRate = int.Parse(comboBoxBaundRate.SelectedItem.ToString());

            serialPort.Open();

            isConnect = true;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.Enter))
            {
                SendData();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (!serialPort.IsOpen)
            {
                MessageBox.Show("串口未開啟但獲取到數據", "Warrn");
                return;
            }

            try
            {
                String input = serialPort.ReadExisting();
                if (textBoxReceive.InvokeRequired)
                {
                    textBoxReceive.Invoke(new Action(() => textBoxReceive.Text += input));
                }
                else
                {
                    textBoxReceive.Text += input;
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                textBoxReceive.Text = "";
            }
        }

        private void KeyNum_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBoxSend.Text += btn.Text;
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            SendData();
        }

        private void KeyClear_Click(object sender, EventArgs e)
        {
            ClearSendBox();
        }

        private void KeySend_Click(object sender, EventArgs e)
        {
            SendData();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort.IsOpen)
            {
                CloseSerail();
            }
        }

        private void BtnReceiveClear_Click(object sender, EventArgs e)
        {
            ClearReceiveBox();
        }
    }
}
