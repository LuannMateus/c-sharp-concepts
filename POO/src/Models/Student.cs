namespace POO.src.Models
{
  public class Student : Person
  {

    private double grade;

    public override void Introduction()
    {
      Console.WriteLine($"Hello, my name is {Name} and i'm {Age} old. My grade is {grade}.");
    }

    public double GetGrade()
    {
      return this.grade;
    }

    public void SetGrade(double grade)
    {
      this.grade = grade;
    }
  }
}