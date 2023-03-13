namespace ListadeExercicio01.Exercicio25
{
    internal class Program
    {
        /*Escreva um algoritmo que leia um valor inicial A e imprima a sequência de valores do cálculo de A! e o seu
        resultado.
        a.Ex: 5! = 5 X 4 X 3 X 2 X 1 = 120
        b.Pesquise sobre “fatorial”*/
        static void Main(string[] args)
        {
            const string sair = "S";
            string resposta = "";

 
            Console.WriteLine(" leia um valor inicial A e imprima a sequência de valores do cálculo de A!\r\n        resultado.\n------------------");
            while (resposta.ToUpper() != sair)
            {
                Console.WriteLine("Valor para A!: ");
                long A = Convert.ToInt64(Console.ReadLine());

                for (long i = A-1; i > 1; i--)
                {
                    A *= i;
                    

                }
                Console.WriteLine("resultado de A!: " + A);


                Console.WriteLine("Sair S/N");
                resposta = Console.ReadLine();


            }

          
            Console.ReadLine();
        }
    }
}