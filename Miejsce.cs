class Miejsce
{
    public int NumerRzedu {get; set;}
    public int NumerMiejscaWRzedzie {get; set;}
    public bool CzyZajete {get; set;} = false;
    public Miejsce(int numerRzedu, int numerMiejscaWRzedzie)
    {
        NumerMiejscaWRzedzie = numerMiejscaWRzedzie;
        NumerRzedu = numerRzedu;
    }
}