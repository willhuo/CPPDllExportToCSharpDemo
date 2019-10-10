using System;
using System.Runtime.InteropServices;

namespace ConsoleApp
{
    class Program
    {
        [DllImport("dlls\\NewLib")]
        static extern int NativeSum(int arg1, int arg2);


        static void Main(string[] args)
        {
            try
            {
                int thirty = NativeSum(10, 20);
                Console.WriteLine($"NativeSum(10,20) = {thirty}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message} Line: {e.Source}");
            }

            Console.ReadLine();
        }
    }
}
