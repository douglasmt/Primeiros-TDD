using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TesteArgo.test
{
    class teste6DougTeste
    {
        teste6Doug classeTeste = new teste6Doug();
        [TestMethod]
        public void teste6_Media()
        {
            Assert.AreEqual(30, classeTeste.Media(50, 20, 20));
            Assert.AreEqual(10, classeTeste.Media(10, 10, 10));
            Assert.AreEqual(50, classeTeste.Media(40, 50, 110, 20, 20, 60));
        }
    }
}
