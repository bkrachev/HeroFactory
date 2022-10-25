namespace HeroesFactory.Weapons;

public class Quiver : IWeapon
{
    public Quiver()
    {
        Damage = 0;
    }
    
    public int Damage { get; set; }
}