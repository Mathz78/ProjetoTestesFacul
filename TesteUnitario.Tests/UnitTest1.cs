using System;
using Xunit;
using Shouldly;

using TesteUnitario.Functions;

namespace TesteUnitario.Tests
{
    public class UnitTest1
    {
        VerificaRenda calculoRenda = new VerificaRenda();

        [Theory]
        [InlineData(4800)]
        [InlineData(4799)]
        [InlineData(3101)]
        public void PrimeiroCaso(double value)
        {
            var resultado = calculoRenda.VerificarRenda(value);
            resultado.ShouldBe("Classe B");
        }

        [Theory]
        [InlineData(10000)]
        [InlineData(4800.01)]
        [InlineData(4800.0001)]
        public void SegundoCaso(double value)
        {
            var resultado = calculoRenda.VerificarRenda(value);
            resultado.ShouldBe("Classe A");
        }

        [Theory]
        [InlineData(-10)]
        [InlineData(-0.1)]
        [InlineData(-0.0011)]
        public void TerceiroCaso(double value)
        {
            var resultado = calculoRenda.VerificarRenda(value);
            resultado.ShouldBe("Inválido");
        }

        [Theory]
        [InlineData(0)]
        [InlineData(1000)]
        [InlineData(999.99)]
        public void QuartoCaso(double value)
        {
            var resultado = calculoRenda.VerificarRenda(value);
            resultado.ShouldBe("Classe E");
        }
    }
}
