using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsAndDragonsGame
{
   public class Inventory
    {
        public List<Potions> potion;
        public List<Weapon> weapons;
        public Potions potions;

        public Inventory()
        {
            potion = new List<Potions>();
        }

        public void AddPotions(Potions potions)
        {
            potion.Add(potions);
        }

        public void AddWeapon(Weapon weapon)
        {
            weapons.Add(weapon);
        }


        public void DisplayInventory()
        {
            foreach (var potion in potion)
            {
                Console.WriteLine(potion.ToString());
            }

            foreach (var weapon in weapons)
            {
                Console.WriteLine(weapon.ToString());
            }
        }
    }

}
