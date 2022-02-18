namespace POO.src.Interfaces
{
  public interface ICalculator
  {
    // * Default implementation
    double Divide(double x, double y)
    {
      return x / y;
    }

    double Multiplication(double x, double y);
    double Subtraction(double x, double y);
    double Sum(double x, double y);
  }
}