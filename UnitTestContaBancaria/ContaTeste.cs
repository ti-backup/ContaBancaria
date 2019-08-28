using Microsoft.VisualStudio.TestTools.UnitTesting;
using ContaBancaria;

namespace UnitTestContaBancaria
{
    [TestClass]
    public class ContaTeste
    {
        [TestMethod]
        public void DebitoComValorValido()
        {
            double saldoInicial = 345.78;
            double valorDebito = 154;
            double saldoEsperado = 191.78;

            Conta conta = new Conta("Jão", saldoInicial);
            conta.Debito(valorDebito);

            double saldoReal = conta.getSaldo();
            Assert.AreEqual(saldoEsperado, saldoReal, 0.001, "Debito realizado de modo incorreto");
        }
    }
}
