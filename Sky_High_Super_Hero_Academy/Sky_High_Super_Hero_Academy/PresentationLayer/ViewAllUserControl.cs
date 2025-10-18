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

            dataGridViewHeroes.CellContentClick += dataGridViewHeroes_CellContentClick; // Event handler for edit and delete button click in DataGridView

            txtSearch.Text = "Search heroes ..."; // Acts as placeholder text, on the txtSearch_MouseEnter event it will be cleared
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

        private void txtSearch_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void txtSearch_MouseLeave(object sender, EventArgs e)
        {

        }

        private void dataGridViewHeroes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ignore header clicks or invalid rows
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            // Identify what column was clicked
            var clickedColumn = dataGridViewHeroes.Columns[e.ColumnIndex];

            // Check if the Edit column was clicked
            if (clickedColumn.Name == "colEdit")
            {
                // Get the hero's data from the row
                string heroId = dataGridViewHeroes.Rows[e.RowIndex].Cells["colHeroID"].Value.ToString();
                string heroName = dataGridViewHeroes.Rows[e.RowIndex].Cells["colName"].Value.ToString();
                string heroAge = dataGridViewHeroes.Rows[e.RowIndex].Cells["colAge"].Value.ToString();
                string heroSuperpower = dataGridViewHeroes.Rows[e.RowIndex].Cells["colSuperpower"].Value.ToString();
                string heroExamScore = dataGridViewHeroes.Rows[e.RowIndex].Cells["colExamScore"].Value.ToString();

                // Create EditHero user control 
                var editControl = new EditHeroUserControl();

                // Load the hero data into the edit control textboxes
                editControl.LoadHero(heroId, heroName,heroAge, heroSuperpower, heroExamScore);

                // Add the panel dynamically
                editControl.Dock = DockStyle.Fill;
                this.Controls.Add(editControl);
                editControl.BringToFront();
            }

            // Check the Delete column was clicked
            if (clickedColumn.Name == "colDelete") 
            {
                //functionality to be implemeted here
            }
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            txtSearch.Text = "";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
          
        }
    }
}
