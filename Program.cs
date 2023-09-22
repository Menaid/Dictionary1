string[] husdjur = File.ReadAllLines("Bok1.csv");

Dictionary<string, int> djur = new Dictionary<string, int>();


foreach (var rad in husdjur)
{
    if (djur == "")
    {
        string[] namn = rad.Split(";");
    }
    else
    {
        Console.WriteLine("Failed to parse something");
    }
    Console.WriteLine(namn[0]);
}

Console.WriteLine("Vänligen ange ett namn av ovanstående");

var djurNamn = Console.ReadLine().ToLower();

bool choose = true;

while (choose)
{

    if (djur.ContainsKey(djurNamn))
    {
        Console.WriteLine("Djurets födelseår är " + (2023 - djur[djurNamn]));

    }
    else
    {
        Console.WriteLine("Det angivna namnet finns inte i listan");

    }

    choose = true;
}

