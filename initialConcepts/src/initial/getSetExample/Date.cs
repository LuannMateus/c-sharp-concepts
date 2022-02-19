namespace initialConcepts.src.initial.getSetExample
{
  public class Date
  {
    private int month;

    // * Public property
    public int Month
    {
      get
      {
        return this.month;
      }
      set
      {
        if (value > 0 && value < 13)
        {
          this.month = value;
          isValidMonth = true;
        }
      }
    }
    private bool isValidMonth;


    public int GetMonth()
    {
      return this.month;

    }

    public void SetMonth(int month)
    {
      if (month > 0 && month < 13)
      {
        this.month = month;
        isValidMonth = true;
      }
      else
      {
        isValidMonth = false;
      }
    }

    public void ShowMonth()
    {
      if (isValidMonth)
      {
        System.Console.WriteLine($"The month is {this.month}");
      }
      else
      {
        System.Console.WriteLine("The month is not valid!");
      }
    }
  }
}