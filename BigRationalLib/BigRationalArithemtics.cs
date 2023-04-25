using System;
namespace BigRationalLib
{
    public readonly partial struct BigRational
    {
        public static BigRational operator +(BigRational left, BigRational right)
        {
            if (left == NaN || right == NaN)
                return NaN;

            //ToDO - sytuacje specjalne

            return new(left.Numerator * right.Denominator + right.Numerator * left.Denominator,
                left.Denominator * right.Denominator);
        }

        public static BigRational operator ++(BigRational b) => b + 1;

        public static BigRational operator -(BigRational left, BigRational right)
        {
            if (left == NaN || right == NaN)
                return NaN;

            //ToDO - sytuacje specjalne

            return new(left.Numerator * right.Denominator - right.Numerator * left.Denominator,
                left.Denominator * right.Denominator);
        }

        public static BigRational operator --(BigRational b) => b - 1;

        public static BigRational operator *(BigRational left, BigRational right)
        {
            if (left == NaN || right == NaN)
                return NaN;

            //ToDO - sytuacje specjalne

            return new(left.Numerator * right.Numerator, left.Denominator * right.Denominator);
        }

        public static BigRational operator /(BigRational left, BigRational right)
        {
            if (left == NaN || right == NaN)
                return NaN;

            //ToDO - sytuacje specjalne

            return new(left.Numerator * right.Denominator, left.Denominator * right.Numerator);
        }
    }
}

