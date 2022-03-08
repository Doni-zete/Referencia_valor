using static System.Console;
public class Program
{

  static void Demo3()
  {
    StructPessoa P1 = new StructPessoa()
    {
      Documento = "1234",
      Idade = 30,
      Nome = "Donizete",
    };

    var p2 = P1;
    P1 = TrocarNome(P1, "Joao");
    WriteLine($@"
    nome do p1 {P1.Nome}
    Nome do p2 {p2.Nome}
    ");
  }
  static void Demo2()
  {
    Pessoa P1 = new Pessoa();
    P1.Nome = "Doni";
    P1.Idade = 25;
    P1.Documento = "1234";

    Pessoa p2 = P1.Clone();


    TrocarNome(P1, "Arnold");
    WriteLine($@"
    O nome p1 é : {P1.Nome}
    O nome  de p2 é:{p2.Nome}
    ");
  }
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

  static StructPessoa TrocarNome(StructPessoa p1, string nomeNovo)
  {
    p1.Nome = nomeNovo;
    return p1;
  }

  static void TrocarNome(string nome, string nomeNovo)
  {
    nome = nomeNovo;
  }
  public static void Main()
  {
    string nome = "Doni";
    TrocarNome(nome,"Pedro");
    WriteLine($"O novo nome é {nome}");
  }

}
