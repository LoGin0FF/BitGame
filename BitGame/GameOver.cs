using System;
using System.Windows.Forms;

namespace Kursach
{
    public partial class GameOver : Form
    {
        public GameOver(int Score, int MAX_SCORE)
        {
            InitializeComponent();
            LabelScore.Text = "Score: " + Score + " / " + MAX_SCORE;
        }

        private void ButtonLevel1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
