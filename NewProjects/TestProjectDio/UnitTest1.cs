using NewProjects;
using System;
using System.Net.Cache;
using System.Net.Http.Headers;
using Xunit;

namespace TestProjectDio
{
    public class UnitTest1
    {
        public Calculadora construirCalculadora()
        {
            string data = "26/04/2024";
            Calculadora calc = new Calculadora(data);
            return calc;
        }
        [Theory]
        [InlineData(1,2,3)]
        [InlineData(3,4,7)]
        public void TesteSoma(int x, int y, int res)
        {
            Calculadora calc = construirCalculadora();
            int resCalculadora = calc.Soma(x, y);
            Assert.Equal(res, resCalculadora);
        }

        [Theory]
        [InlineData(5, 2, 3)]
        [InlineData(5, 4, 1)]
        public void TesteSub(int x, int y, int res)
        {
            Calculadora calc = construirCalculadora();
            int resCalculadora = calc.Subtrair(x, y);
            Assert.Equal(res, resCalculadora);
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(3, 4, 12)]
        public void TesteMult(int x, int y, int res)
        {
            Calculadora calc = construirCalculadora();
            int resCalculadora = calc.Multiplicar(x, y);
            Assert.Equal(res, resCalculadora);
        }

        [Theory]
        [InlineData(10, 2, 5)]
        [InlineData(14, 2, 7)]
        public void TesteDividir(int x, int y, int res)
        {
            Calculadora calc = construirCalculadora();
            int resCalculadora = calc.Dividir(x, y);
            Assert.Equal(res, resCalculadora);
        }


        [Fact]
        public void DivisaoPorZero()
        {
            Calculadora calc = construirCalculadora();
            Assert.Throws<DivideByZeroException>(() => calc.Dividir(3, 0));
        }

        [Fact]
        public void TestarHistorico()
        {
            Calculadora calc = construirCalculadora();

            calc.Soma(2,3);
            calc.Soma(5, 6);
            calc.Soma(7, 8);
            calc.Soma(9, 10);

            var lista = calc.historico();
            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count);
        }
    }
}
