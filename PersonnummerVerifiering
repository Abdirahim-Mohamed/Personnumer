using System;

namespace PersonnummerVerifiering
{
    public class Validator
    {
        public static bool ÄrPersonnummerKorrekt(string personnummer)
        {
            personnummer = personnummer.Replace("-", "").Replace(" ", "");
            if (personnummer.Length != 12 && personnummer.Length != 10)
                return false;

            // Omvandla till 10-siffrig variant
            if (personnummer.Length == 12)
                personnummer = personnummer.Substring(2);
