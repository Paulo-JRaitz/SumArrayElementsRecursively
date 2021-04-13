
namespace Recursividade
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] arrayUm = { 8, 1, 2, 3, 3 };
      SomaRecArray SomarIsso = new SomaRecArray();
      int indexMain = arrayUm.Length;
      System.Console.WriteLine(SomarIsso.soma(arrayUm, indexMain - 1));

      int year = 2021;
      double somaYear = year / 4.0;
      System.Console.WriteLine($"Ano = {year} /4 = {somaYear}");
      year = 2018;
      System.Console.WriteLine($"Ano = {year} /4 = {somaYear}");

    }
  }
}