using HeroesFactory.Heroes;

namespace HeroesFactory;

public class HeroFactory : IHeroFactory
{
    public IHero CreateHero(string type)
    {
        switch (type)
        {
            case nameof(Archer):
                return new Archer();
            case nameof(Jedi):
                return new Jedi();
            case nameof(Knight):
                return new Knight();
            case nameof(Rambo):
                return new Rambo();
            case nameof(Samurai):
                return new Samurai();
            default:
                return new GenericHero();
        }
    }
}