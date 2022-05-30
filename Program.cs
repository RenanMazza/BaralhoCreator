using ConsoleEstudo.Model;

namespace ConsoleEstudo
{
    class Program
    {
        static void Main(string[] args)
        {
            var juliano = new Jogador();
            var baralho = new Baralho();

            var quantosCarrosAcima180 = 0;

            var qtoCarrosAbaixo10s = 0;

            var quntasCartaTemNoBaralho = baralho.Cartas.Count;

            var indiceCarro = 0;

            var decimoCarro = "";

            foreach (var carta in baralho.Cartas)
            {
                indiceCarro++;

                if (carta.Velocidade > 180)
                {
                    quantosCarrosAcima180 = quantosCarrosAcima180 + 1;
                }

                if (carta.Aceleracao < 10)
                {
                    qtoCarrosAbaixo10s++;
                }

                if (indiceCarro == 5)
                    decimoCarro = carta.Nome;



            }





            // for (int i = 0; i < baralho.Cartas.Count ; i++)
            // {
            //     var carta = baralho.Cartas[i];
            // }




            Console.WriteLine(quntasCartaTemNoBaralho);
            Console.WriteLine(quantosCarrosAcima180);
            Console.WriteLine(qtoCarrosAbaixo10s);
            Console.WriteLine(decimoCarro);
            Console.WriteLine(baralho.Cartas[4].Nome);
        }

    }
}