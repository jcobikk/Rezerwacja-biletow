using System;

public class KinoSystem
{
    private Seans _aktualnySeans;
    public KinoSystem()
    {
        Film film1 = new Film("Incepcja", 148, "Sci-Fi");
        _aktualnySeans = new Seans(film1, DateTime.Now);
    }
    public void Uruchom()
    {
        int wybor = 0;
        while(wybor != 2)
        {
            WyswielEkranSystemu();
            wybor = PobierzWyborUzytkownika();

            if(wybor == 1)
            {
                ObsluzRezerwacje();
            }
        }
    }
    private void WyswielEkranSystemu()
    {
        Console.Clear();
        Console.WriteLine("Rezerwacja biletów do kina");
        Console.WriteLine($"Seans: {_aktualnySeans.WyswietlanyFilm.Tytul}, Kiedy: {_aktualnySeans.DataIGodzina}");
        foreach(Miejsce m in _aktualnySeans.Miejsca)
            {
                if (m.CzyZajete)
                {
                    Console.Write("[X]");
                }
                else
                {
                    Console.Write("[ ]");
                }
                if(m.NumerMiejscaWRzedzie == 10)
                {
                    Console.WriteLine();
                }
            }   
    }
    private int PobierzWyborUzytkownika()
    {
        int wybor;
        Console.WriteLine("1. Zarezerwuj bilet\n2. Wyjdź");
        while (true)
            {
                string wejscie = Console.ReadLine();
                if(int.TryParse(wejscie, out wybor) && wybor > 0 && wybor <= 2)
                {
                    break;
                }
                Console.WriteLine("Niepoprawny wybór! Wybierz 1 lub 2!");
            }
            return wybor;
    }
    private void ObsluzRezerwacje()
    {
            
        Console.WriteLine("Podaj rząd: ");
        int podanyrzad = int.Parse(Console.ReadLine());
        Console.WriteLine("Podaj miejsce: ");
        int podanemiejsce = int.Parse(Console.ReadLine());
        if(_aktualnySeans.ZarezerwujMiejsce(podanyrzad, podanemiejsce))
        {
            Console.WriteLine("Zarezerwowano miejsce!");
        }
        else
        {
            Console.WriteLine("Miejsce zajęte lub nie istnieje!");
        }
        Console.WriteLine("\nNaciśnij dowolny klawisz aby kontynuować...");
        Console.ReadKey();
            
    }
}