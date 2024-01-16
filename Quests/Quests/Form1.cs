using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Quests
{
    public partial class Form1 : Form
    {
        private const string connectionString = "Server=localhost;Database=quests;User ID=Aremenel;Password=root;";
        
        public Form1()
        {
            InitializeComponent();
            SpawnAtBottomLeft();
        }

        private void SpawnAtBottomLeft()
        {
            this.StartPosition = FormStartPosition.Manual;
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


// using (MySqlConnection connection = new MySqlConnection(connectionString))
// {
//     connection.Open();
//
//     // Replace "YourTableName" with the actual name of your table
//     string query = "INSERT INTO activeQuests (questID, questName, category) VALUES (1, 'testQuest', 'programming')";
//
//     using (MySqlCommand command = new MySqlCommand(query, connection))
//     {
//         int rowsAffected = command.ExecuteNonQuery();
//
//         if (rowsAffected > 0)
//         {
//             MessageBox.Show("Quest added successfully!");
//         }
//         else
//         {
//             MessageBox.Show("Failed to add quest.");
//         }
//     }
// }