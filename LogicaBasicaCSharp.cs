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



// 7. ID de Itens Relacionados

Console.WriteLine($"ID anterior: {id - 1}"); 

Console.WriteLine($"ID sucessor: {id + 1}");



// 8. Alerta de HP Critico

if (hp < 20) Console.WriteLine("ALERTA: Vida Critica! Use uma pocao!"); 

else Console.WriteLine("HP Estavel");



// 9. Classificacao Etaria

if (idade >= 18) Console.WriteLine("Acesso Autorizado"); 

else Console.WriteLine("Acesso Nao Autorizado");



// 10. Confronto PvP

if (alpha > omega) Console.WriteLine("Time Alpha foi o vencedor!"); 

else if (omega > alpha) Console.WriteLine("Time Omega foi o vencedor!");

else Console.WriteLine("A partida terminou empatada!");



// 11. Sistema de Faccoes

if (id % 2 == 0) Console.WriteLine("Guilda: Magos do Alvorecer");

else Console.WriteLine("Guilda: Guerreiros da Noite");



// 12. Validacao de Cheat Code

Console.WriteLine("Trapaca Ativada: Modo Imortal Habilitado");

if (usuario == "godmode" && senha == "666")  

else Console.WriteLine("Codigo Invalido");



// 13. Peso do Inventario

if (peso <= 50.0) Console.WriteLine("O personagem consegue correr normalmente."); 

else Console.WriteLine("Sobrecarga de peso!");



// 14. Ranking por MMR

if (mmr < 1000) Console.WriteLine("Rank Bronze"); 

else if (mmr <= 2000) Console.WriteLine("Rank Prata"); 

else Console.WriteLine("Rank Ouro");



// 15. Spawner Sequencial de Inimigos

for (int i = 1; i <= 50; i++) { 
    
    Console.WriteLine($"Inimigo #{i} gerado"); 

}



// 16. Eventos de Rounds Pares

for (int i = 2; i <= 100; i += 2) { 
    
    Console.WriteLine($"Round par: {i}"); 

}



//17. Contagem Regressiva do Round

for (int i = 10; i >= 0; i--) {
    
    Console.WriteLine(i); 

} 

Console.WriteLine("FIGHT! COMECOU O ROUND!");



// 18. Farm Semanal Acumulado

int totalMoedas = 0; 

for (int dia = 1; dia <= 7; dia++) { 
    
    int moedas = int.Parse(Console.ReadLine()); totalMoedas += moedas;

}



// 19. Multiplicador de Combo

for (int combo = 1; combo <= 10; combo++) { 
    
    Console.WriteLine($"{combo}x combo = {danoBase * combo} de dano");

}




// 20. Quebrador de Baus

do { palavra = Console.ReadLine(); 
    
    if (palavra != "ABRACADABRA") Console.WriteLine("Senha incorreta. Tente novamente."); } 

while (palavra != "ABRACADABRA");



// 21. Dungeon Customizavel

int salas = int.Parse(Console.ReadLine()); 

double somaDificuldade = 0; 

for (int i = 1; i <= salas; i++) { 
    
    double dificuldade = double.Parse(Console.ReadLine()); somaDificuldade += dificuldade;

} double mediaDificuldade = somaDificuldade / salas;



// 22. Simulador de Drop Rate

int lootComum = 0; 
int lootRaro = 0; 

for (int i = 1; i <= 10; i++) { 
    
    int raridade = int.Parse(Console.ReadLine()); 
    
    if (raridade < 50) lootComum++;
    
    else lootRaro++; 

}


// 23. Recorde Absoluto de Pontos

int pontuacao; 
int maiorPontuacao = 0; 
do {
    
    pontuacao = int.Parse(Console.ReadLine()); 
    
    if (pontuacao > maiorPontuacao) maiorPontuacao = pontuacao;
}

while (pontuacao != 0);


// 24. Gasto e Esvaziamento de Mana

int mana = 1000;

while (mana > 0) {
    
    int gasto = int.Parse(Console.ReadLine());
    
    mana -= gasto; if (mana > 0) Console.WriteLine($"Mana restante: {mana}");
} 

Console.WriteLine("Mana Esgotada! Recarregue.");


// 25. Painel MVP

int totalKills = 0;
int maiorKills = -1;
string mvp = ""; 

for (int i = 1; i <= 5; i++) { 
    
    string nome = Console.ReadLine();
    int kills = int.Parse(Console.ReadLine()); 
    
    totalKills += kills; 
    
    if (kills > maiorKills) {
        
        maiorKills = kills; mvp = nome; } 

}