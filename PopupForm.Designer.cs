namespace PC_Anti_Virus_Shield_Pro_2010
{
    partial class PopupForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dismissLink = new System.Windows.Forms.Label();
            this.popupHeader = new System.Windows.Forms.Label();
            this.popupContent = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 76);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "PC Anti Virus Shield Pro 2010";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Notification";
            // 
            // dismissLink
            // 
            this.dismissLink.AutoSize = true;
            this.dismissLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dismissLink.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.dismissLink.Location = new System.Drawing.Point(222, 83);
            this.dismissLink.Name = "dismissLink";
            this.dismissLink.Size = new System.Drawing.Size(49, 13);
            this.dismissLink.TabIndex = 2;
            this.dismissLink.Text = "Dismiss";
            this.dismissLink.Click += new System.EventHandler(this.dismissLink_Click);
            this.dismissLink.MouseEnter += new System.EventHandler(this.dismissLink_MouseEnter);
            this.dismissLink.MouseLeave += new System.EventHandler(this.dismissLink_MouseLeave);
            // 
            // popupHeader
            // 
            this.popupHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.popupHeader.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.popupHeader.Location = new System.Drawing.Point(13, 109);
            this.popupHeader.Name = "popupHeader";
            this.popupHeader.Size = new System.Drawing.Size(258, 43);
            this.popupHeader.TabIndex = 3;
            this.popupHeader.Text = "Header";
            // 
            // popupContent
            // 
            this.popupContent.Location = new System.Drawing.Point(18, 156);
            this.popupContent.Name = "popupContent";
            this.popupContent.Size = new System.Drawing.Size(253, 103);
            this.popupContent.TabIndex = 4;
            this.popupContent.Text = "Content";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(225, 209);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 50);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // PopupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 319);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.popupContent);
            this.Controls.Add(this.popupHeader);
            this.Controls.Add(this.dismissLink);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PopupForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "PopupForm";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label dismissLink;
        private System.Windows.Forms.Label popupHeader;
        private System.Windows.Forms.Label popupContent;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}