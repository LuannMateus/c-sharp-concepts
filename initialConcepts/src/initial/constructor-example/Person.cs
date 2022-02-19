namespace initialConcepts.src.initial.constructor_example
{
  public class PersonConstructor
  {
    protected string name;
    protected string lastName;

    // * Default constructor
    public PersonConstructor()
    {
      this.name = string.Empty;
      this.lastName = string.Empty;
    }

    public PersonConstructor(string name, string lastName)
    {
      this.name = name;
      this.lastName = lastName;
    }

    public virtual void Introduction()
    {
      System.Console.WriteLine($"Hello, my name is {this.name} {this.lastName}");
    }
  }
}