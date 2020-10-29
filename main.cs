using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("New Employee Created");
    
    Fields unknown = new Fields();
    unknown.Intro();

    Fields create = new Fields("Josh","Smith","1234",45);
    create.Intro();
  }
}