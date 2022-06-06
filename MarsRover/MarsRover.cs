namespace MarsRover
{
    public class MarsRover
    {
        private Grid _grid;
        private char _compass;
        private List<int> _coordinates;

        public MarsRover(Grid grid)
        {
            _grid = grid;
            _compass = 'N';
            _coordinates = new List<int> { 0, 0 };
        }
        public string Execute(string directions)
        {

            foreach (char instruction in directions)
            {
                _compass = Rotate.GetDirection(instruction, _compass);
                _coordinates = Move.InDirection(instruction, _coordinates, _compass);
            }

            return $"{_coordinates[0] + ":" + _coordinates[1]}:{_compass}";
        }
    }
}