using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CheckPoint1_RPG.Models
{
    [Table("Personagens")]
    public class Personagem
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string Idade { get; set; }

        [Required]
        public string Classe { get; set; }

        [Required]
        public int Vida { get; set; }

        [Required]
        public int Dano_fisico { get; set; }

        [Required]
        public int Dano_magico { get; set; }

        [Required]
        public int Res_magica { get; set; }

        [Required]
        public int Res_fisica { get; set; }


    }
}
