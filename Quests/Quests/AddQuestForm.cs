using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Quests
{
    public partial class AddQuestForm : Form
    {
        private const string ConnectionString = "Server=localhost;Database=quests;User ID=Aremenel;Password=LourieJane02!;";

        private const string FillInformationMessage = "Please fill out both the information needed for the quest!";
        private const string FillQuestNameMessage = "Please fill a quest name before undergoing one!";
        private const string SelectCategoryMessage = "Please select a quest category before undergoing one!";
        private const string QuestAddedSuccessfullyMessage = "Quest added successfully!";

        public AddQuestForm()
        {
            InitializeComponent();
        }

        private void addQuest_Click(object sender, EventArgs e)
        {
            // Get values from TextBox and ComboBox
            string questName = questString.Text;
            string category = questCategory.Text;

            if (ValidateInputs(questName, category))
            {
                InsertQuest(questName, category);

                questString.Text = string.Empty;
                questCategory.SelectedIndex = -1;
                MessageBox.Show(QuestAddedSuccessfullyMessage);
                this.Close();
            }
        }

        private bool ValidateInputs(string questName, string category)
        {
            if (string.IsNullOrEmpty(questName) && string.IsNullOrEmpty(category))
            {
                MessageBox.Show(FillInformationMessage);
                return false;
            }

            if (string.IsNullOrEmpty(questName))
            {
                MessageBox.Show(FillQuestNameMessage);
                return false;
            }

            if (string.IsNullOrEmpty(category))
            {
                MessageBox.Show(SelectCategoryMessage);
                return false;
            }

            return true;
        }

        private void InsertQuest(string questName, string category)
        {
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                connection.Open();

                string insertQuery = "INSERT INTO ActiveQuests (questName, category) VALUES (@questName, @category)";

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
