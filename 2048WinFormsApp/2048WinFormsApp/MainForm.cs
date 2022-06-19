using _2048ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2048WinFormsApp
{
    public partial class MainForm : Form
    {
        public static string NameUser;
        public static int MapSize; 
        public static User BestUser = new();
        public MainForm()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (CheckUserName(nameTextBox.Text))
            {
                this.Hide();
                NameUser = nameTextBox.Text;
                MapSize = Convert.ToInt32(mapSizeComboBox.Text);
                GameForm gameForm = new GameForm();
                gameForm.ShowDialog();
                CalculateBestUser();
                this.Show();
            }
        }

        private bool CheckUserName(string nameUser)
        {
            if (nameUser == "")
            {
                MessageBox.Show("Вы забыли ввести данные.");
                return false;
            }

            return true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CalculateBestUser();
        }

        private void resultGamesButton_Click(object sender, EventArgs e)
        {
            var userResultForm = new UserResultForm();
            userResultForm.ShowDialog();
        }

        private void CalculateBestUser()
        {
            var userResults = UsersResultStorage.Get();
            foreach (var userResult in userResults)
            {
                if (userResult.Score > BestUser.Score)
                {
                    BestUser = userResult;
                }
            }
            if (BestUser.NameUser == "")
            {
                bestUserLabel.Text = "Пока ещё нет лучшего игрока";
            }
            else
            {
                bestUserLabel.Text = $"Лучший игрок: {BestUser.NameUser}. Счет: {BestUser.Score}";
            }
        }
        
    }
}
