using System;
using System.Runtime.InteropServices;

namespace DummyLib.Wrapper
{
    public class DummyLibPINVOKE
    {
        // Blittable Type
        [DllImport("native/DummyLib.dll")]
        public static extern float Q_rsqrt(float number);

        // Non blittable types
        [DllImport("native/DummyLib.dll")]
        //[Return: MarshalAs(UnmanagedType.I1)]
        public static extern bool IsNegative(int number);

        // strings and encoding
        [DllImport("native/DummyLib.dll")]
        public static extern void PrintMessage( /*[MarshalAs(UnmanagedType.LPUTF8Str)]*/ string msg);

        [DllImport("native/DummyLib.dll" /*, CharSet = CharSet.Unicode*/)]
        public static extern void PrintMessageW(string msg);

        // structs?

        // delegates?

        // custom type with custom marshaller?
    }
}