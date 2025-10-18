using System;
using System.Drawing;
using System.Windows.Forms;

namespace Sky_High_Super_Hero_Academy.PresentationLayer
{
    public class EditHeroForm : Form
    {
        private readonly Label lblId;
        private readonly TextBox txtName;
        private readonly TextBox txtAge;
        private readonly TextBox txtSuperpower;
        private readonly TextBox txtExamScore;
        private readonly Button btnOk;
        private readonly Button btnCancel;

        public string HeroId { get; }
        public string HeroName => txtName.Text.Trim();
        public string HeroAge => txtAge.Text.Trim();
        public string HeroSuperpower => txtSuperpower.Text.Trim();
        public string HeroExamScore => txtExamScore.Text.Trim();

        public EditHeroForm(string heroId, string name, string age, string superpower, string examScore, string rank, string threatLevel)
        {
            Text = "Edit Hero";
            Size = new Size(420, 360);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            StartPosition = FormStartPosition.CenterParent;
            MaximizeBox = false;
            MinimizeBox = false;
            ShowInTaskbar = false;

            HeroId = heroId;

            var lblIdCaption = new Label { Text = "Hero ID:", Left = 12, Top = 14, Width = 80 };
            lblId = new Label { Text = HeroId, Left = 100, Top = 14, Width = 280, ForeColor = Color.Blue };

            var lblName = new Label { Text = "Name:", Left = 12, Top = 46, Width = 80 };
            txtName = new TextBox { Left = 100, Top = 42, Width = 280, Text = name };

            var lblAge = new Label { Text = "Age:", Left = 12, Top = 78, Width = 80 };
            txtAge = new TextBox { Left = 100, Top = 74, Width = 280, Text = age };

            var lblSuper = new Label { Text = "Superpower:", Left = 12, Top = 110, Width = 80 };
            txtSuperpower = new TextBox { Left = 100, Top = 106, Width = 280, Text = superpower };

            var lblExam = new Label { Text = "Exam Score:", Left = 12, Top = 142, Width = 80 };
            txtExamScore = new TextBox { Left = 100, Top = 138, Width = 280, Text = examScore };

            btnOk = new Button { Text = "OK", Left = 200, Width = 90, Top = 250, DialogResult = DialogResult.OK };
            btnCancel = new Button { Text = "Cancel", Left = 300, Width = 90, Top = 250, DialogResult = DialogResult.Cancel };

            btnOk.Click += BtnOk_Click;

            Controls.Add(lblIdCaption);
            Controls.Add(lblId);
            Controls.Add(lblName);
            Controls.Add(txtName);
            Controls.Add(lblAge);
            Controls.Add(txtAge);
            Controls.Add(lblSuper);
            Controls.Add(txtSuperpower);
            Controls.Add(lblExam);
            Controls.Add(txtExamScore);
            Controls.Add(btnOk);
            Controls.Add(btnCancel);

            AcceptButton = btnOk;
            CancelButton = btnCancel;
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Name is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.None;
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
