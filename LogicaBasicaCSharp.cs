// 1. Boas-vindas ao RPG


Console.Write("Digite o nome do seu personagem: ");
string nome = Console.ReadLine();

Console.WriteLine($"Olá {nome}, sua jornada de 100 horas no mundo de C# começou. Boa sorte!");




// 2. Pontuação Acumulada


Console.WriteLine("Insira a pontuação da primeira missão: ");
int point1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Insira a pontuação da segunda missão: ");
int point2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("A pontuação total é: " +  (point1 + point2));




// 3. Loja de Poções (Merchant)


int quantidade;
double preco;
double total;

Console.WriteLine("Digite o preço de uma poção (em moedas de ouro) : ");
preco = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite a quantidade de poções que deseja comprar: ");
quantidade = Convert.ToInt32(Console.ReadLine());

total = preco * quantidade;

Console.WriteLine($"O total a pagar é: {total} moedas de ouro");




// 4. Conversor de Coordenadas (Meters to Pixels)


 double metros;
 double pixels;

 Console.Write("Digite a posição em metros: ");
 metros = Convert.ToDouble(Console.ReadLine());

 pixels = metros * 64;

 Console.WriteLine($"A posição convertida em pixels é: {pixels} px.");




// 5. Média de XP (Matchmaking)

double xp1, xp2, xp3, media;

Console.WriteLine("Digite o XP da 1° partida: ");
xp1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite o XP da 2° partida: ");
xp2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite o XP da 3° partida: ");
xp3 = Convert.ToDouble(Console.ReadLine());

media = (xp1 + xp2 + xp3) / 3;

Console.WriteLine($"A média de XP do jogador é: {media}");



// 6. Termômetro de Survival Game

double celsius, temp;


Console.WriteLine("Informe a temperatura em graus Celsius: ");
celsius  = Convert.ToDouble(Console.ReadLine());
temp = (celsius * 1.8) + 32;

    Console.WriteLine($"A temperatuta informada, convertida para Fahrenheit é: {temp}");