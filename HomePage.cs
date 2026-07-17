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
    public partial class HomePage : Form
    {
        private Main mainForm;

        public HomePage(Main mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;

            if (AppRegistry.IsActivated())
            { 
                proBoxActivButton.Visible = false;
                proBoxHeader.Text = "PC Anti Virus Shield Pro 2010 is activated";
                proBoxText.Text = "Thank you for activating PC Anti Virus Shield Pro 2010!";
                // label2.Text = "Scan your PC now to protect it from threats. Your computer might be infected with viruses and other unwanted programs. Scan it now to protect your personal data from being leaked.";
            }
            else
            {
                proBoxActivButton.Visible = true;
                proBoxHeader.Text = "PC Anti Virus Shield Pro 2010 is not activated";
                proBoxText.Text = "Please activate to unlock full protection and prevent future infections.";
                // label2.Text = "Scan your PC now to protect it from threats. Your computer might be infected with viruses and other unwanted programs. Scan it now to protect your personal data from being leaked. Purchase and activate your Pro to get better protection.";
            }

            if (AppRegistry.WasScannedBefore() && !AppRegistry.ThreatsRemoved())
            {
                label1.Text = "Attention required: Your PC is infected!";
                label2.Text = "Please scan your PC and remove the threats to protect your personal data from being leaked and files getting deleted.";
                label1.ForeColor = Color.Red;
            }
            else if (AppRegistry.WasScannedBefore() && AppRegistry.ThreatsRemoved())
            {
                label1.Text = "No threats found";
                label2.Text = "No threats were found on your PC. Your data is safe. A scan is still reccommended to keep you safe from viruses.";
                label1.ForeColor = Color.Green;
            }
            else if (AppRegistry.IsActivated() && !AppRegistry.WasScannedBefore())
            {
                label1.Text = "Attention required";
                label2.Text = "Scan your PC now to protect it from threats. Your computer might be infected with viruses and other unwanted programs. Scan it now to protect your personal data from being leaked.";
                label1.ForeColor = Color.Orange;
            }
            else
            {
                label1.Text = "Attention required";
                label2.Text = "Scan your PC now to protect it from threats. Your computer might be infected with viruses and other unwanted programs. Scan it now to protect your personal data from being leaked. Purchase and activate your Pro to get better protection.";
                label1.ForeColor = Color.Orange;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Scan
            /* var scanForm = new ScanForm();
            scanForm.Show(); */
            mainForm.ShowScanForm();
        }

        private void proBoxActivButton_Click(object sender, EventArgs e)
        {
            mainForm.ShowPage(new PurchasePage(mainForm));
            mainForm.Pro_Focus();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.Cursor = Cursors.Hand;
        }

        private void proBoxActivButton_MouseEnter(object sender, EventArgs e)
        {
            proBoxActivButton.Cursor = Cursors.Hand;
        }
    }
}
