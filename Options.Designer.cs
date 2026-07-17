namespace PC_Anti_Virus_Shield_Pro_2010
{
    partial class Options
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.proBoxText1 = new System.Windows.Forms.Label();
            this.proBoxText = new System.Windows.Forms.Label();
            this.proBoxHeader = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.copyDirBtn = new System.Windows.Forms.Button();
            this.dirTextBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.debugPassBox = new System.Windows.Forms.TextBox();
            this.switchPro = new System.Windows.Forms.CheckBox();
            this.threatsRemovedSetting = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.proBoxText1);
            this.groupBox1.Controls.Add(this.proBoxText);
            this.groupBox1.Controls.Add(this.proBoxHeader);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(567, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Your Pro license";
            // 
            // proBoxText1
            // 
            this.proBoxText1.AutoSize = true;
            this.proBoxText1.Location = new System.Drawing.Point(10, 53);
            this.proBoxText1.Name = "proBoxText1";
            this.proBoxText1.Size = new System.Drawing.Size(263, 13);
            this.proBoxText1.TabIndex = 3;
            this.proBoxText1.Text = "You must activate before you can change the options.";
            // 
            // proBoxText
            // 
            this.proBoxText.AutoSize = true;
            this.proBoxText.Location = new System.Drawing.Point(7, 36);
            this.proBoxText.Name = "proBoxText";
            this.proBoxText.Size = new System.Drawing.Size(334, 13);
            this.proBoxText.TabIndex = 2;
            this.proBoxText.Text = "Please activate to unlock full protection and prevent future infections.";
            // 
            // proBoxHeader
            // 
            this.proBoxHeader.AutoSize = true;
            this.proBoxHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proBoxHeader.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.proBoxHeader.Location = new System.Drawing.Point(6, 16);
            this.proBoxHeader.Name = "proBoxHeader";
            this.proBoxHeader.Size = new System.Drawing.Size(351, 20);
            this.proBoxHeader.TabIndex = 1;
            this.proBoxHeader.Text = "PC Anti Virus Shield Pro 2010 is not activated";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.copyDirBtn);
            this.groupBox2.Controls.Add(this.dirTextBox);
            this.groupBox2.Location = new System.Drawing.Point(13, 120);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(567, 74);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Directory";
            // 
            // copyDirBtn
            // 
            this.copyDirBtn.Location = new System.Drawing.Point(511, 20);
            this.copyDirBtn.Name = "copyDirBtn";
            this.copyDirBtn.Size = new System.Drawing.Size(56, 23);
            this.copyDirBtn.TabIndex = 1;
            this.copyDirBtn.Text = "Copy";
            this.copyDirBtn.UseVisualStyleBackColor = true;
            this.copyDirBtn.Click += new System.EventHandler(this.copyDirBtn_Click);
            // 
            // dirTextBox
            // 
            this.dirTextBox.Location = new System.Drawing.Point(6, 20);
            this.dirTextBox.Name = "dirTextBox";
            this.dirTextBox.ReadOnly = true;
            this.dirTextBox.Size = new System.Drawing.Size(499, 20);
            this.dirTextBox.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Location = new System.Drawing.Point(13, 201);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(273, 93);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tweaks";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(6, 20);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(114, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Show Notifications";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button5);
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.threatsRemovedSetting);
            this.groupBox4.Controls.Add(this.switchPro);
            this.groupBox4.Controls.Add(this.debugPassBox);
            this.groupBox4.Location = new System.Drawing.Point(293, 201);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(287, 93);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Testing";
            // 
            // debugPassBox
            // 
            this.debugPassBox.Location = new System.Drawing.Point(7, 20);
            this.debugPassBox.Name = "debugPassBox";
            this.debugPassBox.Size = new System.Drawing.Size(124, 20);
            this.debugPassBox.TabIndex = 0;
            this.debugPassBox.TextChanged += new System.EventHandler(this.debugPassBox_TextChanged);
            // 
            // switchPro
            // 
            this.switchPro.AutoSize = true;
            this.switchPro.Location = new System.Drawing.Point(196, 22);
            this.switchPro.Name = "switchPro";
            this.switchPro.Size = new System.Drawing.Size(81, 17);
            this.switchPro.TabIndex = 1;
            this.switchPro.Text = "ProEnabled";
            this.switchPro.UseVisualStyleBackColor = true;
            this.switchPro.CheckedChanged += new System.EventHandler(this.switchPro_CheckedChanged);
            // 
            // threatsRemovedSetting
            // 
            this.threatsRemovedSetting.AutoSize = true;
            this.threatsRemovedSetting.Location = new System.Drawing.Point(7, 47);
            this.threatsRemovedSetting.Name = "threatsRemovedSetting";
            this.threatsRemovedSetting.Size = new System.Drawing.Size(108, 17);
            this.threatsRemovedSetting.TabIndex = 2;
            this.threatsRemovedSetting.Text = "ThreatsRemoved";
            this.threatsRemovedSetting.UseVisualStyleBackColor = true;
            this.threatsRemovedSetting.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(121, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Close app";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(202, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Restart app";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "CHEATER!!";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(121, 63);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(52, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(179, 64);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(98, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "Remove startup";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(137, 20);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(35, 23);
            this.button5.TabIndex = 8;
            this.button5.Text = "OK";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(126, 16);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(122, 23);
            this.button6.TabIndex = 8;
            this.button6.Text = "Don\'t run on startup";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button4_Click);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(592, 394);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Options";
            this.ShowIcon = false;
            this.Text = "Options";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button copyDirBtn;
        private System.Windows.Forms.TextBox dirTextBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label proBoxHeader;
        private System.Windows.Forms.Label proBoxText;
        private System.Windows.Forms.Label proBoxText1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox threatsRemovedSetting;
        private System.Windows.Forms.CheckBox switchPro;
        private System.Windows.Forms.TextBox debugPassBox;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}