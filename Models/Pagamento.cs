using SistemaPdv.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaPdv.Models
{
    [Table("Pagamento")]
    public class Pagamento
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Metodo { get; set; }
        public decimal Valor { get; set; }
        public StatusPagamento StatusPagamento { get; set; }    
        public MetodoPagamento MetodoPagamento { get; set;}
    }
}
