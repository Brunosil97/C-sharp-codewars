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
    }
}