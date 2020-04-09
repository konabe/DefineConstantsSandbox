using System;
namespace AnotherLibrary
{
    public class MyClass
    {
        public MyClass()
        {
        }

        public void Print()
        {
            Console.WriteLine();
            Console.WriteLine("MyClass#Print Called!");

#if DEBUG
            Console.WriteLine("DEBUG env connecting...");
#if DEV1
            Console.WriteLine("DEV1 env connected!");
#elif DEV2
            Console.WriteLine("DEV2 env connected!");
#endif

#elif RELEASE
            Console.WriteLine("RELEASE env connected!");
#else
            Console.WriteLine("ERROR");
#endif
        }
    }
}
