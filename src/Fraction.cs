﻿using System;

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
            var nominator = a.Nominator * b.Denominator + b.Nominator * a.Denominator;
            var denominator = a.Denominator * b.Denominator;
            while (nominator % 2 == 0 && denominator % 2 == 0) 
            {
                nominator /= 2;
                denominator /= 2;
            }
            return new Fraction(nominator, denominator);
        }

        public override string ToString() 
        {
            return $"{Nominator}/{Denominator}";
        }
    }
}
