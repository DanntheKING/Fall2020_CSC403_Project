using Fall2020_CSC403_Project.code;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Media;
using Fall2020_CSC403_Project.Properties;


namespace Fall2020_CSC403_Project {
  public partial class FrmLevel : Form {
    private Player player;
    private Enemy enemyPoisonPacket;
    public Enemy bossKoolaid;
    private Enemy enemyCheeto;
    private Character[] walls;
    private Heart hearts;
    private Heart twoHeart;
    private Armor armor;

    private DateTime timeBegin;
    private FrmBattle frmBattle;

    SoundPlayer walkSFX = new SoundPlayer(Resources.walkSound);
    public bool lvlMusicOn;
    public bool isKoolAidMan = false;

    public FrmLevel() {
      InitializeComponent();
    }

    private void FrmLevel_Load(object sender, EventArgs e) {
      const int PADDING = 7;
      const int NUM_WALLS = 13;

      player = new Player(CreatePosition(picPlayer), CreateCollider(picPlayer, PADDING));
      hearts = new Heart(CreatePosition(picHeart), CreateCollider(picHeart, PADDING));
      twoHeart = new Heart(CreatePosition(picHeart2), CreateCollider(picHeart2, PADDING));
      armor = new Armor(CreatePosition(picArmor), CreateCollider(picArmor, PADDING));
      bossKoolaid = new Enemy(CreatePosition(picBossKoolAid), CreateCollider(picBossKoolAid, PADDING));
      enemyPoisonPacket = new Enemy(CreatePosition(picEnemyPoisonPacket), CreateCollider(picEnemyPoisonPacket, PADDING));
      enemyCheeto = new Enemy(CreatePosition(picEnemyCheeto), CreateCollider(picEnemyCheeto, PADDING));

      bossKoolaid.Img = picBossKoolAid.BackgroundImage;
      enemyPoisonPacket.Img = picEnemyPoisonPacket.BackgroundImage;
      enemyCheeto.Img = picEnemyCheeto.BackgroundImage;

      bossKoolaid.Color = Color.Red;
      enemyPoisonPacket.Color = Color.Green;
      enemyCheeto.Color = Color.FromArgb(255, 245, 161);

      // Determine who is the boss of the level
      bossKoolaid.Boss = true;
      enemyPoisonPacket.Boss = false;
      enemyCheeto.Boss = false;

      walls = new Character[NUM_WALLS];
      for (int w = 0; w < NUM_WALLS; w++) {
        PictureBox pic = Controls.Find("picWall" + w.ToString(), true)[0] as PictureBox;
        walls[w] = new Character(CreatePosition(pic), CreateCollider(pic, PADDING));
      }

      Game.player = player;
      timeBegin = DateTime.Now;
    }

    private Vector2 CreatePosition(PictureBox pic) {
      return new Vector2(pic.Location.X, pic.Location.Y);
    }

    private Collider CreateCollider(PictureBox pic, int padding) {
      Rectangle rect = new Rectangle(pic.Location, new Size(pic.Size.Width - padding, pic.Size.Height - padding));
      return new Collider(rect);
    }

    private void FrmLevel_KeyUp(object sender, KeyEventArgs e) {
      player.ResetMoveSpeed();
    }

    private void tmrUpdateInGameTime_Tick(object sender, EventArgs e) {
      TimeSpan span = DateTime.Now - timeBegin;
      string time = span.ToString(@"hh\:mm\:ss");
      lblInGameTime.Text = "Time: " + time.ToString();
    }

