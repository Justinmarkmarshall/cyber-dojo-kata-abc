using Moq;
using NUnit.Framework;

namespace AbcProblem.Tests.Uni
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("A", true)]
        [TestCase("BARK", true)]
        [TestCase("BARK", true)]
        [TestCase("BOOK", false)]
        [TestCase("TREAT", true)]
        [TestCase("COMMON", false)]
        [TestCase("SQUAD", true)]
        [TestCase("CONFUSE", true)]         

        public void Give_a_word_then_should_calculate_if_it_can_be_made_with_blocks(string word, bool expectedResult)
        {
            var calculator = new Mock<WordCalculator>();

            var result = calculator.Object.CalculateIfBlocksCanMake(word.ToLower());
            Assert.AreEqual(expectedResult, result);
        }
    }
}