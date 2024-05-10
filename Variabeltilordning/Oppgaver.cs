using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variabeltilordning
{
    internal class Oppgaver
    {
        // Oppgave 1: Lag en metode som tar inn og returnerer summen av to tall

        int number1 = 2;
        int number2 = 3;

        public int AddTwoNumbers(int number1, int number2)
        {
            return number1 + number2;
        }


        // Oppgave 2: Lag en metode skal printe setningen "Denne metoden returnerer ingenting" til konsollen.
        // Denne metoden skal altså ikke returnere noe verdi ;)  

        public void ReturnNothing()
        {
            Console.WriteLine("Denne metoden returnerer ingenting");
        }

    }
}
