namespace MarsRover
{
    public class MarsRover
    {
        private LinkedList<char> compassPoints;
        private Grid _grid;

        public MarsRover(Grid grid)
        {
            compassPoints = new LinkedList<char>(new[] { 'N', 'E', 'S', 'W' });
            _grid = grid;
        }
        public string Execute(string directions)
        {
            int y = directions.Where(x => x == 'M').Count();
            y = y % _grid.MaxY;

            char compass = Rotate.GetFinalDirection(directions, compassPoints);

            return $"0:{y}:{compass}";
        }


    }
}