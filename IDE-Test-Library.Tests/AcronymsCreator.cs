namespace IDE_Test_Library.Tests;

public class Tests
{
    [TestFixture]
    public class AcronymsCreatorTests
    {
        [TestCase("Don't repeat yourself", "DRY")]
        [TestCase("Asynchronous Javascript and XML", "AJAX")]
        [TestCase("Complementary metal-oxide semiconductor	", "CMS")]
        [TestCase("Don't", "D")]
        [TestCase("", "")]
        [TestCase(null, "")]
        public void GetAcronymOfSentence_ReturnsCorrectAcronym_WithBaseSentences(string sentence, string acronym)
        {
            //Arrange
            var acronymsCreator = new AcronymsCreator();

            //Act
            var result = acronymsCreator.GetAcronymOfSentence(sentence);

            //Assert
            Assert.That(result, Is.EqualTo(acronym));
        }

        [TestCase("Don't repeat yourself", "DRY")]
        [TestCase("Asynchronous Javascript and XML", "AJAX")]
        [TestCase("Complementary metal-oxide semiconductor	", "CMOS")]
        [TestCase("Don't", "D")]
        [TestCase("", "")]
        [TestCase(null, "")]
        public void GetAcronymOfSentence_ReturnsCorrectAcronym_WithExtendedSeparators(string sentence, string acronym)
        {
            //Arrange
            var separators = new char[] { ' ', '-' };
            var acronymsCreator = new AcronymsCreator(separators);

            //Act
            var result = acronymsCreator.GetAcronymOfSentence(sentence);

            //Assert
            Assert.That(result, Is.EqualTo(acronym));
        }
    }
}
