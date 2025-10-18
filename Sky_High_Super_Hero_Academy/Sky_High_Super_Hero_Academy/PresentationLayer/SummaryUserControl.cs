using System;
using System.Windows.Forms;

namespace Sky_High_Super_Hero_Academy.PresentationLayer
{
    public partial class SummaryUserControl : UserControl
    {
        public SummaryUserControl()
        {
            InitializeComponent();
        }

        // Event handler for Generate Summary button
        private void btnGenerateSummary_Click(object sender, EventArgs e)
        {

            // Update total heroes
            lblTotalNum.Text = "10";

            // Update average age
            lblAVGAgeNum.Text = "27.5";

            // Update average exam score
            lblAVGExamNum.Text = "88.2";

            // Update rank counts
            lblSRankNum.Text = "2";
            lblARankNum.Text = "3";
            lblBRankNum.Text = "3";
            lblCRankNum.Text = "2";

            // show a message confirming the summary has been generated
            MessageBox.Show("Summary has been generated successfully!", "Summary", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
