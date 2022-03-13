using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.ConsoleApp
{
    internal class Movimentacao
    {
        public double valor;
        public TipoMovimentacao tipo;
        
   }

    public enum TipoMovimentacao
    {
        Credito , Debito
    }
}
