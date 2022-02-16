using System;
using System.Globalization;
using System.Collections.Generic;
using Nota.Entities;

namespace Nota
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Alunos> list = new List<Alunos>();

            Console.Write("Informe a quantidade de alunos: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Nota final: ");
                int finallyNote = int.Parse(Console.ReadLine());
                list.Add(new Alunos(name, finallyNote));
                if (finallyNote >= 7)
                {
                    Console.WriteLine("Parabens você foi aprovado!!!");
                } else
                {
                    Console.WriteLine("Infelizmente você é burro e reprovou!");
                }
            }
        }
    }
}
