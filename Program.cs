using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooPolimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangulo t1 = new Triangulo("Triangulo", 2, 2, 0);
            Triangulo t2 = new Triangulo("Triangulo", 4, 4, 0);
            Triangulo t3 = new Triangulo("Triangulo", 8, 8, 0);

            Quadrado q1 = new Quadrado(2, 2);
            Quadrado q2 = new Quadrado(4, 4);
            Quadrado q3 = new Quadrado(8, 8);

            List<Formas> Formas = new List<Formas>();
            Formas.Add(q1);
            Formas.Add(q2); 
            Formas.Add(q3);
            Formas.Add(t1);
            Formas.Add(t2);
            Formas.Add(t3);
            //foreach (var item in Formas)
            //{
            //    Console.WriteLine("Tipo da forma: " + item.FormaGeometrica);
            //    Console.WriteLine("Base da forma: " + item.Base);
            //    Console.WriteLine("Altura da forma: " + item.Altura);
            //    Console.WriteLine("Cálculo da Area: " + item.CalcularArea());
            //}
            ExibirTipo(q1);

            Console.ReadKey();
        }

        static void ExibirTipo(Formas forma)
        {
            Quadrado q = (Quadrado)forma;
            q.Teste = "Melhor curso POO";
            Console.WriteLine(q.Teste);
            Console.WriteLine("Tipo da forma: " + forma.FormaGeometrica);
        }
    }
}
