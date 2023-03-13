namespace ListadeExercicio01.Exercicio22
{
    internal class Program
    {
        //Escrever um algoritmo que gera e escreve os números ímpares entre 100 e 200.
        static void Main(string[] args)
        {
            const string sair = "S";
            string resposta = "";
            string historico = "";
            double resultado = 0;
            //test


            Console.WriteLine("Calculdadora de volume de um cilindro\n------------------");
            for (int i = 100; i < 200; i++) 
            {

                if (i % 2 == 0)
                {
                }
                else
                {
                    Console.Write(i + ",");

                }
            }
            Console.WriteLine("Sair S/N");
            resposta = Console.ReadLine();



        }
    }
}