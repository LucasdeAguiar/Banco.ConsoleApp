using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.ConsoleApp
{
    internal class Conta_Corrente
    {
        //atributos
        public  int numero;
        public  double saldo=0;
        public  Boolean especial;
        public  double limite;
        public  Cliente titular = new Cliente();
        public Movimentacao[] Movimentacoes;
        

        //Métodos
        public void sacar(double valorSaque)
        {
           

            if (saldo < valorSaque && valorSaque > limite)
            {
                Console.WriteLine("Não é possível sacar pois o valor de saque é maior que o valor armazenado na conta");
            }
            else
            {
                saldo = saldo - valorSaque;
              
            }
            registrarNovaMovimentacao(valorSaque, TipoMovimentacao.Debito);
        }

        public void depositar(double deposito)
        {
        

            saldo = saldo + deposito;
            registrarNovaMovimentacao(deposito, TipoMovimentacao.Credito);
        }

        public void emitirSaldo()
        {
            Console.WriteLine("Saldo Bancário: " + saldo);
        }

        public void extrato()
        {
          //  Console.WriteLine("Nome do titular: " + titular.nome + " " + titular.sobrenome);
          //  Console.WriteLine("CPF do titular: " + titular.cpf);
            titular.mostrarCliente();
            Console.WriteLine("Número da conta: " + numero);
            Console.WriteLine("Saldo da conta: " + saldo);
            Console.WriteLine("Limite da conta: " + limite);
            Console.WriteLine("É especial: " + especial);
            Console.WriteLine("\n");
        }
        
        public void transferirPara(Conta_Corrente conta, double valor)
        {
            this.saldo = this.saldo - valor;
            conta.saldo += valor;
            
        }

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
    }

   
}

