public class Heroi <T>
{
	public string Nome { get; set; }
	public int Idade { get; set; }
	public T Tipo { get; set; }
	
	public Heroi(string nome, int idade, T tipo) 
	{
		Nome = nome;
		Idade = idade;
		Tipo = tipo;
	}
	
	public void Atacar()
	{
		string ataque = DeterminarAtaque();
		Console.WriteLine($"{Tipo} atacou usando {ataque}!");
	}
	
	private string DeterminarAtaque()
    {
        if (Tipo.ToString().ToLower() == "mago")
        {
            return "magia";
        }
        else if (Tipo.ToString().ToLower() == "guerreiro")
        {
            return "espada";
        }
        else if (Tipo.ToString().ToLower() == "monge")
        {
            return "artes marciais";
        }
        else if (Tipo.ToString().ToLower() == "ninja")
        {
            return "shuriken";
        }
        else
        {
            return "ataque desconhecido";
        }
    }
}
