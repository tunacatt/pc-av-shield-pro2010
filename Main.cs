using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using IWshRuntimeLibrary;
using File = System.IO.File;

namespace PC_Anti_Virus_Shield_Pro_2010
{
    public partial class Main : Form
    {
        private Timer scanReminderTimer;
        private Timer activationTimer;
        private Timer threatsFoundTimer;

        public bool mainFormClosed = false;

        string shortcutInFolderPath = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory), "PC Anti Virus Shield Pro 2010.lnk");

        public Main()
        {
            InitializeComponent();
            this.Load += Main_Load;

            // ##############################
            // Activation unclosable popup
            // ##############################

            ActivationPopup activationPopup = new ActivationPopup(this);

            if (!AppRegistry.IsActivated() && !activationPopup.IsDisposed)
            {
                activationPopup.Show();
            }

            if (!System.IO.File.Exists(shortcutInFolderPath))
            {
                try
                {
                    CreateShortcut(shortcutInFolderPath, "");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Hide update controls by default
            ShowUpdateControls(false);

            // ##############################
            // Popups & their timers
            // ##############################

            new PopupForm(PopupForm.PopupType.Reminder).Show();
                        
            scanReminderTimer = new Timer();
            scanReminderTimer.Interval = 30 * 60 * 1000;
            scanReminderTimer.Tick += ScanReminderTimer_Tick;
            if (AppRegistry.NotificationsEnabled()) scanReminderTimer.Start();

            activationTimer = new Timer();
            activationTimer.Interval = 10 * 60 * 1000;
            activationTimer.Tick += ActivationTimer_Tick;
            if (!AppRegistry.IsActivated() && AppRegistry.NotificationsEnabled()) activationTimer.Start();

            threatsFoundTimer = new Timer();
            threatsFoundTimer.Interval = 5 * 60 * 1000;
            threatsFoundTimer.Tick += ThreatsFoundTimer_Tick;
            if (!AppRegistry.ThreatsRemoved() && AppRegistry.WasScannedBefore() && AppRegistry.NotificationsEnabled()) threatsFoundTimer.Start();
                        
            if (!AppRegistry.NotificationsEnabled() && !AppRegistry.IsActivated())
            {
                AppRegistry.SwitchNotifications(true);
            }

            // ##############################
            // Tray icon
            // ##############################

            trayMenu = new ContextMenuStrip();
            trayMenu.Items.Add("Open", null, (s, e) => { this.Show(); this.WindowState = FormWindowState.Normal; this.Activate(); mainFormClosed = false; if (updateControlsVisible == true) ShowUpdateControls(true); else ShowUpdateControls(false); });
            if (AppRegistry.IsActivated())
            {
                trayMenu.Items.Add("Exit", null, (s, e) => { notifyIcon1.Visible = false; Application.Exit(); });
            }
            else
            {
                var exitAppTrayMenu = trayMenu.Items.Add("Exit", null, (s, e) => { notifyIcon1.Visible = false; Application.Exit(); });
                exitAppTrayMenu.Enabled = false;                
            }

            notifyIcon1 = new NotifyIcon();
            notifyIcon1.Icon = Properties.Resources.PCAVShield101;
            notifyIcon1.Visible = true;
            notifyIcon1.Text = "PC Anti Virus Shield Pro 2010";
            notifyIcon1.ContextMenuStrip = trayMenu;

            notifyIcon1.MouseClick += (s, e) =>
            {
                if (e.Button == MouseButtons.Left)
                {
                    this.Show();
                    this.WindowState = FormWindowState.Normal;
                    this.Activate();
                    if (updateControlsVisible == true) ShowUpdateControls(true);
                    else ShowUpdateControls(false);                    
                }
            };
        }

        // Minimize to tray instead of exiting
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
                notifyIcon1.BalloonTipTitle = "PC Anti Virus Shield Pro 2010";
                notifyIcon1.BalloonTipText = "Still running in the background. Your PC is protected.";
                notifyIcon1.ShowBalloonTip(3000);
                mainFormClosed = true;
            }
            else
            {
                base.OnFormClosing(e);
            }
        }

        // Close the activate popup (it may or may not work, try calling it in a try-catch)
        public void CloseActivationPopup()
        {
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm is ActivationPopup activationPopup)
                {
                    activationPopup.Close();
                    break;
                }
            }
        }

        // CreateShortcut for Startup and Desktop folders
        public void CreateShortcut(string shortcutPath, string arguments)
        {
            Type shellType = Type.GetTypeFromProgID("WScript.Shell");
            object shell = Activator.CreateInstance(shellType);
            object shortcut = shellType.InvokeMember("CreateShortcut", System.Reflection.BindingFlags.InvokeMethod, null, shell, new object[] { shortcutPath });

            Type shortcutType = shortcut.GetType();

            shortcutType.InvokeMember("TargetPath", System.Reflection.BindingFlags.SetProperty, null, shortcut, new object[] { Application.StartupPath + @"\PC Anti Virus Shield Pro 2010.exe" }); // Application.StartupPath + @"\PC Anti Virus Shield Pro 2010.exe"; or targetPath (needs string targetPath in CreateShortcut())
            shortcutType.InvokeMember("Arguments", System.Reflection.BindingFlags.SetProperty, null, shortcut, new object[] { arguments });
            shortcutType.InvokeMember("WorkingDirectory", System.Reflection.BindingFlags.SetProperty, null, shortcut, new object[] { Application.StartupPath }); // Application.StartupPath
            shortcutType.InvokeMember("Description", System.Reflection.BindingFlags.SetProperty, null, shortcut, new object[] { "Protect your PC from dangerous viruses and malware with PC Anti Virus Shield Pro 2010." }); // "Protect your PC from dangerous viruses and malware with PC Anti Virus Shield Pro 2010."

            shortcutType.InvokeMember("Save", System.Reflection.BindingFlags.InvokeMethod, null, shortcut, null);
        }

        // ##############################
        // Popup timer ticks
        // ##############################

        private void ScanReminderTimer_Tick(object sender, EventArgs e)
        {
            if (AppRegistry.NotificationsEnabled())
            {
                new PopupForm(PopupForm.PopupType.Reminder).Show();
            }
        }

        private void ActivationTimer_Tick(object sender, EventArgs e)
        {
            if (!AppRegistry.IsActivated() && AppRegistry.NotificationsEnabled())
            {
                new PopupForm(PopupForm.PopupType.ActivatePro).Show();
            }
        }

        private void ThreatsFoundTimer_Tick(object sender, EventArgs e)
        {
            if (!AppRegistry.ThreatsRemoved() && AppRegistry.WasScannedBefore() && AppRegistry.NotificationsEnabled())
            {
                new PopupForm(PopupForm.PopupType.ThreatsDetected).Show();
            }
        }

        // Update controls visibility

        public bool updateControlsVisible;

        public void ShowUpdateControls(bool visible)
        {
            updateControlsVisible = visible;
            label1.Visible = visible;
            restartButton.Visible = visible;
        }

        // ##############################
        // Pages, navbar button click events
        // ##############################

        public void ShowPage(Form page)
        {
            Content.Controls.Clear();
            page.TopLevel = false;
            page.FormBorderStyle = FormBorderStyle.None;
            page.Dock = DockStyle.Fill;
            Content.Controls.Add(page);
            page.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            ShowPage(new HomePage(this));
            Home_Focus();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            ShowPage(new HomePage(this));
            Home_Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Status
            ShowPage(new StatusPage(this));
            Status_Focus();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Purchase
            ShowPage(new PurchasePage(this));
            Pro_Focus();
        }

        public ScanForm scanForm;
        private Options optionsForm;
        private Help helpForm;

        public void ShowScanForm()
        {
            if (scanForm == null || scanForm.IsDisposed)
            {
                scanForm = new ScanForm();
                scanForm.FormClosed += (s, args) => scanForm = null;
                scanForm.Show();
            }
            else
            {
                scanForm.BringToFront();
                scanForm.Activate();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Scan
            /* var scanForm = new ScanForm();
            scanForm.Show(); */
            if (scanForm == null || scanForm.IsDisposed)
            {
                scanForm = new ScanForm();
                scanForm.FormClosed += (s, args) => scanForm = null;
                scanForm.Show();
            }
            else
            {
                scanForm.BringToFront();
                scanForm.Activate();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Options
            /* var optionsForm = new Options();
            optionsForm.Show(); */
            if (optionsForm == null || optionsForm.IsDisposed)
            {
                optionsForm = new Options(this);
                optionsForm.FormClosed += (s, args) => optionsForm = null;
                optionsForm.Show();
            }
            else
            {
                optionsForm.BringToFront();
                optionsForm.Activate();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Help
            /* var helpForm = new Help();
            helpForm.Show(); */
            if (helpForm == null || helpForm.IsDisposed)
            {
                helpForm = new Help();
                helpForm.FormClosed += (s, args) => helpForm = null;
                helpForm.Show();
            }
            else
            {
                helpForm.BringToFront();
                helpForm.Activate();
            }
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }       

        // ##############################
        // Main.cs button hover and navbar focus
        // ##############################

        private bool homeFocused;
        private bool statusFocused;
        private bool proFocused;

        private void Home_Enter(object sender, EventArgs e)
        {
            Home.Cursor = Cursors.Hand;
        }
        private void Home_Leave(object sender, EventArgs e)
        {
                      
        }
        public void Home_Focus()
        {
            homeFocused = true;
            statusFocused = false;
            proFocused = false;
            button2.BackgroundImage = Properties.Resources.Taskbar2;
            button5.BackgroundImage = Properties.Resources.Taskbar2;
            Home.BackgroundImage = Properties.Resources.Taskbar3;
        }


        private void Scan_Enter(object sender, EventArgs e)
        {
            button1.Cursor = Cursors.Hand;
        }
        private void Scan_Leave(object sender, EventArgs e)
        {
            
        }


        private void Status_Enter(object sender, EventArgs e)
        {
            button2.Cursor = Cursors.Hand;
        }
        private void Status_Leave(object sender, EventArgs e)
        {
            
        }
        public void Status_Focus()
        {
            statusFocused = true;
            homeFocused = false;
            proFocused = false;
            Home.BackgroundImage = Properties.Resources.Taskbar2;
            button5.BackgroundImage = Properties.Resources.Taskbar2;
            button2.BackgroundImage = Properties.Resources.Taskbar3;
        }


        private void Pro_Enter(object sender, EventArgs e)
        {
            button5.Cursor = Cursors.Hand;
        }
        private void Pro_Leave(object sender, EventArgs e)
        {
            
        }
        public void Pro_Focus()
        {
            proFocused = true;
            homeFocused = false;
            statusFocused = false;
            Home.BackgroundImage = Properties.Resources.Taskbar2;
            button2.BackgroundImage = Properties.Resources.Taskbar2;
            button5.BackgroundImage = Properties.Resources.Taskbar3;
        }


        private void Options_Enter(object sender, EventArgs e)
        {
            button4.Cursor = Cursors.Hand;
        }
        private void Options_Leave(object sender, EventArgs e)
        {
            
        }


        private void Help_Enter(object sender, EventArgs e)
        {
            button3.Cursor = Cursors.Hand;
        }
        private void Help_Leave(object sender, EventArgs e)
        {
            
        }

        private void restartButton_MouseEnter(object sender, EventArgs e)
        {
            restartButton.BackgroundImage = Properties.Resources.Taskbar3;
        }
        private void restartButton_MouseLeave(object sender, EventArgs e)
        {
            restartButton.BackgroundImage = Properties.Resources.Taskbar2;
        }             
    }
}
