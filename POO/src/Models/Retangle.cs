namespace POO.src.Models
{
  public class Retangle
  {
    private double length;
    private double width;
    private bool isValid;

    public void DefineMeasure(double length, double width)
    {
      if (length > 0 && width > 0)
      {
        this.length = length;
        this.width = width;
        isValid = true;
      }
      else
      {
        Console.WriteLine("Invalid values!");
        isValid = false;
      }
    }

    public double CalcArea()
    {
      if (isValid)
      {
        return length * width;
      }
      else
      {
        Console.WriteLine($"The values are not valid!");
        return 0;
      }
    }

  }
}