using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeInApp
{
    public partial class AdminDashboard : Form
    {
        Timer clock = new Timer();

        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            clock.Interval = 1000;
            clock.Tick += new EventHandler(this.ClockTick);
            clock.Start();
        }

        private void ClockTick(object sender, EventArgs e)
        {
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;
            string today = DateTime.Now.Date.ToShortDateString();

            string timeDisplay = string.Empty;

            if (hh < 10)
            {
                timeDisplay += "0" + hh;
            }
            else
            {
                timeDisplay += hh;
            }
            timeDisplay += ":";
            if (mm < 10)
            {
                timeDisplay += "0" + mm;
            }
            else
            {
                timeDisplay += mm;
            }
            timeDisplay += ":";
            if (ss < 10)
            {
                timeDisplay += "0" + ss;
            }
            else
            {
                timeDisplay += ss;
            }

            label2.Text = timeDisplay;
            label3.Text = today;
        }

        private void AdminDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            new LoginForm().Show();
            this.Dispose();
        }
    }
}
