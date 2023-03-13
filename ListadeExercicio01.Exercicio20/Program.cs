namespace ListadeExercicio01.Exercicio20
{
    //Faça um algoritmo para receber um número qualquer e informar na tela se é par ou ímpar.
    internal class Program
    {
        static void Main(string[] args)
        {
            const string sair = "S";
            string resposta = "";
            string historico = "";
            double resultado = 0;
            //test


            List<string> Historico = new List<string>();
            Console.WriteLine("Algoritmo para receber um número qualquer e informar na tela se é par ou ímpar.\n------------------");
            while (resposta.ToUpper() != sair)
            {

               Console.WriteLine("Numero para verificação");
               int Numero = Convert.ToInt32(Console.ReadLine());

                if (Numero % 2 == 0)
                {
                    Console.WriteLine("Par");

                }
                else
                {
                    Console.WriteLine("Ímpar");

                }



                Console.WriteLine("Sair S/N");
                resposta = Console.ReadLine();


            }

            Console.WriteLine("Histórico: ");
            foreach (var item in Historico)
            {

                Console.WriteLine(item);


            }

            Console.WriteLine("Número de operaçoes: " + Historico.Count());
            Console.ReadLine();

        }
    }
}