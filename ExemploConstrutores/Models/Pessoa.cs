namespace ExemploConstrutores.Models
{
    public class Pessoa
    {
        private readonly string nome;
        private readonly string sobrenome;

        public Pessoa()// Construtor sem parâmetro pré definido;
        {
            nome = string.Empty;
            sobrenome = string.Empty;
        }

        public Pessoa(string nome, string sobrenome)// Construtor com parâmetros pré definidos;
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            Console.WriteLine("Construtor classe pessoa!");
        }

        public void Apresentar()
        {
            global::System.Console.WriteLine($"Olá, meu nome é: {nome} { sobrenome}");
        }
    }

}


