
namespace Kursach
{
    partial class GameOver
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameOver));
            this.LabelScore = new System.Windows.Forms.Label();
            this.LabelGameOver = new System.Windows.Forms.Label();
            this.ButtonLevel1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelScore
            // 
            this.LabelScore.AutoSize = true;
            this.LabelScore.BackColor = System.Drawing.SystemColors.WindowText;
            this.LabelScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelScore.ForeColor = System.Drawing.Color.White;
            this.LabelScore.Location = new System.Drawing.Point(164, 330);
            this.LabelScore.Name = "LabelScore";
            this.LabelScore.Size = new System.Drawing.Size(329, 46);
            this.LabelScore.TabIndex = 7;
            this.LabelScore.Text = "Score: 250 / 500";
            // 
            // LabelGameOver
            // 
            this.LabelGameOver.AutoSize = true;
            this.LabelGameOver.BackColor = System.Drawing.SystemColors.WindowText;
            this.LabelGameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelGameOver.ForeColor = System.Drawing.Color.White;
            this.LabelGameOver.Location = new System.Drawing.Point(214, 170);
            this.LabelGameOver.Name = "LabelGameOver";
            this.LabelGameOver.Size = new System.Drawing.Size(233, 46);
            this.LabelGameOver.TabIndex = 8;
            this.LabelGameOver.Text = "Game Over";
            // 
            // ButtonLevel1
            // 
            this.ButtonLevel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonLevel1.BackColor = System.Drawing.Color.Black;
            this.ButtonLevel1.Font = new System.Drawing.Font("Algerian", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonLevel1.ForeColor = System.Drawing.Color.White;
            this.ButtonLevel1.Location = new System.Drawing.Point(0, 467);
            this.ButtonLevel1.Name = "ButtonLevel1";
            this.ButtonLevel1.Size = new System.Drawing.Size(653, 83);
            this.ButtonLevel1.TabIndex = 9;
            this.ButtonLevel1.Text = "Выход в главное меню";
            this.ButtonLevel1.UseVisualStyleBackColor = false;
            this.ButtonLevel1.Click += new System.EventHandler(this.ButtonLevel1_Click);
            // 
            // GameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(652, 618);
            this.Controls.Add(this.ButtonLevel1);
            this.Controls.Add(this.LabelGameOver);
            this.Controls.Add(this.LabelScore);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "GameOver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameOver";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelScore;
        private System.Windows.Forms.Label LabelGameOver;
        private System.Windows.Forms.Button ButtonLevel1;
    }
}