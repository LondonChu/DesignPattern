using System;

namespace DesignPattern
{
    class Pattern_FactoryMethod_工廠方法模式
    {
        public class Complex
        {
            public double Real;
            public double Imaginary;

            public static Complex FromCartesianFactory(double real, double imaginary)
            {
                return new Complex(real, imaginary);
            }

            public static Complex FromPolarFactory(double modulus, double angle)
            {
                return new Complex(modulus * Math.Cos(angle), modulus * Math.Sin(angle));
            }

            private Complex(double real, double imaginary)
            {
                Real = real;
                Imaginary = imaginary;
            }
        }
    }
}
