using System;
using System.Drawing;
using System.Windows.Forms;

namespace Quests
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            SpawnAtBottomLeft();
            CreateAndUpdateRunningPanel();
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
            addQuestForm.ShowDialog();
        }

        private void CreateAndUpdateRunningPanel()
        {
            Panel panel = new Panel();
            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.Size = new System.Drawing.Size(310, 50);
            panel.Padding = new Padding(10, 5, 10, 5);
            int leftMargin = (flowLayoutPanel.Width - panel.Width / 2);
            panel.Location = new Point(leftMargin, panel.Location.Y);
            panel.BackColor = Color.Aqua;
            
            flowLayoutPanel.Controls.Add(panel);
        }
    }
}


