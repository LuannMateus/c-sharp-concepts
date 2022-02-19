using NamespaceConcepts;
using Human;
using Person;
using Enum;
using initialConcepts.src.initial.constructor_example;
using initialConcepts.src.initial.getSetExample;
namespace Src
{
  class Program
  {
    static void Main(string[] args)
    {
      // * Namespace concept
      var instance = new NamespaceConceptsProgram();
      instance.showConsole();

      // * Class concept
      HumanProgram human = new HumanProgram();
      human.Name = "Jonh Doe";
      Console.WriteLine(human.ShowNameWithExclamation());

      // * Interface concept
      PersonProgram person = new PersonProgram();
      person.setName("John Doe");
      Console.WriteLine(person.getName());

      // * Enum concept
      Seasons verao = (Seasons)0;
      Seasons outono = Seasons.outono;
      Console.WriteLine(verao + " " + outono);

      // * Constructor concept
      PersonConstructor personConstructor = new PersonConstructor("John", "Doe");
      personConstructor.Introduction();

      // * Private constructor concept
      Log log = Log.GetInstance();

      // * Inheritance with constructor
      Student student = new Student("Mary", "Doe", 10.0);
      student.Introduction();

      // * Get and set concept  
      Date date = new Date();
      date.Month = 12;
      date.ShowMonth();
    }
  }
}