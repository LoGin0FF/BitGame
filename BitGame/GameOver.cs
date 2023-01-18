using System;
using System.Windows.Forms;

namespace Kursach
{
    public partial class GameOver : Form
    {
        string MAX_SCORE = "500";
        public GameOver(int Score)
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
