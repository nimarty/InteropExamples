using System;
using DummyLib.Wrapper;

namespace ExampleNonBlittableType
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"is -123 negative: {DummyLibPINVOKE.IsNegative(-123)}");
            Console.WriteLine($"is 5 negative: {DummyLibPINVOKE.IsNegative(5)}");
        }
    }
}
