using System;
using System.Collections.Generic;
using System.Text;

namespace _2022_11_02_TestGenric
{
    public class TestGeneric
    {
        public static bool Compare<T>(T value1, T value2) { return (value1.Equals(value2)); }
    }
}
