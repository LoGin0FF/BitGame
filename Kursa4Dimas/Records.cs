using System;
using System.IO;
using System.Windows.Forms;

namespace Kursach
{
    public partial class Records : Form
    {
        string filename = "C:\\Users\\4859554\\source\\repos\\Kursa4Dimas\\Kursa4Dimas\\bin\\Debug\\Records";
        public Records()
        {
            InitializeComponent();
            using (BinaryReader read = new BinaryReader(File.Open(filename, FileMode.Open)))
            {
                if (read.PeekChar() == -1)
                    LabelRec.Visible = false;
                else
                {
                    LabelRec.Visible = true;
                    int Score = read.ReadInt32();
                    int MAX_SCORE = read.ReadInt32();
                    LabelRec.Text = Score + " / " + MAX_SCORE;
                }
            }
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
