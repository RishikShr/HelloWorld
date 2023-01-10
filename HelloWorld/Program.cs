// See https://aka.ms/new-console-template for more information

using System;
 namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string : ");
            string str = Console.ReadLine();
            LengthHelper lp = new LengthHelper();
            Console.WriteLine("Length of the string is : " + lp.findLength(str));
            Console.ReadKey();
        }

        public class LengthHelper
        {
            public int findLength(string s)
            {
                if (s == null)
                {
                    throw new ArgumentException("string  cannot be null");
                }
                return s.Length;
            }
        }
    }
}
