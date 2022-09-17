namespace FuryKMS.UserControls
{
    partial class Windows
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.productsLbl = new System.Windows.Forms.Label();
            this.productsDrop = new System.Windows.Forms.ComboBox();
            this.removeBtn = new System.Windows.Forms.Button();
            this.activateBtn = new System.Windows.Forms.Button();
            this.infoBtn = new System.Windows.Forms.Button();
            this.bottomPnl = new System.Windows.Forms.Panel();
            this.topPnl = new System.Windows.Forms.Panel();
            this.kmsLbl = new System.Windows.Forms.Label();
            this.serversDrop = new System.Windows.Forms.ComboBox();
            this.homeDrop = new System.Windows.Forms.ComboBox();
            this.licensesLbl = new System.Windows.Forms.Label();
            this.proDrop = new System.Windows.Forms.ComboBox();
            this.windowsLogo = new FontAwesome.Sharp.IconPictureBox();
            this.productLbl = new System.Windows.Forms.Label();
            this.editionLlb = new System.Windows.Forms.Label();
            this.orgLbl = new System.Windows.Forms.Label();
            this.ownerLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.enterpriseDrop = new System.Windows.Forms.ComboBox();
            this.educationDrop = new System.Windows.Forms.ComboBox();
            this.shellText = new System.Windows.Forms.TextBox();
            this.bottomPnl.SuspendLayout();
            this.topPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.windowsLogo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // productsLbl
            // 
            this.productsLbl.AutoSize = true;
            this.productsLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsLbl.ForeColor = System.Drawing.Color.White;
            this.productsLbl.Location = new System.Drawing.Point(15, 30);
            this.productsLbl.Name = "productsLbl";
            this.productsLbl.Size = new System.Drawing.Size(68, 21);
            this.productsLbl.TabIndex = 0;
            this.productsLbl.Text = "Product";
            // 
            // productsDrop
            // 
            this.productsDrop.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsDrop.FormattingEnabled = true;
            this.productsDrop.Items.AddRange(new object[] {
            "Windows 10 - 11 Home",
            "Windows 10 - 11 Pro",
            "Windows 10 - 11 Education",
            "Windows 10 - 11 Enterprise"});
            this.productsDrop.Location = new System.Drawing.Point(175, 27);
            this.productsDrop.Name = "productsDrop";
            this.productsDrop.Size = new System.Drawing.Size(465, 29);
            this.productsDrop.TabIndex = 1;
            this.productsDrop.Text = "Select your Windows Edition";
            this.productsDrop.SelectedIndexChanged += new System.EventHandler(this.productsDrop_SelectedIndexChanged);
            // 
            // removeBtn
            // 
            this.removeBtn.BackColor = System.Drawing.Color.Red;
            this.removeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeBtn.FlatAppearance.BorderSize = 0;
            this.removeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.removeBtn.ForeColor = System.Drawing.Color.White;
            this.removeBtn.Location = new System.Drawing.Point(630, 15);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(155, 40);
            this.removeBtn.TabIndex = 2;
            this.removeBtn.Text = "Remove Key";
            this.removeBtn.UseVisualStyleBackColor = false;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // activateBtn
            // 
            this.activateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.activateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.activateBtn.Enabled = false;
            this.activateBtn.FlatAppearance.BorderSize = 0;
            this.activateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.activateBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.activateBtn.ForeColor = System.Drawing.Color.White;
            this.activateBtn.Location = new System.Drawing.Point(15, 15);
            this.activateBtn.Name = "activateBtn";
            this.activateBtn.Size = new System.Drawing.Size(125, 40);
            this.activateBtn.TabIndex = 3;
            this.activateBtn.Text = "Activate!";
            this.activateBtn.UseVisualStyleBackColor = false;
            this.activateBtn.Click += new System.EventHandler(this.activateBtn_Click);
            // 
            // infoBtn
            // 
            this.infoBtn.BackColor = System.Drawing.Color.White;
            this.infoBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.infoBtn.FlatAppearance.BorderSize = 0;
            this.infoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.infoBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.infoBtn.ForeColor = System.Drawing.Color.Black;
            this.infoBtn.Location = new System.Drawing.Point(337, 15);
            this.infoBtn.Name = "infoBtn";
            this.infoBtn.Size = new System.Drawing.Size(125, 40);
            this.infoBtn.TabIndex = 4;
            this.infoBtn.Text = "Information";
            this.infoBtn.UseVisualStyleBackColor = false;
            this.infoBtn.Click += new System.EventHandler(this.infoBtn_Click);
            // 
            // bottomPnl
            // 
            this.bottomPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.bottomPnl.Controls.Add(this.activateBtn);
            this.bottomPnl.Controls.Add(this.removeBtn);
            this.bottomPnl.Controls.Add(this.infoBtn);
            this.bottomPnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPnl.Location = new System.Drawing.Point(0, 520);
            this.bottomPnl.Name = "bottomPnl";
            this.bottomPnl.Size = new System.Drawing.Size(800, 70);
            this.bottomPnl.TabIndex = 5;
            // 
            // topPnl
            // 
            this.topPnl.Controls.Add(this.kmsLbl);
            this.topPnl.Controls.Add(this.serversDrop);
            this.topPnl.Controls.Add(this.homeDrop);
            this.topPnl.Controls.Add(this.licensesLbl);
            this.topPnl.Controls.Add(this.proDrop);
            this.topPnl.Controls.Add(this.productsLbl);
            this.topPnl.Controls.Add(this.productsDrop);
            this.topPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPnl.Location = new System.Drawing.Point(0, 0);
            this.topPnl.Name = "topPnl";
            this.topPnl.Size = new System.Drawing.Size(800, 165);
            this.topPnl.TabIndex = 7;
            // 
            // kmsLbl
            // 
            this.kmsLbl.AutoSize = true;
            this.kmsLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kmsLbl.ForeColor = System.Drawing.Color.White;
            this.kmsLbl.Location = new System.Drawing.Point(15, 110);
            this.kmsLbl.Name = "kmsLbl";
            this.kmsLbl.Size = new System.Drawing.Size(103, 21);
            this.kmsLbl.TabIndex = 8;
            this.kmsLbl.Text = "KMS Servers";
            // 
            // serversDrop
            // 
            this.serversDrop.Enabled = false;
            this.serversDrop.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serversDrop.FormattingEnabled = true;
            this.serversDrop.Items.AddRange(new object[] {
            "Auto (Recomended)",
            "s8.uk.to",
            "s9.us.to",
            "kms8.msguides.com (UNSTABLE)",
            "kms9.msguides.com (UNSTABLE)"});
            this.serversDrop.Location = new System.Drawing.Point(175, 107);
            this.serversDrop.Name = "serversDrop";
            this.serversDrop.Size = new System.Drawing.Size(465, 29);
            this.serversDrop.TabIndex = 6;
            this.serversDrop.Text = "Select your KMS Server";
            this.serversDrop.SelectedIndexChanged += new System.EventHandler(this.serversDrop_SelectedIndexChanged);
            // 
            // homeDrop
            // 
            this.homeDrop.Enabled = false;
            this.homeDrop.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeDrop.FormattingEnabled = true;
            this.homeDrop.Items.AddRange(new object[] {
            "YTMG3-N6DKC-DKB77-7M9GH-8HVX7",
            "TX9XD-98N7V-6WMQ6-BX7FG-H8Q99",
            "4CPRK-NM3K3-X6XXQ-RXX86-WXCHW (N)",
            "3KHY7-WNT83-DGQKR-F7HPR-844BM (N)",
            "BT79Q-G7N6G-PGBYW-4YWX6-6F4BT (Single Language)",
            "7HNRX-D7KGG-3K4RQ-4WPJ4-YTDFH (Single Language)"});
            this.homeDrop.Location = new System.Drawing.Point(175, 67);
            this.homeDrop.Name = "homeDrop";
            this.homeDrop.Size = new System.Drawing.Size(465, 29);
            this.homeDrop.TabIndex = 4;
            this.homeDrop.Text = "Select your License";
            this.homeDrop.Visible = false;
            this.homeDrop.SelectedIndexChanged += new System.EventHandler(this.homeDrop_SelectedIndexChanged);
            // 
            // licensesLbl
            // 
            this.licensesLbl.AutoSize = true;
            this.licensesLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.licensesLbl.ForeColor = System.Drawing.Color.White;
            this.licensesLbl.Location = new System.Drawing.Point(15, 70);
            this.licensesLbl.Name = "licensesLbl";
            this.licensesLbl.Size = new System.Drawing.Size(71, 21);
            this.licensesLbl.TabIndex = 2;
            this.licensesLbl.Text = "Licenses";
            // 
            // proDrop
            // 
            this.proDrop.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proDrop.FormattingEnabled = true;
            this.proDrop.Items.AddRange(new object[] {
            "VK7JG-NPHTM-C97JM-9MPGT-3V66T",
            "W269N-WFGWX-YVC9B-4J6C9-T83GX",
            "2B87N-8KFHP-DKV6R-Y2C8J-PKCKT (N)",
            "MH37W-N47XK-V7XM9-C7227-GCQG9 (N)",
            "DXG7C-N36C4-C4HTG-X4T3X-2YV77 (for Workstations)",
            "NRG8B-VKK3Q-CXVCJ-9G2XF-6Q84J (for Workstations)",
            "WYPNQ-8C467-V2W6J-TX4WX-WT2RQ (N for Workstations)",
            "9FNHH-K3HBT-3W4TD-6383H-6XYWF (N for Workstations)"});
            this.proDrop.Location = new System.Drawing.Point(175, 67);
            this.proDrop.Name = "proDrop";
            this.proDrop.Size = new System.Drawing.Size(465, 29);
            this.proDrop.TabIndex = 3;
            this.proDrop.Text = "Select your License";
            this.proDrop.Visible = false;
            this.proDrop.SelectedIndexChanged += new System.EventHandler(this.proDrop_SelectedIndexChanged);
            // 
            // windowsLogo
            // 
            this.windowsLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.windowsLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.windowsLogo.IconChar = FontAwesome.Sharp.IconChar.Windows;
            this.windowsLogo.IconColor = System.Drawing.Color.White;
            this.windowsLogo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.windowsLogo.IconSize = 145;
            this.windowsLogo.Location = new System.Drawing.Point(0, 165);
            this.windowsLogo.Name = "windowsLogo";
            this.windowsLogo.Size = new System.Drawing.Size(145, 355);
            this.windowsLogo.TabIndex = 8;
            this.windowsLogo.TabStop = false;
            this.windowsLogo.UseGdi = true;
            // 
            // productLbl
            // 
            this.productLbl.AutoSize = true;
            this.productLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productLbl.ForeColor = System.Drawing.Color.White;
            this.productLbl.Location = new System.Drawing.Point(10, 20);
            this.productLbl.Name = "productLbl";
            this.productLbl.Size = new System.Drawing.Size(82, 21);
            this.productLbl.TabIndex = 9;
            this.productLbl.Text = "Microsoft";
            // 
            // editionLlb
            // 
            this.editionLlb.AutoSize = true;
            this.editionLlb.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editionLlb.ForeColor = System.Drawing.Color.White;
            this.editionLlb.Location = new System.Drawing.Point(10, 41);
            this.editionLlb.Name = "editionLlb";
            this.editionLlb.Size = new System.Drawing.Size(124, 21);
            this.editionLlb.TabIndex = 10;
            this.editionLlb.Text = "Edition ID: Core";
            // 
            // orgLbl
            // 
            this.orgLbl.AutoSize = true;
            this.orgLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orgLbl.ForeColor = System.Drawing.Color.White;
            this.orgLbl.Location = new System.Drawing.Point(10, 62);
            this.orgLbl.Name = "orgLbl";
            this.orgLbl.Size = new System.Drawing.Size(107, 21);
            this.orgLbl.TabIndex = 12;
            this.orgLbl.Text = "Organization:";
            // 
            // ownerLbl
            // 
            this.ownerLbl.AutoSize = true;
            this.ownerLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ownerLbl.ForeColor = System.Drawing.Color.White;
            this.ownerLbl.Location = new System.Drawing.Point(10, 83);
            this.ownerLbl.Name = "ownerLbl";
            this.ownerLbl.Size = new System.Drawing.Size(63, 21);
            this.ownerLbl.TabIndex = 13;
            this.ownerLbl.Text = "Owner:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.editionLlb);
            this.panel1.Controls.Add(this.ownerLbl);
            this.panel1.Controls.Add(this.productLbl);
            this.panel1.Controls.Add(this.orgLbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(145, 165);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(655, 110);
            this.panel1.TabIndex = 14;
            // 
            // enterpriseDrop
            // 
            this.enterpriseDrop.Enabled = false;
            this.enterpriseDrop.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterpriseDrop.FormattingEnabled = true;
            this.enterpriseDrop.Items.AddRange(new object[] {
            "XGVPP-NMH47-7TTHJ-W3FW7-8HV2C",
            "NPPR9-FWDCX-D2C8J-H872K-2YT43",
            "YYVX9-NTFWV-6MDM3-9PT4T-4M68B (G)",
            "FW7NV-4T673-HF4VX-9X4MM-B4H4T (G N)",
            "44RPN-FTY23-9VTTB-MP9BX-T84FV (G N)",
            "WGGHN-J84D6-QYCPR-T7PJ7-X766F (N)",
            "DPH2V-TTNVB-4X9Q3-TJR4H-KHJW4 (N)"});
            this.enterpriseDrop.Location = new System.Drawing.Point(175, 67);
            this.enterpriseDrop.Name = "enterpriseDrop";
            this.enterpriseDrop.Size = new System.Drawing.Size(465, 29);
            this.enterpriseDrop.TabIndex = 15;
            this.enterpriseDrop.Text = "Select your License";
            this.enterpriseDrop.Visible = false;
            this.enterpriseDrop.SelectedIndexChanged += new System.EventHandler(this.enterpriseDrop_SelectedIndexChanged);
            // 
            // educationDrop
            // 
            this.educationDrop.Enabled = false;
            this.educationDrop.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.educationDrop.FormattingEnabled = true;
            this.educationDrop.Items.AddRange(new object[] {
            "YNMGQ-8RYV3-4PGQ3-C8XTP-7CFBY",
            "NW6C2-QMPVW-D7KKK-3GKT6-VCFB2",
            "84NGF-MHBT6-FXBX8-QWJK7-DRR8H (N)",
            "2WH4N-8QGBV-H22JP-CT43Q-MDWWJ (N)",
            "8PTT6-RNW4C-6V7J2-C2D3X-MHBPB (Pro)",
            "6TP4R-GNPTD-KYYHQ-7B7DP-J447Y (Pro)",
            "GJTYN-HDMQY-FRR76-HVGC7-QPF8P (Pro N)",
            "YVWGF-BXNMC-HTQYQ-CPQ99-66QFC (Pro N)"});
            this.educationDrop.Location = new System.Drawing.Point(175, 67);
            this.educationDrop.Name = "educationDrop";
            this.educationDrop.Size = new System.Drawing.Size(465, 29);
            this.educationDrop.TabIndex = 16;
            this.educationDrop.Text = "Select your License";
            this.educationDrop.Visible = false;
            this.educationDrop.SelectedIndexChanged += new System.EventHandler(this.educationDrop_SelectedIndexChanged);
            // 
            // shellText
            // 
            this.shellText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.shellText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.shellText.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shellText.ForeColor = System.Drawing.Color.White;
            this.shellText.Location = new System.Drawing.Point(155, 275);
            this.shellText.Multiline = true;
            this.shellText.Name = "shellText";
            this.shellText.ReadOnly = true;
            this.shellText.Size = new System.Drawing.Size(645, 245);
            this.shellText.TabIndex = 17;
            // 
            // Windows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.shellText);
            this.Controls.Add(this.educationDrop);
            this.Controls.Add(this.enterpriseDrop);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.windowsLogo);
            this.Controls.Add(this.topPnl);
            this.Controls.Add(this.bottomPnl);
            this.Name = "Windows";
            this.Size = new System.Drawing.Size(800, 590);
            this.Load += new System.EventHandler(this.Windows_Load);
            this.bottomPnl.ResumeLayout(false);
            this.topPnl.ResumeLayout(false);
            this.topPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.windowsLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label productsLbl;
        private System.Windows.Forms.ComboBox productsDrop;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Button activateBtn;
        private System.Windows.Forms.Button infoBtn;
        private System.Windows.Forms.Panel bottomPnl;
        private System.Windows.Forms.Panel topPnl;
        private System.Windows.Forms.Label licensesLbl;
        private System.Windows.Forms.ComboBox proDrop;
        private System.Windows.Forms.ComboBox homeDrop;
        private System.Windows.Forms.Label productLbl;
        private System.Windows.Forms.Label editionLlb;
        private System.Windows.Forms.Label orgLbl;
        private System.Windows.Forms.Label ownerLbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label kmsLbl;
        private System.Windows.Forms.ComboBox serversDrop;
        private System.Windows.Forms.ComboBox enterpriseDrop;
        private System.Windows.Forms.ComboBox educationDrop;
        private System.Windows.Forms.TextBox shellText;
        public FontAwesome.Sharp.IconPictureBox windowsLogo;
    }
}
