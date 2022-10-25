namespace HeroesFactory.Weapons;

public class Katana : IWeapon
{
    public Katana()
    {
        Damage = 45;
    }
    
    public int Damage { get; set; }
}