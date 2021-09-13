using System;
using System.Windows.Forms;

namespace test5
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private int time = 10;
        private async void BtnStartGame_Click(object sender, EventArgs e)
        {
            ResetGame();
            BtnClickGame.Enabled = true;
            timer1.Start();
            await Game.StartGame();
            MessageBox.Show($"Score: {Lbl_Score.Text}");
        }

        private void BtnClickGame_Click(object sender, EventArgs e)
        {
            var i = int.Parse(Lbl_Score.Text);
            i++;
            Lbl_Score.Text = i.ToString();
        }
        private void ResetGame()
        {
            Lbl_Score.Text = "0";
            Lbl_Timer.Text = "10";
            time = 10;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time--;
            Lbl_Timer.Text = time.ToString();
            if (time == 0)
            {
                timer1.Stop();
                BtnClickGame.Enabled = false;
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();
        }
    }
}
