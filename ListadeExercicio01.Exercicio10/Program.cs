namespace ListadeExercicio01.Exercicio10
{
    internal class Program
    {
        //Crie um programa para calcular a média ponderada de duas provas realizadas por um aluno
        static void Main(string[] args)
        {
           const string sair = "S";
            string resposta = "";
            string historico = "";
            double resultado = 0;
            double prova1 = 0;
            double prova2 = 0;
            double PesodaProva1 = 0;
            double PesodaProva2 = 0;
            //test


           
            Console.WriteLine("Programa para calcular a média ponderada de duas provas realizadas por um aluno\n------------------");
            while (resposta.ToUpper() != sair)
            {

               Console.WriteLine("Nota da Prova 1: ");
               prova1 = Convert.ToInt32(Console.ReadLine());
               Console.WriteLine("Peso da Prova 1: ");
               PesodaProva1 = Convert.ToInt32(Console.ReadLine());

               Console.WriteLine("Nota da Prova 2: ");
               prova2 = Convert.ToInt32(Console.ReadLine());
               Console.WriteLine("Peso da Prova 2: ");
               PesodaProva2 = Convert.ToInt32(Console.ReadLine());

               resultado = ((prova1 * PesodaProva1) + (prova2 * PesodaProva2)) / ( PesodaProva1 + PesodaProva2 );

                Console.WriteLine("Resultado: "+ Math.Round(resultado,2));

                Console.WriteLine("Sair S/N");
                resposta = Console.ReadLine();


            }

        }
        
    }
}