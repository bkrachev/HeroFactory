namespace HeroesFactory.Weapons;

public class LightSabre : IWeapon
{
    public LightSabre()
    {
        Damage = 40;
    }
    
    public int Damage { get; set; }
}