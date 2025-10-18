using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sky_High_Super_Hero_Academy.BusinessLayer; // use Superhero and file handler

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

        private bool TryCollectInputs(out string id, out string name, out int age, out string superpower, out double examScore)
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

            if (!double.TryParse((txtExamScore.Text ?? string.Empty).Trim(), out examScore) || examScore < 0 || examScore > 100)
            {
                _errorProvider.SetError(txtExamScore, "Enter an exam score between 0 and 100.");
                ok = false;
            }

            return ok;
        }

        private void btnAddSuperhero_Click(object sender, EventArgs e)
        {
            _errorProvider.Clear();

            if (!TryCollectInputs(out var id, out var name, out var age, out var superpower, out var examScore))
                return;

            try
            {
                Superhero hero = new Superhero(id, name, age, superpower, examScore);

                Superhero_FileHandler handler = new Superhero_FileHandler();

                // Check if hero exists already
                var existing = handler.ReadAllSuperheroes()
                                       .FirstOrDefault(h => string.Equals(h.HeroID, id, StringComparison.OrdinalIgnoreCase));

                if (existing != null)
                {
                    var resp = MessageBox.Show($"A hero with ID '{id}' already exists. Overwrite?", "Confirm overwrite", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resp != DialogResult.Yes)
                        return;

                    handler.UpdateSuperhero(id, hero);
                }
                else
                {
                    handler.AddSuperhero(hero);
                }

                MessageBox.Show("Hero saved successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnClear_Click(this, EventArgs.Empty); // clear inputs
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to save hero: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtHeroID.Clear();
            txtHeroName.Clear();
            txtAge.Clear();
            txtSuperpower.Clear();
            txtExamScore.Clear();
            txtInfo.Text = "  Rank and Threat Level will be automatically calculated based on Exam Score";
            _errorProvider.Clear();
        }

        private void txtExamScore_TextChanged(object sender, EventArgs e)
        {
            UpdateRankThreatPreview();
        }

        private void UpdateRankThreatPreview()
        {
            double score;
            if (double.TryParse((txtExamScore.Text ?? string.Empty).Trim(), out score) && score >= 0 && score <= 100)
            {
                try
                {
                    var id = string.IsNullOrWhiteSpace(txtHeroID.Text) ? "PREVIEW" : txtHeroID.Text.Trim();
                    var name = string.IsNullOrWhiteSpace(txtHeroName.Text) ? "Preview" : txtHeroName.Text.Trim();
                    var superpower = string.IsNullOrWhiteSpace(txtSuperpower.Text) ? "-" : txtSuperpower.Text.Trim();
                    var age = 1; // minimal positive age to satisfy validation
                    var previewHero = new Superhero(id, name, age, superpower, score);
                    txtInfo.Text = $"  Rank: {previewHero.Rank} — Threat Level: {previewHero.ThreatLevel}";
                }
                catch
                {
                    txtInfo.Text = "  Rank and Threat Level will be automatically calculated based on Exam Score";
                }
            }
            else
            {
                txtInfo.Text = "Rank and Threat Level will be automatically calculated based on Exam Score";
            }
        }
    }
}
