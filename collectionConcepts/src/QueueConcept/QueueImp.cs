namespace collectionConcepts.src.QueueConcept
{
  public class QueueImp
  {
    public void execute()
    {
      Queue<string> personQueue = new Queue<string>();

      personQueue.Enqueue("John Doe");
      personQueue.Enqueue("Mary Doe");

      System.Console.WriteLine($"Pessoas na fila: {personQueue.Count}");

      this.EmptyQueue(personQueue);
    }

    public void EmptyQueue(Queue<string> queue)
    {
      while (queue.Count > 0)
      {
        System.Console.WriteLine($"A vez de: {queue.Peek()}");
        System.Console.WriteLine($"Já foi atendido: {queue.Dequeue()}");
      }

      System.Console.WriteLine($"Pessoas na fila: {queue.Count}");
    }
  }
}