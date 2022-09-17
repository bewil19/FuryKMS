using FuryKMS.Languages;
using FuryKMS.Properties;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace FuryKMS.UserControls
{
    public partial class Options : UserControl
    {
        private MainForm Fix { get; set; }
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
        private void Options_Load(object sender, EventArgs e)
        {
            CustomFont();
            rightsLbl.Font = new Font(font_AldotheApache, 16, FontStyle.Regular);
            LoadLanguage();
            langDrop.Text = Settings.Default.LangSelected;
        }
        public Options(MainForm mainForm)
        {
            InitializeComponent();
            Fix = mainForm;
        }

        public void LoadLanguage()
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(Settings.Default.Language);
            langLbl.Text = Lang.langLbl;
            updatesLbl.Text = Lang.updatesLbl;
            updatesBtn.Text = Lang.updatesBtn;
            contactLbl.Text = Lang.contactLbl;
            aboutLbl.Text = Lang.aboutLbl;
            infoLbl.Text = Lang.infoLbl;
            Fix.LoadLanguage();
        }

        private void updatesBtn_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/FuryGreenwood/FuryKMS");
        }
        private void gitBtn_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/FuryGreenwood");
        }
        private void discordBtn_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/XUbuJYbUSG");
        }
        private void ytBtn_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/channel/UC30r679XKN70OdvHmmMAjcg");
        }
        private void paypalBtn_Click(object sender, EventArgs e)
        {
            Process.Start("https://paypal.me/FuryGreenwood?");
        }
        private void msBtn_Click(object sender, EventArgs e)
        {
            Process.Start("https://msguides.com");
        }
        private void serversBtn_Click(object sender, EventArgs e)
        {
            Process.Start("https://kms.msguides.com");
        }

        private void langDrop_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (langDrop.SelectedIndex)
            {
                case 0:
                    Settings.Default.Language = "en";
                    Settings.Default.LangSelected = langDrop.Text;
                    LoadLanguage();
                    updatesBtn.TextAlign = ContentAlignment.MiddleCenter;
                    break;

                case 1:
                    Settings.Default.Language = "es";
                    Settings.Default.LangSelected = langDrop.Text;
                    LoadLanguage();
                    updatesBtn.TextAlign = ContentAlignment.MiddleRight;
                    break;

                case 2:
                    Settings.Default.Language = "ru";
                    Settings.Default.LangSelected = langDrop.Text;
                    LoadLanguage();
                    updatesBtn.TextAlign = ContentAlignment.MiddleRight;
                    break;
            }
        }
    }
}