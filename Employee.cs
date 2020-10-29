using System;

class Fields
{
  private string firstname;
  private string lastname;
  private string id;
  private int age;
  private string address;
  private string phonenumber;
  private string title;
  private double yearlysalary;
  private string employmentstatus;
  
  
  
  public Fields()
  {
    firstname = "unknown";
    lastname = "unknown";
    id = "unknown";
    age = 0;
    employmentstatus = "active";

  }

  public Fields(string fname, string lname, string idnum, int empage)
  {
    firstname = fname;
    lastname = lname;
    id = idnum;
    age = empage;
    employmentstatus = "active";

  }
  public void Intro()
  {
    Console.WriteLine("My name is " + firstname + " " + lastname);
    Console.WriteLine("My employee ID is " + id);
    Console.WriteLine("My age is " + age);
  }

}