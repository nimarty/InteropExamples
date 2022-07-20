using System;
using System.Security.Cryptography.X509Certificates;
using DummyLib.Wrapper;

namespace ExampleStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            DummyLibPINVOKE.Point p = new DummyLibPINVOKE.Point();
            p.y = 45.67;
            p.z = 89;
            DummyLibPINVOKE.PrintPoint(p);
        }
    }
}