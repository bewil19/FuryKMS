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
    public partial class Office : UserControl
    {
        private void Office_Load(object sender, EventArgs e)
        {
            LoadLanguage();
            RegistryKeys();
        }
        public Office()
        {
            InitializeComponent();
        }

        public void LoadLanguage()
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(Settings.Default.Language);
            productsLbl.Text = Lang.productsLbl;
            productsDrop.Text = Lang.officeDrop;
            noteLbl.Text = Lang.noteLbl;
            activateBtn.Text = Lang.activateBtn;
            renewBtn.Text = Lang.renewBtn;
            infoBtn.Text = Lang.infoBtn;
            removeBtn.Text = Lang.removeBtn;
            removeAllBtn.Text = Lang.removeAllBtn;
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

        public void RegistryKeys()
        {

            // Office C2R 2016 - 2021
            string RegistryOfficePath = @"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Office\ClickToRun\Configuration";
            string officeVer = Registry.GetValue(RegistryOfficePath, "versionToReport", "").ToString(); //FIX THIS
            string officePlatform = Registry.GetValue(RegistryOfficePath, "platform", "").ToString();
            string officeId = Registry.GetValue(RegistryOfficePath, "productReleaseIds", "").ToString();
            string officeUpdates = Registry.GetValue(RegistryOfficePath, "updatesEnabled", "").ToString();
            if (officePlatform.Contains("x86"))
            {
                productLbl.Text = "Microsoft Office " + officeId + " 32-bits " + "(" + officePlatform + ")";
            }
            else
            {
                productLbl.Text = "Microsoft Office " + officeId + " 64-bits " + "(" + officePlatform + ")";
            }
            // Office Checker
            string office16 = @"C:\Program Files\Microsoft Office\Office16";
            string office15 = @"C:\Program Files\Microsoft Office\Office15";
            string office16x86 = @"C:\Program Files (x86)\Microsoft Office\Office16";
            string office15x86 = @"C:\Program Files (x86)\Microsoft Office\Office15";
            if (Directory.Exists(office16))
            {
                Directory.SetCurrentDirectory(office16);
            }
            else if (Directory.Exists(office16x86))
            {
                Directory.SetCurrentDirectory(office16x86);
            }
            if (Directory.Exists(office15))
            {
                Directory.SetCurrentDirectory(office15);
            }
            else if (Directory.Exists(office15x86))
            {
                Directory.SetCurrentDirectory(office15x86);
            }
            if (officeId.Contains("2021"))
            {
                productsDrop.SelectedIndex = 0;
                officeLogo.Image = Resources.Office2019_2021;
            }
            if (officeId.Contains("2019"))
            {
                productsDrop.SelectedIndex = 1;
                officeLogo.Image = Resources.Office2019_2021;
            }
            if (officeId.Contains("2016"))
            {
                productsDrop.SelectedIndex = 2;
                officeLogo.Image = Resources.Office2013_2016;
            }
            if (officeId.Contains("2013"))
            {
                productsDrop.SelectedIndex = 3;
                officeLogo.Image = Resources.Office2013_2016;
            }

            if (officeUpdates.Contains("True"))
            {
                updatesLbl.Text = Lang.updatesOnLblOffice;
            }
            else
            {
                updatesLbl.Text = Lang.updatesOffLblOffice;
            }

            verLbl.Text = Lang.verLbl + officeVer;
            // Office MSI Here
        }

        private void activateBtn_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            shellText.Text = RunCommands("cscript //nologo slmgr.vbs /ckms; cscript //nologo ospp.vbs /setprt:1688");
            switch (productsDrop.SelectedIndex)
            {
                case 0: // 2021
                    try
                    {
                        string directory = Directory.GetCurrentDirectory() + @"Batchs";
                        if (!Directory.Exists(directory))
                            Directory.CreateDirectory(directory);

                        var batFileName = Path.Combine(directory, "2021.bat");
                        File.Delete(batFileName);

                        using (FileStream stream =
                            new FileStream(batFileName, FileMode.CreateNew, FileAccess.Write))
                        {
                            var bytes = Resources._2021;
                            stream.Write(bytes, 0, bytes.Length);
                        }
                        Process.Start(batFileName);
                    }
                    catch { }
                    break;

                case 1: // 2019
                    try
                    {
                        string directory = Directory.GetCurrentDirectory() + @"Batchs";
                        if (!Directory.Exists(directory))
                            Directory.CreateDirectory(directory);

                        var batFileName = Path.Combine(directory, "2019.bat");
                        File.Delete(batFileName);

                        using (FileStream stream =
                            new FileStream(batFileName, FileMode.CreateNew, FileAccess.Write))
                        {
                            var bytes = Resources._2019;
                            stream.Write(bytes, 0, bytes.Length);
                        }
                        Process.Start(batFileName);
                    }
                    catch { }
                    break;

                case 2: // 2016
                    try
                    {
                        string directory = Directory.GetCurrentDirectory() + @"Batchs";
                        if (!Directory.Exists(directory))
                            Directory.CreateDirectory(directory);

                        var batFileName = Path.Combine(directory, "2016.bat");
                        File.Delete(batFileName);

                        using (FileStream stream =
                            new FileStream(batFileName, FileMode.CreateNew, FileAccess.Write))
                        {
                            var bytes = Resources._2016;
                            stream.Write(bytes, 0, bytes.Length);
                        }
                        Process.Start(batFileName);
                    }
                    catch { }
                    break;

                case 3: // 2013
                    try
                    {
                        string directory = Directory.GetCurrentDirectory() + @"Batchs";
                        if (!Directory.Exists(directory))
                            Directory.CreateDirectory(directory);

                        var batFileName = Path.Combine(directory, "2013.bat");
                        File.Delete(batFileName);

                        using (FileStream stream =
                            new FileStream(batFileName, FileMode.CreateNew, FileAccess.Write))
                        {
                            var bytes = Resources._2013;
                            stream.Write(bytes, 0, bytes.Length);
                        }
                        Process.Start(batFileName);
                    }
                    catch { }
                    break;
            }
            Cursor.Current = Cursors.Default;
        }
        private void renewBtn_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            shellText.Text = RunCommands("cscript //nologo ospp.vbs /act");
            Cursor.Current = Cursors.Default;
        }
        private void infoBtn_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            shellText.Text = RunCommands("cscript //nologo ospp.vbs /dstatus");
            Cursor.Current = Cursors.Default;
        }
        private void removeBtn_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            string RegistryOfficePath = @"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Office\ClickToRun\Configuration";
            string officeId = Registry.GetValue(RegistryOfficePath, "productReleaseIds", "").ToString();

            if (officeId.Contains("2021"))
            {
                shellText.Text = RunCommands("cscript //nologo ospp.vbs /unpkey:6F7TH");
            }
            if (officeId.Contains("2019"))
            {
                shellText.Text = RunCommands("cscript //nologo ospp.vbs /unpkey:6MWKP");
            }
            if (officeId.Contains("2016"))
            {
                shellText.Text = RunCommands("cscript //nologo ospp.vbs /unpkey:WFG99");
            }
            if (officeId.Contains("2013"))
            {
                shellText.Text = RunCommands("cscript //nologo ospp.vbs /unpkey:GVGXT");
            }
            Cursor.Current = Cursors.Default;
        }
        private void removeAllBtn_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            // Remove all Trial Licenses
            shellText.AppendText(Lang.removingTRIAL);
            shellText.Text = RunCommands("cscript //nologo ospp.vbs /unpkey:PG343; cscript //nologo ospp.vbs /unpkey:8MBCX; cscript //nologo ospp.vbs /unpkey:BTDRB; cscript //nologo ospp.vbs /unpkey:27GXM");
            // Remove all Generic Licenses
            shellText.AppendText(Lang.removingGeneric);
            shellText.Text = RunCommands("cscript //nologo ospp.vbs /unpkey:6F7TH; cscript //nologo ospp.vbs /unpkey:6MWKP; cscript //nologo ospp.vbs /unpkey:WFG99; cscript //nologo ospp.vbs /unpkey:GVGXT");
            Cursor.Current = Cursors.Default;
        }

        private void productsDrop_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (productsDrop.SelectedIndex)
            {
                case 0: // 2021
                    activateBtn.Enabled = true;
                    break;

                case 1: // 2019
                    activateBtn.Enabled = true;
                    break;

                case 2: // 2016
                    activateBtn.Enabled = true;
                    break;

                case 3: // 2013
                    activateBtn.Enabled = true;
                    break;
            }
        }
    }
}