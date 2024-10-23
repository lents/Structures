namespace Structures
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            StructExample struct1 = new StructExample { Value = 1 };
            StructExample struct2 = struct1;  // struct2 is a copy of struct1
            struct2.Value = 2;

            ClassExample class1 = new ClassExample { Value = 1 };
            ClassExample class2 = class1;  // class2 refers to the same instance as class1
            class2.Value = 2;

            Console.WriteLine(struct1.Value);  // Output: 1 (struct2 did not affect struct1)
            Console.WriteLine(class1.Value);   // Output: 2 (class2 changed class1)

            //Rectangle rect = new Rectangle(10, 20);
            //Console.WriteLine($"Area of rectangle: {rect.CalculateArea()}");

        }
    }
}
