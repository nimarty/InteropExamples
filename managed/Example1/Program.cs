using System;
using DummyLib.Wrapper;

namespace ExampleBlittableType
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = 1 / DummyLibPINVOKE.Q_rsqrt(144);
            Console.WriteLine($"1 / Q_rsqrt(144) = {result}");
        }
    }
}