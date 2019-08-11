using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec181108.ComplexNumber
{
    class ComplexNumber
    {
        double _rn;     // real number
        double _in;     // imaginary number

        // access functions
        public double real()
        {
            return _rn;
        }

        public double imageinary()
        {
            return _in;
        }

        // constructors
        public ComplexNumber()
        {
            _rn = 0.0;
            _in = 0.0;
        }

        public ComplexNumber(double real, double imaginary)
        {
            _rn = real;
            _in = imaginary;
        }

        public static ComplexNumber add(ComplexNumber a, ComplexNumber b)
        {
            ComplexNumber temp = new ComplexNumber();
            temp._rn = a._rn + b._rn;
            temp._in = a._in + b._in;
            return temp;
        }

        public ComplexNumber add(ComplexNumber c)
        {
            ComplexNumber temp = new ComplexNumber();
            temp._rn = this._rn + c._rn;
            temp._in = this._in + c._in;
            return temp;
        }

        public static ComplexNumber subtract(ComplexNumber a, ComplexNumber b)
        {
            return new ComplexNumber(a._rn - b._rn, a._in - b._in);
        }

        public ComplexNumber subtract(ComplexNumber c)
        {
            return new ComplexNumber(_rn - c._rn, _in - c._in);
        }

        /**
         * the size of complex number
         */
        public double magnitude()
        {
            return Math.Sqrt(_rn * _rn + _in * _in);
        }

        /*
        public void print()
        {
            String tmp = "";

            if (_rn > 0)
            {
                tmp = tmp + _rn;
            }
            else
            {
                tmp = tmp + "(" + _rn + ")";
            }
            tmp = tmp + " + ";
            if (_in > 0)
            {
                tmp = tmp + _in + "i";
            }
            else
            {
                tmp = tmp + "(" + _in + ")i";
            }

            Console.WriteLine(tmp);
        }
        */

        public override String ToString()
        {
            String tmp = "";

            if (_rn > 0)
            {
                tmp = tmp + _rn;
            }
            else
            {
                tmp = tmp + "(" + _rn + ")";
            }
            tmp = tmp + " + ";
            if (_in > 0)
            {
                tmp = tmp + _in + "i";
            }
            else
            {
                tmp = tmp + "(" + _in + ")i";
            }

            return tmp;
        }        
    }

    class Program
    {
        static void Main(string[] args)
        {
            ComplexNumber a = new ComplexNumber(1.2, 1.5);
            ComplexNumber b = new ComplexNumber(-2.1, -3.2);
            ComplexNumber c;

            c = a.add(b);
            c = a.subtract(b);

            // c.print();
            // b.print();
            Console.WriteLine(a.ToString());
            Console.WriteLine(b);
            Console.WriteLine(c);

            c = ComplexNumber.add(a, b);
        }
    }
}
