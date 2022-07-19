using System;
using DummyLib.Wrapper;

namespace Example1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("normalized vector: " + 1 / DummyLibPINVOKE.Q_rsqrt(144));
            Console.WriteLine("is 5 negative: " + DummyLibPINVOKE.IsNegative(5));
            Console.WriteLine("is -123 negative: " + DummyLibPINVOKE.IsNegative(-123));
            Console.WriteLine("return false: " + DummyLibPINVOKE.ReturnFalse());
        }
    }
}