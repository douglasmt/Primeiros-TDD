using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteArgo.test
{
    [TestClass]
    public class teste5Test
    {
        teste5 classeTeste = new teste5();

        [TestMethod]
        public void teste5_ListarFilmes()
        {
            var resultado = classeTeste.ListarDestino();

            Assert.IsNotNull(resultado);
            Assert.IsTrue(resultado.Count > 0);
        }


        [TestMethod]
        public void teste5_ListarPorId()
        {
            var resultado = classeTeste.buscarPorId(1);

            Assert.IsNotNull(resultado);            
        }
    }
}
