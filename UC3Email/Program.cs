using System;

namespace UC3Email;

class Program
{
    public static void Main(string[] args)
    {
        Email email = new Email();
        Console.WriteLine(email.validateEmail("niravpandit@gmail.com"));
    }
}