using System.Net;
using System.Timers;
using Timer = System.Timers.Timer;

int i;
int[] resultList = new int[5];
string menuSelection = "";
string readResult = "";
string finalResult = "";

while (menuSelection != "exit")
{
    Console.WriteLine("Selecione uma opção: ");
    Console.WriteLine("1 - Somar");
    Console.WriteLine("2 - Subtrair");
    Console.WriteLine("3 - Multiplicar");
    Console.WriteLine("4 - Dividir");
    Console.WriteLine("5 - Ver últimos resultados");
    Console.WriteLine("6 - Jogo aleatório");
    Console.WriteLine("7 - Sobre o jogo");
    Console.WriteLine("Sair");

    readResult = Console.ReadLine().ToLower();

    if (readResult != null)
    {
        menuSelection = readResult;
    }
    else
    {
        Console.WriteLine("Opção inválida");
        continue;
    }
    
    if (readResult == "sair")
    {
        Console.WriteLine("Fechando Math Game");
        break;
    }

    Random random = new Random(); 
    int num1 = random.Next(0, 100);
    int num2 = random.Next(0, 100);
    
    string userResponse;
    
    switch (menuSelection)
    {
                
        case "1":
            
            finalResult = Convert.ToString(num1 + num2);
            Console.WriteLine($"Qual o resultado da soma de {num1} + {num2}?");
            userResponse = Console.ReadLine();
            
            if (userResponse == finalResult)
            {
                Console.WriteLine($"Resposta correta: {finalResult}" );  
                for (i = 0; i < 5; i++)
                {
                    if (resultList[i] == 0)
                    {
                        resultList[i] = num1 + num2;
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Resposta incorreta");
            }
            break;
        
        case "2":
            
            finalResult = Convert.ToString(num1 - num2);
            Console.WriteLine($"Qual o resultado da subtração de {num1} - {num2}?");
            userResponse = Console.ReadLine();
                
            if (userResponse == finalResult)
            {
                Console.WriteLine($"Resposta correta: {finalResult}" );
                for (i = 0; i < 5; i++)
                {
                    if (resultList[i] == 0)
                    {
                        resultList[i] = num1 + num2;
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Resposta incorreta");
            }
            break;
        
        case "3":
            finalResult = Convert.ToString(num1 * num2);
            Console.WriteLine($"Qual o resultado da multiplicação de {num1} x {num2}?");
            userResponse = Console.ReadLine();
            
            if (userResponse == finalResult)
            {
                Console.WriteLine($"Resposta correta: {finalResult}" );
                for (i = 0; i < 5; i++)
                {
                    if (resultList[i] == 0)
                    {
                        resultList[i] = num1 + num2;
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Resposta incorreta");
            }
            break;
        
        case "4":
            do
            {
                num1 = random.Next(0, 100);
                num2 = random.Next(1, 100);
                
            } while (num1 % num2 != 0 && num2 != 0);
            
            finalResult = Convert.ToString(num1 / num2);
            Console.WriteLine($"Qual o resultado da divisão de {num1} / {num2}?");
            userResponse = Console.ReadLine();
            
            if (userResponse == finalResult)
            {
                Console.WriteLine($"Resposta correta: {finalResult}" );
                for (i = 0; i < 5; i++)
                {
                    if (resultList[i] == 0)
                    {
                        resultList[i] = num1 + num2;
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Resposta incorreta");
            }
            break;
        
        case "5":
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine($"Resultado {i + 1}: {resultList[i]}");
            }
            break;
        
        case "6":
            
            Console.WriteLine("Em desenvolvimento");
            break;
            
        case "7":
            Console.WriteLine("O Math Game é um jogo de matemática simples, onde você escolhe uma operação matemática e o jogo gera dois números aleatórios para você resolver. O jogo armazena os últimos 5 resultados para você consultar.");
            break;  
        
        default:
            Console.WriteLine("Selecione uma opção válida");
            break;
        
    }
}    