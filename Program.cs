﻿Console.WriteLine("A Tabuada");
int número, produto;
int multiplicador = 0;

Console.Write("Insira o número...: ");
número = Convert.ToInt32(Console.ReadLine()!);

while (multiplicador <= 10)
{
    produto = número*multiplicador;

    Console.WriteLine($"{número} x {multiplicador} = {produto}");
    multiplicador += 1;
}















/*Console.WriteLine7 x 0 = 0
7 x 1 = 7
7 x 2 = 14
7 x 3 = 21
7 x 4 = 28
7 x 5 = 35
7 x 6 = 42
7 x 7 = 49
7 x 8 = 56
7 x 9 = 63
7 x 10 = 70 */