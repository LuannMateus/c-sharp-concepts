namespace POO.src.Models
{
  public class Professor : Person
  {
    protected double salary;

    public sealed override void Introduction()
    {
      Console.WriteLine($"Hello, my name is {Name} and i'm {Age} old with {salary} salary.");
    }

    public double GetSalary()
    {
      return this.salary;
    }

    public void SetSalary(double salary)
    {
      this.salary = salary;
    }
  }
}