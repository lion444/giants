using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class MyHashStuff{

public void process(){

doHashTable();
doDictionary();
soSet();

}

    private void doDictionary()
    {
        Dictionary<int, Player> d1 = new Dictionary<int, Player>();
        d1.Add(1, new Player(){name="Mike"});
        d1.Add(2, new Player(){name="Joe"});
        Console.WriteLine($"d1 2nd is{d1[1]}");
        Console.WriteLine($"d1 2nd is{d1.Count}");
    }

 //need to do tolist or array for this
    private void soSet()
    {
        HashSet<Player> set1 = new HashSet<Player>();
        set1.Add(new Player(){name="Mike"});
        set1.Add(new Player(){name="Joe"});
        Console.WriteLine($"hashset 2nd is {set1.ToArray()[0]}");
        Console.WriteLine($"hashset count {set1.Count}");
    }

    private void doHashTable(){
        Hashtable d1 = new Hashtable();
        d1.Add(1, new Player(){name="Mike"});
        d1.Add(2, new Player(){name="Joe"});
        Console.WriteLine($"d1 2nd is{d1[1]}");

}

}