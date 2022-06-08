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
        [TestCase("MMMMMMMMMMM", "0:0:N")]
        [TestCase("MMMMMMMMMMMMMMMMMMMMM", "0:0:N")]
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
        [TestCase("LL", "0:0:S")]
        [TestCase("LLL", "0:0:E")]
        [TestCase("LLLL", "0:0:N")]
        public void ShouldRotateLeft(string input, string output)
        {
            Assert.AreEqual(output, rover.Execute(input));
        }

        [TestCase("LLMMM", "0:7:S")]
        [TestCase("RRM", "0:9:S")]
        [TestCase("RRMMMMMMMMMMMMMMMMMMM", "0:1:S")]
        public void ShouldMoveSouth(string input, string output)
        {
            Assert.AreEqual(output, rover.Execute(input));
        }

        [TestCase("1:0:E", "RM")]
        public void ShouldMoveEast(string output, string input)
        {
            Assert.AreEqual(output, rover.Execute(input));
        }
    }
}