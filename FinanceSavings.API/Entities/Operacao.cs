using System;
using FinanceSavings.API.Enums;

namespace FinanceSavings.API.Entities
{
    public class Operacao
    {
        public Operacao(decimal valor, TipoOperacao tipo)
        {
            Id = new Random().Next(1, 1000);
            Valor = valor;
            Tipo = tipo;

            DataOperacao = DateTime.Now;
        }

        public int Id { get; private set; }
        public decimal Valor { get; private set; }
        public TipoOperacao Tipo { get; private set; }
        public DateTime DataOperacao { get; set; }
    }
}