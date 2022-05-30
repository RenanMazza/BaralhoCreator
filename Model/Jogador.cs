namespace ConsoleEstudo.Model
{
    public class Jogador
    {
        public string Nome { get; set; }
        
        public List<Carta> ListaCartas  { get; set; }

        public int Idade {get;set;}

        public int QuantidadeVitorias {get;set;}
        
    }
}