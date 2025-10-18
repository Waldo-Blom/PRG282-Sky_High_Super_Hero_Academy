using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Sky_High_Super_Hero_Academy.PresentationLayer
{
    public partial class ViewAllUserControl : UserControl
    {
        private readonly List<Hero> _heroes = new List<Hero>();
        private readonly string _dataFilePath;

        public ViewAllUserControl()
        {
            InitializeComponent();

            // file lives alongside exe; change path if you prefer a different location
            _dataFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "superheroes.txt");

            EnsureDataFileExists();
            LoadFromFile();
        }
            
        private void ViewAllUserControl_Load(object sender, EventArgs e)
        {
        }

        //ensure file exists
        private void EnsureDataFileExists()
        {
            if (!File.Exists(_dataFilePath))
            {
                File.WriteAllLines(_dataFilePath, new[] {
                    //sample rows
                    "H001|Tempest Strike|28|Lightning Manipulation|95|S|Finals Week",
                    "H002|Iron Phoenix|32|Metal Control|88|A|Midterm Madness",
                    "H003|Shadow Whisper|24|Shadow Teleportation|76|B|Group Project Gone Wrong",
                    "H004|Crimson Blade|29|Enhanced Strength|82|C|Pop Quiz"
                });
            }
        }

       
        private void LoadFromFile() //load heroes from file into memory and populate grid
        {
            _heroes.Clear();

            try
            {
                var lines = File.ReadAllLines(_dataFilePath);
                foreach (var line in lines)
                {
                    if (string.IsNullOrWhiteSpace(line))
                        continue;
 
                    var parts = line.Split(new[] { '|' }, StringSplitOptions.None); //expected format: HeroID|Name|Age|Superpower|ExamScore|Rank|ThreatLevel
                    if (parts.Length < 7)
                        continue;

                    var hero = new Hero
                    {
                        HeroId = parts[0].Trim(),
                        Name = parts[1].Trim(),
                        Age = parts[2].Trim(),
                        Superpower = parts[3].Trim(),
                        ExamScore = parts[4].Trim(),
                        Rank = parts[5].Trim(),
                        ThreatLevel = parts[6].Trim()
                    };

                    _heroes.Add(hero);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load heroes from file: {ex.Message}", "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            PopulateGrid(_heroes);
        }

        private void SaveAllToFile()//save current in memory list to file
        {
            try
            {
                var lines = _heroes.Select(h => $"{h.HeroId}|{h.Name}|{h.Age}|{h.Superpower}|{h.ExamScore}|{h.Rank}|{h.ThreatLevel}");
                File.WriteAllLines(_dataFilePath, lines);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to save heroes to file: {ex.Message}", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void PopulateGrid(IEnumerable<Hero> heroesToShow) //fill DataGridView rows from list
        {
            dataGridViewHeroes.Rows.Clear();

            foreach (var h in heroesToShow)
            {
                dataGridViewHeroes.Rows.Add(
                    h.HeroId,
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
                PopulateGrid(_heroes);
                return;
            }

            var filtered = _heroes.Where(h =>
                h.HeroId.IndexOf(q, StringComparison.OrdinalIgnoreCase) >= 0 ||
                h.Name.IndexOf(q, StringComparison.OrdinalIgnoreCase) >= 0 ||
                h.Superpower.IndexOf(q, StringComparison.OrdinalIgnoreCase) >= 0 ||
                h.Rank.IndexOf(q, StringComparison.OrdinalIgnoreCase) >= 0 ||
                h.ThreatLevel.IndexOf(q, StringComparison.OrdinalIgnoreCase) >= 0
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

                var existing = _heroes.FirstOrDefault(h => string.Equals(h.HeroId, heroId, StringComparison.OrdinalIgnoreCase));
                if (existing != null)
                {
                    _heroes.Remove(existing);
                    SaveAllToFile();
                    PopulateGrid(_heroes);
                }
                else
                {
                    // fallback: remove row visually
                    grid.Rows.RemoveAt(e.RowIndex);
                }
            }
            else if (editCol != null && e.ColumnIndex == editCol.Index)
            {
                //Edit clicked
                var heroId = Convert.ToString(grid.Rows[e.RowIndex].Cells["colHeroID"].Value ?? "");
                var existing = _heroes.FirstOrDefault(h => string.Equals(h.HeroId, heroId, StringComparison.OrdinalIgnoreCase));
                if (existing == null)
                {
                    MessageBox.Show("Selected hero not found in memory.", "Edit Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (var editForm = new EditHeroForm(existing.HeroId, existing.Name, existing.Age, existing.Superpower, existing.ExamScore, existing.Rank, existing.ThreatLevel))
                {
                    if (editForm.ShowDialog(FindForm()) == DialogResult.OK)
                    {
                        // update in-memory
                        existing.Name = editForm.HeroName;
                        existing.Age = editForm.HeroAge;
                        existing.Superpower = editForm.HeroSuperpower;
                        existing.ExamScore = editForm.HeroExamScore;
                        existing.Rank = editForm.HeroRank;
                        existing.ThreatLevel = editForm.HeroThreatLevel;

                        SaveAllToFile();
                        PopulateGrid(_heroes);
                    }
                }
            }
        }

        //hero model
        private class Hero
        {
            public string HeroId { get; set; }
            public string Name { get; set; }
            public string Age { get; set; }
            public string Superpower { get; set; }
            public string ExamScore { get; set; }
            public string Rank { get; set; }
            public string ThreatLevel { get; set; }
        }
    }
}
