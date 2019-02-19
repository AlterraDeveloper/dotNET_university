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

        public override string ToString()
        {
            return ((int)real).ToString("-#;0") + ((int)img).ToString("+#;-#") +"i";
        }
    }
}
