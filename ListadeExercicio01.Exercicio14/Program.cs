using System.Runtime.Intrinsics.X86;

namespace ListadeExercicio01.Exercicio14
{
    internal class Program
    {
        //Escreva um algoritmo para ler o nome e a idade de uma pessoa, e exibir quantos dias de vida ela possui.
        //Considere sempre anos completos, e que um ano possui 365 dias.Ex: uma pessoa com 19 anos possui 6935 dias
        //de vida; veja um exemplo de saída: MARIA, VOCÊ JÁ VIVEU 6935 DIAS.
        static void Main(string[] args)
        {
            const string sair = "S";
            string resposta = "";
            //test


            Console.WriteLine("Calculdadora de volume de um cilindro\n------------------");
            while (resposta.ToUpper() != sair)
            {
                Console.WriteLine("Nome: ");
                string Nome = Console.ReadLine();
                Console.WriteLine("Idade: ");
                int Idade = Convert.ToInt32(Console.ReadLine());

                int diasvividos = Idade * 365;
                Console.WriteLine(Nome+ ", Você viveu "+ diasvividos+" dias");



                Console.WriteLine("Sair S/N");
                resposta = Console.ReadLine();


            }

            Console.ReadLine();
        }
        
    }
}