using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Quests
{
    public partial class MainForm : Form
    {
        private const string ConnectionString = "Server=localhost;Database=quests;User ID=Aremenel;Password=LourieJane02!;";
        private Timer updateTimer;

        public MainForm()
        {
            InitializeComponent();
            SpawnAtBottomLeft();
            CreateAndUpdateRunningPanel();
            
            
            flowLayoutPanel.AutoScroll = true;
            flowLayoutPanel.HorizontalScroll.Maximum = 0;
            flowLayoutPanel.WrapContents = true;
            
            updateTimer = new Timer();
            updateTimer.Interval = 30000; 
            updateTimer.Tick += UpdateTimer_Tick;
            updateTimer.Start();
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
            RefreshPanels();
        }

        private void CreateAndUpdateRunningPanel()
        {
            RefreshPanels();
        }

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            RefreshPanels();
        }

        private DataTable GetActiveQuests()
        {
            DataTable dataTable = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                connection.Open();
                string query = "SELECT questID, questName FROM activeQuests";

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                {
                    adapter.Fill(dataTable);
                }
            }

            return dataTable;
        }
        
        private void RefreshPanels()
        {
            DataTable activeQuests = GetActiveQuests();
            foreach (DataRow row in activeQuests.Rows)
            {
                string questName = row["questName"].ToString();
                int questID = Convert.ToInt32(row["questID"]);
                CreateQuestPanel(questID, questName);
            }
        }

        private void CreateQuestPanel(int questID, string questName)
        {
            if (flowLayoutPanel.Controls.ContainsKey("Panel_" + questID))
            {
                return; 
            }

            Panel panel = new Panel();
            panel.Name = "Panel_" + questID; 
            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.Size = new System.Drawing.Size(315, 50);
            panel.Padding = new Padding(10, 5, 10, 5);
            int leftMargin = (flowLayoutPanel.Width - panel.Width / 2);
            panel.Location = new System.Drawing.Point(leftMargin, panel.Location.Y);

            Label questPanelLabel = new Label();
            questPanelLabel.AutoSize = true;
            questPanelLabel.Font = new Font("Minecraft", 7, FontStyle.Regular);
            questPanelLabel.Text = "Quest: " + questName;
            questPanelLabel.Location = new Point(5, 5);
            

            Label questRewardLabel = new Label();
            questRewardLabel.AutoSize = true;
            questRewardLabel.Font = new Font("Minecraft", 7, FontStyle.Regular);
            questRewardLabel.Text = "Reward: " + GetRandomRewardFromDatabase(); 
            questRewardLabel.Location = new Point(150, 5);

            panel.Controls.Add(questPanelLabel);
            panel.Controls.Add(questRewardLabel);
            
            panel.Click += (sender, e) => Panel_Click(questID, panel);
            
            flowLayoutPanel.Controls.Add(panel);
        }
        
        private string GetRandomRewardFromDatabase()
        {
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                connection.Open();
                string query = "SELECT rewardName FROM questrewards ORDER BY RAND() LIMIT 1";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    object result = cmd.ExecuteScalar();
                    return result?.ToString() ?? "No Reward"; 
                }
            }
        }
        
        private void Panel_Click(int questID, Panel clickedPanel)  
        {
            // Reset the background color of all panels
            foreach (Control control in flowLayoutPanel.Controls)
            {
                if (control is Panel panel)
                {
                    panel.BackColor = SystemColors.Control; 
                }
            }
            
            clickedPanel.BackColor = Color.LightBlue;
            
            
        }
    }
    
    
}
