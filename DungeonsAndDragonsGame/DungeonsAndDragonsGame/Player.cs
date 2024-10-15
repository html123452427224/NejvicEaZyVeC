using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsAndDragonsGame
{
    public class Player
    {
        public string Name;
        public double Hp;
        public int Dmg;
        public Inventory Inventory;
        
        public Player(string name, double hp, int dmg)
        {
            this.Name = name;
            this.Hp = hp;
            this.Dmg = dmg;
        }


        public void Attack(Enemy enemy)
        {
            enemy.Hp -= Dmg;
        }

        public void Heal(Inventory inventory)
        {
            if (inventory.potion.Count > 0)
            {
                Potions potionToUse = inventory.potion[0]; 
                Hp += potionToUse.Amount;
                inventory.potion.RemoveAt(0);
                Console.WriteLine("uzdravil jsi se");
            }
            else
            {
                Console.WriteLine("nemas zadne lektvary k uzdraveni");
            }
        }

        public void Strength(Inventory inventory)
        {
            Potions potionsToUse = inventory.potion[0];
            Dmg += potionsToUse.Amount;
            inventory.potion.RemoveAt(0);
            Console.WriteLine("mas vetsi dmg");
        }

        public void AddStats(Inventory inventory)
        {
            Weapon increase = inventory.weapons[0];
            Dmg += increase.Dmg;
            Console.WriteLine("mas vetsi poskozeni");
        }
    }
}
