namespace collectionConcepts.src.ArrayConcept
{
  public class Vector
  {

    public void execute()
    {
      System.Console.WriteLine("\n\n=== Array Unidimensional (Vetor) ===\n\n");

      int[] numArray = new int[3];

      numArray[0] = 1;
      numArray[1] = 2;
      numArray[2] = 3;

      System.Console.WriteLine("Percorrendo o array com o FOR");

      for (int i = 0; i < numArray.Length; i++)
      {
        System.Console.WriteLine(numArray[i]);
      }

      System.Console.WriteLine("Percorrendo o array com o FOR EACH");
      foreach (int i in numArray)
      {
        System.Console.WriteLine(i);
      }
    }
  }
}