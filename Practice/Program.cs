namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IdentifyShapeType(1);
            ShapeProperties properties = ShapeProperties.HasBorder | ShapeProperties.IsFilled;

            if ((properties & ShapeProperties.HasBorder) == ShapeProperties.HasBorder)
            {
                Console.WriteLine("The shape has a border.");
            }

        }

        static void IdentifyShapeType(int shapeTypeValue)
        {
            if (Enum.IsDefined(typeof(ShapeType), shapeTypeValue))
            {
                ShapeType shape = (ShapeType)shapeTypeValue;
                Console.WriteLine($"Shape type is: {shape}");
            }
            else
            {
                Console.WriteLine("Invalid shape type!");
            }
        }

    }

}
