using System;

namespace giants
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Program p = new Program();
            p.eat("Bananas");
        }

        public void eat(String food){
            Console.WriteLine($"Im eating {food}");
        }
    }
}
