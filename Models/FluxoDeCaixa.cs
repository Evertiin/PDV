namespace SistemaPdv.Models
{
    public class FluxoDeCaixa
    {
        public List<Transacao> Transacoes { get; set; }
        public decimal SaldoAtual { get; private set; }

        public FluxoDeCaixa()
        {
            Transacoes = new List<Transacao>();
            SaldoAtual = 0;
        }

        public void RegistrarTransacao(Transacao transacao)
        {
            Transacoes.Add(transacao);
            SaldoAtual += transacao.Total;
        }
    }
}
