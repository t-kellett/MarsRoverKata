using NUnit.Framework;
using System.Collections.Generic;

namespace MarsRover.Test
{
    public class RotateTest
    {
        private LinkedList<char> compass;

        [OneTimeSetUp]
        public void SetUp()
        {
            compass = new LinkedList<char>(new[] {'N', 'E', 'S', 'W'});
        }

        [Test]
        public void ShouldGetCorrectDirection()
        {
            Assert.AreEqual('W', Rotate.GetFinalDirection("L", compass));
        }
    }
}
