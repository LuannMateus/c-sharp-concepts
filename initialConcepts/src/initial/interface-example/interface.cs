namespace Person
{
  interface IPerson
  {
    public string getNameWithExclamation(string name);
  }

  class PersonProgram : IPerson
  {
    private string name { get; set; } = "";

    public string getNameWithExclamation(string name)
    {
      return name + "!!!";
    }

    public string getName()
    {
      return this.name;
    }

    public void setName(string name)
    {
      this.name = name;
    }
  }
}