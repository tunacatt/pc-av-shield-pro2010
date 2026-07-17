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
    public partial class PurchasePage : Form
    {
        private Main mainForm;

        public PurchasePage(Main mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;

            if (AppRegistry.IsActivated())
            {
                header.Text = "PC Anti Virus Shield Pro 2010 is activated";
                header.Location = new Point(110, 0);
                thankText.Visible = true;
                activationBox.Visible = false;
                pictureBox1.Image = PC_Anti_Virus_Shield_Pro_2010.Properties.Resources.PCAVShield10;
                pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            }
            else
            {
                header.Text = "PC Anti Virus Shield Pro 2010 is not activated";
                header.Location = new Point(90, 0);
                thankText.Visible = false;
                activationBox.Visible = true;
                pictureBox1.Image = SystemIcons.Error.ToBitmap();
                pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (AppRegistry.TryActivate(textBox1.Text))
            {
                MessageBox.Show("Activation successful! Thank you for activating PC Anti Virus Shield Pro 2010. Please restart your computer to apply all changes.", "Activation Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                header.Text = "PC Anti Virus Shield Pro 2010 is activated";
                header.Location = new Point(110, 0);
                thankText.Visible = true;
                activationBox.Visible = false;
                pictureBox1.Image = Properties.Resources.PCAVShield10;
                pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
                mainForm.ShowUpdateControls(true);
                // mainForm.CloseActivationPopup();
            }
            else
            {
                MessageBox.Show("Activation failed. Please check your activation key and try again.", "Activation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackgroundImage = Properties.Resources.Taskbar3;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackgroundImage = Properties.Resources.Taskbar2;
        }
    }
}
