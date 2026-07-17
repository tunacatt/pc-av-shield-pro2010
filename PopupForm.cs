using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace PC_Anti_Virus_Shield_Pro_2010
{
    public partial class PopupForm : Form
    {
        public enum PopupType { Reminder, ThreatsDetected, ActivatePro }

        private SoundPlayer pop = new SoundPlayer(Properties.Resources.pop);
        private SoundPlayer alert = new SoundPlayer(Properties.Resources.threat);

        public PopupForm(PopupType type)
        {
            InitializeComponent();            

            switch (type)
            {
                case PopupType.Reminder:
                    // panel1.BackColor = Color.DarkOrange;
                    panel1.BackgroundImage = Properties.Resources.YellowBar;
                    popupHeader.Text = "Scan reminder";
                    popupContent.Text = "You have not scanned your computer in a while. Please run a scan to ensure your system is safe.";
                    pictureBox1.Image = SystemIcons.Warning.ToBitmap();
                    pop.Play();
                    break;
                case PopupType.ThreatsDetected:
                    // panel1.BackColor = Color.DarkRed;
                    panel1.BackgroundImage = Properties.Resources.RedBar;
                    popupHeader.Text = "Threats were found";
                    popupContent.Text = "Your computer is infected. Please run a scan and remove them.";
                    pictureBox1.Image = SystemIcons.Error.ToBitmap();
                    alert.Play();
                    break;
                case PopupType.ActivatePro:
                    // panel1.BackColor = Color.DarkOrange;
                    panel1.BackgroundImage = Properties.Resources.YellowBar;
                    popupHeader.Text = "Activate PC Anti Virus Shield Pro 2010";
                    popupContent.Text = "You haven't activated PC Anti Virus Shield Pro 2010. Please activate to unlock full protection and prevent future infections.";
                    pictureBox1.Image = SystemIcons.Warning.ToBitmap();
                    pop.Play();
                    break;
            }

            /* var workingArea = Screen.PrimaryScreen.WorkingArea;

            this.Location = new Point(
                workingArea.Right - this.Width - 10,
                workingArea.Bottom - this.Height - 10
            ); */

            Rectangle workingArea = Screen.GetWorkingArea(this);
            this.Location = new Point(
                workingArea.Right - Size.Width,
                workingArea.Bottom - Size.Height
            );
        }

        private void dismissLink_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dismissLink_MouseEnter(object sender, EventArgs e)
        {
            dismissLink.ForeColor = SystemColors.ControlDarkDark;
            dismissLink.Cursor = Cursors.Hand;
        }

        private void dismissLink_MouseLeave(object sender, EventArgs e)
        {
            dismissLink.ForeColor = SystemColors.ControlDark;
        }
    }
}
