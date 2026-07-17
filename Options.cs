using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PC_Anti_Virus_Shield_Pro_2010
{
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();
            dirTextBox.Text = Application.StartupPath;
            if (AppRegistry.IsActivated())
            {
                checkBox1.Enabled = true;
                proBoxHeader.Text = "PC Anti Virus Shield Pro 2010 is activated";
                proBoxText.Text = "Thank you for activating PC Anti Virus Shield Pro 2010!";
                proBoxText1.Visible = false;
            }
            else
            {
                checkBox1.Enabled = false;
                proBoxHeader.Text = "PC Anti Virus Shield Pro 2010 is not activated";
                proBoxText.Text = "Please activate to unlock full protection and prevent future infections.";
                proBoxText1.Visible = true;
            }

            if (AppRegistry.NotificationsEnabled())
            {
                checkBox1.Checked = true;
            }
            else
            {
                checkBox1.Checked = false;
            }
        }

        private void copyDirBtn_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(dirTextBox.Text);
            copyDirBtn.Text = "Copied!";

            Timer timer = new Timer();
            timer.Interval = 2500; // 2.5 seconds
            timer.Tick += (s, ev) => { copyDirBtn.Text = "Copy"; timer.Dispose(); };
            timer.Start();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            AppRegistry.SwitchNotifications(checkBox1.Checked);
        }
    }
}
