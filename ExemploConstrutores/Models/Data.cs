using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploConstrutores.Models
{
    public class Data
    {
        private int mes;
        private bool mesValido;

        public int GetMes()
        {
            return this.mes;
        }

        public void SetMes(int mes)
        {
            if (mes >0 && mes <=12)
            {
                this.mes = mes;
                this.mesValido = true;
            }
        }

        public int Mes { get; set; }

        public void ApresentarMes()
        {
            if (this.mesValido)
            {
                Console.WriteLine(this.mes);
            }
            else
            {
                Console.WriteLine("Mês invalido!");
            }
        }
    }
}
