using System;
using System.IO.Ports;
using System.Windows.Forms;
using RTU;

namespace SerialPortExample
  
{
    public partial class Form1 : Form
    {
        LogsControl logsControl = new LogsControl();
        public Form1()
        {
            InitializeComponent();

            logsControl.Width = this.Width;
            logsControl.Height = this.Height;
            panel1.Controls.Add(logsControl);

        }
    }
}