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
            this.About = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // About
            // 
            this.About.AutoSize = true;
            this.About.Location = new System.Drawing.Point(499, 306);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(70, 13);
            this.About.TabIndex = 1;
            this.About.Text = "View all page";
            // 
            // ViewAllUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.About);
            this.Name = "ViewAllUserControl";
            this.Size = new System.Drawing.Size(1184, 600);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label About;
    }
}
