using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Quests
{
    public partial class AddQuestForm : Form
    {
        private const string ConnectionString = "Server=localhost;Database=quests;User ID=Aremenel;Password=LourieJane02!;";

        public AddQuestForm()
        {
            InitializeComponent();
        }

        private void addQuest_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                connection.Open();

                // Get values from TextBox and ComboBox
                String questName = questString.Text;
                String category = questCategory.Text;

                // Insert into the ActiveQuests table
                String insertQuery = "INSERT INTO ActiveQuests (questName, category) VALUES (@questName, @category)";

                using (MySqlCommand cmd = new MySqlCommand(insertQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@questName", questName);
                    cmd.Parameters.AddWithValue("@category", category);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}