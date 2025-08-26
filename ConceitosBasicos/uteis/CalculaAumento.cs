using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceitosBasicos.uteis
{
    public class CalculaAumento
    {
        public decimal Calcular(decimal salario, float percentual)
        {
            return salario * ((decimal) percentual / 100);
        }
    }
}
