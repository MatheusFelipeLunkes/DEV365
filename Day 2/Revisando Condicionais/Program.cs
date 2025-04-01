//Day 2 - Revisando condicionais IF, ELSE IF, ELSE e SWITCH CASE

// Basicamente as condicionais IF, ELSE IF e ELSE nos ajudam a manter o fluxo da nossa aplicação, em outras palavras 
// quando precisamos checar dados ou até mesmo fazer validações usamos os operadores IF, ELSE IF ou else. 

// Existem também dois operadores logicos o AND (&&) e o OR (||).
// Basicamente o operador AND precisa que as duas operações retornem verdadeiro para que se considere verdadeira a validação
// Já o operador OR não nescessita de ambos e sim de apenas UMA operação verdadeira para que se considere verdadeira a validação

// EXEMPLO: 
// Vamos supor que o nosso sistema tenha um usuario e que ele queira fazer login no mesmo:

string userName = "MatheusLunkes";
string userPassword = "123456";

// Em outras palavras usamos IF e ELSE para checagem de condicionais e dentro delas podemos fazer varios tipos de operações logicas
if(userName == "MatheusLunkes" && userPassword == "123456")
{
    Console.WriteLine("Sucess");
}else
{
    Console.WriteLine("Fail");
}

// Além de podermos fazer mais de uma checagem de operação logica em um unico IF, podemos aninhar mais de um if dentro de outro.
// EXEMPLO:
int idade = 15;

if(idade <= 17)
{
    if(idade >= 12) 
    {
        Console.WriteLine("Está na adolescencia");
    }else
    {
        Console.WriteLine("É uma criança");
    }
        Console.WriteLine("Menor de idade");
}else if(idade > 17 && idade <= 50)
{
    Console.WriteLine("Idade entre 18 e 50");
}else
{
    Console.WriteLine("Idade Acima de 50");
}

// O switch também é uma forma de fazermos validações ou checagens, mas é usados para casos um pouco mais especificos
// EXEMPLO:

int mes = 91;

switch(mes)
{
    case 1:
        Console.WriteLine("Janeiro");
        break;
    case 2:
        Console.WriteLine("Fevereiro");
        break;
    case 3:
        Console.WriteLine("Março");
        break;
    case 4:
        Console.WriteLine("Abril");
        break;
    case 5:
        Console.WriteLine("Maio");
        break;
    case 6:
        Console.WriteLine("Junho");
        break;
    case 7:
        Console.WriteLine("Julho");
        break;
    case 8:
        Console.WriteLine("Agosto");
        break;
    case 9:
        Console.WriteLine("Setembro");
        break;
    case 10:
        Console.WriteLine("Outubro");
        break;
    case 11:
        Console.WriteLine("Novembro");
        break;
    case 12:
        Console.WriteLine("Dezembro");
        break;
    default:
        Console.WriteLine("Mes invalido");
        break;

}