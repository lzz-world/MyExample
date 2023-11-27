using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Windows.Forms;

namespace RTU
{
    public partial class MainForm : Form
    {
        private SerialPort _serialPort;
        private ModbusSerialMaster _master;
        public MainForm()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            _serialPort = new SerialPort("COM1");
            _serialPort.BaudRate = 9600;
            _serialPort.DataBits = 8;
            _serialPort.Parity = Parity.None;
            _serialPort.StopBits = StopBits.One;
            _serialPort.Open();
            _master = ModbusSerialMaster.CreateRtu(_serialPort);
            _master.Transport.ReadTimeout = 500;
            _master.Transport.WriteTimeout = 500;
        }

        private void ReadRegisters_Click(object sender, EventArgs e)
        {
            try
            {
                ushort startAddress = Convert.ToUInt16(StartAddressTextBox.Text);
                ushort numRegisters = Convert.ToUInt16(NumRegistersTextBox.Text);
                byte[] data = new byte[numRegisters * 2];
                if (_master.ReadHoldingRegisters(1, startAddress, numRegisters, data))
                {
                    for (int i = 0; i < numRegisters; i++)
                    {
                        ushort value = BitConverter.ToUInt16(data, i * 2);
                        RegistersListBox.Items.Add($"Register {startAddress + i}: {value}");
                    }
                }
                else
                {
                    MessageBox.Show("读取保持寄存器失败");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            _serialPort.Close();
            this.Close();
        }

        private void StartAddressTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
