using SistemaPdv.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaPdv.Models
{
    [Table("Login")]
    public class Login
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserID { get; set; }
        [Required]
        [MaxLength(80)]
        public string Email { get; set; }
        [Required]
        [MaxLength(80)]
        public string Senha { get; set; }
        public NivelAcesso NivelAcesso { get; set; }

    }
}
