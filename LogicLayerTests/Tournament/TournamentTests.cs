using Microsoft.VisualStudio.TestTools.UnitTesting;
using LogicLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogicLayer.Tests
{
    [TestClass()]
    public class TournamentTests
    {
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException), "Teams have to be submitted")]
        public void CalculateRoundRightPositiveIntTest()
        {
            //arrange
            int TeamCount = 0;
            Tournament tournament = new Tournament();
            //act
            int result = tournament.CalculateRounds(TeamCount);           
        }
        [TestMethod()]
        [ExpectedException(typeof(Exception), "Teamcount must be even")]
        public void CalculateRoundWrongPositiveIntTest()
        {
            //arrange
            int TeamCount = 3;
            Tournament tournament = new Tournament();
            //act
            int result = tournament.CalculateRounds(TeamCount);         
        }
        [TestMethod()]
        [ExpectedException(typeof(Exception), "Tournament already filled")]
        public void CalculateRoundPositiveTooLargeIntTest()
        {
            //arrange
            int TeamCount = int.MaxValue;
            Tournament tournament = new Tournament();
            //act
            int result = tournament.CalculateRounds(TeamCount);
        }
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException), "Teams have to be submitted")]
        public void CalculateRoundNegativeIntTest()
        {
            //arrange
            int TeamCount = -4;
            Tournament tournament = new Tournament();
            //act
            int result = tournament.CalculateRounds(TeamCount);           
        }
        

    }
}