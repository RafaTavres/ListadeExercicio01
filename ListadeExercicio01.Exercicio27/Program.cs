namespace ListadeExercicio01.Exercicio27
{
    internal class Program
    {
        //Escreva um programa que imprima os números de 1 a 100 em ordem crescente, substituindo os números
        //múltiplos de 3 pela palavra &quot;Fizz&quot; e os múltiplos de 5 pela palavra &quot;Buzz&quot;. Para números que são múltiplos de
        //ambos, use &quot;FizzBuzz&quot;.
        static void Main(string[] args)
        {

            Console.WriteLine("Numeros que são múltiplos de três e que se encontram no conjunto dos números de 1 até 500");

            for (int i = 1; i < 100; i++)
            {

                if (i % 5 == 0 && i % 3 == 0)
                {

                   Console.Write("fizzbuzz, ");

                }else
                if (i % 3 == 0)
                {

                 Console.Write("fizz, ");

                }else
                if (i % 5 == 0)
                {

                    Console.Write("buzz, ");

                }else
                {
                    Console.WriteLine(i + ", ");
                }




            }
        }
    }
}