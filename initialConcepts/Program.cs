using NamespaceConcepts;
using Human;
using Person;
using Enum;
using initialConcepts.src.initial.constructor_example;
using initialConcepts.src.initial.getSetExample;
using initialConcepts.src.initial.delegateExample;
using initialConcepts.src.initial.eventExample;
namespace Src
{
  class Program
  {
    // * Delegate example
    public delegate void Operation(double x, double y);

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

      // * Constant concept
      const double PI = 3.14;
      System.Console.WriteLine(PI);

      // * Delegate concept
      Operation op = new Operation(Calculator.Sum);
      // Operation op = Calculator.Sum; * 2 form

      op.Invoke(10, 10);
      // op(10, 10) * 2 form

      // * Multicast delegate concept
      Operation op2 = new Operation(Calculator.Sum);
      op2 += Calculator.Subtraction;
      op2.Invoke(10, 10);

      // * Event concept
      MathEvent math = new MathEvent(10.0, 10.0);
      math.Sum();

    }
  }
}