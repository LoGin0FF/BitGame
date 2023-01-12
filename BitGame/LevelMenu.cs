using System;
using System.Windows.Forms;
using WMPLib;

namespace Kursach
{
    public partial class LevelMenu : Form
    {
        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
        public LevelMenu(WindowsMediaPlayer wplayer)
        {
            InitializeComponent();
            this.wplayer = wplayer;
        }
        private void ButtonLevel1_Click(object sender, EventArgs e)
        {
            GameForm gameWindow = new GameForm(1);
            wplayer.controls.stop();
            this.Close();
            gameWindow.Show();
        }

        private void ButtonExit(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonLevel2_Click(object sender, EventArgs e)
        {
            GameForm gameWindow = new GameForm(2);
            wplayer.controls.stop();
            this.Close();
            gameWindow.Show();
        }
    }
}
