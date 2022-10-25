namespace HeroesFactory.Weapons;

public class Gun : IWeapon
{
    public Gun()
    {
        Damage = 90;
    }
    
    public int Damage { get; set; }
}