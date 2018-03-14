using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;


namespace Presentation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Controls.Add(btnCalculate);
            btnCalculate.Click += new EventHandler(Button1_ClickAsync);

            radioButtonPi.Checked = true;
        }

        public void GetFromRabbit()
        {
            using (var bus = RabbitHutch.CreateBus("host=localhost"))
            {
                bus.Publish(new PImodel
                {
                    piValue = Convert.ToInt16(value)
                });

                bus.Receive("CalculatedReplyQueue", (msg) =>
                {

                });
            };
        }

        private void Button1_ClickAsync(object sender, EventArgs e)
        {
            string value = txtInput.Text;
            PI pi = new PI();

            if (radioButtonPi.Checked)
            {
                pi.SendToRabbit(value);
                SendInfoToLog("Clicked Pi " + value);
                txtResult.Text = $"PI {pi.GetFromRabbit()}";

            }
            else
            {
                pi.SendToRabbit(value);
                SendInfoToLog("Clicked Prime " + value);
                txtResult.Text = $"Prime {pi.GetFromRabbit()}";

            }
        }

        private static void SendInfoToLog(string message)
        {
            string logSource = "NumberCalculator";
            string logType = "Application";

            if (!EventLog.SourceExists(logSource))
            {
                EventLog.CreateEventSource(logSource, logType);
                return;
            }

            EventLog myLog = new EventLog();
            myLog.Source = logSource;
            myLog.WriteEntry(message);
        }


    }
}
