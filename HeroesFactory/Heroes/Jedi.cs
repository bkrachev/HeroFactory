using HeroesFactory.Weapons;

namespace HeroesFactory.Heroes;

public class Jedi : Hero
{
    public override void Arm()
    {
        Weapons.Add(new LightSabre());
    }
}