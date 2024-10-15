using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsAndDragonsGame
{

   public class Potions
    {
        public string Name;
        public int Amount;
        public Potions(string name , double amount)
        {
            this.Name = name;
            this.Amount = amount;
        }


        public static class PotionsFactory
        {
            public static Potions CreateHealthPotion()
            {
                return new Potions("Heal", 100);
            }

            public static Potions CreateStrenghtPotion()
            {
                return new Potions("Strength", 20);
            }
        }
    }
}
