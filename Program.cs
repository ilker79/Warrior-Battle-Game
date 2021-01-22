using System;

namespace WarriorBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            Warrior player1 = new Warrior("Ilker");
            Warrior player2 = new Warrior("Steve");

            Console.WriteLine(player1.GetBlock());

        }
    }
}
