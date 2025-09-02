using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConceitosBasicos.uteis;

namespace TesteConceitosBasicos
{
    [TestClass]
    public class TesteCalculaAumento
    {
        [TestMethod]
        public void TesteCalcular()
        {
            // cenário
            decimal salario = 1000;
            float percentual = 20;
            decimal resultado;
            CalculaAumento calculador = new CalculaAumento();

            //ação
            resultado = calculador.Calcular(salario, percentual);

            //verificação
            Assert.AreEqual(200, resultado);
        }
    }
}