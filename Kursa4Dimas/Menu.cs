using System;
using System.Windows.Forms;

namespace Kursach
{
    public partial class Menu : Form
    {
        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
        public Menu()
        {
            InitializeComponent();
            wplayer.URL = "C:\\Users\\4859554\\source\\repos\\Kursa4Dimas\\Kursa4Dimas\\bin\\Debug\\Music\\music.mp3";
            wplayer.controls.play();
        }

        private void StartGameButton_Click(object sender, EventArgs e)
        {
            LevelMenu gameWindow = new LevelMenu(wplayer);
            gameWindow.Show();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonRecords_Click(object sender, EventArgs e)
        {
            Records gameWindow = new Records();
            gameWindow.Show();
        }
    }
}
