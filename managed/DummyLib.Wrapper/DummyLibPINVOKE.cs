using System;
using System.Runtime.InteropServices;

namespace DummyLib.Wrapper
{
    public class DummyLibPINVOKE
    {
        [DllImport("native/DummyLib.dll")]
        public static extern float Q_rsqrt(float number);

        [DllImport("native/DummyLib.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsNegative(int number);

        [DllImport("native/DummyLib.dll")]
        public static extern bool ReturnFalse();

        //strings with unicode problematics

        // structs?

        // delegates?

        // custom type with custom marshaller?
    }
}