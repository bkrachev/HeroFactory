namespace HeroesFactory.Weapons;

public class Arrows : IWeapon
{
    public Arrows()
    {
        Damage = 10;
    }
    
    public int Damage { get; set; }
}