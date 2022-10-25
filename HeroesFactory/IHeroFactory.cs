using HeroesFactory.Heroes;

namespace HeroesFactory;

public interface IHeroFactory
{
     IHero CreateHero(string type);
}