using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PC_Anti_Virus_Shield_Pro_2010
{
    public partial class ActivationPopup : Form
    {
        private Main mainForm;

        private const int MF_BYCOMMAND = 0x00000000;
        private const int MF_GRAYED = 0x00000001;
        private const int MF_DISABLED = 0x00000002;
        private const int SC_CLOSE = 0xF060;

        [DllImport("user32.dll")]
        private static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);

        [DllImport("user32.dll")]
        private static extern int EnableMenuItem(IntPtr hMenu, int uIDEnableItem, int uEnable);

        public ActivationPopup(Main mainForm)
        {
            InitializeComponent();
            this.TopMost = true;
            this.mainForm = mainForm;

            if (AppRegistry.IsActivated())
            {
                this.Close();
            }

            try
            {
                try
                {
                    string exePath = Environment.ExpandEnvironmentVariables(@"%windir%\System32\slui.exe");
                    Icon icon = Icon.ExtractAssociatedIcon(exePath);
                    pictureBox1.Image = icon.ToBitmap();
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                catch
                {
                    string exePath = @"C:\Windows\System32\slui.exe";
                    Icon icon = Icon.ExtractAssociatedIcon(exePath);
                    pictureBox1.Image = icon.ToBitmap();
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            catch
            {
                pictureBox1.Image = SystemIcons.Warning.ToBitmap();
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            GrayOutCloseButton();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    MessageBox.Show("Please activate PC Anti Virus Shield Pro 2010.", "Activation Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;                
            }

            base.OnFormClosing(e);
        }

        private void GrayOutCloseButton()
        {
            IntPtr hSysMenu = GetSystemMenu(this.Handle, false);
            if (hSysMenu != IntPtr.Zero)
            {
                EnableMenuItem(hSysMenu, SC_CLOSE, MF_BYCOMMAND | MF_GRAYED);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (mainForm.mainFormClosed == true)
            {
                mainForm.Show(); 
                mainForm.WindowState = FormWindowState.Normal; 
                mainForm.Activate(); 
                mainForm.mainFormClosed = false;                
            }

            mainForm.ShowPage(new PurchasePage(mainForm));
            mainForm.Pro_Focus();
        }
    }
}
