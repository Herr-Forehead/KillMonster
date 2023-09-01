using KillMonster;
using attackChoice;
// combat rolls
Random generator = new();
int hitRoll = generator.Next(101);
int crit = generator.Next(101);

// Characters
Character Dhoni = new();

Enemy Billiam = new();

Dhoni.Name = "Dhoni";

Dhoni.hp = 250;

Dhoni.mass = 5;

Dhoni.Int = 2;

Dhoni.acc = 75;

Billiam.Name = "Billiam";

Billiam.hp = 100;

Billiam.mass = 1;

Billiam.acc = 50;

Dhoni.Attack(Billiam);

// combat
while (Dhoni.hp > 0 && Billiam.hp > 0)
{
    hitRoll = generator.Next(101);
    crit = generator.Next(101);
    Console.WriteLine("Dhoni is readying up an attack; what do you choose? Spell or physical");
    

}

Console.ReadLine();