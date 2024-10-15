using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsAndDragonsGame
{
   public class Enemy
    {
        public string Name;
        public double BaseDmg;
        public double Hp;

        public Enemy(string name, double baseDmg, double hp)
        {
            this.Name = name;
            this.BaseDmg = baseDmg;
            this.Hp = hp;
        }



        public void Attack(Player player)
        {
            player.Hp -= BaseDmg;
        }


        public int AttackChance()
        {
            Random rnd = new Random();
            int choosenValue = rnd.Next(1, 3);
            return choosenValue;

        }


        private static Random random = new Random();

        public static class Factory
        {
           
            public static Enemy CreateOger()
            {
            
              double damage = random.Next(1,100);
              return new Enemy("Oger", damage,100);
            }

            public static Enemy CreateGoblin()
            {
                double damage = random.Next(1, 15);
                return new Enemy("Goblin", damage, 100);
            }

            public static Enemy CreateZombie()
            {
                double damage = random.Next(1, 20);
                return new Enemy("Zombie", damage, 100);
            }
        }

   
    }
}
