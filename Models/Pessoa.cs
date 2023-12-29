using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaPdv.Models
{
    [Table("Pessoa")]
    public class Pessoa
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        [MaxLength(80)]
        public string Nome { get; set; }
        [Required]
        [MaxLength(80)]
        public string Sobrenome { get; set; }
        public int Idade { get; set; }
        
    }
}
