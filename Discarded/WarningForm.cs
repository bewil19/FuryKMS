using FuryKMS.Languages;
using Microsoft.Win32;
using System;
using System.Windows.Forms;
using FontAwesome.Sharp;
using FuryKMS.Properties;

namespace FuryKMS.Batchs
{
    public partial class WarningForm : Form
    {
        public WarningForm()
        {
            InitializeComponent();
        }
        private void WarningForm_Load(object sender, EventArgs e)
        {
            this.Text = Lang.warningText;
            string RegistryWinPath = @"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion";
            string osName = Registry.GetValue(RegistryWinPath, "productName", "").ToString();
            osLbl.Text = Lang.osLbl1 + osName + "," + Lang.osLbl2;

            if (osName.Contains("Windows 8") || osName.Contains("Windows 8.1"))
            {
                viiLogo.Enabled = false;
                viiLogo.Visible = false;
            }
            if (osName.Contains("Windows 7"))
            {
                windowsIcon.Enabled = false;
                windowsIcon.Visible = false;
            }
        }
    }
}