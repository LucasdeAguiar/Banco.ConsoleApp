using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.ConsoleApp
{
    public class Conta_Corrente
    {
        //atributos
        public  int numero;
        private double saldo=0;
        public  Boolean especial;
        private double limite;
        private static int totalDeContas;


        public  Cliente titular = new Cliente();
     //   public  Movimentacao[] Movimentacoes;

       

        public Conta_Corrente()
        {
            
            Conta_Corrente.totalDeContas = Conta_Corrente.totalDeContas + 1;
        }

        public double Saldo
        {
            get { return saldo + limite; }
            set { saldo = value; }
        }

        public double Limite
        {
            get { return limite; }
            set { limite = value; }
        }
        public Cliente Titular
        {
            get { return titular; }
            set { titular = value; }
        }

        public static int TotalDeContas { get => totalDeContas;  }







        //Métodos
        public void sacar(double valorSaque)
        {
           

            if (Saldo < valorSaque && valorSaque > Limite)
            {
                Console.WriteLine("Não vai da não..");
            }
            else
            {
                this.Saldo = this.Saldo - valorSaque;
              
            }
           
        }

        public void depositar(double deposito)
        {
        

            Saldo = Saldo + deposito;
            
        }

        public void emitirSaldo()
        {
            Console.WriteLine("Saldo Bancário: " + Saldo);
        }

        public void extrato()
        {
          //  Console.WriteLine("Nome do titular: " + titular.nome + " " + titular.sobrenome);
          //  Console.WriteLine("CPF do titular: " + titular.cpf);
            titular.mostrarCliente();
            Console.WriteLine("Número da conta: " + numero);
            Console.WriteLine("Saldo da conta: " + Saldo);
            Console.WriteLine("Limite da conta: " + Limite);
            Console.WriteLine("É especial: " + especial);
            Console.WriteLine("\n");
        }
        
        public void transferirPara(Conta_Corrente conta, double valor)
        {
            this.Saldo = this.Saldo - valor;
            conta.Saldo += valor;
            
        }

    /*
        public void registrarNovaMovimentacao(double valor, TipoMovimentacao tipo)
        {
            Movimentacao novaMovimentacao = new Movimentacao();

            novaMovimentacao.tipo = tipo;
            novaMovimentacao.valor = valor;

            for (int i = 0; i<Movimentacoes.Length;i++)
            {
                if (Movimentacoes[i] == null)
                {
                    Movimentacoes[i] = novaMovimentacao;
                    break;
                }
            }
        }

        */
      
    }

   
}

