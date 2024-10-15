using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsAndDragonsGame
{
    
    enum chooseEnemy
    {
        zombie = 1,
        oger = 2,
        goblin = 3,
    }

    enum choosePotion
    {
        heal = 1,
        strength = 2,
    }

   
  public class Room
    {
        public string Description;
        public Enemy enemy;
        public Potions potions;
      

        public Room(string description)
        {
            this.Description = description;
           
        }

        private static Random random = new Random();
        public Enemy ChooseEnemy()
        {
            int choosenEnemy = random.Next(1, Enum.GetValues(typeof(chooseEnemy)).Length+1);
            chooseEnemy values = (chooseEnemy)choosenEnemy;

            if (values == chooseEnemy.zombie)
            {
                return Enemy.Factory.CreateZombie();
            }
            else if (values == chooseEnemy.oger)
            {
                return Enemy.Factory.CreateOger();
            }
            else if (values == chooseEnemy.goblin)
            {
                return Enemy.Factory.CreateGoblin();
            }
            throw new InvalidOperationException("neznami nepritel");
        }


        public Potions ChooseRandomPotion()
        {
            int choosenPotion = random.Next(1, Enum.GetValues(typeof(choosePotion)).Length);
            choosePotion values = (choosePotion)choosenPotion;

            if (values == choosePotion.heal)
            {
                return Potions.PotionsFactory.CreateHealthPotion();
            }
            else if (values == choosePotion.strength)
            {
                return Potions.PotionsFactory.CreateStrenghtPotion();
            }

            throw new InvalidOperationException("neznami potion");
        }




       

       



    }
}
