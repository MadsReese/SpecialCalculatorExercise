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

        private void Button1_ClickAsync(object sender, EventArgs e)
        {
            var task = GetResponseAsync<MyObject>("my url");
            var items = await task;

            if (radioButtonPi.Checked)
            {
                PI pi = new PI();
                pi.GetPI(6);
                SendInfoToLog("Clicked Pi" + txtInput.ToString());
            }
            else
            {
                SendInfoToLog("Clicked Prime" + txtInput.ToString());
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
