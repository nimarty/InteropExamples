using System;
using System.Text;
using DummyLib.Wrapper;

namespace ExampleStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            DummyLibPINVOKE.PrintMessage("ASCII message:   Hello PInvoke");
            DummyLibPINVOKE.PrintMessage("Unicode message: I ❤️ 💻");
        }
    }
}