    private void tmrPlayerMove_Tick(object sender, EventArgs e) {
      // move player
      player.Move();

      // check collision with walls
      if (HitAWall(player)) {
        player.MoveBack();
      }

      // check collision with enemies
      if (HitAChar(player, enemyPoisonPacket)) {
        Fight(enemyPoisonPacket);
      }
      else if (HitAChar(player, enemyCheeto)) {
        Fight(enemyCheeto);
      }
      if (HitAChar(player, bossKoolaid)) {
        Fight(bossKoolaid);
      }
      while (player.Health < 200 & HitAChar(player, hearts))
      {
          if (HitAChar(player, hearts) & player.Health != player.MaxHealth)
          {
              player.Health += 5;
              picHeart.Location = new Point(1000, 1000);
              player.MaxHealth = 200;
              // player.MaxHealth = player.Health;
              System.Console.WriteLine("Hit heart!!!");
          }
      }
      if(HitAChar(player, hearts) & player.Health == player.MaxHealth){
          picHeart.Location = new Point(1000, 1000);
     
      }
      if (HitAChar(player, bossKoolaid))
      {
          Fight(bossKoolaid);
      }
      while (player.Health < 200 & HitAChar(player, twoHeart))
      {
          if (HitAChar(player, twoHeart) & player.Health != player.MaxHealth)
          {
              player.Health += 5;
              picHeart2.Location = new Point(1000, 1000);
              player.MaxHealth = 200;
              // player.MaxHealth = player.Health
              System.Console.WriteLine("Hit heart!!!");
          }
      }
      if (HitAChar(player, twoHeart) & player.Health == player.MaxHealth)
      {
          picHeart2.Location = new Point(1000, 1000);

      }
      if (enemyPoisonPacket.Health == 0){

          picEnemyPoisonPacket.Visible = false;
          enemyPoisonPacket.releaseCollider();
          picEnemyPoisonPacket.Dispose();
      

      }
      if (enemyCheeto.Health == 0)
      {

          picEnemyCheeto.Visible = false;
          enemyCheeto.releaseCollider();
          picEnemyCheeto.Dispose();

      }
      if (bossKoolaid.Health == 0)
      {

          picBossKoolAid.Visible = false;
          bossKoolaid.releaseCollider();
          picBossKoolAid.Dispose();

      }
      if(HitAChar(player, armor) & player.Armors < 50)
      {
          System.Console.WriteLine("Hit ARMOR!!!");
          player.Armors += 5;
          player.MaxArmor = 50;
          picArmor.Location = new Point(1000, 1000);
          
                
      }








            // update player's picture box
            picPlayer.Location = new Point((int)player.Position.x, (int)player.Position.y);
    }

    private bool HitAWall(Character c) {
      bool hitAWall = false;
      for (int w = 0; w < walls.Length; w++) {
        if (c.Collider.Intersects(walls[w].Collider)) {
          hitAWall = true;
          break;
        }
      }
      return hitAWall;
    }

    private bool HitAChar(Character you, Character other) {
      return you.Collider.Intersects(other.Collider);
    }

    private void Fight(Enemy enemy) {
      player.ResetMoveSpeed();
      player.MoveBack();
      frmBattle = FrmBattle.GetInstance(enemy);
      frmBattle.UpdateSettings(lvlMusicOn, isKoolAidMan);
      frmBattle.Show();

      if (enemy == bossKoolaid) {
        isKoolAidMan = true;
        frmBattle.SetupForBossBattle();
        frmBattle.UpdateSettings(lvlMusicOn, isKoolAidMan);
      }
    }

    private void FrmLevel_KeyDown(object sender, KeyEventArgs e) {
      
      walkSFX.Play(); //walk sound

      switch (e.KeyCode) {
        case Keys.Left:
          player.GoLeft();
          break;

        case Keys.Right:
          player.GoRight();
          break;

        case Keys.Up:
          player.GoUp();
          break;

        case Keys.Down:
          player.GoDown();
          break;

        default:
          player.ResetMoveSpeed();
          break;
      }
    }

    public void UpdateSettings(Settings s)
        {
            if (s.maxWindow)
            {
                s.maximizeWindow(this);
            }

            lvlMusicOn = s.musicOn;
        }

    private void lblInGameTime_Click(object sender, EventArgs e) {

    }
  }
}
