namespace ListadeExercicio01.Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crie um programa para calcular o volume de uma caixa retangular

            const string sair = "S";
            string resposta = "";
            string historico = "";
            double resultado = 0;
            //test

            
            List<string> Historico = new List<string>();
            Console.WriteLine("Calculdadora de volume de uma caixa retangular\n------------------");
            while (resposta.ToUpper() != sair)
            {

                Console.Write("Comprimento: ");
                double comprimento = Convert.ToDouble(Console.ReadLine());

                Console.Write("Largura: ");
                double largura = Convert.ToDouble(Console.ReadLine());

                Console.Write("Altura: ");
                double altura = Convert.ToDouble(Console.ReadLine());

                if (comprimento == 0 || largura == 0 || altura == 0)
                {
                    Console.WriteLine("Erro: Números de Medida nao podem ser 0");
                    continue;
                   
                }

                resultado = comprimento * largura * altura;

                Console.WriteLine("Volume de "+resultado+ " m³");


                historico = Convert.ToString(comprimento) + " " + Convert.ToString(largura) + " " + Convert.ToString(altura) + " = " + Convert.ToString(Math.Round(resultado, 2));


                Historico.Add(historico);

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

            //comprimento x largura x altura
        }
    }
}