namespace initialConcepts.src.initial.delegateExample
{
  public class Calculator
  {
    public delegate void DelegateCalculator();

    public static event DelegateCalculator? CalculatorEvent;

    public static void Sum(double x, double y)
    {
      if (CalculatorEvent != null)
      {

        System.Console.WriteLine(x + y);
        CalculatorEvent();
      }
      else
      {
        System.Console.WriteLine("No subscriber!");
      }

    }

    public static void Subtraction(double x, double y)
    {
      System.Console.WriteLine(x - y);
    }
  }
}