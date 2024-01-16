using System;
using System.Windows.Forms;

namespace Quests
{
    public partial class Form1 : Form
    {
        
        
        public Form1()
        {
            InitializeComponent();
            SpawnAtBottomLeft();
        }

        private void SpawnAtBottomLeft()
        {
            StartPosition = FormStartPosition.Manual;
            int taskbarHeight = Screen.PrimaryScreen.Bounds.Height - Screen.PrimaryScreen.WorkingArea.Height;
            int x = 0;
            int y = Screen.PrimaryScreen.Bounds.Height - taskbarHeight - this.Height; 
            this.Location = new System.Drawing.Point(x, y);
        }

        private void addQuestButton_Click(object sender, EventArgs e)
        {
            AddQuestForm addQuestForm = new AddQuestForm();
            addQuestForm.StartPosition = FormStartPosition.CenterScreen;
            addQuestForm.Show();
        }
    }
}


