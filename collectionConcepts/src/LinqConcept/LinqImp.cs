namespace collectionConcepts.src.LinqConcept
{
  public class LinqImp
  {
    public void execute()
    {
      int[] randomNumbers = new int[] { 1, 4, 33, 21, 100, 102, 100 };

      var pairNumbersQuery =
        from num in randomNumbers
        where num % 2 == 0
        orderby num
        select num;

      var pairNumbersMethod = randomNumbers.Where(x => x % 2 == 0).OrderBy(x => x).ToList();

      System.Console.WriteLine("Números pares query: " + string.Join(", ", pairNumbersQuery));
      System.Console.WriteLine("Números pares method: " + string.Join(", ", pairNumbersMethod));

      var min = randomNumbers.Min();
      var max = randomNumbers.Max();
      var avg = randomNumbers.Average();
      var sum = randomNumbers.Sum();
      var distintic = randomNumbers.Distinct().ToArray();

      System.Console.WriteLine($"Valor mínimo: {min}");
      System.Console.WriteLine($"Valor máximo: {max}");
      System.Console.WriteLine($"Valor médio: {avg}");
      System.Console.WriteLine($"Soma total do array: {sum}");
      System.Console.WriteLine($"Array distinto: {string.Join(", ", distintic)}");
    }
  }
}