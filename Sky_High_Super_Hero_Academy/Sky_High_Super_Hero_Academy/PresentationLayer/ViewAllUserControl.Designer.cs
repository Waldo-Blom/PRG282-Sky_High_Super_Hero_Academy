namespace Sky_High_Super_Hero_Academy.PresentationLayer
{
    partial class ViewAllUserControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewAllUserControl));
            this.pnlAddHero = new System.Windows.Forms.Panel();
            this.dataGridViewHeroes = new System.Windows.Forms.DataGridView();
            this.colHeroID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSuperpower = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExamScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThreatLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnlAddHeroTop = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblHeadingSubscript = new System.Windows.Forms.Label();
            this.lblAddNewHeadding = new System.Windows.Forms.Label();
            this.pnlAddHero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHeroes)).BeginInit();
            this.pnlAddHeroTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAddHero
            // 
            this.pnlAddHero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlAddHero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(40)))), ((int)(((byte)(58)))));
            this.pnlAddHero.Controls.Add(this.dataGridViewHeroes);
            this.pnlAddHero.Controls.Add(this.pnlAddHeroTop);
            this.pnlAddHero.Location = new System.Drawing.Point(160, 80);
            this.pnlAddHero.Margin = new System.Windows.Forms.Padding(4);
            this.pnlAddHero.Name = "pnlAddHero";
            this.pnlAddHero.Size = new System.Drawing.Size(1260, 578);
            this.pnlAddHero.TabIndex = 2;
            // 
            // dataGridViewHeroes
            // 
            this.dataGridViewHeroes.AllowUserToAddRows = false;
            this.dataGridViewHeroes.AllowUserToDeleteRows = false;
            this.dataGridViewHeroes.AllowUserToOrderColumns = true;
            this.dataGridViewHeroes.AllowUserToResizeColumns = false;
            this.dataGridViewHeroes.AllowUserToResizeRows = false;
            this.dataGridViewHeroes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(6)))), ((int)(((byte)(23)))));
            this.dataGridViewHeroes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(6)))), ((int)(((byte)(23)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewHeroes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewHeroes.ColumnHeadersHeight = 40;
            this.dataGridViewHeroes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colHeroID,
            this.colName,
            this.colAge,
            this.colSuperpower,
            this.colExamScore,
            this.colRank,
            this.colThreatLevel,
            this.colDelete,
            this.colEdit});
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(6)))), ((int)(((byte)(23)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle18.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewHeroes.DefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridViewHeroes.EnableHeadersVisualStyles = false;
            this.dataGridViewHeroes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.dataGridViewHeroes.Location = new System.Drawing.Point(0, 100);
            this.dataGridViewHeroes.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewHeroes.MultiSelect = false;
            this.dataGridViewHeroes.Name = "dataGridViewHeroes";
            this.dataGridViewHeroes.ReadOnly = true;
            this.dataGridViewHeroes.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(10)))), ((int)(((byte)(30)))));
            this.dataGridViewHeroes.RowTemplate.Height = 50;
            this.dataGridViewHeroes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewHeroes.Size = new System.Drawing.Size(1260, 478);
            this.dataGridViewHeroes.TabIndex = 1;
            this.dataGridViewHeroes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHeroes_CellContentClick);
            // 
            // colHeroID
            // 
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.colHeroID.DefaultCellStyle = dataGridViewCellStyle11;
            this.colHeroID.HeaderText = "HeroID";
            this.colHeroID.Name = "colHeroID";
            this.colHeroID.ReadOnly = true;
            this.colHeroID.Width = 65;
            // 
            // colName
            // 
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            this.colName.DefaultCellStyle = dataGridViewCellStyle12;
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Width = 150;
            // 
            // colAge
            // 
            this.colAge.HeaderText = "Age";
            this.colAge.Name = "colAge";
            this.colAge.ReadOnly = true;
            this.colAge.Width = 70;
            // 
            // colSuperpower
            // 
            this.colSuperpower.HeaderText = "Superpower";
            this.colSuperpower.Name = "colSuperpower";
            this.colSuperpower.ReadOnly = true;
            this.colSuperpower.Width = 180;
            // 
            // colExamScore
            // 
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colExamScore.DefaultCellStyle = dataGridViewCellStyle13;
            this.colExamScore.HeaderText = "Exam Score";
            this.colExamScore.Name = "colExamScore";
            this.colExamScore.ReadOnly = true;
            // 
            // colRank
            // 
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Gold;
            this.colRank.DefaultCellStyle = dataGridViewCellStyle14;
            this.colRank.HeaderText = "Rank";
            this.colRank.Name = "colRank";
            this.colRank.ReadOnly = true;
            this.colRank.Width = 70;
            // 
            // colThreatLevel
            // 
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.colThreatLevel.DefaultCellStyle = dataGridViewCellStyle15;
            this.colThreatLevel.HeaderText = "Threat Level";
            this.colThreatLevel.Name = "colThreatLevel";
            this.colThreatLevel.ReadOnly = true;
            this.colThreatLevel.Width = 160;
            // 
            // colDelete
            // 
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Red;
            this.colDelete.DefaultCellStyle = dataGridViewCellStyle16;
            this.colDelete.HeaderText = "Delete";
            this.colDelete.Name = "colDelete";
            this.colDelete.ReadOnly = true;
            this.colDelete.Text = "Delete";
            this.colDelete.UseColumnTextForButtonValue = true;
            this.colDelete.Width = 60;
            // 
            // colEdit
            // 
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.Gray;
            this.colEdit.DefaultCellStyle = dataGridViewCellStyle17;
            this.colEdit.HeaderText = "Edit";
            this.colEdit.Name = "colEdit";
            this.colEdit.ReadOnly = true;
            this.colEdit.Text = "Edit";
            this.colEdit.UseColumnTextForButtonValue = true;
            this.colEdit.Width = 60;
            // 
            // pnlAddHeroTop
            // 
            this.pnlAddHeroTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(184)))));
            this.pnlAddHeroTop.Controls.Add(this.btnRefresh);
            this.pnlAddHeroTop.Controls.Add(this.btnSearch);
            this.pnlAddHeroTop.Controls.Add(this.txtSearch);
            this.pnlAddHeroTop.Controls.Add(this.pictureBox2);
            this.pnlAddHeroTop.Controls.Add(this.lblHeadingSubscript);
            this.pnlAddHeroTop.Controls.Add(this.lblAddNewHeadding);
            this.pnlAddHeroTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAddHeroTop.Location = new System.Drawing.Point(0, 0);
            this.pnlAddHeroTop.Margin = new System.Windows.Forms.Padding(4);
            this.pnlAddHeroTop.Name = "pnlAddHeroTop";
            this.pnlAddHeroTop.Size = new System.Drawing.Size(1260, 103);
            this.pnlAddHeroTop.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Location = new System.Drawing.Point(1093, 26);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(133, 34);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(957, 26);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(120, 34);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(22)))), ((int)(((byte)(41)))));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtSearch.Location = new System.Drawing.Point(625, 28);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(324, 29);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.Text = "Search heroes ...";
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(73, 22);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // lblHeadingSubscript
            // 
            this.lblHeadingSubscript.AutoSize = true;
            this.lblHeadingSubscript.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeadingSubscript.ForeColor = System.Drawing.Color.LightGray;
            this.lblHeadingSubscript.Location = new System.Drawing.Point(64, 59);
            this.lblHeadingSubscript.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeadingSubscript.Name = "lblHeadingSubscript";
            this.lblHeadingSubscript.Size = new System.Drawing.Size(343, 22);
            this.lblHeadingSubscript.TabIndex = 1;
            this.lblHeadingSubscript.Text = "Complete list of all the academy heroes";
            // 
            // lblAddNewHeadding
            // 
            this.lblAddNewHeadding.AutoSize = true;
            this.lblAddNewHeadding.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddNewHeadding.ForeColor = System.Drawing.Color.White;
            this.lblAddNewHeadding.Location = new System.Drawing.Point(121, 21);
            this.lblAddNewHeadding.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddNewHeadding.Name = "lblAddNewHeadding";
            this.lblAddNewHeadding.Size = new System.Drawing.Size(185, 31);
            this.lblAddNewHeadding.TabIndex = 0;
            this.lblAddNewHeadding.Text = "All Superheroes";
            // 
            // ViewAllUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(6)))), ((int)(((byte)(23)))));
            this.Controls.Add(this.pnlAddHero);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ViewAllUserControl";
            this.Size = new System.Drawing.Size(1579, 738);
            this.Load += new System.EventHandler(this.ViewAllUserControl_Load);
            this.pnlAddHero.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHeroes)).EndInit();
            this.pnlAddHeroTop.ResumeLayout(false);
            this.pnlAddHeroTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAddHero;
        private System.Windows.Forms.Panel pnlAddHeroTop;
        private System.Windows.Forms.Label lblHeadingSubscript;
        private System.Windows.Forms.Label lblAddNewHeadding;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dataGridViewHeroes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHeroID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSuperpower;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExamScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRank;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThreatLevel;
        private System.Windows.Forms.DataGridViewButtonColumn colDelete;
        private System.Windows.Forms.DataGridViewButtonColumn colEdit;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnRefresh;
    }
}
