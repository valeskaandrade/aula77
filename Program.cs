using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //aula 77
            List<string> lista = new List<string>();
            lista.Add("Maria");
            lista.Add("Alex");
            lista.Add("Bob");
            lista.Insert(2, "Anna");
            lista.Insert(4, "Marco");
            foreach (string nome in lista) { Console.WriteLine(nome); }
            //Console.WriteLine("lista.count:" + lista.Count );
            //string s1 = lista.Find(x => x[0] == 'A');
            //Console.WriteLine("primeiro nome com a:" + s1);
            //string s2 = lista.FindLast(x => x[0] == 'A');
            //Console.WriteLine("último nome com a:" + s2);

            //List<string> lista2 = lista.FindAll(x => x.Length == 5);
            //foreach (string nome in lista2) { Console.WriteLine(nome); }

            //lista.RemoveAt(3);
            lista.RemoveRange(2, 2);
            foreach (string nome in lista) { Console.WriteLine(nome); }
           
        }
    }
}
