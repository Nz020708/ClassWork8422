using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    class Excel : IPrintable
{


    public int RowCount { get; set; }
    public int ColumnCount { get; set; }

    public string FileNAme { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }


    public Excel(int rowc, int columnc)
    {
        RowCount = rowc;
        ColumnCount = columnc;
    }
    public void Print()
    {
        Console.WriteLine(RowCount);
    }
}
}
