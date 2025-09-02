using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConceitosBasicos.uteis;

namespace TesteConceitosBasicos
{
    [TestClass]
    public class TesteSomaDoisNumeros
    {
        [TestMethod]
        public void TesteSomar()
        {
            // cenário
            int num1 = 20;
            int num2 = 22;
            int resultado;
            SomaDoisNumeros somador = new SomaDoisNumeros();

            //ação
            resultado = somador.Somar(num1, num2);

            //verificação
            Assert.AreEqual(42, resultado);
        }
    }
}
