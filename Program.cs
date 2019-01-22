using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace giants
{
    class Program
    {
        List<Player> listOfPlayers = new List<Player>();
        public string fileName { get; set; }

        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello World!");
            Program p = new Program();
           
            p.fileName = args[0];
            p.readFile(p.fileName);
            MyList ml = new MyList();
            ml.doListStuff();
            MyModulus ms = new MyModulus();
            ms.processMod();
            MyArrays ma = new MyArrays();
            ma.process();
            MyHashStuff hs = new MyHashStuff();
            hs.process();

        }

        public void readFile(string fileName){
            Console.WriteLine($"reading file: {fileName}");
            string[] fileLines = File.ReadAllLines (fileName);
            processPlayers(fileLines);
            printProcessedPlayers();
            using (StreamWriter sw = File.CreateText("output.txt")) 
              {
                    listOfPlayers.ForEach(p=>sw.WriteLine(p.name) );
              }

        }

        private void printProcessedPlayers()
        {
            listOfPlayers.Sort((x, y) => x.name.CompareTo(y.name));
            IEnumerable<Player> playersSorted = listOfPlayers.OrderByDescending(p=>p.name);
            foreach(Player p in listOfPlayers){
           //   listOfPlayers.order
               Console.WriteLine("SORT: -------------------");
               Console.WriteLine(p.name);
               Console.WriteLine(p.position);
               Console.WriteLine(p.level);
           }

             foreach(Player p in playersSorted){
           //   listOfPlayers.order
               Console.WriteLine("LINQ: -------------------");
               Console.WriteLine(p.name);
               Console.WriteLine(p.position);
               Console.WriteLine(p.level);
           }
        }

        public void processPlayers(string[] lines){
            foreach(string line in lines) {
                string[] tokens = line.Split(',');
                Player p = new Player();
                p.name = tokens[0];
                p.position = tokens[1];
                p.level = tokens[2] == "\"MAJORS\""? Player.Level.MAJORS: Player.Level.MINORS;
                listOfPlayers.Add(new Player(){name = tokens[0],
                position = tokens[1],
                level  = tokens[2] == "MAJORS"? Player.Level.MAJORS: Player.Level.MINORS
                  });
            }

        }
    }
}
