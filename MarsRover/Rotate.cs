using System.Collections;

namespace MarsRover
{
    public class Rotate
    {
        public static char GetDirection(char turn, char previousDirection)
        {
            LinkedListNode<char> node = Compass().Find(previousDirection);
            char direction = node.Value;
            if (turn.Equals('R'))
            {
                direction = node.Next == null ? 'N' : node.Next.Value;
            }
            else
            {
                direction = node.Previous == null ? 'W' : node.Previous.Value;

            }
            return direction;
        }

        private static LinkedList<char> Compass()
        {
            return new LinkedList<char> (new char[] { 'N', 'E', 'S', 'W' });
        }
    }
}
