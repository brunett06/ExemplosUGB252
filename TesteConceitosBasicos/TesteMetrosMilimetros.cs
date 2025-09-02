using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConceitosBasicos.uteis;

namespace TesteConceitosBasicos
{
    [TestClass]
    public class TesteMetrosMilimetros
    {
        [TestMethod]
        public void TesteConverter()
        {
            // cenário
            int metros = 2;
            int milimetros;

            //ação
            milimetros = MetrosMilimetros.Converter(metros);

            //verificação
            Assert.AreEqual(2000, milimetros);
        }
    }
}
