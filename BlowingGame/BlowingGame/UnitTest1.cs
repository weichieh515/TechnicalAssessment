using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace BlowingGame
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void input()
        {
            string input = "1,1,1,1";
            List<Round> actual = new List<Round>();
            List<Round> expected = new List<Round>();

            BlowingGame game = new BlowingGame();
            actual = game.parseToRound(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void isStrike()
        {                       
            BlowingGame game = new BlowingGame();
            var round = new Round();
            round.first = 10;
            round.second = 0;
            bool actual = game.isStrike(round);
            bool expected = true;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void isSpare()
        {
            BlowingGame game = new BlowingGame();
            bool actual = game.isSpare();
            bool expected = true;
            Assert.AreEqual(expected, actual);
        }


    }
}
