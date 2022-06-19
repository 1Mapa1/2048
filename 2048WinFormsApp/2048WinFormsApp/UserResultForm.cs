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
    public partial class UserResultForm : Form
    {
        private List<User> userResults = UsersResultStorage.Get();
        public UserResultForm()
        {
            InitializeComponent();
        }

        private void UserResultForm_Load(object sender, EventArgs e)
        {
            foreach(var userResult in userResults)
            {
                userResultDataGridView.Rows.Add(userResult.NameUser, userResult.Score);
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
