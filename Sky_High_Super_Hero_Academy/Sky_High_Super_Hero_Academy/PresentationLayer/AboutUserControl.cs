using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sky_High_Super_Hero_Academy.PresentationLayer
{
    public partial class AboutUserControl : UserControl
    {
        public AboutUserControl()
        {
            InitializeComponent();
        }

        private void AboutUserControl_Load(object sender, EventArgs e)
        {
            // This is used to wrap the lable: Credit to https://stackoverflow.com/questions/1204804/word-wrap-for-a-label-in-windows-forms
            lblAboutDescrip.MaximumSize = new Size(900, 0);
            lblAboutDescrip.AutoSize = true;
        }
    }
}
