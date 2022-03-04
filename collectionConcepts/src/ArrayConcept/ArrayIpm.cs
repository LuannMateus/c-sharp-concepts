namespace collectionConcepts.src.ArrayConcept
{
  public class ArrayIpm
  {
    public void CopyArray(ref int[] sourceArray, ref int[] destinyArray)
    {
      /* 
        * Args: 
          * 1 - Array para ser copiado .
          * 2 - Array que recebera os valores.    
          * 3 - Quantos elementos serão copiados.
      */
      Array.Copy(sourceArray, destinyArray, sourceArray.Length);
    }

    public bool ExistsValue(int[] array, int valueToFind)
    {
      return Array.Exists(array, value => value == valueToFind);
    }

    public bool AllGreaterThan(int[] array, int valueToCompare)
    {
      return Array.TrueForAll(array, value => valueToCompare > value);
    }

    public int FindValue(int[] array, int valueToFind)
    {
      return Array.Find(array, value => value == valueToFind);
    }


    public int GetIndex(int[] array, int valueToFind)
    {
      return Array.IndexOf(array, valueToFind);
    }

    public void ResizeArray(ref int[] array, int newSize)
    {
      Array.Resize(ref array, newSize);
    }

    public string[] ConvertToString(int[] array)
    {
      return Array.ConvertAll(array, value => value.ToString());
    }
    public void Print(int[] array)
    {
      String arrayOneLine = string.Join(", ", array);
      System.Console.Write($"{arrayOneLine}");
    }
  }
}