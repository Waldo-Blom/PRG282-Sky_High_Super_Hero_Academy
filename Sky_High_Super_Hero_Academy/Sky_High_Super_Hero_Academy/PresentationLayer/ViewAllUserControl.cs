using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Sky_High_Super_Hero_Academy.BusinessLayer;

namespace Sky_High_Super_Hero_Academy.PresentationLayer
{
    public partial class ViewAllUserControl : UserControl
    {
        private readonly List<Superhero> heroes = new List<Superhero>();
        private readonly Superhero_FileHandler fileHandler = new Superhero_FileHandler();

        public ViewAllUserControl()
        {
            InitializeComponent();
        }

        private void ViewAllUserControl_Load(object sender, EventArgs e)
        {
            LoadFromFile();
        }

        private void LoadFromFile()
        {
            try
            {
                var all = fileHandler.ReadAllSuperheroes() ?? new List<Superhero>();
                heroes.Clear();
                heroes.AddRange(all);
                PopulateGrid(heroes);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load superheroes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulateGrid(IEnumerable<Superhero> heroesToShow) //fill DataGridView rows from list
        {
            dataGridViewHeroes.Rows.Clear();

            foreach (var h in heroesToShow)
            {
                dataGridViewHeroes.Rows.Add(
                    h.HeroID,
                    h.Name,
                    h.Age,
                    h.Superpower,
                    h.ExamScore,
                    h.Rank,
                    h.ThreatLevel,
                    "Delete",
                    "Edit"
                );
            }
        }
 
        private void btnSearch_Click(object sender, EventArgs e) //search button
        {
            var q = (txtSearch.Text ?? string.Empty).Trim();
            if (string.IsNullOrEmpty(q))
            {
                PopulateGrid(heroes);
                return;
            }

            var filtered = heroes.Where(h =>
                (h.HeroID ?? string.Empty).IndexOf(q, StringComparison.OrdinalIgnoreCase) >= 0 ||
                (h.Name ?? string.Empty).IndexOf(q, StringComparison.OrdinalIgnoreCase) >= 0 ||
                (h.Superpower ?? string.Empty).IndexOf(q, StringComparison.OrdinalIgnoreCase) >= 0 ||
                (h.Rank ?? string.Empty).IndexOf(q, StringComparison.OrdinalIgnoreCase) >= 0 ||
                (h.ThreatLevel ?? string.Empty).IndexOf(q, StringComparison.OrdinalIgnoreCase) >= 0
            );

            PopulateGrid(filtered);
        }

        private void btnRefresh_Click(object sender, EventArgs e)//refresh button
        {
            LoadFromFile();
            txtSearch.Clear();
        }

        
        private void dataGridViewHeroes_CellContentClick(object sender, DataGridViewCellEventArgs e)//handle Delete, Edit clicks
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            var grid = (DataGridView)sender;

            var deleteCol = grid.Columns["colDelete"];
            var editCol = grid.Columns["colEdit"];

            if (deleteCol != null && e.ColumnIndex == deleteCol.Index)
            {
                //Delete clicked
                var heroId = Convert.ToString(grid.Rows[e.RowIndex].Cells["colHeroID"].Value ?? "");
                var heroName = Convert.ToString(grid.Rows[e.RowIndex].Cells["colName"].Value ?? "");

                var confirm = MessageBox.Show($"Delete hero {heroName} ({heroId})? This cannot be undone.", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm != DialogResult.Yes)
                    return;

                try
                {
                    fileHandler.DeleteSuperhero(heroId);
                    LoadFromFile();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to delete hero: " + ex.Message, "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (editCol != null && e.ColumnIndex == editCol.Index)
            {
                //Edit clicked
                var heroId = Convert.ToString(grid.Rows[e.RowIndex].Cells["colHeroID"].Value ?? "");
                var existing = heroes.FirstOrDefault(h => string.Equals(h.HeroID, heroId, StringComparison.OrdinalIgnoreCase));
                if (existing == null)
                {
                    MessageBox.Show("Selected hero not found in memory.", "Edit Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (var editForm = new EditHeroForm(existing.HeroID, existing.Name, existing.Age.ToString(), existing.Superpower, existing.ExamScore.ToString(), existing.Rank, existing.ThreatLevel))
                {
                    if (editForm.ShowDialog(FindForm()) == DialogResult.OK)
                    {
                        // parse and validate
                        if (!int.TryParse(editForm.HeroAge, out var newAge))
                        {
                            MessageBox.Show("Age must be a valid integer.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        if (!double.TryParse(editForm.HeroExamScore, out var newExam))
                        {
                            MessageBox.Show("Exam Score must be a valid number.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }

                        try
                        {
                            // Create a new instance so rank/threat are recalculated from exam score
                            Superhero updated = new Superhero(existing.HeroID, editForm.HeroName, newAge, editForm.HeroSuperpower, newExam);
                            fileHandler.UpdateSuperhero(existing.HeroID, updated);
                            LoadFromFile();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Failed to update hero: " + ex.Message, "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

 

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            txtSearch.Text = "";
        }

    }
}
