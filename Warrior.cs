using System;
class Warrior
{
//these are states
    public string Name;
    public int Health = 100;
    public int MaxAttack = 100;
    public int MaxBlock = 100;
    public Warrior(string name)
    {

        Name = name;
        // Health = health;
        Console.WriteLine($"Our hero {Name} has entered");
        // MaxAttack;
        // MaxBlock;
    }

    public int GetAttack()
    {
        Random rnd = new Random();
        int atk = rnd.Next(0, MaxAttack);
        return atk;
    }








}