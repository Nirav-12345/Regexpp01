using System;

namespace UC4MobileFormat;

class Program
{
    public static void Main(string[] args)
    {
        UC4 v = new UC4();

        Console.WriteLine(v.validateMobile("917655786888"));
    }
}