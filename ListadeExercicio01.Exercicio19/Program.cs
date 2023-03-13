namespace ListadeExercicio01.Exercicio19
{
    internal class Program
    {
        /*O IMC – Índice de Massa Corporal é um critério da Organização Mundial de Saúde para dar uma indicação sobre
            a condição de peso de uma pessoa adulta. A fórmula é IMC = peso / (altura) ². Elabore um algoritmo que leia o
            peso e a altura de um adulto e mostre sua condição de acordo com a listagem abaixo:
             IMC em adultos Condição
             Abaixo de 18,5
             Abaixo do peso
             Entre 18,5 e 25 Peso normal
             Entre 25 e 30
             Acima do peso
             Acima de 30 obeso*/

        static void Main(string[] args)
        {
            const string sair = "S";
            string resposta = "";
            string historico = "";
            double resultado = 0;
            //test


            List<string> Historico = new List<string>();
            Console.WriteLine("Calculdadora de IMC\n------------------");
            while (resposta.ToUpper() != sair)
            {

                Console.WriteLine("Peso: ");
                double Peso = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Altura: ");
                double Altura = Convert.ToDouble(Console.ReadLine());

                resultado = Peso / (Math.Pow(Altura, 2));

                if (resultado < 18.5)
                {
                    Console.WriteLine("Abaixo do Peso...");

                }
                else 
                if (resultado >= 18.5  && resultado < 25)
                {
                    Console.WriteLine("Peso Normal...");
                }
                else
                if (resultado >= 25 && resultado < 30)
                {
                    Console.WriteLine("Acima do Peso...");
                }
                else
                if (resultado > 30)
                {
                    Console.WriteLine("Obeso...");
                }

                Console.WriteLine("Sair S/N");
                resposta = Console.ReadLine();


            }

            Console.ReadLine();
        }
        
    }
}