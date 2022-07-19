using System;
using System.Text;
using DummyLib.Wrapper;

namespace ExampleStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            DummyLibPINVOKE.PrintMessage("ASCII message using char*:      Hello PInvoke");
            DummyLibPINVOKE.PrintMessage("unicode message using char*:    I ❤️ 💻");
            DummyLibPINVOKE.PrintMessageW("ASCII message using wchar_t*:   Hello PInvoke");
            DummyLibPINVOKE.PrintMessageW("unicode message using wchar_t*: I ❤️ 💻");
        }
    }
}