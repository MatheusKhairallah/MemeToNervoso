using System;

namespace MemeToNervoso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Usuário, o que você pensa sobre mim?: ");
            string opiniao=Console.ReadLine();
            string opiniao2=opiniao.Remove(10);

            Console.Clear();

            string mensagemOpiniao2=" " +opiniao2+ "... nao pera, to nervoso";

            Console.WriteLine(mensagemOpiniao2);

          
           
        }
    }
}
