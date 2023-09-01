namespace KillMonster;
public class Enemy
{
    public string Name;
    public float maxHp = 100;
    public float hp;
    public float mass;
    public float acc;

    public Enemy()
    {
        ResetnmyHP();
    }
    public void ResetnmyHP()
    {
        hp = maxHp;
    }
}
