﻿using System.Collections.Generic;
using static System.Console;
public class Program
{

  static void Demo6()
  {
    int[] numeros = new int[] { 0, 2, 4, 6, 8 };
    WriteLine($"Digite o número que gostaria de encontrar");
    var numero = int.Parse(ReadLine());
    var idxEncontrado = EncontrarNumero(numeros, numero);


    if (idxEncontrado >= 0)
    {
      WriteLine($"O numero digitado esta na posição {idxEncontrado}");
    }

    else
    {
      WriteLine("O numero digitado não foi encotrado");
    }
  }
  static void Demo5()
  {
    int[] pares = new int[] { 0, 2, 4, 6, 8 };
    MudarParaImpar(pares);
    WriteLine($"Os impares {string.Join(",", pares)}");
  }
  static void Demo4()
  {
    string nome = "Doni";
    TrocarNome(nome, "Pedro");
    WriteLine($"O novo nome é {nome}");
  }
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

  static async void MudarParaImpar(int[] pares)
  {
    for (int i = 0; i < pares.Length; i++)
    {
      pares[i] = pares[i] + 1;
    }
  }

  static int EncontrarNumero(int[] numeros, int numero)
  {
    for (int i = 0; i < numeros.Length; i++)
    {
      if (numeros[i] == numero)
        return i;
    }
    return -1;
  }

  public static void Main()
  {

    /*     List<Pessoa> pessoas = new List<Pessoa>()
    {
      new Pessoa(){Nome ="Pedro"},
        new Pessoa() { Nome = "Jão" },
        new Pessoa() { Nome = "Luiz" },
        new Pessoa() { Nome = "Flavio" },
      }; */


    int idade;
    WriteLine("Digite sua idade: ");
    idade = int.Parse(ReadLine());
    if (idade >= 18)
    {
      WriteLine("Você é maior de idade");
      
    }else{
      WriteLine("Você e menor de idade");
    }
}

}