using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Aula6
{
    public class EnviaPorEmail : IEnviador
    {


        public void Envia(IMensagem mensagem)
        {
            Console.WriteLine("Enviando mensagem por email");
            Console.WriteLine(mensagem.Formata());
        }
    }
        
}
