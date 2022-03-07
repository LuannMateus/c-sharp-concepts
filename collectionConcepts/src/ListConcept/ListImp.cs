namespace collectionConcepts.src.ListConcept
{
  public class ListImp
  {
    public void execute()
    {
      List<string> states = new List<string>();

      states.Add("CE");
      states.Add("SP");
      states.Add("BA");

      System.Console.WriteLine($"Quantidade de elementos na lista: {states.Count}");

      foreach (var item in states)
      {
        System.Console.WriteLine(item);
      }

      for (int i = 0; i < states.Count; i++)
      {
        System.Console.WriteLine(states[i]);
      }
    }

    public void Print(List<string> list)
    {
      foreach (string item in list)
      {
        System.Console.WriteLine(item);
      }
    }
  }
}