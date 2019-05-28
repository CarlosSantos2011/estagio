using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropriedadesPodemSerVirtuais
{
    public class Base
    {
        public virtual void M() { 4 }
        public int numero;
    }
    public class Derivada : Base
    {
        public virtual int Numero { get; set; }
        public override void M() { 3 }
    }
}
