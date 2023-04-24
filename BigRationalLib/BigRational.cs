using System.Numerics;
using System.Runtime.CompilerServices;

namespace BigRationalLib
{
    public readonly struct BigRational
    {
        //dane, wewnętrzna reprezentacja 
        public BigInteger Numerator { get; init; } 
        public BigInteger Denominator { get; init; }

        public static readonly BigRational Zero = new BigRational(0, 1);
        public static readonly BigRational One = new BigRational(1, 1);
        public static readonly BigRational NaN = new BigRational(0, 0);

        //konstruktory

        public BigRational(BigInteger numerator, BigInteger denominator)
        {
            Numerator = numerator;  
            Denominator = denominator;

            if (this.Equals(NaN)) return;



            //znaki ułamka
            if (Denominator < 0)
               (Numerator, Denominator) = (-Numerator, -Denominator);
              //  denominator *= -1;
              //  numerator *= -1;

            //uproszczenie GreatesCommonInteger
            //if (true)
            //{ }
                var GCD = BigInteger.GreatestCommonDivisor(Numerator, Denominator);
                Numerator /= GCD;
                Denominator /= GCD;
            
        }

        //tostring
        public override string ToString() => $"{Numerator}/{Denominator}";


        //public BigRational Pause(string text)
        //{
        //   return text.Split('/');
        //}

        //equals, równość - zdefinij = i !=

        //relacje

        //artmetyka

        //konwersja

    }
}