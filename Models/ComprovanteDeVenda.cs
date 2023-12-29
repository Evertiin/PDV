using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaPdv.Models
{
    [Table("ComprovanteDeVenda")]
    public class ComprovanteDeVenda
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int NumeroVenda { get; set; }
        public DateTime DataHora { get; set; }
        public Cliente Cliente { get; set; }
        public Funcionario Funcionario { get; set; }    
        public List<Produto> ItensVendidos { get; set; }
        public decimal ValorTotal { get; set; }
        

        public ComprovanteDeVenda()
        {
            ItensVendidos = new List<Produto>();
        }
    }
}
