using System.Collections.Generic;
using System;

namespace PC_Anti_Virus_Shield_Pro_2010
{
    partial class ScanForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridViewThreats = new System.Windows.Forms.DataGridView();
            this.progressBarScan = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.scanTimer = new System.Windows.Forms.Timer(this.components);
            this.scanStatusPanel = new System.Windows.Forms.Panel();
            this.proWarn = new System.Windows.Forms.Label();
            this.removeThreatsButton = new System.Windows.Forms.Button();
            this.scanStatusText = new System.Windows.Forms.Label();
            this.scanStatusTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThreats)).BeginInit();
            this.scanStatusPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewThreats
            // 
            this.dataGridViewThreats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewThreats.Location = new System.Drawing.Point(13, 178);
            this.dataGridViewThreats.Name = "dataGridViewThreats";
            this.dataGridViewThreats.Size = new System.Drawing.Size(567, 204);
            this.dataGridViewThreats.TabIndex = 0;
            // 
            // progressBarScan
            // 
            this.progressBarScan.Location = new System.Drawing.Point(13, 133);
            this.progressBarScan.Maximum = 120;
            this.progressBarScan.Name = "progressBarScan";
            this.progressBarScan.Size = new System.Drawing.Size(567, 23);
            this.progressBarScan.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::PC_Anti_Virus_Shield_Pro_2010.Properties.Resources.Taskbar2;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(460, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "Start Scan";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Threats:";
            // 
            // scanStatusPanel
            // 
            this.scanStatusPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.scanStatusPanel.Controls.Add(this.proWarn);
            this.scanStatusPanel.Controls.Add(this.removeThreatsButton);
            this.scanStatusPanel.Controls.Add(this.scanStatusText);
            this.scanStatusPanel.Controls.Add(this.scanStatusTitle);
            this.scanStatusPanel.Location = new System.Drawing.Point(-1, 0);
            this.scanStatusPanel.Name = "scanStatusPanel";
            this.scanStatusPanel.Size = new System.Drawing.Size(595, 86);
            this.scanStatusPanel.TabIndex = 4;
            // 
            // proWarn
            // 
            this.proWarn.AutoSize = true;
            this.proWarn.BackColor = System.Drawing.Color.Transparent;
            this.proWarn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.proWarn.Location = new System.Drawing.Point(254, 59);
            this.proWarn.Name = "proWarn";
            this.proWarn.Size = new System.Drawing.Size(327, 13);
            this.proWarn.TabIndex = 3;
            this.proWarn.Text = "Please purchase and activate your Pro license to remove all threats.";
            this.proWarn.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // removeThreatsButton
            // 
            this.removeThreatsButton.BackColor = System.Drawing.Color.Transparent;
            this.removeThreatsButton.BackgroundImage = global::PC_Anti_Virus_Shield_Pro_2010.Properties.Resources.Taskbar2;
            this.removeThreatsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.removeThreatsButton.FlatAppearance.BorderSize = 0;
            this.removeThreatsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.removeThreatsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.removeThreatsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeThreatsButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeThreatsButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.removeThreatsButton.Location = new System.Drawing.Point(461, 23);
            this.removeThreatsButton.Name = "removeThreatsButton";
            this.removeThreatsButton.Size = new System.Drawing.Size(120, 33);
            this.removeThreatsButton.TabIndex = 2;
            this.removeThreatsButton.Text = "Remove Threats";
            this.removeThreatsButton.UseVisualStyleBackColor = false;
            this.removeThreatsButton.Click += new System.EventHandler(this.removeThreatsButton_Click);
            this.removeThreatsButton.MouseEnter += new System.EventHandler(this.removeThreatsButton_MouseEnter);
            // 
            // scanStatusText
            // 
            this.scanStatusText.BackColor = System.Drawing.Color.Transparent;
            this.scanStatusText.Location = new System.Drawing.Point(9, 33);
            this.scanStatusText.Name = "scanStatusText";
            this.scanStatusText.Size = new System.Drawing.Size(446, 39);
            this.scanStatusText.TabIndex = 1;
            this.scanStatusText.Text = "text";
            // 
            // scanStatusTitle
            // 
            this.scanStatusTitle.AutoSize = true;
            this.scanStatusTitle.BackColor = System.Drawing.Color.Transparent;
            this.scanStatusTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scanStatusTitle.ForeColor = System.Drawing.SystemColors.Info;
            this.scanStatusTitle.Location = new System.Drawing.Point(4, 4);
            this.scanStatusTitle.Name = "scanStatusTitle";
            this.scanStatusTitle.Size = new System.Drawing.Size(46, 25);
            this.scanStatusTitle.TabIndex = 0;
            this.scanStatusTitle.Text = "title";
            // 
            // ScanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 394);
            this.Controls.Add(this.scanStatusPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBarScan);
            this.Controls.Add(this.dataGridViewThreats);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ScanForm";
            this.ShowIcon = false;
            this.Text = "Scan";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThreats)).EndInit();
            this.scanStatusPanel.ResumeLayout(false);
            this.scanStatusPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewThreats;
        private System.Windows.Forms.ProgressBar progressBarScan;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Timer scanTimer;

        private int scanSeconds = 0;        
        public List<(string Name, string Size, string Path)> threats = new List<(string, string, string)>
        {
            ("Backdoor:Win32/DarkComet.RAT", "847MB", @"C:\Windows\svhost.exe"),
            ("Ransom:Win32/LockBit.C!MTB", "412MB", @"C:\Users\Administrator\AppData\Roaming\winupdate32.exe"),
            ("Trojan:Win32/NanoCore.RAT!ml", "156MB", @"C:\Users\Administrator\AppData\Local\Temp\adobe_reader_upd.exe"),
            ("Adware:Win32/InstallCore.E", "23MB", @"C:\Users\Administrator\AppData\Roaming\browser_helper.exe"),
            ("Ransom:MSIL/Conti.A!MTB", "689MB", @"C:\Windows\lsasss.exe"),
            ("Backdoor:MSIL/AsyncRAT!ms", "94MB", @"C:\Users\Administrator\AppData\Roaming\javaw_update.exe"),
            ("Rootkit:Win32/Necurs.A", "331MB", @"C:\Windows\drivers\rundll32s.exe"),
            ("Trojan:Win32/RemcosRAT!ml", "78MB", @"C:\Users\Administrator\AppData\Local\Temp\office_setup.exe"),
            ("Ransom:Win64/BlackMatter.A", "998MB", @"C:\Windows\explorer64.exe"),
            ("Spyware:Win32/Agent.Keylog", "12MB", @"C:\Users\Administrator\AppData\Roaming\onedrive_sync.exe"),
            ("Adware:Win32/DealPly.B!ml", "205MB", @"C:\Users\Administrator\AppData\Local\Temp\flashplayer_inst.exe")
        };
        private System.Windows.Forms.Panel scanStatusPanel;
        private System.Windows.Forms.Label scanStatusTitle;
        private System.Windows.Forms.Button removeThreatsButton;
        private System.Windows.Forms.Label scanStatusText;
        private System.Windows.Forms.Label proWarn;
    }
}