using HeroesFactory.Weapons;

namespace HeroesFactory.Heroes;

public class Samurai : Hero
{
    public override void Arm()
    {
        Weapons.Add(new Katana());
    }
}