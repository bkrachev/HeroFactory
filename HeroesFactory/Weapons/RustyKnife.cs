namespace HeroesFactory.Weapons;

public class RustyKnife : IWeapon
{
    public RustyKnife()
    {
        Damage = 1;
    }
    
    public int Damage { get; set; }
}