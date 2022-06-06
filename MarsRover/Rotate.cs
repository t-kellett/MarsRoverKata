using System.Collections;

namespace MarsRover
{
    public class Rotate
    {
        public static char GetFinalDirection(string directions, LinkedList<char> points)
        {
            char direction = LeftOrRight(directions);
            int Turns = directions.Where(x => x == direction).Count();
            for (int i = 0; i < Turns; i++)
            {
                if (direction == 'R')
                {
                    var first = points.First;
                    points.RemoveFirst();
                    points.AddLast(first);
                }
                else if (direction == 'L')
                {
                    var last = points.Last;
                    points.RemoveLast();
                    points.AddFirst(last);
                }
            }
            return points.First.Value;
        }

        private static char LeftOrRight(string directions)
        {
            char direction = directions.Count() > 0 ? directions.Distinct().ToList()[0] : 'N';
            return direction;
        }

    }
}
