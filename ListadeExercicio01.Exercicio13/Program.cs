namespace ListadeExercicio01.Exercicio13
{
    internal class Program
    {
        /*A padaria Hotpão vende uma certa quantidade de pães franceses e uma quantidade de broas a cada dia. Cada
        pãozinho custa R$ 0,12 e a broa custa R$ 1,50. Ao final do dia, o dono quer saber quanto arrecadou com a
        venda dos pães e broas (juntos), e quanto deve guardar numa conta de poupança (10% do total arrecadado).
        Você foi contratado para fazer os cálculos para o dono. Com base nestes fatos, faça um algoritmo para ler as
        quantidades de pães e de broas, e depois calcular os dados solicitados.*/

        static void Main(string[] args)
        {
            const string sair = "S";
            string resposta = "";
            string historico = "";
            double resultado = 0;
            double Poupanca = 0;
            const double PrecodoPao = 0.12;
            const double PrecoBroa = 1.50;






            List<string> Historico = new List<string>();
            Console.WriteLine("Calculadora da HotPão\n------------------");
            while (resposta.ToUpper() != sair)
            {
                Console.WriteLine("Quantidade vendida de Pães: ");
                double pao = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Quantidade vendida de Broas: ");
                double broa = Convert.ToDouble(Console.ReadLine());

                resultado = (pao * PrecodoPao) + (broa * PrecoBroa);
                Poupanca = resultado * 10 / 100;

                Console.WriteLine("Resultado: "+ resultado +" R$");
                Console.WriteLine("Poupança: " + Poupanca +" R$");

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