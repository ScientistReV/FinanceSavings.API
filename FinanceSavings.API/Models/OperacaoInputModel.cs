using FinanceSavings.API.Enums;

namespace FinanceSavings.API.Models
{
    public class OperacaoInputModel
    {
        public decimal Valor { get; set; }

        public TipoOperacao Operacao  { get; set; }
    }
}
