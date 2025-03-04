using System;

class Program {
    static void Main() {
     
        Console.WriteLine("Dados da primeira pessoa:");
        Console.Write("Nome: ");

        string nome1 = Console.ReadLine();
        Console.Write("Idade: ");
        int idade1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Dados da segunda pessoa:");
        Console.Write("Nome: ");

        string nome2 = Console.ReadLine();
        Console.Write("Idade: ");
        int idade2 = int.Parse(Console.ReadLine());

        if (idade1 > idade2) {
            Console.WriteLine($"Pessoa mais velha: {nome1}");
        }
        else if (idade2 > idade1) {
            Console.WriteLine($"Pessoa mais velha: {nome2}");
        }
        else {
            Console.WriteLine("As duas pessoas têm a mesma idade.");
        }
    }
}
