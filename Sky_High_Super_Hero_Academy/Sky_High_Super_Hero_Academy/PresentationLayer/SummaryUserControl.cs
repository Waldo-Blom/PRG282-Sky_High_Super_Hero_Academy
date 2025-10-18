using System;
using System.Windows.Forms;
using System.Collections.Generic;
using Sky_High_Super_Hero_Academy.BusinessLayer;
using Sky_High_Super_Hero_Academy.DataAccessLayer;

namespace Sky_High_Super_Hero_Academy.PresentationLayer
{
    public partial class SummaryUserControl : UserControl
    {
        private readonly Superhero_FileHandler heroFileHandler = new Superhero_FileHandler();
        private readonly SummaryLogic summaryLogic = new SummaryLogic();
        private readonly Summary_FileHandler summaryFileHandler = new Summary_FileHandler();

        public SummaryUserControl()
        {
            InitializeComponent();
        }

        // Event handler for Generate Summary button
        private void btnGenerateSummary_Click(object sender, EventArgs e)
        {
            try
            {
                List<Superhero> heroes = heroFileHandler.ReadAllSuperheroes();
                SummaryData data = summaryLogic.CalculateSummary(heroes);

                // Update labels
                lblTotalNum.Text = data.TotalHeroes.ToString();
                lblAVGAgeNum.Text = data.AverageAge.ToString();
                lblAVGExamNum.Text = data.AverageExamScore.ToString();
                lblSRankNum.Text = data.SRankCount.ToString();
                lblARankNum.Text = data.ARankCount.ToString();
                lblBRankNum.Text = data.BRankCount.ToString();
                lblCRankNum.Text = data.CRankCount.ToString();

                // Save report
                string report = summaryLogic.GenerateReport(heroes);
                summaryFileHandler.SaveSummary(report);

                MessageBox.Show("Summary has been generated successfully!", "Summary", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to generate summary: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
