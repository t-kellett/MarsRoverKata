namespace MarsRover
{
    public class MarsRover
    {
        private Grid _grid;

        public MarsRover(Grid grid)
        {
            _grid = grid;
        }
        public string Execute(string directions)
        {
            int y = directions.Where(x => x == 'M').Count();
            y = y % _grid.MaxY;

            char compass = Rotate.GetFinalDirection(directions);

            return $"0:{y}:{compass}";
        }


    }
}