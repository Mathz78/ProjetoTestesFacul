using System;
using Xunit;
using Shouldly;

using TesteUnitario.Functions;

namespace TesteUnitario.Tests
{
    public class UnitTest1
    {
        VerificaRenda calculoRenda = new VerificaRenda();

        [Fact]
        public void PrimeiroCaso()
        {
            var resultado = calculoRenda.VerificarRenda(4800);
            resultado.ShouldBe("Classe B");
        }

        [Fact]
        public void SegundoCaso()
        {
            var resultado = calculoRenda.VerificarRenda(4800.01);
            resultado.ShouldBe("Classe A");
        }

        [Fact]
        public void TerceiroCaso()
        {
            var resultado = calculoRenda.VerificarRenda(-1);
            resultado.ShouldBe("Inválido");
        }

        [Fact]
        public void QuartoCaso()
        {
            var resultado = calculoRenda.VerificarRenda(0);
            resultado.ShouldBe("Classe E");
        }
    }
}
