using HeroesFactory.Weapons;

namespace HeroesFactory.Heroes;

public class GenericHero : Hero
{
    public override void Arm()
    {
        Weapons.Add(new RustyKnife());
    }
}