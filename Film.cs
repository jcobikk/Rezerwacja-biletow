class Film
{
    public string Tytul {get; set;}
    public int CzasTrwania {get; set;}
    public string Gatunek {get; set;}
    public Film(string tytul, int czasTrwania, string gatunek)
    {
        Tytul = tytul;
        CzasTrwania = czasTrwania;
        Gatunek = gatunek;
    }
}