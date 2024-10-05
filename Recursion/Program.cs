using Recursion.Models;


Factorial factorial = new Factorial();

Console.WriteLine("Enter a number to calculte the factorial:");

string input = Console.ReadLine();
int number;

// 1. int.TryParse(input, out number)
        // Objetivo: Verificar se a string input (o que o usuário digitou) pode ser convertida para um número inteiro.
        // Explicação detalhada:
        // TryParse: O método int.TryParse() tenta converter a string fornecida (input) para um número inteiro.
        // - Se a conversão for bem-sucedida, ele retorna true e armazena o valor convertido na variável number.
        // - Se a conversão falhar (por exemplo, se o usuário digitou "abc" ou algo que não seja um número), ele retorna false 
        //   e a variável number não recebe um valor válido.
        // out number: A palavra-chave out é usada para indicar que a variável number será preenchida dentro do método TryParse.
        // - Se a conversão for bem-sucedida, o valor de input será armazenado em number.


if(int.TryParse(input, out number) && number >=0)
{
    int result = factorial.CalculateFactorial(number);

    Console.WriteLine($"The factorial of {number} is {result}");
}
else
{
    Console.WriteLine("Please enter a valid integer greater than or equal to zero. ");
}
