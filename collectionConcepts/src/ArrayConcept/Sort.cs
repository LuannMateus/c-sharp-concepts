using System;

namespace collectionConcepts.src.ArrayConcept
{
  public class Sort
  {
    public void BubbleSort(ref int[] intValues)
    {
      int aux = 0;

      for (int i = 0; i < intValues.Length; i++)
      {
        for (int j = 0; j < intValues.Length - 1; j++)
        {
          if (intValues[j] > intValues[j + 1])
          {
            aux = intValues[j];
            intValues[j] = intValues[j + 1];
            intValues[j + 1] = aux;
          }
        }
      }

    }

    public void ArraySort(ref int[] intValues)
    {
      Array.Sort(intValues);
    }

    public void Print(int[] intValues)
    {
      System.Console.Write("[");
      for (int i = 0; i < intValues.Length; i++)
      {
        System.Console.Write($"{intValues[i]} ");
      }
      System.Console.Write("]");
    }
  }
}