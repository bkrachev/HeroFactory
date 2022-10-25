using HeroesFactory.Weapons;

namespace HeroesFactory.Heroes;

public interface IHero
{
    List<IWeapon> Weapons { get; }
    void Arm();
}