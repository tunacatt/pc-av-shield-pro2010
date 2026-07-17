using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PC_Anti_Virus_Shield_Pro_2010
{
    public partial class ScanForm : Form
    {
        private enum ScanState
        {
            NotScanned,
            Scanning,
            Scanned,
            ScannedNoThreats
        }

        private ScanState currentScanState = (AppRegistry.ThreatsRemoved() && AppRegistry.IsActivated() && AppRegistry.WasScannedBefore()) ? ScanState.ScannedNoThreats : ScanState.Scanned;

        public ScanForm()
        {
            InitializeComponent();

            dataGridViewThreats.Columns.Clear();

            var colName = new DataGridViewTextBoxColumn
            {
                Name = "Name",
                HeaderText = "Name",
                FillWeight = 80
            };
            var colSize = new DataGridViewTextBoxColumn
            {
                Name = "Size",
                HeaderText = "Size",
                FillWeight = 14
            };
            var colPath = new DataGridViewTextBoxColumn
            {
                Name = "Path",
                HeaderText = "Path",
                FillWeight = 110
            };

            dataGridViewThreats.Columns.AddRange(colName, colSize, colPath);

            dataGridViewThreats.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // currentScanState = ScanState.NotScanned;
            if (AppRegistry.WasScannedBefore() && !AppRegistry.ThreatsRemoved())
            {
                currentScanState = ScanState.Scanned;
            }
            else if (AppRegistry.ThreatsRemoved() && AppRegistry.IsActivated() && AppRegistry.WasScannedBefore())
            {
                currentScanState = ScanState.ScannedNoThreats;
                // threats.Clear();
                threats = null;
            }
            else
            {
                currentScanState = ScanState.NotScanned;
            }
            UpdateScanStatusPanel();
        }

        private Color gradientColor1;
        private Color gradientColor2;

        private Color yellowGradient1 = Color.Yellow;
        private Color yellowGradient2 = Color.LightYellow;

        private Color redGradient1 = Color.Red;
        private Color redGradient2 = Color.OrangeRed;

        private Color greenGradient1 = Color.Green;
        private Color greenGradient2 = Color.LightGreen;

        private void DrawPanelGradient(Panel panel, PaintEventArgs e, Color color1, Color color2)
        {
            using (Brush brush = new LinearGradientBrush(
                panel.ClientRectangle,
                color1,
                color2,
                LinearGradientMode.Horizontal))
            {
                e.Graphics.FillRectangle(brush, panel.ClientRectangle);
            }
        }

        private void scanStatusPanel_Paint(object sender, PaintEventArgs e)
        {
            DrawPanelGradient(scanStatusPanel, e, gradientColor1, gradientColor2);
        }

        public void SetPanelGradient(Color color1, Color color2)
        {
            gradientColor1 = color1;
            gradientColor2 = color2;
        }

        

        private void UpdateScanStatusPanel()
        {
            switch(currentScanState)
            {
                case ScanState.NotScanned:
                    scanStatusTitle.Text = "Important: Scan your PC now!";
                    scanStatusTitle.ForeColor = Color.White;
                    scanStatusText.Text = "Your PC has not been scanned yet. Please run a scan to ensure your system is safe from dangerous viruses.";
                    scanStatusText.ForeColor = Color.White;
                    // SetPanelGradient(redGradient1, redGradient2);
                    // scanStatusPanel.BackColor = Color.DarkRed; // Red background
                    scanStatusPanel.BackgroundImage = Properties.Resources.RedBar;
                    button1.Enabled = true; // Start scan button
                    label1.Visible = false;
                    dataGridViewThreats.Visible = false;
                    removeThreatsButton.Visible = false;
                    proWarn.Visible = false;
                    break;
                case ScanState.Scanning:
                    scanStatusTitle.Text = "Scanning in progress...";
                    scanStatusTitle.ForeColor = Color.White;
                    scanStatusText.Text = "Your PC is currently being scanned for threats. Please wait until the scan is complete.";
                    scanStatusText.ForeColor = Color.White;
                    // SetPanelGradient(yellowGradient1, yellowGradient2);
                    // scanStatusPanel.BackColor = Color.DarkOrange; // Yellow background
                    scanStatusPanel.BackgroundImage = Properties.Resources.YellowBar;
                    button1.Enabled = false;
                    label1.Visible = true;
                    dataGridViewThreats.Visible = true;
                    removeThreatsButton.Visible = false;
                    proWarn.Visible = false;
                    break;
                case ScanState.Scanned:
                    scanStatusTitle.Text = "Your PC is in danger! 11 threats found";
                    scanStatusTitle.ForeColor = Color.White;
                    scanStatusText.Text = "Your PC has been scanned. 11 critical threats were found. Remove them to restore your computer to optimal performance and protect your personal data. Click 'REMOVE THREATS' to proceed.";
                    scanStatusText.ForeColor = Color.White;
                    // SetPanelGradient(redGradient1, redGradient2);
                    // scanStatusPanel.BackColor = Color.DarkRed; // Red background
                    scanStatusPanel.BackgroundImage = Properties.Resources.RedBar;
                    button1.Enabled = true; // Start scan button
                    label1.Visible = true;
                    dataGridViewThreats.Visible = true;
                    removeThreatsButton.Visible = true;
                    if (AppRegistry.IsActivated())
                    {
                        removeThreatsButton.Enabled = true;
                        proWarn.Visible = false;
                    }
                    else
                    {
                        removeThreatsButton.Enabled = false;
                        proWarn.Visible = true;
                    }
                    break;
                case ScanState.ScannedNoThreats:
                    scanStatusTitle.Text = "Your PC is safe! No threats found";
                    scanStatusTitle.ForeColor = Color.White;
                    scanStatusText.Text = "Your PC has been scanned. No threats were found. Your computer is safe and protected.";
                    scanStatusText.ForeColor = Color.White;
                    // SetPanelGradient(greenGradient1, greenGradient2);
                    // scanStatusPanel.BackColor = Color.DarkGreen; // Green background
                    scanStatusPanel.BackgroundImage = Properties.Resources.GreenBar;
                    button1.Enabled = true; // Start scan button
                    label1.Visible = false;
                    dataGridViewThreats.Visible = false;
                    removeThreatsButton.Visible = false;
                    proWarn.Visible = false;
                    break;
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (scanTimer != null)
            {
                scanTimer.Stop();
                scanTimer.Tick -= ScanTimer_Tick;
                scanTimer.Dispose();
            }
            base.OnFormClosing(e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridViewThreats.Rows.Clear();
            progressBarScan.Value = 0;
            scanSeconds = 0;

            scanTimer = new Timer();
            scanTimer.Interval = 1000;
            scanTimer.Tick += ScanTimer_Tick;
            scanTimer.Start();
            button1.Enabled = false;
            currentScanState = ScanState.Scanning;
            UpdateScanStatusPanel();
        }

        private void ScanTimer_Tick(object sender, EventArgs e)
        {
            if (dataGridViewThreats.Columns.Count == 0) return;

            scanSeconds++;
            progressBarScan.Value = scanSeconds;

            if (threats != null)
            {
                // shows threats every 11 seconds
                int threatsToShow = Math.Min(scanSeconds / 11, threats.Count);
                dataGridViewThreats.Rows.Clear();
                for (int i = 0; i < threatsToShow; i++)
                {
                    var t = threats[i];
                    dataGridViewThreats.Rows.Add(t.Name, t.Size, t.Path);
                }
            }
            
            if (scanSeconds >= 120)
            {
                scanTimer.Stop();
                // Show all threats at the end
                dataGridViewThreats.Rows.Clear();
                if (threats != null)
                {
                    foreach (var t in threats)
                        dataGridViewThreats.Rows.Add(t.Name, t.Size, t.Path);
                }                

                // MessageBox.Show("Scan complete! 11 threats found.", "Scan Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (AppRegistry.ThreatsRemoved() && AppRegistry.IsActivated())
                {
                    currentScanState = ScanState.ScannedNoThreats;
                }
                else
                {
                    currentScanState = ScanState.Scanned;
                }
                UpdateScanStatusPanel();
                button1.Enabled = true;
                AppRegistry.SetWasScannedBefore(true);
            }
        }

        private void removeThreatsButton_Click(object sender, EventArgs e)
        {
            AppRegistry.RemoveThreats(true);
            AppRegistry.SetWasScannedBefore(true);
            MessageBox.Show("11 threats have been removed successfully.", "Threats Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            currentScanState = ScanState.ScannedNoThreats;
            UpdateScanStatusPanel();
        }

        private void removeThreatsButton_MouseEnter(object sender, EventArgs e)
        {
            removeThreatsButton.Cursor = Cursors.Hand;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.Cursor = Cursors.Hand;
        }
    }
}
