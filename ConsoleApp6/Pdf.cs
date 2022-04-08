using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    class Pdf : IPrintable
{
    public int PageCount { get; set; }

    public string FileNAme { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public Pdf(int pagecount)
    {
        PageCount = pagecount;
    }

    public Pdf()
    {
    }

    public  void Print()
    {
        Console.WriteLine($"SAy:{PageCount}");
    }
}
}
