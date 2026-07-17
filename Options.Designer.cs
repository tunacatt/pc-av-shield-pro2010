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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dirTextBox = new System.Windows.Forms.TextBox();
            this.copyDirBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.proBoxHeader = new System.Windows.Forms.Label();
            this.proBoxText = new System.Windows.Forms.Label();
            this.proBoxText1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            // dirTextBox
            // 
            this.dirTextBox.Location = new System.Drawing.Point(6, 20);
            this.dirTextBox.Name = "dirTextBox";
            this.dirTextBox.ReadOnly = true;
            this.dirTextBox.Size = new System.Drawing.Size(499, 20);
            this.dirTextBox.TabIndex = 0;
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Location = new System.Drawing.Point(13, 201);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(567, 100);
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
            // proBoxText
            // 
            this.proBoxText.AutoSize = true;
            this.proBoxText.Location = new System.Drawing.Point(7, 36);
            this.proBoxText.Name = "proBoxText";
            this.proBoxText.Size = new System.Drawing.Size(334, 13);
            this.proBoxText.TabIndex = 2;
            this.proBoxText.Text = "Please activate to unlock full protection and prevent future infections.";
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
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(592, 394);
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
    }
}