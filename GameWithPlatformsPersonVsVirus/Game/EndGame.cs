using System;
using System.Windows.Forms;

namespace GameWithPlatformsPersonVsVirus.Game
{
    public partial class EndGame : Form
    {
        public EndGame()
        {
            InitializeComponent();
        }
        private void MainMenuButton_Click_1(object sender, EventArgs e)
        {
            StartPageOfTheGame startPage = new StartPageOfTheGame();
            startPage.Show();
            Visible = false;
        }
    }
}
