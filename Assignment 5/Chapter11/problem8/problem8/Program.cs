using System;

namespace problem8
{
    class Program
    {
        static void Main(string[] args)
        {
            String name = "Cat";
            for (int i = 0; i < 10; i++)
            {
                Cat cat = new Cat(name + Sequence.NextValue(), "Black");
                cat.SayMiau();
            }
        }
    }
}
