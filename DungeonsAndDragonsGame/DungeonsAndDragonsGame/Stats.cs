using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsAndDragonsGame
{
    public class Stats
    {
        public int KilledEnemies;
        public int DamageDealt;
        

        
        public void UpdateKilledEnemies()
        {
            KilledEnemies++;
        }

        public int UpdateDamageDealt(int damage)
        {
            return DamageDealt += damage;
        }

        public void DisplayKilledEnemies()
        {
            Console.WriteLine("Zabil jsi" + KilledEnemies + " nepřátel");
        }

        public void DisplayDamageDealt()
        {
            Console.WriteLine("zpusobil jsi" +DamageDealt);
        }
    }
}
