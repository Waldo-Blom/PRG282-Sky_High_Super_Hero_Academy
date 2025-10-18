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
    public partial class EditHeroUserControl : UserControl
    {
        public EditHeroUserControl()
        {
            InitializeComponent();
        }

        private void EditHeroUserControl_Load(object sender, EventArgs e)
        {

        }

        public void LoadHero(string id, string name,string age, string superpower, string examscore)
        {
            txtEditHeroID.Text = id;
            txtEditHeroName.Text = name;
            txtEditAge.Text = age;
            txtEditSuperpower.Text = superpower;
            txtEditExamScore.Text = examscore;
        }

        private void btnCloseEdit_Click(object sender, EventArgs e)
        {
            // Find the parent form
            Form parentForm = this.FindForm();

            if (parentForm != null)
            {
                // Remove the EditHeroUserControl
                parentForm.Controls.Remove(this);

                // Show the ViewAll user control when the cancel btn is clicked
                ViewAllUserControl viewAllHeroes = new ViewAllUserControl();
                viewAllHeroes.Dock = DockStyle.Fill;
                parentForm.Controls.Add(viewAllHeroes);
                viewAllHeroes.BringToFront();
            }
        }
    }
}
