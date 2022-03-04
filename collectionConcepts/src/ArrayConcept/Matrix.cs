namespace collectionConcepts.src.ArrayConcept
{
  public class Matrix
  {
    public void execute()
    {
      System.Console.WriteLine("\n\n=== Array Multidimensional (Matriz) ===\n\n");

      int[,] matrix = new int[4, 2] {
        { 1, 2},
        { 3, 4},
        { 5, 6},
        { 7, 8}
      };

      for (int l = 0; l < matrix.GetLength(0); l++)
      {
        for (int c = 0; c < matrix.GetLength(1); c++)
        {
          System.Console.Write(matrix[l, c]);
        }
        System.Console.WriteLine();
      }
    }
  }
}