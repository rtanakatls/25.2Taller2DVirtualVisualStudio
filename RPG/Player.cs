using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2D252.RPG
{
    internal class Player
    {
        private string name;
        private int life;
        private int damage;

        public string Name { get { return name; } }
        public int Life { get { return life; } }
        public int Damage { get { return damage; } }

        public Player(string name, int life, int damage)
        {
            this.name = name;
            this.life = life;
            this.damage = damage;
        }

        public void TakeDamage(int damage)
        {
            life -= damage;
            if(life < 0)
            {
                life = 0;
            }
        }

        public bool IsAlive()
        {
            return life > 0;
        }

        public string GetInfo()
        {
            return $"Player: {name} - Life: {life} - Damage: {damage}";
        }

    }
}
