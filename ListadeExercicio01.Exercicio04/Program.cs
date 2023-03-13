namespace ListadeExercicio01.Exercicio04
{
    internal class Program
    {
        //Crie um programa para calcular o consumo de combustível por Km. Deverá ser informado a quilometragem
        //Inicial e Final do Percurso do Veículo.Deverá ser informado o Consumo de Combustível
        static void Main(string[] args)
        {
           
            const string sair = "S";
            string resposta = "";
            string historico = "";
            double resultado = 0;
            //test


            List<string> Historico = new List<string>();
            Console.WriteLine("Calculdadora de consumo de combustível por Km\n------------------");
            while (resposta.ToUpper() != sair)
            {

              
                Console.WriteLine("Comsumo do carro por Km: ");
                double Gasolinagasta = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Kilometragem Inicial");
                double kilometInicial = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Kilometragem final");
                double kilometFinal = Convert.ToDouble(Console.ReadLine());

                resultado = Gasolinagasta / (kilometFinal - kilometInicial);

                Console.WriteLine("Resultado: "+resultado+ " Km/L");

                Console.WriteLine("Sair S/N");
                resposta = Console.ReadLine();

                historico = "Kilometro Inicail: " + Convert.ToString(kilometInicial) + ", " + " Kilometro Final: " + Convert.ToString(kilometFinal) + ", Consumiu :" + Convert.ToString(resultado) +  "Km/L";


                Historico.Add(historico);

            }

            Console.WriteLine("Histórico dos Kilometros Percorridas: ");
            foreach (var item in Historico)
            {

                Console.WriteLine(item);


            }

            Console.WriteLine("Número de operaçoes: " + Historico.Count());
            Console.ReadLine();
        }






    }
}
