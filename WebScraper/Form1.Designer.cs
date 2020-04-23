namespace WebScraper
{
    partial class FrmMain
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
            this.btnOpenBrow = new System.Windows.Forms.Button();
            this.btnScrape = new System.Windows.Forms.Button();
            this.lbxSymbols = new System.Windows.Forms.ListBox();
            this.lblSym = new System.Windows.Forms.Label();
            this.lblCompany = new System.Windows.Forms.Label();
            this.lblLast = new System.Windows.Forms.Label();
            this.lblPerChange = new System.Windows.Forms.Label();
            this.lblChange = new System.Windows.Forms.Label();
            this.lblVolume = new System.Windows.Forms.Label();
            this.lblTraded = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOpenBrow
            // 
            this.btnOpenBrow.Location = new System.Drawing.Point(93, 127);
            this.btnOpenBrow.Name = "btnOpenBrow";
            this.btnOpenBrow.Size = new System.Drawing.Size(374, 27);
            this.btnOpenBrow.TabIndex = 1;
            this.btnOpenBrow.Text = "Open Browser";
            this.btnOpenBrow.UseVisualStyleBackColor = true;
            this.btnOpenBrow.Click += new System.EventHandler(this.btnOpenBrow_Click);
            // 
            // btnScrape
            // 
            this.btnScrape.Location = new System.Drawing.Point(93, 160);
            this.btnScrape.Name = "btnScrape";
            this.btnScrape.Size = new System.Drawing.Size(374, 26);
            this.btnScrape.TabIndex = 2;
            this.btnScrape.Text = "Start Scraping";
            this.btnScrape.UseVisualStyleBackColor = true;
            this.btnScrape.Click += new System.EventHandler(this.btnScrape_Click);
            // 
            // lbxSymbols
            // 
            this.lbxSymbols.FormattingEnabled = true;
            this.lbxSymbols.Location = new System.Drawing.Point(12, 12);
            this.lbxSymbols.Name = "lbxSymbols";
            this.lbxSymbols.Size = new System.Drawing.Size(75, 173);
            this.lbxSymbols.TabIndex = 4;
            this.lbxSymbols.SelectedValueChanged += new System.EventHandler(this.lbxSymbols_SelectedValueChanged);
            // 
            // lblSym
            // 
            this.lblSym.AutoSize = true;
            this.lblSym.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSym.Location = new System.Drawing.Point(94, 31);
            this.lblSym.Name = "lblSym";
            this.lblSym.Size = new System.Drawing.Size(46, 17);
            this.lblSym.TabIndex = 5;
            this.lblSym.Text = "lblSym";
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompany.Location = new System.Drawing.Point(93, 12);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(100, 19);
            this.lblCompany.TabIndex = 6;
            this.lblCompany.Text = "lblCompany";
            // 
            // lblLast
            // 
            this.lblLast.AutoSize = true;
            this.lblLast.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLast.Location = new System.Drawing.Point(93, 68);
            this.lblLast.Name = "lblLast";
            this.lblLast.Size = new System.Drawing.Size(52, 19);
            this.lblLast.TabIndex = 7;
            this.lblLast.Text = "lblLast";
            // 
            // lblPerChange
            // 
            this.lblPerChange.AutoSize = true;
            this.lblPerChange.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerChange.Location = new System.Drawing.Point(188, 87);
            this.lblPerChange.Name = "lblPerChange";
            this.lblPerChange.Size = new System.Drawing.Size(85, 16);
            this.lblPerChange.TabIndex = 8;
            this.lblPerChange.Text = "lblPerChange";
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChange.Location = new System.Drawing.Point(187, 68);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(76, 19);
            this.lblChange.TabIndex = 9;
            this.lblChange.Text = "lblChange";
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Location = new System.Drawing.Point(12, 287);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(52, 13);
            this.lblVolume.TabIndex = 10;
            this.lblVolume.Text = "lblVolume";
            // 
            // lblTraded
            // 
            this.lblTraded.AutoSize = true;
            this.lblTraded.Location = new System.Drawing.Point(70, 287);
            this.lblTraded.Name = "lblTraded";
            this.lblTraded.Size = new System.Drawing.Size(51, 13);
            this.lblTraded.TabIndex = 11;
            this.lblTraded.Text = "lblTraded";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 196);
            this.Controls.Add(this.lblTraded);
            this.Controls.Add(this.lblVolume);
            this.Controls.Add(this.lblChange);
            this.Controls.Add(this.lblPerChange);
            this.Controls.Add(this.lblLast);
            this.Controls.Add(this.lblCompany);
            this.Controls.Add(this.lblSym);
            this.Controls.Add(this.lbxSymbols);
            this.Controls.Add(this.btnScrape);
            this.Controls.Add(this.btnOpenBrow);
            this.Name = "FrmMain";
            this.Text = "Web Scraper";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnOpenBrow;
        private System.Windows.Forms.Button btnScrape;
        private System.Windows.Forms.ListBox lbxSymbols;
        private System.Windows.Forms.Label lblSym;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.Label lblLast;
        private System.Windows.Forms.Label lblPerChange;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.Label lblTraded;
    }
}

