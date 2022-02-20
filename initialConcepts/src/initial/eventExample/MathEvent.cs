using initialConcepts.src.initial.delegateExample;

namespace initialConcepts.src.initial.eventExample
{
  public class MathEvent
  {
    public double X { get; set; }
    public double Y { get; set; }

    public MathEvent(double x, double y)
    {
      this.X = x;
      this.Y = Y;

      Calculator.CalculatorEvent += this.EventHandler;
    }

    public void Sum()
    {
      Calculator.Sum(this.X, this.Y);
    }

    public void EventHandler()
    {
      System.Console.WriteLine("Evento executado!");
    }

  }
}