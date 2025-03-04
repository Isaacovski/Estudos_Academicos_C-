using System;

namespace MyApp {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Pressione Enter para girar o dado...");

            Console.ReadLine();

            Random random = new Random();

            int numeroAleatorio = random.Next(1, 8);

            Console.WriteLine("O Dado que voçe jogou deu : " + numeroAleatorio);

            string Classe;
            switch (numeroAleatorio) {
                case 1:
                    Classe = "Mage";
                    break;
                case 2:
                    Classe = "Clerigo";
                    break;
                case 3:
                    Classe = "Piromante";
                    break;
                case 4:
                    Classe = "Feiticeiro";
                    break;
                case 5:
                    Classe = "Mercenario";
                    break;
                case 6:
                    Classe = "Cavaleiro";
                    break;
                case 7:
                    Classe = "Despojado";
                    break;
                default:
                    Classe = "Valor inválido";
                    break;
            }

            Console.WriteLine("Sua Classe Sorteada Foi : " + Classe);
        }
    }
}
