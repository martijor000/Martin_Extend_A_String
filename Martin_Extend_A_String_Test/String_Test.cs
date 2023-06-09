using Martin_Extend_A_String;

namespace Martin_Extend_A_String_Test
{
    //Arrange
    //Act
    //Assert

    [TestClass]
    public class String_Test
    {
        [TestMethod]
        public void Pal0indromeStringIsTrue()
        {
            string test = "racecar";

            Assert.IsTrue(test.IsPalindrome());
        }

        [TestMethod]
        public void Pal0indromeStringIsFalse()
        {
            string test = "jordan";

            Assert.IsFalse(test.IsPalindrome());
        }


        [TestMethod]
        public void ReverseStringCaseSensitive()
        {
            string test = "Jordan";
            string reverse = "Nadroj";

            Assert.AreEqual(test.ReverseString(true), reverse);
        }

        [TestMethod]
        public void ReverseStringCaseInsensitive()
        {
            string test = "Jordan";
            string reverse = "nadroJ";

            Assert.AreEqual(test.ReverseString(false), reverse);
        }

        [TestMethod]
        public void RemoveDuplicates()
        {
            string test = "icecream";
            string rvdDup = "iceram";

            Assert.AreEqual(test.RemoveDuplicates(), rvdDup);
        }

        [TestMethod]
        public void CountOccurencesStringPatternWithStringMatched()
        {
            string test = "bananas";
            string pattern = "an";

            Assert.AreEqual(test.CountOccurrences(pattern), 2);

        }

        [TestMethod]
        public void CountOccurencesStringPatternWithStringNotMatched()
        {
            string test = "strawberries";
            string pattern = "an";

            Assert.AreEqual(test.CountOccurrences(pattern), -1);

        }

        [TestMethod]
        public void CountOccurencesByTypeMax()
        {
            string test = "John Doe";
            OccurrenceType OT = OccurrenceType.MaxOccurrence;

            Assert.AreEqual(test.CountOccurrences(OT), 2);
        }
        [TestMethod]
        public void CountOccurencesByTypeMin()
        {
            string test = "John Doe";
            OccurrenceType OT = OccurrenceType.MinOccurrence;


            Assert.AreEqual(test.CountOccurrences(OT), 1);
        }
        [TestMethod]
        public void CountOccurencesByTypeMaxVowels()
        {
            string test = "John Doe";
            OccurrenceType OT = OccurrenceType.MaxOccurrenceVowels;


            Assert.AreEqual(test.CountOccurrences(OT), 2);
        }
        [TestMethod]
        public void CountOccurencesByTypeMinVowels()
        {
            string test = "John Doe";
            OccurrenceType OT = OccurrenceType.MinOccurrenceVowels;


            Assert.AreEqual(test.CountOccurrences(OT), 1);
        }
    }
}