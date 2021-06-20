using Sostenes.LeilaoOnline.Core;
using System;
using Xunit;

namespace Sostenes.LeilaoOnline.Tests
{
    public class LeilaoTest
    {
        [Fact]
        public void LeilaoComVariosLances()
        {
            //Arrange - Cenário
            var leilao = new Leilao("Van Gogh");
            var fulano = new Interessada("Fulano", leilao);
            var maria = new Interessada("Maria", leilao);
            leilao.RecebeLance(fulano, 800);
            leilao.RecebeLance(maria, 900);
            leilao.RecebeLance(fulano, 1000);
            leilao.RecebeLance(maria, 990);

            //Act - método sob teste
            leilao.TerminaPregao();

            //Asset
            var valorEsperado = 1000;
            var valorObtido = leilao.Ganhador.Valor;
           Assert.Equal(valorEsperado, valorObtido);
        }

        [Fact]
        public void LeilaoComApenasUmLance()
        {
            //Arrange - Cenário
            var leilao = new Leilao("Van Gogh");
            var fulano = new Interessada("Fulano", leilao);
            leilao.RecebeLance(fulano, 800);
            //Act - método sob teste
            leilao.TerminaPregao();

            //Asset
            var valorEsperado = 800;
            var valorObtido = leilao.Ganhador.Valor;
            Assert.Equal(valorEsperado, valorObtido);
        }

    }
}
