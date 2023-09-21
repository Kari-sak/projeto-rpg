using CheckPoint1_RPG.Models;

namespace CheckPoint1_RPG.Data.DTOs
{
    public class LerPersonagemDto

    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public string Idade { get; set; }

        public string Classe { get; set; }

        public int Vida { get; set; }

        public int Dano_fisico { get; set; }

        public int Dano_magico { get; set; }

        public int Res_magica { get; set; }

        public int Res_fisica { get; set; }

    }
}
