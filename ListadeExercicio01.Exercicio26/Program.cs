namespace ListadeExercicio01.Exercicio26
{
    internal class Program
    {
        /* Escreva um programa que leia um número e imprima a sequência de Fibonacci até esse número. */
        static void Main(string[] args)
        {
            const string sair = "S";
            string resposta = "";
            int nm1 = 0, fibo = 1, nm3;


            Console.WriteLine(" leia um valor inicial A e imprima a sequência de valores do cálculo de A!\r\n        resultado.\n------------------");
            while (resposta.ToUpper() != sair)
            {
                Console.WriteLine("Valor para Fibonacci: : ");
                int A = Convert.ToInt32(Console.ReadLine());



                while (fibo <= A)
                {
                   
                      nm3 = nm1;
                      nm1 = fibo;
                      fibo = nm1 + nm3;
                      Console.WriteLine("{0}", fibo);
                   
                }
                nm3 = 0;
                nm1 = 0;
                fibo = 1;
                Console.WriteLine("Sair: S/N");
                resposta = Console.ReadLine();

            }


            Console.ReadLine();
        }
    }
}