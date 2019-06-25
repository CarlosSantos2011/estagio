using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Aula4
{
   public interface IExpressao
    {
        int Avalia();
        void Aceita(IVisitor visitor);
    }
}
