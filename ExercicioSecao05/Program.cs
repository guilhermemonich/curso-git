using System;
using System.Collections.Generic;

namespace ExercicioSecao05
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtdAlunos;
            HashSet<int> alunos = new HashSet<int>();
            HashSet<int> alunosA = new HashSet<int>();
            HashSet<int> alunosB = new HashSet<int>();
            HashSet<int> alunosC = new HashSet<int>();

            Console.Write("O curso A possui quantos alunos? ");
            qtdAlunos = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os códigos dos alunos do curso A:");
            for (int i = 0; i < qtdAlunos; i++)
            {
                alunosA.Add(int.Parse(Console.ReadLine()));
            }

            Console.Write("O curso B possui quantos alunos? ");
            qtdAlunos = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os códigos dos alunos do curso B:");
            for (int i = 0; i < qtdAlunos; i++)
            {
                alunosB.Add(int.Parse(Console.ReadLine()));
            }

            Console.Write("O curso C possui quantos alunos? ");
            qtdAlunos = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os códigos dos alunos do curso C:");
            for (int i = 0; i < qtdAlunos; i++)
            {
                alunosC.Add(int.Parse(Console.ReadLine()));
            }

            alunos.UnionWith(alunosA);
            alunos.UnionWith(alunosB);
            alunos.UnionWith(alunosC);

            Console.Write($"Total de alunos: { alunos.Count}");
            Console.WriteLine("Iniciando a utilizar o GIT");
            
            Console.ReadKey();
        }
    }
}
