using FontAwesome.Sharp;
using FuryKMS.Languages;
using FuryKMS.Properties;
using Microsoft.Win32;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace FuryKMS.UserControls
{
    public partial class Windows : UserControl
    {
        private void Windows_Load(object sender, EventArgs e)
        {
            LoadLanguage();
            DropDownManager();
            ComboBoxManager();
            homeDrop.Enabled = false;

            string workPath = @"C:\Windows\system32";
            Directory.SetCurrentDirectory(workPath);

            string RegistryWinPath = @"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion";
            string osName = Registry.GetValue(RegistryWinPath, "productName", "").ToString();
            string osDisplayVer = Registry.GetValue(RegistryWinPath, "displayVersion", "").ToString();
            string osBuild = Registry.GetValue(RegistryWinPath, "currentBuildNumber", "").ToString();
            string osUBR = Registry.GetValue(RegistryWinPath, "ubr", "").ToString();
            string osType = Environment.Is64BitOperatingSystem ? "64-bit" : "32-bit";
            string osEdition = Registry.GetValue(RegistryWinPath, "editionID", "").ToString();
            string organization = Registry.GetValue(RegistryWinPath, "registeredOrganization", "").ToString();
            string owner = Registry.GetValue(RegistryWinPath, "registeredOwner", "").ToString();
            if (osName.Contains("Windows 11"))
            {
                if (Convert.ToInt32(osBuild) >= 22000)
                {
                    windowsLogo.IconChar = IconChar.Microsoft;
                }
                else
                {
                    windowsLogo.IconChar = IconChar.Windows;
                }
            }
            if (organization.Contains(""))
            {
                orgLbl.Text = Lang.orgLbl + "N/A";
            }
            else
            {
                orgLbl.Text = Lang.orgLbl + organization;
            }
            productLbl.Text = "Microsoft " + osName + " " + osDisplayVer + " (" + osBuild + "." + osUBR + ") " + osType;
            editionLlb.Text = "Edition ID: " + osEdition;
            ownerLbl.Text = Lang.ownerLbl + owner;
        }
        public Windows()
        {
            InitializeComponent();
        }

        public void LoadLanguage()
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(Settings.Default.Language);
            productsLbl.Text = Lang.productsLbl;
            licensesLbl.Text = Lang.licensesLbl;
            kmsLbl.Text = Lang.kmsLbl;
            productsDrop.Text = Lang.productsDrop;
            activateBtn.Text = Lang.activateBtn;
            infoBtn.Text = Lang.infoBtn;
            removeBtn.Text = Lang.removeBtn;
        }

        private string RunCommands(string script)
        {
            Runspace rs = RunspaceFactory.CreateRunspace();
            rs.Open();
            Pipeline pip = rs.CreatePipeline();
            pip.Commands.AddScript(script);
            pip.Commands.Add("Out-string");
            Collection<PSObject> results = pip.Invoke();
            rs.Close();
            StringBuilder builder = new StringBuilder();
            foreach (PSObject pSObject in results)
                builder.AppendLine(pSObject.ToString());
            return builder.ToString();
        }

        private void activateBtn_Click(object sender, EventArgs e)
        {
            WindowsHome();
            WindowsPro();
            WindowsEducation();
            WindowsEnterprise();
        }
        private void infoBtn_Click(object sender, EventArgs e)
        {
            shellText.Text = RunCommands("cscript //nologo slmgr.vbs /dli; cscript //nologo slmgr.vbs /xpr");
        }
        private void removeBtn_Click(object sender, EventArgs e)
        {
            shellText.Text = RunCommands("cscript //nologo slmgr.vbs /upk; cscript //nologo slmgr.vbs /cpky");
        }
        private void ActivationCommands()
        {
            switch (serversDrop.SelectedIndex)
            {
                case 0:
                    try
                    {
                        string directory = Directory.GetCurrentDirectory() + @"Batchs";
                        if (!Directory.Exists(directory))
                            Directory.CreateDirectory(directory);

                        var batFileName = Path.Combine(directory, "Auto.bat");
                        File.Delete(batFileName);

                        using (FileStream stream =
                            new FileStream(batFileName, FileMode.CreateNew, FileAccess.Write))
                        {
                            var bytes = Resources.WinAutoKMS;
                            stream.Write(bytes, 0, bytes.Length);
                        }
                        Process.Start(batFileName);
                    }
                    catch { }
                    break;

                case 1:
                    shellText.Text = RunCommands("cscript //nologo slmgr.vbs /skms s8.uk.to; cscript //nologo slmgr.vbs /ato");
                    break;

                case 2:
                    shellText.Text = RunCommands("cscript //nologo slmgr.vbs /skms s9.us.to; cscript //nologo slmgr.vbs /ato");
                    break;
                // DEPRECATED | USE ONLY IN CASE OF EMERGENCY
                case 3:
                    shellText.Text = RunCommands("cscript //nologo slmgr.vbs /skms kms8.msguides.com; cscript //nologo slmgr.vbs /ato");
                    break;

                case 4:
                    shellText.Text = RunCommands("cscript //nologo slmgr.vbs /skms kms9.msguides.com; cscript //nologo slmgr.vbs /ato");
                    break;
            }
        }

        private void DropDownManager()
        {
            activateBtn.Enabled = false;
            proDrop.Text = Lang.licencesText;
            homeDrop.Text = Lang.licencesText;
            educationDrop.Text = Lang.licencesText;
            enterpriseDrop.Text = Lang.licencesText;
            serversDrop.Text = Lang.serversDrop;
        }
        private void ComboBoxManager()
        {
            homeDrop.Enabled = true;
            homeDrop.Visible = true;
            proDrop.Enabled = false;
            proDrop.Visible = false;
            educationDrop.Enabled = false;
            educationDrop.Visible = false;
            enterpriseDrop.Enabled = false;
            enterpriseDrop.Visible = false;
        }

        private void WindowsHome()
        {
            switch (homeDrop.SelectedIndex)
            {
                case 0:
                    shellText.Text = RunCommands("cscript //nologo slmgr.vbs /ipk YTMG3-N6DKC-DKB77-7M9GH-8HVX7");
                    ActivationCommands();
                    break;

                case 1:
                    shellText.Text = RunCommands("cscript //nologo slmgr.vbs /ipk TX9XD-98N7V-6WMQ6-BX7FG-H8Q99");
                    ActivationCommands();
                    break;

                case 2:
                    shellText.Text = RunCommands("cscript //nologo slmgr.vbs /ipk 4CPRK-NM3K3-X6XXQ-RXX86-WXCHW");
                    ActivationCommands();
                    break;

                case 3:
                    shellText.Text = RunCommands("cscript //nologo slmgr.vbs /ipk 3KHY7-WNT83-DGQKR-F7HPR-844BM");
                    ActivationCommands();
                    break;

                case 4:
                    shellText.Text = RunCommands("cscript //nologo slmgr.vbs /ipk BT79Q-G7N6G-PGBYW-4YWX6-6F4BT");
                    ActivationCommands();
                    break;

                case 5:
                    shellText.Text = RunCommands("cscript //nologo slmgr.vbs /ipk 7HNRX-D7KGG-3K4RQ-4WPJ4-YTDFH");
                    ActivationCommands();
                    break;
            }
        }
        private void WindowsPro()
        {
            switch (proDrop.SelectedIndex)
            {
                case 0:
                    shellText.Text = RunCommands("cscript //nologo slmgr.vbs /ipk VK7JG-NPHTM-C97JM-9MPGT-3V66T");
                    ActivationCommands();
                    break;

                case 1:
                    shellText.Text = RunCommands("cscript //nologo slmgr.vbs /ipk W269N-WFGWX-YVC9B-4J6C9-T83GX");
                    ActivationCommands();
                    break;

                case 2:
                    shellText.Text = RunCommands("cscript //nologo slmgr.vbs /ipk 2B87N-8KFHP-DKV6R-Y2C8J-PKCKT");
                    ActivationCommands();
                    break;

                case 3:
                    shellText.Text = RunCommands("cscript //nologo slmgr.vbs /ipk MH37W-N47XK-V7XM9-C7227-GCQG9");
                    ActivationCommands();
                    break;

                case 4:
                    shellText.Text = RunCommands("cscript //nologo slmgr.vbs /ipk DXG7C-N36C4-C4HTG-X4T3X-2YV77");
                    ActivationCommands();
                    break;

                case 5:
                    shellText.Text = RunCommands("cscript //nologo slmgr.vbs /ipk NRG8B-VKK3Q-CXVCJ-9G2XF-6Q84J");
                    ActivationCommands();
                    break;

                case 6:
                    shellText.Text = RunCommands("cscript //nologo slmgr.vbs /ipk WYPNQ-8C467-V2W6J-TX4WX-WT2RQ");
                    ActivationCommands();
                    break;

                case 7:
                    shellText.Text = RunCommands("cscript //nologo slmgr.vbs /ipk 9FNHH-K3HBT-3W4TD-6383H-6XYWF");
                    ActivationCommands();
                    break;
            }
        }
        private void WindowsEducation()
        {
            switch (educationDrop.SelectedIndex)
            {
                case 0:
                    shellText.Text = RunCommands("cscript //nologo slmgr.vbs /ipk YNMGQ-8RYV3-4PGQ3-C8XTP-7CFBY");
                    ActivationCommands();
                    break;

                case 1:
                    shellText.Text = RunCommands("cscript //nologo slmgr.vbs /ipk NW6C2-QMPVW-D7KKK-3GKT6-VCFB2");
                    ActivationCommands();
                    break;

                case 2:
                    shellText.Text = RunCommands("cscript //nologo slmgr.vbs /ipk 84NGF-MHBT6-FXBX8-QWJK7-DRR8H");
                    ActivationCommands();
                    break;

                case 3:
                    shellText.Text = RunCommands("cscript //nologo slmgr.vbs /ipk 2WH4N-8QGBV-H22JP-CT43Q-MDWWJ");
                    ActivationCommands();
                    break;

                case 4:
                    shellText.Text = RunCommands("cscript //nologo slmgr.vbs /ipk 8PTT6-RNW4C-6V7J2-C2D3X-MHBPB");
                    ActivationCommands();
                    break;

                case 5:
                    shellText.Text = RunCommands("cscript //nologo slmgr.vbs /ipk 6TP4R-GNPTD-KYYHQ-7B7DP-J447Y");
                    ActivationCommands();
                    break;

                case 6:
                    shellText.Text = RunCommands("cscript //nologo slmgr.vbs /ipk GJTYN-HDMQY-FRR76-HVGC7-QPF8P");
                    ActivationCommands();
                    break;

                case 7:
                    shellText.Text = RunCommands("cscript //nologo slmgr.vbs /ipk YVWGF-BXNMC-HTQYQ-CPQ99-66QFC");
                    ActivationCommands();
                    break;
            }
        }
        private void WindowsEnterprise()
        {
            switch (enterpriseDrop.SelectedIndex)
            {
                case 0:
                    shellText.Text = RunCommands("cscript //nologo slmgr.vbs /ipk XGVPP-NMH47-7TTHJ-W3FW7-8HV2C");
                    ActivationCommands();
                    break;

                case 1:
                    shellText.Text = RunCommands("cscript //nologo slmgr.vbs /ipk NPPR9-FWDCX-D2C8J-H872K-2YT43");
                    ActivationCommands();
                    break;

                case 2:
                    shellText.Text = RunCommands("cscript //nologo slmgr.vbs /ipk YYVX9-NTFWV-6MDM3-9PT4T-4M68B");
                    ActivationCommands();
                    break;

                case 3:
                    shellText.Text = RunCommands("cscript //nologo slmgr.vbs /ipk FW7NV-4T673-HF4VX-9X4MM-B4H4T");
                    ActivationCommands();
                    break;

                case 4:
                    shellText.Text = RunCommands("cscript //nologo slmgr.vbs /ipk 44RPN-FTY23-9VTTB-MP9BX-T84FV");
                    ActivationCommands();
                    break;

                case 5:
                    shellText.Text = RunCommands("cscript //nologo slmgr.vbs /ipk WGGHN-J84D6-QYCPR-T7PJ7-X766F");
                    ActivationCommands();
                    break;

                case 6:
                    shellText.Text = RunCommands("cscript //nologo slmgr.vbs /ipk DPH2V-TTNVB-4X9Q3-TJR4H-KHJW4");
                    ActivationCommands();
                    break;
            }
        }

        private void productsDrop_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (productsDrop.SelectedIndex)
            {
                case 0:
                    DropDownManager();
                    ComboBoxManager();
                    serversDrop.Enabled = false;
                    break;

                case 1:
                    DropDownManager();
                    homeDrop.Enabled = false;
                    homeDrop.Visible = false;
                    proDrop.Enabled = true;
                    proDrop.Visible = true;
                    educationDrop.Enabled = false;
                    educationDrop.Visible = false;
                    enterpriseDrop.Enabled = false;
                    enterpriseDrop.Visible = false;
                    serversDrop.Enabled = false;
                    break;

                case 2:
                    DropDownManager();
                    homeDrop.Enabled = false;
                    homeDrop.Visible = false;
                    proDrop.Enabled = false;
                    proDrop.Visible = false;
                    educationDrop.Enabled = true;
                    educationDrop.Visible = true;
                    enterpriseDrop.Enabled = false;
                    enterpriseDrop.Visible = false;
                    serversDrop.Enabled = false;
                    break;

                case 3:
                    DropDownManager();
                    homeDrop.Enabled = false;
                    homeDrop.Visible = false;
                    proDrop.Enabled = false;
                    proDrop.Visible = false;
                    educationDrop.Enabled = false;
                    educationDrop.Visible = false;
                    enterpriseDrop.Enabled = true;
                    enterpriseDrop.Visible = true;
                    serversDrop.Enabled = false;
                    break;
            }
        }

        private void homeDrop_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (homeDrop.SelectedIndex)
            {
                case 0:
                    serversDrop.Enabled = true;
                    break;
                case 1:
                    serversDrop.Enabled = true;
                    break;
                case 2:
                    serversDrop.Enabled = true;
                    break;
                case 3:
                    serversDrop.Enabled = true;
                    break;
                case 4:
                    serversDrop.Enabled = true;
                    break;
                case 5:
                    serversDrop.Enabled = true;
                    break;
            }
        }
        private void proDrop_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (proDrop.SelectedIndex)
            {
                case 0:
                    serversDrop.Enabled = true;
                    break;
                case 1:
                    serversDrop.Enabled = true;
                    break;
                case 2:
                    serversDrop.Enabled = true;
                    break;
                case 3:
                    serversDrop.Enabled = true;
                    break;
                case 4:
                    serversDrop.Enabled = true;
                    break;
                case 5:
                    serversDrop.Enabled = true;
                    break;
                case 6:
                    serversDrop.Enabled = true;
                    break;
                case 7:
                    serversDrop.Enabled = true;
                    break;
            }
        }
        private void educationDrop_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (educationDrop.SelectedIndex)
            {
                case 0:
                    serversDrop.Enabled = true;
                    break;
                case 1:
                    serversDrop.Enabled = true;
                    break;
                case 2:
                    serversDrop.Enabled = true;
                    break;
                case 3:
                    serversDrop.Enabled = true;
                    break;
                case 4:
                    serversDrop.Enabled = true;
                    break;
                case 5:
                    serversDrop.Enabled = true;
                    break;
                case 6:
                    serversDrop.Enabled = true;
                    break;
                case 7:
                    serversDrop.Enabled = true;
                    break;
            }
        }
        private void enterpriseDrop_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (enterpriseDrop.SelectedIndex)
            {
                case 0:
                    serversDrop.Enabled = true;
                    break;
                case 1:
                    serversDrop.Enabled = true;
                    break;
                case 2:
                    serversDrop.Enabled = true;
                    break;
                case 3:
                    serversDrop.Enabled = true;
                    break;
                case 4:
                    serversDrop.Enabled = true;
                    break;
                case 5:
                    serversDrop.Enabled = true;
                    break;
                case 6:
                    serversDrop.Enabled = true;
                    break;
            }
        }

        private void serversDrop_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (serversDrop.SelectedIndex)
            {
                case 0:
                    activateBtn.Enabled = true;
                    break;

                case 1:
                    activateBtn.Enabled = true;
                    break;

                case 2:
                    activateBtn.Enabled = true;
                    break;

                case 3:
                    activateBtn.Enabled = true;
                    break;

                case 4:
                    activateBtn.Enabled = true;
                    break;
            }
        }
    }
}