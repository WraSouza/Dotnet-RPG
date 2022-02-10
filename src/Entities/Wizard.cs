namespace Dotnet_RPG.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType) : base(Name, Level, HeroType)
        {
        }

        public override string Attack()
        {
            return this.Name + " lançou magia";
        }

        public string Attack(int bonus)
        {
            if(bonus > 6)
            {
                return this.Name + " lançou magia super efetiva "+bonus;
            }else{
                return this.Name + " lançou magia com força fraca "+bonus;
            }
            
        }
    }
}