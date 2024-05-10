using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variabeltilordning
{
    internal class Variabeltilordning_Tekst_Forklaring
    {
        // Når vi skal skrive funksjoner er vi også nødt til å definere hva slags verdier metoden skal ta inn,
        // og hva slags verdier metoden skal returnere. Det gjøres i metodesignaturen som sett under.

        // Void bruker vi når den ikke skal returnere noe, eller bare kjøre igjennom.
        // Eksempel:
        static void DenneFunksjonenReturnererIngenting()
        {
            return;
        }

        // Hvis det er en spesifikk datatype den skal returnere, så må det defineres slik:
        static int DenneFunksjonenReturnererEtHelTall()
        {
            int etTall = 5;
            return etTall;
        }

        static int DenneFunksjonenTarInnToTall(int input1, int input2)
        {
            return input1 + input2; // her returneres summen av de to tallene sendt inn i metoden
        }

    }
}
