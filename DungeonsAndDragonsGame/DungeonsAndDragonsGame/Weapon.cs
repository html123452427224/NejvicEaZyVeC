using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsAndDragonsGame
{

    public class Weapon
    {

        public string Name;
        public int Dmg;
        public Weapon(string name, int dmg)
        {
            this.Name = name;
            this.Dmg = dmg;
        }


        public static class Factory
        {
            public static Weapon CreateSword()
            {
                return new Weapon("Sword", 10);
            }

            public static Weapon CreateBow()
            {
                return new Weapon("Bow", 20);
            }

            public static Weapon CreateMagicStaff()
            {
                return new Weapon("MagicStaff", 30);
            }

            public static Weapon CreateLightsaber()
            {
                return new Weapon("Lightsaber", 50);
            }
        }
    }
}
