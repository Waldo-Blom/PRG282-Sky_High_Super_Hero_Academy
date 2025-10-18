using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sky_High_Super_Hero_Academy.PresentationLayer
{
    public partial class MainApplciation : Form
    {
        public MainApplciation()
        {
            InitializeComponent();
        }

        private void LoadUserControl(UserControl userControl)
        {
            // Clear the panel
            pnlContent.Controls.Clear();

            // Add the UserControl to the panel
            pnlContent.Controls.Add(userControl);
        }

        // On nav button click navigate to AddHeroUserControl form / page
        private void bntAddHero_Click(object sender, EventArgs e) 
        {
            LoadUserControl(new AddHeroUserControl());
        }

        // On nav button click navigate to ViewAllUserControl form / page
        private void btnViewAll_Click(object sender, EventArgs e)
        {
            LoadUserControl(new ViewAllUserControl());
        }

        // On nav button click navigate to SummaryUserControl form / page
        private void btnSummary_Click(object sender, EventArgs e)
        {
            LoadUserControl(new SummaryUserControl());
        }

        // On nav button click navigate to AboutUserControl form / page
        private void btnAbout_Click(object sender, EventArgs e)
        {
            LoadUserControl(new AboutUserControl());
        }

        // On the form load event load the AddHeroUserControl form / page
        private void MainApplciation_Load(object sender, EventArgs e)
        {
            // Load the AddHeroUserControl by default
            LoadUserControl(new AddHeroUserControl());
        }
    }
}
