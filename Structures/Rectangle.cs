namespace Structures
{
    public struct Rectangle
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public int CalculateArea()
        {
            return Width * Height;
        }
    }  

}
