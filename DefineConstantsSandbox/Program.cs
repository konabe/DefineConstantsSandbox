using System;
using AnotherLibrary;

namespace DefineConstantsSandbox
{
    class Program
    {
        static void Main(string[] args)
        {
#if DEBUG
            Console.WriteLine("Program Start (Debug)");
#elif RELEASE
            Console.WriteLine("Program Start (Release)");
#else
            Console.WriteLine("Program Start (No Config Constant)");
#endif

#if DETECTED
            Console.WriteLine("/p:DevNum=? detected!");
#endif

#if DOG
            Console.WriteLine("Dog is true");
#elif CAT
            Console.WriteLine("CAT is true");
#endif

            var myClass = new MyClass();
            myClass.Print();
        }
    }
}
