using HeroesFactory.Weapons;

namespace HeroesFactory.Heroes;

public class Knight : Hero
{
    public override void Arm()
    {
        Weapons.Add(new BroadSword());
    }
}