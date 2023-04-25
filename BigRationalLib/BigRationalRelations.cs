using System;
namespace BigRationalLib
{
    public readonly partial struct BigRational : IComparable<BigRational>
    {
        // u<v
        // ||
        //u.CompareTo(v) => 1 (u>v)
        public int CompareTo(BigRational other)
        {
            //ToDo - sytuacje specjalne

            return (this.Numerator * other.Denominator - this.Numerator * other.Denominator).Sign;
        }

        public static bool operator <(BigRational left, BigRational right)
        {
            return left.CompareTo(right) < 0;
        }

        public static bool operator >(BigRational left, BigRational right)
        {
            return left.CompareTo(right) > 0;
        }

        public static bool operator <=(BigRational left, BigRational right)
        {
            return left.CompareTo(right) <= 0;
        }

        public static bool operator >=(BigRational left, BigRational right)
        {
            return left.CompareTo(right) >= 0;
        }
    }
}

