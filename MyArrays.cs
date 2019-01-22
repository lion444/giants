using System;
using System.Collections.Generic;

public class MyArrays {

public void process(){
int[,] nums = new int[,] {
    {1,2}, {2,4}
};
doArray(nums);

 List<Player> playerList = new List<Player>();
        playerList.Add(new Player(){name="Tom", position="Catcher"});
        playerList.Add(new Player(){name="aaa", position="Catcher"});
        playerList.Add(new Player(){name="zzz", position="Pitcher"});
        
        Player[] playersArray = playerList.ToArray();
        Array.ForEach(playersArray, i=>Console.WriteLine(i));
        
}

public void doArray(int[,] nums){
    for (int i = 0; i <= nums.GetUpperBound(0); i++)
    {
         Console.WriteLine($" first loop {i}");
        for (int b = 0; b <= nums.GetUpperBound(1); b++)
        {   
            Console.WriteLine($" second loop {b}");
            Console.WriteLine($"{nums[i,b]}");
            
        }
    }

 

}

}