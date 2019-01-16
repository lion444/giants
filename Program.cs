using System;

namespace giants
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello World!");
            Program p = new Program();
            p.eat("Bananas");
        }

        public void eat(String food){
            Console.WriteLine($"Im eating {food}");
            Player p1 = new Player(){name="Mike Lewon", position="Pitcher", level =Player.Level.MAJORS };
            p1.printPlayer();

        }
    }
}
