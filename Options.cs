using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace PC_Anti_Virus_Shield_Pro_2010
{
    public partial class Options : Form
    {
        private Main mainForm;

        public bool debugEnabled = false;

        public Options(Main mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;

            dirTextBox.Text = Application.StartupPath;
            if (AppRegistry.IsActivated())
            {
                checkBox1.Enabled = true;
                button6.Enabled = true;
                proBoxHeader.Text = "PC Anti Virus Shield Pro 2010 is activated";
                proBoxText.Text = "Thank you for activating PC Anti Virus Shield Pro 2010!";
                proBoxText1.Visible = false;
            }
            else
            {
                checkBox1.Enabled = false;
                button6.Enabled = false;
                proBoxHeader.Text = "PC Anti Virus Shield Pro 2010 is not activated";
                proBoxText.Text = "Please activate to unlock full protection and prevent future infections.";
                proBoxText1.Visible = true;
            }

            if (debugEnabled == true)
            {
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                label1.Visible = true;
                switchPro.Visible = true;
                threatsRemovedSetting.Visible = true;
            }
            else
            {
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
                label1.Visible = false;
                switchPro.Visible = false;
                threatsRemovedSetting.Visible = false;
            }

            if (AppRegistry.NotificationsEnabled())
            {
                checkBox1.Checked = true;
            }
            else
            {
                checkBox1.Checked = false;
            }

            if (AppRegistry.ThreatsRemoved())
            {
                threatsRemovedSetting.Checked = true;
            }
            else { threatsRemovedSetting.Checked = false; }
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

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            AppRegistry.RemoveThreats(threatsRemovedSetting.Checked);
        }

        private void switchPro_CheckedChanged(object sender, EventArgs e)
        {
            AppRegistry.SetActivated(switchPro.Checked);
        }

        private void debugPassBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (AppRegistry.TryEnableDebug(debugPassBox.Text))
            {
                debugEnabled = true;
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                label1.Visible = true;
                switchPro.Visible = true;
                threatsRemovedSetting.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mainForm.ShowUpdateControls(true);
        }

        string startupShortcutPath = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + @"PC Anti Virus Shield Pro 2010.lnk";

        private void button4_Click(object sender, EventArgs e)
        {
            if (File.Exists(startupShortcutPath))
            {
                File.Delete(startupShortcutPath);
            }
        }
    }
}
