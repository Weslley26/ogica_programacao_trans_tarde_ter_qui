//ex.05 - Solicitar dois numro e apresentar a soma 

using System;

Console.WriteLine("Digite o 1 número; ");
int num1 = int.Parse(Console.ReadLine());


Console.WriteLine("Digite o 2 número; ");
int num2 = int.Parse(Console.ReadLine());


Console.Clear();

Console.WriteLine("+ ; " + (num1 + num2));
Console.WriteLine("+ ; " + (num1 - num2));
Console.WriteLine("+ ; " + (num1 * num2));

if (num2 != 0)
{
    Console.WriteLine("/ : " + (num1 / num2));
}
else
{
    Console.WriteLine(" / : Divisao por zero não é permitida");
}

 

Console.WriteLine("=====================");
Console.WriteLine("os número são iguais? " + (num1 == num2));
Console.WriteLine(" número 1 é maior numero 2? " + (num1 > num2));
Console.WriteLine(" número 1 é menor numero 2? " + (num1 < num2));
Console.WriteLine(" número 1 é maior igual numero 2? " + (num1 >= num2));
Console.WriteLine(" número 1 é menor igual numero 2? " + (num1 <= num2));


