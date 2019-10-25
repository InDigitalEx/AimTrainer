using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AimTrainer
{
    public partial class GameForm : Form
    {
        private int GameScore = 0;
        private int Countdown = 3;

        private void Game_MoveTarget()
        {
            Random random = new Random();
            GameTarget.Location = new Point(random.Next(Size.Width - GameTarget.Size.Width - 50), random.Next(Size.Height - GameTarget.Size.Height - 50));
            // 50 оффсет поля
        }
        private void Game_TargerClick()
        {
            GameScore++;
            Game_MoveTarget();
            GameScoreLabel.Text = "Score: " + GameScore.ToString();
        }
        private void Game_Start()
        {
            GameOverTimer.Enabled = true;
            GameTarget.Visible = true;
            GameTarget.Enabled = true;
            Game_MoveTarget();
        }
        private void Game_End()
        {
            string text = "Ваш счет: " + GameScore.ToString();
            MessageBox.Show(text, "Игра окончена", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void Game_Init()
        {
            Countdown--;
            if (Countdown == 0) // Если отсчет закончился
            {
                CountdownLabel.Text = "GO";
                CountdownTimer.Interval = 500; // Ставим интервал 500 мсек на скрытие надписи "GO"
            }
            else if (Countdown == -1) // Если прошли 500 мсек после окончания отсчета, то удаляем таймер и лейбл
            {
                CountdownLabel.Dispose();
                CountdownTimer.Dispose();
                Game_Start();
            }
            else
            {
                CountdownLabel.Text = Countdown.ToString();
            }
        }

        //
        //
        //

        public GameForm()
        {
            InitializeComponent();
        }
        private void GameForm_Load(object sender, EventArgs e)
        {
            Owner.Visible = false;
            Owner.Enabled = false;
            CountdownTimer.Enabled = true;
            CountdownLabel.Text = Countdown.ToString();

        }
        private void GameForm_Closed(object sender, FormClosedEventArgs e)
        {
            Owner.Visible = true;
            Owner.Enabled = true;
        }

        private void CountdownTimer_Tick(object sender, EventArgs e)
        {
            Game_Init();
        }

        private void GameOverTimer_Tick(object sender, EventArgs e)
        {
            Game_End();
        }

        private void GameTarget_Click(object sender, EventArgs e)
        {
            Game_TargerClick();
        }
    }
}
