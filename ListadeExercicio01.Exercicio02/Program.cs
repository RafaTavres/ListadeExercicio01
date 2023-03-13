namespace ListadeExercicio01.Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crie um programa para converter a temperatura de graus Fahrenheit para graus Celsius
            //°C = (°F − 32) ÷ 1,8


            const string sair = "S";
            string resposta = "";
            string historico = "";
            //test


            List<string> Historico = new List<string>();
            Console.WriteLine("Conversor de temperatura em graus Fahrenheit para graus Celsius\n------------------");
            while (resposta.ToUpper() != sair)
            {
                Console.Write("-------------\nTemperatura em F°: ");
                double farenheint = Convert.ToDouble(Console.ReadLine());
                double celsiu = (farenheint - 32) / 1.8;

                Console.WriteLine("Temperatura em C°: "+ Math.Round(celsiu, 4) + "C°\n-------------");
  
                Console.WriteLine("Sair S/N");
                resposta = Console.ReadLine();

                historico = Convert.ToString(farenheint)+"F°" + " = " + Convert.ToString(Math.Round(celsiu, 4)+ "C°");


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