using System;
using System.Collections.Generic;
using System.Text;

namespace Bytebank
{
    public class ContaCorrente
    {
        private int numero_agencia;
        public int Numero_agencia
        {
            get { return this.numero_agencia; }
            private set
            {
                if (value > 0)
                {
                    this.numero_agencia = value;
                }
            }
        }
        
        private string conta;
        public string Conta { get; set; }
       

        private string titular;
        public string Titular { get; set; }
        private double saldo;
        
        

        public void depositar (double valor)
        {
            this.saldo += valor;
        }

        public bool Sacar(double Valor)
        {
           if (Valor <= this.saldo)
            {
                this.saldo -= Valor;
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public bool Transferir(double valor, ContaCorrente destino)
        {
            if(this.saldo < valor)
            {

                return false;
            }
            else
            {
                this.saldo -= valor;
                destino.saldo += valor;
                return true;
            }

        }

        public void SetSaldo(double valor)
        {
            if(valor <0)
            {
                return;
            }
            else
            {
                this.saldo = valor;
            }
        }

        public double GetSaldo()
        {
            return this.saldo;
        }

        public ContaCorrente(int numero_agencia, string numero_conta)
        {
            this.numero_agencia = numero_agencia;
            this.Conta = numero_conta;
        }
    }
}
