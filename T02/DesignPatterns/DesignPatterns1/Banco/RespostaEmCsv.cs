﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Banco.Conta;

namespace Banco
{
    class RespostaEmCsv : Resposta
    {
        public Resposta OutraResposta { get; set; }

        public void Responde(Requisicao req, Conta conta)
        {
            if (req.Formato == Formato.CSV)
            {
                Console.WriteLine(conta.Titular + ";" + conta.Saldo);
            }
            else
            {
                OutraResposta.Responde(req, conta);
            }
        }
    }

}