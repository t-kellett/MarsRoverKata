namespace MarsRover
{
    public class Grid
    {
        public int MaxY { get; }
        public int MaxX { get; }
        public Grid(int MaxY = 10, int MaxX = 10)
        {
            this.MaxY = MaxY;
            this.MaxX = MaxX;
        }
    }
}