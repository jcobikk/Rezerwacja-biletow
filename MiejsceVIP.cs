public class MiejsceVIP : Miejsce
    {
        public decimal Cena { get; set; }

        public MiejsceVIP(int numerRzedu, int numerMiejscaWRzedzie) : base(numerRzedu, numerMiejscaWRzedzie)
        {
            Cena = 40.00m;
        }
    }
