namespace HeroesFactory.Weapons;

public class Grenade : IWeapon
{
    public Grenade()
    {
        Damage = 300;
    }
    
    public int Damage { get; set; }
}