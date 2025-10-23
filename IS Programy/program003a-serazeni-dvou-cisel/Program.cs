using System.Runtime.InteropServices.Marshalling;

string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("******************************");
    Console.WriteLine("**** Seřazení Dvou Čísel ******");
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


    Console.WriteLine();
    int pom;
    if (a > b)
    {
        pom = a;
        a = b;
        b = pom;
        Console.WriteLine("Došlo k prohození proměných...");

    }

    Console.WriteLine("=============================================");
    Console.WriteLine($"Seřezená čísla: {a}, {b}");
    Console.WriteLine("=============================================");





    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stisknete klávesu a");
    again = Console.ReadLine();

    










}

