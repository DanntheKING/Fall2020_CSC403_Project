using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using Fall2020_CSC403_Project.Properties;


namespace Fall2020_CSC403_Project
{
    public partial class FrmDeath : Form
    {
        SoundPlayer deathTheme = new SoundPlayer(Resources.deathTheme);
        public FrmDeath()
        {
            InitializeComponent();

            deathTheme.PlayLooping();
        }

        //Retry game
        private void button1_Click(object sender, EventArgs e)
        {
            MainMenu newMainMenu = new MainMenu();

            deathTheme.Stop();

            Close();

            newMainMenu.Show();

        }

        //Quit Game
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
