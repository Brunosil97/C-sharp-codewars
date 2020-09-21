using NUnit.Framework;
using C_sharp_codewars;

namespace Codewar_tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [TestCase(3, new int[] {2, 6, 8, -10, 3})]
        [TestCase(7, new int[] { 2, 6, 8, -10, 7 })]
        [TestCase(20, new int[] { 20, 45, 57, 69, 111 })]

        public void FindOddEvenNumber(int answer, int[] array)
        {
            Kata _kata = new Kata();
            Assert.AreEqual(answer, _kata.Find(array));
        }

        [TestCase(true, "The quick brown fox jumps over the lazy dog.")]
        public void CheckIfSentenceIsPangram(bool answer, string sentence)
        {
            Kata _kata = new Kata();
            Assert.AreEqual(answer, _kata.IsPangram(sentence));
        }

        [TestCase(0, "")]
        [TestCase(0, "abcde")]
        [TestCase(2, "aabBcde")]
        [TestCase(1, "Indivisibility")]
        public void CheckDuplicateCharacterInString(int result, string sentence)
        {
            Kata _kata = new Kata();
            Assert.AreEqual(result, _kata.DuplicateCount(sentence));
        }

    }
}