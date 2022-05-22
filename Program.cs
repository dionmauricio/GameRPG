System.Console.WriteLine("Jogo de RPG simples");
System.Console.WriteLine("Aplicação pratica de uso do DO-WHILE");
System.Console.WriteLine();

// Personagens e potuações.
int jogadorUm = 100;
int jogadorDois = 100;

var gerarAtaque = new Random();

do
{
    int ataque = gerarAtaque.Next(1, 11);
    jogadorDois -= ataque;
    System.Console.WriteLine($"O 'jogadorDois' foi danificado e perdeu {ataque} pontos de vida. Sua vida restaante é de {jogadorDois} pontos");
    System.Console.WriteLine();

    if (jogadorDois <= 0) 
        continue;

    ataque = gerarAtaque.Next(1, 11);
    jogadorUm -= ataque;
    System.Console.WriteLine($"O 'jogadorUm' foi danificado e perdeu {ataque} pontos de vida. Sua vida restaante é de {jogadorUm} pontos");
    System.Console.WriteLine();
} while (jogadorUm > 0 && jogadorDois > 0);

System.Console.WriteLine(jogadorUm > jogadorDois ? "O jogadorUm venceu!" : "O jogadorDois venceu!");
System.Console.WriteLine("Precione <Enter> para sair");
System.Console.ReadLine();