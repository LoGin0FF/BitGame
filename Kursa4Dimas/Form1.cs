using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursach
{
    public partial class GameForm : Form
    {
        List<int> ColorList = new List<int>();
        Random rand = new Random();
        int NowColor = -1;
        int Score = 0;
        public GameForm()
        {
            InitializeComponent();
            for (int i = 0; i < 20; i++)
            {
                ColorList.Add(GenerationRandom(rand));
            }
            timer.Tick += new System.EventHandler(Update);
            KeyDown += new KeyEventHandler(Check);
        }
        public int GenerationRandom(Random rng)
        {
            return rng.Next(1,5);
        }
        private void Update(object sender, EventArgs e)
        {
            RandomUpdate();
            Invalidate();
        }
        public void RandomUpdate()
        {
            int randSwitch = NowColor;
            do
            {
                randSwitch = GenerationRandom(rand);
            }
            while (randSwitch == NowColor);
            switch (randSwitch)
            {
                case 1:
                    PictureBoxColor.BackColor = Color.Lime;
                    break;
                case 2:
                    PictureBoxColor.BackColor = Color.Red;
                    break;
                case 3:
                    PictureBoxColor.BackColor = Color.Yellow;
                    break;
                case 4:
                    PictureBoxColor.BackColor = Color.Blue;
                    break;
                case 5:
                    PictureBoxColor.BackColor = Color.Violet;
                    break;
            }
            NowColor = randSwitch;
            ProgressBarMusic.Value += 1;
        }
        public int Press(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D1:
                    Button1_Click(sender,e);
                    return 1;
                case Keys.D2:
                    button2_Click(sender, e);
                    return 2;
                case Keys.D3:
                    button3_Click(sender, e);
                    return 3;
                case Keys.D4:
                    button4_Click(sender, e);
                    return 4;
                case Keys.D5:
                    button5_Click(sender, e);
                    return 5;
                default:
                    return 0;
            }
        }
        public void Check(object sender, KeyEventArgs e)
        {
            int Pr = Press(sender, e);
            if (Pr != NowColor)
            {
                Score_Update(-10);
            }
            else
            {
                Score_Update(10);
            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }
        public void Score_Update(int ScoreUp)
        {
            Score += ScoreUp;
            LabelScore.Text = "Score: " + Score;
        }

        
    }
}
