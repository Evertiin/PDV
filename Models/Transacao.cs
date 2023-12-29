using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaPdv.Models
{
    [Table("Transacao")]
    public class Transacao
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Numero { get; set; }
        public DateTime DataHora { get; set; }
        public decimal Total { get; set; }
        public List<Produto> Produtos { get; set; }
        public Cliente ClienteAssociado { get; set; }
        public Funcionario FuncionarioAssociado { get; set; }

        public Transacao()
        {
            Produtos = new List<Produto>();
        }
    }
}
