void vykonajScitanie()
{
    Console.WriteLine("rozumiem, vykonam scitanie");
    Console.WriteLine("napis prve cislo:");
    
    int vstup1 = int.Parse(Console.ReadLine());

    Console.WriteLine("napis druhe cislo:");
    int vstup2 = int.Parse(Console.ReadLine());

    int scitavanie = vstup1 + vstup2;

    Console.WriteLine(vstup1 + "+" + vstup2 + "=" + scitavanie);
    
}

void vykonajOdmocninu()
{
    Console.WriteLine("rozumiem, vypisem odmocninu");
    Console.WriteLine("napis prve cislo:");
    
    int vstup1 = int.Parse(Console.ReadLine());
    
    double odmocnina = Math.Sqrt(vstup1);
   
    Console.WriteLine("odmocnina z " + vstup1 + "je " + odmocnina);
}


void vykonajHelp()
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


void vykonajFind()
{
    Console.WriteLine("zadaj vetu:");
    string veta = Console.ReadLine();
    veta = veta.ToLower();
    
    Console.WriteLine("co chces najst vo vete?");
    string castVety = Console.ReadLine();
    castVety = castVety.ToLower();

    int index = castVety.IndexOf(castVety);
    
}

void VykonajRect()
{
    Console.WriteLine("podme si odmerat obdlznik ");
    Console.WriteLine("zadaj cislo prvej strany:");
    double strana1 = int.Parse(Console.ReadLine());
    
    Console.WriteLine("zadaj cislo druhej strany:");
    double strana2 = int.Parse(Console.ReadLine());

    if (strana1 < strana2 || strana2 < strana1)
        return true;
    
    Console.WriteLine("mame obdlznik so stranami " + strana1 + "a " + strana2 + ", co chces odmerat?");
    Console.ReadLine();

}

void VykonajObsah()
{
    Console.WriteLine("vykonam vypocet obsahu obdlznika");
    double vysledokObsahu = strana1 * strana2
    Console.WriteLine("vysledok obsahu je " + vysledokObsahu);
    Console.ReadLine();
}

void VykonajObvod()
{ 
    Console.WriteLine("vykonam vypocet obvodu obdlzika");
    double vysledokObvodu = 2 * strana1 + 2 strana2
    Console.WriteLine("vysledok obvodu je "+ vysledok );
    Console.ReadLine();
}

void VykonajUhlopriecku()
{
    
}


Console.WriteLine(" ahoj, som tvoj asistent a aky prikaz chces spravit?");

string input = Console.ReadLine();
input = input.ToLower();

while (input != "sum" && input != "odm" && input != "help" && input != "find")
{
    Console.WriteLine("nespravny prikaz");
    input = Console.ReadLine();
}


while (input != "exit")
{
    if (input == "sum")
        vykonajScitanie();
    if (input == "odm")
        vykonajOdmocninu();
        if (input == "help")
            vykonajHelp();
        if (input == "find")
            vykonajFind();
    
}



