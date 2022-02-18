using POO.src.Interfaces;
namespace POO.src.Models
{
  public class Calculator : ICalculator
  {
    public double Multiplication(double x, double y)
    {
      return x * y;
    }

    public double Subtraction(double x, double y)
    {
      return x - y;
    }

    public double Sum(double x, double y)
    {
      return x + y;
    }

    public double Sum(double x, double y, double z)
    {
      return x + y + z;
    }

  }
}