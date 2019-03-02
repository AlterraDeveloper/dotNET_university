using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    class Complex
    {
        private double real;
        private double img;

        public Complex(double r,double i)
        {
            real = r;
            img = i;
        }

        public static Complex operator+(Complex one,Complex another)
        {
            return new Complex(one.real + another.real, one.img + another.img);
        }

        public static Complex operator-(Complex one, Complex another)
        {
            return new Complex(one.real - another.real, one.img - another.img);
        }

        public static Complex operator *(Complex one, Complex another)
        {
            return new Complex(one.real*another.real - one.img*another.img,one.real*another.img + one.img*another.real);
        }

        public static Complex operator /(Complex one, Complex another)
        {
            return new Complex(
                (one.real * another.real + one.img * another.img) / (another.real * another.real + another.img * another.img),
                (one.img * another.real - one.real * another.img) / (another.real * another.real + another.img * another.img));
        }

        private string WithSign(double value)
        {
            return value >= 0 ? "+" + value.ToString("N") : value.ToString("N");
        }
        public override string ToString()
        {
            return WithSign(real) + "i" + WithSign(img);
        }

        public static explicit operator double(Complex number)
        {
            return number.real + Math.Pow(number.img, 2) * (-1);
        }
    }
}
