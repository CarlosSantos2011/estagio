using DesignPatterns2.Aula8;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2
{
    public class EmpresaFacade
    {
        public Cliente BuscaCliente(string cpf)
        {
            return new ClienteDAO().BuscaPorCpf(cpf);
        }
        public Fatura CriaFatura(Cliente cliente, double valor)
        {
            return CriaFatura(cliente, valor);
        }
        public Cobranca GeraCobranca (Tipo tipo, Fatura fatura)
        {
            Cobranca cobranca = new Cobranca(tipo, fatura);
            cobranca.Emite();
        }
        public ContatoCliente FazContato (Cliente cliente, Cobranca cobranca)
        {
            ContatoCliente conta = new ContatoCliente(cliente, cobranca);
            FazContato.Dispara();
            return FazContato;
        }
    }
}
