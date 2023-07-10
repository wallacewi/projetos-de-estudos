namespace Sintaxe.Models; // representa um caminho lógico

public class Pessoa
{
    // Propriedades
    public string? Nome { get; set; }
    public int Idade { get; set; }

    // Métodos
    public void Apresentar()
    {
        Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos.");
    }
}
