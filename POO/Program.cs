using POO.src.Models;

/* 
  ? Conceitos da POO
  
    * Abstração: Abstrair objetos da realidade para a programação.

    * Encapsulamento: Visibilidade dos atributos e métodos da classe.

    * Herança: Capacidade de herdar métodos e atributos de outras classes.
  
    * Polimorfismo: Capacidade de modificar os métodos heradados.
*/

namespace POO
{
  class Program
  {
    static void Main(string[] args)
    {
      // * Abstração
      Console.WriteLine("\n--- Abstração ---\n");

      Person p1 = new Person();
      p1.SetName("John Doe");
      p1.SetAge(31);
      p1.Introduction();

      // * Encapsulamento
      Console.WriteLine("\n--- Encapsulamento ---\n");

      Retangle r = new Retangle();
      r.DefineMeasure(1, 1);
      Console.WriteLine(r.CalcArea());
      r.DefineMeasure(1, 0);
      Console.WriteLine(r.CalcArea());

      // * Herança e Polimorfismo
      Console.WriteLine("\n--- Herança ---\n");

      Professor professor = new Professor();
      professor.SetName("Mary Doe");
      professor.SetAge(32);
      professor.SetSalary(3000);

      Student student = new Student();
      student.SetName("John Doe");
      student.SetAge(18);
      student.SetGrade(10);

      student.Introduction();
      professor.Introduction();

      Calculator calculator = new Calculator();
      System.Console.WriteLine(calculator.Sum(1, 1));
      System.Console.WriteLine(calculator.Sum(1, 1, 1));

      // * 
    }
  }
}