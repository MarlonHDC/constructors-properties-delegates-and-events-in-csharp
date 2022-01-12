using ExemploConstrutores.Models;
using System;


namespace ExemploConstrutores
{
    class Program
    {
        public delegate void Operacao(int x, int y);// Delegate

        static void Main(string[] args)
        {

            Matematica m = new Matematica(10, 20);
            m.Somar();
            
            //Operacao op = Calculadora.Somar
            //Operacao op = new Operacao(Calculadora.Somar);
            //op += Calculadora.Subtrair;// Multicast Delegate

            //op.Invoke(10, 10);
            
            //op(10, 10);

            //const double pi = 3.14;
            // Console.WriteLine(pi);

                        
            //Data data = new Data();
            //data.SetMes(20);

            //data.SetMes(12);
            //Console.WriteLine((data.Mes);

            //data.ApresentarMes();
            
            //Aluno p1 = new Aluno("Marlon", "Dias", "Teste");
            //p1.Apresentar();
            
            
            //Log log = Log.GetInstance();

            //log.PropriedadeLog = "Teste instancia";

            //Log log2 = Log.GetInstance();
            //Console.WriteLine(log2.PropriedadeLog);
            
            
            //Pessoa p1 = new Pessoa("Marlon", "Dias");
            //p1.Apresentar();
        }
    }
}
