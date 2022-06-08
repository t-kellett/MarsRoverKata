namespace MarsRover
{
    public class MarsRover
    {
        private Grid _grid;
        private char _compass;
        private Dictionary<char, int> _coordinates;

        public MarsRover(Grid grid)
        {
            _grid = grid;
            _compass = 'N';
            _coordinates = new Dictionary<char, int> { ['X'] = 0, ['Y'] = 0 };
        }
        public string Execute(string directions)
        {
            foreach (char instruction in directions)
            {
                if (instruction == 'M') _coordinates = Move.InDirection(_coordinates, _compass, _grid);
                if (instruction != 'M') _compass = Rotate.GetDirection(instruction, _compass);
            }

            return $"{_coordinates['X'] + ":" + _coordinates['Y']}:{_compass}";
        }
    }
}