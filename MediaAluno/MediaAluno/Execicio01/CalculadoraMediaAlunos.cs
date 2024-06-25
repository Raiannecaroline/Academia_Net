using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaAluno
{
    internal class CalculadoraMediaAlunos
    {
        static void Main(string[] args)
        {
            decimal notasSoma = 0;

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"\nDigite a {i + 1}° nota do Aluno: \n");
                decimal notas = Convert.ToDecimal(Console.ReadLine());

                notasSoma += notas;
            }

            decimal mediaAluno = (notasSoma / 4) / 10;

            if (mediaAluno >= 7)
            {
                Console.WriteLine($"\nO Aluno foi aprovado com a média de {mediaAluno:F1} \n");
            }
            else if (mediaAluno >= 5 && mediaAluno < 7)
            {
                Console.WriteLine($"\nO Aluno ficou com a média de {mediaAluno:F1} e está em Recuperação!!\n");
            }
            else
            {
                Console.WriteLine($"\nO Aluno foi reprovado com a média de {mediaAluno:F1}");
            }

        }
    }
}
