using System;
using System.Collections.Generic;
class Seans
{
    public Film WyswietlanyFilm {get; set;}
    public DateTime DataIGodzina {get; set;}
    public List<Miejsce> Miejsca {get; set;} = new List<Miejsce>();
    public Seans(Film film, DateTime dataIGodzina)
    {
        WyswietlanyFilm = film;
        DataIGodzina = dataIGodzina;

        for(int r = 1; r < 6; r++)
        {
            for(int m = 1; m < 11; m++)
            {
                if (r == 5)
                {
                    Miejsca.Add(new MiejsceVIP(r,m));
                }
                else
                {
                    Miejsca.Add(new Miejsce(r,m));
                }
            }
        }
    }
    public bool ZarezerwujMiejsce(int rzad, int numerMiejsca)
    {
        foreach(Miejsce m in Miejsca)
        {
            if(m.NumerRzedu == rzad && m.NumerMiejscaWRzedzie == numerMiejsca)
            {
                if(m.CzyZajete)
                {
                    return false;
                }
                else
                {
                    m.CzyZajete = true;
                    return true;
                }
            }
        }
        return false;
    }
}