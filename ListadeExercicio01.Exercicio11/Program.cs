namespace ListadeExercicio01.Exercicio11
{
    internal class Program
    {
        //Crie um programa para verificar se um número é primo.
        static void Main(string[] args)
        {
            const string sair = "S";
            string resposta = "";
            string historico = "";
            double resultado = 0;
            //test


            List<string> Historico = new List<string>();
            Console.WriteLine("Calculdadora verificar se um número é primo.\n------------------");
            while (resposta.ToUpper() != sair)
            {

                Console.WriteLine("Numero que deseja verificar: ");
                int nmbr = Convert.ToInt32(Console.ReadLine());


                if (nmbr == 2)
                {
                    Console.WriteLine("O número " + nmbr + " é Primo");
                }else
                 if (nmbr == 3)
                {
                    Console.WriteLine("O número " + nmbr + " é Primo");
                }
                else
                if (nmbr == 1)
                {
                    Console.WriteLine("O número " + nmbr + " Não é Primo");
                }
                else
                if (nmbr % 2 == 0 || nmbr % 3 == 0)
                {
                    Console.WriteLine("O número "+ nmbr + " Não é Primo");
                }
                else
                {
                    Console.WriteLine("O número "+ nmbr + " é Primo");
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