using System;
using System.Linq;

namespace PersonnummerVerifier
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Begär användarinmatning
            Console.WriteLine("Ange personnummer (format: YYMMDDXXXX):");
            string input = Console.ReadLine();

            // Anropa metoden för att verifiera personnummer
            bool isValid = PersonnummerVerifier.VerifieraPersonnummer(input);

            // Visa resultatet
            Console.WriteLine(isValid ? "Personnumret är giltigt." : "Personnumret är ogiltigt.");
        }
    }
}
