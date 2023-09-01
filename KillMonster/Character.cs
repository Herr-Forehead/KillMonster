using System.Security.Cryptography.X509Certificates;

namespace KillMonster;
public class Character
{
    public string Name;
    public float maxHp = 250;
    public float hp;
    public float mass;
    public float Int;
    public float acc;

    public Character()
    {
        ResetHp();
    }
    public void ResetHp()
    {
        hp = maxHp;
    }

    public void Attack(Enemy target)
    {
        string attackChoice = Console.ReadLine();
        if (attackChoice == "spell" || attackChoice == "Spell")
        {
            
        }

    }
}
