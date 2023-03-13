namespace ListadeExercicio01.Exercicio07
{
    internal class Program
    {
        //Crie um programa para calcular o salário total de um vendedor. Deverá ser informado o salário base e o total de
        //vendas.A comissão é calculada com um percentual(informado pelo usuário) sobre o total de vendas.
        static void Main(string[] args)
        {
            const string sair = "S";
            string resposta = "";
            string historico = "";
            double resultado = 0;


            List<string> Historico = new List<string>();
            Console.WriteLine("Salário do vendedor\n------------------");
            while (resposta.ToUpper() != sair)
            {
                Console.Write("-------------\nSalario base: ");
                double salarioBase = Convert.ToDouble(Console.ReadLine());
                Console.Write("Quantidade de dinheiro das Vendas:: ");
                double QuantidadeVendida = Convert.ToDouble(Console.ReadLine());
                Console.Write("Percentual ganho sobre as vendas: ");
                double Porcentagem = Convert.ToDouble(Console.ReadLine());

                double Perncentual = Porcentagem / 100;

                resultado = salarioBase + QuantidadeVendida * Perncentual;



                Console.WriteLine("Salario Final: " + resultado);

                Console.WriteLine("Sair S/N");
                resposta = Console.ReadLine();

                historico = "Salario Base: "+ Convert.ToString(salarioBase) + ", QuantidadeVendida: "+ Convert.ToString(QuantidadeVendida) + ", Salario Final: " + Convert.ToString(Perncentual);


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