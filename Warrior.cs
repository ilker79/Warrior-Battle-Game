using System;
class Warrior
{

    public string Name;
    public int Health;
    public int MaxAttack;
    public int MaxBlock;
    public Warrior(string name, int health)
    {

        Name = name;
        Health = health;
        MaxAttack;
        MaxBlock;
    }

    public int GetAttack()
    {
        Random rnd = new Random();
        MaxAttack = rnd.Next(0, 101);
        Console.WriteLine(MaxAttack);
    }








}