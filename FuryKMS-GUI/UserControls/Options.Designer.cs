namespace FuryKMS.UserControls
{
    partial class Options
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Options));
            this.langLbl = new System.Windows.Forms.Label();
            this.langDrop = new System.Windows.Forms.ComboBox();
            this.updatesLbl = new System.Windows.Forms.Label();
            this.updatesBtn = new FontAwesome.Sharp.IconButton();
            this.contactLbl = new System.Windows.Forms.Label();
            this.gitBtn = new FontAwesome.Sharp.IconButton();
            this.ytBtn = new FontAwesome.Sharp.IconButton();
            this.paypalBtn = new FontAwesome.Sharp.IconButton();
            this.aboutLbl = new System.Windows.Forms.Label();
            this.msBtn = new FontAwesome.Sharp.IconButton();
            this.logoBox = new System.Windows.Forms.PictureBox();
            this.rightsLbl = new System.Windows.Forms.Label();
            this.infoLbl = new System.Windows.Forms.Label();
            this.serversBtn = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // langLbl
            // 
            this.langLbl.AutoSize = true;
            this.langLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.langLbl.ForeColor = System.Drawing.Color.White;
            this.langLbl.Location = new System.Drawing.Point(15, 30);
            this.langLbl.Name = "langLbl";
            this.langLbl.Size = new System.Drawing.Size(140, 21);
            this.langLbl.TabIndex = 2;
            this.langLbl.Text = "Change Language";
            // 
            // langDrop
            // 
            this.langDrop.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.langDrop.FormattingEnabled = true;
            this.langDrop.Items.AddRange(new object[] {
            "English (EN)",
            "Español (ES)",
            "Русский Язык (RU)"});
            this.langDrop.Location = new System.Drawing.Point(19, 54);
            this.langDrop.Name = "langDrop";
            this.langDrop.Size = new System.Drawing.Size(250, 29);
            this.langDrop.TabIndex = 3;
            this.langDrop.SelectedIndexChanged += new System.EventHandler(this.langDrop_SelectedIndexChanged);
            // 
            // updatesLbl
            // 
            this.updatesLbl.AutoSize = true;
            this.updatesLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatesLbl.ForeColor = System.Drawing.Color.White;
            this.updatesLbl.Location = new System.Drawing.Point(15, 181);
            this.updatesLbl.Name = "updatesLbl";
            this.updatesLbl.Size = new System.Drawing.Size(71, 21);
            this.updatesLbl.TabIndex = 5;
            this.updatesLbl.Text = "Updates";
            // 
            // updatesBtn
            // 
            this.updatesBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(11)))), ((int)(((byte)(165)))));
            this.updatesBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updatesBtn.FlatAppearance.BorderSize = 0;
            this.updatesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updatesBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatesBtn.ForeColor = System.Drawing.Color.White;
            this.updatesBtn.IconChar = FontAwesome.Sharp.IconChar.Download;
            this.updatesBtn.IconColor = System.Drawing.Color.White;
            this.updatesBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.updatesBtn.IconSize = 40;
            this.updatesBtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.updatesBtn.Location = new System.Drawing.Point(19, 205);
            this.updatesBtn.Name = "updatesBtn";
            this.updatesBtn.Size = new System.Drawing.Size(250, 40);
            this.updatesBtn.TabIndex = 10;
            this.updatesBtn.Text = "Check Updates";
            this.updatesBtn.UseVisualStyleBackColor = false;
            this.updatesBtn.Click += new System.EventHandler(this.updatesBtn_Click);
            // 
            // contactLbl
            // 
            this.contactLbl.AutoSize = true;
            this.contactLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactLbl.ForeColor = System.Drawing.Color.White;
            this.contactLbl.Location = new System.Drawing.Point(15, 269);
            this.contactLbl.Name = "contactLbl";
            this.contactLbl.Size = new System.Drawing.Size(137, 21);
            this.contactLbl.TabIndex = 11;
            this.contactLbl.Text = "Contact and Help";
            // 
            // gitBtn
            // 
            this.gitBtn.BackColor = System.Drawing.Color.Black;
            this.gitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gitBtn.FlatAppearance.BorderSize = 0;
            this.gitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gitBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gitBtn.ForeColor = System.Drawing.Color.White;
            this.gitBtn.IconChar = FontAwesome.Sharp.IconChar.Github;
            this.gitBtn.IconColor = System.Drawing.Color.White;
            this.gitBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.gitBtn.IconSize = 40;
            this.gitBtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.gitBtn.Location = new System.Drawing.Point(19, 293);
            this.gitBtn.Name = "gitBtn";
            this.gitBtn.Size = new System.Drawing.Size(250, 40);
            this.gitBtn.TabIndex = 12;
            this.gitBtn.Text = "GitHub";
            this.gitBtn.UseVisualStyleBackColor = false;
            this.gitBtn.Click += new System.EventHandler(this.gitBtn_Click);
            // 
            // ytBtn
            // 
            this.ytBtn.BackColor = System.Drawing.Color.Red;
            this.ytBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ytBtn.FlatAppearance.BorderSize = 0;
            this.ytBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ytBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ytBtn.ForeColor = System.Drawing.Color.White;
            this.ytBtn.IconChar = FontAwesome.Sharp.IconChar.Youtube;
            this.ytBtn.IconColor = System.Drawing.Color.White;
            this.ytBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ytBtn.IconSize = 40;
            this.ytBtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ytBtn.Location = new System.Drawing.Point(19, 339);
            this.ytBtn.Name = "ytBtn";
            this.ytBtn.Size = new System.Drawing.Size(250, 40);
            this.ytBtn.TabIndex = 14;
            this.ytBtn.Text = "YouTube";
            this.ytBtn.UseVisualStyleBackColor = false;
            this.ytBtn.Click += new System.EventHandler(this.ytBtn_Click);
            // 
            // paypalBtn
            // 
            this.paypalBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.paypalBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.paypalBtn.FlatAppearance.BorderSize = 0;
            this.paypalBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.paypalBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paypalBtn.ForeColor = System.Drawing.Color.White;
            this.paypalBtn.IconChar = FontAwesome.Sharp.IconChar.Paypal;
            this.paypalBtn.IconColor = System.Drawing.Color.White;
            this.paypalBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.paypalBtn.IconSize = 40;
            this.paypalBtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.paypalBtn.Location = new System.Drawing.Point(19, 385);
            this.paypalBtn.Name = "paypalBtn";
            this.paypalBtn.Size = new System.Drawing.Size(250, 40);
            this.paypalBtn.TabIndex = 15;
            this.paypalBtn.Text = "PayPal";
            this.paypalBtn.UseVisualStyleBackColor = false;
            this.paypalBtn.Click += new System.EventHandler(this.paypalBtn_Click);
            // 
            // aboutLbl
            // 
            this.aboutLbl.AutoSize = true;
            this.aboutLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutLbl.ForeColor = System.Drawing.Color.White;
            this.aboutLbl.Location = new System.Drawing.Point(404, 30);
            this.aboutLbl.Name = "aboutLbl";
            this.aboutLbl.Size = new System.Drawing.Size(56, 21);
            this.aboutLbl.TabIndex = 16;
            this.aboutLbl.Text = "About";
            // 
            // msBtn
            // 
            this.msBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.msBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.msBtn.FlatAppearance.BorderSize = 0;
            this.msBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.msBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msBtn.ForeColor = System.Drawing.Color.White;
            this.msBtn.IconChar = FontAwesome.Sharp.IconChar.Microsoft;
            this.msBtn.IconColor = System.Drawing.Color.White;
            this.msBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.msBtn.IconSize = 40;
            this.msBtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.msBtn.Location = new System.Drawing.Point(19, 431);
            this.msBtn.Name = "msBtn";
            this.msBtn.Size = new System.Drawing.Size(250, 40);
            this.msBtn.TabIndex = 17;
            this.msBtn.Text = "MS Guides";
            this.msBtn.UseVisualStyleBackColor = false;
            this.msBtn.Click += new System.EventHandler(this.msBtn_Click);
            // 
            // logoBox
            // 
            this.logoBox.Image = global::FuryKMS.Properties.Resources.Logo;
            this.logoBox.Location = new System.Drawing.Point(408, 54);
            this.logoBox.Name = "logoBox";
            this.logoBox.Size = new System.Drawing.Size(335, 280);
            this.logoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoBox.TabIndex = 18;
            this.logoBox.TabStop = false;
            // 
            // rightsLbl
            // 
            this.rightsLbl.AutoSize = true;
            this.rightsLbl.Font = new System.Drawing.Font("Aldo the Apache", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightsLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(230)))), ((int)(((byte)(160)))));
            this.rightsLbl.Location = new System.Drawing.Point(403, 346);
            this.rightsLbl.Name = "rightsLbl";
            this.rightsLbl.Size = new System.Drawing.Size(205, 27);
            this.rightsLbl.TabIndex = 19;
            this.rightsLbl.Text = "FURY GREENWOOD - 2023";
            // 
            // infoLbl
            // 
            this.infoLbl.AutoSize = true;
            this.infoLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLbl.ForeColor = System.Drawing.Color.White;
            this.infoLbl.Location = new System.Drawing.Point(405, 373);
            this.infoLbl.Name = "infoLbl";
            this.infoLbl.Size = new System.Drawing.Size(376, 119);
            this.infoLbl.TabIndex = 20;
            this.infoLbl.Text = resources.GetString("infoLbl.Text");
            // 
            // serversBtn
            // 
            this.serversBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(16)))));
            this.serversBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.serversBtn.FlatAppearance.BorderSize = 0;
            this.serversBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.serversBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serversBtn.ForeColor = System.Drawing.Color.White;
            this.serversBtn.IconChar = FontAwesome.Sharp.IconChar.Microsoft;
            this.serversBtn.IconColor = System.Drawing.Color.White;
            this.serversBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.serversBtn.IconSize = 40;
            this.serversBtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.serversBtn.Location = new System.Drawing.Point(19, 477);
            this.serversBtn.Name = "serversBtn";
            this.serversBtn.Size = new System.Drawing.Size(250, 40);
            this.serversBtn.TabIndex = 21;
            this.serversBtn.Text = "MS Guides Servers";
            this.serversBtn.UseVisualStyleBackColor = false;
            this.serversBtn.Click += new System.EventHandler(this.serversBtn_Click);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.serversBtn);
            this.Controls.Add(this.infoLbl);
            this.Controls.Add(this.rightsLbl);
            this.Controls.Add(this.logoBox);
            this.Controls.Add(this.msBtn);
            this.Controls.Add(this.aboutLbl);
            this.Controls.Add(this.paypalBtn);
            this.Controls.Add(this.ytBtn);
            this.Controls.Add(this.gitBtn);
            this.Controls.Add(this.contactLbl);
            this.Controls.Add(this.updatesBtn);
            this.Controls.Add(this.updatesLbl);
            this.Controls.Add(this.langLbl);
            this.Controls.Add(this.langDrop);
            this.Name = "Options";
            this.Size = new System.Drawing.Size(800, 590);
            this.Load += new System.EventHandler(this.Options_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label langLbl;
        private System.Windows.Forms.ComboBox langDrop;
        private System.Windows.Forms.Label updatesLbl;
        private FontAwesome.Sharp.IconButton updatesBtn;
        private System.Windows.Forms.Label contactLbl;
        private FontAwesome.Sharp.IconButton gitBtn;
        private FontAwesome.Sharp.IconButton ytBtn;
        private FontAwesome.Sharp.IconButton paypalBtn;
        private System.Windows.Forms.Label aboutLbl;
        private FontAwesome.Sharp.IconButton msBtn;
        private System.Windows.Forms.PictureBox logoBox;
        private System.Windows.Forms.Label rightsLbl;
        private System.Windows.Forms.Label infoLbl;
        private FontAwesome.Sharp.IconButton serversBtn;
    }
}
