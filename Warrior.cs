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
        int atk = rnd.Next(0, MaxAttack);
        return atk;
    }

    public int GetBlock()
    {
        Random rnd = new Random();
        int blk = rnd.Next(0, MaxBlock);
        return blk;
    }

    public void ApplyDamage(int damage)
    {

        Health -= damage;
    }

    public int HandleAttack(string warrior1, string warrior2)
    {
        int attack = warrior1.GetAttack();
        int block = warrior2.getBlock();
        int damage = attack - block;
        if (damage > 0)
        {
            ApplyDamage(damage);
        }
    }








}