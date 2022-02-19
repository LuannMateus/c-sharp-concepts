/*
  * readonly: Esse modificador permite apenas a leitura do atributo, 
  * podendo apenas modificá-lo na sua declaração e/ou no construtor.

  * 
*/

namespace initialConcepts.src.initial.modifiersExample
{
  public class PersonModifier
  {
    protected readonly string name;
    protected readonly string lastName;

    public PersonModifier()
    {
      this.name = string.Empty;
      this.lastName = string.Empty;
    }

    public PersonModifier(string name, string lastName)
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

