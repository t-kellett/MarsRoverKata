using NUnit.Framework;
using Moq;
using System.Collections.Generic;

namespace MarsRover.Test
{
    public class MoveTests
    {
        private Dictionary<char, int> coordinates;
        private Grid grid;
        [SetUp]
        public void Setup()
        {
            grid = new Grid();
            coordinates = new Dictionary<char, int> { ['X'] = 0, ['Y'] = 0 };
        }

        [Test]
        public void ShouldReturnCorrectXandYforMovingEastFromStart()
        {
            List<int> expected = new List<int> { 1, 0 };
            Assert.AreEqual(expected, Move.InDirection(coordinates, 'E', grid));
        }

        [Test]
        public void ShouldWrapRoundAGridGoingNorth()
        {
            Dictionary<char, int> expected = new Dictionary<char, int> { ['X'] = 0, ['Y'] = 1 };
            Dictionary<char, int> result = new Dictionary<char, int> { ['X'] = 0, ['Y'] = 0 };

            for (int i = 0; i <= 10; i++)
            {
                result = Move.InDirection(coordinates, 'N', grid);
            }

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void ShouldWrapRoundAGridGoingSouth()
        {
            List<int> expected = new List<int> { 0, 9 };

            Assert.AreEqual(expected, Move.InDirection(coordinates, 'S', grid));
        }

        [Test]
        public void ShouldWrapRoundAGridGoingSouth4Times()
        {
            Dictionary<char, int> expected = new Dictionary<char, int> { ['X'] = 0, ['Y'] = 6 };

            for (int i = 0; i < 4 ; i++)
            {
                coordinates = Move.InDirection(coordinates, 'S', grid);
            }

            Assert.AreEqual(expected, coordinates);
        }
    }
}