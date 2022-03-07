namespace collectionConcepts.src.DictionaryConcept
{
  public class DictionaryImp
  {
    public void execute()
    {
      Dictionary<string, string> personIdDict = new Dictionary<string, string>();

      personIdDict.Add("JohnDoe", "123");
      personIdDict.Add("MaryDoe", "456");

      this.Print(personIdDict);

      // * Access a value
      System.Console.WriteLine(personIdDict["JohnDoe"]);

      // * Modify an existing value
      personIdDict["JohnDoe"] = "333";

      System.Console.WriteLine(personIdDict["JohnDoe"]);

      // * Remove an existing value
      personIdDict.Remove("JohnDoe");

      // * TryGetValue
      string searchValue = "JohnDoe";

      if (personIdDict.TryGetValue(searchValue, out string? foundValue))
      {
        System.Console.WriteLine(foundValue);
      }
      else
      {
        System.Console.WriteLine("Valor não encontrado!");
      }

    }

    public void Print(Dictionary<string, string> dictionary)
    {
      foreach (KeyValuePair<string, string> dict in dictionary)
      {
        System.Console.WriteLine($"Key: {dict.Key} - Value: {dict.Value}");
      }
    }
  }
}