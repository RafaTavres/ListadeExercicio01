namespace ListadeExercicio01.Exercicio17
{
    internal class Program
    {
        //Faça um algoritmo que leia os valores A, B, C e imprima na tela se a soma de A + B é menor que C.
        static void Main(string[] args)
        {
           const string sair = "S";
            string resposta = "";
            string historico = "";
            double resultado = 0;
            


            List<string> Historico = new List<string>();
            Console.WriteLine("Algoritmo que leia os valores A, B, C e imprima na tela se a soma de A + B é menor que C.\n------------------");
            while (resposta.ToUpper() != sair)
            {

                Console.WriteLine("Numero A: ");
                double A = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Numero B: ");
                double B = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Numero C: ");
                double C = Convert.ToDouble(Console.ReadLine());


                double SomaAeB = A + B;

                if (SomaAeB < C)
                {
                    Console.WriteLine("a soma de A e B é menor que C");
                }
                if (SomaAeB > C)
                {
                    Console.WriteLine("a soma de A e B NÃO é menor que C");
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