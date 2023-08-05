using System;

namespace EndWar {
    public class Program {
        public static string inverter(string entrada)
        {
            Char[] conversao = entrada.ToCharArray();
            Array.Reverse(conversao);
            return new string(conversao);
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o numero para vermos se ele bate com o" +
            " EndWar");
            String entradaDoUsuario = Console.ReadLine();

            String[] partes = entradaDoUsuario.Split(new char[] { '+', '=' });
            String parteA = inverter(partes[0]);
            string parteB = inverter(partes[1]);
            String parteC = inverter(partes[2]);

            string resultado = int.Parse(parteA) + int.Parse(parteB) == int.Parse(parteC) ? "True" : "false";
            Console.WriteLine(resultado);
            Console.ReadKey();
        }
    }
}
