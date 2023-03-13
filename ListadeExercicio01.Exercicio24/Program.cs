namespace ListadeExercicio01.Exercicio24
{
    internal class Program
    {
        /*Escrever um algoritmo que leia um valor para uma variável N de 1 a 10 e calcule a tabuada de N. Mostre a
        tabuada na forma:
         0 x N = 0,
         1 x N = 1N,
         2 x N = 2N,
        .
        .
        .
         10 x N = 10N.*/
        static void Main(string[] args)
        {
            const string sair = "S";
            string resposta = "";
            double resultado = 0;
            //test


            List<string> Historico = new List<string>();
            Console.WriteLine("Calculdadora de volume de um cilindro\n------------------");
            while (resposta.ToUpper() != sair)
            {

                Console.WriteLine("Número para a tabuada: ");
                int nm1 = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < 11; i++)
                {
                    resultado = i * nm1;
                    Console.WriteLine(i + " x " + nm1 + " = " + resultado);
                }



                Console.WriteLine("Sair S/N");
                resposta = Console.ReadLine();


            }
        }
    }
}