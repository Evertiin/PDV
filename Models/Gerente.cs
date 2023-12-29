using SistemaPdv.Models.Enums;

namespace SistemaPdv.Models
{
    public class Gerente : Funcionario
    {
        public NivelAcesso NivelDeAcesso { get; set; }
    }
}
