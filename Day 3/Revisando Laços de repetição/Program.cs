// DAY 3 - Revisando o conceito sobre laços de repetição FOR e WHILE 

// Basicamente laços de repetição são muito usados para reproduzir diversas ações no fluxo da nossa aplicação. 
// EXEMPLO:

// Digamos que eu tenha uma string e gostaria de saber quantas letras A possuem dentro da mesma. Como poderia fazer isso? 
// R: Simples criando um contador, que percora a string letra a letra checando se é a letra informada e se a condição for verdadeira adiciona mais um ao nosso contador.

string str = "AABBAABBAA";
int count = 0;

// Abaixo podemos ver um laço FOR tradicional que recebe o tamanho de uma string como parametro para a checagem de loop.
for (int i = 0; i < str.Length; i++)
{
    if (str[i] == 'A' || str[i] == 'a')
    {
        count++;
    }
}

Console.WriteLine(count);

string str2 = "ABBCCEFFHHHIOTTTTTU";
int y = 0;
string vogals = "";
string consonants = "";

// Basicamente o laço WHILE é uma forma mais moderna de escrever laços
while (y < str2.Length)
{
    if (str2[y] == 'A' || str2[y] == 'E' || str2[y] == 'I' || str2[y] == 'O' || str2[y] == 'U')
    {
        vogals += str2[y];
    }else
    {
        consonants += str2[y];
    }
        y++;
}

Console.WriteLine(vogals);
Console.WriteLine(consonants);

// Resumindo laços de repetições podem ser abordados em diversas situações nas quais precisamos trabalhar em loop ou até na checagem de multiplos dados. 