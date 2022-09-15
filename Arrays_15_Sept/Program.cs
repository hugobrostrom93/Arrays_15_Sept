// See https://aka.ms/new-console-template for more information

/*
string[] bajs = new string[4]; // måste inte vara en string. Kan vara int, double osv...
bajs[0] = "Hugo";
bajs[1] = "Axel";
bajs[2] = "Daniel";
bajs[3] = "Broström";
*/


string[] gothamHeroes = new string[]
{
    "Batman",
    "Robin",
    "Batgil"
};

Array.Sort(gothamHeroes); // Sortera i bokstavsordning

for (int nummerUp = 0; nummerUp < gothamHeroes.Length; nummerUp++) // börjar på 0 med nummerUp, så länge nummerUp är mindre än Arrayen så går den vidare till nästa array nummer
{
    Console.WriteLine($"{gothamHeroes[nummerUp]}");
}


string[] namn = new string[4]; // måste inte vara en string. Kan vara int, double osv...

string stringNamn = "";
int nummerWtf = 0;
do
{
    stringNamn = Console.ReadLine();
    if (nummerWtf >= namn.Length) break;
    namn[nummerWtf] = stringNamn;
    nummerWtf++;
} while (stringNamn != ""); // Loopen slutar köra om jag inte skriver något

// Sortera i bokstavsordning
// Annars enligt värde från minsta till den högsta
Array.Sort(namn);

for (int count = 0; count < namn.Length; count++) // Loopen kommer gå från 0 till längden av vår array (namn.Length, alltså 4 gånger)
{
    //                array[position]
    Console.WriteLine(namn[count]);
}




/*

Console.WriteLine(namn[0]);
Console.WriteLine(namn[1]);
Console.WriteLine(namn[2]);
Console.WriteLine(namn[3]);

string[] namnTwo = new string[] // ett annat sätt att skiva det på
{
    "Hugo",
    "Axel",
    "Daniel",
    "Broström"
};

Console.WriteLine(namnTwo[0]);
Console.WriteLine(namnTwo[1]);
Console.WriteLine(namnTwo[2]);
Console.WriteLine(namnTwo[3]);

*/
