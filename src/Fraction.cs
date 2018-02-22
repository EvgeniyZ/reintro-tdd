using System;

namespace src
{
    public struct Fraction
    {
        // above line
        public int Nominator { get; }
        // below line
        public int Denominator { get; }
        public Fraction(int nominator, int denominator)
        {
            Nominator = nominator;
            Denominator = denominator;
        }

        public static Fraction operator +(Fraction a, Fraction b) 
        {
            if (a.Denominator == b.Denominator) 
            {
                return new Fraction(1, a.Denominator / 2);
            }
            var difference = b.Denominator - a.Denominator;
            return new Fraction(b.Nominator + difference, b.Denominator);
        }

        public override string ToString() 
        {
            return $"{Nominator}/{Denominator}";
        }
    }
}
