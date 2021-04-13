namespace Recursividade
{
  public class SomaRecArray
  {
    public int soma(int[] array, int index)
    {
      if (index <= 0)
      {
        return array[index];
      }
      else
      {
        return array[index] + soma(array, index - 1);
      }
    }

  }
}
