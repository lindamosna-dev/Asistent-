Console.WriteLine("ahoj, som tvoj asistent a poviem ti co dokazem");
Console.WriteLine("povolene prikazy \n sum - scitanie \n odm - odmocnina \n find - najdi podretazec vo vete \n help - vypise vsetky podporovane prikazy, a povie co robia \n exit - ukonci cely program");


Console.WriteLine("aky prikaz chces spravit");


Console.WriteLine("napis prve cislo:");
string vstup1 = Console.ReadLine();  

Console.WriteLine("napis druhe cislo:");
string vstup2 = Console.ReadLine();

int a = int.Parse(vstup1);
int b = int.Parse(vstup2);

int Scitavanie(int scitanec1, int scitanec2)
{
    int vysledok = 0;
    vysledok = scitanec1 + scitanec2;
    return vysledok;
}

Console.WriteLine(Scitavanie(a, b));

