namespace FuryKMS.Batchs
{
    partial class WarningForm
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
            this.osLbl = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.viiLogo = new System.Windows.Forms.PictureBox();
            this.windowsIcon = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viiLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowsIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // osLbl
            // 
            this.osLbl.AutoSize = true;
            this.osLbl.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.osLbl.ForeColor = System.Drawing.Color.White;
            this.osLbl.Location = new System.Drawing.Point(101, 9);
            this.osLbl.Name = "osLbl";
            this.osLbl.Size = new System.Drawing.Size(493, 69);
            this.osLbl.TabIndex = 0;
            this.osLbl.Text = "Мы обнаружили, что вы используете Windows 7 Professional,\r\nвы по-прежнему сможете" +
    " использовать FuryKMS, но с\r\nограниченными возможностями.";
            this.osLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.iconPictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Warning;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 91;
            this.iconPictureBox1.Location = new System.Drawing.Point(0, 0);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(95, 91);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconPictureBox1.TabIndex = 2;
            this.iconPictureBox1.TabStop = false;
            // 
            // viiLogo
            // 
            this.viiLogo.Dock = System.Windows.Forms.DockStyle.Right;
            this.viiLogo.Image = global::FuryKMS.Properties.Resources._7;
            this.viiLogo.Location = new System.Drawing.Point(505, 0);
            this.viiLogo.Name = "viiLogo";
            this.viiLogo.Size = new System.Drawing.Size(95, 91);
            this.viiLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.viiLogo.TabIndex = 4;
            this.viiLogo.TabStop = false;
            // 
            // windowsIcon
            // 
            this.windowsIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.windowsIcon.Dock = System.Windows.Forms.DockStyle.Right;
            this.windowsIcon.IconChar = FontAwesome.Sharp.IconChar.Windows;
            this.windowsIcon.IconColor = System.Drawing.Color.White;
            this.windowsIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.windowsIcon.IconSize = 91;
            this.windowsIcon.Location = new System.Drawing.Point(600, 0);
            this.windowsIcon.Name = "windowsIcon";
            this.windowsIcon.Size = new System.Drawing.Size(95, 91);
            this.windowsIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.windowsIcon.TabIndex = 3;
            this.windowsIcon.TabStop = false;
            this.windowsIcon.UseGdi = true;
            // 
            // WarningForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(695, 91);
            this.Controls.Add(this.viiLogo);
            this.Controls.Add(this.windowsIcon);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.osLbl);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "WarningForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Warning";
            this.Load += new System.EventHandler(this.WarningForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viiLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowsIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label osLbl;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.PictureBox viiLogo;
        private FontAwesome.Sharp.IconPictureBox windowsIcon;
    }
}