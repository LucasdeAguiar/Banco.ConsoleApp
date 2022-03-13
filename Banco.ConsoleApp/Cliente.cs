using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.ConsoleApp
{
    internal class Cliente
    {
        public string nome;
        public string sobrenome;
        public string cpf;

       

        public void mostrarCliente()
        {
            Console.WriteLine("Nome do cliente: " + nome + " " + sobrenome);
            Console.WriteLine("CPF: " + cpf);
        }

       


    }

    
}
