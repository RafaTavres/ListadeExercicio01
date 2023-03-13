using static System.Net.Mime.MediaTypeNames;

namespace ListadeExercicio01.Exercicio28
{
    internal class Program
    {
        //Escreva um programa que exiba a tabuada de multiplicação do 1 até o 10. Para isso, o programa deve gerar
        //todas as combinações de multiplicação entre 1 e 10, exibindo o resultado de cada operação na tela.
        //a.Desafio: Para cada número, tente separar em colunas.

        static void Main(string[] args)
        {
            const string sair = "S";
            string resposta = "";
            double resultado = 0;
            //test


            List<string> Historico = new List<string>();
            Console.WriteLine("Exiba a tabuada de multiplicação do 1 até o 10\n------------------");
            while (resposta.ToUpper() != sair)
            {

                Console.WriteLine("Enter para a tabuada: ");
                Console.ReadKey();

                for (int i = 1; i < 11; i++)
                {
                    
                    for (int j = 1; j < 11; j++)
                    {
                        resultado = i * j;

                        if (resultado >= 10)
                        {
                            Console.Write(i + " x " + j + " = " + resultado + "||");
                            
                        }
                        else
                        {
                            Console.Write(i + " x " + j + " = 0" + resultado + "||");
                        }
                       
                       
                    }
                    Console.WriteLine("");
                   


                }



                Console.WriteLine("Sair S/N");
                resposta = Console.ReadLine();
            }
        }
    }
}
