// Day 1 Revisão sobre variaveis e seus tipos:

// O C# por ser uma linguagem de tipagem forte ele requer que todas as
// variaveis declaradas devem conter um tipo de dado especifico, ou seja?

// Toda variavel quando declarada deve-se especificar o
// tipo de dado que ela receberá.

int number = 10; // Variavel declarada com o tipo INT que indica que receberá um numero inteiro até 4 bytes ou (32bits)

float PI = 3.14f; // Variavel declara com o tipo FLOAT que indica que receberá um numero com ponto flutuante até 4 bytes ou (32bits),
                  // a unica diferença ao declarar um numero float precisa-se usar o sufixo 'f' no final para que a variavel seja atribuida como Float caso o contrario o compilador assume que a variavel é um double.

double CEP = 95750000d; // Variavel declarada com o tipo DOUBLE que indica que receberá um numero com ponto flutuante até 8 bytes ou (64bits).

string nameCountry = "Brasil"; // Variavel declarada com o tipo STRING que indica que pode receber um ou mais caracteres,
                            // mas diferentes de inteiros a Engine do C# trata de modo diferente as strings.

char sex = 'F'; //Variavel declarada do tipo CHAR que indica que pode conter somente um caractere, diferente da string a variavel CHAR pode apenas receber um unico caractere.

// Basicamente as strings são variaveis do tipo de REFERENCIA oque quer dizer que seu valor real é aramazenado na memoria heap,
// enquanto a variavel em si só contem o endereço do local armazenado.

bool validation = true; // Variavel declarada com o tipo bool que indica que só podem conter dois valores possiveis (True or False),
                       // variaveis boleanas são usadas basicamente na hora de fazermos uma checagem ou operações logicas de fluxo de programa.

//Basicamente podemos trabalhar com as variaveis de diferentes formas como reatribuir seus valores, incrementar ou decrementar, calculos, concatenações e etc.
//EXEMPLOS:


nameCountry = "Estados Unidos"; //Reatribuição, mas basicamente o sistema não reescreveu por cima do que estava escrito e sim criou um novo espaço na memoria
                             //e fez com que a variavel apontasse para o novo endereço fazendo com que o GC (Garbage Collector) limpasse a variavel antiga da memoria caso não exista nenhuma outra referencia apontada para ela.
number++; //Incremento
number--; //Decremento

int x = 5;
int y = 10;

int result = x * y; //Podemos fazer operações matematicas e guarda-las em novas variaveis sem perder o valor original das variaveis x e y.


string firstName = "Matheus";
string lastName = "Lunkes";
string fullName = firstName + " " + lastName; // Em strings operadores como o da Adição (+) servem para concatenar strings, podendo criar novas possubilidades para resolução dos problemas.














