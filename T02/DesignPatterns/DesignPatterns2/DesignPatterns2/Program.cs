using DesignPatterns2.Aula3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2
{
    class Program
    {
        static void Main(string[] args)
        {
            Historico historico = new Historico();

            Contrato contrato = new Contrato(DateTime.Now, "Carlos", TipoContrato.Novo);
            historico.Adiciona(contrato.SalvaEstado());

            contrato.Avanca();
            historico.Adiciona(contrato.SalvaEstado());

            contrato.Avanca();
            historico.Adiciona(contrato.SalvaEstado());

            contrato.Avanca();
            historico.Adiciona(contrato.SalvaEstado());

            Console.WriteLine(historico.Pega(2).Contrato.Tipo);

            Console.ReadLine();
        }
    }
}
