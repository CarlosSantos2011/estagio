using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Aula6
{
    public class MensagemUsuario : IMensagem
    {
        private string nome;

        public IEnviador Enviador { get; set; }

        public MensagemUsuario(String nome)
        {
            this.nome = nome;
        }

        public string Formata()
        {
            return String.Format("Mensagem para o usuário {0}", nome);
        }

        public void Envia()
        {
            this.Enviador.Envia(this);
        }
    }

}