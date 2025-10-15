string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("******************************");
    Console.WriteLine("***** Výpis číselné řady *****");
    Console.WriteLine("******************************");
    Console.WriteLine("******** Josef Kubrt ********");
    Console.WriteLine("********* 2.10.2025 **********");
    Console.WriteLine("******************************");
    Console.WriteLine();

    //Vstup čiselné hodnoty do programu - špatně řešený princip
    //  Console.Write("Zadejte první číslo řady: ");
    //  int first = int.Parse(Console.ReadLine());



  //Vstup čiselné hodnoty do programu - lépe řešený princip
    Console.Write("Zadejte první číslo řady (celé číslo): ");
    int first;
    while (!int.TryParse(Console.ReadLine(), out first))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte první číslo řady znovu:");
    


}





    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stisknete klávesu a");
    again = Console.ReadLine();

    










}

