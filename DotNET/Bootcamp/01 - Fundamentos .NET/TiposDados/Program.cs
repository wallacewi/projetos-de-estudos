// Tipo de dado: String e Char
string primeiroNome = "Wallace";
string segundoNome = "Wictchen";
string bio = "Desenvolvedor .NET";
string nacionalidade = "Brasil";
char genero = 'M';

// Tipo de dado: Numéricos
byte experiencia = 5;
int idade = 23;
decimal salario = 3253.78M;

// Tipo de dado: DateTime
DateTime nascimento = new DateTime(1999, 11, 17);

// Escrevendo as variáveis no console
Console.WriteLine(
    "+--------------------------------------+\n"
    + $"| {primeiroNome + " " + segundoNome,-36} |\n"
    + "+--------------------------------------+\n"
    + $"| {bio,36} |\n"
    + $"| Gênero: {genero,-28} |\n"
    + $"| Nacionalidade: {nacionalidade,-21} |\n"
    + $"| Nascimento: {nascimento.ToShortDateString() + $" ({idade} anos)",-24} |\n"
    + "+--------------------------------------+\n"
    + $"| Experiência: {experiencia + " anos",-23} |\n"
    + $"| Salário: {salario,-27:C} |\n"
    + "+--------------------------------------+"
);
