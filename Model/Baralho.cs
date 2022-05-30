namespace ConsoleEstudo.Model
{
    public class Baralho
    {
        public List<Carta> Cartas { get; set; }
        public Baralho()
        {
            Cartas = new List<Carta>();

            Carta foxSportline = new Carta();
            foxSportline.Nome = "Fox Sportline";
            foxSportline.Velocidade = 186;
            foxSportline.Cilindrada = 1599;
            foxSportline.Codigo = "3A";
            foxSportline.Aceleracao = 11;
            foxSportline.Potencia = 101;
            foxSportline.Comprimento = 3804;
            foxSportline.Peso = 1040;

            Cartas.Add(foxSportline);

            Cartas.Add(new Carta("3B", "Golf GTI1", 227, 1781, 8, 180, 4147, 1251));
            Cartas.Add(new Carta("3B", "Golf GTI2", 130, 1782, 12, 180, 4147, 1251));
            Cartas.Add(new Carta("3B", "Golf GTI3", 228, 1783, 15, 180, 4147, 1251));
            Cartas.Add(new Carta("3B", "Golf GTI4", 150, 1784, 10, 180, 4147, 1251));
            Cartas.Add(new Carta("3B", "Golf GTI5", 241, 1785, 6, 180, 4147, 1251));
            Cartas.Add(new Carta("3B", "Golf GTI6", 289, 1786, 4, 180, 4147, 1251));
            Cartas.Add(new Carta("3B", "Golf GTI7", 110, 1787, 3, 180, 4147, 1251));
            Cartas.Add(new Carta("3B", "Golf GTI8", 120, 1788, 1, 180, 4147, 1251));

        }

    }

}
