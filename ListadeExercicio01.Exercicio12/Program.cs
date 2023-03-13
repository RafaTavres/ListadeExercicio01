namespace ListadeExercicio01.Exercicio12
{
    internal class Program
    {
        //A imobiliária Imóbilis vende apenas terrenos retangulares. Faça um algoritmo para ler as dimensões de um
        //terreno e depois exibir a área do terreno.
        static void Main(string[] args)
        {
            const string sair = "S";
            string resposta = "";
            double resultado = 0;
            //test


            List<double> Historico = new List<double>();
            Console.WriteLine("Algoritmo para ler as dimensões de um terreno e depois exibir a área\n------------------");
            while (resposta.ToUpper() != sair)
            {
                Console.WriteLine("Base: ");
                double _base = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Altura: ");
                double altura = Convert.ToDouble(Console.ReadLine());


                resultado = _base * altura;

                Console.WriteLine("Área: " +resultado+ "m²");

                Historico.Add(resultado);

                Console.WriteLine("Sair S/N");
                resposta = Console.ReadLine();


            }


            Console.WriteLine("Histórico: ");
            foreach (var item in Historico)
            {

                Console.WriteLine("Área: "+ item);


            }

            Console.WriteLine("Número de operaçoes: " + Historico.Count());
            Console.ReadLine();
        }
     }
}