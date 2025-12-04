﻿string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("**********************************************");
    Console.WriteLine("************* Konvergentní řady  *************");
    Console.WriteLine("**********************************************");
    Console.WriteLine("**************** Josef Kubrt *****************");
    Console.WriteLine("**************** 4.12.2025 ******************");
    Console.WriteLine("**********************************************");
    Console.WriteLine();

    // Vstup hodnoty do programu
    Console.Write("Zadejte první číslo řady (celé číslo): ");
    int first;
    while (!int.TryParse(Console.ReadLine(), out first))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte první číslo řady znovu: ");
    }










    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();



}