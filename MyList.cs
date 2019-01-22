
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class MyList{

    internal void doListStuff()
    {
        
        List<Player> playerList = new List<Player>();
        playerList.Add(new Player(){name="Tom", position="Catcher"});
        playerList.Add(new Player(){name="aaa", position="Catcher"});
        playerList.Add(new Player(){name="zzz", position="Pitcher"});
        playerList.Add(new Player(){name="mike", position="Pitcher"});
        IOrderedEnumerable<Player> reverseSort = sortByLamdasReverse(playerList);
        Console.WriteLine("sort descending----");
        
        foreach (var pl in reverseSort)
        {
          pl.printPlayer();  
        }
        sortByLamdas(playerList);
        Console.WriteLine("sort normal----");
        playerList.ForEach(p=>p.printPlayer());

        //where linq
        List<Player> onlyMikes = selectOnlyMike(playerList);
        Console.WriteLine($"number of mieks = {onlyMikes.Count}");
        onlyMikes[0].printPlayer();

    }


public List<Player> selectOnlyMike(List<Player> playerList){
  return playerList.Where(p=>p.name == "mike").ToList();
}
public static void sortByLamdas(List<Player> list ){
     list.Sort((a, b) => (a.name.CompareTo(b.name)));

        }

        public static IOrderedEnumerable<Player> sortByLamdasReverse(List<Player> list ){
       return  list.OrderByDescending(l => l.name);

        }

}