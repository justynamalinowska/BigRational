using System;
namespace BigRationalLib
{
    public readonly partial struct BigRational
    {
        public static implicit operator BigRational(long x) => new BigRational(x);
        public static explicit operator long(BigRational u) => (long)((double)(u.Numerator) / (double)(u.Denominator));

	}
}

