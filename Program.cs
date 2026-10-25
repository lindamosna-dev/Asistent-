void VykonajSum()
{
    Console.WriteLine("rozumiem, vykonam scitanie");
    Console.WriteLine("napis prve cislo:");
    
    int vstup1 = int.Parse(Console.ReadLine());

    Console.WriteLine("napis druhe cislo:");
    int vstup2 = int.Parse(Console.ReadLine());

    int scitavanie = vstup1 + vstup2;

    Console.WriteLine(vstup1 + "+" + vstup2 + "=" + scitavanie);
    
}

void VykonajOdm()
{
    Console.WriteLine("rozumiem, vypisem odmocninu");
    Console.WriteLine("napis prve cislo:");
    
    int vstup1 = int.Parse(Console.ReadLine());
    
    double odmocnina = Math.Sqrt(vstup1);
   
    Console.WriteLine("odmocnina z " + vstup1 + " je " + odmocnina);
}


void VykonajHelp()
{
    Console.WriteLine("povolene prikazy " +
                      "\n sum - scitanie " +
                      "\n odm - odmocnina " +
                      "\n find - najdi podretazec vo vete " +
                      "\n help - vypise vsetky podporovane prikazy, a povie co robia " +
                      "\n exit - ukonci cely program" +
                      "\n area - vypocita obsah obdlznika" +
                      "\n perimeter - vypocita obvod obdlznika" +
                      "\n diagonal - vypocita uhlopriecku obdlznika");
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
    double strana1 = int.Parse(Console.ReadLine());

    Console.WriteLine("zadaj cislo druhej strany:");
    double strana2 = int.Parse(Console.ReadLine());

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
        else
            Console.WriteLine("nespravny prikaz pre obdlznik");
        
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

/*
void VykonajArray()
{
    Console.WriteLine("zadaj cisla do array: ");
    double strana1 = int.Parse(Console.ReadLine());

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
        else
            Console.WriteLine("nespravny prikaz pre obdlznik");
        
        input = Console.ReadLine();
        input = input.ToLower();
    }
}
*/

Console.WriteLine(" ahoj, som tvoj asistent a aky prikaz chces spravit?");
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
        VykonajRect();
    else
        Console.WriteLine("nespravny prikaz");
    
    input = Console.ReadLine();
    input = input.ToLower();
}