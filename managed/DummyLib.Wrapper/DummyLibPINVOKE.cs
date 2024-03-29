﻿using System;
using System.Runtime.InteropServices;

namespace DummyLib.Wrapper
{
    public class DummyLibPINVOKE
    {
        // blittable type
        // https://docs.microsoft.com/en-us/dotnet/framework/interop/blittable-and-non-blittable-types
        [DllImport("native/DummyLib.dll")]
        public static extern float Q_rsqrt(float number);

        // non blittable type
        // https://docs.microsoft.com/en-us/dotnet/framework/interop/blittable-and-non-blittable-types
        [DllImport("native/DummyLib.dll")]
        public static extern bool IsNegative(int number);

        // strings and encoding
        // https://docs.microsoft.com/en-us/dotnet/framework/interop/default-marshalling-for-strings#strings-used-in-platform-invoke
        [DllImport("native/DummyLib.dll")]
        public static extern void PrintMessage(string msg);

        [DllImport("native/DummyLib.dll")]
        public static extern void PrintMessageW(string msg);

        // structs
        // https://docs.microsoft.com/en-us/dotnet/framework/interop/default-marshalling-behavior#default-marshalling-for-value-types
        [StructLayout(LayoutKind.Sequential)]
        public struct Point
        {
            public double y;
            public int z;
        }

        [DllImport("native/DummyLib.dll")]
        public static extern void PrintPoint(Point point);

        // delegates?

        // custom type with custom marshaller?

        // copy vs pinning ?

        // exceptions ?
    }
}