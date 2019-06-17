using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    interface Resposta
    {
        void Responde(Requisicao req, Conta conta);
        Resposta OutraResposta { get;  set; }
    }
    
}
