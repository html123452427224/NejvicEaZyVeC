using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsAndDragonsGame
{
    public class DropItems
    {
        public Weapon weapon;
        public List<Weapon> weapons;
        public Random random;


        public DropItems()
        {
            random = new Random();
            weapons = new List<Weapon>()
            {
                Weapon.Factory.CreateBow(),
                Weapon.Factory.CreateSword(),
                Weapon.Factory.CreateMagicStaff(),
                Weapon.Factory.CreateLightsaber(),
            };

        }
        public Weapon DropWeaponAfterFirstFight()
        {
            int index = random.Next(weapons.Count);
            return weapons[index];
        }

    }
}
