using System;

namespace Polimorfismo {
  class Program {
    static void Main(string[] args){
      Console.WriteLine("Hello, World!");
    }
  }

  interface IBonus {
    //TODO
  }

  public abstract class Empleado {
      public string Name {get; set;}
      public int SNN {get;}
      virtual CalculateSalario;
  }
}
