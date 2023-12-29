using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaPdv.Models
{
    [Table("Cliente")]
    public class Cliente : Pessoa
    {
        
        public string Email { get; set; }
        public Comanda ComandaCliente { get; set; }

    }
    
}
