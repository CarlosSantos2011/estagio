using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{
    public class CalculadoraDeSalario
    {
        public double Calcula(Funcionario funcionario)
        {
            if (funcionario.Cargo is Desenvolvedor)
            {
                return new DezOuVintePorCento().Calcula(funcionario);
            }

            if (funcionario.Cargo is Dba || funcionario.Cargo is Tester)
            {
                return new QuinzeOuVintePorCento().Calcula(funcionario);
            }

            throw new Exception("funcionario invalido");
        }

        
    }
}
