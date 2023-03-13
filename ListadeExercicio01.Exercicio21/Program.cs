namespace ListadeExercicio01.Exercicio21
{

    internal class Program
    {
        /*Faça um algoritmo que leia dois valores inteiros A e B, se os valores forem iguais deverá se somar os dois, caso
        contrário multiplique A por B.
        22. Ao final de qualquer um dos cálculos deve-se atribuir o resultado para uma variável C e mostrar seu conteúdo
        na tela.*/
        static void Main(string[] args)
        {
            const string sair = "S";
            string resposta = "";
            string historico = "";
            double resultado = 0;
            double C = 0; ;
            //test


            List<double> Historico = new List<double>();
            Console.WriteLine("Calculdadora de volume de um cilindro\n------------------");
            while (resposta.ToUpper() != sair)
            {
                Console.WriteLine("Valor A: ");
                double nm1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Valor B: ");
                double nm2 = Convert.ToDouble(Console.ReadLine());

                

                if (nm1 == nm2)
                {
                    C = nm1 + nm2;
                    Console.WriteLine("C = "+ C);
                    Historico.Add(C);
                }
                else
                {
                    C = nm1 * nm2;
                    Console.WriteLine("C = " + C);
                    Historico.Add(C);
                }


                Console.WriteLine("Sair S/N");
                resposta = Console.ReadLine();


            }

            Console.WriteLine("Histórico: ");
            foreach (var item in Historico)
            {

                Console.WriteLine("C = "+item);


            }

            Console.ReadLine();
        }
        
    }
}