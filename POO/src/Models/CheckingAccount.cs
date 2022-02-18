namespace POO.src.Models
{
  public class CheckingAccount : Account
  {
    public override void Credit(double value)
    {
      if (value <= 0)
      {
        System.Console.WriteLine("Valor inválido!");

        return;
      }

      base.balance = value;
    }
  }
}