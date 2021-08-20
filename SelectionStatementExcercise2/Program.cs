using System;

namespace SelectionStatementExcercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite subject in school?");
            string userSub = Console.ReadLine();

            switch(userSub)
            {
                case "programming":
                    Console.WriteLine("Very nice subject.");
                    break;

                case "math":
                    Console.WriteLine("Sounds it could be interesting.");
                    break;

                case "english":
                    Console.WriteLine("Sounds mainstream.");
                    break;

                case "physics":
                    Console.WriteLine("Sounds difficult.");
                    break;

                case "economics":
                    Console.WriteLine("Man that is a boring subject.");
                    break;

                default:
                    Console.WriteLine("Pick a different subject.");
                    break;
            }
        }
    }
}
