
namespace initialConcepts.src.initial.constructor_example
{
  public class Student : PersonConstructor
  {

    private double grade;

    public Student(string name, string lastName, double grade) : base(name, lastName)
    {
      this.grade = grade;
    }

    public override void Introduction()
    {
      System.Console.WriteLine($"Hello, my name is {base.name} {base.lastName} and my grade is {this.grade}");
    }
  }
}