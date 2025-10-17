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
