
Console.WriteLine("Delete this line when you have written your code");

// opretter et objekt af Barometer
Barometer barometer = new Barometer();

for (int i = 0; i < 7; i++)
{
    Console.Write("Skriv lufttrykket (Pressure): "  );
    string trykStr = Console.ReadLine();

    //int tryk;
    //if (int.TryParse(trykStr, out tryk))
    //{
    //    barometer.Pressure = tryk;
    //}
    //else
    //{
    //    Console.WriteLine("FEJL");
    //}

    int tryk = int.Parse(trykStr);
    barometer.Pressure = tryk;

    string beskrivelse = barometer.WeatherDescription;
    Console.WriteLine($" Så må det være {beskrivelse} ");

}
