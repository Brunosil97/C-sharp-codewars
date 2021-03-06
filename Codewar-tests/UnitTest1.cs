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

        [TestCase("ABC", "WUBWUBABCWUB")]
        [TestCase("R L", "RWUBWUBLWUB")]
        public void CheckSongDecoder(string result, string sentence)
        {
            Kata _kata = new Kata();
            Assert.AreEqual(result, _kata.SongDecoder(sentence));
        }

        [TestCase('a', "a")]
        [TestCase('t', "stress")]
        [TestCase('e', "moonmen")]
        public void CheckFirstNonRepeat(char result, string sentence)
        {
            Kata _kata = new Kata();
            Assert.AreEqual(result, _kata.FirstNonRepeat(sentence));
        }

        [TestCase("no one likes this", new string[0])]
        [TestCase("Peter likes this", new string[] { "Peter" })]
        public void CheckWhoLikesPost(string answer, string[] names)
        {
            Kata _kata = new Kata();
            Assert.AreEqual(answer, _kata.WhoLikedIt(names));
        }

        [TestCase(true, "()")]
        [TestCase(false, "[(])")]
        public void CheckTrueOrFalseBrace(bool answer, string braces)
        {
            Kata _kata = new Kata();
            Assert.AreEqual(answer, _kata.ValidBraces(braces));
        }
        
        [TestCase("20th", "1935")]
         public void CheckIfCorrectCentury(string answer, string year)
        {
            Kata _kata = new Kata();
            Assert.AreEqual(answer, _kata.WhatCentury(year));
        }
    }

    [TestFixture]
    public class StretegyTests
    {
        [Test]
        public void _0_WalkMove()
        {
            IUnit viking = new Viking();

            viking.Move();
            Assert.AreEqual(1, viking.Position);
            viking.Move();
            Assert.AreEqual(2, viking.Position);
        }

        [Test]
        public void _1_FlyMove()
        {
            IUnit viking = new Viking();
            viking.MoveBehavior = new Fly();

            viking.Move();
            Assert.AreEqual(10, viking.Position);
            viking.Move();
            Assert.AreEqual(20, viking.Position);
        }

        [Test]
        public void _2_MixMove()
        {
            IUnit viking = new Viking();

            viking.Move();
            Assert.AreEqual(1, viking.Position);

            viking.MoveBehavior = new Fly();
            viking.Move();
            Assert.AreEqual(11, viking.Position);
        }
    }
}
