using FontAwesome.Sharp;
using FuryKMS.Languages;
using FuryKMS.Properties;
using FuryKMS.UserControls;
using Microsoft.Win32;
using System;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace FuryKMS
{
    public partial class MainForm : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private string _currentButton, _lastActive;
        //Custom Font (Aldo the Apache)
        [DllImport("gdi32.DLL")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont, IntPtr pdv, [In] ref uint pcFonts);
        FontFamily font_AldotheApache;
        private void CustomFont()
        {
            PrivateFontCollection new_Font = new PrivateFontCollection();
            int long_font = Resources.AldotheApache.Length;
            byte[] fontdata = Resources.AldotheApache;
            IntPtr replace = Marshal.AllocCoTaskMem(long_font);
            Marshal.Copy(fontdata, 0, replace, long_font);
            uint cFonts = 0;
            AddFontMemResourceEx(replace, (uint)fontdata.Length, IntPtr.Zero, ref cFonts);
            new_Font.AddMemoryFont(replace, long_font);
            Marshal.FreeCoTaskMem(replace);
            font_AldotheApache = new_Font.Families[0];
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CustomFont();
            lblTitle1.Font = new Font(font_AldotheApache, 16, FontStyle.Regular);
            lblTitle2.Font = new Font(font_AldotheApache, 16, FontStyle.Regular);
            LoadLanguage();
            homeBtn.PerformClick();
            // Windows Data
            string RegistryWinPath = @"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion";
            string osName = Registry.GetValue(RegistryWinPath, "productName", "").ToString();
            string osDisplayVer = Registry.GetValue(RegistryWinPath, "displayVersion", "").ToString();
            string osBuild = Registry.GetValue(RegistryWinPath, "currentBuildNumber", "").ToString();
            string osType = Environment.Is64BitOperatingSystem ? "64-bit" : "32-bit";
            osLbl.Text = osName + " " + osDisplayVer + " (" + osBuild + ") " + osType;
            // .NET Framework Data
            const string subkey = @"SOFTWARE\Microsoft\NET Framework Setup\NDP\v4\Full\";
            using (var ndpKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32).OpenSubKey(subkey))
            {
                if (ndpKey != null && ndpKey.GetValue("Release") != null)
                {
                    netLbl.Text = ($".NET Framework {CheckFor45PlusVersion((int)ndpKey.GetValue("Release"))}");
                }
            }
            string CheckFor45PlusVersion(int releaseKey)
            {
                if (releaseKey >= 528040)
                    return "4.8";
                if (releaseKey >= 461808)
                    return "4.7.2";
                if (releaseKey >= 461308)
                    return "4.7.1";
                if (releaseKey >= 460798)
                    return "4.7";
                if (releaseKey >= 394802)
                    return "4.6.2";
                if (releaseKey >= 394254)
                    return "4.6.1";
                if (releaseKey >= 393295)
                    return "4.6";
                if (releaseKey >= 379893)
                    return "4.5.2";
                if (releaseKey >= 378675)
                    return "4.5.1";
                if (releaseKey >= 378389)
                    return "4.5";
                return "¯\\_(ツ)_//¯";
            }
        }
        public MainForm()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(8, 75);
            menuPnl.Controls.Add(leftBorderBtn);
        }
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Settings.Default.Save();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]    // Drag Form Functions
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void titlePnl_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void menuPnl_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            childPnl.Controls.Clear();
            childPnl.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(0, 45, 40);
            public static Color color2 = Color.FromArgb(0, 120, 210);
            public static Color color3 = Color.FromArgb(235, 60, 0);
            public static Color color4 = Color.FromArgb(0, 165, 230);
        }
        private void ActiveButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButtonNoIcon();
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.White;
                currentBtn.ForeColor = color;
                currentBtn.IconColor = color;
                currentBtn.Cursor = Cursors.Arrow;
                //LeftBorder
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(20, 20, 20);
                currentBtn.ForeColor = Color.White;
                currentBtn.IconColor = Color.White;
                currentBtn.Cursor = Cursors.Hand;
            }
        }

        // ONLY FOR OFFICE BUTTON!
        private void ActiveButtonNoIcon(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                DisableButtonNoIcon();
                officeBtn.Image = Resources.colorIcon;
                officeBtn.Refresh();
                officeBtn.BackColor = Color.White;
                officeBtn.ForeColor = color;
                officeBtn.Cursor = Cursors.Arrow;
                //LeftBorder
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, officeBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }
        private void DisableButtonNoIcon()
        {
            if (officeBtn != null)
            {
                officeBtn.BackColor = Color.FromArgb(20, 20, 20);
                officeBtn.ForeColor = Color.White;
                officeBtn.Image = Resources.whiteIcon;
                officeBtn.Cursor = Cursors.Hand;
            }
        }

        public void LoadLanguage()
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(Settings.Default.Language);
            appvLbl.Text = Lang.verLbl + "1.2.0";
            homeBtn.Text = Lang.homeBtn;
            windowsBtn.Text = Lang.windowsBtn;
            officeBtn.Text = Lang.officeBtn;
            optionsBtn.Text = Lang.optionsBtn;
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            _currentButton = sender.ToString();
            if (_currentButton != _lastActive)
            {
                _lastActive = _currentButton;
                ActiveButton(sender, RGBColors.color1);
                Home home = new Home();
                addUserControl(home);
            }
        }
        private void windowsBtn_Click(object sender, EventArgs e)
        {
            _currentButton = sender.ToString();
            if (_currentButton != _lastActive)
            {
                _lastActive = _currentButton;
                ActiveButton(sender, RGBColors.color2);
                Windows win = new Windows();
                addUserControl(win);
            }
        }
        private void officeBtn_Click(object sender, EventArgs e)
        {
            _currentButton = sender.ToString();
            if (_currentButton != _lastActive)
            {
                _lastActive = _currentButton;
                ActiveButtonNoIcon(sender, RGBColors.color3);
                Office office = new Office();
                addUserControl(office);
            }
        }
        private void optionsBtn_Click(object sender, EventArgs e)
        {
            _currentButton = sender.ToString();
            if (_currentButton != _lastActive)
            {
                _lastActive = _currentButton;
                ActiveButton(sender, RGBColors.color4);
                Options options = new Options(this);
                addUserControl(options);
            }
        }
    }
}