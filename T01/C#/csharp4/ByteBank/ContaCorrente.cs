using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class ContaCorrente
    {
        public static double TaxaOperacao { get; private set; }

        public static int TotalDeContasCriadas { get; private set; }

        public Cliente Titular { get; set; }

        public int ContadorSaquesNaoPermitidos { get; private set; }
        public int ContadorTransferenciasNaoPermitidas { get; private set; }
         
        public int Numero { get; }
        public int Agencia
        { get; }
            
        private double _saldo = 100;
        private int v1;
        private int v2;

        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }

                _saldo = value;
            }
        }

        public  ContaCorrente( int numeroagencia, int numeroConta )
        {

            if (numeroagencia <= 0)
            {
                throw new ArgumentException("os argumentos agencia e numero devem ser maiores do que 0",nameof(numeroagencia));
            }

            if (numeroConta <= 0 )
            {
                throw new ArgumentException("O argumento numero deve ser maior do que 0", nameof (numeroConta));
            }
            Agencia = numeroagencia;
            Numero = numeroConta;


            TotalDeContasCriadas++;
            TaxaOperacao = 30 / TotalDeContasCriadas;

        }




        public void Sacar(double valor)
        {
            if (valor < 0)
            {
                throw new ArgumentException("Valor inválido para o saque. ", nameof(valor));
            }

            if (_saldo < valor)
            {

                ContadorSaquesNaoPermitidos++;
                throw new SaldoInsuficienteException("Saldo insuficiente para o saque no valor de " + valor); ;
            }

            _saldo -= valor;
           
        }

        public void Depositar(double valor)

            
        {
            _saldo += valor;
        }

        public void Transferir(double valor, ContaCorrente contaDestino)
        {
            if (valor < 0)
            {
                throw new ArgumentException("Valor inválido para a transferência. ", nameof(valor));
            }

            Sacar(valor); 
            
            
            try
            {
                Sacar(valor);
            }
            catch(SaldoInsuficienteException ex )
            {
                ContadorTransferenciasNaoPermitidas++;
                throw new OperacaoFinanceiraException("Operação não realizada", ex);
            } 

         
            contaDestino.Depositar(valor);
           
        }
    }
}
