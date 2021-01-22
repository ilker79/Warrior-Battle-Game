using System;

namespace WarriorBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            Warrior player1 = new Warrior("Ilker");
            Warrior player2 = new Warrior("Steve");

            HandleAttack(player1, player2);
            

        }

        public static void HandleAttack(Warrior player1, Warrior player2)
    {
        int atk = player1.GetAttack();
        int blk = player2.GetBlock();
        int damage = atk - blk;
        if (damage > 0)
        {
           player2.ApplyDamage(damage);
        }
    }
    }
}
