namespace PC_Anti_Virus_Shield_Pro_2010
{
    partial class StatusPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatusPage));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.proBox = new System.Windows.Forms.GroupBox();
            this.proBoxActivButton = new System.Windows.Forms.Button();
            this.proBoxText = new System.Windows.Forms.Label();
            this.proBoxHeader = new System.Windows.Forms.Label();
            this.proBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(98, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Attention required";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(101, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(361, 116);
            this.label2.TabIndex = 2;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-4, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(562, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "Status";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(192, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 51);
            this.button1.TabIndex = 4;
            this.button1.Text = "SCAN NOW! >>";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            // 
            // proBox
            // 
            this.proBox.Controls.Add(this.proBoxActivButton);
            this.proBox.Controls.Add(this.proBoxText);
            this.proBox.Controls.Add(this.proBoxHeader);
            this.proBox.Location = new System.Drawing.Point(12, 256);
            this.proBox.Name = "proBox";
            this.proBox.Size = new System.Drawing.Size(535, 185);
            this.proBox.TabIndex = 5;
            this.proBox.TabStop = false;
            this.proBox.Text = "Your Pro license";
            // 
            // proBoxActivButton
            // 
            this.proBoxActivButton.BackColor = System.Drawing.Color.Transparent;
            this.proBoxActivButton.BackgroundImage = global::PC_Anti_Virus_Shield_Pro_2010.Properties.Resources.Taskbar2;
            this.proBoxActivButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.proBoxActivButton.FlatAppearance.BorderSize = 0;
            this.proBoxActivButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.proBoxActivButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.proBoxActivButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.proBoxActivButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proBoxActivButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.proBoxActivButton.Location = new System.Drawing.Point(368, 19);
            this.proBoxActivButton.Name = "proBoxActivButton";
            this.proBoxActivButton.Size = new System.Drawing.Size(161, 51);
            this.proBoxActivButton.TabIndex = 5;
            this.proBoxActivButton.Text = "Activate now >>";
            this.proBoxActivButton.UseVisualStyleBackColor = false;
            this.proBoxActivButton.Click += new System.EventHandler(this.proBoxActivButton_Click);
            this.proBoxActivButton.MouseEnter += new System.EventHandler(this.proBoxActivButton_MouseEnter);
            // 
            // proBoxText
            // 
            this.proBoxText.AutoSize = true;
            this.proBoxText.Location = new System.Drawing.Point(7, 36);
            this.proBoxText.Name = "proBoxText";
            this.proBoxText.Size = new System.Drawing.Size(334, 13);
            this.proBoxText.TabIndex = 4;
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
            this.proBoxHeader.TabIndex = 3;
            this.proBoxHeader.Text = "PC Anti Virus Shield Pro 2010 is not activated";
            // 
            // StatusPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 453);
            this.Controls.Add(this.proBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StatusPage";
            this.Text = "StatusPage";
            this.proBox.ResumeLayout(false);
            this.proBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox proBox;
        private System.Windows.Forms.Button proBoxActivButton;
        private System.Windows.Forms.Label proBoxText;
        private System.Windows.Forms.Label proBoxHeader;
    }
}