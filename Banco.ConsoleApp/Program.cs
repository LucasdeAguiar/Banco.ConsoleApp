using System;

namespace Banco.ConsoleApp
{
  
    internal class Program
    {
        
        static void Main(string[] args)
        {


/*
            Cliente c = new Cliente();
            Conta_Corrente conta_1 = new Conta_Corrente();

            Conta_Corrente conta_2 = new Conta_Corrente();

            int total = Conta_Corrente.TotalDeContas;

            Console.WriteLine(total);


          Conta_Corrente conta_2 = new Conta_Corrente();
          
          Cliente c2 = new Cliente();
          conta_1.titular = c;
          conta_2.titular = c2;


            c.nome = "Lucas";
            c.sobrenome = "Aguiar";
            c.MudaCPF("19104630785");
            c.mostrarCliente();

            conta_1.Saldo = 1000;
            conta_1.Limite = 2000;
        */


            /*
            conta_1.Saldo = 1000;
            conta_1.Limite = 0;
            conta_1.numero = 321;
            conta_1.sacar(500);
            conta_1.depositar(100);
            conta_1.especial = false;
            conta_1.extrato();
            
          
            conta_1.titular.nome = "Lucas";
            conta_1.titular.sobrenome = "Gomes";
            conta_1.titular.cpf = "191.046.307-85";
            conta_1.extrato();


            conta_2.saldo = 1500;
            conta_2.limite = 0;
            conta_2.numero = 654;
            conta_2.sacar(100);
            conta_2.depositar(200);
            conta_2.especial = true;
            
         
            conta_2.titular.nome = "Maria";
            conta_2.titular.sobrenome = "Alves";
            conta_2.titular.cpf = "132.321.123-32";
            conta_2.extrato();

         
            conta_1.transferirPara(conta_2, 400);

   */




            Funcionario f1 = new Funcionario("Fiodor", "41.34434.213424", 100, "12/12/2020","123");
           
            f1.bonifica(50);
          
            f1.mostraFuncionario();
          




        }


    }

    
}
