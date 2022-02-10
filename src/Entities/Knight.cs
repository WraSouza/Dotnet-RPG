namespace Dotnet_RPG.src.Entities
{
    public class Knight : Hero
    {
        public Knight(string Name, int Level, string HeroType) : base(Name, Level, HeroType)
        {
             this.Name = Name;
             this.Level = Level;
             this.HeroType = HeroType;
        }

        public override string Attack()
        {
            return this.Name+" Golpeou com a espada";
        }

        public override string Attack(string tipoInimigo)
        {
            if(tipoInimigo == "monstro")
            {
                return this.Name+" acertou o golpe com dano de 10";
            }else{
                return this.Name+" acertou o golpe com dano de 5";
            }
        }

        public override string Defend()
        {
            return this.Name+" defendeu com o escudo";
        }
        
    }
}