namespace HeroesFactory.Weapons;

public class Bow : IWeapon
{
    public Bow()
    {
        Damage = 0;
    }
    
    public int Damage { get; set; }
}