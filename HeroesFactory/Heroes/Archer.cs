using HeroesFactory.Weapons;

namespace HeroesFactory.Heroes;

public class Archer : Hero
{
    public override void Arm()
    {
        Weapons.Add(new Bow());
        Weapons.Add(new Quiver());
        Weapons.Add(new Arrows());
    }
}