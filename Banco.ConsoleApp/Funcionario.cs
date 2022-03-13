using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.ConsoleApp
{
    internal class Funcionario
    {
        public string nome;
        public string departamento;
        public double salario;
        public string dataEntrada;
        public string rg;
        public Boolean estaNaEmpresa = true;




        public void bonifica(double aumento)
        {
            this.salario += aumento;
        }

        public void demite()
        {
            estaNaEmpresa = false;
        }

        public void mostraFuncionario()
        {
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Departamento: " + departamento);
            Console.WriteLine("Sálario: " + salario);
            Console.WriteLine("Data de entrada: " + dataEntrada);
            Console.WriteLine("RG: " + rg);
            Console.WriteLine("Está na empresa? " + estaNaEmpresa);
        }
    }
}
