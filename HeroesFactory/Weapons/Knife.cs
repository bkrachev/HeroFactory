namespace HeroesFactory.Weapons;

public class Knife : IWeapon
{
    public Knife()
    {
        Damage = 15;
    }
    
    public int Damage { get; set; }
}