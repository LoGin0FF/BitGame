using System;
using System.IO;
using System.Windows.Forms;

namespace Kursach
{
    public partial class Records : Form
    {
        string filename = "./Records";
        public Records()
        {
            InitializeComponent();
            using (BinaryReader read = new BinaryReader(File.Open(filename, FileMode.Open)))
            {
                int Score = read.ReadInt32();
                int MAX_SCORE = read.ReadInt32();
                LabelRec.Text = Score + " / " + MAX_SCORE;
            }
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
