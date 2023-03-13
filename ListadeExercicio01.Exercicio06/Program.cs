namespace ListadeExercicio01.Exercicio06
{
    internal class Program
    {
        //Crie um programa para converter a temperatura da escala Celsius para a escala Fahrenheit
        //°F = °C × 1, 8 + 32

        static void Main(string[] args)
        {
            const string sair = "S";
            string resposta = "";
            string historico = "";


            List<string> Historico = new List<string>();
            Console.WriteLine("Conversor de temperatura em graus Celsius para graus Fahrenheit\n------------------");
            while (resposta.ToUpper() != sair)
            {
                Console.Write("-------------\nTemperatura em C°: ");
                double celsiu = Convert.ToDouble(Console.ReadLine());
                double farenheint = (celsiu * 1.8) + 32;

                Console.WriteLine("Temperatura em F°: " + Math.Round(farenheint, 4) + "F°\n-------------");

                Console.WriteLine("Sair S/N");
                resposta = Console.ReadLine();

                historico = Convert.ToString(celsiu) + "C°" + " = " + Convert.ToString(Math.Round(farenheint, 4) + "F°");


                Historico.Add(historico);

            }

            Console.WriteLine("Histórico: ");
            foreach (var item in Historico)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();

            

        }
    }
}