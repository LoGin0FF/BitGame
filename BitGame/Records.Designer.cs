
namespace Kursach
{
    partial class Records
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Records));
            this.LabelRecords = new System.Windows.Forms.Label();
            this.LabelRec = new System.Windows.Forms.Label();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelRecords
            // 
            this.LabelRecords.AutoSize = true;
            this.LabelRecords.BackColor = System.Drawing.Color.Black;
            this.LabelRecords.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRecords.ForeColor = System.Drawing.Color.White;
            this.LabelRecords.Location = new System.Drawing.Point(243, 174);
            this.LabelRecords.Name = "LabelRecords";
            this.LabelRecords.Size = new System.Drawing.Size(166, 41);
            this.LabelRecords.TabIndex = 7;
            this.LabelRecords.Text = "Рекорды";
            // 
            // LabelRec
            // 
            this.LabelRec.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelRec.AutoSize = true;
            this.LabelRec.BackColor = System.Drawing.Color.White;
            this.LabelRec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelRec.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRec.ForeColor = System.Drawing.Color.Black;
            this.LabelRec.Location = new System.Drawing.Point(243, 257);
            this.LabelRec.Name = "LabelRec";
            this.LabelRec.Size = new System.Drawing.Size(165, 43);
            this.LabelRec.TabIndex = 8;
            this.LabelRec.Text = "250 / 490";
            // 
            // ButtonExit
            // 
            this.ButtonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonExit.BackColor = System.Drawing.Color.Black;
            this.ButtonExit.Font = new System.Drawing.Font("Algerian", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonExit.ForeColor = System.Drawing.Color.White;
            this.ButtonExit.Location = new System.Drawing.Point(-1, 469);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(653, 83);
            this.ButtonExit.TabIndex = 10;
            this.ButtonExit.Text = "Выход в главное меню";
            this.ButtonExit.UseVisualStyleBackColor = false;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // Records
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(652, 618);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.LabelRec);
            this.Controls.Add(this.LabelRecords);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Records";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Records";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelRecords;
        private System.Windows.Forms.Label LabelRec;
        private System.Windows.Forms.Button ButtonExit;
    }
}