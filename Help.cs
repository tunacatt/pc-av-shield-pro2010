using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace PC_Anti_Virus_Shield_Pro_2010
{
    partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
            this.Text = String.Format("About {0}", AssemblyTitle);
        }

        #region Assembly Attribute Accessors

        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        #endregion

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("license key is GH8JK-LZX2V-NM6QE-RTY0U-YU60P btw hav fun", "License Key", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
