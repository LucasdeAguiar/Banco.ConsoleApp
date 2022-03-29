using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.ConsoleApp
{
    internal class Funcionario
    {
        private string nome;
        private string departamento;
        private double salario;
        private string dataEntrada;
        private string rg;
        public Boolean estaNaEmpresa = true;

        public Funcionario(string nome, string departamento, double salario, string dataEntrada, string rg)
        {
            this.nome = nome;
            this.departamento = departamento;
            this.salario = salario;
            this.dataEntrada = dataEntrada;
            this.rg = rg;
        }



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
