namespace Dotnet_RPG.src.Entities
{
    public class BlackWizard : Hero
    {
        public BlackWizard(string Name, int Level, string HeroType) : base(Name, Level, HeroType)
        {
        }

        public override string Attack()
        {
            return this.Name+" lançou lavas do subterrâneo";
        }

        public override string Attack(string tipoMonstro)
        {
            if(tipoMonstro=="Morto-Vivo")
            {
                return this.Name+" Não acertou o inimigo";
            }else{
                return this.Name+" Acertou o Golpe com Força Máxima";
            }
        }

        public override string Defend()
        {
            return this.Name+" defendeu com um muro de esqueletos";
        }

        public string Summon()
        {
            return this.Name+" invocou uma legião de mortos-vivos";
        }
    }
}