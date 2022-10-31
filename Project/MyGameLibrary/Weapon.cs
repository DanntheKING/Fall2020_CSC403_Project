using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Class for Weapons
namespace Fall2020_CSC403_Project.code{ 
    public class Weapon : BattleCharacter
    {
        public Image Img { get; set; }

        public Weapon(Vector2 initPos, Collider collider) : base(initPos, collider)
        { }

    }

}