namespace collectionConcepts.src.StackConcept
{
  public class StackImp
  {
    public void execute()
    {
      Stack<string> bookStack = new Stack<string>();

      bookStack.Push("Clean Code");
      bookStack.Push("Design Patterns");

      System.Console.WriteLine($"Quantidade de livros na pilha: {bookStack.Count}");

      this.EmptyStack(bookStack);
    }

    public void EmptyStack(Stack<string> stack)
    {
      while (stack.Count > 0)
      {
        System.Console.WriteLine($"A vez de: {stack.Peek()}");
        System.Console.WriteLine($"Já foi tirado da pilha: {stack.Pop()}");
      }

      System.Console.WriteLine($"Pessoas na fila: {stack.Count}");
    }
  }
}