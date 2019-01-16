using System;
public class Player{
    public enum Level {MINORS, MAJORS}

    public string name { get; set; }
    public string position { get; set; }
    
    public Level level { get; set; }

    public void printPlayer(){
        Console.WriteLine($"Player name ={this.name}");
        Console.WriteLine($"Player level ={this.level}");
    }
}