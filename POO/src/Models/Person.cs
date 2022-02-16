using System;

namespace POO.src.Models
{
  public class Person
  {
    public string Name { get; set; } = "";
    public int Age { get; set; }

    public virtual void Introduction()
    {
      Console.WriteLine($"Hello, my name is {Name} and i'm {Age} old");
    }

    public string GetName()
    {
      return this.Name;
    }

    public void SetName(string name)
    {
      this.Name = name;
    }

    public int GetAge()
    {
      return this.Age;
    }

    public void SetAge(int age)
    {
      this.Age = age;
    }
  }

}