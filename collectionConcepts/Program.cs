using collectionConcepts.src.ArrayConcept;
using collectionConcepts.src.ListConcept;
using collectionConcepts.src.QueueConcept;
using collectionConcepts.src.StackConcept;
using collectionConcepts.src.DictionaryConcept;
using collectionConcepts.src.LinqConcept;

namespace collectionConcepts
{
  public class Program
  {
    public static void Main(string[] args)
    {
      // * Vector
      Vector vec = new Vector();
      vec.execute();

      // * Matrix
      Matrix matrix = new Matrix();
      matrix.execute();


      // * Bubble sort
      Console.WriteLine("\n\n -- Bubble sort --\n\n");

      int[] nums = new int[4] { 3, 10, 2, 100 };

      Sort sort = new Sort();

      Console.WriteLine("\n=== Array não ordenado ===\n");
      sort.Print(nums);

      Console.WriteLine("\n=== Array ordenado ===\n");
      sort.BubbleSort(ref nums);
      sort.Print(nums);

      // * Array sort
      Console.WriteLine("\n\n -- Array sort --\n\n");
      int[] nums2 = new int[4] { 4, 10, 300, 1 };

      Console.WriteLine("\n\n=== Array não ordenado ===\n\n");
      sort.Print(nums2);


      Console.WriteLine("\n\n=== Array ordenado ===\n\n");
      sort.ArraySort(ref nums2);
      sort.Print(nums2);


      // * Array copy
      Console.WriteLine("\n\n -- Array Copy --\n\n");

      int[] sourceArray = new int[5] { 1, 2, 3, 4, 5 };
      int[] destinyArray = new int[5];

      ArrayIpm arrayIpm = new ArrayIpm();
      arrayIpm.CopyArray(ref sourceArray, ref destinyArray);

      Console.WriteLine("\n\n -- Array Original --\n\n");
      arrayIpm.Print(sourceArray);

      Console.WriteLine("\n\n -- Array Copiado --\n\n");
      arrayIpm.Print(destinyArray);

      // * Array Exists
      Console.WriteLine("\n\n -- Array Exists --\n\n");

      bool exists = arrayIpm.ExistsValue(sourceArray, 1);
      System.Console.WriteLine($"The value 1 exists: {exists}");

      // * Array TrueForAll
      Console.WriteLine("\n\n -- Array TrueForAll --\n\n");

      bool isBiggest = arrayIpm.AllGreaterThan(sourceArray, 100);
      System.Console.WriteLine($"The value 100 is the bigget: {isBiggest}");

      // * Array Find
      Console.WriteLine("\n\n -- Array Find --\n\n");

      int isValueExists = arrayIpm.FindValue(sourceArray, 100);
      System.Console.WriteLine($"The value 100 exists: {(isValueExists > 0 ? true : false)}");


      // * Array IndexOf
      Console.WriteLine("\n\n -- Array IndexOf --\n\n");

      int isIndexOf = arrayIpm.GetIndex(sourceArray, 100);
      System.Console.WriteLine($"The index of value 100: {isIndexOf}");

      // * Array Resize
      Console.WriteLine("\n\n -- Array Resize --\n\n");

      System.Console.WriteLine($"The original array size: {sourceArray.Length}");
      arrayIpm.ResizeArray(ref sourceArray, sourceArray.Length * 2);
      System.Console.WriteLine($"The resize value: {sourceArray.Length}");

      // * Array ConvertAll
      Console.WriteLine("\n\n -- Array ConvertAll --\n\n");

      System.Console.WriteLine($"The original array: {sourceArray}");
      string[] convertedArray = arrayIpm.ConvertToString(sourceArray);
      System.Console.WriteLine($"The converted array: {convertedArray}");

      // * List
      Console.WriteLine("\n\n -- List --\n\n");

      ListImp list = new ListImp();
      list.execute();

      // * List Remove
      Console.WriteLine("\n\n -- List Remove --\n\n");

      List<string> states = new List<string>();

      states.Add("CE");
      states.Add("SP");
      states.Add("BA");

      states.Remove("CE");

      list.Print(states);

      // * List AddRange
      Console.WriteLine("\n\n -- List AddRange --\n\n");

      string[] statesArray = new string[] { "SC", "PB" };

      states.AddRange(statesArray);

      list.Print(states);

      // * List Insert
      Console.WriteLine("\n\n -- List Insert --\n\n");

      states.Insert(0, "PR");

      list.Print(states);

      // * Queue
      Console.WriteLine("\n\n -- Queue --\n\n");

      QueueImp queueImp = new QueueImp();

      queueImp.execute();

      // * Stack
      Console.WriteLine("\n\n -- Stack --\n\n");

      StackImp stackImp = new StackImp();

      stackImp.execute();

      // * Dictionary
      Console.WriteLine("\n\n -- Dictionary --\n\n");

      DictionaryImp dictionaryImp = new DictionaryImp();

      dictionaryImp.execute();

      // * Linq
      LinqImp linqImp = new LinqImp();

      linqImp.execute();


    }
  }
}