using System.Runtime.InteropServices.Marshalling;

string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("******************************");
    Console.WriteLine("**** Seřazení Tří Čísel ******");
    Console.WriteLine("******************************");
    Console.WriteLine("******** Josef Kubrt *********");
    Console.WriteLine("********* 23.10.2025 *********");
    Console.WriteLine("******************************");
    Console.WriteLine();

    //Vstup čiselné hodnoty do programu - špatně řešený princip
    //  Console.Write("Zadejte první číslo řady: ");
    //  int first = int.Parse(Console.ReadLine());



  //Vstup čiselné hodnoty do programu - lépe řešený princip
    Console.Write("Zadejte Celé číslo A: ");
    int a;
    while (!int.TryParse(Console.ReadLine(), out a))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte celé číslo A znovu:");



    }
 Console.Write("Zadejte Celé číslo B: ");
    int b;
    while (!int.TryParse(Console.ReadLine(), out b))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte celé číslo B znovu:");



    }
    Console.Write("Zadejte Celé číslo C: ");
    int c;
    while (!int.TryParse(Console.ReadLine(), out c))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte celé číslo C znovu:");



    }


    Console.WriteLine();
    Console.WriteLine("=============================================");
    if (a > b)

    {
        if (a > c)
            Console.WriteLine($"Největší je číslo A = {a}");
        else
            Console.WriteLine($"Největší je číslo C = {c}");

    }
    else
    {
        if (b > c)
            Console.WriteLine($"Největší je číslo B = {b}");
        else
            Console.WriteLine($"Největší je číslo C = {c}");
    }
    Console.WriteLine("=============================================");

    

    Console.WriteLine("=============================================");
    Console.WriteLine($"Seřezená čísla: {a}, {b}, {c}");
    Console.WriteLine("=============================================");





    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stisknete klávesu a");
    again = Console.ReadLine();

    










}

