using System;

namespace FinanceSavings.API.Exceptions
{
    public class SaldoInsuficienteException : Exception
    {
        public SaldoInsuficienteException() : base("Saldo insuficiente!")
        {
        }
    }
}