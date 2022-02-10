namespace Dotnet_RPG.src.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string Name, int Level, string HeroType) : base(Name, Level, HeroType)
        {
        }

        public override string Defend()
        {
            return this.Name+" defendeu com a katana";
        }

        public override string Attack()
        {
            return this.Name+" lançou shurikens";
        }
    }
}