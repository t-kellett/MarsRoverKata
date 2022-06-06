namespace MarsRover
{
    public class Move
    {
        public static List<int> InDirection(char direction, List<int> coordinates, char facing)
        {
            if (direction == 'M')
            {
                if (facing == 'N') coordinates[1] += 1;
                if (facing == 'E') coordinates[0] += 1;
                if (facing == 'S') coordinates[1] -= 1;
                if (facing == 'W') coordinates[0] += 1;
            }
            return coordinates;
        }
    }
}