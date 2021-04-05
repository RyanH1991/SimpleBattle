// 

using System;

class Unit {
  public int HP = 0;
  public int ATK = 0;
  public int SPD = 1;
}

class MainClass {
    static void fight(Unit first, Unit second) {
      while(first.HP > 0 & second.HP > 0){
        Console.WriteLine("Fighters' Health Totals:\n");
        Console.WriteLine("first HP:" + first.HP + " second HP:" + second.HP + "\n");
        Console.WriteLine("The fighters engage!\n");
        Console.WriteLine("first strikes for: " + first.ATK + " damage.\n");
        second.HP -= first.ATK;
        Console.WriteLine("second strikes for: " + second.ATK + " damage.\n");
        first.HP -= second.ATK;
      }
      Console.WriteLine("Fighters' Health Totals:\n");
      Console.WriteLine("first HP:" + first.HP + " second HP:" + second.HP + "\n");
      if(first.HP > 0){
        Console.WriteLine("The first fighter is victorious!\n");
      }
      else if(second.HP > 0){
        Console.WriteLine("The second fighter is victorious!\n");
      }
      else{
        Console.WriteLine("Both fighters have obliterated eachother!\n");
      }
    }
  public static void Main (string[] args) {
    Console.WriteLine ("Testing Ground");
      Unit first = new Unit();
      first.HP = 10;
      first.ATK = 3;
      Unit second = new Unit();
      second.HP = 13;
      second.ATK = 2;

      fight(first,second);

      return;
  }


}