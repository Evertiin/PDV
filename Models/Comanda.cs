using SistemaPdv.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaPdv.Models
{
    [Table("Comanda")]
    public class Comanda
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Numero { get; set; }
        public DateTime DataHora { get; set; }
        public decimal Total { get; set; }
        public Cliente ClienteAssociado { get; set; }
        public Funcionario FuncionarioResponsavel { get; set; }
        public List<Produto> ItensVendidos { get; set; }
        public StatusComanda StatusComanda { get; set; }

        public Comanda()
        {
            ItensVendidos = new List<Produto>();
        }
    }
}
