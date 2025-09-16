using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Taller2D252.RPG
{
    internal class RPGMenu
    {
        private List<Enemy> enemies;
        private Player player;
        private int currentEnemyIndex;

        public RPGMenu()
        {
            enemies = new List<Enemy>();
        }

        public void Execute()
        {
            player = GetPlayer();
            CreateEnemies();
            Gameplay();
        }

        private void CreateEnemies()
        {
            enemies.Add(new Enemy("Enemy 1", 50, 10));
            enemies.Add(new Enemy("Enemy 2", 100, 20));
            enemies.Add(new Enemy("Enemy 3", 10, 50));
        }

        private Player GetPlayer()
        {
            Console.WriteLine("Introduce el nombre del jugador:");
            string name = Console.ReadLine();
            int life = GetLife();
            int damage = GetDamage();
            return new Player(name, life, damage);
        }

        private int GetLife()
        {
            int life = 0;
            bool continueFlag = true;
            while (continueFlag)
            {
                Console.WriteLine("Introduce la vida del jugador:");
                life = int.Parse(Console.ReadLine());
                if (life > 0 && life <= 100)
                {
                    continueFlag = false;
                }
                else
                {
                    Console.WriteLine("La vida debe ser mayor a 0 y menor o igual a 100.");
                }
            }
            return life;
        }

        private int GetDamage()
        {
            int damage = 0;
            bool continueFlag = true;
            while (continueFlag)
            {
                Console.WriteLine("Introduce el daño del jugador:");
                damage = int.Parse(Console.ReadLine());
                if (damage > 0 && damage <= 100)
                {
                    continueFlag = false;
                }
                else
                {
                    Console.WriteLine("La daño debe ser mayor a 0 y menor o igual a 100.");
                }
            }
            return damage;
        }

        private void Gameplay()
        {
            bool continueFlag = true;
            while(continueFlag)
            {
                PlayerTurn();
                if (IsEnemyAlive())
                {
                    EnemyTurn();
                    if (!player.IsAlive())
                    {
                        continueFlag = false;
                    }
                }
                else
                {
                    continueFlag = false;
                }
            }

            if(player.IsAlive())
            {
                Console.WriteLine("Has ganado!");
            }
            else
            {
                Console.WriteLine("Has perdido!");
            }
        }

        private void PlayerTurn()
        {
            Console.WriteLine(player.GetInfo());
            bool continueFlag = true;
            while (continueFlag)
            {
                Console.WriteLine("Selecciona un enemigo para atacar:");
                ShowAllEnemies();
                int option = int.Parse(Console.ReadLine());
                if (option >= 0 && option < enemies.Count)
                {
                    Enemy enemy = enemies[option];
                    if (enemy.IsAlive())
                    {
                        enemy.TakeDamage(player.Damage);
                        Console.WriteLine($"El enemigo {enemy.Name} recibió {player.Damage} de daño");
                        if (!enemy.IsAlive())
                        {
                            Console.WriteLine($"El enemigo {enemy.Name} ha muerto");
                        }
                        continueFlag = false;
                    }
                    else
                    {
                        Console.WriteLine("No puedes atacar a un enemigo muerto");
                    }
                }
            }
        }


        private void EnemyTurn()
        {
            Enemy enemy = GetEnemy();
            player.TakeDamage(enemy.Damage);
            Console.WriteLine($"El jugador {player.Name} recibió {enemy.Damage} de daño del enemigo {enemy.Name}");
            currentEnemyIndex++;
        }

        private Enemy GetEnemy()
        {
            while(true)
            {
                if (enemies[currentEnemyIndex].IsAlive())
                {
                    return enemies[currentEnemyIndex];
                }
                else
                {
                    currentEnemyIndex++;
                }
            }

        }

        private bool IsEnemyAlive()
        {
            foreach(Enemy enemy in enemies)
            {
                if (enemy.IsAlive())
                {
                    return true;
                }
            }
            return false;
        }

        private void ShowAllEnemies()
        {
            for (int i = 0; i < enemies.Count; i++)
            {
                if (enemies[i].IsAlive())
                {
                    Console.WriteLine($"{i} - {enemies[i].GetInfo()}");
                }
            }
        }

    }
}
