using FinanceSavings.API.Entities;
using System.Collections.Generic;

namespace FinanceSavings.API.Persistence
{
    public class FinanceSavingsContext
    {
        public List<ObjetivoFinanceiro> Objetivos { get; set; }

        public FinanceSavingsContext()
        {
            Objetivos = new List<ObjetivoFinanceiro>();
        }
    }
}
