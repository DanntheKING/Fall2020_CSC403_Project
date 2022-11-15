using Fall2020_CSC403_Project.code;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fall2020_CSC403_Project.code
{
    public class Armor : BattleCharacter
    {
        public Image Img { get; set; }
        public Armor(Vector2 initPos, Collider collider) : base(initPos, collider)
        {

        }

    }
}
