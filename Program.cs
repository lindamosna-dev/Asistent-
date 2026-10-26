void VykonajSum()
{
    Console.WriteLine("rozumiem, vykonam scitanie");
    Console.WriteLine("napis prve cislo:");
    double vstup1;
	 if (!double.TryParse(Console.ReadLine(), out vstup1))
	 {
	 	 Console.WriteLine("zly vstup");
		 return;
	 }
    Console.WriteLine("napis druhe cislo:");
	 double vstup2;
	 if (!double.TryParse(Console.ReadLine(), out vstup2))
	 {
	 	 Console.WriteLine("zly vstup");
		 return;
	 }

    double scitavanie = vstup1 + vstup2;

    Console.WriteLine(vstup1 + " + " + vstup2 + " = " + scitavanie);
}

void VykonajOdm()
{
    Console.WriteLine("rozumiem, vypisem odmocninu");
    Console.WriteLine("napis cislo:");
	 double vstup;
	 if (!double.TryParse(Console.ReadLine(), out vstup))
	 {
	 	 Console.WriteLine("zly vstup");
		 return;
	 } 

	 if (vstup < 0)
	 {
	 	  Console.WriteLine("odmocnina zo zaporneho cisla neexistuje");
		  return;
	 }
    
    double odmocnina = Math.Sqrt(vstup);
   
    Console.WriteLine("odmocnina z " + vstup + " je " + odmocnina);
}


void VykonajHelp()
{
    Console.WriteLine("povolene prikazy " +
                      "\n sum - scitanie " +
                      "\n odm - odmocnina " +
                      "\n find - najde podretazec vo vete " +
                      "\n help - vypise vsetky podporovane prikazy, a povie co robia " +
                      "\n exit - ukonci cely program" +
							 "\n rect - spusti mod pre ratanie obldznika" +
                      "\n  area - vypocita obsah obdlznika" +
                      "\n  perimeter - vypocita obvod obdlznika" +
                      "\n  diagonal - vypocita uhlopriecku obdlznika" +
							 "\n array - spusti mod pre pole" +
							 "\n  find - vypise na akej pozicii sa nachadza cislo" +
							 "\n  min - najde najmensie cislo" +
							 "\n  sort - zoradi pole od najmensieho cisla");
}


void VykonajFind()
{
    Console.WriteLine("zadaj vetu:");
    string veta = Console.ReadLine();
    veta = veta.ToLower();
    
    Console.WriteLine("co chces najst vo vete?");
    string castVety = Console.ReadLine();
    castVety = castVety.ToLower();

    int index = veta.IndexOf(castVety);
    
    Console.WriteLine("cast vety sa nachadza na indexe: " + index);
}

void VykonajRect()
{
    Console.WriteLine("podme si odmerat obdlznik :)");
    Console.WriteLine("zadaj cislo prvej strany:");
	 double strana1;
	 if (!double.TryParse(Console.ReadLine(), out strana1))
	 {
	 	 Console.WriteLine("zly vstup");
		 return;
	 }

    Console.WriteLine("zadaj cislo druhej strany:");
	 double strana2;
	 if (!double.TryParse(Console.ReadLine(), out strana2))
	 {
	 	 Console.WriteLine("zly vstup");
		 return;
	 }

    if (strana1 == strana2 || strana1 <= 0 || strana2 <= 0)
    {
        Console.WriteLine("nespravne hodnoty");
        return;
    }

    Console.WriteLine("mame obdlznik so stranami " + strana1 + " a " + strana2 + ", co chces odmerat?");
    string input = Console.ReadLine();
    input = input.ToLower();

    while (input != "exit")
    {
        if (input == "area")
            VykonajArea(strana1, strana2);
        else if (input == "perimeter")
            VykonajPerimeter(strana1, strana2);
        else if (input == "diagonal")
            VykonajDiagonal(strana1, strana2);
		  else if (input == "help")
		  		VykonajHelp();
        else
            Console.WriteLine("nespravny prikaz pre obdlznik");
       
		  Console.WriteLine("zadaj prikaz:");
        input = Console.ReadLine();
        input = input.ToLower();
    }
}

void VykonajArea(double strana1, double strana2)
{
    Console.WriteLine("vykonam vypocet obsahu obdlznika");
    double vysledokObsahu = strana1 * strana2;
    Console.WriteLine("vysledok obsahu je " + vysledokObsahu);
}

void VykonajPerimeter(double strana1, double strana2)
{ 
    Console.WriteLine("vykonam vypocet obvodu obdlzika");
    double vysledok = 2 * strana1 + 2 * strana2;
    Console.WriteLine("vysledok obvodu je "+ vysledok ); }

void VykonajDiagonal(double strana1, double strana2)
{
    Console.WriteLine("vykonam vypocet uhlopriecky obdlzika");
    double vysledok = Math.Sqrt(strana1 * strana1 + strana2 * strana2);
    Console.WriteLine("vysledok uhlopriecky je "+ vysledok ); 
}

void VykonajArray()
{
    Console.WriteLine("zadaj cisla do array: ");
	 string input = Console.ReadLine();
	 string[] arrayInput = input.Split(' ');

	 int[] array = new int[arrayInput.Length];
	 for (int i = 0; i < arrayInput.Length; i++)
	 {
		  if (!int.TryParse(arrayInput[i], out array[i]))
		  {
		  		Console.WriteLine("zly vstup");
				return;
		  }
	 }

    Console.WriteLine("co chces robit?");
    input = Console.ReadLine();
	 input = input.ToLower();

    while (input != "exit")
    {
        if (input == "find")
            VykonajArrayFind(array);
        else if (input == "min")
            VykonajMin(array);
        else if (input == "sort")
            VykonajSort(array);
		  else if (input == "help")
		  		VykonajHelp();
        else
            Console.WriteLine("nespravny prikaz pre array");

	  	  Console.WriteLine("zadaj prikaz:");
        input = Console.ReadLine();
        input = input.ToLower();
    }
}

void VykonajArrayFind(int[] array)
{
	 Console.WriteLine("ake cislo chces najst?");
	 int cislo;
	 if (!int.TryParse(Console.ReadLine(), out cislo))
	 {
		  Console.WriteLine("zly vstup");
		  return;
	 }

	 for (int i = 0; i < array.Length; i++)
	 {
	     if (array[i] == cislo)
		  {
		      Console.WriteLine("cislo " + array[i] + " je v poli na pozicii " + i);
		  }
	 }
}

void VykonajMin(int[] array)
{
   int min = array[0];
	for (int i = 0; i < array.Length; i++)
   {
		  if (array[i] < min)
		  	   min = array[i];
	}
   Console.WriteLine("najmensie cislo: " + min); 
}

void VykonajSort(int[] array)
{
	Array.Sort(array);
   Console.WriteLine("zoradene pole: " + string.Join(" ", array)); 
}

Console.WriteLine("ahoj, som tvoj asistent a aky prikaz chces spravit?");
string input = Console.ReadLine();
input = input.ToLower();

while (input != "exit")
{
    if (input == "sum")
        VykonajSum();
    else if (input == "odm")
        VykonajOdm();
    else if (input == "help")
        VykonajHelp();
    else if (input == "find")
        VykonajFind();
    else if (input == "rect")
	 {
        VykonajRect();
		  break;
	 }
	 else if (input == "array")
	 {
	 	  VykonajArray();
		  break;
	 }
    else
        Console.WriteLine("nespravny prikaz");
   	
	 Console.WriteLine("zadaj prikaz:");
    input = Console.ReadLine();
    input = input.ToLower();
}