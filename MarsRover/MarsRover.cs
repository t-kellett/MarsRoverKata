namespace MarsRover
{
    public class MarsRover
    {
        private Queue<string> compassPoints;
        public MarsRover()
        {
            compassPoints = new Queue<string>(new[] { "N", "E", "S", "W" });
        }
        public string Execute(string directions)
        {
            int y = directions.Where(x => x == 'M').Count();

            if (y >= 10) y -= 10;

            int rightTurns = directions.Where(x => x == 'R').Count();

            for (int i = 0; i < rightTurns; i++)
            {
                compassPoints.Enqueue(compassPoints.Dequeue());
            }
            return $"0:{y}:{compassPoints.Peek()}";
        }
    }
}