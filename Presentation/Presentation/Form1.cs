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

namespace Presentation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Controls.Add(btnCalculate);
            btnCalculate.Click += new EventHandler(Button1_Click);

            radioButtonPi.Checked = true;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (radioButtonPi.Checked)
            {
                SendInfoToLog("Clicked Pi");
            }
            else
            {
                SendInfoToLog("Clicked Prime");
            }
        }

        private static void SendInfoToLog(string message)
        {
            string logSource = "NumberCalculator";
            string logType = "Application";
            if (!EventLog.SourceExists(logSource))
                EventLog.CreateEventSource(logSource, logType);
            EventLog.WriteEntry(logSource, message, EventLogEntryType.Information);
        }

    }
}
