using System;
using System.Net.Sockets;

namespace Propriedades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pagamento = new Pagamento();
            pagamento.DataPagamento = DateTime.Now;
            Console.WriteLine("Hello World!");
        }
    }

    public class Pagamento

    {
        public string NumeroBoleto;
        public DateTime Vencimento { get; set; }

        private DateTime _dataPagamento;

        public DateTime DataPagamento
        {
            get { return _dataPagamento; }
            set { _dataPagamento = value; }
        }

        void pagar() { }
    }
    public class Address
    {
        string CPF;
    }
}




// Diferença entre Var e Propriedades
// prop criar uma propriedade
// Propriedades: Possue Get e Set são chamados de acessores,
// pode atribuir ou receber valores atráves da var