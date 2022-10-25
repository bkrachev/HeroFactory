namespace HeroesFactory.Weapons;

public class BroadSword : IWeapon
{
    public BroadSword()
    {
        Damage = 60;
    }
    
    public int Damage { get; set; }
}