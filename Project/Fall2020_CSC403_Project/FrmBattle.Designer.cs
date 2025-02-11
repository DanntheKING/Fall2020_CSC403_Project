﻿namespace Fall2020_CSC403_Project {
  partial class FrmBattle {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(140, 113);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(458, 44);
            this.label1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(1030, 113);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(458, 44);
            this.label2.TabIndex = 5;

      this.components = new System.ComponentModel.Container();
      this.btnAttack = new System.Windows.Forms.Button();
      this.btnRetreat = new System.Windows.Forms.Button();
      this.btnCounter = new System.Windows.Forms.Button();
      this.btnFinisher = new System.Windows.Forms.Button();
      this.lblPlayerHealthFull = new System.Windows.Forms.Label();
      this.lblPlayerArmorFull = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.lblEnemyHealthFull = new System.Windows.Forms.Label();
      this.picBossBattle = new System.Windows.Forms.PictureBox();
      this.picEnemy = new System.Windows.Forms.PictureBox();
      this.picHeart = new System.Windows.Forms.PictureBox();
      this.picPlayer = new System.Windows.Forms.PictureBox();
      this.tmrFinalBattle = new System.Windows.Forms.Timer(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.picBossBattle)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.picEnemy)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.picHeart)).BeginInit();
      this.SuspendLayout();
      // 
      // btnAttack
      // 
      this.btnAttack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnAttack.Location = new System.Drawing.Point(127, 422);
      this.btnAttack.Name = "btnAttack";
      this.btnAttack.Size = new System.Drawing.Size(128, 43);
      this.btnAttack.TabIndex = 2;
      this.btnAttack.Text = "Attack";
      this.btnAttack.UseVisualStyleBackColor = true;
      this.btnAttack.Click += new System.EventHandler(this.btnAttack_Click);
	  //
      // btnRetreat
      //
      this.btnRetreat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnRetreat.Location = new System.Drawing.Point(258, 422);
      this.btnRetreat.Name = "btnRetreat";
      this.btnRetreat.Size = new System.Drawing.Size(128, 43);
      this.btnRetreat.TabIndex = 8;
      this.btnRetreat.Text = "Retreat";
      this.btnRetreat.UseVisualStyleBackColor = true;
      this.btnRetreat.Click += new System.EventHandler(this.btnRetreat_Click);
      //
      // btnCounter
      //
      this.btnCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnCounter.Location = new System.Drawing.Point(389, 422);
      this.btnCounter.Name = "btnCounter";
      this.btnCounter.Size = new System.Drawing.Size(128, 43);
      this.btnCounter.TabIndex = 9;
      this.btnCounter.Text = "Counter";
      this.btnCounter.UseVisualStyleBackColor = true;
      this.btnCounter.Click += new System.EventHandler(this.btnCounter_Click);
      //
      // btnFinisher
      //
      this.btnFinisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnFinisher.Location = new System.Drawing.Point(520, 422);
      this.btnFinisher.Name = "btnFinisher";
      this.btnFinisher.Size = new System.Drawing.Size(128, 43);
      this.btnFinisher.TabIndex = 10;
      this.btnFinisher.Text = "Finisher";
      this.btnFinisher.UseVisualStyleBackColor = true;
      this.btnFinisher.Click += new System.EventHandler(this.btnFinisher_Click);
      //
      // lblPlayerHealthFull
      // 
      this.lblPlayerHealthFull.BackColor = System.Drawing.Color.Blue;
      this.lblPlayerHealthFull.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblPlayerHealthFull.ForeColor = System.Drawing.Color.White;
      this.lblPlayerHealthFull.Location = new System.Drawing.Point(71, 80);
      this.lblPlayerHealthFull.Name = "lblPlayerHealthFull";
      this.lblPlayerHealthFull.Size = new System.Drawing.Size(226, 20);
      this.lblPlayerHealthFull.TabIndex = 3;
      //
      // lblPlayerArmorFull
      // 
      this.lblPlayerArmorFull.BackColor = System.Drawing.Color.Red;
      this.lblPlayerArmorFull.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblPlayerArmorFull.ForeColor = System.Drawing.Color.White;
      this.lblPlayerArmorFull.Location = new System.Drawing.Point(71, 60);
      this.lblPlayerArmorFull.Name = "lblPlayerArmorFull";
      this.lblPlayerArmorFull.Size = new System.Drawing.Size(226, 20);
      this.lblPlayerArmorFull.TabIndex = 3;

      // 
      // label1
      // 
      this.label1.BackColor = System.Drawing.Color.Black;
      this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.label1.Location = new System.Drawing.Point(70, 59);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(229, 23);
      this.label1.TabIndex = 4;
      // 
      // label2
      // 
      this.label2.BackColor = System.Drawing.Color.Black;
      this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.label2.Location = new System.Drawing.Point(515, 59);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(229, 23);
      this.label2.TabIndex = 5;
      // 
      // lblEnemyHealthFull
      // 
      this.lblEnemyHealthFull.BackColor = System.Drawing.Color.Blue;
      this.lblEnemyHealthFull.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblEnemyHealthFull.ForeColor = System.Drawing.Color.White;
      this.lblEnemyHealthFull.Location = new System.Drawing.Point(516, 60);
      this.lblEnemyHealthFull.Name = "lblEnemyHealthFull";
      this.lblEnemyHealthFull.Size = new System.Drawing.Size(226, 20);
      this.lblEnemyHealthFull.TabIndex = 6;
      // 
      // picBossBattle
      // 
      this.picBossBattle.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.battle_screen;
      this.picBossBattle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.picBossBattle.Location = new System.Drawing.Point(780, 563);
      this.picBossBattle.Name = "picBossBattle";
      this.picBossBattle.Size = new System.Drawing.Size(30, 28);
      this.picBossBattle.TabIndex = 7;
      this.picBossBattle.TabStop = false;
      this.picBossBattle.Visible = false;
      // 
      // picEnemy
      // 
      this.picEnemy.BackColor = System.Drawing.Color.WhiteSmoke;
      this.picEnemy.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.enemy_koolaid;
      this.picEnemy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.picEnemy.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.picEnemy.Location = new System.Drawing.Point(515, 98);
      this.picEnemy.Name = "picEnemy";
      this.picEnemy.Size = new System.Drawing.Size(229, 267);
      this.picEnemy.TabIndex = 1;
      this.picEnemy.TabStop = false;
      // 
      // picPlayer
      // 
      this.picPlayer.BackColor = System.Drawing.Color.WhiteSmoke;
      this.picPlayer.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.player;
      this.picPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.picPlayer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.picPlayer.Location = new System.Drawing.Point(70, 98);
      this.picPlayer.Name = "picPlayer";
      this.picPlayer.Size = new System.Drawing.Size(229, 267);
      this.picPlayer.TabIndex = 0;
      this.picPlayer.TabStop = false;
      // 
      //
      // picHeart
      //
      //
      this.picHeart.BackColor = System.Drawing.Color.WhiteSmoke;
      this.picHeart.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.heart;
      this.picHeart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.picHeart.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.picHeart.Location = new System.Drawing.Point(70, 98);
      this.picHeart.Name = "picPlayer";
      this.picHeart.Size = new System.Drawing.Size(229, 267);
      this.picHeart.TabIndex = 0;
      this.picHeart.TabStop = false;
       //
       // tmrFinalBattle
       // 
      this.tmrFinalBattle.Interval = 5600;
      this.tmrFinalBattle.Tick += new System.EventHandler(this.tmrFinalBattle_Tick);
      // 
      // FrmBattle
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Green;
      this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.ClientSize = new System.Drawing.Size(822, 603);
      this.Controls.Add(this.picBossBattle);
      this.Controls.Add(this.lblEnemyHealthFull);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.lblPlayerHealthFull);
      this.Controls.Add(this.lblPlayerArmorFull);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnAttack);
      this.Controls.Add(this.btnRetreat);
      this.Controls.Add(this.btnCounter);
      this.Controls.Add(this.btnFinisher);
      this.Controls.Add(this.picEnemy);
      this.Controls.Add(this.picPlayer);
      this.DoubleBuffered = true;
      this.Name = "FrmBattle";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Fight!";
      ((System.ComponentModel.ISupportInitialize)(this.picBossBattle)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.picEnemy)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.picHeart)).EndInit();
      this.ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.PictureBox picPlayer;
    private System.Windows.Forms.PictureBox picHeart;
    private System.Windows.Forms.PictureBox picEnemy;
    private System.Windows.Forms.Button btnAttack;
    private System.Windows.Forms.Button btnRetreat;
    private System.Windows.Forms.Button btnCounter;
    private System.Windows.Forms.Button btnFinisher;
    private System.Windows.Forms.Label lblPlayerHealthFull;
    private System.Windows.Forms.Label lblPlayerArmorFull;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label lblEnemyHealthFull;
    private System.Windows.Forms.PictureBox picBossBattle;
    private System.Windows.Forms.Timer tmrFinalBattle;
  }
}