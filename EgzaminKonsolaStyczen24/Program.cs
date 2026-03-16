using EgzaminKonsolaStyczen24;

Console.WriteLine("Wprowadź 11 znakowy numer pesel");
Pesel pesel = new Pesel(Console.ReadLine());

Console.WriteLine("Sprawdzanie płci");
if (pesel.SprawdzPlec() == 'K')
{
    Console.WriteLine("jest to kobieta");
} else
{
    Console.WriteLine("jest to mezczyzna");
}

Console.WriteLine("Sprawdzenie poprawności numeru pesel:");
Console.WriteLine(pesel.WalidacjaNumeruPesel() ? "Pesel prawidlowy" : "Pesel nieprawidłowy");