// 

using System;
using System.Collections.Generic;

class Unit {
  public int HP = 0;
  public int ATK = 0;
  public int SPD = 1;
  public string name = "";
  public Unit(int HP, int ATK, int SPD, string name){
    this.HP = HP;
    this.ATK = ATK;
    this.SPD = SPD;
    this.name = name;
  }
}



class MainClass {
    static void fight(Unit first, Unit second) {
      while(first.HP > 0 & second.HP > 0){
        Console.WriteLine("Combatants' Health Totals:\n");
        Console.WriteLine(first.name + " HP: " + first.HP + second.name + " HP: " + second.HP + "\n");
        Console.WriteLine("The combatants engage!\n");
        Console.WriteLine(first.name + " strikes for: " + first.ATK + " damage.\n");
        second.HP -= first.ATK;
        Console.WriteLine(second.name + " strikes for: " + second.ATK + " damage.\n");
        first.HP -= second.ATK;
      }
      Console.WriteLine("Combatants' Health Totals:\n");
      Console.WriteLine(first.name + " HP: " + first.HP + second.name + " HP: " + second.HP + "\n");
      if(first.HP > 0){
        Console.WriteLine(first.name + " is victorious!\n");
      }
      else if(second.HP > 0){
        Console.WriteLine(second.name +" is victorious!\n");
      }
      else{
        Console.WriteLine("Both combatants have obliterated eachother!\n");
      }
    }

    //initialize the four class prototypes: Tank,fighter,mage,archer
    //no input, output is a dictionary of Units
    static Dictionary <string,Unit> InitClasses (){
      var classes = new Dictionary<string,Unit>();
      classes.Add("tank",new Unit(10,1,1,"tank"));
      classes.Add("fighter",new Unit(7,2,1,"fighter"));
      classes.Add("mage",new Unit(3,3,1,"mage"));
      classes.Add("archer",new Unit(6,2,1,"archer"));
      return classes;
    }

    //make battlefield. two top, two bottom. Array?
    // static  initBattlefield (){
    //   int[,] array = new int[2, 2];

    // }

  public static void Main (string[] args) {
    Console.WriteLine ("Testing Ground");
      //Unit first = new Unit(10,1,1);
      //Unit second = new Unit(13,1,1);
      var classes = InitClasses();
      Unit first = classes["tank"];
      Unit second = classes["fighter"];

      fight(first,second);

      return;
  }


}