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
    public partial class FrmWin : Form
    {

        SoundPlayer winTheme = new SoundPlayer(Resources.winTheme);

        public FrmWin()
        {
            InitializeComponent();

            winTheme.Play();
        }

        //Quit
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainMenu newGame = new MainMenu();

            winTheme.Stop();

            Close();

            newGame.Show();
        }
    }
}
