namespace ListadeExercicio01.Exercicio16
{
    internal class Program
    {
        //Faça um algoritmo para ler o salário de um funcionário e aumentá-lo em 15%. Após o aumento, desconte 8% de
        //impostos.Imprima o salário inicial, o salário com o aumento e o salário final.
        static void Main(string[] args)
        {
            const string sair = "S";
            string resposta = "";
            string historico = "";
            


            
            Console.WriteLine("Salário do Funcionário\n------------------");
            while (resposta.ToUpper() != sair)
            {
                Console.Write("-------------\nSalario : ");
                double salarioBase = Convert.ToDouble(Console.ReadLine());
                              
                double SalarioComAumento = salarioBase + salarioBase * 15 / 100;


                double SalarioComImpostos = SalarioComAumento - SalarioComAumento * 8 / 100;

                Console.WriteLine("Salario Ininal: " + salarioBase + "R$\nSalario depois do aumento: "+ SalarioComAumento + "R$\nSalario depois dos impostos: "+SalarioComImpostos +"R$");

                Console.WriteLine("Sair S/N");
                resposta = Console.ReadLine();
    
               
            }
               Console.ReadLine();

        }
    }
}