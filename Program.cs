
Console.Write("Qual o nome do herói? ");
		string nome = Console.ReadLine();

		Console.Write("Qual a idade do herói? ");
		int idade = int.Parse(Console.ReadLine());

		Console.Write("Qual o tipo do herói (guerreiro, mago, monge, ninja)? ");
		string tipo = Console.ReadLine().ToLower(); 

		
		var heroi = new Heroi<string>(nome, idade, tipo);

		
		heroi.Atacar();
