string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("**********************************************************");
    Console.WriteLine("************* Převod z 10 do 2 soustavy *************");
    Console.WriteLine("**********************************************");
    Console.WriteLine("**************** Josef Kubrt *****************");
    Console.WriteLine("**************** 27.11.2025 ******************");
    Console.WriteLine("**********************************************");
    Console.WriteLine();

    
    //Vstup čiselné hodnoty do programu - špatně řešený princip
    //  Console.Write("Zadejte první číslo řady: ");
    //  int first = int.Parse(Console.ReadLine());



  //Vstup čiselné hodnoty do programu - lépe řešený princip
    Console.Write("Zadejte přirozené číslo: ");
    uint number10;
    while (!uint.TryParse(Console.ReadLine(), out number10))
    {
        Console.Write("Nezadali jste přirozené. Zadejte přirozené číslo v desítkové soustavě znovu: ");
    
}
uint [] myArray = new uint[32];
uint backupNumber10 = number10;
uint zbytek;

uint i;
for(i=0; number10 > 0 ;i++){
     zbytek = number10 % 2;
     number10 = (number10 - zbytek)/2;
     myArray[i] = zbytek;

    
     Console.WriteLine("Celá část = {0}; zbytek = {1}", number10, zbytek);
        
    }
//zpětný výpis pole
    Console.Write("Desítkové číslo {0} ve dvojkové soustavě = ", backupNumber10);
    for(uint j = i - 1; j >= 0; j--){
        Console.Write("{0}", myArray[j]);
    }





    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stisknete klávesu a");
    again = Console.ReadLine();
}
