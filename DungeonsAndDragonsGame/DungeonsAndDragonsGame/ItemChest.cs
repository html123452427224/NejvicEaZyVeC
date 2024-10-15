using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsAndDragonsGame
{
  public class ItemChest
    {
        public Random random;
        public Weapon weapon;
        public Potions potions;
        public Enemy enemy;
        public List<Potions> potionsList;
        public List<Weapon> weapons;
        public List<Enemy> enemyList;
        public List<object> items;
        public Weapon rewardWeapon;
        public Enemy rewardEnemy;
        public Potions rewardPotions;
        

        public ItemChest()
        {
         
            random = new Random();
            weapons = new List<Weapon>()
            {
                Weapon.Factory.CreateBow(),
                Weapon.Factory.CreateLightsaber(),
                Weapon.Factory.CreateSword(),
                Weapon.Factory.CreateMagicStaff(),
            };

            potionsList = new List<Potions>
            {
                Potions.PotionsFactory.CreateHealthPotion(),
                Potions.PotionsFactory.CreateStrenghtPotion(),
            };

            enemyList = new List<Enemy>
            {
                Enemy.Factory.CreateZombie(),
                Enemy.Factory.CreateGoblin(),
                Enemy.Factory.CreateOger(),
            };
        }

        public Potions GetRewardPotions()
        {
            return rewardPotions;
        }

        public void RewardChest()
        {
            int weaponIndex = random.Next(weapons.Count);
            rewardWeapon = weapons[weaponIndex];

            int enemyIndex = random.Next(enemyList.Count);
            rewardEnemy = enemyList[enemyIndex];

            int potionIndex = random.Next(potionsList.Count);
            rewardPotions = potionsList[potionIndex];


            items = new List<object>
            { 
                rewardEnemy,
                rewardPotions,
                rewardEnemy,
            };

            int chestIndex = random.Next(items.Count);
            object rewardItems = items[chestIndex];
        }
    }


}
