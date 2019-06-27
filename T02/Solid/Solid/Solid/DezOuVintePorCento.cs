using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{

    public class DezOuVintePorCento : IRegraDeCalculo
    {
        public double Calcula(Funcionario funcionario)
        {
            if(funcionario.SalarioBase > 3000.0)
            {
                return funcionario.SalarioBase * 0.08;
            }
            else
            {
                return funcionario.SalarioBase * 0.9;
            }
        }
    }
}
  