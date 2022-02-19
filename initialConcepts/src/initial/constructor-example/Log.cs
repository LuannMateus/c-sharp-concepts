namespace initialConcepts.src.initial.constructor_example
{
  public class Log
  {
    private static Log? _instance;

    private Log() { }

    public static Log GetInstance()
    {
      if (_instance == null)
      {
        _instance = new Log();
      }

      return _instance;
    }
  }
}