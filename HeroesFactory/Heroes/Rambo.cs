using HeroesFactory.Weapons;

namespace HeroesFactory.Heroes;

public class Rambo : Hero
{
    public override void Arm()
    {
        Weapons.Add(new Knife());
        Weapons.Add(new Gun());
        Weapons.Add(new Rifle());
        Weapons.Add(new Grenade());
    }
}