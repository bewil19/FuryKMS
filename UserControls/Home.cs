using FuryKMS.Languages;
using FuryKMS.Properties;
using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace FuryKMS.UserControls
{
    public partial class Home : UserControl
    {
        private void Home_Load(object sender, EventArgs e)
        {
            LoadLanguage();
        }
        public Home()
        {
            InitializeComponent();
        }
        public void LoadLanguage()
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(Settings.Default.Language);
            titleLbl1.Text = Lang.titleLbl1;
            titleLbl2.Text = Lang.titleLbl2;
            titleLbl3.Text = Lang.titleLbl3;
            textLbl1.Text = Lang.textLbl1;
            textLbl2.Text = Lang.textLbl2;
            textLbl3.Text = Lang.textLbl3;
        }
    }
}