using System;
using System.Collections.Generic;

public class MyModulus{
    int[] nums = new int[]{0,23,3432,2,34,54,9,12,15};

    public void processMod(){
        List<Player> playerList = new List<Player>();
        playerList.Add(new Player(){name="Tom", position="Catcher"});
        playerList.Add(new Player(){name="aaa", position="Catcher"});
        playerList.Add(new Player(){name="zzz", position="Pitcher"});
        int[] theMods = isDivByThree(nums).ToArray();
        Array.ForEach(theMods, i=>Console.WriteLine(i));
    }
    public List<int> isDivByThree(int[] nums){
        List<int> divBy3List = new List<int>();
        foreach (int i in nums)
        {
            if (i%3 == 0){
                divBy3List.Add(i);
            }
        }
        return divBy3List;
    }

    public void switchStatement(){
        Player pl = new Player(){name="mike", level=Player.Level.MAJORS};

        switch (pl.level)
        {
            case Player.Level.MAJORS:
            break;
            case Player.Level.MINORS:
            break;

        
            default:
            break;
        }

    }

}