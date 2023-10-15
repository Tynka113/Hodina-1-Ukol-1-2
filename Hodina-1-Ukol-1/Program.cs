// Zadání úkol 1 + úkol 2:

static void Odradkuj()
{
    Console.WriteLine("");
}



// Vytvoř pole typu int s těmito hodnotami {3, -4, 0, 21, 3, 16, 7, 0, 1, 3, 4,-2}. Pro kontrolu si obsah pole vypiš.

int[] mojePole = { 3, -4, 0, 21, 3, 16, 7, 0, 1, 3, 4, -2 };
Console.WriteLine("Obsah pole:");

for (int i=0;i<mojePole.Length ;i++)
{
Console.WriteLine($"{i + 1}. číslo: "+ mojePole[i]);

}

// Vyhledej záporná čísla a změň je na kladné číslo, zároveň vyhledej nuly a ke každé přičti hodnotu jejího indexu. Výsledné pole si vypiš.
Odradkuj();
Console.WriteLine("Záporná čísla nahrazená kladnými a k nulám přičetná hodnota jejich indexů:");
for (int i = 0; i < mojePole.Length; i++)
{
    if (mojePole[i] < 0)
    {
            Random noveNahodneCislo = new Random();
            mojePole[i] = noveNahodneCislo.Next(0,100);      
    } 
    if (mojePole[i] == 0)
    {
        mojePole[i] = i;
    }
        Console.WriteLine($"{i + 1}. číslo: " + mojePole[i]);

}

// Vyhledej největší číslo v poli a vypiš ho.
Odradkuj();
Console.WriteLine("Největší číslo v poli je: ");
int poleMax = mojePole[0];
for (int i = 0; i < mojePole.Length; i++)
{
    if (poleMax < mojePole[i])
    {
        poleMax = mojePole[i];
    }
}
 Console.WriteLine(poleMax);


// Seřaď prvky v poli od nejmenšího po největší. Můžeš například využít toho, že už umíš najít největší číslo v poli. Prosím, nepoužívej už hotovou funkci na sortování, jde o to, aby sis takovou funkci zkusila napsat sama.
Odradkuj();
Console.WriteLine("Seřazeno: ");

int pomocna;

for (int i = 0; i < mojePole.Length - 1; i++)
{
    if (mojePole[i] > mojePole[i + 1])
    {
        pomocna = mojePole[i];
        mojePole[i] = mojePole[i + 1];
        mojePole[i + 1] = pomocna;
        i = -1;
    }

}

for (int i = 0; i < mojePole.Length; i++)
{
    Console.WriteLine($"{i + 1}. číslo: " + mojePole[i]);

}
Odradkuj();


//Zvol si libovolné pole délky n a najdi v něm takovou kombinaci n-1 prvků, které dávají nejnižší a nejvyšší součet. Tyto dva součty vypiš jako výsledek.
int[] libovolnePole = { 1, 20, 36, 5, 21, 3, 6, 8 };
int libovolnePoleMax = libovolnePole[0];
int libovolnePoleMin = libovolnePole[0];
int soucetPole = 0;
int minimalniSoucet;
int maximalniSoucet;

Console.Write("Moje čísla v poli: ");

for (int i = 0; i < libovolnePole.Length; i++)
{
    if (libovolnePoleMax < libovolnePole[i])
    {
        libovolnePoleMax = libovolnePole[i];
    }

    if (libovolnePoleMin > libovolnePole[i])
    {
        libovolnePoleMin = libovolnePole[i];
    }
    soucetPole = soucetPole + libovolnePole[i];
    Console.Write(mojePole[i] + ", ");
}
minimalniSoucet = soucetPole - libovolnePoleMax;
maximalniSoucet = soucetPole - libovolnePoleMin;

Odradkuj(); 
Console.WriteLine("Minimální součet: " + minimalniSoucet);
Console.WriteLine("Maximální součet: " + maximalniSoucet);


//Vypiš zadaný počet schodů (řádků) podle uvedeného příkladu. Napiš program tak, aby uživatel mohl zadat počet schodů, které se mají vypsat.
Console.WriteLine("Zadej pocet schodů: ");
string pocetText = Console.ReadLine();
int pocet;
while (!int.TryParse(pocetText, out pocet) || pocet < 1)
{
    Console.WriteLine("Toto není spravna hodnota, zadej znovu:");
    pocetText = Console.ReadLine();
}
pocet = pocet+1;
for(int i=1; i<pocet;i++)
{
    for(int a=0; a<pocet-i;a++)
    {
        Console.Write(" ");
    }
    for(int b=0;b<i;b++)
    {
        Console.Write("#");
    }
    Odradkuj();
}

Console.ReadLine();
