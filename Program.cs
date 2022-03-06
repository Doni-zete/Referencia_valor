using static System.Console;
public class Program
{
  static void Demo1()
  {

    int a = 2;
    a = Adicionar20(a);
    WriteLine($"O Valor da variável aé {a}");
  }

  static int Adicionar20(int x)
  {
    return x + 20;
  }

  static void TrocarNome(Pessoa p1, string nomeNovo)
  {
    p1.Nome = nomeNovo;
  }
  public static void Main()
  {
    Pessoa P1 = new Pessoa();
    P1.Nome = "Doni";
    P1.Idade = 25;
    P1.Documento = "1234";


    TrocarNome(P1, "Arnold");
    WriteLine($"O novo nome é : {P1.Nome}");
  }

}
