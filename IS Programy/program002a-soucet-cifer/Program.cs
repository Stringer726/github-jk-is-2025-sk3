string again = "a";
while (again == "a")
{
  Console.Clear();
  Console.WriteLine("*****************************");
  Console.WriteLine("*** Součet a součin cifer ***");
  Console.WriteLine("*****************************");
  Console.WriteLine("******** Josef Kubrt ********");
  Console.WriteLine("******** 16.10.2025 *********");
  Console.WriteLine("*****************************");
  Console.WriteLine();

  //Vstup čiselné hodnoty do programu - špatně řešený princip
  //  Console.Write("Zadejte první číslo řady: ");
  //  int first = int.Parse(Console.ReadLine());



  //Vstup čiselné hodnoty do programu - lépe řešený princip
  Console.Write("Zadejte celé číslo: ");
  int number;
    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte ho znovu: ");



    }
    int suma = 0;
    int numberBackup = number;
    int digit;

    if (number < 0)
    {
        number = -number;
    }

    while (number >= 10)
    {
        digit = number % 10;
        number = (number - digit) / 10;
        Console.WriteLine("Zbytek = {0}", digit);
        suma = suma + digit;
    }

    Console.WriteLine("Poslední zbytek: {0}", number);

    suma = suma + number; //musíme přičíst poslední cifru

    Console.WriteLine();
    Console.WriteLine("Součet cifer čísla {0} je {1}", numberBackup, suma);





  

  Console.WriteLine();
    Console.WriteLine("Pro opakování programu stisknete klávesu a");
    again = Console.ReadLine();

    







}

