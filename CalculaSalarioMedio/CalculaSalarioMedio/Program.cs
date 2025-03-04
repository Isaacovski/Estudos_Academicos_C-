using System;
  
class Program {
    static void Main() {

        Console.WriteLine("Dados do primeiro funcionário:");
        Console.Write("Nome: ");
        string nome1 = Console.ReadLine();
        Console.Write("Salário: ");
        double salario1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Dados do segundo funcionário:");
        Console.Write("Nome: ");
        string nome2 = Console.ReadLine();
        Console.Write("Salário: ");
        double salario2 = double.Parse(Console.ReadLine());

        double salarioMedio = (salario1 + salario2) / 2;

         Console.WriteLine($"Salário médio = {salarioMedio:F2}");
    }
}
