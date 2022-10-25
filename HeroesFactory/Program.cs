using HeroesFactory;
using HeroesFactory.Heroes;

List<IHero> heroes = new();
HeroFactory factory = new HeroFactory();

foreach (var type in (HeroTypes[])Enum.GetValues(typeof(HeroTypes)))
{
    heroes.Add(factory.CreateHero(type.ToString()));
}

foreach (var hero in heroes)
{
    Console.WriteLine(hero.ToString());
}
