using System;
using System.Security.Cryptography.X509Certificates;

namespace DungeonsAndDragonsGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
      
            Console.WriteLine("Zadej jméno tvoji postavy: ");
            string playersName = Console.ReadLine();
            Player player = new Player(playersName, 100, 20); 
            Console.WriteLine("Vítej ve hře: " + player.Name);
            
            Stats stats = new Stats();
            int roomCount = 0;
            int numberOfRooms = 100;
            int killedEnemies = 0;
            DropItems dropItems = new DropItems();
            ItemChest cestka = new ItemChest();

            Console.WriteLine("chces jit do prvni roomky?: ");
            string command = Console.ReadLine();

            if (command  == "ano")
            {
             
                Room room = new Room("zacatecni roomka")
                {
                    enemy = Enemy.Factory.CreateZombie() 
                };

                Console.WriteLine("zautocil jsi na enemyho");


                player.Attack(room.enemy);
                Console.WriteLine("zautocil jsi na enemyho a ted ma" + room.enemy.Hp + "zivotu");

              
                Console.WriteLine("bacha enemy muze zautocit i na tebe");
                room.enemy.Attack(player);
                Console.WriteLine("enemy na tebe zautocil a sebral ti " + room.enemy.BaseDmg + " zivotu a ted mas " + player.Hp + " zivotu");
                Weapon droppedWeapon = dropItems.DropWeaponAfterFirstFight();
                player.Inventory.AddWeapon(droppedWeapon);


              
                while (player.Hp > 0 && roomCount < numberOfRooms)
                {
                    Console.WriteLine("co chces delat: (utocit,status) ");
                    string Command = Console.ReadLine();

                    if (Command == "utocit")
                    {
                        player.Attack(room.enemy);
                        Console.WriteLine("zautocil jsi na enemyho a ted ma" + room.enemy.Hp + " zivotu");
                        stats.UpdateDamageDealt(player.Dmg);
                        if (room.enemy.Hp <= 0)
                        {
                            roomCount++;
                            Console.WriteLine("zabil jsi enemyho a ted jdes do roomky (" + roomCount + ")");
                            killedEnemies = killedEnemies + 1;
                            stats.UpdateKilledEnemies();
                         
                            if (roomCount >= numberOfRooms)
                            {
                                Console.WriteLine("jsi v posledni roomce a ted budes bojovat s finalnim bosem");
                                break;
                            }
                            room = new Room("roomka " + roomCount)
                            
                            {
                                enemy = room.ChooseEnemy()
                            };
                            Console.WriteLine("tvuj novy enemy je " + room.enemy.Name);
                        }
                    }
                    else if (Command == "status")
                    {
                        Console.WriteLine("tvoje zivoty: " + player.Hp + ", enemy ma: " + room.enemy.Hp + " zivotu");
                    }
                    else if (Command == "stats_damage" || Command == "stats_kills")
                    {
                        stats.DisplayDamageDealt();
                        stats.UpdateKilledEnemies();
                    }
                    else if (Command == "inventar")
                    {
                        player.Inventory.DisplayInventory();
                    }


                    int attackChance = room.enemy.AttackChance();
                    if (attackChance == 1)
                    {
                        room.enemy.Attack(player);
                        Console.WriteLine("nepritel na tebe zautocil a ubral ti " + room.enemy.BaseDmg + " zivotu a ted mas " + player.Hp + " zivotu");
                    }
                    else if (attackChance == 2)
                    {
                        Console.WriteLine("nepritel chtel zautocit ale missnul");
                    }

                    if (player.Hp <= 0)
                    {
                        Console.WriteLine("umrel jsi a hra konci");
                        return;
                    }
                }
            }
            else
            {
                Console.WriteLine("Škoda :( pokud si to rozmyslis spust program znova");
            }

            if (roomCount == 25)
            {
                cestka.RewardChest();
            }
        }
    }
}