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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainApplciation));
            this.pnlNav = new System.Windows.Forms.Panel();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnSummary = new System.Windows.Forms.Button();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.bntAddHero = new System.Windows.Forms.Button();
            this.lblBrandName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.Transparent;
            this.pnlNav.Controls.Add(this.btnAbout);
            this.pnlNav.Controls.Add(this.btnSummary);
            this.pnlNav.Controls.Add(this.btnViewAll);
            this.pnlNav.Controls.Add(this.bntAddHero);
            this.pnlNav.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlNav.Location = new System.Drawing.Point(507, 0);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(675, 74);
            this.pnlNav.TabIndex = 0;
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAbout.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnAbout.ForeColor = System.Drawing.Color.White;
            this.btnAbout.Location = new System.Drawing.Point(510, 14);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(135, 40);
            this.btnAbout.TabIndex = 3;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnSummary
            // 
            this.btnSummary.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSummary.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSummary.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnSummary.ForeColor = System.Drawing.Color.White;
            this.btnSummary.Location = new System.Drawing.Point(350, 14);
            this.btnSummary.Name = "btnSummary";
            this.btnSummary.Size = new System.Drawing.Size(135, 40);
            this.btnSummary.TabIndex = 2;
            this.btnSummary.Text = "Summary";
            this.btnSummary.UseVisualStyleBackColor = false;
            this.btnSummary.Click += new System.EventHandler(this.btnSummary_Click);
            // 
            // btnViewAll
            // 
            this.btnViewAll.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnViewAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnViewAll.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnViewAll.ForeColor = System.Drawing.Color.White;
            this.btnViewAll.Location = new System.Drawing.Point(190, 14);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(135, 40);
            this.btnViewAll.TabIndex = 1;
            this.btnViewAll.Text = "View All";
            this.btnViewAll.UseVisualStyleBackColor = false;
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);
            // 
            // bntAddHero
            // 
            this.bntAddHero.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bntAddHero.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.bntAddHero.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bntAddHero.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntAddHero.ForeColor = System.Drawing.Color.White;
            this.bntAddHero.Location = new System.Drawing.Point(32, 14);
            this.bntAddHero.Name = "bntAddHero";
            this.bntAddHero.Size = new System.Drawing.Size(135, 40);
            this.bntAddHero.TabIndex = 0;
            this.bntAddHero.Text = "Add hero";
            this.bntAddHero.UseVisualStyleBackColor = false;
            this.bntAddHero.Click += new System.EventHandler(this.bntAddHero_Click);
            // 
            // lblBrandName
            // 
            this.lblBrandName.AutoSize = true;
            this.lblBrandName.BackColor = System.Drawing.Color.Transparent;
            this.lblBrandName.Font = new System.Drawing.Font("Rockwell Nova Cond", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrandName.ForeColor = System.Drawing.Color.White;
            this.lblBrandName.Location = new System.Drawing.Point(195, 2);
            this.lblBrandName.Name = "lblBrandName";
            this.lblBrandName.Size = new System.Drawing.Size(292, 42);
            this.lblBrandName.TabIndex = 1;
            this.lblBrandName.Text = "Sky High Heroes Academy";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(26, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 73);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.SystemColors.Desktop;
            this.pnlTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTop.Controls.Add(this.label1);
            this.pnlTop.Controls.Add(this.pictureBox1);
            this.pnlTop.Controls.Add(this.lblBrandName);
            this.pnlTop.Controls.Add(this.pnlNav);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1184, 76);
            this.pnlTop.TabIndex = 2;
            // 
            // pnlContent
            // 
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 76);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1184, 585);
            this.pnlContent.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell Nova Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(207, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "A super hero mangement system for all your needs";
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
        private System.Windows.Forms.Label label1;
    }
}