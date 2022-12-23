namespace FuryKMS.UserControls
{
    partial class Office
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.removeAllBtn = new System.Windows.Forms.Button();
            this.renewBtn = new System.Windows.Forms.Button();
            this.activateBtn = new System.Windows.Forms.Button();
            this.infoBtn = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.noteLbl = new System.Windows.Forms.Label();
            this.productsLbl = new System.Windows.Forms.Label();
            this.productsDrop = new System.Windows.Forms.ComboBox();
            this.shellText = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.updatesLbl = new System.Windows.Forms.Label();
            this.verLbl = new System.Windows.Forms.Label();
            this.productLbl = new System.Windows.Forms.Label();
            this.officeLogo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.officeLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel1.Controls.Add(this.removeAllBtn);
            this.panel1.Controls.Add(this.renewBtn);
            this.panel1.Controls.Add(this.activateBtn);
            this.panel1.Controls.Add(this.infoBtn);
            this.panel1.Controls.Add(this.removeBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 520);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 70);
            this.panel1.TabIndex = 0;
            // 
            // removeAllBtn
            // 
            this.removeAllBtn.BackColor = System.Drawing.Color.Red;
            this.removeAllBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeAllBtn.FlatAppearance.BorderSize = 0;
            this.removeAllBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeAllBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.removeAllBtn.ForeColor = System.Drawing.Color.White;
            this.removeAllBtn.Location = new System.Drawing.Point(499, 15);
            this.removeAllBtn.Name = "removeAllBtn";
            this.removeAllBtn.Size = new System.Drawing.Size(125, 40);
            this.removeAllBtn.TabIndex = 9;
            this.removeAllBtn.Text = "Remove All";
            this.removeAllBtn.UseVisualStyleBackColor = false;
            this.removeAllBtn.Click += new System.EventHandler(this.removeAllBtn_Click);
            // 
            // renewBtn
            // 
            this.renewBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(240)))));
            this.renewBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.renewBtn.FlatAppearance.BorderSize = 0;
            this.renewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.renewBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.renewBtn.ForeColor = System.Drawing.Color.White;
            this.renewBtn.Location = new System.Drawing.Point(146, 15);
            this.renewBtn.Name = "renewBtn";
            this.renewBtn.Size = new System.Drawing.Size(125, 40);
            this.renewBtn.TabIndex = 8;
            this.renewBtn.Text = "Renew";
            this.renewBtn.UseVisualStyleBackColor = false;
            this.renewBtn.Click += new System.EventHandler(this.renewBtn_Click);
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
            this.activateBtn.TabIndex = 6;
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
            this.infoBtn.TabIndex = 7;
            this.infoBtn.Text = "Information";
            this.infoBtn.UseVisualStyleBackColor = false;
            this.infoBtn.Click += new System.EventHandler(this.infoBtn_Click);
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
            this.removeBtn.TabIndex = 5;
            this.removeBtn.Text = "Remove Key";
            this.removeBtn.UseVisualStyleBackColor = false;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.noteLbl);
            this.panel2.Controls.Add(this.productsLbl);
            this.panel2.Controls.Add(this.productsDrop);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 130);
            this.panel2.TabIndex = 1;
            // 
            // noteLbl
            // 
            this.noteLbl.AutoSize = true;
            this.noteLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteLbl.ForeColor = System.Drawing.Color.White;
            this.noteLbl.Location = new System.Drawing.Point(15, 70);
            this.noteLbl.Name = "noteLbl";
            this.noteLbl.Size = new System.Drawing.Size(720, 42);
            this.noteLbl.TabIndex = 8;
            this.noteLbl.Text = "*Note: The license expires in 180 days and is automatically renewed 7 days later," +
    " in the rare case If \r\nit doesn\'t, press the RENEW button.";
            // 
            // productsLbl
            // 
            this.productsLbl.AutoSize = true;
            this.productsLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsLbl.ForeColor = System.Drawing.Color.White;
            this.productsLbl.Location = new System.Drawing.Point(15, 30);
            this.productsLbl.Name = "productsLbl";
            this.productsLbl.Size = new System.Drawing.Size(68, 21);
            this.productsLbl.TabIndex = 6;
            this.productsLbl.Text = "Product";
            // 
            // productsDrop
            // 
            this.productsDrop.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsDrop.FormattingEnabled = true;
            this.productsDrop.Items.AddRange(new object[] {
            "Microsoft Office Standard - Profesional Plus 2021",
            "Microsoft Office Standard - Profesional Plus 2019",
            "Microsoft Office Standard - Profesional Plus 2016",
            "Microsoft Office Standard - Profesional Plus 2013"});
            this.productsDrop.Location = new System.Drawing.Point(175, 27);
            this.productsDrop.Name = "productsDrop";
            this.productsDrop.Size = new System.Drawing.Size(465, 29);
            this.productsDrop.TabIndex = 7;
            this.productsDrop.Text = "Select your Office version";
            this.productsDrop.SelectedIndexChanged += new System.EventHandler(this.productsDrop_SelectedIndexChanged);
            // 
            // shellText
            // 
            this.shellText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.shellText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.shellText.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shellText.ForeColor = System.Drawing.Color.White;
            this.shellText.Location = new System.Drawing.Point(155, 216);
            this.shellText.Multiline = true;
            this.shellText.Name = "shellText";
            this.shellText.ReadOnly = true;
            this.shellText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.shellText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.shellText.Size = new System.Drawing.Size(645, 304);
            this.shellText.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.updatesLbl);
            this.panel3.Controls.Add(this.verLbl);
            this.panel3.Controls.Add(this.productLbl);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(145, 130);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(655, 86);
            this.panel3.TabIndex = 6;
            // 
            // updatesLbl
            // 
            this.updatesLbl.AutoSize = true;
            this.updatesLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatesLbl.ForeColor = System.Drawing.Color.White;
            this.updatesLbl.Location = new System.Drawing.Point(10, 52);
            this.updatesLbl.Name = "updatesLbl";
            this.updatesLbl.Size = new System.Drawing.Size(79, 21);
            this.updatesLbl.TabIndex = 16;
            this.updatesLbl.Text = "Updates: ";
            // 
            // verLbl
            // 
            this.verLbl.AutoSize = true;
            this.verLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verLbl.ForeColor = System.Drawing.Color.White;
            this.verLbl.Location = new System.Drawing.Point(10, 31);
            this.verLbl.Name = "verLbl";
            this.verLbl.Size = new System.Drawing.Size(122, 21);
            this.verLbl.TabIndex = 15;
            this.verLbl.Text = "Version: 1X.XXX";
            // 
            // productLbl
            // 
            this.productLbl.AutoSize = true;
            this.productLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productLbl.ForeColor = System.Drawing.Color.White;
            this.productLbl.Location = new System.Drawing.Point(10, 10);
            this.productLbl.Name = "productLbl";
            this.productLbl.Size = new System.Drawing.Size(131, 21);
            this.productLbl.TabIndex = 14;
            this.productLbl.Text = "Microsoft Office";
            // 
            // officeLogo
            // 
            this.officeLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.officeLogo.Image = global::FuryKMS.Properties.Resources.Office2019_2021;
            this.officeLogo.Location = new System.Drawing.Point(0, 130);
            this.officeLogo.Name = "officeLogo";
            this.officeLogo.Size = new System.Drawing.Size(145, 390);
            this.officeLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.officeLogo.TabIndex = 5;
            this.officeLogo.TabStop = false;
            // 
            // Office
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.shellText);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.officeLogo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Office";
            this.Size = new System.Drawing.Size(800, 590);
            this.Load += new System.EventHandler(this.Office_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.officeLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button activateBtn;
        private System.Windows.Forms.Button infoBtn;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Label productsLbl;
        private System.Windows.Forms.ComboBox productsDrop;
        private System.Windows.Forms.TextBox shellText;
        private System.Windows.Forms.PictureBox officeLogo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label updatesLbl;
        private System.Windows.Forms.Label verLbl;
        private System.Windows.Forms.Label productLbl;
        private System.Windows.Forms.Button renewBtn;
        private System.Windows.Forms.Label noteLbl;
        private System.Windows.Forms.Button removeAllBtn;
    }
}
