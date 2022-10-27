﻿using System;
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
    public partial class MainMenu : Form
    {
        SoundPlayer menuMusic = new SoundPlayer(Resources.main_menu);

        public MainMenu()
        {
            InitializeComponent();

            //play Music
            menuMusic.PlayLooping();

        }

        //Start
        private void button1_Click(object sender, EventArgs e)
        {
            FrmLevel newGame = new FrmLevel();
            
            newGame.Show();
            
            menuMusic.Stop();

            Hide(); //can't Close(), will shut down entire application
        }

        //Quit
        private void button3_Click(object sender, EventArgs e) 
        {
            Close();
        }

        //Settings
        public void button2_Click(object sender, EventArgs e) 
        {
            Settings changeSettings = new Settings();

            changeSettings.Menu = this;

            changeSettings.Show();
            
            Hide();

        }

    }
}
