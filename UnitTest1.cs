using Xunit;
using PersonnummerVerifier;

namespace PersonnummerVerifier.Tests
{
    public class PersonnummerVerifierTests
    {
        [Theory]
        [InlineData("19850615-1234", true)] // Giltigt personnummer
        [InlineData("19850615 1234", true)] // Giltigt personnummer utan bindestreck
        [InlineData("1985-06-15 1234", true)] // Giltigt personnummer med bindestreck
        [InlineData("19850615-1235", false)] // Ogiltigt personnummer (checksumma stämmer inte)
        [InlineData("abcd", false)] // Ogiltigt format
        public void TestVerifieraPersonnummer(string personnummer, bool expectedResult)
        {
            // Anropa metoden för att verifiera personnummer
            var result = PersonnummerVerifier.VerifieraPersonnummer(personnummer);

            // Kontrollera om resultatet matchar förväntat resultat
            Assert.Equal(expectedResult, result);
        }
    }
}
