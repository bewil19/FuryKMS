using System;

namespace FuryKMS
{
    partial class MainForm
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.titlePnl = new System.Windows.Forms.Panel();
            this.appvLbl = new System.Windows.Forms.Label();
            this.netLbl = new System.Windows.Forms.Label();
            this.osLbl = new System.Windows.Forms.Label();
            this.lblTitle2 = new System.Windows.Forms.Label();
            this.lblTitle1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuPnl = new System.Windows.Forms.Panel();
            this.officeBtn = new System.Windows.Forms.Button();
            this.windowsBtn = new FontAwesome.Sharp.IconButton();
            this.optionsBtn = new FontAwesome.Sharp.IconButton();
            this.homeBtn = new FontAwesome.Sharp.IconButton();
            this.childPnl = new System.Windows.Forms.Panel();
            this.titlePnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // titlePnl
            // 
            this.titlePnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.titlePnl.Controls.Add(this.appvLbl);
            this.titlePnl.Controls.Add(this.netLbl);
            this.titlePnl.Controls.Add(this.osLbl);
            this.titlePnl.Controls.Add(this.lblTitle2);
            this.titlePnl.Controls.Add(this.lblTitle1);
            this.titlePnl.Controls.Add(this.pictureBox1);
            this.titlePnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePnl.Location = new System.Drawing.Point(0, 0);
            this.titlePnl.Name = "titlePnl";
            this.titlePnl.Size = new System.Drawing.Size(915, 70);
            this.titlePnl.TabIndex = 0;
            this.titlePnl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titlePnl_MouseDown);
            // 
            // appvLbl
            // 
            this.appvLbl.AutoSize = true;
            this.appvLbl.BackColor = System.Drawing.Color.Transparent;
            this.appvLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.appvLbl.ForeColor = System.Drawing.Color.White;
            this.appvLbl.Location = new System.Drawing.Point(121, 32);
            this.appvLbl.Name = "appvLbl";
            this.appvLbl.Size = new System.Drawing.Size(81, 17);
            this.appvLbl.TabIndex = 0;
            this.appvLbl.Text = "Version 1.0.0";
            // 
            // netLbl
            // 
            this.netLbl.AutoSize = true;
            this.netLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.netLbl.ForeColor = System.Drawing.Color.White;
            this.netLbl.Location = new System.Drawing.Point(251, 32);
            this.netLbl.Name = "netLbl";
            this.netLbl.Size = new System.Drawing.Size(140, 17);
            this.netLbl.TabIndex = 0;
            this.netLbl.Text = ".NET Framework 4.X.X";
            this.netLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // osLbl
            // 
            this.osLbl.AutoSize = true;
            this.osLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.osLbl.ForeColor = System.Drawing.Color.White;
            this.osLbl.Location = new System.Drawing.Point(251, 15);
            this.osLbl.Name = "osLbl";
            this.osLbl.Size = new System.Drawing.Size(128, 17);
            this.osLbl.TabIndex = 0;
            this.osLbl.Text = "Windows 10 Version";
            this.osLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTitle2
            // 
            this.lblTitle2.AutoSize = true;
            this.lblTitle2.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle2.Font = new System.Drawing.Font("Aldo the Apache", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle2.ForeColor = System.Drawing.Color.White;
            this.lblTitle2.Location = new System.Drawing.Point(165, 9);
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Size = new System.Drawing.Size(46, 27);
            this.lblTitle2.TabIndex = 0;
            this.lblTitle2.Text = "KMS";
            // 
            // lblTitle1
            // 
            this.lblTitle1.AutoSize = true;
            this.lblTitle1.Font = new System.Drawing.Font("Aldo the Apache", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(230)))), ((int)(((byte)(158)))));
            this.lblTitle1.Location = new System.Drawing.Point(121, 9);
            this.lblTitle1.Name = "lblTitle1";
            this.lblTitle1.Size = new System.Drawing.Size(51, 27);
            this.lblTitle1.TabIndex = 0;
            this.lblTitle1.Text = "Fury";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FuryKMS.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuPnl
            // 
            this.menuPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.menuPnl.Controls.Add(this.officeBtn);
            this.menuPnl.Controls.Add(this.windowsBtn);
            this.menuPnl.Controls.Add(this.optionsBtn);
            this.menuPnl.Controls.Add(this.homeBtn);
            this.menuPnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPnl.Location = new System.Drawing.Point(0, 70);
            this.menuPnl.Name = "menuPnl";
            this.menuPnl.Size = new System.Drawing.Size(115, 590);
            this.menuPnl.TabIndex = 1;
            this.menuPnl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuPnl_MouseDown);
            // 
            // officeBtn
            // 
            this.officeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.officeBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.officeBtn.FlatAppearance.BorderSize = 0;
            this.officeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.officeBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.officeBtn.ForeColor = System.Drawing.Color.White;
            this.officeBtn.Image = global::FuryKMS.Properties.Resources.whiteIcon;
            this.officeBtn.Location = new System.Drawing.Point(0, 150);
            this.officeBtn.Name = "officeBtn";
            this.officeBtn.Size = new System.Drawing.Size(115, 75);
            this.officeBtn.TabIndex = 2;
            this.officeBtn.Text = "Office";
            this.officeBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.officeBtn.UseVisualStyleBackColor = true;
            this.officeBtn.Click += new System.EventHandler(this.officeBtn_Click);
            // 
            // windowsBtn
            // 
            this.windowsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.windowsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.windowsBtn.FlatAppearance.BorderSize = 0;
            this.windowsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.windowsBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windowsBtn.ForeColor = System.Drawing.Color.White;
            this.windowsBtn.IconChar = FontAwesome.Sharp.IconChar.Windows;
            this.windowsBtn.IconColor = System.Drawing.Color.White;
            this.windowsBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.windowsBtn.IconSize = 45;
            this.windowsBtn.Location = new System.Drawing.Point(0, 75);
            this.windowsBtn.Name = "windowsBtn";
            this.windowsBtn.Size = new System.Drawing.Size(115, 75);
            this.windowsBtn.TabIndex = 1;
            this.windowsBtn.Text = "Windows";
            this.windowsBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.windowsBtn.UseVisualStyleBackColor = true;
            this.windowsBtn.Click += new System.EventHandler(this.windowsBtn_Click);
            // 
            // optionsBtn
            // 
            this.optionsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.optionsBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.optionsBtn.FlatAppearance.BorderSize = 0;
            this.optionsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.optionsBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionsBtn.ForeColor = System.Drawing.Color.White;
            this.optionsBtn.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.optionsBtn.IconColor = System.Drawing.Color.White;
            this.optionsBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.optionsBtn.IconSize = 45;
            this.optionsBtn.Location = new System.Drawing.Point(0, 515);
            this.optionsBtn.Name = "optionsBtn";
            this.optionsBtn.Size = new System.Drawing.Size(115, 75);
            this.optionsBtn.TabIndex = 3;
            this.optionsBtn.Text = "Settings";
            this.optionsBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.optionsBtn.UseVisualStyleBackColor = true;
            this.optionsBtn.Click += new System.EventHandler(this.optionsBtn_Click);
            // 
            // homeBtn
            // 
            this.homeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homeBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.homeBtn.FlatAppearance.BorderSize = 0;
            this.homeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeBtn.ForeColor = System.Drawing.Color.White;
            this.homeBtn.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.homeBtn.IconColor = System.Drawing.Color.White;
            this.homeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.homeBtn.IconSize = 45;
            this.homeBtn.Location = new System.Drawing.Point(0, 0);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(115, 75);
            this.homeBtn.TabIndex = 0;
            this.homeBtn.Text = "Home";
            this.homeBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.homeBtn.UseVisualStyleBackColor = true;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // childPnl
            // 
            this.childPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.childPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.childPnl.Location = new System.Drawing.Point(115, 70);
            this.childPnl.Name = "childPnl";
            this.childPnl.Size = new System.Drawing.Size(800, 590);
            this.childPnl.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 660);
            this.Controls.Add(this.childPnl);
            this.Controls.Add(this.menuPnl);
            this.Controls.Add(this.titlePnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FuryKMS";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.titlePnl.ResumeLayout(false);
            this.titlePnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuPnl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel titlePnl;
        private System.Windows.Forms.Panel menuPnl;
        private System.Windows.Forms.Panel childPnl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitle1;
        private FontAwesome.Sharp.IconButton homeBtn;
        private FontAwesome.Sharp.IconButton optionsBtn;
        private System.Windows.Forms.Label lblTitle2;
        private System.Windows.Forms.Label osLbl;
        private System.Windows.Forms.Label netLbl;
        private FontAwesome.Sharp.IconButton windowsBtn;
        private System.Windows.Forms.Label appvLbl;
        private System.Windows.Forms.Button officeBtn;
    }
}

