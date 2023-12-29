using SistemaPdv.Models.Enums;

namespace SistemaPdv.Models
{
    public class Funcionario : Pessoa
    {
        public string Cargo { get; set; }
        public NivelAcesso NivelAcesso { get; set; }

    }
}
