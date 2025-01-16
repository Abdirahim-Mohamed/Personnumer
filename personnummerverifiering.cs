 // Validera datum
            string datumDel = personnummer.Substring(0, 6);
            if (!DateTime.TryParseExact(datumDel, "yyMMdd", null, System.Globalization.DateTimeStyles.None, out _))
                return false;

            // Kontrollsiffra via Luhn-algoritmen
            string siffror = personnummer.Substring(0, 9);
            int kontrollSiffra = int.Parse(personnummer[9].ToString());
            return KontrolleraLuhn(siffror, kontrollSiffra);
        }

        private static bool KontrolleraLuhn(string siffror, int kontrollSiffra)
        {
            int summa = 0;
            for (int i = 0; i < siffror.Length; i++)
            {
                int siffra = int.Parse(siffror[i].ToString());
                if (i % 2 == 0)
                {
                    siffra *= 2;
                    if (siffra > 9)
                        siffra -= 9;
                }
                summa += siffra;
            }
            return (10 - (summa % 10)) % 10 == kontrollSiffra;
        }
    }
}
