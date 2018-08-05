using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TesteArgo.test
{
    [TestClass]
    public class teste1teste
    {
        teste1 classeTeste = new teste1();

        [TestMethod]
        public void teste1_soma()
        {
            Assert.AreEqual(6, classeTeste.Somar(1, 5));
        }

        [TestMethod]
        public void teste1_Subtrair()
        {
            Assert.AreEqual(2, classeTeste.Subtrair(5, 3));
            Assert.AreEqual(3, classeTeste.Subtrair(10, 7));
        }

        [TestMethod]
        public void teste1_Media()
        {
            Assert.AreEqual(30, classeTeste.Media(50, 20, 20));
            Assert.AreEqual(10, classeTeste.Media(10, 10, 10));
            Assert.AreEqual(50, classeTeste.Media(40, 50, 110,20,20,60));
            
        }

        [TestMethod]
        public void teste1_CalcularIdade()
        {
            Assert.AreEqual(27, classeTeste.CalcularIdade(1990, 9, 22));
            Assert.AreEqual(21, classeTeste.CalcularIdade(1997, 5, 12));
        }

        [TestMethod]
        public void teste1_Multiplicador()
        {
            var sut = new Multiplicador();
            var atual = 0;
            var esperado = 24;

            sut.Multiplicar(2);
            atual = sut.Resultado();//-2
            sut.Multiplicar(3);
            sut.Multiplicar(4);
            sut.Multiplicar(2);
            atual = sut.Resultado();

            Assert.AreEqual(esperado, atual);

        }
    }
}
