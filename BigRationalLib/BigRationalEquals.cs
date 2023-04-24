using System;
using System.Numerics;

namespace BigRationalLib
{
	public readonly partial struct BigRational :IEquatable<BigRational>
	{
        //equals,== i !=

        public bool Equals(BigRational other)
        {
            if (IsNaN(this) && IsNaN(other))
                return true;
            if (IsNaN(this) && !IsNaN(other) || !IsNaN(this) && IsNaN(other))
                return false;
            else
                return (this.Numerator == other.Numerator && this.Denominator == other.Denominator);
        }

        public override bool Equals(object? obj)
        {
            if(obj is null )
            if(obj is BigRational other) return Equals(other);

            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Numerator, Denominator);
        }

        public static bool operator ==(BigRational b1, BigRational b2)
        { return b1.Equals(b2); }

        public static bool operator !=(BigRational b1, BigRational b2)
        { return !(b1.Equals(b2)); }
    }
}

