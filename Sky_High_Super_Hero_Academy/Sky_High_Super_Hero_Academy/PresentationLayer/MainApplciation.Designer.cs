namespace Sky_High_Super_Hero_Academy.PresentationLayer
{
    partial class MainApplciation
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
            this.pnlNav = new System.Windows.Forms.Panel();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnSummary = new System.Windows.Forms.Button();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.bntAddHero = new System.Windows.Forms.Button();
            this.lblBrandName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlNav
            // 
            this.pnlNav.Controls.Add(this.btnAbout);
            this.pnlNav.Controls.Add(this.btnSummary);
            this.pnlNav.Controls.Add(this.btnViewAll);
            this.pnlNav.Controls.Add(this.bntAddHero);
            this.pnlNav.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlNav.Location = new System.Drawing.Point(507, 0);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(675, 59);
            this.pnlNav.TabIndex = 0;
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAbout.Location = new System.Drawing.Point(496, 12);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(121, 34);
            this.btnAbout.TabIndex = 3;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnSummary
            // 
            this.btnSummary.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSummary.Location = new System.Drawing.Point(357, 12);
            this.btnSummary.Name = "btnSummary";
            this.btnSummary.Size = new System.Drawing.Size(121, 34);
            this.btnSummary.TabIndex = 2;
            this.btnSummary.Text = "Summary";
            this.btnSummary.UseVisualStyleBackColor = false;
            this.btnSummary.Click += new System.EventHandler(this.btnSummary_Click);
            // 
            // btnViewAll
            // 
            this.btnViewAll.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnViewAll.Location = new System.Drawing.Point(213, 12);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(121, 34);
            this.btnViewAll.TabIndex = 1;
            this.btnViewAll.Text = "View All";
            this.btnViewAll.UseVisualStyleBackColor = false;
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);
            // 
            // bntAddHero
            // 
            this.bntAddHero.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bntAddHero.BackColor = System.Drawing.Color.DodgerBlue;
            this.bntAddHero.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bntAddHero.Location = new System.Drawing.Point(64, 12);
            this.bntAddHero.Name = "bntAddHero";
            this.bntAddHero.Size = new System.Drawing.Size(121, 34);
            this.bntAddHero.TabIndex = 0;
            this.bntAddHero.Text = "Add hero";
            this.bntAddHero.UseVisualStyleBackColor = false;
            this.bntAddHero.Click += new System.EventHandler(this.bntAddHero_Click);
            // 
            // lblBrandName
            // 
            this.lblBrandName.AutoSize = true;
            this.lblBrandName.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrandName.Location = new System.Drawing.Point(105, 18);
            this.lblBrandName.Name = "lblBrandName";
            this.lblBrandName.Size = new System.Drawing.Size(266, 28);
            this.lblBrandName.TabIndex = 1;
            this.lblBrandName.Text = "Sky High Heroes Academy";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(22, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 38);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pnlTop
            // 
            this.pnlTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTop.Controls.Add(this.pictureBox1);
            this.pnlTop.Controls.Add(this.lblBrandName);
            this.pnlTop.Controls.Add(this.pnlNav);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1184, 61);
            this.pnlTop.TabIndex = 2;
            // 
            // pnlContent
            // 
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 61);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1184, 600);
            this.pnlContent.TabIndex = 6;
            // 
            // MainApplciation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlTop);
            this.Name = "MainApplciation";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainApplciation_Load);
            this.pnlNav.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnSummary;
        private System.Windows.Forms.Button btnViewAll;
        private System.Windows.Forms.Button bntAddHero;
        private System.Windows.Forms.Label lblBrandName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlContent;
    }
}