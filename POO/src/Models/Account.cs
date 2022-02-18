namespace POO.src.Models
{
  public abstract class Account
  {
    protected double balance;

    public abstract void Credit(double value);

    public void ShowBalance()
    {
      System.Console.WriteLine($"Seu saldo é: {this.balance} R$");
    }
  }

}