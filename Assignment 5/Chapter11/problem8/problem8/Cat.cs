using System;
using System.Collections.Generic;
using System.Text;

namespace problem8
{
    class Cat
    {
        private string name;
        private string color;

        public Cat(string name, string color)
        {
            this.name = name;
            this.color = color;
        }

        public void SayMiau()
        {
            Console.WriteLine($"{name}: Miauu");
        }
    }
}
