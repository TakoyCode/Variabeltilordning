using System.Security.Cryptography.X509Certificates;
namespace Variabeltilordning

{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //var game = new Variabeltilordning_Video_Forklaring();
            //game.Run();

            var tasks = new Oppgaver();
            
            Console.WriteLine(tasks.AddTwoNumbers(2, 4));

            tasks.ReturnNothing();
        }
    }
}
