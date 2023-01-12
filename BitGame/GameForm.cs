using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Kursach
{
    public partial class GameForm : Form
    {
        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
        WMPLib.WindowsMediaPlayer wplayer2 = new WMPLib.WindowsMediaPlayer();
        WMPLib.WindowsMediaPlayer wplayer3 = new WMPLib.WindowsMediaPlayer();
        List<int> ColorList = new List<int>();
        Random rand = new Random();
        List<PictureBox> pictureBoxList = new List<PictureBox>(5);
        int NowColor = -1;
        int Score = 0, MAX_SCORE;
        int GlobalJ = 0;
        public GameForm(int level)
        {
            InitializeComponent();
            timer.Tick += new System.EventHandler(Update);
            KeyDown += new KeyEventHandler(Check);
            Init(level);
        }
        private void Update(object sender, EventArgs e) //по тику таймера обновление (сдвиг клеток)
        {
            var pictureBoxList = this.Controls.OfType<PictureBox>()
            .Where(x => x.Name.StartsWith("pictureBox"))
            .ToList(); 
            int j = GlobalJ;
            for (int i = 0; i < pictureBoxList.Count; i++)
            {
                switch (ColorList[j++])
                {
                    case 1:
                        pictureBoxList[i].BackColor = Color.Lime;
                        break;
                    case 2:
                        pictureBoxList[i].BackColor = Color.Red;
                        break;
                    case 3:
                        pictureBoxList[i].BackColor = Color.Yellow;
                        break;
                    case 4:
                        pictureBoxList[i].BackColor = Color.Blue;
                        break;
                }
            }
            NowColor = ColorList[GlobalJ];
            GameOver();
            ProgressBarMusic.Value += 1;
            GlobalJ++;
            Invalidate();
        }
        public int Press(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D1:
                    Button1_Click(sender,e);
                    return 1;
                case Keys.D2:
                    Button2_Click(sender, e);
                    return 2;
                case Keys.D3:
                    Button3_Click(sender, e);
                    return 3;
                case Keys.D4:
                    Button4_Click(sender, e);
                    return 4;
                case Keys.Escape:
                    wplayer3.controls.stop();
                    this.Close();
                    return -1;
                default:
                    return 0;
            }
        }
        public void Check(object sender, KeyEventArgs e)
        {
            int Pr = Press(sender, e);
            if (Pr != NowColor && Pr != -1)
            {
                wplayer2.URL = "./Music/no.wav";
                wplayer2.controls.play();
                Score_Update(-10);
            }
            else
            {
                wplayer2.URL = "./Music/bass.wav";
                wplayer2.controls.play();
                if (Pr != -1)
                    Score_Update(10);
            }
        }
        public void GameOver()
        {
            if (ProgressBarMusic.Value + 1 == ProgressBarMusic.Maximum)
            {
                string filename = "./Records";
                bool flag = true;
                timer.Stop();
                wplayer3.controls.stop();
                using (BinaryReader read = new BinaryReader(File.Open(filename, FileMode.Open)))
                {
                    int ScoreFile = read.ReadInt32();
                    if (Score > ScoreFile) flag = true;
                }
                if (flag)
                {
                    using (BinaryWriter write = new BinaryWriter(File.Open("Records", FileMode.OpenOrCreate)))
                    {
                        write.Write(Score);
                        write.Write(MAX_SCORE);
                    }
                }
                GameOver gameWindow = new GameOver(Score, MAX_SCORE);
                this.Close();
                gameWindow.Show();
            }
        }
        public void LoadLevel(int level)
        {
            string filename = "";
            switch (level)
            {
                case 1:
                    filename = "./Levels/Level1";
                    wplayer.controls.stop();
                    wplayer3.URL = "./Music/music.mp3";
                    timer.Interval = 700;
                    LabelSpeed.Text = "Скорость: " + 700 + "мс";
                    break;
                case 2:
                    filename = "./Levels/Level2";
                    wplayer.controls.stop();
                    wplayer3.URL = "./Music/music2.mp3";
                    timer.Interval = 500;
                    LabelSpeed.Text = "Скорость: " + 500 + "мс";
                    break;
                default:
                    break;
            }
            MAX_SCORE = 500;
            using (BinaryReader read = new BinaryReader(File.Open(filename, FileMode.Open)))
            {
                while (read.PeekChar() != -1)
                {
                    ColorList.Add(read.ReadInt32());
                }
            }
        }
        public void Init(int level)
        {
            LoadLevel(level);
            wplayer3.controls.play();
            LabelScore.Text = "Score: " + Score + " / " + MAX_SCORE;
        }
        #region [Button]
        private void Button1_Click(object sender, EventArgs e)
        {}
        private void Button2_Click(object sender, EventArgs e)
        {}
        private void Button3_Click(object sender, EventArgs e)
        {}
        private void Button4_Click(object sender, EventArgs e)
        {}
        #endregion
        public void Score_Update(int ScoreUp)
        {
            Score += ScoreUp;
            LabelScore.Text = "Score: " + Score + " / " + MAX_SCORE;
        }
    }
}
