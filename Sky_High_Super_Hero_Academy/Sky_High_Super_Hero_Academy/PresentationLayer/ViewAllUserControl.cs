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
    public partial class ViewAllUserControl : UserControl
    {
        public ViewAllUserControl()
        {
            InitializeComponent();
            LoadMockData();
        }

        private void ViewAllUserControl_Load(object sender, EventArgs e)
        {

        }

        // This will be removed later when the file storage is implemented, just for display purposes for now
        private void LoadMockData()
        {
            dataGridViewHeroes.Rows.Add("H001", "Tempest Strike", "28", "Lightning Manipulation", "95", "S", "Finals Week", "Delete", "Edit");
            dataGridViewHeroes.Rows.Add("H002", "Iron Phoenix", "32", "Metal Control", "88", "A", "Midterm Madness", "Delete", "Edit");
            dataGridViewHeroes.Rows.Add("H003", "Shadow Whisper", "24", "Shadow Teleportation", "76", "B", "Group Project Gone Wrong", "Delete", "Edit");
            dataGridViewHeroes.Rows.Add("H004", "Crimson Blade", "29", "Enhanced Strength", "82", "c", "Pop Quiz", "Delete", "Edit");
        }
    }
}
