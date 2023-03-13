namespace ListadeExercicio01.Exercicio18
{
    internal class Program
    {
        //Escreva um algoritmo que leia três valores inteiros e diferentes e mostre-os em ordem decrescente.
        static void Main(string[] args)
        {

            const string sair = "S";
            string resposta = "";
            string historico = "";
            double resultado = 0;



            SortedSet<int> Ordem = new SortedSet <int>();
            Console.WriteLine("Algoritmo que leia três valores inteiros e diferentes e mostre-os em ordem decrescente.\n------------------");
            while (resposta.ToUpper() != sair)
            {

                Console.WriteLine("Numero 1: ");
                int nm1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Numero 2: ");
                int nm2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Numero 3: ");
                int nm3 = Convert.ToInt32(Console.ReadLine());

                Ordem.Add(nm1);
                Ordem.Add(nm2);
                Ordem.Add(nm3);

                Console.WriteLine("Sair S/N");
                resposta = Console.ReadLine();


            }

            Console.WriteLine("Histórico: ");
            foreach (var item in Ordem.Reverse())
            {

                Console.WriteLine(item);


            }

            Console.ReadLine();
        }
    }
}