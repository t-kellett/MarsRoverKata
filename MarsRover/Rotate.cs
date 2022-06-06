using System.Collections;

namespace MarsRover
{
    public class Rotate
    {
        public static char GetFinalDirection(string directions)
        {
            List<char> turns = ExtractTurns(directions);
            return turns.Count() == 0 ? 'N' : CompassTurner(turns);
        }

        private static List<char> ExtractTurns(string directions)
        {
            List<char> onlyRotates = directions.Where(x => x == 'L' || x == 'R').ToList();
            return onlyRotates;
        }

        private static LinkedList<char> GetCompass()
        {
            return new LinkedList<char>(new[] { 'N', 'E', 'S', 'W' });
        }

        private static char CompassTurner(List<char> turns)
        {
            LinkedList<char> compass = GetCompass();
            foreach (char turn in turns)
            {
                if (turn == 'R')
                {
                    var first = compass.First;
                    compass.RemoveFirst();
                    compass.AddLast(first);
                }
                else if (turn == 'L')
                {
                    var last = compass.Last;
                    compass.RemoveLast();
                    compass.AddFirst(last);
                }
            }
            return compass.First.Value;
        }
    }
}
