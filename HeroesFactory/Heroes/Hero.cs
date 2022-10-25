using System.Text;
using HeroesFactory.Weapons;

namespace HeroesFactory.Heroes;

public abstract class Hero : IHero
{
    private readonly List<IWeapon> weapons;

    protected Hero()
    {
        weapons = new List<IWeapon>();
        Arm();
    }

    public List<IWeapon> Weapons => weapons;

    public abstract void Arm();

    public int DoDamage()
    {
        return Weapons.Sum(x => x.Damage);
    }

    public override string ToString()
    {
        StringBuilder sb = new();

        sb.AppendLine($"{GetType().Name} is ready for action. Can't wait to do {DoDamage()} damage.");

        foreach (var weapon in Weapons)
        {
            sb.AppendLine($" - {weapon.GetType().Name}");
        }

        return sb.ToString().Trim();
    }
}