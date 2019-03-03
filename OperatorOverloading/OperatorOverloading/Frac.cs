using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    public class Frac
    {
        private int wholePart;
        private int numerator;
        private int denominator;

        public Frac() { }

        public Frac(int numerator, int denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
        }

        public Frac(int wholePart, int numerator, int denominator) : this(numerator, denominator)
        {
            this.wholePart = wholePart;
        }

        public static Frac operator +(Frac firstObject, Frac secondObject)
        {
            var newFirstObject = firstObject.Normalize();
            var newSecondObject = secondObject.Normalize();
            return new Frac(
                newFirstObject.numerator * newSecondObject.denominator + newFirstObject.denominator * newSecondObject.numerator,
                newFirstObject.denominator * newSecondObject.denominator);
        }
        public static Frac operator -(Frac firstObject, Frac secondObject)
        {
            var newFirstObject = firstObject.Normalize();
            var newSecondObject = secondObject.Normalize();
            return new Frac(
                newFirstObject.numerator * newSecondObject.denominator - newFirstObject.denominator * newSecondObject.numerator,
                newFirstObject.denominator * newSecondObject.denominator);

        }
        public static Frac operator *(Frac firstObject, Frac secondObject)
        {
            var newFirstObject = firstObject.Normalize();
            var newSecondObject = secondObject.Normalize();
            return new Frac(newFirstObject.numerator * newSecondObject.numerator, newFirstObject.denominator * newSecondObject.denominator);
        }
        public static Frac operator /(Frac firstObject, Frac secondObject)
        {
            var newFirstObject = firstObject.Normalize();
            var newSecondObject = secondObject.Normalize();
            return new Frac(newFirstObject.numerator * newSecondObject.denominator, newFirstObject.denominator * newSecondObject.numerator);
        }
        public Frac Normalize()
        {
            return new Frac(numerator + denominator * wholePart, denominator);
        }
        public Frac Denormalize()
        {
            return new Frac( numerator/denominator, numerator % denominator, denominator);
        }
        public override string ToString()
        {
            var ret_val = String.Empty;
            var sign = Math.Sign(wholePart) + Math.Sign(numerator) + Math.Sign(denominator) < 0 ? "-" : "";
            if(wholePart != 0) ret_val = String.Concat(ret_val,wholePart," ");
            if (numerator != 0) ret_val = String.Concat(ret_val, numerator, "/", denominator);
            return String.IsNullOrEmpty(ret_val) ? "0" : sign + ret_val;
        }
        public static implicit operator double(Frac frac)
        {
            var newFrac = frac.Normalize();
            return (double)newFrac.numerator / newFrac.denominator;
        }

        public override bool Equals(object obj)
        {
            var comparedObject = obj as Frac;
            if (comparedObject == null) return false;
            if (Object.ReferenceEquals(comparedObject, this)) return true;
            return comparedObject == this;
        }

        public static bool operator ==(Frac firstFrac, Frac secondFrac)
        {
            var newFirstFrac = firstFrac.Normalize();
            var newSecondFrac = secondFrac.Normalize();
            return newFirstFrac.numerator == newSecondFrac.numerator &&
                   newFirstFrac.denominator == newSecondFrac.denominator;
        }

        public static bool operator !=(Frac firstFrac, Frac secondFrac)
        {
            return !(firstFrac == secondFrac);
        }
    }
}
