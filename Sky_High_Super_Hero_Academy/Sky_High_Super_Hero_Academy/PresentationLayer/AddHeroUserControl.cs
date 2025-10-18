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

        private (string rank, string threat) ComputeRankAndThreat(int score)
        {
            string rank;
            if (score >= 95) rank = "S";
            else if (score >= 85) rank = "A";
            else if (score >= 70) rank = "B";
            else if (score >= 50) rank = "C";
            else rank = "D";

            string threat;
            if (score >= 95) threat = "Extreme";
            else if (score >= 85) threat = "High";
            else if (score >= 70) threat = "Moderate";
            else if (score >= 50) threat = "Low";
            else threat = "Minimal";

            return (rank, threat);
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
            _errorProvider.Clear();

            if (!TryCollectInputs(out var id, out var name, out var age, out var superpower, out var examScore))
                return;

            var (rank, threat) = ComputeRankAndThreat(examScore);

            try
            {
                var filePath = GetDataFilePath();
                Directory.CreateDirectory(Path.GetDirectoryName(filePath) ?? AppDomain.CurrentDomain.BaseDirectory);

                if (RecordExists(filePath, id))
                {
                    var resp = MessageBox.Show($"A hero with ID '{id}' already exists. Overwrite?", "Confirm overwrite", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resp != DialogResult.Yes)
                        return;

                    ReplaceRecord(filePath, id, FormatRecord(id, name, age, superpower, examScore, rank, threat));
                }
                else
                {
                    AppendRecord(filePath, FormatRecord(id, name, age, superpower, examScore, rank, threat));
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
            if (int.TryParse((txtExamScore.Text ?? string.Empty).Trim(), out var score) && score >= 0 && score <= 100)
            {
                var (rank, threat) = ComputeRankAndThreat(score);
                txtInfo.Text = $"  Rank: {rank} — Threat Level: {threat}";
            }
            else
            {
                txtInfo.Text = "Rank and Threat Level will be automatically calculated based on Exam Score";
            }
        }

        private string GetDataFilePath()
        {
            return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "superheroes.txt");
        }

        private static string Quote(string s)
        {
            if (s == null) return "\"\"";
            return "\"" + s.Replace("\"", "\"\"") + "\"";
        }

        private string FormatRecord(string id, string name, int age, string superpower, int examScore, string rank, string threat)
        {
            // CSV: Id,Name,Age,Superpower,ExamScore,Rank,ThreatLevel
            return string.Join(",", new[]
            {
        Quote(id),
        Quote(name),
        age.ToString(),
        Quote(superpower),
        examScore.ToString(),
        Quote(rank),
        Quote(threat)
    });
        }

        private void AppendRecord(string filePath, string line)
        {
            using (var sw = new StreamWriter(filePath, true, Encoding.UTF8))
                sw.WriteLine(line);
        }

        private bool RecordExists(string filePath, string id)
        {
            if (!File.Exists(filePath))
                return false;

            foreach (var raw in File.ReadAllLines(filePath, Encoding.UTF8))
            {
                if (string.IsNullOrWhiteSpace(raw)) continue;
                var first = ParseCsvFirstField(raw);
                if (string.Equals(first, id, StringComparison.OrdinalIgnoreCase))
                    return true;
            }
            return false;
        }

        private void ReplaceRecord(string filePath, string id, string newLine)
        {
            var lines = File.Exists(filePath) ? File.ReadAllLines(filePath, Encoding.UTF8) : new string[0];
            for (int i = 0; i < lines.Length; i++)
            {
                if (string.Equals(ParseCsvFirstField(lines[i]), id, StringComparison.OrdinalIgnoreCase))
                {
                    lines[i] = newLine;
                    File.WriteAllLines(filePath, lines, Encoding.UTF8);
                    return;
                }
            }
            // not found -> append
            AppendRecord(filePath, newLine);
        }

        // Extract first CSV field (handles quoted field with escaped quotes)
        private string ParseCsvFirstField(string line)
        {
            if (string.IsNullOrEmpty(line)) return string.Empty;
            var i = 0;
            var inQuotes = false;
            var sb = new StringBuilder();
            while (i < line.Length)
            {
                var c = line[i];
                if (!inQuotes)
                {
                    if (c == '"')
                    {
                        inQuotes = true;
                    }
                    else if (c == ',')
                    {
                        break;
                    }
                    else
                    {
                        sb.Append(c);
                    }
                }
                else
                {
                    if (c == '"' && i + 1 < line.Length && line[i + 1] == '"')
                    {
                        sb.Append('"');
                        i++; // skip escaped quote
                    }
                    else if (c == '"')
                    {
                        inQuotes = false;
                    }
                    else
                    {
                        sb.Append(c);
                    }
                }
                i++;
            }
            return sb.ToString();
        }
    }
}
