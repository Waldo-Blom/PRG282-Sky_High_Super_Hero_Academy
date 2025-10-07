namespace Sky_High_Super_Hero_Academy.PresentationLayer
{
    partial class SummaryUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SummaryUserControl));
            this.pnlAddHero = new System.Windows.Forms.Panel();
            this.pnlAddHeroTop = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblHeadingSubscript = new System.Windows.Forms.Label();
            this.lblAddNewHeadding = new System.Windows.Forms.Label();
            this.pnlAddHero.SuspendLayout();
            this.pnlAddHeroTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAddHero
            // 
            this.pnlAddHero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlAddHero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(40)))), ((int)(((byte)(58)))));
            this.pnlAddHero.Controls.Add(this.pnlAddHeroTop);
            this.pnlAddHero.Location = new System.Drawing.Point(120, 65);
            this.pnlAddHero.Name = "pnlAddHero";
            this.pnlAddHero.Size = new System.Drawing.Size(945, 470);
            this.pnlAddHero.TabIndex = 3;
            // 
            // pnlAddHeroTop
            // 
            this.pnlAddHeroTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(184)))));
            this.pnlAddHeroTop.Controls.Add(this.pictureBox2);
            this.pnlAddHeroTop.Controls.Add(this.lblHeadingSubscript);
            this.pnlAddHeroTop.Controls.Add(this.lblAddNewHeadding);
            this.pnlAddHeroTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAddHeroTop.Location = new System.Drawing.Point(0, 0);
            this.pnlAddHeroTop.Name = "pnlAddHeroTop";
            this.pnlAddHeroTop.Size = new System.Drawing.Size(945, 84);
            this.pnlAddHeroTop.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(55, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // lblHeadingSubscript
            // 
            this.lblHeadingSubscript.AutoSize = true;
            this.lblHeadingSubscript.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeadingSubscript.ForeColor = System.Drawing.Color.LightGray;
            this.lblHeadingSubscript.Location = new System.Drawing.Point(48, 48);
            this.lblHeadingSubscript.Name = "lblHeadingSubscript";
            this.lblHeadingSubscript.Size = new System.Drawing.Size(379, 22);
            this.lblHeadingSubscript.TabIndex = 1;
            this.lblHeadingSubscript.Text = "Academy statisics and preformance metrics";
            // 
            // lblAddNewHeadding
            // 
            this.lblAddNewHeadding.AutoSize = true;
            this.lblAddNewHeadding.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddNewHeadding.ForeColor = System.Drawing.Color.White;
            this.lblAddNewHeadding.Location = new System.Drawing.Point(91, 17);
            this.lblAddNewHeadding.Name = "lblAddNewHeadding";
            this.lblAddNewHeadding.Size = new System.Drawing.Size(194, 31);
            this.lblAddNewHeadding.TabIndex = 0;
            this.lblAddNewHeadding.Text = "Summary Report";
            // 
            // SummaryUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(6)))), ((int)(((byte)(23)))));
            this.Controls.Add(this.pnlAddHero);
            this.Name = "SummaryUserControl";
            this.Size = new System.Drawing.Size(1184, 600);
            this.pnlAddHero.ResumeLayout(false);
            this.pnlAddHeroTop.ResumeLayout(false);
            this.pnlAddHeroTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAddHero;
        private System.Windows.Forms.Panel pnlAddHeroTop;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblHeadingSubscript;
        private System.Windows.Forms.Label lblAddNewHeadding;
    }
}
