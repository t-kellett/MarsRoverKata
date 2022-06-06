using NUnit.Framework;
using Moq;

namespace MarsRover.Test
{
    public class MovementTests
    {
        private MarsRover rover;
        private Grid grid;

        [SetUp]
        public void Setup()
        {
            grid = new Grid();
            rover = new MarsRover(grid);
        }


        [TestCase("M", "0:1:N")]
        [TestCase("MMM", "0:3:N")]
        [TestCase("MMMMMMMMMM", "0:0:N")]
        [TestCase("MMMMMMMMMMMMMMMMMMMM", "0:0:N")]
        [TestCase("", "0:0:N")]
        public void ShouldMoveNorth(string input, string output)
        {
            Assert.AreEqual(output, rover.Execute(input));
        }

        [TestCase("R", "0:0:E")]
        [TestCase("RR", "0:0:S")]
        [TestCase("RRR", "0:0:W")]
        [TestCase("RRRR", "0:0:N")]
        public void ShouldRotateRight(string input, string output)
        {
            Assert.AreEqual(output, rover.Execute(input));
        }

        [TestCase("L", "0:0:W")]
        public void ShouldRotateLeft(string input, string output)
        {
            Assert.AreEqual(output, rover.Execute(input));
        }
    }
}