using System.Collections;

namespace MarsRover
{
    public class Rotate
    {
        public static char GetDirection(char turn, char previousDirection)
        {
            List<char> compass = GetCompass();
            if (turn.Equals('M')) return previousDirection;
            return turn.Equals('R') ? compass[compass.IndexOf(previousDirection) + 1] : compass[compass.IndexOf(previousDirection) - 1];

        }

        private static List<char> GetCompass()
        {
            return new List<char> { 'N', 'E', 'S', 'W' };
        }
    }
}
