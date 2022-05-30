namespace ConsoleEstudo.Model
{
    public class Carta
    {
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public int Velocidade { get; set; }
        public int Cilindrada { get; set; }
        public int Aceleracao { get; set; }
        public int Potencia { get; set; }
        public int Comprimento { get; set; }
        public int Peso { get; set; }

        public Carta() { }

        public Carta(string codigo, string nome, int velocidade, int cilindrada, int aceleracao, int potencia, int comprimento, int peso)
        {
            Nome = nome;
            Velocidade = velocidade;
            Cilindrada = cilindrada;
            Codigo = codigo;
            Aceleracao = aceleracao;
            Potencia = potencia;
            Comprimento = comprimento;
            Peso = peso;
        }

    }

}
