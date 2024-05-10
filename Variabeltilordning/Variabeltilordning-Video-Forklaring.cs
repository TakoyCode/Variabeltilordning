using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variabeltilordning
{
    internal class Variabeltilordning_Video_Forklaring
    {
        int tall = 1;

        float desimalTall = 1.01F;
        double desimalTall2 = 1.01D;
        decimal desimalTall3 = 1.01M;

        char bokstav = 'a';
        string tekst = "Hei";

        bool santUsant = true;

        int[] tallArrayy = { 1, 2, 3 };
        string[] tekstArray = {"hei", "på", "deg"};

        List<int> listeMedTall = new List<int>(); // Lager en liste med tall


        public string ReturnString()
        {
            return tekst;
        }

        public int ReturnWholeNumber()
        {
            return tall;
        }

        public double ReturnDouble()
        {
            return desimalTall2;
        }
        public bool TrueFalse()
        {
            return santUsant;
        }

        public void Run()
        {
            Console.WriteLine($"Dette er en string : {ReturnString()}");
            Console.WriteLine($"Dette er en int : {ReturnWholeNumber()}");
            Console.WriteLine($"Dette er en double : {ReturnDouble()}");
            Console.WriteLine($"Dette er en bool : {TrueFalse()}");
        }

    }
}
