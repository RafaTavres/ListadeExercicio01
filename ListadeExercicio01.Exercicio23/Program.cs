namespace ListadeExercicio01.Exercicio23
{
    internal class Program
    {
        //Desenvolver um algoritmo que efetue a soma de todos os números ímpares que são múltiplos de três e que se
        //encontram no conjunto dos números de 1 até 500.
        static void Main(string[] args)
        {
            Console.WriteLine("ímpares que são múltiplos de três e que se encontram no conjunto dos números de 1 até 500");
            int resultado = 0;

            for (int i = 1; i < 500; i++)
            {

                if (i % 2 == 0)
                {
                }
                else
                {
                    if (i % 3 == 0)
                    {
                        Console.Write(i + ",");

                    }
                    if(i % 3 == 0)
                    {

                      resultado += i;

                    }


                    }
            }
            Console.Write("\n");
            Console.Write("Soma dos Ímpares entre 1 e 500"+resultado);
            Console.ReadLine();
        }
    }
}