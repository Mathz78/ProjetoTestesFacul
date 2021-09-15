using System;
using TesteUnitario.Functions;

namespace TesteUnitario
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Olá, visitante, por favor informe a sua renda: ");
            var renda = double.Parse(Console.ReadLine());
            
            
            var calculoRenda = new VerificaRenda();
            var resultado = calculoRenda.VerificarRenda(renda);
            Console.WriteLine(resultado);
        }
    }
}
