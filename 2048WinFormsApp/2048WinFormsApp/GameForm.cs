using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2048ClassLibrary;

namespace _2048WinFormsApp
{
    public partial class GameForm : Form
    {
        private int mapSize = MainForm.MapSize;
        private Label[,] map;
        private static Random random = new Random();
        private int score = 0;
        private User bestUser = MainForm.BestUser;
        private int lableSIze = 70;
        public GameForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            InitMap();
            GenirateNumber();
            bestScoreLabel.Text = bestUser.Score.ToString();
        }

        private void InitMap()
        {
            map = new Label[mapSize, mapSize];
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    var newLable = CreateLable(i, j);
                    Controls.Add(newLable);
                    map[i, j] = newLable;
                }
            }
        }

        private void GenirateNumber()
        {
            string number;
            if (random.Next(1, 101) <= 75)
            {
                number = "2";
            }
            else
            {
                number = "4";
            }

            bool value = false;
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    if (map[i, j].Text == string.Empty)
                    {
                        while (true)
                        {
                            var randomNumberLable = random.Next(mapSize * mapSize);
                            var indexRow = randomNumberLable / mapSize;
                            var indexColumn = randomNumberLable % mapSize;
                            if (map[indexRow, indexColumn].Text == string.Empty)
                            {
                                map[indexRow, indexColumn].Text = number;
                                map[indexRow, indexColumn].BackColor = ColorTranslator.FromHtml(GetColor(Convert.ToInt32(number)));
                                value = true;
                                break;
                            }
                        }
                        break;
                    }
                }
                if (value)
                {
                    break;
                }
            }
        }

        private void ShowScore()
        {
            scoreLabel.Text = score.ToString();
            if (score > bestUser.Score)
            {
                bestUser.Score = score;
                bestScoreLabel.Text = bestUser.Score.ToString();
                bestUser.NameUser = MainForm.NameUser;
            }
        }

        private Label CreateLable(int indexRow, int indexColumn)
        {
            var label = new Label();
            label.BackColor = SystemColors.ButtonShadow;
            label.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label.Size = new Size(lableSIze, lableSIze);
            label.TextAlign = ContentAlignment.MiddleCenter;
            int x = 10 + indexColumn * 76;
            int y = 70 + indexRow * 78;
            label.Location = new Point(x, y);

            return label;
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D || e.KeyCode == Keys.Left || e.KeyCode == Keys.A || e.KeyCode == Keys.Up || e.KeyCode == Keys.W || e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
                {
                    PressRight();
                }
                if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
                {
                    PressLeft();
                }
                if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
                {
                    PressUp();
                }
                if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
                {
                    PressDown();
                }

                ShowScore();

                if (Win())
                {
                    WinForm winForm = new WinForm();
                    winForm.ShowDialog();
                    if(winForm.menu)
                    {
                        exitToolStripMenuItem.PerformClick();
                    }
                    if(winForm.restart)
                    {
                        restartToolStripMenuItem.PerformClick();                    }
                    return;
                }

                GenirateNumber();
            }
        }

        private bool Win()
        {
            foreach (var item in map)
            {
                if (item.Text == "16")
                {
                    return true;
                }
            }
            
            return false;
        }

        private void PressDown()
        {
            for (int j = 0; j < mapSize; j++)
            {
                for (int i = mapSize - 1; i >= 0; i--)
                {
                    if (map[i, j].Text != string.Empty)
                    {
                        for (int k = i - 1; k >= 0; k--)
                        {
                            if (map[k, j].Text != string.Empty)
                            {
                                if (map[i, j].Text == map[k, j].Text)
                                {
                                    ChangeColor(map[i, j], map[k, j]);
                                }
                                break;
                            }
                        }
                    }
                }
            }

            for (int j = 0; j < mapSize; j++)
            {
                for (int i = mapSize - 1; i >= 0; i--)
                {
                    if (map[i, j].Text == string.Empty)
                    {
                        for (int k = i - 1; k >= 0; k--)
                        {
                            if (map[k, j].Text != string.Empty)
                            {
                                map[i, j].Text = map[k, j].Text;
                                map[i, j].BackColor = map[k, j].BackColor;
                                map[k, j].Text = string.Empty;
                                map[k, j].BackColor = SystemColors.ButtonShadow;
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void PressUp()
        {
            for (int j = 0; j < mapSize; j++)
            {
                for (int i = 0; i < mapSize; i++)
                {
                    if (map[i, j].Text != string.Empty)
                    {
                        for (int k = i + 1; k < mapSize; k++)
                        {
                            if (map[k, j].Text != string.Empty)
                            {
                                if (map[i, j].Text == map[k, j].Text)
                                {
                                    ChangeColor(map[i, j], map[k, j]);
                                }
                                break;
                            }
                        }
                    }
                }
            }

            for (int j = 0; j < mapSize; j++)
            {
                for (int i = 0; i < mapSize; i++)
                {
                    if (map[i, j].Text == string.Empty)
                    {
                        for (int k = i + 1; k < mapSize; k++)
                        {
                            if (map[k, j].Text != string.Empty)
                            {
                                map[i, j].Text = map[k, j].Text;
                                map[i, j].BackColor = map[k, j].BackColor;
                                map[k, j].Text = string.Empty;
                                map[k, j].BackColor = SystemColors.ButtonShadow;
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void PressLeft()
        {
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    if (map[i, j].Text != string.Empty)
                    {
                        for (int k = j + 1; k < mapSize; k++)
                        {
                            if (map[i, k].Text != string.Empty)
                            {
                                if (map[i, j].Text == map[i, k].Text)
                                {
                                    ChangeColor(map[i, j], map[i, k]);
                                }
                                break;
                            }
                        }
                    }
                }
            }

            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    if (map[i, j].Text == string.Empty)
                    {
                        for (int k = j + 1; k < mapSize; k++)
                        {
                            if (map[i, k].Text != string.Empty)
                            {
                                map[i, j].Text = map[i, k].Text;
                                map[i, j].BackColor = map[i, k].BackColor;
                                map[i, k].Text = string.Empty;
                                map[i, k].BackColor = SystemColors.ButtonShadow;
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void PressRight()
        {
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = mapSize - 1; j >= 0; j--)
                {
                    if (map[i, j].Text != string.Empty)
                    {
                        for (int k = j - 1; k >= 0; k--)
                        {
                            if (map[i, k].Text != string.Empty)
                            {
                                if (map[i, j].Text == map[i, k].Text)
                                {
                                    ChangeColor(map[i, j], map[i, k]);
                                }
                                break;
                            }
                        }
                    }
                }
            }

            for (int i = 0; i < mapSize; i++)
            {
                for (int j = mapSize - 1; j >= 0; j--)
                {
                    if (map[i, j].Text == string.Empty)
                    {
                        for (int k = j - 1; k >= 0; k--)
                        {
                            if (map[i, k].Text != string.Empty)
                            {
                                map[i, j].Text = map[i, k].Text;
                                map[i, j].BackColor = map[i, k].BackColor;
                                map[i, k].Text = string.Empty;
                                map[i, k].BackColor = SystemColors.ButtonShadow;
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void ChangeColor(Label lable1, Label lable2)
        {
            var number = int.Parse(lable1.Text);
            score += number * 2;
            lable1.Text = (number * 2).ToString();
            lable1.BackColor = ColorTranslator.FromHtml(GetColor(number * 2));
            lable2.Text = string.Empty;
            lable2.BackColor = SystemColors.ButtonShadow;
        }

        private void ruleButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Если в одной строчке или в одном столбце находится более двух плиток одного номинала, то при сбрасывании они начинают соединяться с той стороны, в которую были направлены.", "ПРАВИЛА");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            if (score != 0)
            {
                SaveUser();
            }
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var lable in map)
            {
                lable.Text = "";
                lable.BackColor = SystemColors.ButtonShadow;
            }
            if (score != 0)
            {
                SaveUser();
            }
            score = 0;
            scoreLabel.Text = "0";
            GenirateNumber();
        }

        private void правилаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Если в одной строчке или в одном столбце находится более двух плиток одного номинала, то при сбрасывании они начинают соединяться с той стороны, в которую были направлены.", "ПРАВИЛА");
        }

        private string GetColor(int number)
        {
            switch(number)
            {
                case 2: return "#ffff9e";
                case 4: return "#FFDB8B";
                case 8: return "#FFCF40";
                case 16: return "#FFCF48";
                case 32: return "#FFDB58";
                case 64: return "#F4A900";
                case 128: return "#EDFF21";
                case 256: return "#E1CC4F";
                case 512: return "#CDA434";
                case 1024: return "#D6AE01";
                case 2048: return "#FFB300";
            }
            return "";
        }
        private void SaveUser()
        {
            var user = new User(MainForm.NameUser, score);

            UsersResultStorage.Append(user);
        }
        
    }
}
