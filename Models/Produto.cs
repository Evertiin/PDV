using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaPdv.Models
{
    [Table("Produto")]
    public class Produto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MaxLength(80)]
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int Estoque { get; set; }
    }
}
