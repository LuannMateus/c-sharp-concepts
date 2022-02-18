namespace Human
{
  class HumanProgram
  {
    public string Name { get; set; } = "";

    public string ShowNameWithExclamation()
    {
      return Name + "!";
    }
  }
}