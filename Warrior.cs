using System;
class Warrior
{
    //these are states
    public string Name;
    public int Health;
    public int MaxAttack = 100;
    public int MaxBlock = 100;
    public Warrior(string name)
    {

        Name = name;
        Health = 100;
        Console.WriteLine($"Our hero {Name} has entered");
        // MaxAttack;
        // MaxBlock;
    }

    public int GetAttack()
    {
        Random rnd = new Random();
        int attack = rnd.Next(0, MaxAttack);
        return attack;
    }

    public int GetBlock()
    {
        Random rnd = new Random();
        int block = rnd.Next(0, MaxBlock);
        return block;
    }

    public void ApplyDamage(int damage)
    {

        Health -= damage;
    }

    








}