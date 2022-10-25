namespace HeroesFactory.Weapons;

public class Rifle : IWeapon
{
    public Rifle()
    {
        Damage = 120;
    }
    
    public int Damage { get; set; }
}