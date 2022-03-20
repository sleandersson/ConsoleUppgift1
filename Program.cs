// See https://aka.ms/new-console-template for more information
Console.WriteLine("Staffan Leandersson, sleandersson@yahoo.se, L0002B, Uppgift 1 Console-variant \n\n");

//Första GoTo flaggan. Frågar efter summa att betala men kan också avsluta genom att mata in en '0'.
Flagga1:
Console.WriteLine("Pris att betala? (Skriv '0' för att avsluta.)");
int attBetala = Convert.ToInt32(Console.ReadLine());
    if (attBetala == 0)
    {
    Console.WriteLine("Användaren har avslutat programmet. Tryck på valfri knapp för att stänga fönstret.");
    Console.ReadLine();
    Environment.Exit(0);
    }
Console.Clear();

//Andra GoTo flaggan. Visar summan av köpet och frågar efter vad kunden har betalat. Om kunden har betalat för lite får man varningsmeddelande och programmet GoTo Flagga2.
Flagga2:
Console.WriteLine("Summan av köpet är: " + attBetala + " kr." + "\n");
Console.WriteLine("\n" + "Hur mycket har kunden betalat?");
int kundBetalt = Convert.ToInt32(Console.ReadLine());
Console.Clear();
    if (kundBetalt < attBetala)
    {
    int betalatLite = (kundBetalt - attBetala) * -1;
    Console.WriteLine("Kunden har betalat " + betalatLite + " kr för lite! Vänligen korrigera.");
    goto Flagga2;
    }

Console.WriteLine("Summan av köpet är: " + attBetala + " kr." + "\n");
Console.WriteLine("Kunden har givit dig: " + kundBetalt + " kr." + "\n");
int totalChange = (kundBetalt - attBetala);
Console.WriteLine("Du ska ge tillbaka " + totalChange + " kr. i form av;" + "\n");

//En övergripande do sats med if satser per valör som med nästlade do satser räknar av växel som är kvar och räknar upp antal valörer.
do
{
int tvåHundring, hundraLapp, femtioLapp, tjugoLapp, tioKrona, femKrona, enKrona;

    if (totalChange >= 200)
    {
    tvåHundring = 0;
        do
        { 
        int nySumma = totalChange - 200;
        tvåHundring++;
        totalChange = nySumma;
        } while (totalChange > 200);
    Console.WriteLine(tvåHundring + " tvåhundralapp(ar).\n");
    }

    if (totalChange >= 100)
    {
    hundraLapp = 0;
        do
        {
        int nySumma = totalChange - 100;
        hundraLapp++;
        totalChange = nySumma;
        } while (totalChange > 100);
        Console.WriteLine(hundraLapp + " hundralapp(ar).\n");
    }

    if (totalChange >= 50)
    {
    femtioLapp = 0;
        do
        {
        int nySumma = totalChange - 50;
        femtioLapp++;
        totalChange = nySumma;
        } while (totalChange > 50);
        Console.WriteLine(femtioLapp + " femtiolapp(ar).\n");
    }

    if (totalChange >= 20)
    {
    tjugoLapp = 0;
        do
        {
        int nySumma = totalChange - 20;
        tjugoLapp++;
        totalChange = nySumma;
        } while (totalChange > 20);
        Console.WriteLine(tjugoLapp + " tjugolapp(ar).\n");
    }

    if (totalChange >= 10)
    {
        tioKrona = 0;
        do
        {
        int nySumma = totalChange - 10;
        tioKrona++;
        totalChange = nySumma;
        } while (totalChange > 10);
        Console.WriteLine(tioKrona + " tiokron(a/or).\n");
    }

    if (totalChange >= 5)
    {
    femKrona = 0;
        do
        {
        int nySumma = totalChange - 5;
        femKrona++;
        totalChange = nySumma;
        } while (totalChange > 5);
        Console.WriteLine(femKrona + " femkron(a/or).\n");
    }

    if (totalChange > 0)
    {
    enKrona = 0;
        do
        {
        int nySumma = totalChange - 1;
        enKrona++;
        totalChange = nySumma;
        } while (totalChange > 0);
        Console.WriteLine(enKrona + " enkron(a/or).\n");
    }

} while ( totalChange > 0);


//Ger möjligheten att starta om från början med sifferinmatning.
Console.WriteLine("\n\nVill du fortsätta? skriv '1' annars skriv '0' för att avsluta.");
string svar = Console.ReadLine();
if (svar == "1")
{
Console.Clear();
goto Flagga1;
}
else if (svar == "0") Environment.Exit(0);