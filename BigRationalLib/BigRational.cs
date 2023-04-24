using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace BigRationalLib
{
    public readonly partial struct BigRational
    {
        //dane, wewnętrzna reprezentacja 
        public BigInteger Numerator { get; init; } 
        public BigInteger Denominator { get; init; }

        public static readonly BigRational Zero = new BigRational(0, 1);
        public static readonly BigRational One = new BigRational(1, 1);
        public static readonly BigRational Half = new BigRational(1, 2);

        public static readonly BigRational NaN = new BigRational(0, 0);
        public static readonly BigRational PositiveInfinity = new BigRational(1, 0);
        public static readonly BigRational NegativeInfinity = new BigRational(1, 0);

        //konstruktory

        public BigRational(BigInteger numerator, BigInteger denominator)
        {
            Numerator = numerator;  
            Denominator = denominator;

            if (this.Equals(NaN)) return;

            //uproszczenie GreatesCommonInteger
    
                var GCD = BigInteger.GreatestCommonDivisor(Numerator, Denominator);
                Numerator /= GCD;
                Denominator /= GCD;

            //znaki ułamka
            if (Denominator < 0)
                (Numerator, Denominator) = (-Numerator, -Denominator);

        }

        public BigRational(BigInteger value) : this(value, 1) { }

        public BigRational() : this(0, 1) { }

        //tostring
        public override string ToString() => $"{Numerator}/{Denominator}";


        public static BigRational Parse(string text)
        {
            var tab =  text.Split('/');

            if (tab.Length != 2)
                throw new FormatException();

            return new BigRational(BigInteger.Parse(tab[0]), BigInteger.Parse(tab[1]));
        }

        public static bool IsNaN(BigRational b) => (b.Numerator == 0 && b.Denominator == 0);

        //relacje

        //artmetyka

        //konwersja

    }
}