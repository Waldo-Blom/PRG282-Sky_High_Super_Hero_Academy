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
    public partial class AddHeroUserControl : UserControl
    {
        private readonly ErrorProvider _errorProvider = new ErrorProvider();

        public AddHeroUserControl()
        {
            InitializeComponent();

            // Wire UI to backend handlers
            btnAddSuperhero.Click += btnAddSuperhero_Click;
            btnClear.Click += btnClear_Click;
            txtExamScore.TextChanged += txtExamScore_TextChanged;

            _errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;

        }

        private bool TryCollectInputs(out string id, out string name, out int age, out string superpower, out int examScore)
        {
            id = (txtHeroID.Text ?? string.Empty).Trim();
            name = (txtHeroName.Text ?? string.Empty).Trim();
            superpower = (txtSuperpower.Text ?? string.Empty).Trim();
            age = 0;
            examScore = -1;

            var ok = true;
            _errorProvider.Clear();

            if (string.IsNullOrWhiteSpace(id))
            {
                _errorProvider.SetError(txtHeroID, "Hero ID is required.");
                ok = false;
            }

            if (string.IsNullOrWhiteSpace(name))
            {
                _errorProvider.SetError(txtHeroName, "Hero name is required.");
                ok = false;
            }

            if (!int.TryParse((txtAge.Text ?? string.Empty).Trim(), out age) || age <= 0)
            {
                _errorProvider.SetError(txtAge, "Enter a valid positive age.");
                ok = false;
            }

            if (string.IsNullOrWhiteSpace(superpower))
            {
                _errorProvider.SetError(txtSuperpower, "Superpower is required.");
                ok = false;
            }

            if (!int.TryParse((txtExamScore.Text ?? string.Empty).Trim(), out examScore) || examScore < 0 || examScore > 100)
            {
                _errorProvider.SetError(txtExamScore, "Enter an exam score between 0 and 100.");
                ok = false;
            }

            return ok;
        }



        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtSuperpower_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddSuperhero_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void txtExamScore_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
