namespace ListadeExercicio01.Exercicio08
{
    internal class Program
    {
        //Crie um programa para calcular o volume de uma lata de óleo
        static void Main(string[] args)
        {


            const string sair = "S";
            string resposta = "";
            string historico = "";
            double resultado = 0;
            //test


            List<string> Historico = new List<string>();
            Console.WriteLine("Calculadadora de volume de uma lata de óleo\n------------------");
            while (resposta.ToUpper() != sair)
            {
                Console.Write("Raio: ");
                double raio = Convert.ToDouble(Console.ReadLine());
                
                Console.Write("Altura: ");
                double altura = Convert.ToDouble(Console.ReadLine());


                resultado = Math.Round(Math.PI, 4) * Math.Pow(raio, 2) * altura;

                Console.WriteLine("Volume de " + resultado + "m³");



                Console.WriteLine("Sair S/N");
                resposta = Console.ReadLine();


                historico = Convert.ToString(Math.Round(Math.PI, 4)) + " x " + Convert.ToString(raio) + "m² x " + Convert.ToString(altura) + "m = " + Convert.ToString(Math.Round(resultado, 4) + "m³");


                Historico.Add(historico);

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