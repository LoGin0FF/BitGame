
namespace Kursach
{
    partial class LevelMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LevelMenu));
            this.ButtonLevel1 = new System.Windows.Forms.Button();
            this.ButtonLevel2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonLevel1
            // 
            this.ButtonLevel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonLevel1.BackColor = System.Drawing.Color.White;
            this.ButtonLevel1.Font = new System.Drawing.Font("Modern No. 20", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonLevel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonLevel1.Location = new System.Drawing.Point(28, 161);
            this.ButtonLevel1.Name = "ButtonLevel1";
            this.ButtonLevel1.Size = new System.Drawing.Size(230, 64);
            this.ButtonLevel1.TabIndex = 2;
            this.ButtonLevel1.Text = "Уровень 1";
            this.ButtonLevel1.UseVisualStyleBackColor = false;
            this.ButtonLevel1.Click += new System.EventHandler(this.ButtonLevel1_Click);
            // 
            // ButtonLevel2
            // 
            this.ButtonLevel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonLevel2.BackColor = System.Drawing.Color.White;
            this.ButtonLevel2.Font = new System.Drawing.Font("Modern No. 20", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonLevel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonLevel2.Location = new System.Drawing.Point(28, 319);
            this.ButtonLevel2.Name = "ButtonLevel2";
            this.ButtonLevel2.Size = new System.Drawing.Size(230, 64);
            this.ButtonLevel2.TabIndex = 3;
            this.ButtonLevel2.Text = "Уровень 2";
            this.ButtonLevel2.UseVisualStyleBackColor = false;
            this.ButtonLevel2.Click += new System.EventHandler(this.ButtonLevel2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(28, 476);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(230, 64);
            this.button1.TabIndex = 4;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.ButtonExit);
            // 
            // LevelMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(652, 618);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ButtonLevel2);
            this.Controls.Add(this.ButtonLevel1);
            this.DoubleBuffered = true;
            this.Name = "LevelMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LevelMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonLevel1;
        private System.Windows.Forms.Button ButtonLevel2;
        private System.Windows.Forms.Button button1;
    }
}