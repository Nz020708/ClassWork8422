using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    class Printfilegen<T> where T : IPrintable
    {
        public string FileNAme { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }


        public static void Print(T type)
        {
            type.Print();
        }
    }
}
