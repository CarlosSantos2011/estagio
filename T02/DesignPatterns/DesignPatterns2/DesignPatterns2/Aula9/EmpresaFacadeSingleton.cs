using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Aula9
{
    class EmpresaFacadeSingleton
    {
        public static EmpresaFacade facade = new EmpresaFacade();

        public EmpresaFacade Instancia
        {
            get
            {
                return facade;
            }
        }
    }
}
