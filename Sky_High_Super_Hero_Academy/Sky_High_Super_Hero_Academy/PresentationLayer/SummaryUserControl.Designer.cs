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
            this.btnGenerateSummary = new System.Windows.Forms.Button(); // ✅ NEW BUTTON ADDED
            this.pnlAddHeroTop = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblHeadingSubscript = new System.Windows.Forms.Label();
            this.lblAddNewHeadding = new System.Windows.Forms.Label();
            this.pnlTotalHeroes = new System.Windows.Forms.Panel();
            this.pnlAVGAge = new System.Windows.Forms.Panel();
            this.pnlAVGExam = new System.Windows.Forms.Panel();
            this.pnlHeroesRank = new System.Windows.Forms.Panel();
            this.lblTotalHeroes = new System.Windows.Forms.Label();
            this.lblTotalNum = new System.Windows.Forms.Label();
            this.lblAVGAge = new System.Windows.Forms.Label();
            this.lblAVGAgeNum = new System.Windows.Forms.Label();
            this.lblAVGExam = new System.Windows.Forms.Label();
            this.lblAVGExamNum = new System.Windows.Forms.Label();
            this.lblHeroesRank = new System.Windows.Forms.Label();
            this.lblSRank = new System.Windows.Forms.Label();
            this.lblCRank = new System.Windows.Forms.Label();
            this.lblBRank = new System.Windows.Forms.Label();
            this.lblARank = new System.Windows.Forms.Label();
            this.lblSRankNum = new System.Windows.Forms.Label();
            this.lblCRankNum = new System.Windows.Forms.Label();
            this.lblBRankNum = new System.Windows.Forms.Label();
            this.lblARankNum = new System.Windows.Forms.Label();
            this.pnlAddHero.SuspendLayout();
            this.pnlAddHeroTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlTotalHeroes.SuspendLayout();
            this.pnlAVGAge.SuspendLayout();
            this.pnlAVGExam.SuspendLayout();
            this.pnlHeroesRank.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAddHero
            // 
            this.pnlAddHero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlAddHero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(40)))), ((int)(((byte)(58)))));
            this.pnlAddHero.Controls.Add(this.btnGenerateSummary); // ✅ BUTTON ADDED TO PANEL
            this.pnlAddHero.Controls.Add(this.pnlAVGAge);
            this.pnlAddHero.Controls.Add(this.pnlAVGExam);
            this.pnlAddHero.Controls.Add(this.pnlHeroesRank);
            this.pnlAddHero.Controls.Add(this.pnlTotalHeroes);
            this.pnlAddHero.Controls.Add(this.pnlAddHeroTop);
            this.pnlAddHero.Location = new System.Drawing.Point(120, 65);
            this.pnlAddHero.Name = "pnlAddHero";
            this.pnlAddHero.Size = new System.Drawing.Size(945, 420); // increased height to fit button
            this.pnlAddHero.TabIndex = 3;
            // 
            // btnGenerateSummary
            // 
            this.btnGenerateSummary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(132)))));
            this.btnGenerateSummary.FlatAppearance.BorderSize = 0;
            this.btnGenerateSummary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateSummary.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateSummary.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnGenerateSummary.Location = new System.Drawing.Point(760, 320);
            this.btnGenerateSummary.Name = "btnGenerateSummary";
            this.btnGenerateSummary.Size = new System.Drawing.Size(157, 40);
            this.btnGenerateSummary.TabIndex = 99;
            this.btnGenerateSummary.Text = "Generate Summary";
            this.btnGenerateSummary.UseVisualStyleBackColor = false;
            this.btnGenerateSummary.Click += new System.EventHandler(this.btnGenerateSummary_Click);
            // 
            // pnlAddHeroTop
            // 
            this.pnlAddHeroTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(132)))));
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
            // pnlTotalHeroes
            // 
            this.pnlTotalHeroes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(91)))), ((int)(((byte)(230)))));
            this.pnlTotalHeroes.Controls.Add(this.lblTotalNum);
            this.pnlTotalHeroes.Controls.Add(this.lblTotalHeroes);
            this.pnlTotalHeroes.Location = new System.Drawing.Point(33, 128);
            this.pnlTotalHeroes.Name = "pnlTotalHeroes";
            this.pnlTotalHeroes.Size = new System.Drawing.Size(175, 170);
            this.pnlTotalHeroes.TabIndex = 1;
            // 
            // pnlAVGAge
            // 
            this.pnlAVGAge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(157)))), ((int)(((byte)(189)))));
            this.pnlAVGAge.Controls.Add(this.lblAVGAgeNum);
            this.pnlAVGAge.Controls.Add(this.lblAVGAge);
            this.pnlAVGAge.Location = new System.Drawing.Point(264, 128);
            this.pnlAVGAge.Name = "pnlAVGAge";
            this.pnlAVGAge.Size = new System.Drawing.Size(175, 170);
            this.pnlAVGAge.TabIndex = 2;
            // 
            // pnlAVGExam
            // 
            this.pnlAVGExam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(114)))));
            this.pnlAVGExam.Controls.Add(this.lblAVGExamNum);
            this.pnlAVGExam.Controls.Add(this.lblAVGExam);
            this.pnlAVGExam.Location = new System.Drawing.Point(506, 128);
            this.pnlAVGExam.Name = "pnlAVGExam";
            this.pnlAVGExam.Size = new System.Drawing.Size(175, 170);
            this.pnlAVGExam.TabIndex = 2;
            // 
            // pnlHeroesRank
            // 
            this.pnlHeroesRank.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(33)))), ((int)(((byte)(48)))));
            this.pnlHeroesRank.Controls.Add(this.lblARankNum);
            this.pnlHeroesRank.Controls.Add(this.lblBRankNum);
            this.pnlHeroesRank.Controls.Add(this.lblCRankNum);
            this.pnlHeroesRank.Controls.Add(this.lblSRankNum);
            this.pnlHeroesRank.Controls.Add(this.lblARank);
            this.pnlHeroesRank.Controls.Add(this.lblBRank);
            this.pnlHeroesRank.Controls.Add(this.lblCRank);
            this.pnlHeroesRank.Controls.Add(this.lblSRank);
            this.pnlHeroesRank.Controls.Add(this.lblHeroesRank);
            this.pnlHeroesRank.Location = new System.Drawing.Point(742, 128);
            this.pnlHeroesRank.Name = "pnlHeroesRank";
            this.pnlHeroesRank.Size = new System.Drawing.Size(175, 170);
            this.pnlHeroesRank.TabIndex = 2;
            // 
            // lblTotalHeroes
            // 
            this.lblTotalHeroes.AutoSize = true;
            this.lblTotalHeroes.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalHeroes.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTotalHeroes.Location = new System.Drawing.Point(28, 16);
            this.lblTotalHeroes.Name = "lblTotalHeroes";
            this.lblTotalHeroes.Size = new System.Drawing.Size(106, 23);
            this.lblTotalHeroes.TabIndex = 0;
            this.lblTotalHeroes.Text = "Total Heroes";
            // 
            // lblTotalNum
            // 
            this.lblTotalNum.AutoSize = true;
            this.lblTotalNum.Font = new System.Drawing.Font("Bernard MT Condensed", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalNum.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTotalNum.Location = new System.Drawing.Point(25, 58);
            this.lblTotalNum.Name = "lblTotalNum";
            this.lblTotalNum.Size = new System.Drawing.Size(36, 41);
            this.lblTotalNum.TabIndex = 1;
            this.lblTotalNum.Text = "3";
            // 
            // lblAVGAge
            // 
            this.lblAVGAge.AutoSize = true;
            this.lblAVGAge.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAVGAge.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblAVGAge.Location = new System.Drawing.Point(16, 16);
            this.lblAVGAge.Name = "lblAVGAge";
            this.lblAVGAge.Size = new System.Drawing.Size(107, 23);
            this.lblAVGAge.TabIndex = 2;
            this.lblAVGAge.Text = "Average Age";
            // 
            // lblAVGAgeNum
            // 
            this.lblAVGAgeNum.AutoSize = true;
            this.lblAVGAgeNum.Font = new System.Drawing.Font("Bernard MT Condensed", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAVGAgeNum.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblAVGAgeNum.Location = new System.Drawing.Point(13, 58);
            this.lblAVGAgeNum.Name = "lblAVGAgeNum";
            this.lblAVGAgeNum.Size = new System.Drawing.Size(82, 41);
            this.lblAVGAgeNum.TabIndex = 2;
            this.lblAVGAgeNum.Text = "28.0";
            // 
            // lblAVGExam
            // 
            this.lblAVGExam.AutoSize = true;
            this.lblAVGExam.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAVGExam.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblAVGExam.Location = new System.Drawing.Point(15, 16);
            this.lblAVGExam.Name = "lblAVGExam";
            this.lblAVGExam.Size = new System.Drawing.Size(137, 23);
            this.lblAVGExam.TabIndex = 3;
            this.lblAVGExam.Text = "AVG Exam Score";
            // 
            // lblAVGExamNum
            // 
            this.lblAVGExamNum.AutoSize = true;
            this.lblAVGExamNum.Font = new System.Drawing.Font("Bernard MT Condensed", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAVGExamNum.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblAVGExamNum.Location = new System.Drawing.Point(12, 58);
            this.lblAVGExamNum.Name = "lblAVGExamNum";
            this.lblAVGExamNum.Size = new System.Drawing.Size(82, 41);
            this.lblAVGExamNum.TabIndex = 3;
            this.lblAVGExamNum.Text = "86.3";
            // 
            // lblHeroesRank
            // 
            this.lblHeroesRank.AutoSize = true;
            this.lblHeroesRank.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeroesRank.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblHeroesRank.Location = new System.Drawing.Point(13, 16);
            this.lblHeroesRank.Name = "lblHeroesRank";
            this.lblHeroesRank.Size = new System.Drawing.Size(136, 23);
            this.lblHeroesRank.TabIndex = 4;
            this.lblHeroesRank.Text = "Heroes Per Rank";
            // 
            // lblSRank
            // 
            this.lblSRank.AutoSize = true;
            this.lblSRank.Font = new System.Drawing.Font("Arial Nova Cond", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSRank.ForeColor = System.Drawing.Color.Red;
            this.lblSRank.Location = new System.Drawing.Point(14, 58);
            this.lblSRank.Name = "lblSRank";
            this.lblSRank.Size = new System.Drawing.Size(45, 16);
            this.lblSRank.TabIndex = 5;
            this.lblSRank.Text = "S-Rank";
            // 
            // lblCRank
            // 
            this.lblCRank.AutoSize = true;
            this.lblCRank.Font = new System.Drawing.Font("Arial Nova Cond", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCRank.ForeColor = System.Drawing.Color.SpringGreen;
            this.lblCRank.Location = new System.Drawing.Point(14, 138);
            this.lblCRank.Name = "lblCRank";
            this.lblCRank.Size = new System.Drawing.Size(45, 16);
            this.lblCRank.TabIndex = 6;
            this.lblCRank.Text = "C-Rank";
            // 
            // lblBRank
            // 
            this.lblBRank.AutoSize = true;
            this.lblBRank.Font = new System.Drawing.Font("Arial Nova Cond", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBRank.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblBRank.Location = new System.Drawing.Point(14, 111);
            this.lblBRank.Name = "lblBRank";
            this.lblBRank.Size = new System.Drawing.Size(46, 16);
            this.lblBRank.TabIndex = 7;
            this.lblBRank.Text = "B-Rank";
            // 
            // lblARank
            // 
            this.lblARank.AutoSize = true;
            this.lblARank.Font = new System.Drawing.Font("Arial Nova Cond", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblARank.ForeColor = System.Drawing.Color.Coral;
            this.lblARank.Location = new System.Drawing.Point(14, 85);
            this.lblARank.Name = "lblARank";
            this.lblARank.Size = new System.Drawing.Size(45, 16);
            this.lblARank.TabIndex = 8;
            this.lblARank.Text = "A-Rank";
            // 
            // lblSRankNum
            // 
            this.lblSRankNum.AutoSize = true;
            this.lblSRankNum.Font = new System.Drawing.Font("Arial Nova Cond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSRankNum.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblSRankNum.Location = new System.Drawing.Point(129, 52);
            this.lblSRankNum.Name = "lblSRankNum";
            this.lblSRankNum.Size = new System.Drawing.Size(17, 20);
            this.lblSRankNum.TabIndex = 9;
            this.lblSRankNum.Text = "1";
            // 
            // lblCRankNum
            // 
            this.lblCRankNum.AutoSize = true;
            this.lblCRankNum.Font = new System.Drawing.Font("Arial Nova Cond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCRankNum.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCRankNum.Location = new System.Drawing.Point(129, 138);
            this.lblCRankNum.Name = "lblCRankNum";
            this.lblCRankNum.Size = new System.Drawing.Size(17, 20);
            this.lblCRankNum.TabIndex = 10;
            this.lblCRankNum.Text = "1";
            // 
            // lblBRankNum
            // 
            this.lblBRankNum.AutoSize = true;
            this.lblBRankNum.Font = new System.Drawing.Font("Arial Nova Cond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBRankNum.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblBRankNum.Location = new System.Drawing.Point(129, 111);
            this.lblBRankNum.Name = "lblBRankNum";
            this.lblBRankNum.Size = new System.Drawing.Size(17, 20);
            this.lblBRankNum.TabIndex = 11;
            this.lblBRankNum.Text = "1";
            // 
            // lblARankNum
            // 
            this.lblARankNum.AutoSize = true;
            this.lblARankNum.Font = new System.Drawing.Font("Arial Nova Cond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblARankNum.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblARankNum.Location = new System.Drawing.Point(129, 83);
            this.lblARankNum.Name = "lblARankNum";
            this.lblARankNum.Size = new System.Drawing.Size(17, 20);
            this.lblARankNum.TabIndex = 12;
            this.lblARankNum.Text = "1";
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
            this.pnlTotalHeroes.ResumeLayout(false);
            this.pnlTotalHeroes.PerformLayout();
            this.pnlAVGAge.ResumeLayout(false);
            this.pnlAVGAge.PerformLayout();
            this.pnlAVGExam.ResumeLayout(false);
            this.pnlAVGExam.PerformLayout();
            this.pnlHeroesRank.ResumeLayout(false);
            this.pnlHeroesRank.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAddHero;
        private System.Windows.Forms.Panel pnlAddHeroTop;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblHeadingSubscript;
        private System.Windows.Forms.Label lblAddNewHeadding;
        private System.Windows.Forms.Panel pnlAVGAge;
        private System.Windows.Forms.Panel pnlAVGExam;
        private System.Windows.Forms.Panel pnlHeroesRank;
        private System.Windows.Forms.Panel pnlTotalHeroes;
        private System.Windows.Forms.Label lblTotalNum;
        private System.Windows.Forms.Label lblTotalHeroes;
        private System.Windows.Forms.Label lblAVGAgeNum;
        private System.Windows.Forms.Label lblAVGAge;
        private System.Windows.Forms.Label lblAVGExamNum;
        private System.Windows.Forms.Label lblAVGExam;
        private System.Windows.Forms.Label lblARankNum;
        private System.Windows.Forms.Label lblBRankNum;
        private System.Windows.Forms.Label lblCRankNum;
        private System.Windows.Forms.Label lblSRankNum;
        private System.Windows.Forms.Label lblARank;
        private System.Windows.Forms.Label lblBRank;
        private System.Windows.Forms.Label lblCRank;
        private System.Windows.Forms.Label lblSRank;
        private System.Windows.Forms.Label lblHeroesRank;
        private System.Windows.Forms.Button btnGenerateSummary; // new button field
    }
}
