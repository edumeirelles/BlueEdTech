using System;
using System.Collections.Generic;
using System.IO;

namespace Testes_01_02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new();
            while (true)
            {
                Console.WriteLine("Digite um número:");
                int n = Convert.ToInt32(Console.ReadLine());
                lista.Add(n);
                lista.Sort();

                Console.WriteLine("[{0}]", string.Join(", ", lista));

                TextWriter texto = new StreamWriter("d:/lista.txt");
                foreach (int i in lista)
                    texto.WriteLine(i);
                texto.Close();
            }
        }
    }
}
