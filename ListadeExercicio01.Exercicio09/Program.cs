namespace ListadeExercicio01.Exercicio09
{
    internal class Program
    {
        //Crie um programa para calcular a média harmônica das notas de um Aluno
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            const string sair = "N";
            string resposta = "";
            decimal historico = 0;
            decimal resultado = 1;
            decimal resultado2 = 0;
            decimal resultado3 = 0;
            decimal resultado4 = 0;
            decimal resultado5 = 0;
            int quantNotas = 0;
            decimal Nota = 0;

            //test


            List<decimal> notas = new List<decimal>();
            List<decimal> Resultado2 = new List<decimal>();
            Console.WriteLine("Calculadadora para média harmônica das notas de um Aluno\n------------------");
            while (resposta.ToUpper() != sair)
            {
                Console.WriteLine("Nota: ");
                Nota = Convert.ToInt32(Console.ReadLine());
                notas.Add(Nota);
                quantNotas++;
 
                resultado *= Nota;

                Console.WriteLine("Mais notas? S/N");
                resposta = Console.ReadLine();

                


            }

            foreach (var item in notas)
            {
                resultado2 = resultado / item;
                Resultado2.Add(resultado2);

            }
            foreach (var item in Resultado2)
            {
                resultado3 += item;

            }

            Console.WriteLine("--------------------------------");
            resultado4 = quantNotas * resultado;
            resultado5 = resultado4 / resultado3;
            Console.WriteLine("resultado : " + Math.Round(resultado5));

            Console.ReadLine();
        }      
    }
}