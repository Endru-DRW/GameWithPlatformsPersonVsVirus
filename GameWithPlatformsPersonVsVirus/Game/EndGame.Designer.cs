namespace GameWithPlatformsPersonVsVirus.Game
{
    partial class EndGame
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
            this.txtScore = new System.Windows.Forms.Label();
            this.MainMenuButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtScore
            // 
            this.txtScore.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.Location = new System.Drawing.Point(140, 296);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(372, 142);
            this.txtScore.TabIndex = 33;
            this.txtScore.Text = " Felicitări! Ai terminat jocul! Te așteaptă mai multe nivele pe viitor!";
            this.txtScore.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // MainMenuButton
            // 
            this.MainMenuButton.BackColor = System.Drawing.Color.Transparent;
            this.MainMenuButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MainMenuButton.Cursor = System.Windows.Forms.Cursors.No;
            this.MainMenuButton.FlatAppearance.BorderSize = 0;
            this.MainMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainMenuButton.Location = new System.Drawing.Point(13, 14);
            this.MainMenuButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MainMenuButton.Name = "MainMenuButton";
            this.MainMenuButton.Size = new System.Drawing.Size(57, 35);
            this.MainMenuButton.TabIndex = 34;
            this.MainMenuButton.UseVisualStyleBackColor = false;
            this.MainMenuButton.Click += new System.EventHandler(this.MainMenuButton_Click_1);
            // 
            // EndGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(654, 749);
            this.Controls.Add(this.MainMenuButton);
            this.Controls.Add(this.txtScore);
            this.Name = "EndGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Final";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Button MainMenuButton;
    }
}