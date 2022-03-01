using static System.Console;

namespace Demo
{
  class Program
  {
    static int Adicionar20(int x)
    {

     return  x+ 20;
    }
    static void Main(string[] args)
    {
      int a = 2;
      a=Adicionar20(a);

      WriteLine($"O valor da variavel é {a}");
    }
  }
}
