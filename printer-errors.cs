using System;
using System.Linq;

public class Printer
{
    public static string PrinterError(String s)
    {

        return s.Count(c => c > 'm') + "/" + s.Length;
    }
}