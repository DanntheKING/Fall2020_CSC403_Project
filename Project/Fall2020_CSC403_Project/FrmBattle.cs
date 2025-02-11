﻿using Fall2020_CSC403_Project.code;
using Fall2020_CSC403_Project.Properties;
using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project {
  public partial class FrmBattle : Form {
    public static FrmBattle instance = null;
    private Enemy enemy;
    private Player player;

    public bool battleMusicOn;
    private SoundPlayer music;

    public FrmLevel level;
    public FrmDeath deathScreen;

    private FrmBattle() {
      InitializeComponent();
      player = Game.player;
    }

    public void Setup() {
      // update for this enemy
      picEnemy.BackgroundImage = enemy.Img;
      picEnemy.Refresh();
      BackColor = enemy.Color;
      picBossBattle.Visible = false;

      // Observer pattern
      enemy.AttackEvent += PlayerDamage;
      player.AttackEvent += PlayerArmor;
      player.AttackEvent += EnemyDamage;
      
      

      // show health
      UpdateHealthBars();
    }

    public void SetupForBossBattle() {
      picBossBattle.Location = Point.Empty;
      picBossBattle.Size = ClientSize;
      picBossBattle.Visible = true;

      tmrFinalBattle.Enabled = true;
    }

    public static FrmBattle GetInstance(Enemy enemy) {
      if (instance == null) {
        instance = new FrmBattle();
        instance.enemy = enemy;
        if(instance.enemy.Boss == true)
        {

          instance.enemy.MaxHealth = 100;

          instance.enemy.Health = instance.enemy.MaxHealth;
        }
        instance.Setup();
      }
      return instance;
    }

    private void UpdateHealthBars() {
      float playerHealthPer = player.Health / (float)player.MaxHealth;
      float playerArmorPer = player.Armors / (float)player.MaxArmor;
      float enemyHealthPer = enemy.Health / (float)enemy.MaxHealth;

      const int MAX_HEALTHBAR_WIDTH = 226;
      lblPlayerHealthFull.Width = (int)(MAX_HEALTHBAR_WIDTH * playerHealthPer);
      lblPlayerArmorFull.Width = (int)(MAX_HEALTHBAR_WIDTH * playerArmorPer);
      lblEnemyHealthFull.Width = (int)(MAX_HEALTHBAR_WIDTH * enemyHealthPer);

      lblPlayerHealthFull.Text = player.Health.ToString();
      lblPlayerArmorFull.Text = player.Armors.ToString();
      lblEnemyHealthFull.Text = enemy.Health.ToString();
    }
    
    private void btnAttack_Click(object sender, EventArgs e) {
      player.OnAttack(-2);
      if (enemy.Health > 0) {
      if (player.Armors > 0 & player.Armors < 51)
      {
          PlayerArmor(-4);
      }
      else
      {
          enemy.OnAttack(-2);
      }
      }



      UpdateHealthBars();
      if (enemy.Health <= 0) {
        instance = null;
        Close();
      }

      if (player.Health <= 0)
        {
            instance = null;
            Close();

            level.Close();
            
            deathScreen = new FrmDeath();
            deathScreen.Show();
        }

    }

    // Retreat button
    private void btnRetreat_Click(object sender, EventArgs e)
    {
        if (player.Health > 0 && enemy.Health > 0)
        {
            UpdateHealthBars();
            instance = null;
            music.Stop();
            Close();
        }
    }
    // Counter button
    private void btnCounter_Click(object sender, EventArgs e) 
    {   enemy.OnAttack(-2);
        if(player.Health > 0)
        {
            player.OnAttack(-1);
        }
        UpdateHealthBars();
        if(player.Health <= 0 || enemy.Health <= 0) 
        { 
            instance = null;
            music.Stop();
            Close();
        }
    }

    // Finisher button
    private void btnFinisher_Click(object sender, EventArgs e)
    {
        if(enemy.Health < 20 && player.Health > enemy.Health) 
        {
            player.OnAttack(-(enemy.Health));
        }
        UpdateHealthBars();
        if(player.Health <= 0 || enemy.Health <= 0) 
        { 
            instance = null;
            music.Stop();
            Close();
        }
    
    }
    private void EnemyDamage(int amount) {
      enemy.AlterHealth(amount);
    }

    private void PlayerDamage(int amount) {
      player.AlterHealth(amount);
    }

    private void PlayerArmor(int amount)
    {
        player.AlterArmor(amount);
    }

        private void tmrFinalBattle_Tick(object sender, EventArgs e) {
      picBossBattle.Visible = false;
      tmrFinalBattle.Enabled = false;
    }


    private void PlayNonBossMusic()
        {
            music = new SoundPlayer(Resources.nonBossTheme);
            music.PlayLooping();
        }    
        
    private void PlayBossMusic()
        {
            music = new SoundPlayer(Resources.newFinalTheme);
            music.PlayLooping();
        }



    public void UpdateSettings(bool musicIsOn, bool enemyIsBoss)
        {
            if (musicIsOn && enemyIsBoss)
            {
                PlayBossMusic();
            }
            else if (musicIsOn)
            {
                PlayNonBossMusic();
            }
        }

    private void FrmBattle_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (level.lvlMusicOn)
            {
                music.Stop(); //stop any music playing
            }
            level.UpdateHealthText(); //update player health text every time a form closes
        }
    }
}
