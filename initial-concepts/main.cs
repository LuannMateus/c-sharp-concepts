using NamespaceConcepts;
using Human;
using Person;
using Enum;

namespace Src
{
  class Program
  {
    static void Main(string[] args)
    {
      // Namespace concept
      var instance = new NamespaceConceptsProgram();
      instance.showConsole();

      // Class concept
      HumanProgram human = new HumanProgram();
      human.Name = "Jonh Doe";
      Console.WriteLine(human.ShowNameWithExclamation());

      // Interface concept
      PersonProgram person = new PersonProgram();
      person.setName("John Doe");
      Console.WriteLine(person.getName());

      // Enum concept
      Seasons verao = (Seasons)0;
      Seasons outono = Seasons.outono;
      Console.WriteLine(verao + " " + outono);
    }
  }
}