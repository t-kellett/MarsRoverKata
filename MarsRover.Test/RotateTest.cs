using NUnit.Framework;
using System.Collections.Generic;

namespace MarsRover.Test
{
    public class RotateTest
    {

        [TestCase('W', 'L', 'N')]
        [TestCase('W', 'R', 'S')]

        public void ShouldGetCorrectDirection(char output, char turn, char previousDirection)
        {
            Assert.AreEqual(output, Rotate.GetDirection(turn, previousDirection));
        }
    }
}
