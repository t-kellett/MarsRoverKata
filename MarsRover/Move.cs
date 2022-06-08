namespace MarsRover
{
    public class Move
    {
        public static Dictionary<char, int> InDirection(Dictionary<char, int> coordinates, char facing, Grid grid)
        {
            if (facing == 'N') coordinates['Y'] += 1;
            if (facing == 'E') coordinates['X'] += 1;
            if (facing == 'W') coordinates['X'] -= 1;
            if (facing == 'S') coordinates['Y'] -= 1;

            return Wrap(coordinates, grid);
        }


        private static Dictionary<char, int> Wrap(Dictionary<char, int> coordinates, Grid grid)
        {
            if (coordinates['X'] > grid.MaxX) coordinates['X'] -= grid.MaxX;
            if (coordinates['Y'] > grid.MaxX) coordinates['Y'] -= grid.MaxY;

            return coordinates;
        }
    }
}