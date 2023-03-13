namespace ListadeExercicio01.Exercicio05
{
    internal class Program
    {
        //Crie um programa para calcular o volume de uma esfera
        //Ve = 4. p.r³/3. 
        static void Main(string[] args)
        {

            const string sair = "S";
            string resposta = "";
            string historico = "";
            double resultado = 0;
            //test


            List<string> Historico = new List<string>();
            Console.WriteLine("Calculdadora de volume de uma esfera\n------------------");
            while (resposta.ToUpper() != sair)
            {
                Console.WriteLine("Raio: ");
                double raio = Convert.ToInt32(Console.ReadLine());

                resultado = (4 * Math.Round(Math.PI,2) * Math.Pow(raio, 3)) / 3;

                Console.WriteLine(""+ Math.Round(resultado,2) + " cm³");



                Console.WriteLine("Sair S/N");
                resposta = Console.ReadLine();

                historico = "Raio Inicial: " + Convert.ToString(raio)+ ", PI :"+Convert.ToString(Math.Round(Math.PI, 2)) + ", Volume Final" + Convert.ToString(Math.Round(resultado, 2) + "cm³");
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