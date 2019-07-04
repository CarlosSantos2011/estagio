using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Source
{
    public interface ICambioService
    {
        decimal Calcular(string moedaOrigem, string moedaDestion, decimal valor);
    }
}
