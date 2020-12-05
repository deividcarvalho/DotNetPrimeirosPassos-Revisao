using System;

namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno [5];
            var indiceAluno = 0;

            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        Console.WriteLine("Informe o nome do aluno: ");
                        Aluno aluno = new Aluno();
                        aluno.Nome = Console.ReadLine();

                        Console.WriteLine("Informe a nota do aluno: ");
                        //O TryParse retorna um bool. Se conseguir fazer o parse da string para decimal,
                        //do valor digitado no terminal, será atribuída à nova variável nota que já está no método.
                        if (decimal.TryParse(Console.ReadLine(), out decimal nota))
                        {
                        aluno.Nota = nota;
                        
                        }else
                        {
                            throw new ArgumentException("O valor da nota deve ser decimal");
                        }
                        
                        alunos[indiceAluno] = aluno;
                        indiceAluno++;
                        
                        break;
                    case "2":
                        //TO DO: Listar alunos 
                        break;
                    case "3":
                        //TO DO: Calcular média geral 
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();

                }

                opcaoUsuario = ObterOpcaoUsuario();

            }


        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine("1 - Inserir novo aluno");
            Console.WriteLine("2 - Listar alunos");
            Console.WriteLine("3 - Calcular média geral");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}
