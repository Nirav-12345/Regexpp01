using System;

namespace UC1EnterUserName;

class Program
{
    public static void Main(string[] args)
    {
        UC1 v = new UC1();

        Console.WriteLine(v.validateName("Nir"));
    }
}