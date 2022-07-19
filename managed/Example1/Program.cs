using System;
using DummyLib.Wrapper;

namespace Example1
{
    class Program
    {
        static void Main(string[] args)
        {
            var value = 1 / DummyLibPINVOKE.Q_rsqrt(144);

            Console.WriteLine($"inverse inverse sqrt(144): {value}");
        }
    }
}