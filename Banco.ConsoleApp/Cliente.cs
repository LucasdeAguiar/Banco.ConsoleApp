using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.ConsoleApp
{
    public class Cliente
    {
        public string nome;
        public string sobrenome;
        private string cpf;
        private int idade;

        public string Cpf { get => cpf; set => cpf = value; }

        public void mostrarCliente()
        {
            Console.WriteLine("Nome do cliente: " + this.nome + " " + this.sobrenome);
            Console.WriteLine("CPF: " + this.Cpf);
            Console.ReadLine();
        }

        public void MudaCPF(String cpf)
        {
            bool validacao =  ValidaCPF(cpf);

            if (validacao == true)
            {
                Notificador(true);
                this.cpf = cpf;
            }
            else
            {
                Notificador(false);
                

            }
        }

        private bool ValidaCPF(String cpf)
        {
            if (cpf.Length == 11)
            {
                return true;
            }
            else if(cpf.Length != 11)
            {         
                return false;
               
            }
            return false;
        }

        public void Notificador(bool opcao)
        {
            if (opcao == true)
            {
                Console.WriteLine("Sucesso!");
            }
            else if(opcao == false)
            {
                Console.WriteLine("Cadastro inválido");
            }
        }

       




    }


}
