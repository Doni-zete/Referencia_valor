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

    Pessoa p2 = P1;


    TrocarNome(P1, "Arnold");
    WriteLine($@"
    O nome p1 é : {P1.Nome}
    O nome  de p2 é:{p2.Nome}
    ");
  }

}
