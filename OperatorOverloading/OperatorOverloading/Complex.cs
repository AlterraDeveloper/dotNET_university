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
            var ret_val = "";
            if(real != 0) ret_val = String.Concat(ret_val,real.ToString());
            if (img > 0)
            {
                if (String.IsNullOrEmpty(ret_val))
                {
                    return String.Concat(ret_val , img == 1 ? "i" : String.Concat(img, "i"));
                }
                else
                {
                    return String.Concat(ret_val,img == 1 ? "+i" : String.Concat("+", img, "i"));
                }
                
            }
            else if (img < 0)
            {
                if (String.IsNullOrEmpty(ret_val))
                {
                    return String.Concat(ret_val, img == -1 ? "-i" : String.Concat(img, "i"));
                }
                else
                {
                    return String.Concat(ret_val, img == -1 ? "-i" : String.Concat(img, "i"));
                }
            }
            return String.IsNullOrEmpty(ret_val)? "0" : ret_val;
        }

        public static explicit operator double(Complex number)
        {
            return number.real;
        }

        public override bool Equals(object obj)
        {
            var comparedObject = obj as Complex;
            if (comparedObject == null) return false;
            if (Object.ReferenceEquals(this, comparedObject)) return true;
            return this == comparedObject;
        }

        public static bool operator ==(Complex firstObj, Complex secondObj)
        {
            return firstObj.real == secondObj.real && firstObj.img == secondObj.img;
        }

        public static bool operator !=(Complex firstObj, Complex secondObj)
        {
            return !(firstObj == secondObj);
        }
    }

    struct ComplexStruct
    {
        private double real;
        private double img;

        public ComplexStruct(double r, double i)
        {
            real = r;
            img = i;
        }

        public static ComplexStruct operator +(ComplexStruct one, ComplexStruct another)
        {
            return new ComplexStruct(one.real + another.real, one.img + another.img);
        }

        public static ComplexStruct operator -(ComplexStruct one, ComplexStruct another)
        {
            return new ComplexStruct(one.real - another.real, one.img - another.img);
        }

        public static ComplexStruct operator *(ComplexStruct one, ComplexStruct another)
        {
            return new ComplexStruct(one.real * another.real - one.img * another.img, one.real * another.img + one.img * another.real);
        }

        public static ComplexStruct operator /(ComplexStruct one, ComplexStruct another)
        {
            return new ComplexStruct(
                (one.real * another.real + one.img * another.img) / (another.real * another.real + another.img * another.img),
                (one.img * another.real - one.real * another.img) / (another.real * another.real + another.img * another.img));
        }


        public override string ToString()
        {
            var ret_val = "";
            if (real != 0) ret_val = String.Concat(ret_val, real.ToString());
            if (img > 0)
            {
                if (String.IsNullOrEmpty(ret_val))
                {
                    return String.Concat(ret_val, img == 1 ? "i" : String.Concat(img, "i"));
                }
                else
                {
                    return String.Concat(ret_val, img == 1 ? "+i" : String.Concat("+", img, "i"));
                }

            }
            else if (img < 0)
            {
                if (String.IsNullOrEmpty(ret_val))
                {
                    return String.Concat(ret_val, img == -1 ? "-i" : String.Concat(img, "i"));
                }
                else
                {
                    return String.Concat(ret_val, img == -1 ? "-i" : String.Concat(img, "i"));
                }
            }
            return String.IsNullOrEmpty(ret_val) ? "0" : ret_val;
        }

        public static explicit operator double(ComplexStruct number)
        {
            return number.real;
        }

        public override bool Equals(object obj)
        {
            if (Object.ReferenceEquals(this, obj)) return true;
            if (obj is ComplexStruct) return this == (ComplexStruct) obj;
            return false;
        }

        public static bool operator ==(ComplexStruct firstObj, ComplexStruct secondObj)
        {
            return firstObj.real == secondObj.real && firstObj.img == secondObj.img;
        }

        public static bool operator !=(ComplexStruct firstObj, ComplexStruct secondObj)
        {
            return !(firstObj == secondObj);
        }
    }
}
