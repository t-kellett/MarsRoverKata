using NUnit.Framework;
using System.Collections.Generic;

namespace MarsRover.Test
{
    public class RotateTest
    {

        [TestCase('W', "L")]
        [TestCase('E', "R")]
        [TestCase('S', "LLLLRR")]
        [TestCase('N', "RLRLRLLRRRRR")]
        [TestCase('W', "RRR")]
        public void ShouldGetCorrectDirection(char output, string input)
        {
            Assert.AreEqual(output, Rotate.GetFinalDirection(input));
        }
    }
}
